using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Azure.NotificationHubs.Service.Registrars;
using Soenneker.Azure.NotificationHubs.Senders.Abstract;

namespace Soenneker.Azure.NotificationHubs.Senders.Registrars;

/// <summary>
/// A .NET sender for Azure Notification Hubs push notifications.
/// </summary>
public static class AzureNotificationHubSenderRegistrar
{
    /// <summary>
    /// Adds <see cref="IAzureNotificationHubSender"/> as a singleton service. <para/>
    /// </summary>
    /// <param name="services">Service collection that receives the registration.</param>
    /// <returns>The same service collection, so additional registrations can be chained.</returns>
    public static IServiceCollection AddAzureNotificationHubSenderAsSingleton(this IServiceCollection services)
    {
        services.AddAzureNotificationHubServiceAsSingleton();
        services.TryAddSingleton<IAzureNotificationHubSender, AzureNotificationHubSender>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="IAzureNotificationHubSender"/> as a scoped service. <para/>
    /// </summary>
    /// <param name="services">Service collection that receives the registration.</param>
    /// <returns>The same service collection, so additional registrations can be chained.</returns>
    public static IServiceCollection AddAzureNotificationHubSenderAsScoped(this IServiceCollection services)
    {
        services.AddAzureNotificationHubServiceAsScoped();
        services.TryAddScoped<IAzureNotificationHubSender, AzureNotificationHubSender>();

        return services;
    }
}
