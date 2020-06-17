using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThuongMaiDienTu.Models;

namespace ThuongMaiDienTu.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(OrderInfoModel data)
        {
            try
            {
                if (String.IsNullOrEmpty(data.CustomerPhone) || String.IsNullOrEmpty(data.CustomerName) || String.IsNullOrEmpty(data.CustomerAddress)) throw new Exception("Vui lòng điền đầy đủ thông tin trước khi đặt hàng");
                var list = (Session["cart"] as List<PRODUCT>);
                if (list is null) throw new Exception("Đơn hàng rỗng không thể thanh toán");
                if (list.Count < 1) throw new Exception("Đơn hàng rỗng không thể thanh toán");

                using (THUONGMAIDIENTUEntities db = new THUONGMAIDIENTUEntities())
                {
                    // tìm và update khách nếu ko thì tạo
                    var customer = db.CUSTOMERs.Where(x => x.CustomerPhone.Equals(data.CustomerPhone)).FirstOrDefault();
                    if (customer is null) customer = new CUSTOMER();
                    customer.CustomerPhone = data.CustomerPhone;
                    customer.CustomerAddress = data.CustomerAddress;
                    customer.CustomerName = data.CustomerName;
                    customer.CustomerEmail = data.CustomerEmail;
                    if (customer.IdCustomer < 1) db.CUSTOMERs.Add(customer);
                    db.SaveChanges();

                    ORDER o = new ORDER();
                    o.IdCustomer = customer.IdCustomer;
                    o.DateOrder = DateTime.Now;
                    o.DateDelivery = DateTime.Now;
                    o.OrderComment = data.CustomerComment;
                    o.IdPayment = data.PaymentMethod;
                    o.IdStatus = 1;
                    int total = 0;

                    foreach (var p in list)
                    {
                        total += (int)p.ProductPrice;
                        PRODUCT_ORDER po = new PRODUCT_ORDER();
                        po.Count = 1;
                        po.Discount = 0;
                        po.IdProduct = p.IdProduct;
                        po.Price = p.ProductPrice;
                        o.PRODUCT_ORDER.Add(po);
                    }

                    o.Total = total;

                    db.ORDERs.Add(o);
                    db.SaveChanges();

                   
                    TempData["id"] = o.IdOrder;
                    return RedirectToAction("Success");
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }
            return View();
        }


        public ActionResult Success()
        {
            if (TempData["id"] is null) return RedirectToAction("Index", "Home");
            ViewBag.Id = TempData["id"].ToString();
            Session["cart"] = null;
            return View();
        }
        public ActionResult Fail()
        {
            return View();
        }


      
    }
}