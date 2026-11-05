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
    /// Container for the parameters to the RestoreDBClusterFromSnapshot operation. Creates
    /// a new DB cluster from a DB snapshot or DB cluster snapshot. <para> If a DB snapshot
    /// is specified, the target DB cluster is created from the source DB snapshot with a
    /// default configuration and default security group. </para> <para> If a DB cluster snapshot
    /// is specified, the target DB cluster is created from the source DB cluster restore
    /// point with the same configuration as the original source DB cluster, except that the
    /// new DB cluster is created with the default security group. </para>
    /// </summary>
    public partial class RestoreDBClusterFromSnapshotRequest : AmazonNeptuneRequest
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// Provides the list of EC2 Availability Zones that instances in the restored DB cluster
        /// can be created in.
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
        /// Gets and sets the property CopyTagsToSnapshot. 
        /// <para>
        ///  <i>If set to <c>true</c>, tags are copied to any snapshot of the restored DB cluster
        /// that is created.</i> 
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
        /// The name of the DB cluster to create from the DB snapshot or DB cluster snapshot.
        /// This parameter isn't case-sensitive.
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
        /// <para>
        /// Example: <c>my-snapshot-id</c> 
        /// </para>
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
        /// The name of the DB subnet group to use for the new DB cluster.
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
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// Not supported.
        /// </para>
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

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
        /// The list of logs that the restored DB cluster is to export to Amazon CloudWatch Logs.
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
        /// Gets and sets the property Engine. 
        /// <para>
        /// The database engine to use for the new DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Default: The same as source
        /// </para>
        ///  
        /// <para>
        /// Constraint: Must be compatible with the engine of the source
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version of the database engine to use for the new DB cluster.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon KMS key identifier to use when restoring an encrypted DB cluster from a
        /// DB snapshot or DB cluster snapshot.
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
        /// If you do not specify a value for the <c>KmsKeyId</c> parameter, then the following
        /// will occur:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the DB snapshot or DB cluster snapshot in <c>SnapshotIdentifier</c> is encrypted,
        /// then the restored DB cluster is encrypted using the KMS key that was used to encrypt
        /// the DB snapshot or DB cluster snapshot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the DB snapshot or DB cluster snapshot in <c>SnapshotIdentifier</c> is not encrypted,
        /// then the restored DB cluster is not encrypted.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property SnapshotIdentifier. 
        /// <para>
        /// The identifier for the DB snapshot or DB cluster snapshot to restore from.
        /// </para>
        ///  
        /// <para>
        /// You can use either the name or the Amazon Resource Name (ARN) to specify a DB cluster
        /// snapshot. However, you can use only the ARN to specify a DB snapshot.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing Snapshot.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SnapshotIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotIdentifier property is set.
        /// </summary>
        internal bool IsSetSnapshotIdentifier() => this.SnapshotIdentifier != null;

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
        /// The tags to be assigned to the restored DB cluster.
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
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// A list of VPC security groups that the new DB cluster will belong to.
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
