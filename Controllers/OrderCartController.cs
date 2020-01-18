using CafeO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CafeO.Controllers
{
    public class OrderCartController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        //
        // GET: /OrderCart/
        public ActionResult Index()
        {
            var cart = OrderCart.GetCart(this.HttpContext);

            // Set up our ViewModel
            var viewModel = new OrderCartViewModel
            {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetTotal()
            };
            // Return the view
            return View(viewModel);
        }
        //
        // GET: /Store/AddToCart/5
        public ActionResult AddToCart(int id)
        {
            // Retrieve the product from the database
            var addedProduct = db.Products
                .Single(product => product.Id == id);

            // Add it to the shopping cart
            var cart = OrderCart.GetCart(this.HttpContext);

            cart.AddToCart(addedProduct);

            // Go back to the main store page for more shopping
            return RedirectToAction("Index");
        }
        //
        // AJAX: /OrderCart/RemoveFromCart/5
        [HttpPost]
        public ActionResult RemoveFromCart(int id)
        {
            // Remove the item from the cart
            var cart = OrderCart.GetCart(this.HttpContext);

            // Get the name of the product to display confirmation
            string productName = db.CartItems
                .Single(item => item.CartItemId == id).Product.Name;

            // Remove from cart
            int itemCount = cart.RemoveFromCart(id);

            // Display the confirmation message
            var results = new OrderCartRemoveViewModel
            {
                Message = Server.HtmlEncode(productName) +
                    " has been removed from your shopping cart.",
                CartTotal = cart.GetTotal(),
                CartCount = cart.GetCount(),
                ItemCount = itemCount,
                DeleteId = id
            };
            return Json(results);
        }
        //
        // GET: /OrderCart/CartSummary
        [ChildActionOnly]
        public ActionResult CartSummary()
        {
            var cart = OrderCart.GetCart(this.HttpContext);

            ViewData["CartCount"] = cart.GetCount();
            return PartialView("_CartSummary");
        }
    }
}