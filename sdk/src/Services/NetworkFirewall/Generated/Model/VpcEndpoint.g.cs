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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// The VPC and subnets for the endpoints of a proxy mode firewall. You use this in <c>CreateFirewall</c>.
    /// Network Firewall creates the firewall endpoints and the firewall's NAT gateways in
    /// this VPC.
    /// 
    ///  
    /// <para>
    /// This differs from <c>VpcEndpointAssociation</c>, which defines additional endpoints
    /// for a firewall in other VPCs.
    /// </para>
    /// </summary>
    public partial class VpcEndpoint
    {
        /// <summary>
        /// Gets and sets the property SubnetMappings. 
        /// <para>
        /// The subnets where Network Firewall creates the firewall endpoints of a proxy mode
        /// firewall. Specify one subnet for each Availability Zone, and a NAT gateway mapping
        /// in each of those Availability Zones.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<SubnetMapping> SubnetMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<SubnetMapping>() : null;

        /// <summary>
        /// Checks to see if the SubnetMappings property is set.
        /// </summary>
        internal bool IsSetSubnetMappings() => this.SubnetMappings != null && (this.SubnetMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC where Network Firewall creates the endpoints and NAT gateways of
        /// a proxy mode firewall.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
