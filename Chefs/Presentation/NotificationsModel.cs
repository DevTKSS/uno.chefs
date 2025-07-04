using Chefs.Business.Services.Notifications;

namespace Chefs.Presentation;
public partial record NotificationsModel
{
	private readonly INavigator _navigator;
	private readonly INotificationService _notificationService;

	public NotificationsModel(INavigator navigator, INotificationService notificationService)
	{
		_notificationService = notificationService;
		_navigator = navigator;
	}
	public IFeed<GroupedNotification> Notifications => Feed<GroupedNotification>.Async(async ct
			=> await _notificationService.GetAll(ct) is { Count: > 0 } result
			? new GroupedNotification(result)
			: Option.None<GroupedNotification>());

	public IFeed<GroupedNotification> Unread => Notifications.Select(group =>
		new GroupedNotification(group.GetAll().Where(n => !n.IsRead).ToImmutableList()));

	public IFeed<GroupedNotification> Read => Notifications.Select(group =>
		new GroupedNotification(group.GetAll().Where(n => n.IsRead).ToImmutableList()));
}
