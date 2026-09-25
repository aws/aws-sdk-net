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
    /// This is the response object from the GetConnection operation.
    /// </summary>
    public partial class GetConnectionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CleanSession. 
        /// <para>
        /// Indicates whether the client is using a clean session. Returns <c>true</c> for clean
        /// sessions or <c>false</c> for persistent sessions.
        /// </para>
        /// </summary>
        public bool? CleanSession { get; set; }

        /// <summary>
        /// Checks to see if the CleanSession property is set.
        /// </summary>
        internal bool IsSetCleanSession() => this.CleanSession.HasValue;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The unique identifier of the MQTT client. This is the same client ID that was used
        /// when the client established the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property Connected. 
        /// <para>
        /// The connection state of the client. Returns <c>true</c> if the client is currently
        /// connected, or <c>false</c> if the client is not connected.
        /// </para>
        /// </summary>
        public bool? Connected { get; set; }

        /// <summary>
        /// Checks to see if the Connected property is set.
        /// </summary>
        internal bool IsSetConnected() => this.Connected.HasValue;

        /// <summary>
        /// Gets and sets the property ConnectedSince. 
        /// <para>
        /// Unix timestamp (in milliseconds) indicating when the client connected. Present only
        /// when connected is true.
        /// </para>
        /// </summary>
        public long? ConnectedSince { get; set; }

        /// <summary>
        /// Checks to see if the ConnectedSince property is set.
        /// </summary>
        internal bool IsSetConnectedSince() => this.ConnectedSince.HasValue;

        /// <summary>
        /// Gets and sets the property DisconnectReason. 
        /// <para>
        /// The reason for the last disconnection, if the client is currently disconnected. See
        /// the <a href="https://docs.aws.amazon.com/iot/latest/developerguide/life-cycle-events.html#connect-disconnect">developer
        /// guide</a> for valid disconnect reasons.
        /// </para>
        /// </summary>
        public string DisconnectReason { get; set; }

        /// <summary>
        /// Checks to see if the DisconnectReason property is set.
        /// </summary>
        internal bool IsSetDisconnectReason() => this.DisconnectReason != null;

        /// <summary>
        /// Gets and sets the property DisconnectedSince. 
        /// <para>
        /// Unix timestamp (in milliseconds) indicating when the client disconnected. Present
        /// only when connected is false. This information is available for 30 minutes after the
        /// client disconnects.
        /// </para>
        /// </summary>
        public long? DisconnectedSince { get; set; }

        /// <summary>
        /// Checks to see if the DisconnectedSince property is set.
        /// </summary>
        internal bool IsSetDisconnectedSince() => this.DisconnectedSince.HasValue;

        /// <summary>
        /// Gets and sets the property KeepAliveDuration. 
        /// <para>
        /// The keep-alive interval in seconds that the client specified when establishing the
        /// connection.
        /// </para>
        /// </summary>
        public int? KeepAliveDuration { get; set; }

        /// <summary>
        /// Checks to see if the KeepAliveDuration property is set.
        /// </summary>
        internal bool IsSetKeepAliveDuration() => this.KeepAliveDuration.HasValue;

        /// <summary>
        /// Gets and sets the property SessionExpiry. 
        /// <para>
        /// The session expiry interval in seconds for the MQTT client connection. This is configured
        /// by the user. This value indicates how long the session will remain active after the
        /// client disconnects.
        /// </para>
        /// </summary>
        public long? SessionExpiry { get; set; }

        /// <summary>
        /// Checks to see if the SessionExpiry property is set.
        /// </summary>
        internal bool IsSetSessionExpiry() => this.SessionExpiry.HasValue;

        /// <summary>
        /// Gets and sets the property SourceIp. 
        /// <para>
        /// The IP address of the client that initiated the connection.
        /// </para>
        /// </summary>
        public string SourceIp { get; set; }

        /// <summary>
        /// Checks to see if the SourceIp property is set.
        /// </summary>
        internal bool IsSetSourceIp() => this.SourceIp != null;

        /// <summary>
        /// Gets and sets the property SourcePort. 
        /// <para>
        /// The client's source port.
        /// </para>
        /// </summary>
        public int? SourcePort { get; set; }

        /// <summary>
        /// Checks to see if the SourcePort property is set.
        /// </summary>
        internal bool IsSetSourcePort() => this.SourcePort.HasValue;

        /// <summary>
        /// Gets and sets the property TargetIp. 
        /// <para>
        /// The IP address of the Amazon Web Services IoT Core endpoint that the client connected
        /// to. For clients connected to VPC endpoints, this is the private IP address of the
        /// network interface the client is connected to.
        /// </para>
        /// </summary>
        public string TargetIp { get; set; }

        /// <summary>
        /// Checks to see if the TargetIp property is set.
        /// </summary>
        internal bool IsSetTargetIp() => this.TargetIp != null;

        /// <summary>
        /// Gets and sets the property TargetPort. 
        /// <para>
        /// The port number of the Amazon Web Services IoT Core endpoint that the client connected
        /// to.
        /// </para>
        /// </summary>
        public int? TargetPort { get; set; }

        /// <summary>
        /// Checks to see if the TargetPort property is set.
        /// </summary>
        internal bool IsSetTargetPort() => this.TargetPort.HasValue;

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the thing associated with the principal of the MQTT client, if applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ThingName { get; set; }

        /// <summary>
        /// Checks to see if the ThingName property is set.
        /// </summary>
        internal bool IsSetThingName() => this.ThingName != null;

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The ID of the VPC endpoint. Present for clients connected to IoT Core via a <a href="https://docs.aws.amazon.com/iot/latest/developerguide/IoTCore-VPC.html">VPC
        /// endpoint</a>. 
        /// </para>
        /// </summary>
        public string VpcEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointId property is set.
        /// </summary>
        internal bool IsSetVpcEndpointId() => this.VpcEndpointId != null;
    }
}
