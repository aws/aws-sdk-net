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

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Details about a Kinesis data stream used as the source for a Firehose stream.
    /// </summary>
    public partial class KinesisStreamSourceDescription
    {
        /// <summary>
        /// Gets and sets the property DeliveryStartTimestamp. 
        /// <para>
        /// Firehose starts retrieving records from the Kinesis data stream starting with this
        /// timestamp.
        /// </para>
        /// </summary>
        public DateTime? DeliveryStartTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryStartTimestamp property is set.
        /// </summary>
        internal bool IsSetDeliveryStartTimestamp() => this.DeliveryStartTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property KinesisStreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source Kinesis data stream. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-kinesis-streams">Amazon
        /// Kinesis Data Streams ARN Format</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string KinesisStreamARN { get; set; }

        /// <summary>
        /// Checks to see if the KinesisStreamARN property is set.
        /// </summary>
        internal bool IsSetKinesisStreamARN() => this.KinesisStreamARN != null;

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The ARN of the role used by the source Kinesis data stream. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-iam">Amazon
        /// Web Services Identity and Access Management (IAM) ARN Format</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string RoleARN { get; set; }

        /// <summary>
        /// Checks to see if the RoleARN property is set.
        /// </summary>
        internal bool IsSetRoleARN() => this.RoleARN != null;
    }
}
