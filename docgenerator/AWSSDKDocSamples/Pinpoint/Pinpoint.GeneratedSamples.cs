using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Pinpoint;
using Amazon.Pinpoint.Model;

namespace AWSSDKDocSamples.Amazon.Pinpoint.Generated
{
    class PinpointSamples : ISample
    {
        public void PinpointGetJourneyRunExecutionActivityMetrics()
        {
            #region to-get-the-activity-execution-metrics-for-a-journey-run

            var client = new AmazonPinpointClient();
            var response = client.GetJourneyRunExecutionActivityMetrics(new GetJourneyRunExecutionActivityMetricsRequest 
            {
                ApplicationId = "11111111112222222222333333333344",
                JourneyId = "aaaaaaaaaabbbbbbbbbbccccccccccdd",
                RunId = "99999999998888888888777777777766",
                JourneyActivityId = "AAAAAAAAAA"
            });

            JourneyRunExecutionActivityMetricsResponse journeyRunExecutionActivityMetricsResponse = response.JourneyRunExecutionActivityMetricsResponse;

            #endregion
        }

        public void PinpointGetJourneyRunExecutionMetrics()
        {
            #region to-get-the-execution-metrics-for-a-journey-run

            var client = new AmazonPinpointClient();
            var response = client.GetJourneyRunExecutionMetrics(new GetJourneyRunExecutionMetricsRequest 
            {
                ApplicationId = "11111111112222222222333333333344",
                JourneyId = "aaaaaaaaaabbbbbbbbbbccccccccccdd",
                RunId = "99999999998888888888777777777766"
            });

            JourneyRunExecutionMetricsResponse journeyRunExecutionMetricsResponse = response.JourneyRunExecutionMetricsResponse;

            #endregion
        }

        public void PinpointGetJourneyRuns()
        {
            #region to-get-the-runs-of-a-journey

            var client = new AmazonPinpointClient();
            var response = client.GetJourneyRuns(new GetJourneyRunsRequest 
            {
                ApplicationId = "11111111112222222222333333333344",
                JourneyId = "aaaaaaaaaabbbbbbbbbbccccccccccdd"
            });

            JourneyRunsResponse journeyRunsResponse = response.JourneyRunsResponse;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}