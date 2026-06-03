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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the GetThingConnectivityData operation.
    /// </summary>
    public partial class GetThingConnectivityDataResponse : AmazonWebServiceResponse
    {
        private bool? _cleanSession;
        private string _clientId;
        private bool? _connected;
        private DisconnectReasonValue _disconnectReason;
        private int? _keepAliveDuration;
        private long? _sessionExpiry;
        private string _sourceIp;
        private int? _sourcePort;
        private string _targetIp;
        private int? _targetPort;
        private string _thingName;
        private DateTime? _timestamp;
        private string _vpcEndpointId;

        /// <summary>
        /// Gets and sets the property CleanSession. 
        /// <para>
        /// Indicates whether the client is using a clean session. Returns <c>true</c> for clean
        /// sessions.
        /// </para>
        /// </summary>
        public bool? CleanSession
        {
            get { return this._cleanSession; }
            set { this._cleanSession = value; }
        }

        // Check to see if CleanSession property is set
        internal bool IsSetCleanSession()
        {
            return this._cleanSession.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The unique identifier of the MQTT client.
        /// </para>
        /// </summary>
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property Connected. 
        /// <para>
        /// A Boolean that indicates the connectivity status.
        /// </para>
        /// </summary>
        public bool? Connected
        {
            get { return this._connected; }
            set { this._connected = value; }
        }

        // Check to see if Connected property is set
        internal bool IsSetConnected()
        {
            return this._connected.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisconnectReason. 
        /// <para>
        /// The reason that the client is disconnected.
        /// </para>
        /// </summary>
        public DisconnectReasonValue DisconnectReason
        {
            get { return this._disconnectReason; }
            set { this._disconnectReason = value; }
        }

        // Check to see if DisconnectReason property is set
        internal bool IsSetDisconnectReason()
        {
            return this._disconnectReason != null;
        }

        /// <summary>
        /// Gets and sets the property KeepAliveDuration. 
        /// <para>
        /// The keep-alive interval in seconds that the client specified when establishing the
        /// connection.
        /// </para>
        /// </summary>
        public int? KeepAliveDuration
        {
            get { return this._keepAliveDuration; }
            set { this._keepAliveDuration = value; }
        }

        // Check to see if KeepAliveDuration property is set
        internal bool IsSetKeepAliveDuration()
        {
            return this._keepAliveDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SessionExpiry. 
        /// <para>
        /// The session expiry interval in seconds for the MQTT client connection. This value
        /// indicates how long the session will remain active after the client disconnects.
        /// </para>
        /// </summary>
        public long? SessionExpiry
        {
            get { return this._sessionExpiry; }
            set { this._sessionExpiry = value; }
        }

        // Check to see if SessionExpiry property is set
        internal bool IsSetSessionExpiry()
        {
            return this._sessionExpiry.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceIp. 
        /// <para>
        /// The IP address of the client that initiated the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string SourceIp
        {
            get { return this._sourceIp; }
            set { this._sourceIp = value; }
        }

        // Check to see if SourceIp property is set
        internal bool IsSetSourceIp()
        {
            return this._sourceIp != null;
        }

        /// <summary>
        /// Gets and sets the property SourcePort. 
        /// <para>
        /// The client's source port.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public int? SourcePort
        {
            get { return this._sourcePort; }
            set { this._sourcePort = value; }
        }

        // Check to see if SourcePort property is set
        internal bool IsSetSourcePort()
        {
            return this._sourcePort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetIp. 
        /// <para>
        /// The IP address of the Amazon Web Services IoT Core endpoint that the client connected
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string TargetIp
        {
            get { return this._targetIp; }
            set { this._targetIp = value; }
        }

        // Check to see if TargetIp property is set
        internal bool IsSetTargetIp()
        {
            return this._targetIp != null;
        }

        /// <summary>
        /// Gets and sets the property TargetPort. 
        /// <para>
        /// The port number of the Amazon Web Services IoT Core endpoint that the client connected
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public int? TargetPort
        {
            get { return this._targetPort; }
            set { this._targetPort = value; }
        }

        // Check to see if TargetPort property is set
        internal bool IsSetTargetPort()
        {
            return this._targetPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of your IoT thing.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string ThingName
        {
            get { return this._thingName; }
            set { this._thingName = value; }
        }

        // Check to see if ThingName property is set
        internal bool IsSetThingName()
        {
            return this._thingName != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp of when the device connected or disconnected.
        /// </para>
        /// </summary>
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The ID of the VPC endpoint. Present for clients connected to Amazon Web Services IoT
        /// Core via a VPC endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string VpcEndpointId
        {
            get { return this._vpcEndpointId; }
            set { this._vpcEndpointId = value; }
        }

        // Check to see if VpcEndpointId property is set
        internal bool IsSetVpcEndpointId()
        {
            return this._vpcEndpointId != null;
        }

    }
}