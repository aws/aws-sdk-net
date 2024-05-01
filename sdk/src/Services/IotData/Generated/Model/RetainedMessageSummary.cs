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
 * Do not modify this file. This file is generated from the iot-data-2015-05-28.normal.json service model.
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
namespace Amazon.IotData.Model
{
    /// <summary>
    /// Information about a single retained message.
    /// </summary>
    public partial class RetainedMessageSummary
    {
        private long? _lastModifiedTime;
        private long? _payloadSize;
        private int? _qos;
        private string _topic;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The Epoch date and time, in milliseconds, when the retained message was stored by
        /// IoT.
        /// </para>
        /// </summary>
        public long? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PayloadSize. 
        /// <para>
        /// The size of the retained message's payload in bytes.
        /// </para>
        /// </summary>
        public long? PayloadSize
        {
            get { return this._payloadSize; }
            set { this._payloadSize = value; }
        }

        // Check to see if PayloadSize property is set
        internal bool IsSetPayloadSize()
        {
            return this._payloadSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Qos. 
        /// <para>
        /// The quality of service (QoS) level used to publish the retained message.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public int? Qos
        {
            get { return this._qos; }
            set { this._qos = value; }
        }

        // Check to see if Qos property is set
        internal bool IsSetQos()
        {
            return this._qos.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Topic. 
        /// <para>
        /// The topic name to which the retained message was published.
        /// </para>
        /// </summary>
        public string Topic
        {
            get { return this._topic; }
            set { this._topic = value; }
        }

        // Check to see if Topic property is set
        internal bool IsSetTopic()
        {
            return this._topic != null;
        }

    }
}