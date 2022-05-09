using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RecordStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace RecordStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MyContext _context;

        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }

        // Index and Home routes
        public IActionResult Index()
        {
            ViewBag.AllRecords = _context.Records.OrderBy(a => a.Title).ToList();
            if (HttpContext.Session.GetInt32("UserId") != null)
            {
                ViewBag.LoggedInUser = _context.Users.FirstOrDefault(a => a.UserId == (int)HttpContext.Session.GetInt32("UserId"));
            }
            if (HttpContext.Session.GetString("Search") != null)
            {
                ViewBag.Search = HttpContext.Session.GetString("Search");
            }
            return View();
        }

        [HttpGet("home")]
        public IActionResult Home()
        {
            HttpContext.Session.SetString("Search", "");
            return RedirectToAction("Index");
        }

        [HttpPost("records/search")]
        public IActionResult RecordSearch(string Search)
        {
            if (Search == null)
            {
                HttpContext.Session.SetString("Search", "");
                return RedirectToAction("Index");
            }
            else
            {
            }
            HttpContext.Session.SetString("Search", Search);
            return RedirectToAction("Index");
        }

        // Login, Registration and Logout routes

        [HttpGet("register")]
        public IActionResult Register()
        {
            ViewBag.AllUsers = _context.Users.ToList();
            return View();
        }

        [HttpPost("users/register")]
        public IActionResult CreateUser(User newUser)
        {
            if (ModelState.IsValid)
            {   
                if (_context.Users.Any(a => a.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email address is already in use.");
                    return View("Register");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                _context.Add(newUser);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("UserId", newUser.UserId);
                HttpContext.Session.SetString("UserType", newUser.UserType);
                return RedirectToAction("Index");
            }
            ViewBag.AllUsers = _context.Users.ToList();
            return View("Register");
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("users/login")]
        public IActionResult LoginUser(LoginUser loginSubmission)
        {
            if (ModelState.IsValid)
            {
                User userInDb = _context.Users.FirstOrDefault(a => a.Email == loginSubmission.LoginEmail);
                if (userInDb == null)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
                    return View("Login");
                }
                PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(loginSubmission, userInDb.Password, loginSubmission.LoginPassword);
                if (result == 0)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
                    return View("Login");
                }
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                HttpContext.Session.SetString("UserType", userInDb.UserType);
                if (userInDb.UserType == "Administrator")
                {
                    return RedirectToAction("AdminDashboard");
                }
                return RedirectToAction("Index");
            }
            return View("Login");
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        // Admin routes

        [HttpGet("/admin/dashboard")]
        public IActionResult AdminDashboard()
        {
            if (HttpContext.Session.GetString("UserType") != "Administrator")
            {
                return RedirectToAction("Index");
            }
            if (HttpContext.Session.GetString("Choice") != null)
            {
                ViewBag.Choice = HttpContext.Session.GetString("Choice");
            }
            ViewBag.LoggedInUser = _context.Users.FirstOrDefault(a => a.UserId == (int)HttpContext.Session.GetInt32("UserId"));
            ViewBag.AllRecords = _context.Records.ToList();
            ViewBag.AllOrders = _context.Orders.Include(a => a.Buyer).Include(b => b.Record).ToList();
            return View();
        }

        [HttpPost("admin/choice")]
        public IActionResult AdminChoice(string Choice)
        {
            if (HttpContext.Session.GetString("UserType") != "Administrator")
            {
                return RedirectToAction("Index");
            }
            HttpContext.Session.SetString("Choice", Choice);
            return RedirectToAction("AdminDashboard");
        }

        [HttpGet("records/new")]
        public IActionResult NewRecord()
        {
            if (HttpContext.Session.GetString("UserType") != "Administrator")
            {
                return RedirectToAction("Index");
            }
            ViewBag.LoggedInUser = _context.Users.FirstOrDefault(a => a.UserId == (int)HttpContext.Session.GetInt32("UserId"));
            return View();
        }

        [HttpPost("records/add")]
        public IActionResult AddRecord(Record newRecord)
        {
            if (HttpContext.Session.GetString("UserType") != "Administrator")
            {
                return RedirectToAction("Index");
            }
            if (ModelState.IsValid)
            {
                _context.Add(newRecord);
                _context.SaveChanges();
                return RedirectToAction("AdminDashboard");
            }
            ViewBag.LoggedInUser = _context.Users.FirstOrDefault(a => a.UserId == (int)HttpContext.Session.GetInt32("UserId"));
            return View("NewRecord");
        }

        [HttpGet("records/edit/{recordId}")]
        public IActionResult EditRecord(int recordId)
        {
            if (HttpContext.Session.GetString("UserType") != "Administrator")
            {
                return RedirectToAction("Index");
            }
            Record record = _context.Records.FirstOrDefault(a => a.RecordId == recordId);
            ViewBag.LoggedInUser = _context.Users.FirstOrDefault(a => a.UserId == (int)HttpContext.Session.GetInt32("UserId"));
            return View(record);
        }

        [HttpPost("records/update/{recordId}")]
        public IActionResult UpdateRecord(int recordId, Record updatedRecord)
        {
            if (HttpContext.Session.GetString("UserType") != "Administrator")
            {
                return RedirectToAction("Index");
            }
            Record oldRecord = _context.Records.FirstOrDefault(a => a.RecordId == recordId);
            if (ModelState.IsValid)
            {
                oldRecord.Title = updatedRecord.Title;
                oldRecord.Artist = updatedRecord.Artist;
                oldRecord.Cover = updatedRecord.Cover;
                oldRecord.Genre = updatedRecord.Genre;
                oldRecord.Price = updatedRecord.Price;
                oldRecord.Quantity = updatedRecord.Quantity;
                oldRecord.Spotify = updatedRecord.Spotify;
                oldRecord.UpdatedAt = DateTime.Now;
                _context.SaveChanges();
                return RedirectToAction("AdminDashboard");
            }
            ViewBag.LoggedInUser = _context.Users.FirstOrDefault(a => a.UserId == (int)HttpContext.Session.GetInt32("UserId"));
            return View("EditRecord", updatedRecord);
        }

        [HttpGet("records/delete/{recordId}")]
        public IActionResult DeleteRecord(int recordId)
        {
            if (HttpContext.Session.GetString("UserType") != "Administrator")
            {
                return RedirectToAction("Index");
            }
            Record RetrievedRecord = _context.Records.SingleOrDefault(a => a.RecordId == recordId);
            _context.Records.Remove(RetrievedRecord);
            _context.SaveChanges();
            return RedirectToAction("AdminDashboard");
        }

        [HttpGet("orders/delete/{orderId}")]
        public IActionResult DeleteOrder(int orderId)
        {
            if (HttpContext.Session.GetString("UserType") != "Administrator")
            {
                return RedirectToAction("Index");
            }
            Order RetrievedOrder = _context.Orders.SingleOrDefault(a => a.OrderId == orderId);
            Record RetrievedRecord = _context.Records.SingleOrDefault(a => a.RecordId == RetrievedOrder.RecordId);
            RetrievedRecord.Quantity += RetrievedOrder.QuantityBought;
            _context.Orders.Remove(RetrievedOrder);
            _context.SaveChanges();
            return RedirectToAction("AdminDashboard");
        }

        // User routes

        [HttpGet("records/{recordId}")]
        public IActionResult OneRecord(int recordId)
        {
            ViewBag.OneRecord = _context.Records.FirstOrDefault(a => a.RecordId == recordId);
            if (HttpContext.Session.GetInt32("UserId") != null)
            {
                ViewBag.LoggedInUser = _context.Users.FirstOrDefault(a => a.UserId == (int)HttpContext.Session.GetInt32("UserId"));
            }
            return View();
        }

        [HttpPost("records/buy/{recordId}")]
        public IActionResult BuyRecord(int recordId, int quantity)
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            Record purchasedRecord = _context.Records.FirstOrDefault(a => a.RecordId == recordId);
            Order newOrder = new Order { UserId = (int)HttpContext.Session.GetInt32("UserId"), RecordId = recordId, Price = purchasedRecord.Price, QuantityBought = quantity, OrderTotal = purchasedRecord.Price * quantity };
            _context.Orders.Add(newOrder);
            purchasedRecord.Quantity -= quantity;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("users/myorders/{userId}")]
        public IActionResult MyOrders(int userId)
        {
            if (HttpContext.Session.GetInt32("UserId") != userId)
            {
                return RedirectToAction("Index");
            }
            ViewBag.LoggedInUser = _context.Users.Include(a => a.MyOrders).ThenInclude(b => b.Record).FirstOrDefault(c => c.UserId == userId);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
