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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
    /// The configuration for updating invocation settings.
    /// </summary>
    public partial class ModifyInvocationConfigurationInput
    {
        private string _payloadDeliveryBucketName;
        private string _topicArn;

        /// <summary>
        /// Gets and sets the property PayloadDeliveryBucketName. 
        /// <para>
        /// The updated S3 bucket name for event payload delivery.
        /// </para>
        /// </summary>
        public string PayloadDeliveryBucketName
        {
            get { return this._payloadDeliveryBucketName; }
            set { this._payloadDeliveryBucketName = value; }
        }

        // Check to see if PayloadDeliveryBucketName property is set
        internal bool IsSetPayloadDeliveryBucketName()
        {
            return this._payloadDeliveryBucketName != null;
        }

        /// <summary>
        /// Gets and sets the property TopicArn. 
        /// <para>
        /// The updated ARN of the SNS topic for job notifications.
        /// </para>
        /// </summary>
        public string TopicArn
        {
            get { return this._topicArn; }
            set { this._topicArn = value; }
        }

        // Check to see if TopicArn property is set
        internal bool IsSetTopicArn()
        {
            return this._topicArn != null;
        }

    }
}