[![](https://img.shields.io/nuget/v/soenneker.azure.notificationhubs.senders.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.azure.notificationhubs.senders/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.azure.notificationhubs.senders/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.azure.notificationhubs.senders/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.azure.notificationhubs.senders.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.azure.notificationhubs.senders/)

# Soenneker.Azure.NotificationHubs.Senders

A .NET sender for Azure Notification Hubs push notifications.

## Install

```bash
dotnet add package Soenneker.Azure.NotificationHubs.Senders
```

## Quick start

```csharp
using Soenneker.Azure.NotificationHubs.Senders.Registrars;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
var result = services.AddAzureNotificationHubSenderAsSingleton();
```

Adds `IAzureNotificationHubSender` as a singleton service.

## What you get

- `IAzureNotificationHubSender` — A .NET sender for Azure Notification Hubs push notifications.
- `AzureNotificationHubSenderRegistrar` — A .NET sender for Azure Notification Hubs push notifications.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `IAzureNotificationHubSender.Send(notification, tags, cancellationToken)` | Sends azure Notification Hub Sender. | A task whose result is the requested notification Outcome. |
| `IAzureNotificationHubSender.SendTemplate(properties, cancellationToken)` | Sends template. | A task whose result is the requested notification Outcome. |
| `IAzureNotificationHubSender.SendTemplate(properties, tags, cancellationToken)` | Sends template. | A task whose result is the requested notification Outcome. |
| `IAzureNotificationHubSender.SendTemplateToTagExpression(properties, tagExpression, cancellationToken)` | Sends template To Tag Expression. | A task whose result is the requested notification Outcome. |
| `IAzureNotificationHubSender.SendDirect(notification, deviceHandle, cancellationToken)` | Sends direct. | A task whose result is the requested notification Outcome. |
| `IAzureNotificationHubSender.SendApple(jsonPayload, cancellationToken)` | Sends apple. | A task whose result is the requested notification Outcome. |
| `IAzureNotificationHubSender.SendApple(jsonPayload, tags, cancellationToken)` | Sends apple. | A task whose result is the requested notification Outcome. |
| `IAzureNotificationHubSender.SendAppleToTagExpression(jsonPayload, tagExpression, cancellationToken)` | Sends apple To Tag Expression. | A task whose result is the requested notification Outcome. |
| `IAzureNotificationHubSender.SendFcm(jsonPayload, cancellationToken)` | Sends fcm. | A task whose result is the requested notification Outcome. |
| `IAzureNotificationHubSender.SendFcm(jsonPayload, tags, cancellationToken)` | Sends fcm. | A task whose result is the requested notification Outcome. |
| `IAzureNotificationHubSender.SendFcmToTagExpression(jsonPayload, tagExpression, cancellationToken)` | Sends fcm To Tag Expression. | A task whose result is the requested notification Outcome. |
| `IAzureNotificationHubSender.SendFcmV1(jsonPayload, cancellationToken)` | Sends fcm V. | A task whose result is the requested notification Outcome. |
| `IAzureNotificationHubSender.SendFcmV1(jsonPayload, tags, cancellationToken)` | Sends fcm V. | A task whose result is the requested notification Outcome. |
| `IAzureNotificationHubSender.SendFcmV1ToTagExpression(jsonPayload, tagExpression, cancellationToken)` | Sends fcm V1 To Tag Expression. | A task whose result is the requested notification Outcome. |
| `IAzureNotificationHubSender.SendWindows(windowsNativePayload, cancellationToken)` | Sends windows. | A task whose result is the requested notification Outcome. |
| `IAzureNotificationHubSender.SendWindows(windowsNativePayload, tags, cancellationToken)` | Sends windows. | A task whose result is the requested notification Outcome. |
| `IAzureNotificationHubSender.SendWindowsToTagExpression(windowsNativePayload, tagExpression, cancellationToken)` | Sends windows To Tag Expression. | A task whose result is the requested notification Outcome. |
| `IAzureNotificationHubSender.SendAdm(jsonPayload, cancellationToken)` | Sends adm. | A task whose result is the requested notification Outcome. |

## Practical notes

- Cancellation stops pending work; it does not undo work that has already completed.
