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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreDBClusterToPointInTime operation.
    /// Restores a DB cluster to an arbitrary point in time. Users can restore to any point
    /// in time before <code>LatestRestorableTime</code> for up to <code>BackupRetentionPeriod</code>
    /// days. The target DB cluster is created from the source DB cluster with the same configuration
    /// as the original DB cluster, except that the new DB cluster is created with the default
    /// DB security group. 
    /// 
    ///  <note> 
    /// <para>
    /// This action only restores the DB cluster, not the DB instances for that DB cluster.
    /// You must invoke the <code>CreateDBInstance</code> action to create DB instances for
    /// the restored DB cluster, specifying the identifier of the restored DB cluster in <code>DBClusterIdentifier</code>.
    /// You can create DB instances only after the <code>RestoreDBClusterToPointInTime</code>
    /// action has completed and the DB cluster is available.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
    /// What Is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i> 
    /// </para>
    ///  <note> 
    /// <para>
    /// This action only applies to Aurora DB clusters.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class RestoreDBClusterToPointInTimeRequest : AmazonRDSRequest
    {
        private long? _backtrackWindow;
        private bool? _copyTagsToSnapshot;
        private string _dbClusterIdentifier;
        private string _dbClusterParameterGroupName;
        private string _dbSubnetGroupName;
        private bool? _deletionProtection;
        private string _domain;
        private string _domainIAMRoleName;
        private List<string> _enableCloudwatchLogsExports = new List<string>();
        private bool? _enableIAMDatabaseAuthentication;
        private string _kmsKeyId;
        private string _optionGroupName;
        private int? _port;
        private DateTime? _restoreToTimeUtc;
        private string _restoreType;
        private string _sourceDBClusterIdentifier;
        private List<Tag> _tags = new List<Tag>();
        private bool? _useLatestRestorableTime;
        private List<string> _vpcSecurityGroupIds = new List<string>();

        /// <summary>
        /// Gets and sets the property BacktrackWindow. 
        /// <para>
        /// The target backtrack window, in seconds. To disable backtracking, set this value to
        /// 0.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently, Backtrack is only supported for Aurora MySQL DB clusters.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: 0
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
        public long BacktrackWindow
        {
            get { return this._backtrackWindow.GetValueOrDefault(); }
            set { this._backtrackWindow = value; }
        }

        // Check to see if BacktrackWindow property is set
        internal bool IsSetBacktrackWindow()
        {
            return this._backtrackWindow.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CopyTagsToSnapshot. 
        /// <para>
        /// A value that indicates whether to copy all tags from the restored DB cluster to snapshots
        /// of the restored DB cluster. The default is not to copy them.
        /// </para>
        /// </summary>
        public bool CopyTagsToSnapshot
        {
            get { return this._copyTagsToSnapshot.GetValueOrDefault(); }
            set { this._copyTagsToSnapshot = value; }
        }

        // Check to see if CopyTagsToSnapshot property is set
        internal bool IsSetCopyTagsToSnapshot()
        {
            return this._copyTagsToSnapshot.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The name of the new DB cluster to be created.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain from 1 to 63 letters, numbers, or hyphens
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't end with a hyphen or contain two consecutive hyphens
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBClusterIdentifier
        {
            get { return this._dbClusterIdentifier; }
            set { this._dbClusterIdentifier = value; }
        }

        // Check to see if DBClusterIdentifier property is set
        internal bool IsSetDBClusterIdentifier()
        {
            return this._dbClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DBClusterParameterGroupName. 
        /// <para>
        /// The name of the DB cluster parameter group to associate with this DB cluster. If this
        /// argument is omitted, the default DB cluster parameter group for the specified engine
        /// is used.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If supplied, must match the name of an existing DB cluster parameter group.
        /// </para>
        ///  </li> <li> 
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
        public string DBClusterParameterGroupName
        {
            get { return this._dbClusterParameterGroupName; }
            set { this._dbClusterParameterGroupName = value; }
        }

        // Check to see if DBClusterParameterGroupName property is set
        internal bool IsSetDBClusterParameterGroupName()
        {
            return this._dbClusterParameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property DBSubnetGroupName. 
        /// <para>
        /// The DB subnet group name to use for the new DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Constraints: If supplied, must match the name of an existing DBSubnetGroup.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>mySubnetgroup</code> 
        /// </para>
        /// </summary>
        public string DBSubnetGroupName
        {
            get { return this._dbSubnetGroupName; }
            set { this._dbSubnetGroupName = value; }
        }

        // Check to see if DBSubnetGroupName property is set
        internal bool IsSetDBSubnetGroupName()
        {
            return this._dbSubnetGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// A value that indicates whether the DB cluster has deletion protection enabled. The
        /// database can't be deleted when deletion protection is enabled. By default, deletion
        /// protection is disabled. 
        /// </para>
        /// </summary>
        public bool DeletionProtection
        {
            get { return this._deletionProtection.GetValueOrDefault(); }
            set { this._deletionProtection = value; }
        }

        // Check to see if DeletionProtection property is set
        internal bool IsSetDeletionProtection()
        {
            return this._deletionProtection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// Specify the Active Directory directory ID to restore the DB cluster in. The domain
        /// must be created prior to this operation. 
        /// </para>
        ///  
        /// <para>
        ///  For Amazon Aurora DB clusters, Amazon RDS can use Kerberos Authentication to authenticate
        /// users that connect to the DB cluster. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/kerberos-authentication.html">Kerberos
        /// Authentication</a> in the <i>Amazon Aurora User Guide</i>. 
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property DomainIAMRoleName. 
        /// <para>
        /// Specify the name of the IAM role to be used when making API calls to the Directory
        /// Service.
        /// </para>
        /// </summary>
        public string DomainIAMRoleName
        {
            get { return this._domainIAMRoleName; }
            set { this._domainIAMRoleName = value; }
        }

        // Check to see if DomainIAMRoleName property is set
        internal bool IsSetDomainIAMRoleName()
        {
            return this._domainIAMRoleName != null;
        }

        /// <summary>
        /// Gets and sets the property EnableCloudwatchLogsExports. 
        /// <para>
        /// The list of logs that the restored DB cluster is to export to CloudWatch Logs. The
        /// values in the list depend on the DB engine being used. For more information, see <a
        /// href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_LogAccess.html#USER_LogAccess.Procedural.UploadtoCloudWatch">Publishing
        /// Database Logs to Amazon CloudWatch Logs</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        public List<string> EnableCloudwatchLogsExports
        {
            get { return this._enableCloudwatchLogsExports; }
            set { this._enableCloudwatchLogsExports = value; }
        }

        // Check to see if EnableCloudwatchLogsExports property is set
        internal bool IsSetEnableCloudwatchLogsExports()
        {
            return this._enableCloudwatchLogsExports != null && this._enableCloudwatchLogsExports.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EnableIAMDatabaseAuthentication. 
        /// <para>
        /// A value that indicates whether to enable mapping of AWS Identity and Access Management
        /// (IAM) accounts to database accounts. By default, mapping is disabled.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/UsingWithRDS.IAMDBAuth.html">
        /// IAM Database Authentication</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
        /// </summary>
        public bool EnableIAMDatabaseAuthentication
        {
            get { return this._enableIAMDatabaseAuthentication.GetValueOrDefault(); }
            set { this._enableIAMDatabaseAuthentication = value; }
        }

        // Check to see if EnableIAMDatabaseAuthentication property is set
        internal bool IsSetEnableIAMDatabaseAuthentication()
        {
            return this._enableIAMDatabaseAuthentication.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The AWS KMS key identifier to use when restoring an encrypted DB cluster from an encrypted
        /// DB cluster.
        /// </para>
        ///  
        /// <para>
        /// The AWS KMS key identifier is the key ARN, key ID, alias ARN, or alias name for the
        /// AWS KMS customer master key (CMK). To use a CMK in a different AWS account, specify
        /// the key ARN or alias ARN.
        /// </para>
        ///  
        /// <para>
        /// You can restore to a new DB cluster and encrypt the new DB cluster with a AWS KMS
        /// CMK that is different than the AWS KMS key used to encrypt the source DB cluster.
        /// The new DB cluster is encrypted with the AWS KMS CMK identified by the <code>KmsKeyId</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for the <code>KmsKeyId</code> parameter, then the following
        /// occurs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the DB cluster is encrypted, then the restored DB cluster is encrypted using the
        /// AWS KMS CMK that was used to encrypt the source DB cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the DB cluster isn't encrypted, then the restored DB cluster isn't encrypted.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If <code>DBClusterIdentifier</code> refers to a DB cluster that isn't encrypted, then
        /// the restore request is rejected.
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
        /// Gets and sets the property OptionGroupName. 
        /// <para>
        /// The name of the option group for the new DB cluster.
        /// </para>
        /// </summary>
        public string OptionGroupName
        {
            get { return this._optionGroupName; }
            set { this._optionGroupName = value; }
        }

        // Check to see if OptionGroupName property is set
        internal bool IsSetOptionGroupName()
        {
            return this._optionGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number on which the new DB cluster accepts connections.
        /// </para>
        ///  
        /// <para>
        /// Constraints: A value from <code>1150-65535</code>. 
        /// </para>
        ///  
        /// <para>
        /// Default: The default port for the engine.
        /// </para>
        /// </summary>
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RestoreToTimeUtc. 
        /// <para>
        /// The date and time to restore the DB cluster to.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: Value must be a time in Universal Coordinated Time (UTC) format
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be before the latest restorable time for the DB instance
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be specified if <code>UseLatestRestorableTime</code> parameter isn't provided
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be specified if the <code>UseLatestRestorableTime</code> parameter is enabled
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be specified if the <code>RestoreType</code> parameter is <code>copy-on-write</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <code>2015-03-07T23:45:00Z</code> 
        /// </para>
        /// </summary>
        public DateTime RestoreToTimeUtc
        {
            get { return this._restoreToTimeUtc.GetValueOrDefault(); }
            set { this._restoreToTime = this._restoreToTimeUtc = value; }
        }

        // Check to see if RestoreToTimeUtc property is set
        internal bool IsSetRestoreToTimeUtc()
        {
            return this._restoreToTimeUtc.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RestoreType. 
        /// <para>
        /// The type of restore to be performed. You can specify one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>full-copy</code> - The new DB cluster is restored as a full copy of the source
        /// DB cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>copy-on-write</code> - The new DB cluster is restored as a clone of the source
        /// DB cluster.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Constraints: You can't specify <code>copy-on-write</code> if the engine version of
        /// the source DB cluster is earlier than 1.11.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a <code>RestoreType</code> value, then the new DB cluster is
        /// restored as a full copy of the source DB cluster.
        /// </para>
        /// </summary>
        public string RestoreType
        {
            get { return this._restoreType; }
            set { this._restoreType = value; }
        }

        // Check to see if RestoreType property is set
        internal bool IsSetRestoreType()
        {
            return this._restoreType != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDBClusterIdentifier. 
        /// <para>
        /// The identifier of the source DB cluster from which to restore.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing DBCluster.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceDBClusterIdentifier
        {
            get { return this._sourceDBClusterIdentifier; }
            set { this._sourceDBClusterIdentifier = value; }
        }

        // Check to see if SourceDBClusterIdentifier property is set
        internal bool IsSetSourceDBClusterIdentifier()
        {
            return this._sourceDBClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UseLatestRestorableTime. 
        /// <para>
        /// A value that indicates whether to restore the DB cluster to the latest restorable
        /// backup time. By default, the DB cluster isn't restored to the latest restorable backup
        /// time. 
        /// </para>
        ///  
        /// <para>
        /// Constraints: Can't be specified if <code>RestoreToTime</code> parameter is provided.
        /// </para>
        /// </summary>
        public bool UseLatestRestorableTime
        {
            get { return this._useLatestRestorableTime.GetValueOrDefault(); }
            set { this._useLatestRestorableTime = value; }
        }

        // Check to see if UseLatestRestorableTime property is set
        internal bool IsSetUseLatestRestorableTime()
        {
            return this._useLatestRestorableTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// A list of VPC security groups that the new DB cluster belongs to.
        /// </para>
        /// </summary>
        public List<string> VpcSecurityGroupIds
        {
            get { return this._vpcSecurityGroupIds; }
            set { this._vpcSecurityGroupIds = value; }
        }

        // Check to see if VpcSecurityGroupIds property is set
        internal bool IsSetVpcSecurityGroupIds()
        {
            return this._vpcSecurityGroupIds != null && this._vpcSecurityGroupIds.Count > 0; 
        }

#region Backwards compatible properties
        private DateTime? _restoreToTime;

        /// <summary>
        /// Gets and sets the property RestoreToTimeUtc. 
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use RestoreToTimeUtc instead. Setting either RestoreToTime
        /// or RestoreToTimeUtc results in both RestoreToTime and RestoreToTimeUtc being assigned,
        /// the latest assignment to either one of the two property is reflected in the value
        /// of both. RestoreToTime is provided for backwards compatibility only and assigning
        /// a non-Utc DateTime to it results in the wrong timestamp being passed to the service.
        /// </para>
        ///  
        /// <para>
        /// The date and time to restore the DB cluster to.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: Value must be a time in Universal Coordinated Time (UTC) format
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be before the latest restorable time for the DB instance
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be specified if <code>UseLatestRestorableTime</code> parameter isn't provided
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be specified if the <code>UseLatestRestorableTime</code> parameter is enabled
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be specified if the <code>RestoreType</code> parameter is <code>copy-on-write</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <code>2015-03-07T23:45:00Z</code> 
        /// </para>
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use RestoreToTimeUtc instead. Setting either RestoreToTime or RestoreToTimeUtc results in both RestoreToTime and " +
            "RestoreToTimeUtc being assigned, the latest assignment to either one of the two property is " + 
            "reflected in the value of both. RestoreToTime is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime RestoreToTime
        {
            get { return this._restoreToTime.GetValueOrDefault(); }
            set
            {
                this._restoreToTime = value;
                this._restoreToTimeUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }
#endregion
    }
}