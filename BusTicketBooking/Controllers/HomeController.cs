using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BusTicketBooking.Models;

namespace BusTicketBooking.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Trang chủ mặc định
        public IActionResult Index()
        {
            return View();
        }

        // Trang Privacy
        public IActionResult Privacy()
        {
            return View();
        }

        // Hiển thị form đăng nhập
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // Xử lý đăng nhập
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Kiểm tra thông tin đăng nhập (thay thế bằng logic thực tế)
            if (username == "admin" && password == "password") // Ví dụ kiểm tra cứng
            {
                // Chuyển hướng đến trang chính sau khi đăng nhập thành công
                return RedirectToAction("Index", "Home");
            }

            // Nếu đăng nhập không thành công, trả về trang đăng nhập với thông báo lỗi
            ViewBag.ErrorMessage = "Tên đăng nhập hoặc mật khẩu không đúng.";
            return View();
        }

        // Hiển thị form đặt vé
        public IActionResult Booking()
        {
            return View();
        }

        // Xử lý khi người dùng gửi form đặt vé
        [HttpPost]
        public IActionResult Booking(string name, string phone, string date, string route)
        {
            ViewBag.Message = $"Đặt vé thành công! Tên: {name}, Điện thoại: {phone}, Ngày đi: {date}, Tuyến: {route}";
            return View();
        }

        // Xử lý lỗi
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}