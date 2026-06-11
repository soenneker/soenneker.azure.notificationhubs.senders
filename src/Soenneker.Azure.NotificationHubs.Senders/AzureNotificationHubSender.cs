using Microsoft.Azure.NotificationHubs;
using Microsoft.Extensions.Logging;
using Soenneker.Azure.NotificationHubs.Service.Abstract;
using Soenneker.Azure.NotificationHubs.Senders.Abstract;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Soenneker.Extensions.Task;
using Soenneker.Extensions.ValueTask;

namespace Soenneker.Azure.NotificationHubs.Senders;

/// <inheritdoc cref="IAzureNotificationHubSender"/>
public sealed class AzureNotificationHubSender : IAzureNotificationHubSender
{
    private readonly IAzureNotificationHubService _notificationHubService;
    private readonly ILogger<AzureNotificationHubSender> _logger;

    public AzureNotificationHubSender(IAzureNotificationHubService notificationHubService, ILogger<AzureNotificationHubSender> logger)
    {
        _notificationHubService = notificationHubService;
        _logger = logger;
    }

    public async ValueTask<NotificationOutcome> Send(Notification notification, CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();

        _logger.LogDebug("Sending Azure Notification Hubs notification...");

        return await client.SendNotificationAsync(notification, cancellationToken).NoSync();
    }

    public async ValueTask<NotificationOutcome> Send(Notification notification, IEnumerable<string> tags, CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();

        _logger.LogDebug("Sending Azure Notification Hubs notification to tags...");

        return await client.SendNotificationAsync(notification, tags, cancellationToken).NoSync();
    }

    public async ValueTask<NotificationOutcome> SendToTagExpression(Notification notification, string tagExpression, CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();

        _logger.LogDebug("Sending Azure Notification Hubs notification to tag expression ({tagExpression})...", tagExpression);

        return await client.SendNotificationAsync(notification, tagExpression, cancellationToken).NoSync();
    }

    public async ValueTask<NotificationOutcome> SendTemplate(IDictionary<string, string> properties, CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();

        _logger.LogDebug("Sending Azure Notification Hubs template notification...");

        return await client.SendTemplateNotificationAsync(properties, cancellationToken).NoSync();
    }

    public async ValueTask<NotificationOutcome> SendTemplate(IDictionary<string, string> properties, IEnumerable<string> tags, CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();

        _logger.LogDebug("Sending Azure Notification Hubs template notification to tags...");

        return await client.SendTemplateNotificationAsync(properties, tags, cancellationToken).NoSync();
    }

    public async ValueTask<NotificationOutcome> SendTemplateToTagExpression(IDictionary<string, string> properties, string tagExpression,
        CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();

        _logger.LogDebug("Sending Azure Notification Hubs template notification to tag expression ({tagExpression})...", tagExpression);

        return await client.SendTemplateNotificationAsync(properties, tagExpression, cancellationToken).NoSync();
    }

    public async ValueTask<NotificationOutcome> SendDirect(Notification notification, string deviceHandle, CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();

        _logger.LogDebug("Sending Azure Notification Hubs direct notification...");

        return await client.SendDirectNotificationAsync(notification, deviceHandle, cancellationToken).NoSync();
    }

    public async ValueTask<NotificationOutcome> SendDirect(Notification notification, IList<string> deviceHandles, CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();

        _logger.LogDebug("Sending Azure Notification Hubs direct notification to device handles...");

        return await client.SendDirectNotificationAsync(notification, deviceHandles, cancellationToken).NoSync();
    }

    public async ValueTask<NotificationOutcome> SendApple(string jsonPayload, CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();
        return await client.SendAppleNativeNotificationAsync(jsonPayload, cancellationToken).NoSync();
    }

    public async ValueTask<NotificationOutcome> SendApple(string jsonPayload, IEnumerable<string> tags, CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();
        return await client.SendAppleNativeNotificationAsync(jsonPayload, tags, cancellationToken).NoSync();
    }

    public async ValueTask<NotificationOutcome> SendAppleToTagExpression(string jsonPayload, string tagExpression, CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();
        return await client.SendAppleNativeNotificationAsync(jsonPayload, tagExpression, cancellationToken).NoSync();
    }

