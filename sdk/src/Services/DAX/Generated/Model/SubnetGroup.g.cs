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

namespace Amazon.DAX.Model
{
    /// <summary>
    /// Represents the output of one of the following actions:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <i>CreateSubnetGroup</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>ModifySubnetGroup</i> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class SubnetGroup
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the subnet group.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property SubnetGroupName. 
        /// <para>
        /// The name of the subnet group.
        /// </para>
        /// </summary>
        public string SubnetGroupName { get; set; }

        /// <summary>
        /// Checks to see if the SubnetGroupName property is set.
        /// </summary>
        internal bool IsSetSubnetGroupName() => this.SubnetGroupName != null;

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// A list of subnets associated with the subnet group. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Subnet> Subnets { get; set; } = AWSConfigs.InitializeCollections ? new List<Subnet>() : null;

        /// <summary>
        /// Checks to see if the Subnets property is set.
        /// </summary>
        internal bool IsSetSubnets() => this.Subnets != null && (this.Subnets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedNetworkTypes. 
        /// <para>
        /// The network types supported by this subnet. Returns an array of strings that can include
        /// <c>ipv4</c>, <c>ipv6</c>, or both, indicating whether the subnet group supports IPv4
        /// only, IPv6 only, or dual-stack deployments. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedNetworkTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedNetworkTypes property is set.
        /// </summary>
        internal bool IsSetSupportedNetworkTypes() => this.SupportedNetworkTypes != null && (this.SupportedNetworkTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The Amazon Virtual Private Cloud identifier (VPC ID) of the subnet group.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
