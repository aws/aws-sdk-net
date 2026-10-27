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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Describes a subnet group in response to a request by the <c>DescribeReplicationSubnetGroups</c>
    /// operation.
    /// </summary>
    public partial class ReplicationSubnetGroup
    {
        /// <summary>
        /// Gets and sets the property IsReadOnly. 
        /// <para>
        /// Indicates whether the replication subnet group is read-only. When set to <c>true</c>,
        /// this subnet group is managed by DMS as part of a zero-ETL integration and cannot be
        /// modified or deleted directly. You can only modify or delete read-only subnet groups
        /// through their associated zero-ETL integration.
        /// </para>
        /// </summary>
        public bool? IsReadOnly { get; set; }

        /// <summary>
        /// Checks to see if the IsReadOnly property is set.
        /// </summary>
        internal bool IsSetIsReadOnly() => this.IsReadOnly.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicationSubnetGroupDescription. 
        /// <para>
        /// A description for the replication subnet group.
        /// </para>
        /// </summary>
        public string ReplicationSubnetGroupDescription { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationSubnetGroupDescription property is set.
        /// </summary>
        internal bool IsSetReplicationSubnetGroupDescription() => this.ReplicationSubnetGroupDescription != null;

        /// <summary>
        /// Gets and sets the property ReplicationSubnetGroupIdentifier. 
        /// <para>
        /// The identifier of the replication instance subnet group.
        /// </para>
        /// </summary>
        public string ReplicationSubnetGroupIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationSubnetGroupIdentifier property is set.
        /// </summary>
        internal bool IsSetReplicationSubnetGroupIdentifier() => this.ReplicationSubnetGroupIdentifier != null;

        /// <summary>
        /// Gets and sets the property SubnetGroupStatus. 
        /// <para>
        /// The status of the subnet group.
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
        /// The subnets that are in the subnet group.
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
        /// The IP addressing protocol supported by the subnet group. This is used by a replication
        /// instance with values such as IPv4 only or Dual-stack that supports both IPv4 and IPv6
        /// addressing. IPv6 only is not yet supported.
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
        /// The ID of the VPC.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
