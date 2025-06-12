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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
        private string _replicationSubnetGroupDescription;
        private string _replicationSubnetGroupIdentifier;
        private string _subnetGroupStatus;
        private List<Subnet> _subnets = AWSConfigs.InitializeCollections ? new List<Subnet>() : null;
        private List<string> _supportedNetworkTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property ReplicationSubnetGroupDescription. 
        /// <para>
        /// A description for the replication subnet group.
        /// </para>
        /// </summary>
        public string ReplicationSubnetGroupDescription
        {
            get { return this._replicationSubnetGroupDescription; }
            set { this._replicationSubnetGroupDescription = value; }
        }

        // Check to see if ReplicationSubnetGroupDescription property is set
        internal bool IsSetReplicationSubnetGroupDescription()
        {
            return this._replicationSubnetGroupDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationSubnetGroupIdentifier. 
        /// <para>
        /// The identifier of the replication instance subnet group.
        /// </para>
        /// </summary>
        public string ReplicationSubnetGroupIdentifier
        {
            get { return this._replicationSubnetGroupIdentifier; }
            set { this._replicationSubnetGroupIdentifier = value; }
        }

        // Check to see if ReplicationSubnetGroupIdentifier property is set
        internal bool IsSetReplicationSubnetGroupIdentifier()
        {
            return this._replicationSubnetGroupIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetGroupStatus. 
        /// <para>
        /// The status of the subnet group.
        /// </para>
        /// </summary>
        public string SubnetGroupStatus
        {
            get { return this._subnetGroupStatus; }
            set { this._subnetGroupStatus = value; }
        }

        // Check to see if SubnetGroupStatus property is set
        internal bool IsSetSubnetGroupStatus()
        {
            return this._subnetGroupStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// The subnets that are in the subnet group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Subnet> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this._subnets != null && (this._subnets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedNetworkTypes. 
        /// <para>
        /// The IP addressing protocol supported by the subnet group. This is used by a replication
        /// instance with values such as IPv4 only or Dual-stack that supports both IPv4 and IPv6
        /// addressing. IPv6 only is not yet supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedNetworkTypes
        {
            get { return this._supportedNetworkTypes; }
            set { this._supportedNetworkTypes = value; }
        }

        // Check to see if SupportedNetworkTypes property is set
        internal bool IsSetSupportedNetworkTypes()
        {
            return this._supportedNetworkTypes != null && (this._supportedNetworkTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC.
        /// </para>
        /// </summary>
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