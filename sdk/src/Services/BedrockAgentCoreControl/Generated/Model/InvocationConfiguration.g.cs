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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The configuration to invoke a self-managed memory processing pipeline with.
    /// </summary>
    public partial class InvocationConfiguration
    {
        /// <summary>
        /// Gets and sets the property PayloadDeliveryBucketName. 
        /// <para>
        /// The S3 bucket name for event payload delivery.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PayloadDeliveryBucketName { get; set; }

        /// <summary>
        /// Checks to see if the PayloadDeliveryBucketName property is set.
        /// </summary>
        internal bool IsSetPayloadDeliveryBucketName() => this.PayloadDeliveryBucketName != null;

        /// <summary>
        /// Gets and sets the property TopicArn. 
        /// <para>
        /// The ARN of the SNS topic for job notifications.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TopicArn { get; set; }

        /// <summary>
        /// Checks to see if the TopicArn property is set.
        /// </summary>
        internal bool IsSetTopicArn() => this.TopicArn != null;
    }
}
