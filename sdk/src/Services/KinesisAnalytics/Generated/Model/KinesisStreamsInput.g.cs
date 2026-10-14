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

namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Identifies an Amazon Kinesis stream as the streaming source. You provide the stream's
    /// Amazon Resource Name (ARN) and an IAM role ARN that enables Amazon Kinesis Analytics
    /// to access the stream on your behalf.
    /// </summary>
    public partial class KinesisStreamsInput
    {
        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        /// ARN of the input Amazon Kinesis stream to read.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ResourceARN { get; set; }

        /// <summary>
        /// Checks to see if the ResourceARN property is set.
        /// </summary>
        internal bool IsSetResourceARN() => this.ResourceARN != null;

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// ARN of the IAM role that Amazon Kinesis Analytics can assume to access the stream
        /// on your behalf. You need to grant the necessary permissions to this role.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string RoleARN { get; set; }

        /// <summary>
        /// Checks to see if the RoleARN property is set.
        /// </summary>
        internal bool IsSetRoleARN() => this.RoleARN != null;
    }
}
