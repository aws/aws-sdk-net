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
    /// The definition and status of the attachment between a proxy mode firewall and a NAT
    /// gateway that proxies its traffic.
    /// </summary>
    public partial class NatGatewayAttachment
    {
        private string _dnsName;
        private string _natGatewayId;
        private NatGatewayAttachmentStatus _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property DnsName. 
        /// <para>
        /// The DNS name that resolves to the firewall's proxy for traffic sent through this NAT
        /// gateway attachment. 
        /// </para>
        /// </summary>
        public string DnsName
        {
            get { return this._dnsName; }
            set { this._dnsName = value; }
        }

        // Check to see if DnsName property is set
        internal bool IsSetDnsName()
        {
            return this._dnsName != null;
        }

        /// <summary>
        /// Gets and sets the property NatGatewayId. 
        /// <para>
        /// A unique identifier for the NAT gateway to use with proxy resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string NatGatewayId
        {
            get { return this._natGatewayId; }
            set { this._natGatewayId = value; }
        }

        // Check to see if NatGatewayId property is set
        internal bool IsSetNatGatewayId()
        {
            return this._natGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the NAT gateway attachment. 
        /// </para>
        ///  
        /// <para>
        /// When this value is <c>READY</c>, the attachment is available to proxy traffic. Otherwise,
        /// this value reflects its state, for example <c>CREATING</c> or <c>DELETING</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NatGatewayAttachmentStatus Status
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
        /// If Network Firewall encounters an issue with the NAT gateway attachment, it populates
        /// this with an explanation of the problem. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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

    }
}