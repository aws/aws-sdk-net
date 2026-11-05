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

namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreDBClusterToPointInTime operation. Restores
    /// a cluster to an arbitrary point in time. Users can restore to any point in time before
    /// <c>LatestRestorableTime</c> for up to <c>BackupRetentionPeriod</c> days. The target
    /// cluster is created from the source cluster with the same configuration as the original
    /// cluster, except that the new cluster is created with the default security group.
    /// </summary>
    public partial class RestoreDBClusterToPointInTimeRequest : AmazonDocDBRequest
    {
        /// <summary>
        /// Gets and sets the property CopyTagsToSnapshot. 
        /// <para>
        /// Specifies whether to copy all tags from the restored DB cluster to snapshots of the
        /// restored DB cluster. The default is not to copy them.
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
        /// The name of the new cluster to be created.
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
        /// Cannot end with a hyphen or contain two consecutive hyphens.
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
        /// Gets and sets the property DBSubnetGroupName. 
        /// <para>
        /// The subnet group name to use for the new cluster.
        /// </para>
        ///  
        /// <para>
        /// Constraints: If provided, must match the name of an existing <c>DBSubnetGroup</c>.
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
        /// Specifies whether this cluster can be deleted. If <c>DeletionProtection</c> is enabled,
        /// the cluster cannot be deleted unless it is modified and <c>DeletionProtection</c>
        /// is disabled. <c>DeletionProtection</c> protects clusters from being accidentally deleted.
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
        /// A list of log types that must be enabled for exporting to Amazon CloudWatch Logs.
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The KMS key identifier to use when restoring an encrypted cluster from an encrypted
        /// cluster.
        /// </para>
        ///  
        /// <para>
        /// The KMS key identifier is the Amazon Resource Name (ARN) for the KMS encryption key.
        /// If you are restoring a cluster with the same Amazon Web Services account that owns
        /// the KMS encryption key used to encrypt the new cluster, then you can use the KMS key
        /// alias instead of the ARN for the KMS encryption key.
        /// </para>
        ///  
        /// <para>
        /// You can restore to a new cluster and encrypt the new cluster with an KMS key that
        /// is different from the KMS key used to encrypt the source cluster. The new DB cluster
        /// is encrypted with the KMS key identified by the <c>KmsKeyId</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value for the <c>KmsKeyId</c> parameter, then the following
        /// occurs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the cluster is encrypted, then the restored cluster is encrypted using the KMS
        /// key that was used to encrypt the source cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the cluster is not encrypted, then the restored cluster is not encrypted.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If <c>DBClusterIdentifier</c> refers to a cluster that is not encrypted, then the
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
        /// The network type of the cluster.
        /// </para>
        ///  
        /// <para>
        /// The network type is determined by the <c>DBSubnetGroup</c> specified for the cluster.
        /// A <c>DBSubnetGroup</c> can support only the IPv4 protocol or the IPv4 and the IPv6
        /// protocols (<c>DUAL</c>).
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/documentdb/latest/devguide/vpc-clusters.html">DocumentDB
        /// clusters in a VPC</a> in the Amazon DocumentDB Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>IPV4</c> | <c>DUAL</c> 
        /// </para>
        /// </summary>
        public string NetworkType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkType property is set.
        /// </summary>
        internal bool IsSetNetworkType() => this.NetworkType != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number on which the new cluster accepts connections.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must be a value from <c>1150</c> to <c>65535</c>. 
        /// </para>
        ///  
        /// <para>
        /// Default: The default port for the engine.
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
        /// The date and time to restore the cluster to.
        /// </para>
        ///  
        /// <para>
        /// Valid values: A time in Universal Coordinated Time (UTC) format.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be before the latest restorable time for the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be specified if the <c>UseLatestRestorableTime</c> parameter is not provided.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot be specified if the <c>UseLatestRestorableTime</c> parameter is <c>true</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot be specified if the <c>RestoreType</c> parameter is <c>copy-on-write</c>.
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
        /// Constraints: You can't specify <c>copy-on-write</c> if the engine version of the source
        /// DB cluster is earlier than 1.11.
        /// </para>
        ///  
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
        /// Contains the scaling configuration of an Amazon DocumentDB Serverless cluster.
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
        /// The identifier of the source cluster from which to restore.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing <c>DBCluster</c>.
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
        /// The storage type to associate with the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// For information on storage types for Amazon DocumentDB clusters, see Cluster storage
        /// configurations in the <i>Amazon DocumentDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid values for storage type - <c>standard | iopt1</c> 
        /// </para>
        ///  
        /// <para>
        /// Default value is <c>standard </c> 
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
        /// The tags to be assigned to the restored cluster.
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
        /// A value that is set to <c>true</c> to restore the cluster to the latest restorable
        /// backup time, and <c>false</c> otherwise. 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        ///  
        /// <para>
        /// Constraints: Cannot be specified if the <c>RestoreToTime</c> parameter is provided.
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
        /// A list of VPC security groups that the new cluster belongs to.
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
