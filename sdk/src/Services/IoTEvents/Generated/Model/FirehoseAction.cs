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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
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
namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// Sends information about the detector model instance and the event that triggered the
    /// action to an Amazon Kinesis Data Firehose delivery stream.
    /// </summary>
    public partial class FirehoseAction
    {
        private string _deliveryStreamName;
        private Payload _payload;
        private string _separator;

        /// <summary>
        /// Gets and sets the property DeliveryStreamName. 
        /// <para>
        /// The name of the Kinesis Data Firehose delivery stream where the data is written.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DeliveryStreamName
        {
            get { return this._deliveryStreamName; }
            set { this._deliveryStreamName = value; }
        }

        // Check to see if DeliveryStreamName property is set
        internal bool IsSetDeliveryStreamName()
        {
            return this._deliveryStreamName != null;
        }

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// You can configure the action payload when you send a message to an Amazon Kinesis
        /// Data Firehose delivery stream.
        /// </para>
        /// </summary>
        public Payload Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null;
        }

        /// <summary>
        /// Gets and sets the property Separator. 
        /// <para>
        /// A character separator that is used to separate records written to the Kinesis Data
        /// Firehose delivery stream. Valid values are: '\n' (newline), '\t' (tab), '\r\n' (Windows
        /// newline), ',' (comma).
        /// </para>
        /// </summary>
        public string Separator
        {
            get { return this._separator; }
            set { this._separator = value; }
        }

        // Check to see if Separator property is set
        internal bool IsSetSeparator()
        {
            return this._separator != null;
        }

    }
}