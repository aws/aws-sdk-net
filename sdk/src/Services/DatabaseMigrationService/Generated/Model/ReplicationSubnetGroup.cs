/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ReplicationSubnetGroup
    {
        private string _replicationSubnetGroupDescription;
        private string _replicationSubnetGroupIdentifier;
        private string _subnetGroupStatus;
        private List<Subnet> _subnets = new List<Subnet>();
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property ReplicationSubnetGroupDescription. 
        /// <para>
        /// The description of the replication subnet group.
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
        /// </summary>
        public List<Subnet> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this._subnets != null && this._subnets.Count > 0; 
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