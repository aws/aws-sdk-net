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
    /// Container for the parameters to the SendDirectMessage operation. Sends an MQTT message
    /// directly to a specific client identified by its client ID. <para> <c>SendDirectMessage</c>
    /// targets a single client ID. The receiving client does not need to subscribe to the
    /// topic, but the receiver's policy must allow <c>iot:Receive</c> on the specified topic.
    /// </para> <para> Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">SendDirectMessage</a>
    /// action. </para> <para> For more information about messaging costs, see <a href="http://aws.amazon.com/iot-core/pricing/">Amazon
    /// Web Services IoT Core pricing</a>. </para>
    /// </summary>
    public partial class SendDirectMessageRequest : AmazonIotDataRequest
    {
        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The unique identifier of the MQTT client to send the message to.
        /// </para>
        ///  
        /// <para>
        /// Client IDs must not exceed 128 characters and can't start with a dollar sign ($).
        /// MQTT client IDs must be URL encoded (percent-encoded) when they contain characters
        /// that are not valid in HTTP requests, such as spaces, forward slashes (/), and UTF-8
        /// characters. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/iot-core.html#message-broker-limits">Amazon
        /// Web Services IoT Core message broker and protocol limits and quotas</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property Confirmation. 
        /// <para>
        /// A Boolean value that specifies whether to wait for delivery confirmation from the
        /// receiving client.
        /// </para>
        ///  
        /// <para>
        /// When set to <c>true</c>, the API delivers the message at QoS 1 and waits for the client
        /// to send a delivery confirmation (PUBACK) before returning a successful response. If
        /// delivery confirmation is not received within the specified <c>timeout</c> period,
        /// the API returns HTTP 504.
        /// </para>
        ///  
        /// <para>
        /// When set to <c>false</c>, the API delivers the message at QoS 0 and returns after
        /// Amazon Web Services IoT Core attempts to deliver the message.
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
        public bool? Confirmation { get; set; }

        /// <summary>
        /// Checks to see if the Confirmation property is set.
        /// </summary>
        internal bool IsSetConfirmation() => this.Confirmation.HasValue;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The MQTT5 content type property forwarded to the receiving client (for example, <c>application/json</c>).
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
        /// Gets and sets the property Payload. 
        /// <para>
        /// The message body. MQTT accepts text, binary, and empty (null) message payloads.
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
        /// Gets and sets the property ResponseTopic. 
        /// <para>
        /// A UTF-8 encoded string that's used as the topic name for a response message. The response
        /// topic describes the topic which the receiver should publish to as part of the request-response
        /// flow. The topic must not contain wildcard characters. For more information, see <a
        /// href="https://docs.aws.amazon.com/general/latest/gr/iot-core.html#message-broker-limits">Amazon
        /// Web Services IoT Core message broker and protocol limits and quotas</a>.
        /// </para>
        /// </summary>
        public string ResponseTopic { get; set; }

        /// <summary>
        /// Checks to see if the ResponseTopic property is set.
        /// </summary>
        internal bool IsSetResponseTopic() => this.ResponseTopic != null;

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// An integer that represents the maximum time, in seconds, to wait for a delivery confirmation
        /// (PUBACK) from the receiving client after the message has been delivered. This parameter
        /// is only used when <c>confirmation</c> is set to <c>true</c>. If <c>confirmation</c>
        /// is <c>false</c>, this parameter is ignored.
        /// </para>
        ///  
        /// <para>
        /// The total API response time may be higher than this value due to internal processing.
        /// Set your HTTP client timeout to a value greater than this parameter.
        /// </para>
        ///  
        /// <para>
        /// Valid range: 1 to 15 seconds.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>5</c> seconds.
        /// </para>
        /// </summary>
        public int? Timeout { get; set; }

        /// <summary>
        /// Checks to see if the Timeout property is set.
        /// </summary>
        internal bool IsSetTimeout() => this.Timeout.HasValue;

        /// <summary>
        /// Gets and sets the property Topic. 
        /// <para>
        /// The topic of the outbound MQTT Publish message to the receiving client. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/iot-core.html#message-broker-limits">Amazon
        /// Web Services IoT Core message broker and protocol limits and quotas</a>.
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
        /// A JSON string that contains an array of JSON objects. If you don't use Amazon Web
        /// Services SDK or CLI, you must encode the JSON string to base64 format before adding
        /// it to the HTTP header. <c>userProperties</c> is an HTTP header value in the API.
        /// </para>
        ///  
        /// <para>
        /// For MQTT 3.1.1 clients, user properties are silently dropped.
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
