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
    /// Container for the parameters to the AcceptNetworkFirewallTransitGatewayAttachment operation.
    /// Accepts a transit gateway attachment request for Network Firewall. When you accept
    /// the attachment request, Network Firewall creates the necessary routing components
    /// to enable traffic flow between the transit gateway and firewall endpoints.
    /// 
    ///  
    /// <para>
    /// You must accept a transit gateway attachment to complete the creation of a transit
    /// gateway-attached firewall, unless auto-accept is enabled on the transit gateway. After
    /// acceptance, use <a>DescribeFirewall</a> to verify the firewall status.
    /// </para>
    ///  
    /// <para>
    /// To reject an attachment instead of accepting it, use <a>RejectNetworkFirewallTransitGatewayAttachment</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// It can take several minutes for the attachment acceptance to complete and the firewall
    /// to become available.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AcceptNetworkFirewallTransitGatewayAttachmentRequest : AmazonNetworkFirewallRequest
    {
        private string _transitGatewayAttachmentId;

        /// <summary>
        /// Gets and sets the property TransitGatewayAttachmentId. 
        /// <para>
        /// Required. The unique identifier of the transit gateway attachment to accept. This
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