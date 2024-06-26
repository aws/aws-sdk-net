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
using System;
using System.Collections.Generic;
using System.Linq;
using Amazon.Auth.AccessControlPolicy;
using System.Globalization;

namespace Amazon.SimpleNotificationService
{
    public partial class AmazonSimpleNotificationServiceClient
    {
        /// <summary>
        /// Add statement to the policy that gives the sns topic access to send a message to the queue.
        /// </summary>
        /// <param name="policy"></param>
        /// <param name="topicArn"></param>
        /// <param name="sqsQueueArn"></param>
        private static void AddSQSPermission(Policy policy, string topicArn, string sqsQueueArn)
        {
            Statement statement = new Statement(Statement.StatementEffect.Allow);
            statement.Actions.Add("sqs:SendMessage");
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

        /// <summary>
        /// Verifies that the ARN for the topic matches the topic name
        /// </summary>
        /// <param name="topicArn"></param>
        /// <param name="topicName"></param>
        /// <returns></returns>
        private static bool TopicNameMatcher(string topicArn, string topicName)
        {
            if (String.IsNullOrEmpty(topicArn))
            {
                return false;
            }

            if (String.IsNullOrEmpty(topicName))
            {
                return false;
            }

            int indexOfLastColon = topicArn.LastIndexOf(":", StringComparison.OrdinalIgnoreCase);

            if (indexOfLastColon.Equals(-1))
            {
                return false;
            }

            return topicArn.Substring(indexOfLastColon + 1).Equals(topicName);
        }

        /// <summary>
        /// Helper method for AuthorizeS3ToPublishAsync()
        /// </summary>
        /// <param name="attributes"></param>
        /// <param name="topicArn"></param>
        /// <param name="bucket"></param>
        /// <param name="policy"></param>
        /// <param name="statement"></param>
        private static void GetNewPolicyAndStatementForTopicAttributes(Dictionary<string, string> attributes, string topicArn, string bucket, out Policy policy, out Statement statement)
        {
            if(attributes.ContainsKey("Policy") && !string.IsNullOrEmpty(attributes["Policy"]))
            {
                policy = Policy.FromJson(attributes["Policy"]);
            }
            else
            {
                policy = new Policy();
            }

            var sourceArn = string.Format(CultureInfo.InvariantCulture, "arn:aws:s3:*:*:{0}", bucket);

            statement = new Statement(Statement.StatementEffect.Allow);
            statement.Actions.Add("sns:Publish");
            statement.Resources.Add(new Resource(topicArn));
            statement.Principals.Add(new Principal("*"));
            statement.Conditions.Add(ConditionFactory.NewSourceArnCondition(sourceArn));

            // If the arn doesn't have the required tokens then it is most likely be called from a mock or fake AWS service.
            // Since this is an existing method we don't want to introduce a new exception. So if there is no account id then
            // don't add the extra condition.
            if (Arn.TryParse(topicArn, out Arn arn) && !string.IsNullOrEmpty(arn.AccountId))
            {
                statement.Conditions.Add(ConditionFactory.NewCondition(ConditionFactory.StringComparisonType.StringEquals, ConditionFactory.SOURCE_ACCOUNT_KEY, arn.AccountId));
            }
        }
    }
}
