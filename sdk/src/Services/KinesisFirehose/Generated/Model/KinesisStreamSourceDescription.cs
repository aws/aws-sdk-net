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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Details about a Kinesis data stream used as the source for a Kinesis Data Firehose
    /// delivery stream.
    /// </summary>
    public partial class KinesisStreamSourceDescription
    {
        private DateTime? _deliveryStartTimestamp;
        private string _kinesisStreamARN;
        private string _roleARN;

        /// <summary>
        /// Gets and sets the property DeliveryStartTimestamp. 
        /// <para>
        /// Kinesis Data Firehose starts retrieving records from the Kinesis data stream starting
        /// with this timestamp.
        /// </para>
        /// </summary>
        public DateTime DeliveryStartTimestamp
        {
            get { return this._deliveryStartTimestamp.GetValueOrDefault(); }
            set { this._deliveryStartTimestamp = value; }
        }

        // Check to see if DeliveryStartTimestamp property is set
        internal bool IsSetDeliveryStartTimestamp()
        {
            return this._deliveryStartTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KinesisStreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source Kinesis data stream. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-kinesis-streams">Amazon
        /// Kinesis Data Streams ARN Format</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string KinesisStreamARN
        {
            get { return this._kinesisStreamARN; }
            set { this._kinesisStreamARN = value; }
        }

        // Check to see if KinesisStreamARN property is set
        internal bool IsSetKinesisStreamARN()
        {
            return this._kinesisStreamARN != null;
        }

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The ARN of the role used by the source Kinesis data stream. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-iam">Amazon
        /// Web Services Identity and Access Management (IAM) ARN Format</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string RoleARN
        {
            get { return this._roleARN; }
            set { this._roleARN = value; }
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._roleARN != null;
        }

    }
}