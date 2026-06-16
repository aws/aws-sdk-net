using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.SagemakerJobRuntime;
using Amazon.SagemakerJobRuntime.Model;

namespace AWSSDKDocSamples.Amazon.SagemakerJobRuntime.Generated
{
    class SagemakerJobRuntimeSamples : ISample
    {
        public void SagemakerJobRuntimeCompleteRollout()
        {
            #region example-1

            var client = new AmazonSagemakerJobRuntimeClient();
            var response = client.CompleteRollout(new CompleteRolloutRequest 
            {
                JobArn = "arn:aws:sagemaker:us-east-1:123456789012:job/AgentRFT/my-training-job",
                Status = "ready",
                TrajectoryId = "trajectory-001"
            });


            #endregion
        }

        public void SagemakerJobRuntimeSample()
        {
            #region example-1

            var client = new AmazonSagemakerJobRuntimeClient();
            var response = client.Sample(new SampleRequest 
            {
                Body = new MemoryStream(eyJtb2RlbCI6Im15LW1vZGVsIiwibWVzc2FnZXMiOlt7InJvbGUiOiJ1c2VyIiwiY29udGVudCI6IkhlbGxvIn1dfQ==),
                JobArn = "arn:aws:sagemaker:us-east-1:123456789012:job/AgentRFT/my-training-job",
                TrajectoryId = "trajectory-001"
            });


            #endregion
        }

        public void SagemakerJobRuntimeSampleWithResponseStream()
        {
            #region example-1

            var client = new AmazonSagemakerJobRuntimeClient();
            var response = client.SampleWithResponseStream(new SampleWithResponseStreamRequest 
            {
                Body = new MemoryStream(eyJtb2RlbCI6Im15LW1vZGVsIiwibWVzc2FnZXMiOlt7InJvbGUiOiJ1c2VyIiwiY29udGVudCI6IkhlbGxvIn1dfQ==),
                JobArn = "arn:aws:sagemaker:us-east-1:123456789012:job/AgentRFT/my-training-job",
                TrajectoryId = "trajectory-001"
            });


            #endregion
        }

        public void SagemakerJobRuntimeUpdateReward()
        {
            #region example-1

            var client = new AmazonSagemakerJobRuntimeClient();
            var response = client.UpdateReward(new UpdateRewardRequest 
            {
                JobArn = "arn:aws:sagemaker:us-east-1:123456789012:job/AgentRFT/my-training-job",
                Rewards = new List<double> {
                    0.85,
                    0.92,
                    0.78
                },
                TrajectoryId = "trajectory-001"
            });


            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}