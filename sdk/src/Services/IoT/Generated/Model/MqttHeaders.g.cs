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
    /// Specifies MQTT Version 5.0 headers information. For more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/mqtt.html">
    /// MQTT</a> from Amazon Web Services IoT Core Developer Guide.
    /// </summary>
    public partial class MqttHeaders
    {
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
        [AWSProperty(Min = 0, Max = 1024)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

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
        [AWSProperty(Min = 0, Max = 1024)]
        public string CorrelationData { get; set; }

        /// <summary>
        /// Checks to see if the CorrelationData property is set.
        /// </summary>
        internal bool IsSetCorrelationData() => this.CorrelationData != null;

        /// <summary>
        /// Gets and sets the property MessageExpiry. 
        /// <para>
        /// A user-defined integer value that will persist a message at the message broker for
        /// a specified amount of time to ensure that the message will expire if it's no longer
        /// relevant to the subscriber. The value of <c>messageExpiry</c> represents the number
        /// of seconds before it expires. For more information about the limits of <c>messageExpiry</c>,
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
        [AWSProperty(Min = 0, Max = 1024)]
        public string MessageExpiry { get; set; }

        /// <summary>
        /// Checks to see if the MessageExpiry property is set.
        /// </summary>
        internal bool IsSetMessageExpiry() => this.MessageExpiry != null;

        /// <summary>
        /// Gets and sets the property PayloadFormatIndicator. 
        /// <para>
        /// An <c>Enum</c> string value that indicates whether the payload is formatted as UTF-8.
        /// </para>
        ///  
        /// <para>
        /// Valid values are <c>UNSPECIFIED_BYTES</c> and <c>UTF8_DATA</c>.
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
        [AWSProperty(Min = 0, Max = 1024)]
        public string PayloadFormatIndicator { get; set; }

        /// <summary>
        /// Checks to see if the PayloadFormatIndicator property is set.
        /// </summary>
        internal bool IsSetPayloadFormatIndicator() => this.PayloadFormatIndicator != null;

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
        [AWSProperty(Min = 0, Max = 1024)]
        public string ResponseTopic { get; set; }

        /// <summary>
        /// Checks to see if the ResponseTopic property is set.
        /// </summary>
        internal bool IsSetResponseTopic() => this.ResponseTopic != null;

        /// <summary>
        /// Gets and sets the property UserProperties. 
        /// <para>
        /// An array of key-value pairs that you define in the MQTT5 header.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<UserProperty> UserProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<UserProperty>() : null;

        /// <summary>
        /// Checks to see if the UserProperties property is set.
        /// </summary>
        internal bool IsSetUserProperties() => this.UserProperties != null && (this.UserProperties.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
