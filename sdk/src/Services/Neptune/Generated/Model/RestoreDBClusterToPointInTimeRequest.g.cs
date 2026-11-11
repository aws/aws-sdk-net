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

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreDBClusterToPointInTime operation. Restores
    /// a DB cluster to an arbitrary point in time. Users can restore to any point in time
    /// before <c>LatestRestorableTime</c> for up to <c>BackupRetentionPeriod</c> days. The
    /// target DB cluster is created from the source DB cluster with the same configuration
    /// as the original DB cluster, except that the new DB cluster is created with the default
    /// DB security group. <note> <para> This action only restores the DB cluster, not the
    /// DB instances for that DB cluster. You must invoke the <a>CreateDBInstance</a> action
    /// to create DB instances for the restored DB cluster, specifying the identifier of the
    /// restored DB cluster in <c>DBClusterIdentifier</c>. You can create DB instances only
    /// after the <c>RestoreDBClusterToPointInTime</c> action has completed and the DB cluster
    /// is available. </para> </note>
    /// </summary>
    public partial class RestoreDBClusterToPointInTimeRequest : AmazonNeptuneRequest
    {
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
        [AWSProperty(Required = true)]
        public string DBClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetDBClusterIdentifier() => this.DBClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property DBClusterParameterGroupName. 
        /// <para>
        /// The name of the DB cluster parameter group to associate with the new DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If supplied, must match the name of an existing DBClusterParameterGroup.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DBClusterParameterGroupName { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterParameterGroupName property is set.
        /// </summary>
        internal bool IsSetDBClusterParameterGroupName() => this.DBClusterParameterGroupName != null;

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
        /// Example: <c>mySubnetgroup</c> 
        /// </para>
        /// </summary>
        public string DBSubnetGroupName { get; set; }

        /// <summary>
        /// Checks to see if the DBSubnetGroupName property is set.
        /// </summary>
        internal bool IsSetDBSubnetGroupName() => this.DBSubnetGroupName != null;

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// A value that indicates whether the DB cluster has deletion protection enabled. The
        /// database can't be deleted when deletion protection is enabled. By default, deletion
        /// protection is disabled. 
        /// </para>
        /// </summary>
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtection property is set.
        /// </summary>
        internal bool IsSetDeletionProtection() => this.DeletionProtection.HasValue;

        /// <summary>
        /// Gets and sets the property EnableCloudwatchLogsExports. 
        /// <para>
        /// The list of logs that the restored DB cluster is to export to CloudWatch Logs.
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
        /// Gets and sets the property EnableIAMDatabaseAuthentication. 
        /// <para>
        /// True to enable mapping of Amazon Identity and Access Management (IAM) accounts to
        /// database accounts, and otherwise false.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? EnableIAMDatabaseAuthentication { get; set; }

        /// <summary>
        /// Checks to see if the EnableIAMDatabaseAuthentication property is set.
        /// </summary>
        internal bool IsSetEnableIAMDatabaseAuthentication() => this.EnableIAMDatabaseAuthentication.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon KMS key identifier to use when restoring an encrypted DB cluster from an
        /// encrypted DB cluster.
        /// </para>
        ///  
        /// <para>
        /// The KMS key identifier is the Amazon Resource Name (ARN) for the KMS encryption key.
        /// If you are restoring a DB cluster with the same Amazon account that owns the KMS encryption
        /// key used to encrypt the new DB cluster, then you can use the KMS key alias instead
        /// of the ARN for the KMS encryption key.
        /// </para>
        ///  
        /// <para>
        /// You can restore to a new DB cluster and encrypt the new DB cluster with a KMS key
        /// that is different than the KMS key used to encrypt the source DB cluster. The new
        /// DB cluster is encrypted with the KMS key identified by the <c>KmsKeyId</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value for the <c>KmsKeyId</c> parameter, then the following
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
        /// If <c>DBClusterIdentifier</c> refers to a DB cluster that is not encrypted, then the
        /// restore request is rejected.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The network type of the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>IPV4</c> </b> – ( <i>the default</i> ) The DB cluster uses only IPv4 addresses
        /// for communication.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>DUAL</c> </b> – The DB cluster uses both IPv4 and IPv6 addresses for communication.
        /// The DB subnet group associated with the cluster must support IPv6.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string NetworkType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkType property is set.
        /// </summary>
        internal bool IsSetNetworkType() => this.NetworkType != null;

        /// <summary>
        /// Gets and sets the property OptionGroupName. 
        /// <para>
        ///  <i>(Not supported by Neptune)</i> 
        /// </para>
        /// </summary>
        public string OptionGroupName { get; set; }

        /// <summary>
        /// Checks to see if the OptionGroupName property is set.
        /// </summary>
        internal bool IsSetOptionGroupName() => this.OptionGroupName != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number on which the new DB cluster accepts connections.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Value must be <c>1150-65535</c> 
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
        /// Must be specified if <c>UseLatestRestorableTime</c> parameter is not provided
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot be specified if <c>UseLatestRestorableTime</c> parameter is true
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot be specified if <c>RestoreType</c> parameter is <c>copy-on-write</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>2015-03-07T23:45:00Z</c> 
        /// </para>
        /// </summary>
        public DateTime? RestoreToTime { get; set; }

        /// <summary>
        /// Checks to see if the RestoreToTime property is set.
        /// </summary>
        internal bool IsSetRestoreToTime() => this.RestoreToTime.HasValue;

        /// <summary>
        /// Gets and sets the property RestoreType. 
        /// <para>
        /// The type of restore to be performed. You can specify one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>full-copy</c> - The new DB cluster is restored as a full copy of the source DB
        /// cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>copy-on-write</c> - The new DB cluster is restored as a clone of the source DB
        /// cluster.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify a <c>RestoreType</c> value, then the new DB cluster is restored
        /// as a full copy of the source DB cluster.
        /// </para>
        /// </summary>
        public string RestoreType { get; set; }

        /// <summary>
        /// Checks to see if the RestoreType property is set.
        /// </summary>
        internal bool IsSetRestoreType() => this.RestoreType != null;

        /// <summary>
        /// Gets and sets the property ServerlessV2ScalingConfiguration. 
        /// <para>
        /// Contains the scaling configuration of a Neptune Serverless DB cluster.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/neptune-serverless-using.html">Using
        /// Amazon Neptune Serverless</a> in the <i>Amazon Neptune User Guide</i>.
        /// </para>
        /// </summary>
        public ServerlessV2ScalingConfiguration ServerlessV2ScalingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessV2ScalingConfiguration property is set.
        /// </summary>
        internal bool IsSetServerlessV2ScalingConfiguration() => this.ServerlessV2ScalingConfiguration != null;

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
        [AWSProperty(Required = true)]
        public string SourceDBClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SourceDBClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetSourceDBClusterIdentifier() => this.SourceDBClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// Specifies the storage type to be associated with the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>standard</c>, <c>iopt1</c> 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>standard</c> 
        /// </para>
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be applied to the restored DB cluster.
        /// </para>
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
        /// Gets and sets the property UseLatestRestorableTime. 
        /// <para>
        /// A value that is set to <c>true</c> to restore the DB cluster to the latest restorable
        /// backup time, and <c>false</c> otherwise.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        ///  
        /// <para>
        /// Constraints: Cannot be specified if <c>RestoreToTime</c> parameter is provided.
        /// </para>
        /// </summary>
        public bool? UseLatestRestorableTime { get; set; }

        /// <summary>
        /// Checks to see if the UseLatestRestorableTime property is set.
        /// </summary>
        internal bool IsSetUseLatestRestorableTime() => this.UseLatestRestorableTime.HasValue;

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// A list of VPC security groups that the new DB cluster belongs to.
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
