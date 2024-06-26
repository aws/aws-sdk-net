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

using Amazon.Runtime;
using Amazon.Runtime.SharedInterfaces;

using Amazon.SQS.Model;

using Amazon.Auth.AccessControlPolicy;

namespace Amazon.SQS
{
    public partial class AmazonSQSClient : AmazonServiceClient, IAmazonSQS
    {
        Dictionary<string, string> ICoreAmazonSQS.GetAttributes(string queueUrl)
        {
            var getAttributeResponse = this.GetQueueAttributes(new GetQueueAttributesRequest()
            {
                AttributeNames = new List<string>() { "All" },
                QueueUrl = queueUrl
            });

            return getAttributeResponse.Attributes;
        }

        void ICoreAmazonSQS.SetAttributes(string queueUrl, Dictionary<string, string> attributes)
        {
            this.SetQueueAttributes(new SetQueueAttributesRequest()
            {
                QueueUrl = queueUrl,
                Attributes = attributes
            });
        }

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
            Statement statement;
            GetNewPolicyAndStatement(getAttributeResponse, bucket, out policy, out statement);

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
    }
}