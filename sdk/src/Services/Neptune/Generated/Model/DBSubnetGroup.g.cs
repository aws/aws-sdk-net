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

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Contains the details of an Amazon Neptune DB subnet group.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <a>DescribeDBSubnetGroups</a>
    /// action.
    /// </para>
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
        /// Provides the description of the DB subnet group.
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
        /// The name of the DB subnet group.
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
        /// Provides the status of the DB subnet group.
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
        ///  Contains a list of <a>Subnet</a> elements.
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
        /// The network types supported by the DB subnet group.
        /// </para>
        ///  
        /// <para>
        /// Valid network types include <c>IPV4</c> and <c>DUAL</c>. A DB subnet group supports
        /// <c>DUAL</c> if all subnets in the group have both IPv4 and IPv6 CIDRs.
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
        /// Provides the VpcId of the DB subnet group.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
