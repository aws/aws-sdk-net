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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
    /// Contains information about the Amazon Kinesis data stream where you're sending real-time
    /// log data in a real-time log configuration.
    /// </summary>
    public partial class EndPoint
    {
        private KinesisStreamConfig _kinesisStreamConfig;
        private string _streamType;

        /// <summary>
        /// Gets and sets the property KinesisStreamConfig. 
        /// <para>
        /// Contains information about the Amazon Kinesis data stream where you are sending real-time
        /// log data in a real-time log configuration.
        /// </para>
        /// </summary>
        public KinesisStreamConfig KinesisStreamConfig
        {
            get { return this._kinesisStreamConfig; }
            set { this._kinesisStreamConfig = value; }
        }

        // Check to see if KinesisStreamConfig property is set
        internal bool IsSetKinesisStreamConfig()
        {
            return this._kinesisStreamConfig != null;
        }

        /// <summary>
        /// Gets and sets the property StreamType. 
        /// <para>
        /// The type of data stream where you are sending real-time log data. The only valid value
        /// is <c>Kinesis</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StreamType
        {
            get { return this._streamType; }
            set { this._streamType = value; }
        }

        // Check to see if StreamType property is set
        internal bool IsSetStreamType()
        {
            return this._streamType != null;
        }

    }
}