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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// The configuration and status for a single subnet that you've specified for use by
    /// the Network Firewall firewall. This is part of the <a>FirewallStatus</a>.
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
        /// The current status of the firewall endpoint in the subnet. This value reflects both
        /// the instantiation of the endpoint in the VPC subnet and the sync states that are reported
        /// in the <code>Config</code> settings. When this value is <code>READY</code>, the endpoint
        /// is available and configured properly to handle network traffic. When the endpoint
        /// isn't available for traffic, this value will reflect its state, for example <code>CREATING</code>
        /// or <code>DELETING</code>.
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
        /// it populates this with the reason for the failure and how to resolve it. Depending
        /// on the error, it can take as many as 15 minutes to populate this field. For more information
        /// about the errors and solutions available for this field, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/firewall-troubleshooting-endpoint-failures.html">Troubleshooting
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