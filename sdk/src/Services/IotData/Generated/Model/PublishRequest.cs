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

namespace Amazon.IotData.Model
{
    /// <summary>
    /// Container for the parameters to the Publish operation.
    /// Publishes an MQTT message.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">Publish</a>
    /// action.
    /// </para>
    ///  
    /// <para>
    /// For more information about MQTT messages, see <a href="http://docs.aws.amazon.com/iot/latest/developerguide/mqtt.html">MQTT
    /// Protocol</a> in the IoT Developer Guide.
    /// </para>
    ///  
    /// <para>
    /// For more information about messaging costs, see <a href="http://aws.amazon.com/iot-core/pricing/#Messaging">Amazon
    /// Web Services IoT Core pricing - Messaging</a>.
    /// </para>
    /// </summary>
    public partial class PublishRequest : AmazonIotDataRequest
    {
        private string _contentType;
        private string _correlationData;
        private long? _messageExpiry;
        private MemoryStream _payload;
        private PayloadFormatIndicator _payloadFormatIndicator;
        private int? _qos;
        private string _responseTopic;
        private bool? _retain;
        private string _topic;
        private string _userProperties;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// A UTF-8 encoded string that describes the content of the publishing message.
        /// </para>
        /// </summary>
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property CorrelationData. 
        /// <para>
        /// The base64-encoded binary data used by the sender of the request message to identify
        /// which request the response message is for when it's received. <code>correlationData</code>
        /// is an HTTP header value in the API.
        /// </para>
        /// </summary>
        public string CorrelationData
        {
            get { return this._correlationData; }
            set { this._correlationData = value; }
        }

        // Check to see if CorrelationData property is set
        internal bool IsSetCorrelationData()
        {
            return this._correlationData != null;
        }

        /// <summary>
        /// Gets and sets the property MessageExpiry. 
        /// <para>
        /// A user-defined integer value that represents the message expiry interval in seconds.
        /// If absent, the message doesn't expire. For more information about the limits of <code>messageExpiry</code>,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/iot-core.html#message-broker-limits">Amazon
        /// Web Services IoT Core message broker and protocol limits and quotas </a> from the
        /// Amazon Web Services Reference Guide.
        /// </para>
        /// </summary>
        public long MessageExpiry
        {
            get { return this._messageExpiry.GetValueOrDefault(); }
            set { this._messageExpiry = value; }
        }

        // Check to see if MessageExpiry property is set
        internal bool IsSetMessageExpiry()
        {
            return this._messageExpiry.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// The message body. MQTT accepts text, binary, and empty (null) message payloads.
        /// </para>
        ///  
        /// <para>
        /// Publishing an empty (null) payload with <b>retain</b> = <code>true</code> deletes
        /// the retained message identified by <b>topic</b> from Amazon Web Services IoT Core.
        /// </para>
        /// </summary>
        public MemoryStream Payload
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
        /// Gets and sets the property PayloadFormatIndicator. 
        /// <para>
        /// An <code>Enum</code> string value that indicates whether the payload is formatted
        /// as UTF-8. <code>payloadFormatIndicator</code> is an HTTP header value in the API.
        /// </para>
        /// </summary>
        public PayloadFormatIndicator PayloadFormatIndicator
        {
            get { return this._payloadFormatIndicator; }
            set { this._payloadFormatIndicator = value; }
        }

        // Check to see if PayloadFormatIndicator property is set
        internal bool IsSetPayloadFormatIndicator()
        {
            return this._payloadFormatIndicator != null;
        }

        /// <summary>
        /// Gets and sets the property Qos. 
        /// <para>
        /// The Quality of Service (QoS) level. The default QoS level is 0.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public int Qos
        {
            get { return this._qos.GetValueOrDefault(); }
            set { this._qos = value; }
        }

        // Check to see if Qos property is set
        internal bool IsSetQos()
        {
            return this._qos.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResponseTopic. 
        /// <para>
        /// A UTF-8 encoded string that's used as the topic name for a response message. The response
        /// topic is used to describe the topic which the receiver should publish to as part of
        /// the request-response flow. The topic must not contain wildcard characters.
        /// </para>
        /// </summary>
        public string ResponseTopic
        {
            get { return this._responseTopic; }
            set { this._responseTopic = value; }
        }

        // Check to see if ResponseTopic property is set
        internal bool IsSetResponseTopic()
        {
            return this._responseTopic != null;
        }

        /// <summary>
        /// Gets and sets the property Retain. 
        /// <para>
        /// A Boolean value that determines whether to set the RETAIN flag when the message is
        /// published.
        /// </para>
        ///  
        /// <para>
        /// Setting the RETAIN flag causes the message to be retained and sent to new subscribers
        /// to the topic.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>true</code> | <code>false</code> 
        /// </para>
        ///  
        /// <para>
        /// Default value: <code>false</code> 
        /// </para>
        /// </summary>
        public bool Retain
        {
            get { return this._retain.GetValueOrDefault(); }
            set { this._retain = value; }
        }

        // Check to see if Retain property is set
        internal bool IsSetRetain()
        {
            return this._retain.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Topic. 
        /// <para>
        /// The name of the MQTT topic.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property UserProperties. 
        /// <para>
        /// A JSON string that contains an array of JSON objects. If you don’t use Amazon Web
        /// Services SDK or CLI, you must encode the JSON string to base64 format before adding
        /// it to the HTTP header. <code>userProperties</code> is an HTTP header value in the
        /// API.
        /// </para>
        ///  
        /// <para>
        /// The following example <code>userProperties</code> parameter is a JSON string which
        /// represents two User Properties. Note that it needs to be base64-encoded:
        /// </para>
        ///  
        /// <para>
        ///  <code>[{"deviceName": "alpha"}, {"deviceCnt": "45"}]</code> 
        /// </para>
        /// </summary>
        public string UserProperties
        {
            get { return this._userProperties; }
            set { this._userProperties = value; }
        }

        // Check to see if UserProperties property is set
        internal bool IsSetUserProperties()
        {
            return this._userProperties != null;
        }

    }
}