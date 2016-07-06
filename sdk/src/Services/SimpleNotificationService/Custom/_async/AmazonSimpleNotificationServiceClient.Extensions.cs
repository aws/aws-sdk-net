/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

using Amazon.Runtime;
using Amazon.Runtime.SharedInterfaces;

using Amazon.SimpleNotificationService.Model;

using Amazon.Auth.AccessControlPolicy;
using Amazon.Auth.AccessControlPolicy.ActionIdentifiers;
using System.Globalization;

namespace Amazon.SimpleNotificationService
{
    public partial class AmazonSimpleNotificationServiceClient
    {
        /// <summary>
        /// Subscribes an existing Amazon SQS queue to an existing Amazon SNS topic asynchronously.
        /// <para>
        /// The policy applied to the SQS queue is similar to this:
        /// <code>
        /// {
        /// 	"Version" : "2008-10-17",
        /// 	"Statement" : [{
        /// 	    "Sid" : "topic-subscription-arn:aws:sns:us-west-2:599109622955:myTopic",
        /// 		"Effect" : "Allow",
        /// 		"Principal" : "*",
        /// 		"Action" : ["sqs:SendMessage"],
        /// 		"Resource":["arn:aws:sqs:us-west-2:599109622955:myQueue"],
        /// 		"Condition" : {
        /// 			"ArnLike":{
        /// 				"aws:SourceArn":["arn:aws:sns:us-west-2:599109622955:myTopic"]
        /// 			}
        /// 		}
        ///     }]
        /// }
        /// </code>
        /// </para>
        /// <para>
        /// There might be a small time period immediately after
        /// subscribing the SQS queue to the SNS topic and updating the SQS queue's
        /// policy, where messages are not able to be delivered to the queue. After a
        /// moment, the new queue policy will propagate and the queue will be able to
        /// receive messages. This delay only occurs immediately after initially
        /// subscribing the queue.
        /// </para>
        /// </summary>
        /// <param name="topicArn">The topic to subscribe to</param>
        /// <param name="sqsClient">The SQS client used to get attributes and set the policy on the SQS queue.</param>
        /// <param name="sqsQueueUrl">The queue to add a subscription to.</param>
        /// <returns>The subscription ARN as returned by Amazon SNS when the queue is 
        /// successfully subscribed to the topic.</returns>
        public async Task<string> SubscribeQueueAsync(string topicArn, ICoreAmazonSQS sqsClient, string sqsQueueUrl)
        {
            var topics = await SubscribeQueueToTopicsAsync(new List<string>() { topicArn }, sqsClient, sqsQueueUrl).ConfigureAwait(false);
            return topics.Values.First();
        }

        /// <summary>
        /// Subscribes an existing Amazon SQS queue to existing Amazon SNS topics asynchronously.
        /// <para>
        /// The policy applied to the SQS queue is similar to this:
        /// <code>
        /// {
        /// 	"Version" : "2008-10-17",
        /// 	"Statement" : [{
        /// 	    "Sid" : "topic-subscription-arn:aws:sns:us-west-2:599109622955:myTopic",
        /// 		"Effect" : "Allow",
        /// 		"Principal" : "*",
        /// 		"Action" : ["sqs:SendMessage"],
        /// 		"Resource":["arn:aws:sqs:us-west-2:599109622955:myQueue"],
        /// 		"Condition" : {
        /// 			"ArnLike":{
        /// 				"aws:SourceArn":["arn:aws:sns:us-west-2:599109622955:myTopic"]
        /// 			}
        /// 		}
        ///     }]
        /// }
        /// </code>
        /// </para>
        /// <para>
        /// There might be a small time period immediately after
        /// subscribing the SQS queue to the SNS topic and updating the SQS queue's
        /// policy, where messages are not able to be delivered to the queue. After a
        /// moment, the new queue policy will propagate and the queue will be able to
        /// receive messages. This delay only occurs immediately after initially
        /// subscribing the queue.
        /// </para>
        /// </summary>
        /// <param name="topicArns">The topics to subscribe to</param>
        /// <param name="sqsClient">The SQS client used to get attributes and set the policy on the SQS queue.</param>
        /// <param name="sqsQueueUrl">The queue to add a subscription to.</param>
        /// <returns>The mapping of topic ARNs to subscription ARNs as returned by Amazon SNS when the queue is 
        /// successfully subscribed to each topic.</returns>
        public async Task<IDictionary<string, string>> SubscribeQueueToTopicsAsync(IList<string> topicArns, ICoreAmazonSQS sqsClient, string sqsQueueUrl)
        {
            // Get the queue's existing policy and ARN
            var queueAttributes = await sqsClient.GetAttributesAsync(sqsQueueUrl).ConfigureAwait(false);

            string sqsQueueArn = queueAttributes["QueueArn"];

            Policy policy;
            string policyStr = null;
            if(queueAttributes.ContainsKey("Policy"))
                policyStr = queueAttributes["Policy"];
            if (string.IsNullOrEmpty(policyStr))
                policy = new Policy();
            else
                policy = Policy.FromJson(policyStr);

            var subscriptionArns = new Dictionary<string,string>();

            foreach (var topicArn in topicArns)
            {
                if (!HasSQSPermission(policy, topicArn, sqsQueueArn))
                    AddSQSPermission(policy, topicArn, sqsQueueArn);

                SubscribeResponse response = await this.SubscribeAsync(new SubscribeRequest
                {
                    TopicArn = topicArn,
                    Protocol = "sqs",
                    Endpoint = sqsQueueArn,
                }).ConfigureAwait(false);
                subscriptionArns.Add(topicArn, response.SubscriptionArn);
            }

            var setAttributes = new Dictionary<string, string> { { "Policy", policy.ToJson() } };
            await sqsClient.SetAttributesAsync(sqsQueueUrl, setAttributes).ConfigureAwait(false);

            return subscriptionArns;
        }
    }
}
