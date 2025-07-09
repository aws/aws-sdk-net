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

using Amazon.Runtime.SharedInterfaces;

namespace Amazon.SQS
{
    public partial interface IAmazonSQS : IDisposable, ICoreAmazonSQS
    {

#if BCL
        /// <summary>
        /// This is a utility method which updates the policy of a queue to allow the
        /// S3 bucket to publish events to it.
        /// </summary>
        /// <param name="queueUrl">The queue that will have its policy updated.</param>
        /// <param name="bucket">The bucket that will be given access to send messages from.</param>
        /// <returns>The ARN for the SQS queue. This can be used when setting up the S3 bucket notification.</returns>
        string AuthorizeS3ToSendMessage(string queueUrl, string bucket);
#endif

        /// <summary>
        /// This is a utility method which asynchronously updates the policy of a queue to allow the
        /// S3 bucket to publish events to it.
        /// </summary>
        /// <param name="queueUrl">The queue that will have its policy updated.</param>
        /// <param name="bucket">The bucket that will be given access to send messages from.</param>
        /// <returns>A Task containing the ARN for the SQS queue. This can be used when setting up the S3 bucket notification.</returns>
        System.Threading.Tasks.Task<string> AuthorizeS3ToSendMessageAsync(string queueUrl, string bucket);
    }
}