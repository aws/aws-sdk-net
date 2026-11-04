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

namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Detailed information about a subnet group.
    /// </summary>
    public partial class DBSubnetGroup
    {
        /// <summary>
        /// Gets and sets the property DBSubnetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the DB subnet group.
        /// </para>
        /// </summary>
        public string DBSubnetGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the DBSubnetGroupArn property is set.
        /// </summary>
        internal bool IsSetDBSubnetGroupArn() => this.DBSubnetGroupArn != null;

        /// <summary>
        /// Gets and sets the property DBSubnetGroupDescription. 
        /// <para>
        /// Provides the description of the subnet group.
        /// </para>
        /// </summary>
        public string DBSubnetGroupDescription { get; set; }

        /// <summary>
        /// Checks to see if the DBSubnetGroupDescription property is set.
        /// </summary>
        internal bool IsSetDBSubnetGroupDescription() => this.DBSubnetGroupDescription != null;

        /// <summary>
        /// Gets and sets the property DBSubnetGroupName. 
        /// <para>
        /// The name of the subnet group.
        /// </para>
        /// </summary>
        public string DBSubnetGroupName { get; set; }

        /// <summary>
        /// Checks to see if the DBSubnetGroupName property is set.
        /// </summary>
        internal bool IsSetDBSubnetGroupName() => this.DBSubnetGroupName != null;

        /// <summary>
        /// Gets and sets the property SubnetGroupStatus. 
        /// <para>
        /// Provides the status of the subnet group.
        /// </para>
        /// </summary>
        public string SubnetGroupStatus { get; set; }

        /// <summary>
        /// Checks to see if the SubnetGroupStatus property is set.
        /// </summary>
        internal bool IsSetSubnetGroupStatus() => this.SubnetGroupStatus != null;

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// Detailed information about one or more subnets within a subnet group.
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
        /// The network type of the DB subnet group.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>IPV4</c> | <c>DUAL</c> 
        /// </para>
        ///  
        /// <para>
        /// A <c>DBSubnetGroup</c> can support only the IPv4 protocol or the IPv4 and the IPv6
        /// protocols (DUAL).
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
        /// Provides the virtual private cloud (VPC) ID of the subnet group.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
