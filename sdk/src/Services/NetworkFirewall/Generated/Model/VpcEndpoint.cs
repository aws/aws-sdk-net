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
    /// The VPC and subnets for a proxy mode firewall endpoint. This is used in <a>CreateFirewall</a>
    /// when <c>NoSourcePreservation</c> is <c>TRUE</c>, to specify where Network Firewall
    /// creates the firewall endpoint. 
    /// 
    ///  
    /// <para>
    /// This differs from <a>VpcEndpointAssociation</a>, which defines additional secondary
    /// endpoints for a firewall in other VPCs. 
    /// </para>
    /// </summary>
    public partial class VpcEndpoint
    {
        private List<SubnetMapping> _subnetMappings = AWSConfigs.InitializeCollections ? new List<SubnetMapping>() : null;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property SubnetMappings. 
        /// <para>
        /// The subnets in which Network Firewall creates the firewall endpoint for a proxy mode
        /// firewall. Each subnet must belong to a different Availability Zone in the VPC. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SubnetMapping> SubnetMappings
        {
            get { return this._subnetMappings; }
            set { this._subnetMappings = value; }
        }

        // Check to see if SubnetMappings property is set
        internal bool IsSetSubnetMappings()
        {
            return this._subnetMappings != null && (this._subnetMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The unique identifier of the VPC where Network Firewall creates the proxy mode firewall
        /// endpoint. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}