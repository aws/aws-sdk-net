using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    [TestCategory("SimpleNotificationService")]
    public class FindTopicTests
    {
        [TestMethod]
        public async Task FindTopicAsyncReturnsNullWhenTopicsIsNull()
        {
            var client = new EmptyTopicsClient();
            Assert.IsNull(await client.FindTopicAsync("missing"));
        }

        private class EmptyTopicsClient : AmazonSimpleNotificationServiceClient
        {
            public EmptyTopicsClient() : base(new AnonymousAWSCredentials(), Amazon.RegionEndpoint.USEast1)
            {
            }

            public override Task<ListTopicsResponse> ListTopicsAsync(ListTopicsRequest request, CancellationToken cancellationToken = default(CancellationToken))
            {
                return Task.FromResult(new ListTopicsResponse { Topics = null });
            }
        }
    }
}