    public async ValueTask<NotificationOutcome> SendFcm(string jsonPayload, CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();
        return await client.SendFcmNativeNotificationAsync(jsonPayload, cancellationToken).NoSync();
    }

    public async ValueTask<NotificationOutcome> SendFcm(string jsonPayload, IEnumerable<string> tags, CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();
        return await client.SendFcmNativeNotificationAsync(jsonPayload, tags, cancellationToken).NoSync();
    }

    public async ValueTask<NotificationOutcome> SendFcmToTagExpression(string jsonPayload, string tagExpression, CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();
        return await client.SendFcmNativeNotificationAsync(jsonPayload, tagExpression, cancellationToken).NoSync();
    }

    public async ValueTask<NotificationOutcome> SendFcmV1(string jsonPayload, CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();
        return await client.SendFcmV1NativeNotificationAsync(jsonPayload, cancellationToken).NoSync();
    }

    public async ValueTask<NotificationOutcome> SendFcmV1(string jsonPayload, IEnumerable<string> tags, CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();
        return await client.SendFcmV1NativeNotificationAsync(jsonPayload, tags, cancellationToken).NoSync();
    }

    public async ValueTask<NotificationOutcome> SendFcmV1ToTagExpression(string jsonPayload, string tagExpression, CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();
        return await client.SendFcmV1NativeNotificationAsync(jsonPayload, tagExpression, cancellationToken).NoSync();
    }

    public async ValueTask<NotificationOutcome> SendWindows(string windowsNativePayload, CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();
        return await client.SendWindowsNativeNotificationAsync(windowsNativePayload, cancellationToken).NoSync();
    }

    public async ValueTask<NotificationOutcome> SendWindows(string windowsNativePayload, IEnumerable<string> tags, CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();
        return await client.SendWindowsNativeNotificationAsync(windowsNativePayload, tags, cancellationToken).NoSync();
    }

    public async ValueTask<NotificationOutcome> SendWindowsToTagExpression(string windowsNativePayload, string tagExpression, CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();
        return await client.SendWindowsNativeNotificationAsync(windowsNativePayload, tagExpression, cancellationToken).NoSync();
    }

    public async ValueTask<NotificationOutcome> SendAdm(string jsonPayload, CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();
        return await client.SendAdmNativeNotificationAsync(jsonPayload, cancellationToken).NoSync();
    }

    public async ValueTask<NotificationOutcome> SendAdm(string jsonPayload, IEnumerable<string> tags, CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();
        return await client.SendAdmNativeNotificationAsync(jsonPayload, tags, cancellationToken).NoSync();
    }

    public async ValueTask<NotificationOutcome> SendAdmToTagExpression(string jsonPayload, string tagExpression, CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();
        return await client.SendAdmNativeNotificationAsync(jsonPayload, tagExpression, cancellationToken).NoSync();
    }

    public async ValueTask<NotificationOutcome> SendBaidu(string message, CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();
        return await client.SendBaiduNativeNotificationAsync(message, cancellationToken).NoSync();
    }

    public async ValueTask<NotificationOutcome> SendBaidu(string message, IEnumerable<string> tags, CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();
        return await client.SendBaiduNativeNotificationAsync(message, tags, cancellationToken).NoSync();
    }

    public async ValueTask<NotificationOutcome> SendBaiduToTagExpression(string message, string tagExpression, CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();
        return await client.SendBaiduNativeNotificationAsync(message, tagExpression, cancellationToken).NoSync();
    }

    public async ValueTask<NotificationOutcome> SendMpns(string nativePayload, CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();
        return await client.SendMpnsNativeNotificationAsync(nativePayload, cancellationToken).NoSync();
    }

    public async ValueTask<NotificationOutcome> SendMpns(string nativePayload, IEnumerable<string> tags, CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();
        return await client.SendMpnsNativeNotificationAsync(nativePayload, tags, cancellationToken).NoSync();
    }

    public async ValueTask<NotificationOutcome> SendMpnsToTagExpression(string nativePayload, string tagExpression, CancellationToken cancellationToken = default)
    {
        NotificationHubClient client = await _notificationHubService.Get(cancellationToken).NoSync();
        return await client.SendMpnsNativeNotificationAsync(nativePayload, tagExpression, cancellationToken).NoSync();
    }
}
