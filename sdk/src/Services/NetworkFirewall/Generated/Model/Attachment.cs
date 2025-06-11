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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// The definition and status of the firewall endpoint for a single subnet. In each configured
    /// subnet, Network Firewall instantiates a firewall endpoint to handle network traffic.
    /// 
    /// 
    ///  
    /// <para>
    /// This data type is used for any firewall endpoint type: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For <c>Firewall.SubnetMappings</c>, this <c>Attachment</c> is part of the <c>FirewallStatus</c>
    /// sync states information. You define firewall subnets using <c>CreateFirewall</c> and
    /// <c>AssociateSubnets</c>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For <c>VpcEndpointAssociation</c>, this <c>Attachment</c> is part of the <c>VpcEndpointAssociationStatus</c>
    /// sync states information. You define these subnets using <c>CreateVpcEndpointAssociation</c>.
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class Attachment
    {
        private string _endpointId;
        private AttachmentStatus _status;
        private string _statusMessage;
        private string _subnetId;

        /// <summary>
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// The identifier of the firewall endpoint that Network Firewall has instantiated in
        /// the subnet. You use this to identify the firewall endpoint in the VPC route tables,
        /// when you redirect the VPC traffic through the endpoint. 
        /// </para>
        /// </summary>
        public string EndpointId
        {
            get { return this._endpointId; }
            set { this._endpointId = value; }
        }

        // Check to see if EndpointId property is set
        internal bool IsSetEndpointId()
        {
            return this._endpointId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the firewall endpoint instantiation in the subnet. 
        /// </para>
        ///  
        /// <para>
        /// When this value is <c>READY</c>, the endpoint is available to handle network traffic.
        /// Otherwise, this value reflects its state, for example <c>CREATING</c> or <c>DELETING</c>.
        /// </para>
        /// </summary>
        public AttachmentStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// If Network Firewall fails to create or delete the firewall endpoint in the subnet,
        /// it populates this with the reason for the error or failure and how to resolve it.
        /// A <c>FAILED</c> status indicates a non-recoverable state, and a <c>ERROR</c> status
        /// indicates an issue that you can fix. Depending on the error, it can take as many as
        /// 15 minutes to populate this field. For more information about the causes for failiure
        /// or errors and solutions available for this field, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/firewall-troubleshooting-endpoint-failures.html">Troubleshooting
        /// firewall endpoint failures</a> in the <i>Network Firewall Developer Guide</i>.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The unique identifier of the subnet that you've specified to be used for a firewall
        /// endpoint. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

    }
}