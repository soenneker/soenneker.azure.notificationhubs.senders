using Microsoft.Azure.NotificationHubs;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Azure.NotificationHubs.Senders.Abstract;

/// <summary>
/// A .NET sender for Azure Notification Hubs push notifications.
/// </summary>
public interface IAzureNotificationHubSender
{
    ValueTask<NotificationOutcome> Send(Notification notification, CancellationToken cancellationToken = default);

    ValueTask<NotificationOutcome> Send(Notification notification, IEnumerable<string> tags, CancellationToken cancellationToken = default);

    ValueTask<NotificationOutcome> SendToTagExpression(Notification notification, string tagExpression, CancellationToken cancellationToken = default);

    ValueTask<NotificationOutcome> SendTemplate(IDictionary<string, string> properties, CancellationToken cancellationToken = default);

    ValueTask<NotificationOutcome> SendTemplate(IDictionary<string, string> properties, IEnumerable<string> tags, CancellationToken cancellationToken = default);

    ValueTask<NotificationOutcome> SendTemplateToTagExpression(IDictionary<string, string> properties, string tagExpression, CancellationToken cancellationToken = default);

    ValueTask<NotificationOutcome> SendDirect(Notification notification, string deviceHandle, CancellationToken cancellationToken = default);

    ValueTask<NotificationOutcome> SendDirect(Notification notification, IList<string> deviceHandles, CancellationToken cancellationToken = default);

    ValueTask<NotificationOutcome> SendApple(string jsonPayload, CancellationToken cancellationToken = default);

    ValueTask<NotificationOutcome> SendApple(string jsonPayload, IEnumerable<string> tags, CancellationToken cancellationToken = default);

    ValueTask<NotificationOutcome> SendAppleToTagExpression(string jsonPayload, string tagExpression, CancellationToken cancellationToken = default);

    ValueTask<NotificationOutcome> SendFcm(string jsonPayload, CancellationToken cancellationToken = default);

    ValueTask<NotificationOutcome> SendFcm(string jsonPayload, IEnumerable<string> tags, CancellationToken cancellationToken = default);

    ValueTask<NotificationOutcome> SendFcmToTagExpression(string jsonPayload, string tagExpression, CancellationToken cancellationToken = default);

    ValueTask<NotificationOutcome> SendFcmV1(string jsonPayload, CancellationToken cancellationToken = default);

    ValueTask<NotificationOutcome> SendFcmV1(string jsonPayload, IEnumerable<string> tags, CancellationToken cancellationToken = default);

    ValueTask<NotificationOutcome> SendFcmV1ToTagExpression(string jsonPayload, string tagExpression, CancellationToken cancellationToken = default);

    ValueTask<NotificationOutcome> SendWindows(string windowsNativePayload, CancellationToken cancellationToken = default);

    ValueTask<NotificationOutcome> SendWindows(string windowsNativePayload, IEnumerable<string> tags, CancellationToken cancellationToken = default);

    ValueTask<NotificationOutcome> SendWindowsToTagExpression(string windowsNativePayload, string tagExpression, CancellationToken cancellationToken = default);

    ValueTask<NotificationOutcome> SendAdm(string jsonPayload, CancellationToken cancellationToken = default);

    ValueTask<NotificationOutcome> SendAdm(string jsonPayload, IEnumerable<string> tags, CancellationToken cancellationToken = default);

    ValueTask<NotificationOutcome> SendAdmToTagExpression(string jsonPayload, string tagExpression, CancellationToken cancellationToken = default);

    ValueTask<NotificationOutcome> SendBaidu(string message, CancellationToken cancellationToken = default);

    ValueTask<NotificationOutcome> SendBaidu(string message, IEnumerable<string> tags, CancellationToken cancellationToken = default);

    ValueTask<NotificationOutcome> SendBaiduToTagExpression(string message, string tagExpression, CancellationToken cancellationToken = default);

    ValueTask<NotificationOutcome> SendMpns(string nativePayload, CancellationToken cancellationToken = default);

    ValueTask<NotificationOutcome> SendMpns(string nativePayload, IEnumerable<string> tags, CancellationToken cancellationToken = default);

    ValueTask<NotificationOutcome> SendMpnsToTagExpression(string nativePayload, string tagExpression, CancellationToken cancellationToken = default);
}
