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


namespace Amazon.SQS
{
    public partial class AmazonSQSClient : AmazonServiceClient, IAmazonSQS
    {
#if BCL
        /// <summary>
        /// This is a utility method which updates the policy of a queue to allow the
        /// S3 bucket to publish events to it.
        /// </summary>
        /// <param name="queueUrl">The queue that will have its policy updated.</param>
        /// <param name="bucket">The bucket that will be given access to send messages from.</param>
        /// <returns>The ARN for the SQS queue. This can be used when setting up the S3 bucket notification.</returns>
        public string AuthorizeS3ToSendMessage(string queueUrl, string bucket)
        {
            var getAttributeResponse = this.GetQueueAttributes(new GetQueueAttributesRequest
            {
                QueueUrl = queueUrl,
                AttributeNames = new List<string> { "All"}
            });

            Policy policy;
            if (!string.IsNullOrEmpty(getAttributeResponse.Policy))
            {
                policy = Policy.FromJson(getAttributeResponse.Policy);
            }
            else
            {
                policy = new Policy();
            }

            var sourceArn = string.Format(CultureInfo.InvariantCulture, "arn:aws:s3:*:*:{0}", bucket);

            Statement statement = new Statement(Statement.StatementEffect.Allow);
            statement.Actions.Add(SQSActionIdentifiers.SendMessage);
            statement.Resources.Add(new Resource(getAttributeResponse.QueueARN));
            statement.Conditions.Add(ConditionFactory.NewSourceArnCondition(sourceArn));
            statement.Principals.Add(new Principal("*"));

            if (!policy.CheckIfStatementExists(statement))
            {
                policy.Statements.Add(statement);

                var policyString = policy.ToJson();
                this.SetQueueAttributes(new SetQueueAttributesRequest
                {
                    QueueUrl = queueUrl,
                    Attributes = new Dictionary<string, string>
                    {
                        {"Policy", policyString}
                    }
                });
            }

            return getAttributeResponse.QueueARN;
        }
#endif
    }
}