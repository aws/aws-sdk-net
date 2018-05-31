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
 * Do not modify this file. This file is generated from the neptune-2018-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptune.Model
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
    /// You must invoke the <a>CreateDBInstance</a> action to create DB instances for the
    /// restored DB cluster, specifying the identifier of the restored DB cluster in <code>DBClusterIdentifier</code>.
    /// You can create DB instances only after the <code>RestoreDBClusterToPointInTime</code>
    /// action has completed and the DB cluster is available.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
    /// on Amazon Neptune</a> in the <i>Amazon Neptune User Guide.</i> 
    /// </para>
    /// </summary>
    public partial class RestoreDBClusterToPointInTimeRequest : AmazonNeptuneRequest
    {
        private string _dbClusterIdentifier;
        private string _dbSubnetGroupName;
        private bool? _enableIAMDatabaseAuthentication;
        private string _kmsKeyId;
        private string _optionGroupName;
        private int? _port;
        private DateTime? _restoreToTime;
        private string _restoreType;
        private string _sourceDBClusterIdentifier;
        private List<Tag> _tags = new List<Tag>();
        private bool? _useLatestRestorableTime;
        private List<string> _vpcSecurityGroupIds = new List<string>();

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
        /// Cannot end with a hyphen or contain two consecutive hyphens
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// Gets and sets the property EnableIAMDatabaseAuthentication. 
        /// <para>
        /// True to enable mapping of AWS Identity and Access Management (IAM) accounts to database
        /// accounts, and otherwise false.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>false</code> 
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
        /// The KMS key identifier is the Amazon Resource Name (ARN) for the KMS encryption key.
        /// If you are restoring a DB cluster with the same AWS account that owns the KMS encryption
        /// key used to encrypt the new DB cluster, then you can use the KMS key alias instead
        /// of the ARN for the KMS encryption key.
        /// </para>
        ///  
        /// <para>
        /// You can restore to a new DB cluster and encrypt the new DB cluster with a KMS key
        /// that is different than the KMS key used to encrypt the source DB cluster. The new
        /// DB cluster is encrypted with the KMS key identified by the <code>KmsKeyId</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value for the <code>KmsKeyId</code> parameter, then the following
        /// will occur:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the DB cluster is encrypted, then the restored DB cluster is encrypted using the
        /// KMS key that was used to encrypt the source DB cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the DB cluster is not encrypted, then the restored DB cluster is not encrypted.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If <code>DBClusterIdentifier</code> refers to a DB cluster that is not encrypted,
        /// then the restore request is rejected.
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
        /// Constraints: Value must be <code>1150-65535</code> 
        /// </para>
        ///  
        /// <para>
        /// Default: The same port as the original DB cluster.
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
        /// Gets and sets the property RestoreToTime. 
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
        /// Must be specified if <code>UseLatestRestorableTime</code> parameter is not provided
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot be specified if <code>UseLatestRestorableTime</code> parameter is true
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot be specified if <code>RestoreType</code> parameter is <code>copy-on-write</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <code>2015-03-07T23:45:00Z</code> 
        /// </para>
        /// </summary>
        public DateTime RestoreToTime
        {
            get { return this._restoreToTime.GetValueOrDefault(); }
            set { this._restoreToTime = value; }
        }

        // Check to see if RestoreToTime property is set
        internal bool IsSetRestoreToTime()
        {
            return this._restoreToTime.HasValue; 
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
        /// A value that is set to <code>true</code> to restore the DB cluster to the latest restorable
        /// backup time, and <code>false</code> otherwise. 
        /// </para>
        ///  
        /// <para>
        /// Default: <code>false</code> 
        /// </para>
        ///  
        /// <para>
        /// Constraints: Cannot be specified if <code>RestoreToTime</code> parameter is provided.
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

    }
}