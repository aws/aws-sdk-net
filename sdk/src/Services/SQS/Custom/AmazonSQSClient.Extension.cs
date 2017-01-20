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

using Amazon.Runtime;
using Amazon.SQS.Model;

using Amazon.Auth.AccessControlPolicy;
using Amazon.Auth.AccessControlPolicy.ActionIdentifiers;
using System.Globalization;

namespace Amazon.SQS
{
    public partial class AmazonSQSClient : AmazonServiceClient, IAmazonSQS
    {
        /// <summary>
        /// Helper method for AuthorizeS3ToSendMessage()
        /// </summary>
        /// <param name="response"></param>
        /// <param name="bucket"></param>
        /// <param name="policy"></param>
        /// <param name="statement"></param>
        private static void GetNewPolicyAndStatement(GetQueueAttributesResponse response, string bucket, out Policy policy, out Statement statement)
        {
            if (!string.IsNullOrEmpty(response.Policy))
            {
                policy = Policy.FromJson(response.Policy);
            }
            else
            {
                policy = new Policy();
            }

            var sourceArn = string.Format(CultureInfo.InvariantCulture, "arn:aws:s3:*:*:{0}", bucket);

            statement = new Statement(Statement.StatementEffect.Allow);
            statement.Actions.Add(SQSActionIdentifiers.SendMessage);
            statement.Resources.Add(new Resource(response.QueueARN));
            statement.Conditions.Add(ConditionFactory.NewSourceArnCondition(sourceArn));
            statement.Principals.Add(new Principal("*"));
        }
    }
}