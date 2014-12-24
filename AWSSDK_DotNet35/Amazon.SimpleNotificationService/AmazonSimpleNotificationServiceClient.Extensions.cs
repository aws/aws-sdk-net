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
using System.Text;

using Amazon.Runtime;

using Amazon.SimpleNotificationService.Model;

using Amazon.SQS;
using Amazon.SQS.Model;

#if BCL
using Amazon.Auth.AccessControlPolicy;
using Amazon.Auth.AccessControlPolicy.ActionIdentifiers;
using System.Globalization;
#endif


namespace Amazon.SimpleNotificationService
{
    public partial class AmazonSimpleNotificationServiceClient
    {

#if BCL
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
        public string SubscribeQueue(string topicArn, IAmazonSQS sqsClient, string sqsQueueUrl)
        {
            // Get the queue's existing policy and ARN
            var getAttributeResponse = sqsClient.GetQueueAttributes(new GetQueueAttributesRequest()
            {
                AttributeNames = new List<string>() { "All" },
                QueueUrl = sqsQueueUrl
            });

            string sqsQueueArn = getAttributeResponse.QueueARN;

            Policy policy;
            string policyStr = getAttributeResponse.Policy;
            if (string.IsNullOrEmpty(policyStr))
                policy = new Policy();
            else
                policy = Policy.FromJson(policyStr);

            if (!HasSQSPermission(policy, topicArn, sqsQueueArn))
            {
                AddSQSPermission(policy, topicArn, sqsQueueArn);
                sqsClient.SetQueueAttributes(new SetQueueAttributesRequest()
                {
                    QueueUrl = sqsQueueUrl,
                    Attributes = new Dictionary<string, string>() { { "Policy", policy.ToJson() } }
                });
            }

            var subscribeResponse = this.Subscribe(new SubscribeRequest()
            {
                TopicArn = topicArn,
                Protocol = "sqs",
                Endpoint = sqsQueueArn
            });

            return subscribeResponse.SubscriptionArn;
        }

        /// <summary>
        /// Add statement to the policy that gives the sns topic access to send a message to the queue.
        /// </summary>
        /// <param name="policy"></param>
        /// <param name="topicArn"></param>
        /// <param name="sqsQueueArn"></param>
        private static void AddSQSPermission(Policy policy, string topicArn, string sqsQueueArn)
        {
            Statement statement = new Statement(Statement.StatementEffect.Allow);
            statement.Actions.Add(SQSActionIdentifiers.SendMessage);
            statement.Resources.Add(new Resource(sqsQueueArn));
            statement.Conditions.Add(ConditionFactory.NewSourceArnCondition(topicArn));
            statement.Principals.Add(new Principal("*"));
            policy.Statements.Add(statement);
        }

        /// <summary>
        /// Check to see if the policy for the queue has already given permission to the topic.
        /// </summary>
        /// <param name="policy"></param>
        /// <param name="topicArn"></param>
        /// <param name="sqsQueueArn"></param>
        /// <returns></returns>
        private static bool HasSQSPermission(Policy policy, string topicArn, string sqsQueueArn)
        {
            foreach (Statement statement in policy.Statements)
            {
                // See if the statement contains the topic as a resource
                bool containsResource = false;
                foreach (var resource in statement.Resources)
                {
                    if (resource.Id.Equals(sqsQueueArn))
                    {
                        containsResource = true;
                        break;
                    }
                }

                // If queue found as the resource see if the condition is for this topic
                if (containsResource)
                {
                    foreach (var condition in statement.Conditions)
                    {
                        if ((string.Equals(condition.Type, ConditionFactory.StringComparisonType.StringLike.ToString(), StringComparison.OrdinalIgnoreCase) ||
                                string.Equals(condition.Type, ConditionFactory.StringComparisonType.StringEquals.ToString(), StringComparison.OrdinalIgnoreCase) ||
                                string.Equals(condition.Type, ConditionFactory.ArnComparisonType.ArnEquals.ToString(), StringComparison.OrdinalIgnoreCase) ||
                                string.Equals(condition.Type, ConditionFactory.ArnComparisonType.ArnLike.ToString(), StringComparison.OrdinalIgnoreCase)) &&
                            string.Equals(condition.ConditionKey, ConditionFactory.SOURCE_ARN_CONDITION_KEY, StringComparison.OrdinalIgnoreCase) &&
                            condition.Values.Contains<string>(topicArn))
                            return true;
                    }
                }
            }

            return false;
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
            if(attributes.ContainsKey("Policy") && !string.IsNullOrEmpty(attributes["Policy"]))
            {
                policy = Policy.FromJson(attributes["Policy"]);
            }
            else
            {
                policy = new Policy();
            }

            var sourceArn = string.Format(CultureInfo.InvariantCulture, "arn:aws:s3:*:*:{0}", bucket);

            Statement statement = new Statement(Statement.StatementEffect.Allow);
            statement.Actions.Add(SNSActionIdentifiers.Publish);
            statement.Resources.Add(new Resource(topicArn));
            statement.Conditions.Add(ConditionFactory.NewSourceArnCondition(sourceArn));
            statement.Principals.Add(new Principal("*"));
            policy.Statements.Add(statement);

            var policyString = policy.ToJson();
            this.SetTopicAttributes(new SetTopicAttributesRequest
            {
                TopicArn = topicArn,
                AttributeName = "Policy",
                AttributeValue = policyString
            });
        }
#endif

        /// <summary>
        /// Returns a list of the requester's subscriptions. Each call returns a limited list
        ///      of subscriptions, up to 100. If there are more subscriptions, a <code>NextToken</code>
        /// is also returned. Use the <code>NextToken</code> parameter in a       new <code>ListSubscriptions</code>
        /// call to get further results.
        /// </summary>
        /// <param name="nextToken">Token returned by the previous <code>ListSubscriptions</code> request.</param>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        public ListSubscriptionsResponse ListSubscriptions(string nextToken)
        {
            var request = new ListSubscriptionsRequest();
            request.NextToken = nextToken;
            return ListSubscriptions(request);
        }

        /// <summary>
        /// Returns a list of the subscriptions to a specific topic. Each call returns       a
        /// limited list of subscriptions, up to 100. If there are more subscriptions, a <code>NextToken</code>
        /// is also returned. Use the <code>NextToken</code>       parameter in a new <code>ListSubscriptionsByTopic</code>
        /// call to get further results.
        /// </summary>
        /// <param name="topicArn">The ARN of the topic for which you wish to find subscriptions.</param>
        /// <param name="nextToken">Token returned by the previous <code>ListSubscriptionsByTopic</code> request.</param>
        /// 
        /// <returns>The response from the ListSubscriptionsByTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        public ListSubscriptionsByTopicResponse ListSubscriptionsByTopic(string topicArn, string nextToken)
        {
            var request = new ListSubscriptionsByTopicRequest();
            request.TopicArn = topicArn;
            request.NextToken = nextToken;
            return ListSubscriptionsByTopic(request);
        }

        /// <summary>
        /// Returns a list of the requester's topics. Each call returns a limited list of topics,
        /// up to 100. If      there are more topics, a <code>NextToken</code> is also returned.
        /// Use the <code>NextToken</code> parameter in a new <code>ListTopics</code> call to
        /// get      further results.
        /// </summary>
        /// <param name="nextToken">Token returned by the previous <code>ListTopics</code> request.</param>
        /// 
        /// <returns>The response from the ListTopics service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        public ListTopicsResponse ListTopics(string nextToken)
        {
            var request = new ListTopicsRequest();
            request.NextToken = nextToken;
            return ListTopics(request);
        }
    }
}
