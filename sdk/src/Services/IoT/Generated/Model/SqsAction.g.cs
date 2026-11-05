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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Describes an action to publish data to an Amazon SQS queue.
    /// </summary>
    public partial class SqsAction
    {
        /// <summary>
        /// Gets and sets the property QueueUrl. 
        /// <para>
        /// The URL of the Amazon SQS queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string QueueUrl { get; set; }

        /// <summary>
        /// Checks to see if the QueueUrl property is set.
        /// </summary>
        internal bool IsSetQueueUrl() => this.QueueUrl != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that grants access.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property UseBase64. 
        /// <para>
        /// Specifies whether to use Base64 encoding.
        /// </para>
        /// </summary>
        public bool? UseBase64 { get; set; }

        /// <summary>
        /// Checks to see if the UseBase64 property is set.
        /// </summary>
        internal bool IsSetUseBase64() => this.UseBase64.HasValue;
    }
}
