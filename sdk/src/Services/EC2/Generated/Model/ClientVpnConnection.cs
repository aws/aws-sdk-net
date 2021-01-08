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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a client connection.
    /// </summary>
    public partial class ClientVpnConnection
    {
        private string _clientIp;
        private string _clientVpnEndpointId;
        private string _commonName;
        private string _connectionEndTime;
        private string _connectionEstablishedTime;
        private string _connectionId;
        private string _egressBytes;
        private string _egressPackets;
        private string _ingressBytes;
        private string _ingressPackets;
        private List<string> _postureComplianceStatuses = new List<string>();
        private ClientVpnConnectionStatus _status;
        private string _timestamp;
        private string _username;

        /// <summary>
        /// Gets and sets the property ClientIp. 
        /// <para>
        /// The IP address of the client.
        /// </para>
        /// </summary>
        public string ClientIp
        {
            get { return this._clientIp; }
            set { this._clientIp = value; }
        }

        // Check to see if ClientIp property is set
        internal bool IsSetClientIp()
        {
            return this._clientIp != null;
        }

        /// <summary>
        /// Gets and sets the property ClientVpnEndpointId. 
        /// <para>
        /// The ID of the Client VPN endpoint to which the client is connected.
        /// </para>
        /// </summary>
        public string ClientVpnEndpointId
        {
            get { return this._clientVpnEndpointId; }
            set { this._clientVpnEndpointId = value; }
        }

        // Check to see if ClientVpnEndpointId property is set
        internal bool IsSetClientVpnEndpointId()
        {
            return this._clientVpnEndpointId != null;
        }

        /// <summary>
        /// Gets and sets the property CommonName. 
        /// <para>
        /// The common name associated with the client. This is either the name of the client
        /// certificate, or the Active Directory user name.
        /// </para>
        /// </summary>
        public string CommonName
        {
            get { return this._commonName; }
            set { this._commonName = value; }
        }

        // Check to see if CommonName property is set
        internal bool IsSetCommonName()
        {
            return this._commonName != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionEndTime. 
        /// <para>
        /// The date and time the client connection was terminated.
        /// </para>
        /// </summary>
        public string ConnectionEndTime
        {
            get { return this._connectionEndTime; }
            set { this._connectionEndTime = value; }
        }

        // Check to see if ConnectionEndTime property is set
        internal bool IsSetConnectionEndTime()
        {
            return this._connectionEndTime != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionEstablishedTime. 
        /// <para>
        /// The date and time the client connection was established.
        /// </para>
        /// </summary>
        public string ConnectionEstablishedTime
        {
            get { return this._connectionEstablishedTime; }
            set { this._connectionEstablishedTime = value; }
        }

        // Check to see if ConnectionEstablishedTime property is set
        internal bool IsSetConnectionEstablishedTime()
        {
            return this._connectionEstablishedTime != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of the client connection.
        /// </para>
        /// </summary>
        public string ConnectionId
        {
            get { return this._connectionId; }
            set { this._connectionId = value; }
        }

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this._connectionId != null;
        }

        /// <summary>
        /// Gets and sets the property EgressBytes. 
        /// <para>
        /// The number of bytes received by the client.
        /// </para>
        /// </summary>
        public string EgressBytes
        {
            get { return this._egressBytes; }
            set { this._egressBytes = value; }
        }

        // Check to see if EgressBytes property is set
        internal bool IsSetEgressBytes()
        {
            return this._egressBytes != null;
        }

        /// <summary>
        /// Gets and sets the property EgressPackets. 
        /// <para>
        /// The number of packets received by the client.
        /// </para>
        /// </summary>
        public string EgressPackets
        {
            get { return this._egressPackets; }
            set { this._egressPackets = value; }
        }

        // Check to see if EgressPackets property is set
        internal bool IsSetEgressPackets()
        {
            return this._egressPackets != null;
        }

        /// <summary>
        /// Gets and sets the property IngressBytes. 
        /// <para>
        /// The number of bytes sent by the client.
        /// </para>
        /// </summary>
        public string IngressBytes
        {
            get { return this._ingressBytes; }
            set { this._ingressBytes = value; }
        }

        // Check to see if IngressBytes property is set
        internal bool IsSetIngressBytes()
        {
            return this._ingressBytes != null;
        }

        /// <summary>
        /// Gets and sets the property IngressPackets. 
        /// <para>
        /// The number of packets sent by the client.
        /// </para>
        /// </summary>
        public string IngressPackets
        {
            get { return this._ingressPackets; }
            set { this._ingressPackets = value; }
        }

        // Check to see if IngressPackets property is set
        internal bool IsSetIngressPackets()
        {
            return this._ingressPackets != null;
        }

        /// <summary>
        /// Gets and sets the property PostureComplianceStatuses. 
        /// <para>
        /// The statuses returned by the client connect handler for posture compliance, if applicable.
        /// </para>
        /// </summary>
        public List<string> PostureComplianceStatuses
        {
            get { return this._postureComplianceStatuses; }
            set { this._postureComplianceStatuses = value; }
        }

        // Check to see if PostureComplianceStatuses property is set
        internal bool IsSetPostureComplianceStatuses()
        {
            return this._postureComplianceStatuses != null && this._postureComplianceStatuses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the client connection.
        /// </para>
        /// </summary>
        public ClientVpnConnectionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The current date and time.
        /// </para>
        /// </summary>
        public string Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The username of the client who established the client connection. This information
        /// is only provided if Active Directory client authentication is used.
        /// </para>
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}