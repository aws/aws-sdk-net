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

namespace Amazon.IotData.Model
{
    /// <summary>
    /// Container for the parameters to the Publish operation. Publishes an MQTT message.
    /// <para> Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">Publish</a>
    /// action. </para> <para> For more information about MQTT messages, see <a href="http://docs.aws.amazon.com/iot/latest/developerguide/mqtt.html">MQTT
    /// Protocol</a> in the IoT Developer Guide. </para> <para> For more information about
    /// messaging costs, see <a href="http://aws.amazon.com/iot-core/pricing/#Messaging">Amazon
    /// Web Services IoT Core pricing - Messaging</a>. </para>
    /// </summary>
    public partial class PublishRequest : AmazonIotDataRequest
    {
        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// A UTF-8 encoded string that describes the content of the publishing message.
        /// </para>
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property CorrelationData. 
        /// <para>
        /// The base64-encoded binary data used by the sender of the request message to identify
        /// which request the response message is for when it's received. <c>correlationData</c>
        /// is an HTTP header value in the API.
        /// </para>
        /// </summary>
        public string CorrelationData { get; set; }

        /// <summary>
        /// Checks to see if the CorrelationData property is set.
        /// </summary>
        internal bool IsSetCorrelationData() => this.CorrelationData != null;

        /// <summary>
        /// Gets and sets the property MessageExpiry. 
        /// <para>
        /// A user-defined integer value that represents the message expiry interval in seconds.
        /// If absent, the message doesn't expire. For more information about the limits of <c>messageExpiry</c>,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/iot-core.html#message-broker-limits">Amazon
        /// Web Services IoT Core message broker and protocol limits and quotas </a> from the
        /// Amazon Web Services Reference Guide.
        /// </para>
        /// </summary>
        public long? MessageExpiry { get; set; }

        /// <summary>
        /// Checks to see if the MessageExpiry property is set.
        /// </summary>
        internal bool IsSetMessageExpiry() => this.MessageExpiry.HasValue;

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// The message body. MQTT accepts text, binary, and empty (null) message payloads.
        /// </para>
        ///  
        /// <para>
        /// Publishing an empty (null) payload with <b>retain</b> = <c>true</c> deletes the retained
        /// message identified by <b>topic</b> from Amazon Web Services IoT Core.
        /// </para>
        /// </summary>
        public MemoryStream Payload { get; set; }

        /// <summary>
        /// Checks to see if the Payload property is set.
        /// </summary>
        internal bool IsSetPayload() => this.Payload != null;

        /// <summary>
        /// Gets and sets the property PayloadFormatIndicator. 
        /// <para>
        /// An <c>Enum</c> string value that indicates whether the payload is formatted as UTF-8.
        /// <c>payloadFormatIndicator</c> is an HTTP header value in the API.
        /// </para>
        /// </summary>
        public PayloadFormatIndicator PayloadFormatIndicator { get; set; }

        /// <summary>
        /// Checks to see if the PayloadFormatIndicator property is set.
        /// </summary>
        internal bool IsSetPayloadFormatIndicator() => this.PayloadFormatIndicator != null;

        /// <summary>
        /// Gets and sets the property Qos. 
        /// <para>
        /// The Quality of Service (QoS) level. The default QoS level is 0.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public int? Qos { get; set; }

        /// <summary>
        /// Checks to see if the Qos property is set.
        /// </summary>
        internal bool IsSetQos() => this.Qos.HasValue;

        /// <summary>
        /// Gets and sets the property ResponseTopic. 
        /// <para>
        /// A UTF-8 encoded string that's used as the topic name for a response message. The response
        /// topic is used to describe the topic which the receiver should publish to as part of
        /// the request-response flow. The topic must not contain wildcard characters.
        /// </para>
        /// </summary>
        public string ResponseTopic { get; set; }

        /// <summary>
        /// Checks to see if the ResponseTopic property is set.
        /// </summary>
        internal bool IsSetResponseTopic() => this.ResponseTopic != null;

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
        /// Valid values: <c>true</c> | <c>false</c> 
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? Retain { get; set; }

        /// <summary>
        /// Checks to see if the Retain property is set.
        /// </summary>
        internal bool IsSetRetain() => this.Retain.HasValue;

        /// <summary>
        /// Gets and sets the property Topic. 
        /// <para>
        /// The name of the MQTT topic.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Topic { get; set; }

        /// <summary>
        /// Checks to see if the Topic property is set.
        /// </summary>
        internal bool IsSetTopic() => this.Topic != null;

        /// <summary>
        /// Gets and sets the property UserProperties. 
        /// <para>
        /// A JSON string that contains an array of JSON objects. If you don’t use Amazon Web
        /// Services SDK or CLI, you must encode the JSON string to base64 format before adding
        /// it to the HTTP header. <c>userProperties</c> is an HTTP header value in the API.
        /// </para>
        ///  
        /// <para>
        /// The following example <c>userProperties</c> parameter is a JSON string which represents
        /// two User Properties. Note that it needs to be base64-encoded:
        /// </para>
        ///  
        /// <para>
        ///  <c>[{"deviceName": "alpha"}, {"deviceCnt": "45"}]</c> 
        /// </para>
        /// </summary>
        public string UserProperties { get; set; }

        /// <summary>
        /// Checks to see if the UserProperties property is set.
        /// </summary>
        internal bool IsSetUserProperties() => this.UserProperties != null;
    }
}
