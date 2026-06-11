using Soenneker.Azure.NotificationHubs.Senders.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Azure.NotificationHubs.Senders.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class AzureNotificationHubSenderTests : HostedUnitTest
{
    private readonly IAzureNotificationHubSender _util;

    public AzureNotificationHubSenderTests(Host host) : base(host)
    {
        _util = Resolve<IAzureNotificationHubSender>(true);
    }

    [Test]
    public void Default()
    {

    }
}
