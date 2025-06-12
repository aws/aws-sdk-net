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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about an Database Migration Service (DMS) replication instance.
    /// DMS uses a replication instance to connect to your source data store, read the source
    /// data, and format the data for consumption by the target data store.
    /// </summary>
    public partial class AwsDmsReplicationInstanceDetails
    {
        private int? _allocatedStorage;
        private bool? _autoMinorVersionUpgrade;
        private string _availabilityZone;
        private string _engineVersion;
        private string _kmsKeyId;
        private bool? _multiAZ;
        private string _preferredMaintenanceWindow;
        private bool? _publiclyAccessible;
        private string _replicationInstanceClass;
        private string _replicationInstanceIdentifier;
        private AwsDmsReplicationInstanceReplicationSubnetGroupDetails _replicationSubnetGroup;
        private List<AwsDmsReplicationInstanceVpcSecurityGroupsDetails> _vpcSecurityGroups = AWSConfigs.InitializeCollections ? new List<AwsDmsReplicationInstanceVpcSecurityGroupsDetails>() : null;

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        ///  The amount of storage (in gigabytes) that is allocated for the replication instance.
        /// 
        /// </para>
        /// </summary>
        public int? AllocatedStorage
        {
            get { return this._allocatedStorage; }
            set { this._allocatedStorage = value; }
        }

        // Check to see if AllocatedStorage property is set
        internal bool IsSetAllocatedStorage()
        {
            return this._allocatedStorage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        ///  Indicates whether minor engine upgrades are applied automatically to the replication
        /// instance during the maintenance window. 
        /// </para>
        /// </summary>
        public bool? AutoMinorVersionUpgrade
        {
            get { return this._autoMinorVersionUpgrade; }
            set { this._autoMinorVersionUpgrade = value; }
        }

        // Check to see if AutoMinorVersionUpgrade property is set
        internal bool IsSetAutoMinorVersionUpgrade()
        {
            return this._autoMinorVersionUpgrade.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        ///  The Availability Zone that the replication instance is created in. The default value
        /// is a random, system-chosen Availability Zone in the endpoint's Amazon Web Services
        /// Region, such as <c>us-east-1d</c>.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        ///  The engine version number of the replication instance. If an engine version number
        /// is not specified when a replication instance is created, the default is the latest
        /// engine version available. 
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        ///  An KMS key identifier that is used to encrypt the data on the replication instance.
        /// If you don't specify a value for the <c>KmsKeyId</c> parameter, DMS uses your default
        /// encryption key. KMS creates the default encryption key for your Amazon Web Services
        /// account. Your Amazon Web Services account has a different default encryption key for
        /// each Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property MultiAZ. 
        /// <para>
        ///  Specifies whether the replication instance is deployed across multiple Availability
        /// Zones (AZs). You can't set the <c>AvailabilityZone</c> parameter if the <c>MultiAZ</c>
        /// parameter is set to <c>true</c>.
        /// </para>
        /// </summary>
        public bool? MultiAZ
        {
            get { return this._multiAZ; }
            set { this._multiAZ = value; }
        }

        // Check to see if MultiAZ property is set
        internal bool IsSetMultiAZ()
        {
            return this._multiAZ.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        ///  The maintenance window times for the replication instance. Upgrades to the replication
        /// instance are performed during this time.
        /// </para>
        /// </summary>
        public string PreferredMaintenanceWindow
        {
            get { return this._preferredMaintenanceWindow; }
            set { this._preferredMaintenanceWindow = value; }
        }

        // Check to see if PreferredMaintenanceWindow property is set
        internal bool IsSetPreferredMaintenanceWindow()
        {
            return this._preferredMaintenanceWindow != null;
        }

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        ///  Specifies the accessibility options for the replication instance. A value of <c>true</c>
        /// represents an instance with a public IP address. A value of <c>false</c> represents
        /// an instance with a private IP address. The default value is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? PubliclyAccessible
        {
            get { return this._publiclyAccessible; }
            set { this._publiclyAccessible = value; }
        }

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this._publiclyAccessible.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationInstanceClass. 
        /// <para>
        ///  The compute and memory capacity of the replication instance as defined for the specified
        /// replication instance class. 
        /// </para>
        /// </summary>
        public string ReplicationInstanceClass
        {
            get { return this._replicationInstanceClass; }
            set { this._replicationInstanceClass = value; }
        }

        // Check to see if ReplicationInstanceClass property is set
        internal bool IsSetReplicationInstanceClass()
        {
            return this._replicationInstanceClass != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationInstanceIdentifier. 
        /// <para>
        ///  The replication instance identifier.
        /// </para>
        /// </summary>
        public string ReplicationInstanceIdentifier
        {
            get { return this._replicationInstanceIdentifier; }
            set { this._replicationInstanceIdentifier = value; }
        }

        // Check to see if ReplicationInstanceIdentifier property is set
        internal bool IsSetReplicationInstanceIdentifier()
        {
            return this._replicationInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationSubnetGroup. 
        /// <para>
        ///  The subnet group for the replication instance.
        /// </para>
        /// </summary>
        public AwsDmsReplicationInstanceReplicationSubnetGroupDetails ReplicationSubnetGroup
        {
            get { return this._replicationSubnetGroup; }
            set { this._replicationSubnetGroup = value; }
        }

        // Check to see if ReplicationSubnetGroup property is set
        internal bool IsSetReplicationSubnetGroup()
        {
            return this._replicationSubnetGroup != null;
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroups. 
        /// <para>
        ///  The virtual private cloud (VPC) security group for the replication instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsDmsReplicationInstanceVpcSecurityGroupsDetails> VpcSecurityGroups
        {
            get { return this._vpcSecurityGroups; }
            set { this._vpcSecurityGroups = value; }
        }

        // Check to see if VpcSecurityGroups property is set
        internal bool IsSetVpcSecurityGroups()
        {
            return this._vpcSecurityGroups != null && (this._vpcSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}