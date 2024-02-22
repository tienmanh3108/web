using Microsoft.AspNetCore.Mvc;
using System.IO; //thao tac voi file, thu muc
using Newtonsoft.Json;//thao tac voi file json
using System.Data;//su dung DataTalbe, DataRow
using System.Data.SqlClient;//su dung SqlConnection, DataAdapter...
using X.PagedList;//su dung cac ham phan trang
using BC = BCrypt.Net;//doi tuong ma hoa csdl, gan doi tuong nay thanh BC
using project.Models;//nhan dien cac file trong thu muc Models
using System.Security.Cryptography;

namespace project.Controllers
{
    public class ProductsController : Controller
    {
        public MyDbContext db = new MyDbContext();
        public IActionResult Category(int? id, int? page)
        {
            int _CategoryId = id ?? 0;
            //khai bao so ban ghi tren mot trang
            ViewBag.CategoryId = _CategoryId;  
            int pageSize = 50;
            //tinh so trang
            int pageNumber = page ?? 1;
            List<ItemProduct> list_record = (from item in db.Products orderby item.Id descending select item).ToList();
            if (_CategoryId > 0)
            {
                list_record = (from item_product in list_record join item_category_product in db.CategoriesProducts on item_product.Id equals item_category_product.ProductId join item_category in db.Categories on item_category_product.CategoryId equals item_category.Id where item_category.Id == _CategoryId select item_product).ToList();
            }
            if (!string.IsNullOrEmpty(Request.Query["order"]))
            {
                string order = Request.Query["order"];
                switch(order)
                {
                    case "name-asc":
                        list_record = list_record.OrderBy(item => item.Name).ToList();
                        break;
                    case "name-desc":
                        list_record = list_record.OrderByDescending(item => item.Name).ToList();
                        break;
                    case "price-asc":
                        list_record = list_record.OrderBy(item => item.Price).ToList();
                        break;
                    case "price-desc":
                        list_record = list_record.OrderByDescending(item => item.Price).ToList();
                        break;
                }
            }
            return View(list_record.ToPagedList(pageNumber, pageSize));
        }
        public IActionResult Detail(int? id)
        {
            int _id = id ?? 0;
            ItemProduct item_product = db.Products.Where(item => item.Id == _id).FirstOrDefault();
            return View(item_product);
        }
        public IActionResult Rating(int? id)
        {
            int _id = id ?? 0;
            int star = Convert.ToInt32(Request.Query["star"]);
            ItemRating record = new ItemRating();
            record.ProductId = _id;
            record.Star = star;
            db.Add(record);
            db.SaveChanges();
            return Redirect("/Products/Details/" + _id);
        }
    }
}