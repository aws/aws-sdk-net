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

namespace Amazon.ChimeSDKMeetings.Model
{
    /// <summary>
    /// The configuration for resource targets to receive notifications when meeting and attendee
    /// events occur.
    /// </summary>
    public partial class NotificationsConfiguration
    {
        /// <summary>
        /// Gets and sets the property LambdaFunctionArn. 
        /// <para>
        /// The ARN of the Amazon Web Services Lambda function in the notifications configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string LambdaFunctionArn { get; set; }

        /// <summary>
        /// Checks to see if the LambdaFunctionArn property is set.
        /// </summary>
        internal bool IsSetLambdaFunctionArn() => this.LambdaFunctionArn != null;

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// The ARN of the SNS topic.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string SnsTopicArn { get; set; }

        /// <summary>
        /// Checks to see if the SnsTopicArn property is set.
        /// </summary>
        internal bool IsSetSnsTopicArn() => this.SnsTopicArn != null;

        /// <summary>
        /// Gets and sets the property SqsQueueArn. 
        /// <para>
        /// The ARN of the SQS queue.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string SqsQueueArn { get; set; }

        /// <summary>
        /// Checks to see if the SqsQueueArn property is set.
        /// </summary>
        internal bool IsSetSqsQueueArn() => this.SqsQueueArn != null;
    }
}
