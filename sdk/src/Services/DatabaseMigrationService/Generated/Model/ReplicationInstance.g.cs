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
    /// Provides information that defines a replication instance.
    /// </summary>
    public partial class ReplicationInstance
    {
        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The amount of storage (in gigabytes) that is allocated for the replication instance.
        /// </para>
        /// </summary>
        public int? AllocatedStorage { get; set; }

        /// <summary>
        /// Checks to see if the AllocatedStorage property is set.
        /// </summary>
        internal bool IsSetAllocatedStorage() => this.AllocatedStorage.HasValue;

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        /// Boolean value indicating if minor version upgrades will be automatically applied to
        /// the instance.
        /// </para>
        /// </summary>
        public bool? AutoMinorVersionUpgrade { get; set; }

        /// <summary>
        /// Checks to see if the AutoMinorVersionUpgrade property is set.
        /// </summary>
        internal bool IsSetAutoMinorVersionUpgrade() => this.AutoMinorVersionUpgrade.HasValue;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone for the instance.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property DnsNameServers. 
        /// <para>
        /// The DNS name servers supported for the replication instance to access your on-premise
        /// source or target database.
        /// </para>
        /// </summary>
        public string DnsNameServers { get; set; }

        /// <summary>
        /// Checks to see if the DnsNameServers property is set.
        /// </summary>
        internal bool IsSetDnsNameServers() => this.DnsNameServers != null;

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
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property FreeUntil. 
        /// <para>
        ///  The expiration date of the free replication instance that is part of the Free DMS
        /// program. 
        /// </para>
        /// </summary>
        public DateTime? FreeUntil { get; set; }

        /// <summary>
        /// Checks to see if the FreeUntil property is set.
        /// </summary>
        internal bool IsSetFreeUntil() => this.FreeUntil.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceCreateTime. 
        /// <para>
        /// The time the replication instance was created.
        /// </para>
        /// </summary>
        public DateTime? InstanceCreateTime { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCreateTime property is set.
        /// </summary>
        internal bool IsSetInstanceCreateTime() => this.InstanceCreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property KerberosAuthenticationSettings. 
        /// <para>
        /// Specifies the settings required for kerberos authentication when replicating an instance.
        /// </para>
        /// </summary>
        public KerberosAuthenticationSettings KerberosAuthenticationSettings { get; set; }

        /// <summary>
        /// Checks to see if the KerberosAuthenticationSettings property is set.
        /// </summary>
        internal bool IsSetKerberosAuthenticationSettings() => this.KerberosAuthenticationSettings != null;

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
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property MultiAZ. 
        /// <para>
        ///  Specifies whether the replication instance is a Multi-AZ deployment. You can't set
        /// the <c>AvailabilityZone</c> parameter if the Multi-AZ parameter is set to <c>true</c>.
        /// 
        /// </para>
        /// </summary>
        public bool? MultiAZ { get; set; }

        /// <summary>
        /// Checks to see if the MultiAZ property is set.
        /// </summary>
        internal bool IsSetMultiAZ() => this.MultiAZ.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The type of IP address protocol used by a replication instance, such as IPv4 only
        /// or Dual-stack that supports both IPv4 and IPv6 addressing. IPv6 only is not yet supported.
        /// </para>
        /// </summary>
        public string NetworkType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkType property is set.
        /// </summary>
        internal bool IsSetNetworkType() => this.NetworkType != null;

        /// <summary>
        /// Gets and sets the property PendingModifiedValues. 
        /// <para>
        /// The pending modification values.
        /// </para>
        /// </summary>
        public ReplicationPendingModifiedValues PendingModifiedValues { get; set; }

        /// <summary>
        /// Checks to see if the PendingModifiedValues property is set.
        /// </summary>
        internal bool IsSetPendingModifiedValues() => this.PendingModifiedValues != null;

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// The maintenance window times for the replication instance. Any pending upgrades to
        /// the replication instance are performed during this time.
        /// </para>
        /// </summary>
        public string PreferredMaintenanceWindow { get; set; }

        /// <summary>
        /// Checks to see if the PreferredMaintenanceWindow property is set.
        /// </summary>
        internal bool IsSetPreferredMaintenanceWindow() => this.PreferredMaintenanceWindow != null;

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        ///  Specifies the accessibility options for the replication instance. A value of <c>true</c>
        /// represents an instance with a public IP address. A value of <c>false</c> represents
        /// an instance with a private IP address. The default value is <c>true</c>. 
        /// </para>
        /// </summary>
        public bool? PubliclyAccessible { get; set; }

        /// <summary>
        /// Checks to see if the PubliclyAccessible property is set.
        /// </summary>
        internal bool IsSetPubliclyAccessible() => this.PubliclyAccessible.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicationInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the replication instance.
        /// </para>
        /// </summary>
        public string ReplicationInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationInstanceArn property is set.
        /// </summary>
        internal bool IsSetReplicationInstanceArn() => this.ReplicationInstanceArn != null;

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
        [AWSProperty(Min = 0, Max = 30)]
        public string ReplicationInstanceClass { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationInstanceClass property is set.
        /// </summary>
        internal bool IsSetReplicationInstanceClass() => this.ReplicationInstanceClass != null;

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
        public string ReplicationInstanceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationInstanceIdentifier property is set.
        /// </summary>
        internal bool IsSetReplicationInstanceIdentifier() => this.ReplicationInstanceIdentifier != null;

        /// <summary>
        /// Gets and sets the property ReplicationInstanceIpv6Addresses. 
        /// <para>
        /// One or more IPv6 addresses for the replication instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReplicationInstanceIpv6Addresses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReplicationInstanceIpv6Addresses property is set.
        /// </summary>
        internal bool IsSetReplicationInstanceIpv6Addresses() => this.ReplicationInstanceIpv6Addresses != null && (this.ReplicationInstanceIpv6Addresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReplicationInstancePrivateIpAddress. 
        /// <para>
        /// The private IP address of the replication instance.
        /// </para>
        /// </summary>
        [Obsolete("This type is deprecated")]
        public string ReplicationInstancePrivateIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationInstancePrivateIpAddress property is set.
        /// </summary>
        internal bool IsSetReplicationInstancePrivateIpAddress() => this.ReplicationInstancePrivateIpAddress != null;

        /// <summary>
        /// Gets and sets the property ReplicationInstancePrivateIpAddresses. 
        /// <para>
        /// One or more private IP addresses for the replication instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReplicationInstancePrivateIpAddresses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReplicationInstancePrivateIpAddresses property is set.
        /// </summary>
        internal bool IsSetReplicationInstancePrivateIpAddresses() => this.ReplicationInstancePrivateIpAddresses != null && (this.ReplicationInstancePrivateIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReplicationInstancePublicIpAddress. 
        /// <para>
        /// The public IP address of the replication instance.
        /// </para>
        /// </summary>
        [Obsolete("This type is deprecated")]
        public string ReplicationInstancePublicIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationInstancePublicIpAddress property is set.
        /// </summary>
        internal bool IsSetReplicationInstancePublicIpAddress() => this.ReplicationInstancePublicIpAddress != null;

        /// <summary>
        /// Gets and sets the property ReplicationInstancePublicIpAddresses. 
        /// <para>
        /// One or more public IP addresses for the replication instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReplicationInstancePublicIpAddresses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReplicationInstancePublicIpAddresses property is set.
        /// </summary>
        internal bool IsSetReplicationInstancePublicIpAddresses() => this.ReplicationInstancePublicIpAddresses != null && (this.ReplicationInstancePublicIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public string ReplicationInstanceStatus { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationInstanceStatus property is set.
        /// </summary>
        internal bool IsSetReplicationInstanceStatus() => this.ReplicationInstanceStatus != null;

        /// <summary>
        /// Gets and sets the property ReplicationSubnetGroup. 
        /// <para>
        /// The subnet group for the replication instance.
        /// </para>
        /// </summary>
        public ReplicationSubnetGroup ReplicationSubnetGroup { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationSubnetGroup property is set.
        /// </summary>
        internal bool IsSetReplicationSubnetGroup() => this.ReplicationSubnetGroup != null;

        /// <summary>
        /// Gets and sets the property SecondaryAvailabilityZone. 
        /// <para>
        /// The Availability Zone of the standby replication instance in a Multi-AZ deployment.
        /// </para>
        /// </summary>
        public string SecondaryAvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryAvailabilityZone property is set.
        /// </summary>
        internal bool IsSetSecondaryAvailabilityZone() => this.SecondaryAvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property VpcSecurityGroups. 
        /// <para>
        /// The VPC security group for the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcSecurityGroupMembership> VpcSecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<VpcSecurityGroupMembership>() : null;

        /// <summary>
        /// Checks to see if the VpcSecurityGroups property is set.
        /// </summary>
        internal bool IsSetVpcSecurityGroups() => this.VpcSecurityGroups != null && (this.VpcSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
