using Amazon.TranscribeService;
using Amazon.TranscribeService.Model;
using Xunit;

namespace AWSSDK.SmokeTests.TranscribeService
{
    [Trait("Category", "SmokeTests")]
    [Trait("Category", "TranscribeService")]
    public class SmokeTest
    {
        IAmazonTranscribeService transcribeServiceClient;
        public SmokeTest()
        {
            transcribeServiceClient = new AmazonTranscribeServiceClient(Amazon.RegionEndpoint.USEast1);
        }

        [Fact]
        public void ListSecretsSmokeTest()
        {
#if BCL
            var response = transcribeServiceClient.ListTranscriptionJobs(new ListTranscriptionJobsRequest
            {
            });
#elif CORECLR
            var response = transcribeServiceClient.ListTranscriptionJobsAsync(new ListTranscriptionJobsRequest
            {
            }).Result;
#endif
            Assert.NotNull(response);
        }
    }
}
