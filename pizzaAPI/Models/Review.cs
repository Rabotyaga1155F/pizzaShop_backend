namespace pizzaAPI.Models;

public class Review
{
    public int ReviewId { get; set; }

    public string UserName { get; set; } = string.Empty;
    
    
    public string City { get; set; } = string.Empty;
    
    public string PhoneNumber { get; set; } = string.Empty;
    
    public string Email { get; set; } = string.Empty;
    
    public string Comment { get; set; } = string.Empty;
    
    public DateTime ReviewDate { get; set; }

    public string ReviewStatus { get; set; } = string.Empty;
}