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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Contains information about the Amazon Kinesis data stream where you are sending real-time
    /// log data.
    /// </summary>
    public partial class KinesisStreamConfig
    {
        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Identity and Access Management (IAM) role that
        /// CloudFront can use to send real-time log data to your Kinesis data stream.
        /// </para>
        ///  
        /// <para>
        /// For more information the IAM role, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/real-time-logs.html#understand-real-time-log-config-iam-role">Real-time
        /// log configuration IAM role</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleARN { get; set; }

        /// <summary>
        /// Checks to see if the RoleARN property is set.
        /// </summary>
        internal bool IsSetRoleARN() => this.RoleARN != null;

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Kinesis data stream where you are sending real-time
        /// log data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StreamARN { get; set; }

        /// <summary>
        /// Checks to see if the StreamARN property is set.
        /// </summary>
        internal bool IsSetStreamARN() => this.StreamARN != null;
    }
}
