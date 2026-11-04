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
    /// Container for the parameters to the ModifyDBCluster operation. Modifies the settings
    /// of an Amazon Aurora DB cluster or a Multi-AZ DB cluster. You can change one or more
    /// settings by specifying these parameters and the new values in the request. <para>
    /// For more information on Amazon Aurora DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
    /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>. </para> <para>
    /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
    /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>. </para>
    /// </summary>
    public partial class ModifyDBClusterRequest : AmazonRDSRequest
    {
        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The amount of storage in gibibytes (GiB) to allocate to each DB instance in the Multi-AZ
        /// DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Multi-AZ DB clusters only
        /// </para>
        /// </summary>
        public int? AllocatedStorage { get; set; }

        /// <summary>
        /// Checks to see if the AllocatedStorage property is set.
        /// </summary>
        internal bool IsSetAllocatedStorage() => this.AllocatedStorage.HasValue;

        /// <summary>
        /// Gets and sets the property AllowEngineModeChange. 
        /// <para>
        /// Specifies whether engine mode changes from <c>serverless</c> to <c>provisioned</c>
        /// are allowed.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora Serverless v1 DB clusters only
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must allow engine mode changes when specifying a different value for the <c>EngineMode</c>
        /// parameter from the DB cluster's current engine mode.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? AllowEngineModeChange { get; set; }

        /// <summary>
        /// Checks to see if the AllowEngineModeChange property is set.
        /// </summary>
        internal bool IsSetAllowEngineModeChange() => this.AllowEngineModeChange.HasValue;

        /// <summary>
        /// Gets and sets the property AllowMajorVersionUpgrade. 
        /// <para>
        /// Specifies whether major version upgrades are allowed.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must allow major version upgrades when specifying a value for the <c>EngineVersion</c>
        /// parameter that is a different major version than the DB cluster's current version.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? AllowMajorVersionUpgrade { get; set; }

        /// <summary>
        /// Checks to see if the AllowMajorVersionUpgrade property is set.
        /// </summary>
        internal bool IsSetAllowMajorVersionUpgrade() => this.AllowMajorVersionUpgrade.HasValue;

        /// <summary>
        /// Gets and sets the property ApplyImmediately. 
        /// <para>
        /// Specifies whether the modifications in this request are asynchronously applied as
        /// soon as possible, regardless of the <c>PreferredMaintenanceWindow</c> setting for
        /// the DB cluster. If this parameter is disabled, changes to the DB cluster are applied
        /// during the next maintenance window.
        /// </para>
        ///  
        /// <para>
        /// Most modifications can be applied immediately or during the next scheduled maintenance
        /// window. Some modifications, such as turning on deletion protection and changing the
        /// master password, are applied immediately—regardless of when you choose to apply them.
        /// </para>
        ///  
        /// <para>
        /// By default, this parameter is disabled.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        /// </summary>
        public bool? ApplyImmediately { get; set; }

        /// <summary>
        /// Checks to see if the ApplyImmediately property is set.
        /// </summary>
        internal bool IsSetApplyImmediately() => this.ApplyImmediately.HasValue;

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        /// Specifies whether minor engine upgrades are applied automatically to the DB cluster
        /// during the maintenance window. By default, minor engine upgrades are applied automatically.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters.
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
        /// Gets and sets the property AwsBackupRecoveryPointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recovery point in Amazon Web Services Backup.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 43, Max = 350)]
        public string AwsBackupRecoveryPointArn { get; set; }

        /// <summary>
        /// Checks to see if the AwsBackupRecoveryPointArn property is set.
        /// </summary>
        internal bool IsSetAwsBackupRecoveryPointArn() => this.AwsBackupRecoveryPointArn != null;

        /// <summary>
        /// Gets and sets the property BacktrackWindow. 
        /// <para>
        /// The target backtrack window, in seconds. To disable backtracking, set this value to
        /// <c>0</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora MySQL DB clusters only
        /// </para>
        ///  
        /// <para>
        /// Default: <c>0</c> 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If specified, this value must be set to a number from 0 to 259,200 (72 hours).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public long? BacktrackWindow { get; set; }

        /// <summary>
        /// Checks to see if the BacktrackWindow property is set.
        /// </summary>
        internal bool IsSetBacktrackWindow() => this.BacktrackWindow.HasValue;

        /// <summary>
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        /// The number of days for which automated backups are retained. Specify a minimum value
        /// of <c>1</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        ///  
        /// <para>
        /// Default: <c>1</c> 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be a value from 1 to 35.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the BackupRetentionPeriod property is set.
        /// </summary>
        internal bool IsSetBackupRetentionPeriod() => this.BackupRetentionPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property CACertificateIdentifier. 
        /// <para>
        /// The CA certificate identifier to use for the DB cluster's server certificate.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.SSL.html">Using
        /// SSL/TLS to encrypt a connection to a DB instance</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Multi-AZ DB clusters
        /// </para>
        /// </summary>
        public string CACertificateIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CACertificateIdentifier property is set.
        /// </summary>
        internal bool IsSetCACertificateIdentifier() => this.CACertificateIdentifier != null;

        /// <summary>
        /// Gets and sets the property CloudwatchLogsExportConfiguration. 
        /// <para>
        /// The configuration setting for the log types to be enabled for export to CloudWatch
        /// Logs for a specific DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        ///  
        /// <para>
        /// The following values are valid for each DB engine:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Aurora MySQL - <c>audit | error | general | instance | slowquery | iam-db-auth-error</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Aurora PostgreSQL - <c>instance | postgresql | iam-db-auth-error</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for MySQL - <c>error | general | slowquery | iam-db-auth-error</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for PostgreSQL - <c>postgresql | upgrade | iam-db-auth-error</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about exporting CloudWatch Logs for Amazon RDS, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_LogAccess.html#USER_LogAccess.Procedural.UploadtoCloudWatch">
        /// Publishing Database Logs to Amazon CloudWatch Logs</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about exporting CloudWatch Logs for Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_LogAccess.html#USER_LogAccess.Procedural.UploadtoCloudWatch">Publishing
        /// Database Logs to Amazon CloudWatch Logs</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        public CloudwatchLogsExportConfiguration CloudwatchLogsExportConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CloudwatchLogsExportConfiguration property is set.
        /// </summary>
        internal bool IsSetCloudwatchLogsExportConfiguration() => this.CloudwatchLogsExportConfiguration != null;

        /// <summary>
        /// Gets and sets the property CopyTagsToSnapshot. 
        /// <para>
        /// Specifies whether to copy all tags from the DB cluster to snapshots of the DB cluster.
        /// The default is not to copy them.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        /// </summary>
        public bool? CopyTagsToSnapshot { get; set; }

        /// <summary>
        /// Checks to see if the CopyTagsToSnapshot property is set.
        /// </summary>
        internal bool IsSetCopyTagsToSnapshot() => this.CopyTagsToSnapshot.HasValue;

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The DB cluster identifier for the cluster being modified. This parameter isn't case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing DB cluster.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DBClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetDBClusterIdentifier() => this.DBClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property DBClusterInstanceClass. 
        /// <para>
        /// The compute and memory capacity of each DB instance in the Multi-AZ DB cluster, for
        /// example <c>db.m6gd.xlarge</c>. Not all DB instance classes are available in all Amazon
        /// Web Services Regions, or for all database engines.
        /// </para>
        ///  
        /// <para>
        /// For the full list of DB instance classes and availability for your engine, see <a
        /// href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.DBInstanceClass.html">
        /// DB Instance Class</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Multi-AZ DB clusters only
        /// </para>
        /// </summary>
        public string DBClusterInstanceClass { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterInstanceClass property is set.
        /// </summary>
        internal bool IsSetDBClusterInstanceClass() => this.DBClusterInstanceClass != null;

        /// <summary>
        /// Gets and sets the property DBClusterParameterGroupName. 
        /// <para>
        /// The name of the DB cluster parameter group to use for the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        /// </summary>
        public string DBClusterParameterGroupName { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterParameterGroupName property is set.
        /// </summary>
        internal bool IsSetDBClusterParameterGroupName() => this.DBClusterParameterGroupName != null;

        /// <summary>
        /// Gets and sets the property DBInstanceParameterGroupName. 
        /// <para>
        /// The name of the DB parameter group to apply to all instances of the DB cluster.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you apply a parameter group using the <c>DBInstanceParameterGroupName</c> parameter,
        /// the DB cluster isn't rebooted automatically. Also, parameter changes are applied immediately
        /// rather than during the next maintenance window.
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters only
        /// </para>
        ///  
        /// <para>
        /// Default: The existing name setting
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The DB parameter group must be in the same DB parameter group family as this DB cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DBInstanceParameterGroupName</c> parameter is valid in combination with the
        /// <c>AllowMajorVersionUpgrade</c> parameter for a major version upgrade only.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DBInstanceParameterGroupName { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceParameterGroupName property is set.
        /// </summary>
        internal bool IsSetDBInstanceParameterGroupName() => this.DBInstanceParameterGroupName != null;

        /// <summary>
        /// Gets and sets the property DatabaseInsightsMode. 
        /// <para>
        /// Specifies the mode of Database Insights to enable for the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// If you change the value from <c>standard</c> to <c>advanced</c>, you must set the
        /// <c>PerformanceInsightsEnabled</c> parameter to <c>true</c> and the <c>PerformanceInsightsRetentionPeriod</c>
        /// parameter to 465.
        /// </para>
        ///  
        /// <para>
        /// If you change the value from <c>advanced</c> to <c>standard</c>, you can set the <c>PerformanceInsightsEnabled</c>
        /// parameter to <c>true</c> to collect detailed database counter and per-query metrics.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        /// </summary>
        public DatabaseInsightsMode DatabaseInsightsMode { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseInsightsMode property is set.
        /// </summary>
        internal bool IsSetDatabaseInsightsMode() => this.DatabaseInsightsMode != null;

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Specifies whether the DB cluster has deletion protection enabled. The database can't
        /// be deleted when deletion protection is enabled. By default, deletion protection isn't
        /// enabled.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
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
        /// The Active Directory directory ID to move the DB cluster to. Specify <c>none</c> to
        /// remove the cluster from its current domain. The domain must be created prior to this
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/kerberos-authentication.html">Kerberos
        /// Authentication</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters only
        /// </para>
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property DomainIAMRoleName. 
        /// <para>
        /// The name of the IAM role to use when making API calls to the Directory Service.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters only
        /// </para>
        /// </summary>
        public string DomainIAMRoleName { get; set; }

        /// <summary>
        /// Checks to see if the DomainIAMRoleName property is set.
        /// </summary>
        internal bool IsSetDomainIAMRoleName() => this.DomainIAMRoleName != null;

        /// <summary>
        /// Gets and sets the property EnableGlobalWriteForwarding. 
        /// <para>
        /// Specifies whether to enable this DB cluster to forward write operations to the primary
        /// cluster of a global cluster (Aurora global database). By default, write operations
        /// are not allowed on Aurora DB clusters that are secondary clusters in an Aurora global
        /// database.
        /// </para>
        ///  
        /// <para>
        /// You can set this value only on Aurora DB clusters that are members of an Aurora global
        /// database. With this parameter enabled, a secondary cluster can forward writes to the
        /// current primary cluster, and the resulting changes are replicated back to this cluster.
        /// For the primary DB cluster of an Aurora global database, this value is used immediately
        /// if the primary is demoted by a global cluster API operation, but it does nothing until
        /// then.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters only
        /// </para>
        /// </summary>
        public bool? EnableGlobalWriteForwarding { get; set; }

        /// <summary>
        /// Checks to see if the EnableGlobalWriteForwarding property is set.
        /// </summary>
        internal bool IsSetEnableGlobalWriteForwarding() => this.EnableGlobalWriteForwarding.HasValue;

        /// <summary>
        /// Gets and sets the property EnableHttpEndpoint. 
        /// <para>
        /// Specifies whether to enable the HTTP endpoint for an Aurora Serverless v1 DB cluster.
        /// By default, the HTTP endpoint isn't enabled.
        /// </para>
        ///  
        /// <para>
        /// When enabled, the HTTP endpoint provides a connectionless web service API (RDS Data
        /// API) for running SQL queries on the Aurora Serverless v1 DB cluster. You can also
        /// query your database from inside the RDS console with the RDS query editor.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/data-api.html">Using
        /// RDS Data API</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter applies only to Aurora Serverless v1 DB clusters. To enable or disable
        /// the HTTP endpoint for an Aurora Serverless v2 or provisioned DB cluster, use the <c>EnableHttpEndpoint</c>
        /// and <c>DisableHttpEndpoint</c> operations.
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters only
        /// </para>
        /// </summary>
        public bool? EnableHttpEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the EnableHttpEndpoint property is set.
        /// </summary>
        internal bool IsSetEnableHttpEndpoint() => this.EnableHttpEndpoint.HasValue;

        /// <summary>
        /// Gets and sets the property EnableIAMDatabaseAuthentication. 
        /// <para>
        /// Specifies whether to enable mapping of Amazon Web Services Identity and Access Management
        /// (IAM) accounts to database accounts. By default, mapping isn't enabled.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/UsingWithRDS.IAMDBAuth.html">
        /// IAM Database Authentication</a> in the <i>Amazon Aurora User Guide</i> or <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.IAMDBAuth.html">IAM
        /// database authentication for MariaDB, MySQL, and PostgreSQL</a> in the <i>Amazon RDS
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        /// </summary>
        public bool? EnableIAMDatabaseAuthentication { get; set; }

        /// <summary>
        /// Checks to see if the EnableIAMDatabaseAuthentication property is set.
        /// </summary>
        internal bool IsSetEnableIAMDatabaseAuthentication() => this.EnableIAMDatabaseAuthentication.HasValue;

        /// <summary>
        /// Gets and sets the property EnableLimitlessDatabase. 
        /// <para>
        /// Specifies whether to enable Aurora Limitless Database. You must enable Aurora Limitless
        /// Database to create a DB shard group.
        /// </para>
        ///  
        /// <para>
        /// Valid for: Aurora DB clusters only
        /// </para>
        ///  <note> 
        /// <para>
        /// This setting is no longer used. Instead use the <c>ClusterScalabilityType</c> setting
        /// when you create your Aurora Limitless Database DB cluster.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? EnableLimitlessDatabase { get; set; }

        /// <summary>
        /// Checks to see if the EnableLimitlessDatabase property is set.
        /// </summary>
        internal bool IsSetEnableLimitlessDatabase() => this.EnableLimitlessDatabase.HasValue;

        /// <summary>
        /// Gets and sets the property EnableLocalWriteForwarding. 
        /// <para>
        /// Specifies whether read replicas can forward write operations to the writer DB instance
        /// in the DB cluster. By default, write operations aren't allowed on reader DB instances.
        /// </para>
        ///  
        /// <para>
        /// Valid for: Aurora DB clusters only
        /// </para>
        /// </summary>
        public bool? EnableLocalWriteForwarding { get; set; }

        /// <summary>
        /// Checks to see if the EnableLocalWriteForwarding property is set.
        /// </summary>
        internal bool IsSetEnableLocalWriteForwarding() => this.EnableLocalWriteForwarding.HasValue;

        /// <summary>
        /// Gets and sets the property EnablePerformanceInsights. 
        /// <para>
        /// Specifies whether to turn on Performance Insights for the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PerfInsights.html">
        /// Using Amazon Performance Insights</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        /// </summary>
        public bool? EnablePerformanceInsights { get; set; }

        /// <summary>
        /// Checks to see if the EnablePerformanceInsights property is set.
        /// </summary>
        internal bool IsSetEnablePerformanceInsights() => this.EnablePerformanceInsights.HasValue;

        /// <summary>
        /// Gets and sets the property EngineLifecycleSupport. 
        /// <para>
        /// The lifecycle type for this DB cluster.
        /// </para>
        ///  
        /// <para>
        /// You can use this setting to enroll your DB cluster into Amazon RDS Extended Support
        /// or to opt out. With RDS Extended Support, you can run the selected major engine version
        /// on your DB cluster past the end of standard support for that engine version. For more
        /// information, see the following sections:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Aurora - <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/extended-support.html">Amazon
        /// RDS Extended Support with Amazon Aurora</a> in the <i>Amazon Aurora User Guide</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon RDS - <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/extended-support.html">Amazon
        /// RDS Extended Support with Amazon RDS</a> in the <i>Amazon RDS User Guide</i> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>open-source-rds-extended-support | open-source-rds-extended-support-disabled</c>
        /// 
        /// </para>
        /// </summary>
        public string EngineLifecycleSupport { get; set; }

        /// <summary>
        /// Checks to see if the EngineLifecycleSupport property is set.
        /// </summary>
        internal bool IsSetEngineLifecycleSupport() => this.EngineLifecycleSupport != null;

        /// <summary>
        /// Gets and sets the property EngineMode. 
        /// <para>
        /// The DB engine mode of the DB cluster, either <c>provisioned</c> or <c>serverless</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The DB engine mode can be modified only from <c>serverless</c> to <c>provisioned</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_CreateDBCluster.html">
        /// CreateDBCluster</a>.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters only
        /// </para>
        /// </summary>
        public string EngineMode { get; set; }

        /// <summary>
        /// Checks to see if the EngineMode property is set.
        /// </summary>
        internal bool IsSetEngineMode() => this.EngineMode != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version number of the database engine to which you want to upgrade. Changing this
        /// parameter results in an outage. The change is applied during the next maintenance
        /// window unless <c>ApplyImmediately</c> is enabled.
        /// </para>
        ///  
        /// <para>
        /// If the cluster that you're modifying has one or more read replicas, all replicas must
        /// be running an engine version that's the same or later than the version you specify.
        /// </para>
        ///  
        /// <para>
        /// To list all of the available engine versions for Aurora MySQL, use the following command:
        /// </para>
        ///  
        /// <para>
        ///  <c>aws rds describe-db-engine-versions --engine aurora-mysql --query "DBEngineVersions[].EngineVersion"</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// To list all of the available engine versions for Aurora PostgreSQL, use the following
        /// command:
        /// </para>
        ///  
        /// <para>
        ///  <c>aws rds describe-db-engine-versions --engine aurora-postgresql --query "DBEngineVersions[].EngineVersion"</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// To list all of the available engine versions for RDS for MySQL, use the following
        /// command:
        /// </para>
        ///  
        /// <para>
        ///  <c>aws rds describe-db-engine-versions --engine mysql --query "DBEngineVersions[].EngineVersion"</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// To list all of the available engine versions for RDS for PostgreSQL, use the following
        /// command:
        /// </para>
        ///  
        /// <para>
        ///  <c>aws rds describe-db-engine-versions --engine postgres --query "DBEngineVersions[].EngineVersion"</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The amount of Provisioned IOPS (input/output operations per second) to be initially
        /// allocated for each DB instance in the Multi-AZ DB cluster.
        /// </para>
        ///  
        /// <para>
        /// For information about valid IOPS values, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Storage.html#USER_PIOPS">Amazon
        /// RDS Provisioned IOPS storage</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Multi-AZ DB clusters only
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be a multiple between .5 and 50 of the storage amount for the DB cluster.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public int? Iops { get; set; }

        /// <summary>
        /// Checks to see if the Iops property is set.
        /// </summary>
        internal bool IsSetIops() => this.Iops.HasValue;

        /// <summary>
        /// Gets and sets the property ManageMasterUserPassword. 
        /// <para>
        /// Specifies whether to manage the master user password with Amazon Web Services Secrets
        /// Manager.
        /// </para>
        ///  
        /// <para>
        /// If the DB cluster doesn't manage the master user password with Amazon Web Services
        /// Secrets Manager, you can turn on this management. In this case, you can't specify
        /// <c>MasterUserPassword</c>.
        /// </para>
        ///  
        /// <para>
        /// If the DB cluster already manages the master user password with Amazon Web Services
        /// Secrets Manager, and you specify that the master user password is not managed with
        /// Amazon Web Services Secrets Manager, then you must specify <c>MasterUserPassword</c>.
        /// In this case, RDS deletes the secret and uses the new password for the master user
        /// specified by <c>MasterUserPassword</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/rds-secrets-manager.html">Password
        /// management with Amazon Web Services Secrets Manager</a> in the <i>Amazon RDS User
        /// Guide</i> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/rds-secrets-manager.html">Password
        /// management with Amazon Web Services Secrets Manager</a> in the <i>Amazon Aurora User
        /// Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        /// </summary>
        public bool? ManageMasterUserPassword { get; set; }

        /// <summary>
        /// Checks to see if the ManageMasterUserPassword property is set.
        /// </summary>
        internal bool IsSetManageMasterUserPassword() => this.ManageMasterUserPassword.HasValue;

        /// <summary>
        /// Gets and sets the property MasterUserAuthenticationType. 
        /// <para>
        /// Specifies the authentication type for the master user. With IAM master user authentication,
        /// you can change the master DB user to use IAM database authentication.
        /// </para>
        ///  
        /// <para>
        /// You can specify one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>password</c> - Use standard database authentication with a password.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>iam-db-auth</c> - Use IAM database authentication for the master user.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        ///  
        /// <para>
        /// This option is only valid for RDS for PostgreSQL and Aurora PostgreSQL engines.
        /// </para>
        /// </summary>
        public MasterUserAuthenticationType MasterUserAuthenticationType { get; set; }

        /// <summary>
        /// Checks to see if the MasterUserAuthenticationType property is set.
        /// </summary>
        internal bool IsSetMasterUserAuthenticationType() => this.MasterUserAuthenticationType != null;

        /// <summary>
        /// Gets and sets the property MasterUserPassword. 
        /// <para>
        /// The new password for the master database user.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain from 8 to 41 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can contain any printable ASCII character except "/", """, or "@".
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be specified if <c>ManageMasterUserPassword</c> is turned on.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string MasterUserPassword { get; set; }

        /// <summary>
        /// Checks to see if the MasterUserPassword property is set.
        /// </summary>
        internal bool IsSetMasterUserPassword() => this.MasterUserPassword != null;

        /// <summary>
        /// Gets and sets the property MasterUserSecretKmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key identifier to encrypt a secret that is automatically
        /// generated and managed in Amazon Web Services Secrets Manager.
        /// </para>
        ///  
        /// <para>
        /// This setting is valid only if both of the following conditions are met:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The DB cluster doesn't manage the master user password in Amazon Web Services Secrets
        /// Manager.
        /// </para>
        ///  
        /// <para>
        /// If the DB cluster already manages the master user password in Amazon Web Services
        /// Secrets Manager, you can't change the KMS key that is used to encrypt the secret.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You are turning on <c>ManageMasterUserPassword</c> to manage the master user password
        /// in Amazon Web Services Secrets Manager.
        /// </para>
        ///  
        /// <para>
        /// If you are turning on <c>ManageMasterUserPassword</c> and don't specify <c>MasterUserSecretKmsKeyId</c>,
        /// then the <c>aws/secretsmanager</c> KMS key is used to encrypt the secret. If the secret
        /// is in a different Amazon Web Services account, then you can't use the <c>aws/secretsmanager</c>
        /// KMS key to encrypt the secret, and you must use a customer managed KMS key.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The Amazon Web Services KMS key identifier is the key ARN, key ID, alias ARN, or alias
        /// name for the KMS key. To use a KMS key in a different Amazon Web Services account,
        /// specify the key ARN or alias ARN.
        /// </para>
        ///  
        /// <para>
        /// There is a default KMS key for your Amazon Web Services account. Your Amazon Web Services
        /// account has a different default KMS key for each Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        /// </summary>
        public string MasterUserSecretKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the MasterUserSecretKmsKeyId property is set.
        /// </summary>
        internal bool IsSetMasterUserSecretKmsKeyId() => this.MasterUserSecretKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property MonitoringInterval. 
        /// <para>
        /// The interval, in seconds, between points when Enhanced Monitoring metrics are collected
        /// for the DB cluster. To turn off collecting Enhanced Monitoring metrics, specify <c>0</c>.
        /// </para>
        ///  
        /// <para>
        /// If <c>MonitoringRoleArn</c> is specified, also set <c>MonitoringInterval</c> to a
        /// value other than <c>0</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Multi-AZ DB clusters only
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>0 | 1 | 5 | 10 | 15 | 30 | 60</c> 
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
        /// The Amazon Resource Name (ARN) for the IAM role that permits RDS to send Enhanced
        /// Monitoring metrics to Amazon CloudWatch Logs. An example is <c>arn:aws:iam:123456789012:role/emaccess</c>.
        /// For information on creating a monitoring role, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Monitoring.html#USER_Monitoring.OS.IAMRole">To
        /// create an IAM role for Amazon RDS Enhanced Monitoring</a> in the <i>Amazon RDS User
        /// Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// If <c>MonitoringInterval</c> is set to a value other than <c>0</c>, supply a <c>MonitoringRoleArn</c>
        /// value.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Multi-AZ DB clusters only
        /// </para>
        /// </summary>
        public string MonitoringRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringRoleArn property is set.
        /// </summary>
        internal bool IsSetMonitoringRoleArn() => this.MonitoringRoleArn != null;

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The network type of the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// The network type is determined by the <c>DBSubnetGroup</c> specified for the DB cluster.
        /// A <c>DBSubnetGroup</c> can support only the IPv4 protocol or the IPv4 and the IPv6
        /// protocols (<c>DUAL</c>).
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_VPC.WorkingWithRDSInstanceinaVPC.html">
        /// Working with a DB instance in a VPC</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters only
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>IPV4 | DUAL</c> 
        /// </para>
        /// </summary>
        public string NetworkType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkType property is set.
        /// </summary>
        internal bool IsSetNetworkType() => this.NetworkType != null;

        /// <summary>
        /// Gets and sets the property NewDBClusterIdentifier. 
        /// <para>
        /// The new DB cluster identifier for the DB cluster when renaming a DB cluster. This
        /// value is stored as a lowercase string.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain from 1 to 63 letters, numbers, or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The first character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>my-cluster2</c> 
        /// </para>
        /// </summary>
        public string NewDBClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the NewDBClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetNewDBClusterIdentifier() => this.NewDBClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property OptionGroupName. 
        /// <para>
        /// The option group to associate the DB cluster with.
        /// </para>
        ///  
        /// <para>
        /// DB clusters are associated with a default option group that can't be modified.
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
        /// If you don't specify a value for <c>PerformanceInsightsKMSKeyId</c>, then Amazon RDS
        /// uses your default KMS key. There is a default KMS key for your Amazon Web Services
        /// account. Your Amazon Web Services account has a different default KMS key for each
        /// Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
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
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
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
        /// issues an error.
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
        /// The port number on which the DB cluster accepts connections.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters only
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>1150-65535</c> 
        /// </para>
        ///  
        /// <para>
        /// Default: The same port as the original DB cluster.
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
        /// The daily time range during which automated backups are created if automated backups
        /// are enabled, using the <c>BackupRetentionPeriod</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// The default is a 30-minute window selected at random from an 8-hour block of time
        /// for each Amazon Web Services Region. To view the time blocks available, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/Aurora.Managing.Backups.html#Aurora.Managing.Backups.BackupWindow">
        /// Backup window</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be in the format <c>hh24:mi-hh24:mi</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be in Universal Coordinated Time (UTC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must not conflict with the preferred maintenance window.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be at least 30 minutes.
        /// </para>
        ///  </li> </ul>
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
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        ///  
        /// <para>
        /// The default is a 30-minute window selected at random from an 8-hour block of time
        /// for each Amazon Web Services Region, occurring on a random day of the week. To see
        /// the time blocks available, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_UpgradeDBInstance.Maintenance.html#AdjustingTheMaintenanceWindow.Aurora">
        /// Adjusting the Preferred DB Cluster Maintenance Window</a> in the <i>Amazon Aurora
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be in the format <c>ddd:hh24:mi-ddd:hh24:mi</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Days must be one of <c>Mon | Tue | Wed | Thu | Fri | Sat | Sun</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be in Universal Coordinated Time (UTC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be at least 30 minutes.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string PreferredMaintenanceWindow { get; set; }

        /// <summary>
        /// Checks to see if the PreferredMaintenanceWindow property is set.
        /// </summary>
        internal bool IsSetPreferredMaintenanceWindow() => this.PreferredMaintenanceWindow != null;

        /// <summary>
        /// Gets and sets the property RotateMasterUserPassword. 
        /// <para>
        /// Specifies whether to rotate the secret managed by Amazon Web Services Secrets Manager
        /// for the master user password.
        /// </para>
        ///  
        /// <para>
        /// This setting is valid only if the master user password is managed by RDS in Amazon
        /// Web Services Secrets Manager for the DB cluster. The secret value contains the updated
        /// password.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/rds-secrets-manager.html">Password
        /// management with Amazon Web Services Secrets Manager</a> in the <i>Amazon RDS User
        /// Guide</i> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/rds-secrets-manager.html">Password
        /// management with Amazon Web Services Secrets Manager</a> in the <i>Amazon Aurora User
        /// Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must apply the change immediately when rotating the master user password.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? RotateMasterUserPassword { get; set; }

        /// <summary>
        /// Checks to see if the RotateMasterUserPassword property is set.
        /// </summary>
        internal bool IsSetRotateMasterUserPassword() => this.RotateMasterUserPassword.HasValue;

        /// <summary>
        /// Gets and sets the property ScalingConfiguration. 
        /// <para>
        /// The scaling properties of the DB cluster. You can only modify scaling properties for
        /// DB clusters in <c>serverless</c> DB engine mode.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters only
        /// </para>
        /// </summary>
        public ScalingConfiguration ScalingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ScalingConfiguration property is set.
        /// </summary>
        internal bool IsSetScalingConfiguration() => this.ScalingConfiguration != null;

        /// <summary>
        /// Gets and sets the property ServerlessV2ScalingConfiguration.
        /// </summary>
        public ServerlessV2ScalingConfiguration ServerlessV2ScalingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessV2ScalingConfiguration property is set.
        /// </summary>
        internal bool IsSetServerlessV2ScalingConfiguration() => this.ServerlessV2ScalingConfiguration != null;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The storage type to associate with the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// For information on storage types for Aurora DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/Aurora.Overview.StorageReliability.html#aurora-storage-type">Storage
        /// configurations for Amazon Aurora DB clusters</a>. For information on storage types
        /// for Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/create-multi-az-db-cluster.html#create-multi-az-db-cluster-settings">Settings
        /// for creating Multi-AZ DB clusters</a>.
        /// </para>
        ///  
        /// <para>
        /// When specified for a Multi-AZ DB cluster, a value for the <c>Iops</c> parameter is
        /// required.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Aurora DB clusters - <c>aurora | aurora-iopt1</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Multi-AZ DB clusters - <c>io1 | io2 | gp3</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Aurora DB clusters - <c>aurora</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Multi-AZ DB clusters - <c>io1</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// A list of EC2 VPC security groups to associate with this DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
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
