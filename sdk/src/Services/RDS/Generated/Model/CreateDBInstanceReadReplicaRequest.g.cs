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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDBInstanceReadReplica operation. Creates
    /// a new DB instance that acts as a read replica for an existing source DB instance or
    /// Multi-AZ DB cluster. You can create a read replica for a DB instance running Db2,
    /// MariaDB, MySQL, Oracle, PostgreSQL, or SQL Server. You can create a read replica for
    /// a Multi-AZ DB cluster running MySQL or PostgreSQL. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_ReadRepl.html">Working
    /// with read replicas</a> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html#multi-az-db-clusters-migrating-to-instance-with-read-replica">Migrating
    /// from a Multi-AZ DB cluster to a DB instance using a read replica</a> in the <i>Amazon
    /// RDS User Guide</i>. <para> Amazon Aurora doesn't support this operation. To create
    /// a DB instance for an Aurora DB cluster, use the <c>CreateDBInstance</c> operation.
    /// </para> <para> RDS creates read replicas with backups disabled. All other attributes
    /// (including DB security groups and DB parameter groups) are inherited from the source
    /// DB instance or cluster, except as specified. </para> <important> <para> Your source
    /// DB instance or cluster must have backup retention enabled. </para> </important>
    /// </summary>
    public partial class CreateDBInstanceReadReplicaRequest : AmazonRDSRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public CreateDBInstanceReadReplicaRequest() { }

        /// <summary>
        /// Instantiates CreateDBInstanceReadReplicaRequest with the parameterized properties
        /// </summary>
        /// <param name="dbInstanceIdentifier">The DB instance identifier of the read replica. This identifier is the unique key that identifies a DB instance. This parameter is stored as a lowercase string.</param>
        /// <param name="sourceDBInstanceIdentifier">The identifier of the DB instance that will act as the source for the read replica. Each DB instance can have up to 15 read replicas, except for the following engines: <ul> <li> Db2 - Can have up to three replicas. </li> <li> Oracle - Can have up to five read replicas. </li> <li> SQL Server - Can have up to five read replicas. </li> </ul> Constraints: <ul> <li> Must be the identifier of an existing Db2, MariaDB, MySQL, Oracle, PostgreSQL, or SQL Server DB instance. </li> <li> Can't be specified if the <c>SourceDBClusterIdentifier</c> parameter is also specified. </li> <li> For the limitations of Oracle read replicas, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/oracle-read-replicas.limitations.html#oracle-read-replicas.limitations.versions-and-licenses">Version and licensing considerations for RDS for Oracle replicas</a> in the <i>Amazon RDS User Guide</i>. </li> <li> For the limitations of SQL Server read replicas, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/SQLServer.ReadReplicas.html#SQLServer.ReadReplicas.Limitations">Read replica limitations with SQL Server</a> in the <i>Amazon RDS User Guide</i>. </li> <li> The specified DB instance must have automatic backups enabled, that is, its backup retention period must be greater than 0. </li> <li> If the source DB instance is in the same Amazon Web Services Region as the read replica, specify a valid DB instance identifier. </li> <li> If the source DB instance is in a different Amazon Web Services Region from the read replica, specify a valid DB instance ARN. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.ARN.html#USER_Tagging.ARN.Constructing">Constructing an ARN for Amazon RDS</a> in the <i>Amazon RDS User Guide</i>. This doesn't apply to SQL Server or RDS Custom, which don't support cross-Region replicas. </li> </ul></param>
        public CreateDBInstanceReadReplicaRequest(string dbInstanceIdentifier, string sourceDBInstanceIdentifier)
        {
            this.DBInstanceIdentifier = dbInstanceIdentifier;
            this.SourceDBInstanceIdentifier = sourceDBInstanceIdentifier;
        }

        /// <summary>
        /// Gets and sets the property AdditionalStorageVolumes. 
        /// <para>
        /// A list of additional storage volumes to create for the DB instance. You can create
        /// up to three additional storage volumes using the names <c>rdsdbdata2</c>, <c>rdsdbdata3</c>,
        /// and <c>rdsdbdata4</c>. Additional storage volumes are supported for RDS for Oracle
        /// and RDS for SQL Server DB instances only.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AdditionalStorageVolume> AdditionalStorageVolumes { get; set; } = AWSConfigs.InitializeCollections ? new List<AdditionalStorageVolume>() : null;

        /// <summary>
        /// Checks to see if the AdditionalStorageVolumes property is set.
        /// </summary>
        internal bool IsSetAdditionalStorageVolumes() => this.AdditionalStorageVolumes != null && (this.AdditionalStorageVolumes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The amount of storage (in gibibytes) to allocate initially for the read replica. Follow
        /// the allocation rules specified in <c>CreateDBInstance</c>.
        /// </para>
        ///  
        /// <para>
        /// This setting isn't valid for RDS for SQL Server.
        /// </para>
        ///  <note> 
        /// <para>
        /// Be sure to allocate enough storage for your read replica so that the create operation
        /// can succeed. You can also allocate additional storage for future growth.
        /// </para>
        ///  </note>
        /// </summary>
        public int? AllocatedStorage { get; set; }

        /// <summary>
        /// Checks to see if the AllocatedStorage property is set.
        /// </summary>
        internal bool IsSetAllocatedStorage() => this.AllocatedStorage.HasValue;

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        /// Specifies whether to automatically apply minor engine upgrades to the read replica
        /// during the maintenance window.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        ///  
        /// <para>
        /// Default: Inherits the value from the source DB instance.
        /// </para>
        ///  
        /// <para>
        /// For more information about automatic minor version upgrades, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_UpgradeDBInstance.Upgrading.html#USER_UpgradeDBInstance.Upgrading.AutoMinorVersionUpgrades">Automatically
        /// upgrading the minor engine version</a>.
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
        /// The Availability Zone (AZ) where the read replica will be created.
        /// </para>
        ///  
        /// <para>
        /// Default: A random, system-chosen Availability Zone in the endpoint's Amazon Web Services
        /// Region.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>us-east-1d</c> 
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property BackupTarget. 
        /// <para>
        /// The location where RDS stores automated backups and manual snapshots.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>local</c> for Dedicated Local Zones
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>region</c> for Amazon Web Services Region
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string BackupTarget { get; set; }

        /// <summary>
        /// Checks to see if the BackupTarget property is set.
        /// </summary>
        internal bool IsSetBackupTarget() => this.BackupTarget != null;

        /// <summary>
        /// Gets and sets the property CACertificateIdentifier. 
        /// <para>
        /// The CA certificate identifier to use for the read replica's server certificate.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.SSL.html">Using
        /// SSL/TLS to encrypt a connection to a DB instance</a> in the <i>Amazon RDS User Guide</i>
        /// and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/UsingWithRDS.SSL.html">
        /// Using SSL/TLS to encrypt a connection to a DB cluster</a> in the <i>Amazon Aurora
        /// User Guide</i>.
        /// </para>
        /// </summary>
        public string CACertificateIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CACertificateIdentifier property is set.
        /// </summary>
        internal bool IsSetCACertificateIdentifier() => this.CACertificateIdentifier != null;

        /// <summary>
        /// Gets and sets the property CopyTagsToSnapshot. 
        /// <para>
        /// Specifies whether to copy all tags from the read replica to snapshots of the read
        /// replica. By default, tags aren't copied.
        /// </para>
        /// </summary>
        public bool? CopyTagsToSnapshot { get; set; }

        /// <summary>
        /// Checks to see if the CopyTagsToSnapshot property is set.
        /// </summary>
        internal bool IsSetCopyTagsToSnapshot() => this.CopyTagsToSnapshot.HasValue;

        /// <summary>
        /// Gets and sets the property CustomIamInstanceProfile. 
        /// <para>
        /// The instance profile associated with the underlying Amazon EC2 instance of an RDS
        /// Custom DB instance. The instance profile must meet the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The profile must exist in your account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The profile must have an IAM role that Amazon EC2 has permissions to assume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The instance profile name and the associated IAM role name must start with the prefix
        /// <c>AWSRDSCustom</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For the list of permissions required for the IAM role, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/custom-setup-orcl.html#custom-setup-orcl.iam-vpc">
        /// Configure IAM and your VPC</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This setting is required for RDS Custom DB instances.
        /// </para>
        /// </summary>
        public string CustomIamInstanceProfile { get; set; }

        /// <summary>
        /// Checks to see if the CustomIamInstanceProfile property is set.
        /// </summary>
        internal bool IsSetCustomIamInstanceProfile() => this.CustomIamInstanceProfile != null;

        /// <summary>
        /// Gets and sets the property DBCapacityReservationIdentifier. 
        /// <para>
        /// The identifier or the name of the DB capacity reservation to associate with this read
        /// replica. You can specify the identifier, which has the prefix <c>dbcr-</c>, or the
        /// reservation name. When you specify this parameter, the read replica uses reserved
        /// capacity from the specified reservation. A read replica uses one unit of reserved
        /// capacity, in the same way as any other DB instance.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>AvailabilityZone</c>, Amazon RDS places the DB instance in that
        /// Availability Zone, and the reservation must cover it.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The reservation must reserve capacity for the DB instance class and the database engine
        /// of the DB instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the reservation reserves capacity for a specific license model, the license model
        /// of the source DB instance must match it. A read replica inherits its license model
        /// from the source DB instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The reservation must be in the <c>active</c> state, and it must not be past its end
        /// date.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify <c>AvailabilityZone</c>, it must be one of the Availability Zones of
        /// the reservation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For a Multi-AZ DB instance, the reservation must cover two or more Availability Zones.
        /// A Multi-AZ DB instance uses one unit of reserved capacity in each of two Availability
        /// Zones. If the reservation covers more than two Availability Zones, Amazon RDS chooses
        /// the two that the DB instance uses.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The reservation must have available capacity in each Availability Zone that the DB
        /// instance uses.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The DB subnet group must be in a VPC with default tenancy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The DB subnet group must cover each Availability Zone that the DB instance uses.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string DBCapacityReservationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBCapacityReservationIdentifier property is set.
        /// </summary>
        internal bool IsSetDBCapacityReservationIdentifier() => this.DBCapacityReservationIdentifier != null;

        /// <summary>
        /// Gets and sets the property DBInstanceClass. 
        /// <para>
        /// The compute and memory capacity of the read replica, for example db.m4.large. Not
        /// all DB instance classes are available in all Amazon Web Services Regions, or for all
        /// database engines. For the full list of DB instance classes, and availability for your
        /// engine, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.DBInstanceClass.html">DB
        /// Instance Class</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: Inherits the value from the source DB instance.
        /// </para>
        /// </summary>
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceClass property is set.
        /// </summary>
        internal bool IsSetDBInstanceClass() => this.DBInstanceClass != null;

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// The DB instance identifier of the read replica. This identifier is the unique key
        /// that identifies a DB instance. This parameter is stored as a lowercase string.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DBInstanceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceIdentifier property is set.
        /// </summary>
        internal bool IsSetDBInstanceIdentifier() => this.DBInstanceIdentifier != null;

        /// <summary>
        /// Gets and sets the property DBParameterGroupName. 
        /// <para>
        /// The name of the DB parameter group to associate with this read replica DB instance.
        /// </para>
        ///  
        /// <para>
        /// For the Db2 DB engine, if your source DB instance uses the bring your own license
        /// (BYOL) model, then a custom parameter group must be associated with the replica. For
        /// a same Amazon Web Services Region replica, if you don't specify a custom parameter
        /// group, Amazon RDS associates the custom parameter group associated with the source
        /// DB instance. For a cross-Region replica, you must specify a custom parameter group.
        /// This custom parameter group must include your IBM Site ID and IBM Customer ID. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/db2-licensing.html#db2-prereqs-ibm-info">IBM
        /// IDs for bring your own license (BYOL) for Db2</a>. 
        /// </para>
        ///  
        /// <para>
        /// For Single-AZ or Multi-AZ DB instance read replica instances, if you don't specify
        /// a value for <c>DBParameterGroupName</c>, then Amazon RDS uses the <c>DBParameterGroup</c>
        /// of the source DB instance for a same Region read replica, or the default <c>DBParameterGroup</c>
        /// for the specified DB engine for a cross-Region read replica.
        /// </para>
        ///  
        /// <para>
        /// For Multi-AZ DB cluster same Region read replica instances, if you don't specify a
        /// value for <c>DBParameterGroupName</c>, then Amazon RDS uses the default <c>DBParameterGroup</c>.
        /// </para>
        ///  
        /// <para>
        /// Specifying a parameter group for this operation is only supported for MySQL DB instances
        /// for cross-Region read replicas, for Multi-AZ DB cluster read replica instances, for
        /// Db2 DB instances, and for Oracle DB instances. It isn't supported for MySQL DB instances
        /// for same Region read replicas or for RDS Custom.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be 1 to 255 letters, numbers, or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DBParameterGroupName { get; set; }

        /// <summary>
        /// Checks to see if the DBParameterGroupName property is set.
        /// </summary>
        internal bool IsSetDBParameterGroupName() => this.DBParameterGroupName != null;

        /// <summary>
        /// Gets and sets the property DBSubnetGroupName. 
        /// <para>
        /// A DB subnet group for the DB instance. The new DB instance is created in the VPC associated
        /// with the DB subnet group. If no DB subnet group is specified, then the new DB instance
        /// isn't created in a VPC.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If supplied, must match the name of an existing DB subnet group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The specified DB subnet group must be in the same Amazon Web Services Region in which
        /// the operation is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All read replicas in one Amazon Web Services Region that are created from the same
        /// source DB instance must either:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify DB subnet groups from the same VPC. All these read replicas are created in
        /// the same VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not specify a DB subnet group. All these read replicas are created outside of any
        /// VPC.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// Example: <c>mydbsubnetgroup</c> 
        /// </para>
        /// </summary>
        public string DBSubnetGroupName { get; set; }

        /// <summary>
        /// Checks to see if the DBSubnetGroupName property is set.
        /// </summary>
        internal bool IsSetDBSubnetGroupName() => this.DBSubnetGroupName != null;

        /// <summary>
        /// Gets and sets the property DatabaseInsightsMode. 
        /// <para>
        /// The mode of Database Insights to enable for the read replica.
        /// </para>
        ///  <note> 
        /// <para>
        /// This setting isn't supported.
        /// </para>
        ///  </note>
        /// </summary>
        public DatabaseInsightsMode DatabaseInsightsMode { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseInsightsMode property is set.
        /// </summary>
        internal bool IsSetDatabaseInsightsMode() => this.DatabaseInsightsMode != null;

        /// <summary>
        /// Gets and sets the property DedicatedLogVolume. 
        /// <para>
        /// Indicates whether the DB instance has a dedicated log volume (DLV) enabled.
        /// </para>
        /// </summary>
        public bool? DedicatedLogVolume { get; set; }

        /// <summary>
        /// Checks to see if the DedicatedLogVolume property is set.
        /// </summary>
        internal bool IsSetDedicatedLogVolume() => this.DedicatedLogVolume.HasValue;

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Specifies whether to enable deletion protection for the DB instance. The database
        /// can't be deleted when deletion protection is enabled. By default, deletion protection
        /// isn't enabled. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_DeleteInstance.html">
        /// Deleting a DB Instance</a>.
        /// </para>
        /// </summary>
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtection property is set.
        /// </summary>
        internal bool IsSetDeletionProtection() => this.DeletionProtection.HasValue;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The Active Directory directory ID to create the DB instance in. Currently, only MySQL,
        /// Microsoft SQL Server, Oracle, and PostgreSQL DB instances can be created in an Active
        /// Directory Domain.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/kerberos-authentication.html">
        /// Kerberos Authentication</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property DomainAuthSecretArn. 
        /// <para>
        /// The ARN for the Secrets Manager secret with the credentials for the user joining the
        /// domain.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>arn:aws:secretsmanager:region:account-number:secret:myselfmanagedADtestsecret-123456</c>
        /// 
        /// </para>
        /// </summary>
        public string DomainAuthSecretArn { get; set; }

        /// <summary>
        /// Checks to see if the DomainAuthSecretArn property is set.
        /// </summary>
        internal bool IsSetDomainAuthSecretArn() => this.DomainAuthSecretArn != null;

        /// <summary>
        /// Gets and sets the property DomainDnsIps. 
        /// <para>
        /// The IPv4 DNS IP addresses of your primary and secondary Active Directory domain controllers.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Two IP addresses must be provided. If there isn't a secondary domain controller, use
        /// the IP address of the primary domain controller for both entries in the list.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>123.124.125.126,234.235.236.237</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DomainDnsIps { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DomainDnsIps property is set.
        /// </summary>
        internal bool IsSetDomainDnsIps() => this.DomainDnsIps != null && (this.DomainDnsIps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DomainFqdn. 
        /// <para>
        /// The fully qualified domain name (FQDN) of an Active Directory domain.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can't be longer than 64 characters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>mymanagedADtest.mymanagedAD.mydomain</c> 
        /// </para>
        /// </summary>
        public string DomainFqdn { get; set; }

        /// <summary>
        /// Checks to see if the DomainFqdn property is set.
        /// </summary>
        internal bool IsSetDomainFqdn() => this.DomainFqdn != null;

        /// <summary>
        /// Gets and sets the property DomainIAMRoleName. 
        /// <para>
        /// The name of the IAM role to use when making API calls to the Directory Service.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        /// </summary>
        public string DomainIAMRoleName { get; set; }

        /// <summary>
        /// Checks to see if the DomainIAMRoleName property is set.
        /// </summary>
        internal bool IsSetDomainIAMRoleName() => this.DomainIAMRoleName != null;

        /// <summary>
        /// Gets and sets the property DomainOu. 
        /// <para>
        /// The Active Directory organizational unit for your DB instance to join.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be in the distinguished name format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be longer than 64 characters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>OU=mymanagedADtestOU,DC=mymanagedADtest,DC=mymanagedAD,DC=mydomain</c>
        /// 
        /// </para>
        /// </summary>
        public string DomainOu { get; set; }

        /// <summary>
        /// Checks to see if the DomainOu property is set.
        /// </summary>
        internal bool IsSetDomainOu() => this.DomainOu != null;

        /// <summary>
        /// Gets and sets the property EnableCloudwatchLogsExports. 
        /// <para>
        /// The list of logs that the new DB instance is to export to CloudWatch Logs. The values
        /// in the list depend on the DB engine being used. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_LogAccess.html#USER_LogAccess.Procedural.UploadtoCloudWatch">Publishing
        /// Database Logs to Amazon CloudWatch Logs </a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnableCloudwatchLogsExports { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EnableCloudwatchLogsExports property is set.
        /// </summary>
        internal bool IsSetEnableCloudwatchLogsExports() => this.EnableCloudwatchLogsExports != null && (this.EnableCloudwatchLogsExports.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnableCustomerOwnedIp. 
        /// <para>
        /// Specifies whether to enable a customer-owned IP address (CoIP) for an RDS on Outposts
        /// read replica.
        /// </para>
        ///  
        /// <para>
        /// A <i>CoIP</i> provides local or external connectivity to resources in your Outpost
        /// subnets through your on-premises network. For some use cases, a CoIP can provide lower
        /// latency for connections to the read replica from outside of its virtual private cloud
        /// (VPC) on your local network.
        /// </para>
        ///  
        /// <para>
        /// For more information about RDS on Outposts, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/rds-on-outposts.html">Working
        /// with Amazon RDS on Amazon Web Services Outposts</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about CoIPs, see <a href="https://docs.aws.amazon.com/outposts/latest/userguide/routing.html#ip-addressing">Customer-owned
        /// IP addresses</a> in the <i>Amazon Web Services Outposts User Guide</i>.
        /// </para>
        /// </summary>
        public bool? EnableCustomerOwnedIp { get; set; }

        /// <summary>
        /// Checks to see if the EnableCustomerOwnedIp property is set.
        /// </summary>
        internal bool IsSetEnableCustomerOwnedIp() => this.EnableCustomerOwnedIp.HasValue;

        /// <summary>
        /// Gets and sets the property EnableIAMDatabaseAuthentication. 
        /// <para>
        /// Specifies whether to enable mapping of Amazon Web Services Identity and Access Management
        /// (IAM) accounts to database accounts. By default, mapping isn't enabled.
        /// </para>
        ///  
        /// <para>
        /// For more information about IAM database authentication, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.IAMDBAuth.html">
        /// IAM Database Authentication for MySQL and PostgreSQL</a> in the <i>Amazon RDS User
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        /// </summary>
        public bool? EnableIAMDatabaseAuthentication { get; set; }

        /// <summary>
        /// Checks to see if the EnableIAMDatabaseAuthentication property is set.
        /// </summary>
        internal bool IsSetEnableIAMDatabaseAuthentication() => this.EnableIAMDatabaseAuthentication.HasValue;

        /// <summary>
        /// Gets and sets the property EnablePerformanceInsights. 
        /// <para>
        /// Specifies whether to enable Performance Insights for the read replica.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PerfInsights.html">Using
        /// Amazon Performance Insights</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        /// </summary>
        public bool? EnablePerformanceInsights { get; set; }

        /// <summary>
        /// Checks to see if the EnablePerformanceInsights property is set.
        /// </summary>
        internal bool IsSetEnablePerformanceInsights() => this.EnablePerformanceInsights.HasValue;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The amount of Provisioned IOPS (input/output operations per second) to initially allocate
        /// for the DB instance.
        /// </para>
        /// </summary>
        public int? Iops { get; set; }

        /// <summary>
        /// Checks to see if the Iops property is set.
        /// </summary>
        internal bool IsSetIops() => this.Iops.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key identifier for an encrypted read replica.
        /// </para>
        ///  
        /// <para>
        /// The Amazon Web Services KMS key identifier is the key ARN, key ID, alias ARN, or alias
        /// name for the KMS key.
        /// </para>
        ///  
        /// <para>
        /// For a read replica in the same Amazon Web Services Region as the source DB instance
        /// or Multi-AZ DB cluster, specifying this parameter is optional. If you specify a KMS
        /// key identifier, the read replica is encrypted with that KMS key, which can be different
        /// from the KMS key of the source.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for this parameter, the read replica is encrypted with
        /// the same KMS key as the source DB instance or Multi-AZ DB cluster.
        /// </para>
        ///  
        /// <para>
        /// If you create an encrypted read replica in a different Amazon Web Services Region,
        /// then you must specify a KMS key identifier for the destination Amazon Web Services
        /// Region. KMS keys are specific to the Amazon Web Services Region that they are created
        /// in, and you can't use KMS keys from one Amazon Web Services Region in another Amazon
        /// Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// You can't create an encrypted read replica from an unencrypted DB instance or Multi-AZ
        /// DB cluster.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom, which uses the same KMS key as the primary
        /// replica.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property MaxAllocatedStorage. 
        /// <para>
        /// The upper limit in gibibytes (GiB) to which Amazon RDS can automatically scale the
        /// storage of the DB instance.
        /// </para>
        ///  
        /// <para>
        /// For more information about this setting, including limitations that apply to it, see
        /// <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PIOPS.StorageTypes.html#USER_PIOPS.Autoscaling">
        /// Managing capacity automatically with Amazon RDS storage autoscaling</a> in the <i>Amazon
        /// RDS User Guide</i>.
        /// </para>
        /// </summary>
        public int? MaxAllocatedStorage { get; set; }

        /// <summary>
        /// Checks to see if the MaxAllocatedStorage property is set.
        /// </summary>
        internal bool IsSetMaxAllocatedStorage() => this.MaxAllocatedStorage.HasValue;

        /// <summary>
        /// Gets and sets the property MonitoringInterval. 
        /// <para>
        /// The interval, in seconds, between points when Enhanced Monitoring metrics are collected
        /// for the read replica. To disable collection of Enhanced Monitoring metrics, specify
        /// <c>0</c>. The default is <c>0</c>.
        /// </para>
        ///  
        /// <para>
        /// If <c>MonitoringRoleArn</c> is specified, then you must set <c>MonitoringInterval</c>
        /// to a value other than <c>0</c>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>0, 1, 5, 10, 15, 30, 60</c> 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>0</c> 
        /// </para>
        /// </summary>
        public int? MonitoringInterval { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringInterval property is set.
        /// </summary>
        internal bool IsSetMonitoringInterval() => this.MonitoringInterval.HasValue;

        /// <summary>
        /// Gets and sets the property MonitoringRoleArn. 
        /// <para>
        /// The ARN for the IAM role that permits RDS to send enhanced monitoring metrics to Amazon
        /// CloudWatch Logs. For example, <c>arn:aws:iam:123456789012:role/emaccess</c>. For information
        /// on creating a monitoring role, go to <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Monitoring.html#USER_Monitoring.OS.IAMRole">To
        /// create an IAM role for Amazon RDS Enhanced Monitoring</a> in the <i>Amazon RDS User
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If <c>MonitoringInterval</c> is set to a value other than 0, then you must supply
        /// a <c>MonitoringRoleArn</c> value.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        /// </summary>
        public string MonitoringRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringRoleArn property is set.
        /// </summary>
        internal bool IsSetMonitoringRoleArn() => this.MonitoringRoleArn != null;

        /// <summary>
        /// Gets and sets the property MultiAZ. 
        /// <para>
        /// Specifies whether the read replica is in a Multi-AZ deployment.
        /// </para>
        ///  
        /// <para>
        /// You can create a read replica as a Multi-AZ DB instance. RDS creates a standby of
        /// your replica in another Availability Zone for failover support for the replica. Creating
        /// your read replica as a Multi-AZ DB instance is independent of whether the source is
        /// a Multi-AZ DB instance or a Multi-AZ DB cluster.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
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
        /// The network type of the DB instance.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IPV4</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DUAL</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The network type is determined by the <c>DBSubnetGroup</c> specified for read replica.
        /// A <c>DBSubnetGroup</c> can support only the IPv4 protocol or the IPv4 and the IPv6
        /// protocols (<c>DUAL</c>).
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.WorkingWithRDSInstanceinaVPC.html">
        /// Working with a DB instance in a VPC</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        public string NetworkType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkType property is set.
        /// </summary>
        internal bool IsSetNetworkType() => this.NetworkType != null;

        /// <summary>
        /// Gets and sets the property OptionGroupName. 
        /// <para>
        /// The option group to associate the DB instance with. If not specified, RDS uses the
        /// option group associated with the source DB instance or cluster.
        /// </para>
        ///  <note> 
        /// <para>
        /// For SQL Server, you must use the option group associated with the source.
        /// </para>
        ///  </note> 
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        /// </summary>
        public string OptionGroupName { get; set; }

        /// <summary>
        /// Checks to see if the OptionGroupName property is set.
        /// </summary>
        internal bool IsSetOptionGroupName() => this.OptionGroupName != null;

        /// <summary>
        /// Gets and sets the property PerformanceInsightsKMSKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key identifier for encryption of Performance Insights
        /// data.
        /// </para>
        ///  
        /// <para>
        /// The Amazon Web Services KMS key identifier is the key ARN, key ID, alias ARN, or alias
        /// name for the KMS key.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value for <c>PerformanceInsightsKMSKeyId</c>, then Amazon
        /// RDS uses your default KMS key. There is a default KMS key for your Amazon Web Services
        /// account. Your Amazon Web Services account has a different default KMS key for each
        /// Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        /// </summary>
        public string PerformanceInsightsKMSKeyId { get; set; }

        /// <summary>
        /// Checks to see if the PerformanceInsightsKMSKeyId property is set.
        /// </summary>
        internal bool IsSetPerformanceInsightsKMSKeyId() => this.PerformanceInsightsKMSKeyId != null;

        /// <summary>
        /// Gets and sets the property PerformanceInsightsRetentionPeriod. 
        /// <para>
        /// The number of days to retain Performance Insights data.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>7</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>month</i> * 31, where <i>month</i> is a number of months from 1-23. Examples:
        /// <c>93</c> (3 months * 31), <c>341</c> (11 months * 31), <c>589</c> (19 months * 31)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>731</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <c>7</c> days
        /// </para>
        ///  
        /// <para>
        /// If you specify a retention period that isn't valid, such as <c>94</c>, Amazon RDS
        /// returns an error.
        /// </para>
        /// </summary>
        public int? PerformanceInsightsRetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the PerformanceInsightsRetentionPeriod property is set.
        /// </summary>
        internal bool IsSetPerformanceInsightsRetentionPeriod() => this.PerformanceInsightsRetentionPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number that the DB instance uses for connections.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>1150-65535</c> 
        /// </para>
        ///  
        /// <para>
        /// Default: Inherits the value from the source DB instance.
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property PreSignedUrl. 
        /// <para>
        /// When you are creating a read replica from one Amazon Web Services GovCloud (US) Region
        /// to another or from one China Amazon Web Services Region to another, the URL that contains
        /// a Signature Version 4 signed request for the <c>CreateDBInstanceReadReplica</c> API
        /// operation in the source Amazon Web Services Region that contains the source DB instance.
        /// </para>
        ///  
        /// <para>
        /// This setting applies only to Amazon Web Services GovCloud (US) Regions and China Amazon
        /// Web Services Regions. It's ignored in other Amazon Web Services Regions.
        /// </para>
        ///  
        /// <para>
        /// This setting applies only when replicating from a source DB <i>instance</i>. Source
        /// DB clusters aren't supported in Amazon Web Services GovCloud (US) Regions and China
        /// Amazon Web Services Regions.
        /// </para>
        ///  
        /// <para>
        /// You must specify this parameter when you create an encrypted read replica from another
        /// Amazon Web Services Region by using the Amazon RDS API. Don't specify <c>PreSignedUrl</c>
        /// when you are creating an encrypted read replica in the same Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// The presigned URL must be a valid request for the <c>CreateDBInstanceReadReplica</c>
        /// API operation that can run in the source Amazon Web Services Region that contains
        /// the encrypted source DB instance. The presigned URL request must contain the following
        /// parameter values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DestinationRegion</c> - The Amazon Web Services Region that the encrypted read
        /// replica is created in. This Amazon Web Services Region is the same one where the <c>CreateDBInstanceReadReplica</c>
        /// operation is called that contains this presigned URL.
        /// </para>
        ///  
        /// <para>
        /// For example, if you create an encrypted DB instance in the us-west-1 Amazon Web Services
        /// Region, from a source DB instance in the us-east-2 Amazon Web Services Region, then
        /// you call the <c>CreateDBInstanceReadReplica</c> operation in the us-east-1 Amazon
        /// Web Services Region and provide a presigned URL that contains a call to the <c>CreateDBInstanceReadReplica</c>
        /// operation in the us-west-2 Amazon Web Services Region. For this example, the <c>DestinationRegion</c>
        /// in the presigned URL must be set to the us-east-1 Amazon Web Services Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KmsKeyId</c> - The KMS key identifier for the key to use to encrypt the read replica
        /// in the destination Amazon Web Services Region. This is the same identifier for both
        /// the <c>CreateDBInstanceReadReplica</c> operation that is called in the destination
        /// Amazon Web Services Region, and the operation contained in the presigned URL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SourceDBInstanceIdentifier</c> - The DB instance identifier for the encrypted
        /// DB instance to be replicated. This identifier must be in the Amazon Resource Name
        /// (ARN) format for the source Amazon Web Services Region. For example, if you are creating
        /// an encrypted read replica from a DB instance in the us-west-2 Amazon Web Services
        /// Region, then your <c>SourceDBInstanceIdentifier</c> looks like the following example:
        /// <c>arn:aws:rds:us-west-2:123456789012:instance:mysql-instance1-20161115</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To learn how to generate a Signature Version 4 signed request, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sigv4-query-string-auth.html">Authenticating
        /// Requests: Using Query Parameters (Amazon Web Services Signature Version 4)</a> and
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4 Signing Process</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you are using an Amazon Web Services SDK tool or the CLI, you can specify <c>SourceRegion</c>
        /// (or <c>--source-region</c> for the CLI) instead of specifying <c>PreSignedUrl</c>
        /// manually. Specifying <c>SourceRegion</c> autogenerates a presigned URL that is a valid
        /// request for the operation that can run in the source Amazon Web Services Region.
        /// </para>
        ///  </note> 
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string PreSignedUrl { get; set; }

        /// <summary>
        /// Checks to see if the PreSignedUrl property is set.
        /// </summary>
        internal bool IsSetPreSignedUrl() => this.PreSignedUrl != null;

        /// <summary>
        /// Gets and sets the property ProcessorFeatures. 
        /// <para>
        /// The number of CPU cores and the number of threads per core for the DB instance class
        /// of the DB instance.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProcessorFeature> ProcessorFeatures { get; set; } = AWSConfigs.InitializeCollections ? new List<ProcessorFeature>() : null;

        /// <summary>
        /// Checks to see if the ProcessorFeatures property is set.
        /// </summary>
        internal bool IsSetProcessorFeatures() => this.ProcessorFeatures != null && (this.ProcessorFeatures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// Specifies whether the DB instance is publicly accessible.
        /// </para>
        ///  
        /// <para>
        /// When the DB cluster is publicly accessible, its Domain Name System (DNS) endpoint
        /// resolves to the private IP address from within the DB cluster's virtual private cloud
        /// (VPC). It resolves to the public IP address from outside of the DB cluster's VPC.
        /// Access to the DB cluster is ultimately controlled by the security group it uses. That
        /// public access isn't permitted if the security group assigned to the DB cluster doesn't
        /// permit it.
        /// </para>
        ///  
        /// <para>
        /// When the DB instance isn't publicly accessible, it is an internal DB instance with
        /// a DNS name that resolves to a private IP address.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a>CreateDBInstance</a>.
        /// </para>
        /// </summary>
        public bool? PubliclyAccessible { get; set; }

        /// <summary>
        /// Checks to see if the PubliclyAccessible property is set.
        /// </summary>
        internal bool IsSetPubliclyAccessible() => this.PubliclyAccessible.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicaMode. 
        /// <para>
        /// The open mode of the replica database.
        /// </para>
        ///  
        /// <para>
        /// This parameter is only supported for Db2 DB instances and Oracle DB instances.
        /// </para>
        ///  <dl> <dt>Db2</dt> <dd> 
        /// <para>
        /// Standby DB replicas are included in Db2 Advanced Edition (AE), Db2 Community Edition
        /// (CE), and Db2 Standard Edition (SE). The main use case for standby replicas is cross-Region
        /// disaster recovery. Because it doesn't accept user connections, a standby replica can't
        /// serve a read-only workload.
        /// </para>
        ///  
        /// <para>
        /// You can create a combination of standby and read-only DB replicas for the same primary
        /// DB instance. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/db2-replication.html">Working
        /// with replicas for Amazon RDS for Db2</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To create standby DB replicas for RDS for Db2, set this parameter to <c>mounted</c>.
        /// </para>
        ///  </dd> <dt>Oracle</dt> <dd> 
        /// <para>
        /// Mounted DB replicas are included in Oracle Database Enterprise Edition. The main use
        /// case for mounted replicas is cross-Region disaster recovery. The primary database
        /// doesn't use Active Data Guard to transmit information to the mounted replica. Because
        /// it doesn't accept user connections, a mounted replica can't serve a read-only workload.
        /// </para>
        ///  
        /// <para>
        /// You can create a combination of mounted and read-only DB replicas for the same primary
        /// DB instance. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/oracle-read-replicas.html">Working
        /// with read replicas for Amazon RDS for Oracle</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For RDS Custom, you must specify this parameter and set it to <c>mounted</c>. The
        /// value won't be set by default. After replica creation, you can manage the open mode
        /// manually.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public ReplicaMode ReplicaMode { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaMode property is set.
        /// </summary>
        internal bool IsSetReplicaMode() => this.ReplicaMode != null;

        /// <summary>
        /// Gets and sets the property SourceDBClusterIdentifier. 
        /// <para>
        /// The identifier of the Multi-AZ DB cluster that will act as the source for the read
        /// replica. Each DB cluster can have up to 15 read replicas.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be the identifier of an existing Multi-AZ DB cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be specified if the <c>SourceDBInstanceIdentifier</c> parameter is also specified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The specified DB cluster must have automatic backups enabled, that is, its backup
        /// retention period must be greater than 0.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The source DB cluster must be in the same Amazon Web Services Region as the read replica.
        /// Cross-Region replication isn't supported.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string SourceDBClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SourceDBClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetSourceDBClusterIdentifier() => this.SourceDBClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property SourceDBInstanceIdentifier. 
        /// <para>
        /// The identifier of the DB instance that will act as the source for the read replica.
        /// Each DB instance can have up to 15 read replicas, except for the following engines:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Db2 - Can have up to three replicas.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Oracle - Can have up to five read replicas.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SQL Server - Can have up to five read replicas.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be the identifier of an existing Db2, MariaDB, MySQL, Oracle, PostgreSQL, or
        /// SQL Server DB instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be specified if the <c>SourceDBClusterIdentifier</c> parameter is also specified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the limitations of Oracle read replicas, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/oracle-read-replicas.limitations.html#oracle-read-replicas.limitations.versions-and-licenses">Version
        /// and licensing considerations for RDS for Oracle replicas</a> in the <i>Amazon RDS
        /// User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the limitations of SQL Server read replicas, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/SQLServer.ReadReplicas.html#SQLServer.ReadReplicas.Limitations">Read
        /// replica limitations with SQL Server</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The specified DB instance must have automatic backups enabled, that is, its backup
        /// retention period must be greater than 0.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source DB instance is in the same Amazon Web Services Region as the read replica,
        /// specify a valid DB instance identifier.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source DB instance is in a different Amazon Web Services Region from the read
        /// replica, specify a valid DB instance ARN. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.ARN.html#USER_Tagging.ARN.Constructing">Constructing
        /// an ARN for Amazon RDS</a> in the <i>Amazon RDS User Guide</i>. This doesn't apply
        /// to SQL Server or RDS Custom, which don't support cross-Region replicas.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string SourceDBInstanceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SourceDBInstanceIdentifier property is set.
        /// </summary>
        internal bool IsSetSourceDBInstanceIdentifier() => this.SourceDBInstanceIdentifier != null;

        /// <summary>
        /// Gets and sets the property StorageThroughput. 
        /// <para>
        /// Specifies the storage throughput value for the read replica.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom or Amazon Aurora DB instances.
        /// </para>
        /// </summary>
        public int? StorageThroughput { get; set; }

        /// <summary>
        /// Checks to see if the StorageThroughput property is set.
        /// </summary>
        internal bool IsSetStorageThroughput() => this.StorageThroughput.HasValue;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The storage type to associate with the read replica.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>io1</c>, <c>io2</c>, or <c>gp3</c>, you must also include a value
        /// for the <c>Iops</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>gp2 | gp3 | io1 | io2 | standard</c> 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>io1</c> if the <c>Iops</c> parameter is specified. Otherwise, <c>gp3</c>.
        /// </para>
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// Tags to assign to resources associated with the DB instance.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>auto-backup</c> - The DB instance's automated backup.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpgradeStorageConfig. 
        /// <para>
        /// Whether to upgrade the storage file system configuration on the read replica. This
        /// option migrates the read replica from the old storage file system layout to the preferred
        /// layout.
        /// </para>
        /// </summary>
        public bool? UpgradeStorageConfig { get; set; }

        /// <summary>
        /// Checks to see if the UpgradeStorageConfig property is set.
        /// </summary>
        internal bool IsSetUpgradeStorageConfig() => this.UpgradeStorageConfig.HasValue;

        /// <summary>
        /// Gets and sets the property UseDefaultProcessorFeatures. 
        /// <para>
        /// Specifies whether the DB instance class of the DB instance uses its default processor
        /// features.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        /// </summary>
        public bool? UseDefaultProcessorFeatures { get; set; }

        /// <summary>
        /// Checks to see if the UseDefaultProcessorFeatures property is set.
        /// </summary>
        internal bool IsSetUseDefaultProcessorFeatures() => this.UseDefaultProcessorFeatures.HasValue;

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// A list of Amazon EC2 VPC security groups to associate with the read replica.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        ///  
        /// <para>
        /// Default: The default EC2 VPC security group for the DB subnet group's VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VpcSecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the VpcSecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetVpcSecurityGroupIds() => this.VpcSecurityGroupIds != null && (this.VpcSecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
