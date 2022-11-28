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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Specifies MQTT Version 5.0 headers information. For more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/mqtt.html">
    /// MQTT</a> from Amazon Web Services IoT Core Developer Guide.
    /// </summary>
    public partial class MqttHeaders
    {
        private string _contentType;
        private string _correlationData;
        private string _messageExpiry;
        private string _payloadFormatIndicator;
        private string _responseTopic;
        private List<UserProperty> _userProperties = new List<UserProperty>();

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// A UTF-8 encoded string that describes the content of the publishing message.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.oasis-open.org/mqtt/mqtt/v5.0/os/mqtt-v5.0-os.html#_Toc3901118">
        /// Content Type</a> from the MQTT Version 5.0 specification.
        /// </para>
        ///  
        /// <para>
        /// Supports <a href="https://docs.aws.amazon.com/iot/latest/developerguide/iot-substitution-templates.html">substitution
        /// templates</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// which request the response message is for when it's received.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.oasis-open.org/mqtt/mqtt/v5.0/os/mqtt-v5.0-os.html#_Toc3901115">
        /// Correlation Data</a> from the MQTT Version 5.0 specification.
        /// </para>
        ///  <note> 
        /// <para>
        ///  This binary data must be based64-encoded. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Supports <a href="https://docs.aws.amazon.com/iot/latest/developerguide/iot-substitution-templates.html">substitution
        /// templates</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// A user-defined integer value that will persist a message at the message broker for
        /// a specified amount of time to ensure that the message will expire if it's no longer
        /// relevant to the subscriber. The value of <code>messageExpiry</code> represents the
        /// number of seconds before it expires. For more information about the limits of <code>messageExpiry</code>,
        /// see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/mqtt.html">Amazon
        /// Web Services IoT Core message broker and protocol limits and quotas </a> from the
        /// Amazon Web Services Reference Guide.
        /// </para>
        ///  
        /// <para>
        /// Supports <a href="https://docs.aws.amazon.com/iot/latest/developerguide/iot-substitution-templates.html">substitution
        /// templates</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string MessageExpiry
        {
            get { return this._messageExpiry; }
            set { this._messageExpiry = value; }
        }

        // Check to see if MessageExpiry property is set
        internal bool IsSetMessageExpiry()
        {
            return this._messageExpiry != null;
        }

        /// <summary>
        /// Gets and sets the property PayloadFormatIndicator. 
        /// <para>
        /// An <code>Enum</code> string value that indicates whether the payload is formatted
        /// as UTF-8.
        /// </para>
        ///  
        /// <para>
        /// Valid values are <code>UNSPECIFIED_BYTES</code> and <code>UTF8_DATA</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.oasis-open.org/mqtt/mqtt/v5.0/os/mqtt-v5.0-os.html#_Toc3901111">
        /// Payload Format Indicator</a> from the MQTT Version 5.0 specification.
        /// </para>
        ///  
        /// <para>
        /// Supports <a href="https://docs.aws.amazon.com/iot/latest/developerguide/iot-substitution-templates.html">substitution
        /// templates</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string PayloadFormatIndicator
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
        /// Gets and sets the property ResponseTopic. 
        /// <para>
        /// A UTF-8 encoded string that's used as the topic name for a response message. The response
        /// topic is used to describe the topic which the receiver should publish to as part of
        /// the request-response flow. The topic must not contain wildcard characters.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.oasis-open.org/mqtt/mqtt/v5.0/os/mqtt-v5.0-os.html#_Toc3901114">
        /// Response Topic</a> from the MQTT Version 5.0 specification.
        /// </para>
        ///  
        /// <para>
        /// Supports <a href="https://docs.aws.amazon.com/iot/latest/developerguide/iot-substitution-templates.html">substitution
        /// templates</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property UserProperties. 
        /// <para>
        /// An array of key-value pairs that you define in the MQTT5 header.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<UserProperty> UserProperties
        {
            get { return this._userProperties; }
            set { this._userProperties = value; }
        }

        // Check to see if UserProperties property is set
        internal bool IsSetUserProperties()
        {
            return this._userProperties != null && this._userProperties.Count > 0; 
        }

    }
}