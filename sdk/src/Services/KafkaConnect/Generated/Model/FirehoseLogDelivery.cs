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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
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
namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// The settings for delivering logs to Amazon Kinesis Data Firehose.
    /// </summary>
    public partial class FirehoseLogDelivery
    {
        private string _deliveryStream;
        private bool? _enabled;

        /// <summary>
        /// Gets and sets the property DeliveryStream. 
        /// <para>
        /// The name of the Kinesis Data Firehose delivery stream that is the destination for
        /// log delivery.
        /// </para>
        /// </summary>
        public string DeliveryStream
        {
            get { return this._deliveryStream; }
            set { this._deliveryStream = value; }
        }

        // Check to see if DeliveryStream property is set
        internal bool IsSetDeliveryStream()
        {
            return this._deliveryStream != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether connector logs get delivered to Amazon Kinesis Data Firehose.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

    }
}