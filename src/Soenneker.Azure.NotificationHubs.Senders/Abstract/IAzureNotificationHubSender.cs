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
    /// <summary>
    /// Sends azure Notification Hub Sender for the Azure Notification Hub Sender.
    /// </summary>
    /// <param name="notification">Notification payload to send.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> Send(Notification notification, CancellationToken cancellationToken = default);
    /// <summary>
    /// Sends azure Notification Hub Sender.
    /// </summary>
    /// <param name="notification">Notification payload to send.</param>
    /// <param name="tags">Tags used to select notification recipients.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> Send(Notification notification, IEnumerable<string> tags, CancellationToken cancellationToken = default);
    /// <summary>
    /// Sends template for the azure notification hub sender.
    /// </summary>
    /// <param name="notification">Notification payload to send.</param>
    /// <param name="tagExpression">Notification Hub tag expression used to select recipients.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> SendToTagExpression(Notification notification, string tagExpression, CancellationToken cancellationToken = default);
    /// <summary>
    /// Sends template.
    /// </summary>
    /// <param name="properties">Properties for the send template operation.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> SendTemplate(IDictionary<string, string> properties, CancellationToken cancellationToken = default);
    /// <summary>
    /// Sends template.
    /// </summary>
    /// <param name="properties">Properties for the send template operation.</param>
    /// <param name="tags">Tags used to select notification recipients.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> SendTemplate(IDictionary<string, string> properties, IEnumerable<string> tags, CancellationToken cancellationToken = default);
    /// <summary>
    /// Sends template To Tag Expression.
    /// </summary>
    /// <param name="properties">Properties for the send template to tag expression operation.</param>
    /// <param name="tagExpression">Notification Hub tag expression used to select recipients.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> SendTemplateToTagExpression(IDictionary<string, string> properties, string tagExpression, CancellationToken cancellationToken = default);
    /// <summary>
    /// Sends direct.
    /// </summary>
    /// <param name="notification">Notification payload to send.</param>
    /// <param name="deviceHandle">Device Handle for the send direct operation.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> SendDirect(Notification notification, string deviceHandle, CancellationToken cancellationToken = default);
    /// <summary>
    /// Sends apple for the azure notification hub sender.
    /// </summary>
    /// <param name="notification">Notification payload to send.</param>
    /// <param name="deviceHandles">device Handles to process.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> SendDirect(Notification notification, IList<string> deviceHandles, CancellationToken cancellationToken = default);
    /// <summary>
    /// Sends apple.
    /// </summary>
    /// <param name="jsonPayload">JSON payload supplied to the callback.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> SendApple(string jsonPayload, CancellationToken cancellationToken = default);
    /// <summary>
    /// Sends apple.
    /// </summary>
    /// <param name="jsonPayload">JSON payload supplied to the callback.</param>
    /// <param name="tags">Tags used to select notification recipients.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> SendApple(string jsonPayload, IEnumerable<string> tags, CancellationToken cancellationToken = default);
    /// <summary>
    /// Sends apple To Tag Expression.
    /// </summary>
    /// <param name="jsonPayload">JSON payload supplied to the callback.</param>
    /// <param name="tagExpression">Notification Hub tag expression used to select recipients.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> SendAppleToTagExpression(string jsonPayload, string tagExpression, CancellationToken cancellationToken = default);
    /// <summary>
    /// Sends fcm.
    /// </summary>
    /// <param name="jsonPayload">JSON payload supplied to the callback.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> SendFcm(string jsonPayload, CancellationToken cancellationToken = default);
    /// <summary>
    /// Sends fcm.
    /// </summary>
    /// <param name="jsonPayload">JSON payload supplied to the callback.</param>
    /// <param name="tags">Tags used to select notification recipients.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> SendFcm(string jsonPayload, IEnumerable<string> tags, CancellationToken cancellationToken = default);
    /// <summary>
    /// Sends fcm To Tag Expression.
    /// </summary>
    /// <param name="jsonPayload">JSON payload supplied to the callback.</param>
    /// <param name="tagExpression">Notification Hub tag expression used to select recipients.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> SendFcmToTagExpression(string jsonPayload, string tagExpression, CancellationToken cancellationToken = default);
    /// <summary>
    /// Sends fcm V.
    /// </summary>
    /// <param name="jsonPayload">JSON payload supplied to the callback.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> SendFcmV1(string jsonPayload, CancellationToken cancellationToken = default);
    /// <summary>
    /// Sends fcm V.
    /// </summary>
    /// <param name="jsonPayload">JSON payload supplied to the callback.</param>
    /// <param name="tags">Tags used to select notification recipients.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> SendFcmV1(string jsonPayload, IEnumerable<string> tags, CancellationToken cancellationToken = default);
    /// <summary>
    /// Sends fcm V1 To Tag Expression.
    /// </summary>
    /// <param name="jsonPayload">JSON payload supplied to the callback.</param>
    /// <param name="tagExpression">Notification Hub tag expression used to select recipients.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> SendFcmV1ToTagExpression(string jsonPayload, string tagExpression, CancellationToken cancellationToken = default);
    /// <summary>
    /// Sends windows.
    /// </summary>
    /// <param name="windowsNativePayload">Windows Native Payload for the send windows operation.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> SendWindows(string windowsNativePayload, CancellationToken cancellationToken = default);
    /// <summary>
    /// Sends windows.
    /// </summary>
    /// <param name="windowsNativePayload">Windows Native Payload for the send windows operation.</param>
    /// <param name="tags">Tags used to select notification recipients.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> SendWindows(string windowsNativePayload, IEnumerable<string> tags, CancellationToken cancellationToken = default);
    /// <summary>
    /// Sends windows To Tag Expression.
    /// </summary>
    /// <param name="windowsNativePayload">Windows Native Payload for the send windows to tag expression operation.</param>
    /// <param name="tagExpression">Notification Hub tag expression used to select recipients.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> SendWindowsToTagExpression(string windowsNativePayload, string tagExpression, CancellationToken cancellationToken = default);
    /// <summary>
    /// Sends adm.
    /// </summary>
    /// <param name="jsonPayload">JSON payload supplied to the callback.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> SendAdm(string jsonPayload, CancellationToken cancellationToken = default);
    /// <summary>
    /// Sends adm.
    /// </summary>
    /// <param name="jsonPayload">JSON payload supplied to the callback.</param>
    /// <param name="tags">Tags used to select notification recipients.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> SendAdm(string jsonPayload, IEnumerable<string> tags, CancellationToken cancellationToken = default);
    /// <summary>
    /// Sends adm To Tag Expression.
    /// </summary>
    /// <param name="jsonPayload">JSON payload supplied to the callback.</param>
    /// <param name="tagExpression">Notification Hub tag expression used to select recipients.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> SendAdmToTagExpression(string jsonPayload, string tagExpression, CancellationToken cancellationToken = default);
    /// <summary>
    /// Sends baidu for the azure notification hub sender.
    /// </summary>
    /// <param name="message">Message content to send.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> SendBaidu(string message, CancellationToken cancellationToken = default);
    /// <summary>
    /// Sends baidu.
    /// </summary>
    /// <param name="message">Message content to send.</param>
    /// <param name="tags">Tags used to select notification recipients.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> SendBaidu(string message, IEnumerable<string> tags, CancellationToken cancellationToken = default);
    /// <summary>
    /// Sends mpns for the azure notification hub sender.
    /// </summary>
    /// <param name="message">Message content to send.</param>
    /// <param name="tagExpression">Notification Hub tag expression used to select recipients.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> SendBaiduToTagExpression(string message, string tagExpression, CancellationToken cancellationToken = default);
    /// <summary>
    /// Sends mpns.
    /// </summary>
    /// <param name="nativePayload">Native Payload for the send mpns operation.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> SendMpns(string nativePayload, CancellationToken cancellationToken = default);
    /// <summary>
    /// Sends mpns.
    /// </summary>
    /// <param name="nativePayload">Native Payload for the send mpns operation.</param>
    /// <param name="tags">Tags used to select notification recipients.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> SendMpns(string nativePayload, IEnumerable<string> tags, CancellationToken cancellationToken = default);
    /// <summary>
    /// Sends mpns To Tag Expression.
    /// </summary>
    /// <param name="nativePayload">Native Payload for the send mpns to tag expression operation.</param>
    /// <param name="tagExpression">Notification Hub tag expression used to select recipients.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested notification Outcome.</returns>
    ValueTask<NotificationOutcome> SendMpnsToTagExpression(string nativePayload, string tagExpression, CancellationToken cancellationToken = default);
}
