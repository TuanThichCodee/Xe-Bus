public class Booking
{
    public int Id { get; set; }
    
    public required string Name { get; set; }  // Bắt buộc phải có giá trị
    public required string Phone { get; set; }
    public DateTime Date { get; set; }
    public required string Route { get; set; }
}