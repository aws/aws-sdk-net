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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about an Amazon RDS DB cluster.
    /// </summary>
    public partial class AwsRdsDbClusterDetails
    {
        /// <summary>
        /// Gets and sets the property ActivityStreamStatus. 
        /// <para>
        /// The status of the database activity stream. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>started</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>starting</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>stopped</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>stopping</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ActivityStreamStatus { get; set; }

        /// <summary>
        /// Checks to see if the ActivityStreamStatus property is set.
        /// </summary>
        internal bool IsSetActivityStreamStatus() => this.ActivityStreamStatus != null;

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// For all database engines except Aurora, specifies the allocated storage size in gibibytes
        /// (GiB).
        /// </para>
        /// </summary>
        public int? AllocatedStorage { get; set; }

        /// <summary>
        /// Checks to see if the AllocatedStorage property is set.
        /// </summary>
        internal bool IsSetAllocatedStorage() => this.AllocatedStorage.HasValue;

        /// <summary>
        /// Gets and sets the property AssociatedRoles. 
        /// <para>
        /// A list of the IAM roles that are associated with the DB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRdsDbClusterAssociatedRole> AssociatedRoles { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsRdsDbClusterAssociatedRole>() : null;

        /// <summary>
        /// Checks to see if the AssociatedRoles property is set.
        /// </summary>
        internal bool IsSetAssociatedRoles() => this.AssociatedRoles != null && (this.AssociatedRoles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        ///  Indicates if minor version upgrades are automatically applied to the cluster.
        /// </para>
        /// </summary>
        public bool? AutoMinorVersionUpgrade { get; set; }

        /// <summary>
        /// Checks to see if the AutoMinorVersionUpgrade property is set.
        /// </summary>
        internal bool IsSetAutoMinorVersionUpgrade() => this.AutoMinorVersionUpgrade.HasValue;

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// A list of Availability Zones (AZs) where instances in the DB cluster can be created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailabilityZones { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AvailabilityZones property is set.
        /// </summary>
        internal bool IsSetAvailabilityZones() => this.AvailabilityZones != null && (this.AvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        /// The number of days for which automated backups are retained.
        /// </para>
        /// </summary>
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the BackupRetentionPeriod property is set.
        /// </summary>
        internal bool IsSetBackupRetentionPeriod() => this.BackupRetentionPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property ClusterCreateTime. 
        /// <para>
        /// Indicates when the DB cluster was created, in Universal Coordinated Time (UTC).
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string ClusterCreateTime { get; set; }

        /// <summary>
        /// Checks to see if the ClusterCreateTime property is set.
        /// </summary>
        internal bool IsSetClusterCreateTime() => this.ClusterCreateTime != null;

        /// <summary>
        /// Gets and sets the property CopyTagsToSnapshot. 
        /// <para>
        /// Whether tags are copied from the DB cluster to snapshots of the DB cluster.
        /// </para>
        /// </summary>
        public bool? CopyTagsToSnapshot { get; set; }

        /// <summary>
        /// Checks to see if the CopyTagsToSnapshot property is set.
        /// </summary>
        internal bool IsSetCopyTagsToSnapshot() => this.CopyTagsToSnapshot.HasValue;

        /// <summary>
        /// Gets and sets the property CrossAccountClone. 
        /// <para>
        /// Whether the DB cluster is a clone of a DB cluster owned by a different Amazon Web
        /// Services account.
        /// </para>
        /// </summary>
        public bool? CrossAccountClone { get; set; }

        /// <summary>
        /// Checks to see if the CrossAccountClone property is set.
        /// </summary>
        internal bool IsSetCrossAccountClone() => this.CrossAccountClone.HasValue;

        /// <summary>
        /// Gets and sets the property CustomEndpoints. 
        /// <para>
        /// A list of custom endpoints for the DB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CustomEndpoints { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CustomEndpoints property is set.
        /// </summary>
        internal bool IsSetCustomEndpoints() => this.CustomEndpoints != null && (this.CustomEndpoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the database.
        /// </para>
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property DbClusterIdentifier. 
        /// <para>
        /// The DB cluster identifier that the user assigned to the cluster. This identifier is
        /// the unique key that identifies a DB cluster.
        /// </para>
        /// </summary>
        public string DbClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DbClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetDbClusterIdentifier() => this.DbClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property DbClusterMembers. 
        /// <para>
        /// The list of instances that make up the DB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRdsDbClusterMember> DbClusterMembers { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsRdsDbClusterMember>() : null;

        /// <summary>
        /// Checks to see if the DbClusterMembers property is set.
        /// </summary>
        internal bool IsSetDbClusterMembers() => this.DbClusterMembers != null && (this.DbClusterMembers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DbClusterOptionGroupMemberships. 
        /// <para>
        /// The list of option group memberships for this DB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRdsDbClusterOptionGroupMembership> DbClusterOptionGroupMemberships { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsRdsDbClusterOptionGroupMembership>() : null;

        /// <summary>
        /// Checks to see if the DbClusterOptionGroupMemberships property is set.
        /// </summary>
        internal bool IsSetDbClusterOptionGroupMemberships() => this.DbClusterOptionGroupMemberships != null && (this.DbClusterOptionGroupMemberships.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DbClusterParameterGroup. 
        /// <para>
        /// The name of the DB cluster parameter group for the DB cluster.
        /// </para>
        /// </summary>
        public string DbClusterParameterGroup { get; set; }

        /// <summary>
        /// Checks to see if the DbClusterParameterGroup property is set.
        /// </summary>
        internal bool IsSetDbClusterParameterGroup() => this.DbClusterParameterGroup != null;

        /// <summary>
        /// Gets and sets the property DbClusterResourceId. 
        /// <para>
        /// The identifier of the DB cluster. The identifier must be unique within each Amazon
        /// Web Services Region and is immutable.
        /// </para>
        /// </summary>
        public string DbClusterResourceId { get; set; }

        /// <summary>
        /// Checks to see if the DbClusterResourceId property is set.
        /// </summary>
        internal bool IsSetDbClusterResourceId() => this.DbClusterResourceId != null;

        /// <summary>
        /// Gets and sets the property DbSubnetGroup. 
        /// <para>
        /// The subnet group that is associated with the DB cluster, including the name, description,
        /// and subnets in the subnet group.
        /// </para>
        /// </summary>
        public string DbSubnetGroup { get; set; }

        /// <summary>
        /// Checks to see if the DbSubnetGroup property is set.
        /// </summary>
        internal bool IsSetDbSubnetGroup() => this.DbSubnetGroup != null;

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Whether the DB cluster has deletion protection enabled.
        /// </para>
        /// </summary>
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtection property is set.
        /// </summary>
        internal bool IsSetDeletionProtection() => this.DeletionProtection.HasValue;

        /// <summary>
        /// Gets and sets the property DomainMemberships. 
        /// <para>
        /// The Active Directory domain membership records that are associated with the DB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRdsDbDomainMembership> DomainMemberships { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsRdsDbDomainMembership>() : null;

        /// <summary>
        /// Checks to see if the DomainMemberships property is set.
        /// </summary>
        internal bool IsSetDomainMemberships() => this.DomainMemberships != null && (this.DomainMemberships.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnabledCloudWatchLogsExports. 
        /// <para>
        /// A list of log types that this DB cluster is configured to export to CloudWatch Logs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnabledCloudWatchLogsExports { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EnabledCloudWatchLogsExports property is set.
        /// </summary>
        internal bool IsSetEnabledCloudWatchLogsExports() => this.EnabledCloudWatchLogsExports != null && (this.EnabledCloudWatchLogsExports.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The connection endpoint for the primary instance of the DB cluster.
        /// </para>
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the database engine to use for this DB cluster. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>aurora</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aurora-mysql</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aurora-postgresql</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property EngineMode. 
        /// <para>
        /// The database engine mode of the DB cluster.Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>global</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>multimaster</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>parallelquery</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>provisioned</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>serverless</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string EngineMode { get; set; }

        /// <summary>
        /// Checks to see if the EngineMode property is set.
        /// </summary>
        internal bool IsSetEngineMode() => this.EngineMode != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version number of the database engine to use.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// Specifies the identifier that Amazon Route 53 assigns when you create a hosted zone.
        /// </para>
        /// </summary>
        public string HostedZoneId { get; set; }

        /// <summary>
        /// Checks to see if the HostedZoneId property is set.
        /// </summary>
        internal bool IsSetHostedZoneId() => this.HostedZoneId != null;

        /// <summary>
        /// Gets and sets the property HttpEndpointEnabled. 
        /// <para>
        /// Whether the HTTP endpoint for an Aurora Serverless DB cluster is enabled.
        /// </para>
        /// </summary>
        public bool? HttpEndpointEnabled { get; set; }

        /// <summary>
        /// Checks to see if the HttpEndpointEnabled property is set.
        /// </summary>
        internal bool IsSetHttpEndpointEnabled() => this.HttpEndpointEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property IamDatabaseAuthenticationEnabled. 
        /// <para>
        /// Whether the mapping of IAM accounts to database accounts is enabled.
        /// </para>
        /// </summary>
        public bool? IamDatabaseAuthenticationEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IamDatabaseAuthenticationEnabled property is set.
        /// </summary>
        internal bool IsSetIamDatabaseAuthenticationEnabled() => this.IamDatabaseAuthenticationEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ARN of the KMS master key that is used to encrypt the database instances in the
        /// DB cluster.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// The name of the master user for the DB cluster.
        /// </para>
        /// </summary>
        public string MasterUsername { get; set; }

        /// <summary>
        /// Checks to see if the MasterUsername property is set.
        /// </summary>
        internal bool IsSetMasterUsername() => this.MasterUsername != null;

        /// <summary>
        /// Gets and sets the property MultiAz. 
        /// <para>
        /// Whether the DB cluster has instances in multiple Availability Zones.
        /// </para>
        /// </summary>
        public bool? MultiAz { get; set; }

        /// <summary>
        /// Checks to see if the MultiAz property is set.
        /// </summary>
        internal bool IsSetMultiAz() => this.MultiAz.HasValue;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number on which the DB instances in the DB cluster accept connections.
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property PreferredBackupWindow. 
        /// <para>
        /// The range of time each day when automated backups are created, if automated backups
        /// are enabled.
        /// </para>
        ///  
        /// <para>
        /// Uses the format <c>HH:MM-HH:MM</c>. For example, <c>04:52-05:22</c>.
        /// </para>
        /// </summary>
        public string PreferredBackupWindow { get; set; }

        /// <summary>
        /// Checks to see if the PreferredBackupWindow property is set.
        /// </summary>
        internal bool IsSetPreferredBackupWindow() => this.PreferredBackupWindow != null;

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// The weekly time range during which system maintenance can occur, in Universal Coordinated
        /// Time (UTC).
        /// </para>
        ///  
        /// <para>
        /// Uses the format <c>&lt;day&gt;:HH:MM-&lt;day&gt;:HH:MM</c>.
        /// </para>
        ///  
        /// <para>
        /// For the day values, use <c>mon</c>|<c>tue</c>|<c>wed</c>|<c>thu</c>|<c>fri</c>|<c>sat</c>|<c>sun</c>.
        /// </para>
        ///  
        /// <para>
        /// For example, <c>sun:09:32-sun:10:02</c>.
        /// </para>
        /// </summary>
        public string PreferredMaintenanceWindow { get; set; }

        /// <summary>
        /// Checks to see if the PreferredMaintenanceWindow property is set.
        /// </summary>
        internal bool IsSetPreferredMaintenanceWindow() => this.PreferredMaintenanceWindow != null;

        /// <summary>
        /// Gets and sets the property ReadReplicaIdentifiers. 
        /// <para>
        /// The identifiers of the read replicas that are associated with this DB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReadReplicaIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReadReplicaIdentifiers property is set.
        /// </summary>
        internal bool IsSetReadReplicaIdentifiers() => this.ReadReplicaIdentifiers != null && (this.ReadReplicaIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReaderEndpoint. 
        /// <para>
        /// The reader endpoint for the DB cluster.
        /// </para>
        /// </summary>
        public string ReaderEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ReaderEndpoint property is set.
        /// </summary>
        internal bool IsSetReaderEndpoint() => this.ReaderEndpoint != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of this DB cluster.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StorageEncrypted. 
        /// <para>
        /// Whether the DB cluster is encrypted.
        /// </para>
        /// </summary>
        public bool? StorageEncrypted { get; set; }

        /// <summary>
        /// Checks to see if the StorageEncrypted property is set.
        /// </summary>
        internal bool IsSetStorageEncrypted() => this.StorageEncrypted.HasValue;

        /// <summary>
        /// Gets and sets the property VpcSecurityGroups. 
        /// <para>
        /// A list of VPC security groups that the DB cluster belongs to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRdsDbInstanceVpcSecurityGroup> VpcSecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsRdsDbInstanceVpcSecurityGroup>() : null;

        /// <summary>
        /// Checks to see if the VpcSecurityGroups property is set.
        /// </summary>
        internal bool IsSetVpcSecurityGroups() => this.VpcSecurityGroups != null && (this.VpcSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
