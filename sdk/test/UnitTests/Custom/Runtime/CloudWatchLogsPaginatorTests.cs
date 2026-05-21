#if !NETFRAMEWORK
using System;
using System.Threading;
using System.Threading.Tasks;
using Amazon.CloudWatchLogs;
using Amazon.CloudWatchLogs.Model;
using Amazon.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AWSSDK.UnitTests
{
    [TestClass]
    [TestCategory("CloudWatchLogs")]
    public class CloudWatchLogsPaginatorTests
    {
        private Mock<AmazonCloudWatchLogsClient> _mockClient;

        [TestInitialize]
        public void Initialize()
        {
            _mockClient = new Mock<AmazonCloudWatchLogsClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        public async Task DescribeDestinationsTest_TwoResponses()
        {
            var request = new DescribeDestinationsRequest();
            var firstResponse = new DescribeDestinationsResponse() { NextToken = "foo" };
            var secondResponse = new DescribeDestinationsResponse() { NextToken = null };
            var token = new CancellationToken();

            _mockClient.SetupSequence(x => x.DescribeDestinationsAsync(It.IsAny<DescribeDestinationsRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(firstResponse)
                .ReturnsAsync(secondResponse);

            var numResponses = 0;
            await foreach (var destination in _mockClient.Object.Paginators.DescribeDestinations(request).Responses.WithCancellation(token))
            {
                numResponses += 1;
            }
            Assert.AreEqual(2, numResponses);
        }

        [TestMethod]
        public async Task DescribeDestinationsTest__OnlyUsedOnce()
        {
            var request = new DescribeDestinationsRequest();
            var response = new DescribeDestinationsResponse();
            var token = new CancellationToken();
            var paginator = _mockClient.Object.Paginators.DescribeDestinations(request);

            _mockClient.Setup(x => x.DescribeDestinationsAsync(It.IsAny<DescribeDestinationsRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(response);

            await LoopOverDestinations(paginator, token);
            await Assert.ThrowsExceptionAsync<System.InvalidOperationException>(async () => await LoopOverDestinations(paginator, token));
        }

        private async Task LoopOverDestinations(IDescribeDestinationsPaginator paginator, CancellationToken token)
        {
            await foreach (var destination in paginator.Responses.WithCancellation(token)) ;
        }

        [TestMethod]
        public async Task DescribeDestinationsTest__CancellationToken()
        {
            var request = new DescribeDestinationsRequest();
            var firstResponse = new DescribeDestinationsResponse() { NextToken = "foo" };
            var secondResponse = new DescribeDestinationsResponse() { NextToken = null };
            var paginator = _mockClient.Object.Paginators.DescribeDestinations(request);

            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;
            tokenSource.Cancel();

            _mockClient.SetupSequence(x => x.DescribeDestinationsAsync(It.IsAny<DescribeDestinationsRequest>(), It.IsAny<CancellationToken>()))
                 .ReturnsAsync(firstResponse)
                 .ReturnsAsync(secondResponse);

            await Assert.ThrowsExceptionAsync<OperationCanceledException>(async () => await LoopOverDestinations(paginator, token));
        }

        [TestMethod]
        public async Task DescribeLogGroupsTest_TwoResponses()
        {
            var request = new DescribeLogGroupsRequest();
            var firstResponse = new DescribeLogGroupsResponse() { NextToken = "foo" };
            var secondResponse = new DescribeLogGroupsResponse() { NextToken = null };
            var token = new CancellationToken();

            _mockClient.SetupSequence(x => x.DescribeLogGroupsAsync(It.IsAny<DescribeLogGroupsRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(firstResponse)
                .ReturnsAsync(secondResponse);

            var numResponses = 0;
            await foreach (var logGroup in _mockClient.Object.Paginators.DescribeLogGroups(request).Responses.WithCancellation(token))
            {
                numResponses += 1;
            }
            Assert.AreEqual(2, numResponses);
        }

        [TestMethod]
        public async Task DescribeLogGroupsTest__OnlyUsedOnce()
        {
            var request = new DescribeLogGroupsRequest();
            var response = new DescribeLogGroupsResponse();
            var token = new CancellationToken();
            var paginator = _mockClient.Object.Paginators.DescribeLogGroups(request);

            _mockClient.Setup(x => x.DescribeLogGroupsAsync(It.IsAny<DescribeLogGroupsRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(response);

            await LoopOverLogGroups(paginator, token);
            await Assert.ThrowsExceptionAsync<System.InvalidOperationException>(async () => await LoopOverLogGroups(paginator, token));
        }

        private async Task LoopOverLogGroups(IDescribeLogGroupsPaginator paginator, CancellationToken token)
        {
            await foreach (var logGroup in paginator.Responses.WithCancellation(token)) ;
        }

        [TestMethod]
        public async Task DescribeLogGroupsTest__CancellationToken()
        {
            var request = new DescribeLogGroupsRequest();
            var firstResponse = new DescribeLogGroupsResponse() { NextToken = "foo" };
            var secondResponse = new DescribeLogGroupsResponse() { NextToken = null };
            var paginator = _mockClient.Object.Paginators.DescribeLogGroups(request);

            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;
            tokenSource.Cancel();

            _mockClient.SetupSequence(x => x.DescribeLogGroupsAsync(It.IsAny<DescribeLogGroupsRequest>(), It.IsAny<CancellationToken>()))
                 .ReturnsAsync(firstResponse)
                 .ReturnsAsync(secondResponse);

            await Assert.ThrowsExceptionAsync<OperationCanceledException>(async () => await LoopOverLogGroups(paginator, token));
        }

        [TestMethod]
        public async Task DescribeLogStreamsTest_TwoResponses()
        {
            var request = new DescribeLogStreamsRequest();
            var firstResponse = new DescribeLogStreamsResponse() { NextToken = "foo" };
            var secondResponse = new DescribeLogStreamsResponse() { NextToken = null };
            var token = new CancellationToken();

            _mockClient.SetupSequence(x => x.DescribeLogStreamsAsync(It.IsAny<DescribeLogStreamsRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(firstResponse)
                .ReturnsAsync(secondResponse);

            var numResponses = 0;
            await foreach (var logStream in _mockClient.Object.Paginators.DescribeLogStreams(request).Responses.WithCancellation(token))
            {
                numResponses += 1;
            }
            Assert.AreEqual(2, numResponses);
        }

        [TestMethod]
        public async Task DescribeLogStreamsTest__OnlyUsedOnce()
        {
            var request = new DescribeLogStreamsRequest();
            var response = new DescribeLogStreamsResponse();
            var token = new CancellationToken();
            var paginator = _mockClient.Object.Paginators.DescribeLogStreams(request);

            _mockClient.Setup(x => x.DescribeLogStreamsAsync(It.IsAny<DescribeLogStreamsRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(response);

            await LoopOverLogStreams(paginator, token);
            await Assert.ThrowsExceptionAsync<System.InvalidOperationException>(async () => await LoopOverLogStreams(paginator, token));
        }

        private async Task LoopOverLogStreams(IDescribeLogStreamsPaginator paginator, CancellationToken token)
        {
            await foreach (var logStream in paginator.Responses.WithCancellation(token)) ;
        }

        [TestMethod]
        public async Task DescribeLogStreamsTest__CancellationToken()
        {
            var request = new DescribeLogStreamsRequest();
            var firstResponse = new DescribeLogStreamsResponse() { NextToken = "foo" };
            var secondResponse = new DescribeLogStreamsResponse() { NextToken = null };
            var paginator = _mockClient.Object.Paginators.DescribeLogStreams(request);

            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;
            tokenSource.Cancel();

            _mockClient.SetupSequence(x => x.DescribeLogStreamsAsync(It.IsAny<DescribeLogStreamsRequest>(), It.IsAny<CancellationToken>()))
                 .ReturnsAsync(firstResponse)
                 .ReturnsAsync(secondResponse);

            await Assert.ThrowsExceptionAsync<OperationCanceledException>(async () => await LoopOverLogStreams(paginator, token));
        }

        [TestMethod]
        public async Task DescribeMetricFiltersTest_TwoResponses()
        {
            var request = new DescribeMetricFiltersRequest();
            var firstResponse = new DescribeMetricFiltersResponse() { NextToken = "foo" };
            var secondResponse = new DescribeMetricFiltersResponse() { NextToken = null };
            var token = new CancellationToken();

            _mockClient.SetupSequence(x => x.DescribeMetricFiltersAsync(It.IsAny<DescribeMetricFiltersRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(firstResponse)
                .ReturnsAsync(secondResponse);

            var numResponses = 0;
            await foreach (var metricFilter in _mockClient.Object.Paginators.DescribeMetricFilters(request).Responses.WithCancellation(token))
            {
                numResponses += 1;
            }
            Assert.AreEqual(2, numResponses);
        }

        [TestMethod]
        public async Task DescribeMetricFiltersTest__OnlyUsedOnce()
        {
            var request = new DescribeMetricFiltersRequest();
            var response = new DescribeMetricFiltersResponse();
            var token = new CancellationToken();
            var paginator = _mockClient.Object.Paginators.DescribeMetricFilters(request);

            _mockClient.Setup(x => x.DescribeMetricFiltersAsync(It.IsAny<DescribeMetricFiltersRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(response);

            await LoopOverMetricFilters(paginator, token);
            await Assert.ThrowsExceptionAsync<System.InvalidOperationException>(async () => await LoopOverMetricFilters(paginator, token));
        }

        private async Task LoopOverMetricFilters(IDescribeMetricFiltersPaginator paginator, CancellationToken token)
        {
            await foreach (var metricFilter in paginator.Responses.WithCancellation(token)) ;
        }

        [TestMethod]
        public async Task DescribeMetricFiltersTest__CancellationToken()
        {
            var request = new DescribeMetricFiltersRequest();
            var firstResponse = new DescribeMetricFiltersResponse() { NextToken = "foo" };
            var secondResponse = new DescribeMetricFiltersResponse() { NextToken = null };
            var paginator = _mockClient.Object.Paginators.DescribeMetricFilters(request);

            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;
            tokenSource.Cancel();

            _mockClient.SetupSequence(x => x.DescribeMetricFiltersAsync(It.IsAny<DescribeMetricFiltersRequest>(), It.IsAny<CancellationToken>()))
                 .ReturnsAsync(firstResponse)
                 .ReturnsAsync(secondResponse);

            await Assert.ThrowsExceptionAsync<OperationCanceledException>(async () => await LoopOverMetricFilters(paginator, token));
        }

        [TestMethod]
        public async Task DescribeSubscriptionFiltersTest_TwoResponses()
        {
            var request = new DescribeSubscriptionFiltersRequest();
            var firstResponse = new DescribeSubscriptionFiltersResponse() { NextToken = "foo" };
            var secondResponse = new DescribeSubscriptionFiltersResponse() { NextToken = null };
            var token = new CancellationToken();

            _mockClient.SetupSequence(x => x.DescribeSubscriptionFiltersAsync(It.IsAny<DescribeSubscriptionFiltersRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(firstResponse)
                .ReturnsAsync(secondResponse);

            var numResponses = 0;
            await foreach (var subscriptionFilter in _mockClient.Object.Paginators.DescribeSubscriptionFilters(request).Responses.WithCancellation(token))
            {
                numResponses += 1;
            }
            Assert.AreEqual(2, numResponses);
        }

        [TestMethod]
        public async Task DescribeSubscriptionFiltersTest__OnlyUsedOnce()
        {
            var request = new DescribeSubscriptionFiltersRequest();
            var response = new DescribeSubscriptionFiltersResponse();
            var token = new CancellationToken();
            var paginator = _mockClient.Object.Paginators.DescribeSubscriptionFilters(request);

            _mockClient.Setup(x => x.DescribeSubscriptionFiltersAsync(It.IsAny<DescribeSubscriptionFiltersRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(response);

            await LoopOverSubscriptionFilters(paginator, token);
            await Assert.ThrowsExceptionAsync<System.InvalidOperationException>(async () => await LoopOverSubscriptionFilters(paginator, token));
        }

        private async Task LoopOverSubscriptionFilters(IDescribeSubscriptionFiltersPaginator paginator, CancellationToken token)
        {
            await foreach (var subscriptionFilter in paginator.Responses.WithCancellation(token)) ;
        }

        [TestMethod]
        public async Task DescribeSubscriptionFiltersTest__CancellationToken()
        {
            var request = new DescribeSubscriptionFiltersRequest();
            var firstResponse = new DescribeSubscriptionFiltersResponse() { NextToken = "foo" };
            var secondResponse = new DescribeSubscriptionFiltersResponse() { NextToken = null };
            var paginator = _mockClient.Object.Paginators.DescribeSubscriptionFilters(request);

            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;
            tokenSource.Cancel();

            _mockClient.SetupSequence(x => x.DescribeSubscriptionFiltersAsync(It.IsAny<DescribeSubscriptionFiltersRequest>(), It.IsAny<CancellationToken>()))
                 .ReturnsAsync(firstResponse)
                 .ReturnsAsync(secondResponse);

            await Assert.ThrowsExceptionAsync<OperationCanceledException>(async () => await LoopOverSubscriptionFilters(paginator, token));
        }

        [TestMethod]
        public async Task FilterLogEventsTest_TwoResponses()
        {
            var request = new FilterLogEventsRequest();
            var firstResponse = new FilterLogEventsResponse() { NextToken = "foo" };
            var secondResponse = new FilterLogEventsResponse() { NextToken = null };
            var token = new CancellationToken();

            _mockClient.SetupSequence(x => x.FilterLogEventsAsync(It.IsAny<FilterLogEventsRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(firstResponse)
                .ReturnsAsync(secondResponse);

            var numResponses = 0;
            await foreach (var logEvent in _mockClient.Object.Paginators.FilterLogEvents(request).Responses.WithCancellation(token))
            {
                numResponses += 1;
            }
            Assert.AreEqual(2, numResponses);
        }

        [TestMethod]
        public async Task FilterLogEventsTest__OnlyUsedOnce()
        {
            var request = new FilterLogEventsRequest();
            var response = new FilterLogEventsResponse();
            var token = new CancellationToken();
            var paginator = _mockClient.Object.Paginators.FilterLogEvents(request);

            _mockClient.Setup(x => x.FilterLogEventsAsync(It.IsAny<FilterLogEventsRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(response);

            await LoopOverFilterLogEvents(paginator, token);
            await Assert.ThrowsExceptionAsync<System.InvalidOperationException>(async () => await LoopOverFilterLogEvents(paginator, token));
        }

        private async Task LoopOverFilterLogEvents(IFilterLogEventsPaginator paginator, CancellationToken token)
        {
            await foreach (var logEvent in paginator.Responses.WithCancellation(token)) ;
        }

        [TestMethod]
        public async Task FilterLogEventsTest__CancellationToken()
        {
            var request = new FilterLogEventsRequest();
            var firstResponse = new FilterLogEventsResponse() { NextToken = "foo" };
            var secondResponse = new FilterLogEventsResponse() { NextToken = null };
            var paginator = _mockClient.Object.Paginators.FilterLogEvents(request);

            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;
            tokenSource.Cancel();

            _mockClient.SetupSequence(x => x.FilterLogEventsAsync(It.IsAny<FilterLogEventsRequest>(), It.IsAny<CancellationToken>()))
                 .ReturnsAsync(firstResponse)
                 .ReturnsAsync(secondResponse);

            await Assert.ThrowsExceptionAsync<OperationCanceledException>(async () => await LoopOverFilterLogEvents(paginator, token));
        }

        [TestMethod]
        public async Task GetLogEventsTest_TwoResponses()
        {
            var request = new GetLogEventsRequest();
            var firstResponse = new GetLogEventsResponse() { NextForwardToken = "foo" };
            var secondResponse = new GetLogEventsResponse() { NextForwardToken = "foo" };
            var token = new CancellationToken();

            _mockClient.SetupSequence(x => x.GetLogEventsAsync(It.IsAny<GetLogEventsRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(firstResponse)
                .ReturnsAsync(secondResponse);

            var numResponses = 0;
            await foreach (var logEvent in _mockClient.Object.Paginators.GetLogEvents(request).Responses.WithCancellation(token))
            {
                numResponses += 1;
            }
            Assert.AreEqual(2, numResponses);
        }

        [TestMethod]
        public async Task GetLogEventsTest__OnlyUsedOnce()
        {
            var request = new GetLogEventsRequest();
            var response = new GetLogEventsResponse();
            var token = new CancellationToken();
            var paginator = _mockClient.Object.Paginators.GetLogEvents(request);

            _mockClient.Setup(x => x.GetLogEventsAsync(It.IsAny<GetLogEventsRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(response);

            await LoopOverGetLogEvents(paginator, token);
            await Assert.ThrowsExceptionAsync<System.InvalidOperationException>(async () => await LoopOverGetLogEvents(paginator, token));
        }

        private async Task LoopOverGetLogEvents(IGetLogEventsPaginator paginator, CancellationToken token)
        {
            await foreach (var logEvent in paginator.Responses.WithCancellation(token)) ;
        }

        [TestMethod]
        public async Task GetLogEventsTest__CancellationToken()
        {
            var request = new GetLogEventsRequest();
            var firstResponse = new GetLogEventsResponse() { NextForwardToken = "foo" };
            var secondResponse = new GetLogEventsResponse() { NextForwardToken = null };
            var paginator = _mockClient.Object.Paginators.GetLogEvents(request);

            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;
            tokenSource.Cancel();

            _mockClient.SetupSequence(x => x.GetLogEventsAsync(It.IsAny<GetLogEventsRequest>(), It.IsAny<CancellationToken>()))
                 .ReturnsAsync(firstResponse)
                 .ReturnsAsync(secondResponse);

            await Assert.ThrowsExceptionAsync<OperationCanceledException>(async () => await LoopOverGetLogEvents(paginator, token));
        }
    }
}
#endif
