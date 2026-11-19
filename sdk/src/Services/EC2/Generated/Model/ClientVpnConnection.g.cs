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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a client connection.
    /// </summary>
    public partial class ClientVpnConnection
    {
        /// <summary>
        /// Gets and sets the property AuthorizationPolicyLastEvaluatedTime. 
        /// <para>
        /// The date and time the authorization policy was last evaluated for the client connection,
        /// if applicable.
        /// </para>
        /// </summary>
        public string AuthorizationPolicyLastEvaluatedTime { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationPolicyLastEvaluatedTime property is set.
        /// </summary>
        internal bool IsSetAuthorizationPolicyLastEvaluatedTime() => this.AuthorizationPolicyLastEvaluatedTime != null;

        /// <summary>
        /// Gets and sets the property ClientIp. 
        /// <para>
        /// The IP address of the client.
        /// </para>
        /// </summary>
        public string ClientIp { get; set; }

        /// <summary>
        /// Checks to see if the ClientIp property is set.
        /// </summary>
        internal bool IsSetClientIp() => this.ClientIp != null;

        /// <summary>
        /// Gets and sets the property ClientIpv6Address. 
        /// <para>
        /// The IPv6 address assigned to the client connection when using a dual-stack Client
        /// VPN endpoint. This field is only populated when the endpoint is configured for dual-stack
        /// addressing, and the client is using IPv6 for connectivity.
        /// </para>
        /// </summary>
        public string ClientIpv6Address { get; set; }

        /// <summary>
        /// Checks to see if the ClientIpv6Address property is set.
        /// </summary>
        internal bool IsSetClientIpv6Address() => this.ClientIpv6Address != null;

        /// <summary>
        /// Gets and sets the property ClientVpnEndpointId. 
        /// <para>
        /// The ID of the Client VPN endpoint to which the client is connected.
        /// </para>
        /// </summary>
        public string ClientVpnEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the ClientVpnEndpointId property is set.
        /// </summary>
        internal bool IsSetClientVpnEndpointId() => this.ClientVpnEndpointId != null;

        /// <summary>
        /// Gets and sets the property CommonName. 
        /// <para>
        /// The common name associated with the client. This is either the name of the client
        /// certificate, or the Active Directory user name.
        /// </para>
        /// </summary>
        public string CommonName { get; set; }

        /// <summary>
        /// Checks to see if the CommonName property is set.
        /// </summary>
        internal bool IsSetCommonName() => this.CommonName != null;

        /// <summary>
        /// Gets and sets the property ConnectionEndTime. 
        /// <para>
        /// The date and time the client connection was terminated.
        /// </para>
        /// </summary>
        public string ConnectionEndTime { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionEndTime property is set.
        /// </summary>
        internal bool IsSetConnectionEndTime() => this.ConnectionEndTime != null;

        /// <summary>
        /// Gets and sets the property ConnectionEstablishedTime. 
        /// <para>
        /// The date and time the client connection was established.
        /// </para>
        /// </summary>
        public string ConnectionEstablishedTime { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionEstablishedTime property is set.
        /// </summary>
        internal bool IsSetConnectionEstablishedTime() => this.ConnectionEstablishedTime != null;

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of the client connection.
        /// </para>
        /// </summary>
        public string ConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionId property is set.
        /// </summary>
        internal bool IsSetConnectionId() => this.ConnectionId != null;

        /// <summary>
        /// Gets and sets the property EgressBytes. 
        /// <para>
        /// The number of bytes received by the client.
        /// </para>
        /// </summary>
        public string EgressBytes { get; set; }

        /// <summary>
        /// Checks to see if the EgressBytes property is set.
        /// </summary>
        internal bool IsSetEgressBytes() => this.EgressBytes != null;

        /// <summary>
        /// Gets and sets the property EgressPackets. 
        /// <para>
        /// The number of packets received by the client.
        /// </para>
        /// </summary>
        public string EgressPackets { get; set; }

        /// <summary>
        /// Checks to see if the EgressPackets property is set.
        /// </summary>
        internal bool IsSetEgressPackets() => this.EgressPackets != null;

        /// <summary>
        /// Gets and sets the property IngressBytes. 
        /// <para>
        /// The number of bytes sent by the client.
        /// </para>
        /// </summary>
        public string IngressBytes { get; set; }

        /// <summary>
        /// Checks to see if the IngressBytes property is set.
        /// </summary>
        internal bool IsSetIngressBytes() => this.IngressBytes != null;

        /// <summary>
        /// Gets and sets the property IngressPackets. 
        /// <para>
        /// The number of packets sent by the client.
        /// </para>
        /// </summary>
        public string IngressPackets { get; set; }

        /// <summary>
        /// Checks to see if the IngressPackets property is set.
        /// </summary>
        internal bool IsSetIngressPackets() => this.IngressPackets != null;

        /// <summary>
        /// Gets and sets the property PostureComplianceStatuses. 
        /// <para>
        /// The statuses returned by the client connect handler for posture compliance, if applicable.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PostureComplianceStatuses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PostureComplianceStatuses property is set.
        /// </summary>
        internal bool IsSetPostureComplianceStatuses() => this.PostureComplianceStatuses != null && (this.PostureComplianceStatuses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the client connection.
        /// </para>
        /// </summary>
        public ClientVpnConnectionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The current date and time.
        /// </para>
        /// </summary>
        public string Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp != null;

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The username of the client who established the client connection. This information
        /// is only provided if Active Directory client authentication is used.
        /// </para>
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;
    }
}
