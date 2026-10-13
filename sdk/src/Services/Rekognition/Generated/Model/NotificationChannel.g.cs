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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// The Amazon Simple Notification Service topic to which Amazon Rekognition publishes
    /// the completion status of a video analysis operation. For more information, see <a
    /// href="https://docs.aws.amazon.com/rekognition/latest/dg/api-video.html">Calling Amazon
    /// Rekognition Video operations</a>. Note that the Amazon SNS topic must have a topic
    /// name that begins with <i>AmazonRekognition</i> if you are using the AmazonRekognitionServiceRole
    /// permissions policy to access the topic. For more information, see <a href="https://docs.aws.amazon.com/rekognition/latest/dg/api-video-roles.html#api-video-roles-all-topics">Giving
    /// access to multiple Amazon SNS topics</a>.
    /// </summary>
    public partial class NotificationChannel
    {
        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of an IAM role that gives Amazon Rekognition publishing permissions to the
        /// Amazon SNS topic. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SNSTopicArn. 
        /// <para>
        /// The Amazon SNS topic to which Amazon Rekognition posts the completion status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SNSTopicArn { get; set; }

        /// <summary>
        /// Checks to see if the SNSTopicArn property is set.
        /// </summary>
        internal bool IsSetSNSTopicArn() => this.SNSTopicArn != null;
    }
}
