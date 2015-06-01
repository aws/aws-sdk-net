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
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the PutBucketNotification operation.
    /// <para>Enables notifications of specified events for a bucket.</para>
    /// </summary>
    public partial class PutBucketNotificationRequest : AmazonWebServiceRequest
    {
        /// <summary>
        /// Gets and sets the BucketName property.
        /// </summary>
        public string BucketName { get; set; }

        // Check to see if Bucket property is set
        internal bool IsSetBucketName()
        {
            return this.BucketName != null;
        }

        /// <summary>
        /// Gets and sets the TopicConfigurations property. TopicConfigurations are configuration for Amazon S3 
        /// events to be sent to Amazon SNS topics.
        /// </summary>
        public List<TopicConfiguration> TopicConfigurations {get; set;}

        internal bool IsSetTopicConfigurations()
        {
            return this.TopicConfigurations != null && TopicConfigurations.Count > 0;
        }

        /// <summary>
        /// Gets and sets the QueueConfigurations property. QueueConfigurations are configuration for Amazon S3 
        /// events to be sent to Amazon SQS queues.
        /// </summary>
        public List<QueueConfiguration> QueueConfigurations { get; set; }

        internal bool IsSetQueueConfigurations()
        {
            return this.QueueConfigurations != null && QueueConfigurations.Count > 0;
        }



        /// <summary>
        /// Gets and sets the LambdaFunctionConfigurations property. LambdaFunctionConfigurations are configuration for 
        /// Amazon S3 events to be sent to an Amazon Lambda cloud function.
        /// </summary>
        public List<LambdaFunctionConfiguration> LambdaFunctionConfigurations { get; set; }

        internal bool IsSetLambdaFunctionConfigurations()
        {
            return this.LambdaFunctionConfigurations != null && LambdaFunctionConfigurations.Count > 0;
        }
    }
}
    
