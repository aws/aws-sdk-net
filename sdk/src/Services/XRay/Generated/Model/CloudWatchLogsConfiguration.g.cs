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

namespace Amazon.XRay.Model
{
    /// <summary>
    /// Contains the settings for the CloudWatch Logs log groups that X-Ray creates for Transaction
    /// Search.
    /// </summary>
    public partial class CloudWatchLogsConfiguration
    {
        /// <summary>
        /// Gets and sets the property SpansLogGroupKmsKeyId. 
        /// <para>
        ///  The ARN of an AWS Key Management Service (AWS KMS) key that you create and manage,
        /// in the same account and Region, used to encrypt the <c>aws/spans</c> log group. Key
        /// IDs and alias ARNs are not supported. 
        /// </para>
        ///  
        /// <para>
        ///  X-Ray applies the key only when it creates <c>aws/spans</c>. If the account already
        /// has an <c>aws/spans</c> log group, X-Ray fails the request with an <c>InvalidRequestException</c>
        /// and does not change the log group. To enable Transaction Search with the existing
        /// log group as it is, call <c>UpdateTraceSegmentDestination</c> again without <c>SpansLogGroupKmsKeyId</c>.
        /// To set or change the key of the existing log group, use the CloudWatch Logs <c>AssociateKmsKey</c>
        /// operation. 
        /// </para>
        ///  
        /// <para>
        ///  You need <c>kms:DescribeKey</c> permission on the key, and the key policy must allow
        /// CloudWatch Logs to use the key. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/encrypt-log-data-kms.html">Encrypt
        /// log data in CloudWatch Logs using AWS Key Management Service</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string SpansLogGroupKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the SpansLogGroupKmsKeyId property is set.
        /// </summary>
        internal bool IsSetSpansLogGroupKmsKeyId() => this.SpansLogGroupKmsKeyId != null;
    }
}
