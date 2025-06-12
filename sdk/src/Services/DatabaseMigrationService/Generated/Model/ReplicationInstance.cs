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
    /// Provides information that defines a replication instance.
    /// </summary>
    public partial class ReplicationInstance
    {
        private int? _allocatedStorage;
        private bool? _autoMinorVersionUpgrade;
        private string _availabilityZone;
        private string _dnsNameServers;
        private string _engineVersion;
        private DateTime? _freeUntil;
        private DateTime? _instanceCreateTime;
        private KerberosAuthenticationSettings _kerberosAuthenticationSettings;
        private string _kmsKeyId;
        private bool? _multiAZ;
        private string _networkType;
        private ReplicationPendingModifiedValues _pendingModifiedValues;
        private string _preferredMaintenanceWindow;
        private bool? _publiclyAccessible;
        private string _replicationInstanceArn;
        private string _replicationInstanceClass;
        private string _replicationInstanceIdentifier;
        private List<string> _replicationInstanceIpv6Addresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _replicationInstancePrivateIpAddress;
        private List<string> _replicationInstancePrivateIpAddresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _replicationInstancePublicIpAddress;
        private List<string> _replicationInstancePublicIpAddresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _replicationInstanceStatus;
        private ReplicationSubnetGroup _replicationSubnetGroup;
        private string _secondaryAvailabilityZone;
        private List<VpcSecurityGroupMembership> _vpcSecurityGroups = AWSConfigs.InitializeCollections ? new List<VpcSecurityGroupMembership>() : null;

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The amount of storage (in gigabytes) that is allocated for the replication instance.
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
        /// Boolean value indicating if minor version upgrades will be automatically applied to
        /// the instance.
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
        /// The Availability Zone for the instance.
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
        /// Gets and sets the property DnsNameServers. 
        /// <para>
        /// The DNS name servers supported for the replication instance to access your on-premise
        /// source or target database.
        /// </para>
        /// </summary>
        public string DnsNameServers
        {
            get { return this._dnsNameServers; }
            set { this._dnsNameServers = value; }
        }

        // Check to see if DnsNameServers property is set
        internal bool IsSetDnsNameServers()
        {
            return this._dnsNameServers != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The engine version number of the replication instance.
        /// </para>
        ///  
        /// <para>
        /// If an engine version number is not specified when a replication instance is created,
        /// the default is the latest engine version available.
        /// </para>
        ///  
        /// <para>
        /// When modifying a major engine version of an instance, also set <c>AllowMajorVersionUpgrade</c>
        /// to <c>true</c>.
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
        /// Gets and sets the property FreeUntil. 
        /// <para>
        ///  The expiration date of the free replication instance that is part of the Free DMS
        /// program. 
        /// </para>
        /// </summary>
        public DateTime? FreeUntil
        {
            get { return this._freeUntil; }
            set { this._freeUntil = value; }
        }

        // Check to see if FreeUntil property is set
        internal bool IsSetFreeUntil()
        {
            return this._freeUntil.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceCreateTime. 
        /// <para>
        /// The time the replication instance was created.
        /// </para>
        /// </summary>
        public DateTime? InstanceCreateTime
        {
            get { return this._instanceCreateTime; }
            set { this._instanceCreateTime = value; }
        }

        // Check to see if InstanceCreateTime property is set
        internal bool IsSetInstanceCreateTime()
        {
            return this._instanceCreateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KerberosAuthenticationSettings. 
        /// <para>
        /// Specifies the settings required for kerberos authentication when replicating an instance.
        /// </para>
        /// </summary>
        public KerberosAuthenticationSettings KerberosAuthenticationSettings
        {
            get { return this._kerberosAuthenticationSettings; }
            set { this._kerberosAuthenticationSettings = value; }
        }

        // Check to see if KerberosAuthenticationSettings property is set
        internal bool IsSetKerberosAuthenticationSettings()
        {
            return this._kerberosAuthenticationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// An KMS key identifier that is used to encrypt the data on the replication instance.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for the <c>KmsKeyId</c> parameter, then DMS uses your
        /// default encryption key.
        /// </para>
        ///  
        /// <para>
        /// KMS creates the default encryption key for your Amazon Web Services account. Your
        /// Amazon Web Services account has a different default encryption key for each Amazon
        /// Web Services Region.
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
        ///  Specifies whether the replication instance is a Multi-AZ deployment. You can't set
        /// the <c>AvailabilityZone</c> parameter if the Multi-AZ parameter is set to <c>true</c>.
        /// 
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
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The type of IP address protocol used by a replication instance, such as IPv4 only
        /// or Dual-stack that supports both IPv4 and IPv6 addressing. IPv6 only is not yet supported.
        /// </para>
        /// </summary>
        public string NetworkType
        {
            get { return this._networkType; }
            set { this._networkType = value; }
        }

        // Check to see if NetworkType property is set
        internal bool IsSetNetworkType()
        {
            return this._networkType != null;
        }

        /// <summary>
        /// Gets and sets the property PendingModifiedValues. 
        /// <para>
        /// The pending modification values.
        /// </para>
        /// </summary>
        public ReplicationPendingModifiedValues PendingModifiedValues
        {
            get { return this._pendingModifiedValues; }
            set { this._pendingModifiedValues = value; }
        }

        // Check to see if PendingModifiedValues property is set
        internal bool IsSetPendingModifiedValues()
        {
            return this._pendingModifiedValues != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// The maintenance window times for the replication instance. Any pending upgrades to
        /// the replication instance are performed during this time.
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
        /// Gets and sets the property ReplicationInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the replication instance.
        /// </para>
        /// </summary>
        public string ReplicationInstanceArn
        {
            get { return this._replicationInstanceArn; }
            set { this._replicationInstanceArn = value; }
        }

        // Check to see if ReplicationInstanceArn property is set
        internal bool IsSetReplicationInstanceArn()
        {
            return this._replicationInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationInstanceClass. 
        /// <para>
        /// The compute and memory capacity of the replication instance as defined for the specified
        /// replication instance class. It is a required parameter, although a default value is
        /// pre-selected in the DMS console.
        /// </para>
        ///  
        /// <para>
        /// For more information on the settings and capacities for the available replication
        /// instance classes, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_ReplicationInstance.html#CHAP_ReplicationInstance.InDepth">
        /// Selecting the right DMS replication instance for your migration</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=30)]
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
        /// The replication instance identifier is a required parameter. This parameter is stored
        /// as a lowercase string.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain 1-63 alphanumeric characters or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>myrepinstance</c> 
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
        /// Gets and sets the property ReplicationInstanceIpv6Addresses. 
        /// <para>
        /// One or more IPv6 addresses for the replication instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReplicationInstanceIpv6Addresses
        {
            get { return this._replicationInstanceIpv6Addresses; }
            set { this._replicationInstanceIpv6Addresses = value; }
        }

        // Check to see if ReplicationInstanceIpv6Addresses property is set
        internal bool IsSetReplicationInstanceIpv6Addresses()
        {
            return this._replicationInstanceIpv6Addresses != null && (this._replicationInstanceIpv6Addresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReplicationInstancePrivateIpAddress. 
        /// <para>
        /// The private IP address of the replication instance.
        /// </para>
        /// </summary>
        [Obsolete("This type is deprecated")]
        public string ReplicationInstancePrivateIpAddress
        {
            get { return this._replicationInstancePrivateIpAddress; }
            set { this._replicationInstancePrivateIpAddress = value; }
        }

        // Check to see if ReplicationInstancePrivateIpAddress property is set
        internal bool IsSetReplicationInstancePrivateIpAddress()
        {
            return this._replicationInstancePrivateIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationInstancePrivateIpAddresses. 
        /// <para>
        /// One or more private IP addresses for the replication instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReplicationInstancePrivateIpAddresses
        {
            get { return this._replicationInstancePrivateIpAddresses; }
            set { this._replicationInstancePrivateIpAddresses = value; }
        }

        // Check to see if ReplicationInstancePrivateIpAddresses property is set
        internal bool IsSetReplicationInstancePrivateIpAddresses()
        {
            return this._replicationInstancePrivateIpAddresses != null && (this._replicationInstancePrivateIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReplicationInstancePublicIpAddress. 
        /// <para>
        /// The public IP address of the replication instance.
        /// </para>
        /// </summary>
        [Obsolete("This type is deprecated")]
        public string ReplicationInstancePublicIpAddress
        {
            get { return this._replicationInstancePublicIpAddress; }
            set { this._replicationInstancePublicIpAddress = value; }
        }

        // Check to see if ReplicationInstancePublicIpAddress property is set
        internal bool IsSetReplicationInstancePublicIpAddress()
        {
            return this._replicationInstancePublicIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationInstancePublicIpAddresses. 
        /// <para>
        /// One or more public IP addresses for the replication instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReplicationInstancePublicIpAddresses
        {
            get { return this._replicationInstancePublicIpAddresses; }
            set { this._replicationInstancePublicIpAddresses = value; }
        }

        // Check to see if ReplicationInstancePublicIpAddresses property is set
        internal bool IsSetReplicationInstancePublicIpAddresses()
        {
            return this._replicationInstancePublicIpAddresses != null && (this._replicationInstancePublicIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReplicationInstanceStatus. 
        /// <para>
        /// The status of the replication instance. The possible return values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"available"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"creating"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"deleted"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"deleting"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"failed"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"modifying"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"upgrading"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"rebooting"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"resetting-master-credentials"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"storage-full"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"incompatible-credentials"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"incompatible-network"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"maintenance"</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ReplicationInstanceStatus
        {
            get { return this._replicationInstanceStatus; }
            set { this._replicationInstanceStatus = value; }
        }

        // Check to see if ReplicationInstanceStatus property is set
        internal bool IsSetReplicationInstanceStatus()
        {
            return this._replicationInstanceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationSubnetGroup. 
        /// <para>
        /// The subnet group for the replication instance.
        /// </para>
        /// </summary>
        public ReplicationSubnetGroup ReplicationSubnetGroup
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
        /// Gets and sets the property SecondaryAvailabilityZone. 
        /// <para>
        /// The Availability Zone of the standby replication instance in a Multi-AZ deployment.
        /// </para>
        /// </summary>
        public string SecondaryAvailabilityZone
        {
            get { return this._secondaryAvailabilityZone; }
            set { this._secondaryAvailabilityZone = value; }
        }

        // Check to see if SecondaryAvailabilityZone property is set
        internal bool IsSetSecondaryAvailabilityZone()
        {
            return this._secondaryAvailabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroups. 
        /// <para>
        /// The VPC security group for the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcSecurityGroupMembership> VpcSecurityGroups
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