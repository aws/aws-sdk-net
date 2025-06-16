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
    /// Container for the parameters to the RejectNetworkFirewallTransitGatewayAttachment operation.
    /// Rejects a transit gateway attachment request for Network Firewall. When you reject
    /// the attachment request, Network Firewall cancels the creation of routing components
    /// between the transit gateway and firewall endpoints.
    /// 
    ///  
    /// <para>
    /// Only the transit gateway owner can reject the attachment. After rejection, no traffic
    /// will flow through the firewall endpoints for this attachment.
    /// </para>
    ///  
    /// <para>
    /// Use <a>DescribeFirewall</a> to monitor the rejection status. To accept the attachment
    /// instead of rejecting it, use <a>AcceptNetworkFirewallTransitGatewayAttachment</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Once rejected, you cannot reverse this action. To establish connectivity, you must
    /// create a new transit gateway-attached firewall.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class RejectNetworkFirewallTransitGatewayAttachmentRequest : AmazonNetworkFirewallRequest
    {
        private string _transitGatewayAttachmentId;

        /// <summary>
        /// Gets and sets the property TransitGatewayAttachmentId. 
        /// <para>
        /// Required. The unique identifier of the transit gateway attachment to reject. This
        /// ID is returned in the response when creating a transit gateway-attached firewall.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string TransitGatewayAttachmentId
        {
            get { return this._transitGatewayAttachmentId; }
            set { this._transitGatewayAttachmentId = value; }
        }

        // Check to see if TransitGatewayAttachmentId property is set
        internal bool IsSetTransitGatewayAttachmentId()
        {
            return this._transitGatewayAttachmentId != null;
        }

    }
}