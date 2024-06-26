/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;
using System.Linq;

using Amazon.Auth.AccessControlPolicy;
using Amazon.Runtime.SharedInterfaces;
using Amazon.SimpleNotificationService.Model;


namespace Amazon.SimpleNotificationService
{
    public partial class AmazonSimpleNotificationServiceClient
    {

        #region SubscribeQueue

        /// <summary>
        /// Subscribes an existing Amazon SQS queue to an existing Amazon SNS topic.
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
        public string SubscribeQueue(string topicArn, ICoreAmazonSQS sqsClient, string sqsQueueUrl)
        {
            return SubscribeQueueToTopics(new List<string>() { topicArn }, sqsClient, sqsQueueUrl).Values.First();
        }

        /// <summary>
        /// Subscribes an existing Amazon SQS queue to existing Amazon SNS topics.
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
        public IDictionary<string, string> SubscribeQueueToTopics(IList<string> topicArns, ICoreAmazonSQS sqsClient, string sqsQueueUrl)
        {
            // Get the queue's existing policy and ARN
            var queueAttributes = sqsClient.GetAttributes(sqsQueueUrl);

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

                var arn = this.Subscribe(new SubscribeRequest
                {
                    TopicArn = topicArn,
                    Protocol = "sqs",
                    Endpoint = sqsQueueArn
                }).SubscriptionArn;

                subscriptionArns.Add(topicArn, arn);
            }

            var setAttributes = new Dictionary<string, string> { { "Policy", policy.ToJson() } };
            sqsClient.SetAttributes(sqsQueueUrl, setAttributes);

            return subscriptionArns;
        }

        #endregion

        #region FindTopic

        /// <summary>
        /// Finds an existing Amazon SNS topic by iterating all SNS topics until a match is found.
        /// <para>
        /// The ListTopics method is used to fetch upto 100 SNS topics at a time until a SNS topic 
        /// with an TopicArn that matches <paramref name="topicName"/> is found.
        /// </para>
        /// </summary>
        /// <param name="topicName">The name of the topic find</param>
        /// <returns>The matched SNS topic.</returns>
        public Topic FindTopic(string topicName)
        {
            var nextToken = string.Empty;

            do
            {
                var response = this.ListTopics(new ListTopicsRequest { NextToken = nextToken });

                var matchedTopic = response.Topics.FirstOrDefault(x => TopicNameMatcher(x.TopicArn, topicName));

                if (matchedTopic != null)
                {
                    return matchedTopic;
                }

                nextToken = response.NextToken;

            } while (!string.IsNullOrEmpty(nextToken));

            return null;
        }
        #endregion


        /// <summary>
        /// This is a utility method which updates the policy of a topic to allow the
        /// S3 bucket to publish events to it.
        /// </summary>
        /// <param name="topicArn">The topic that will have its policy updated.</param>
        /// <param name="bucket">The bucket that will be given access to publish from.</param>
        public void AuthorizeS3ToPublish(string topicArn, string bucket)
        {
            var attributes = this.GetTopicAttributes(new GetTopicAttributesRequest
                {
                    TopicArn = topicArn
                }).Attributes;

            Policy policy;
            Statement newStatement;
            GetNewPolicyAndStatementForTopicAttributes(attributes, topicArn, bucket, out policy, out newStatement);

            if (!policy.CheckIfStatementExists(newStatement))
            {
                policy.Statements.Add(newStatement);

                var policyString = policy.ToJson();
                this.SetTopicAttributes(new SetTopicAttributesRequest
                {
                    TopicArn = topicArn,
                    AttributeName = "Policy",
                    AttributeValue = policyString
                });
            }
        }
    }
}
