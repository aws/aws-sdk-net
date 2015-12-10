using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.SQS;
using Amazon.SQS.Model;

namespace AWSSDKDocSamples.Amazon.SQS.Generated
{
    class SQSSamples : ISample
    {
        static IAmazonSQS client = new AmazonSQSClient();
        public void SQSCreateQueue()
        {
            #region create-an-sqs-queue-1445915686197

            var response = client.CreateQueue(new CreateQueueRequest 
            {
                QueueName = "MyQueue", // The Name for the new queue
                Attributes = new Dictionary<string, string> {
                    { "foo", "bar" },
                    { "ghoti", "fish" }
                }
            });

            string queueUrl = response.QueueUrl; // The URL of the new queue

            #endregion
        }

        public void SQSGetQueueUrl()
        {
            #region retrieve-queue-attributes-from-an-sqs-queue-1445915930574

            var response = client.GetQueueUrl(new GetQueueUrlRequest 
            {
                QueueName = "MyQueue",
                QueueOwnerAWSAccountId = "12345678910"
            });

            string queueUrl = response.QueueUrl;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}