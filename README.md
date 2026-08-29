[![](https://img.shields.io/nuget/v/soenneker.azure.notificationhubs.senders.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.azure.notificationhubs.senders/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.azure.notificationhubs.senders/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.azure.notificationhubs.senders/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.azure.notificationhubs.senders.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.azure.notificationhubs.senders/)

# Soenneker.Azure.NotificationHubs.Senders

A DI-ready sender for template and native Azure Notification Hubs notifications, with tag, tag-expression, and direct-device targeting.

## Installation

```bash
dotnet add package Soenneker.Azure.NotificationHubs.Senders
```

## Configuration and registration

```json
{
  "Azure": {
    "NotificationHubs": {
      "ConnectionString": "Endpoint=sb://...",
      "HubName": "notifications"
    }
  }
}
```

```csharp
using Soenneker.Azure.NotificationHubs.Senders.Registrars;

builder.Services.AddAzureNotificationHubSenderAsSingleton();
```

The connection string must permit sends. Keep it in a backend secret provider; never place it in a mobile or browser application.

## Send an FCM v1 notification to tags

```csharp
using Soenneker.Azure.NotificationHubs.Senders.Abstract;

string payload = """
{
  "message": {
    "notification": {
      "title": "Order ready",
      "body": "Your order is ready for pickup."
    }
  }
}
""";

NotificationOutcome outcome = await sender.SendFcmV1(
    payload,
    tags: ["user:42"],
    cancellationToken);
```

Platform helpers are available for Apple, legacy FCM, FCM v1, Windows, ADM, Baidu, and MPNS payloads. The package passes native payload strings to the Azure SDK; it does not build or validate platform JSON/XML.

## Targeting options

- Overloads accepting `tags` target the union understood by the Azure SDK.
- `*ToTagExpression` methods accept Azure Notification Hubs tag-expression syntax.
- `SendDirect` targets one device handle or a supplied handle list.
- `SendTemplate` sends a property dictionary for templates already registered on installations.
- `Send(Notification)` and platform overloads with no tags or expression are broadcasts to all eligible installations in the hub.

Treat no-target overloads as privileged broadcast operations. Do not select an overload from untrusted request input, and validate user-derived tag expressions against your authorization model. A successful `NotificationOutcome` reflects Azure's send submission; it does not prove every device displayed the notification.
