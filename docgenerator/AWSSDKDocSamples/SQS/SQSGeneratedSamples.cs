using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.SQS;
using Amazon.SQS.Model;

namespace AWSSDKDocSamples.SQS.Generated
{
    class Amazon.SQSSamples : ISample
    {
        public void SQSCreateQueue()
        {
            #region create-an-sqs-queue-1445915686197
            var client = new AmazonSQSClient();

            var response = client.CreateQueue(new CreateQueueRequest 
            {
                QueueName = "MyQueue", // The Name for the new queue
                Attributes = new Dictionary<string, String> {
                    { "foo", "bar" },
                    { "ghoti", "fish" }
                }
            });
            #endregion
        }

        public void SQSGetQueueUrl()
        {
            #region retrieve-queue-attributes-from-an-sqs-queue-1445915930574
            var client = new AmazonSQSClient();

            var response = client.GetQueueUrl(new GetQueueUrlRequest 
            {
                QueueName = "MyQueue",
                QueueOwnerAWSAccountId = "12345678910"
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