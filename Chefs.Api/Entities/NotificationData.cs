namespace Chefs.Api.Entities;

public class NotificationData
{
	public string? Title { get; set; }
	public string? Description { get; set; }
	public bool IsRead { get; set; }
	public DateTime Date { get; set; }
}
