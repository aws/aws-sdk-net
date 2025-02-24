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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterTransitGatewayMulticastGroupSources operation.
    /// Registers sources (network interfaces) with the specified transit gateway multicast
    /// group.
    /// 
    ///  
    /// <para>
    /// A multicast source is a network interface attached to a supported instance that sends
    /// multicast traffic. For more information about supported instances, see <a href="https://docs.aws.amazon.com/vpc/latest/tgw/tgw-multicast-overview.html">Multicast
    /// on transit gateways</a> in the <i>Amazon Web Services Transit Gateways Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// After you add the source, use <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_SearchTransitGatewayMulticastGroups.html">SearchTransitGatewayMulticastGroups</a>
    /// to verify that the source was added to the multicast group.
    /// </para>
    /// </summary>
    public partial class RegisterTransitGatewayMulticastGroupSourcesRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private string _groupIpAddress;
        private List<string> _networkInterfaceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _transitGatewayMulticastDomainId;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GroupIpAddress. 
        /// <para>
        /// The IP address assigned to the transit gateway multicast group.
        /// </para>
        /// </summary>
        public string GroupIpAddress
        {
            get { return this._groupIpAddress; }
            set { this._groupIpAddress = value; }
        }

        // Check to see if GroupIpAddress property is set
        internal bool IsSetGroupIpAddress()
        {
            return this._groupIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceIds. 
        /// <para>
        /// The group sources' network interface IDs to register with the transit gateway multicast
        /// group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> NetworkInterfaceIds
        {
            get { return this._networkInterfaceIds; }
            set { this._networkInterfaceIds = value; }
        }

        // Check to see if NetworkInterfaceIds property is set
        internal bool IsSetNetworkInterfaceIds()
        {
            return this._networkInterfaceIds != null && (this._networkInterfaceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayMulticastDomainId. 
        /// <para>
        /// The ID of the transit gateway multicast domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TransitGatewayMulticastDomainId
        {
            get { return this._transitGatewayMulticastDomainId; }
            set { this._transitGatewayMulticastDomainId = value; }
        }

        // Check to see if TransitGatewayMulticastDomainId property is set
        internal bool IsSetTransitGatewayMulticastDomainId()
        {
            return this._transitGatewayMulticastDomainId != null;
        }

    }
}