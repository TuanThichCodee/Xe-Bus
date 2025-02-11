namespace BusTicketBooking.Models
{
    public class User
    {
        public int Id { get; set; } // ID người dùng
        public required string Username { get; set; } // Tên đăng nhập
        public required string Password { get; set; } // Mật khẩu
        public required string Email { get; set; }
        // Thêm các thuộc tính khác nếu cần, như Email, Phone, v.v.
    }
}