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

namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCluster operation. Creates a new CloudHSM
    /// cluster. <para> <b>Cross-account use:</b> Yes. To perform this operation with an CloudHSM
    /// backup in a different AWS account, specify the full backup ARN in the value of the
    /// SourceBackupId parameter. </para>
    /// </summary>
    public partial class CreateClusterRequest : AmazonCloudHSMV2Request
    {
        /// <summary>
        /// Gets and sets the property BackupRetentionPolicy. 
        /// <para>
        /// A policy that defines how the service retains backups.
        /// </para>
        /// </summary>
        public BackupRetentionPolicy BackupRetentionPolicy { get; set; }

        /// <summary>
        /// Checks to see if the BackupRetentionPolicy property is set.
        /// </summary>
        internal bool IsSetBackupRetentionPolicy() => this.BackupRetentionPolicy != null;

        /// <summary>
        /// Gets and sets the property HsmType. 
        /// <para>
        /// The type of HSM to use in the cluster. The allowed values are <c>hsm1.medium</c> and
        /// <c>hsm2m.medium</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 32)]
        public string HsmType { get; set; }

        /// <summary>
        /// Checks to see if the HsmType property is set.
        /// </summary>
        internal bool IsSetHsmType() => this.HsmType != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The mode to use in the cluster. The allowed values are <c>FIPS</c> and <c>NON_FIPS</c>.
        /// </para>
        /// </summary>
        public ClusterMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The NetworkType to create a cluster with. The allowed values are <c>IPV4</c> and <c>DUALSTACK</c>.
        /// 
        /// </para>
        /// </summary>
        public NetworkType NetworkType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkType property is set.
        /// </summary>
        internal bool IsSetNetworkType() => this.NetworkType != null;

        /// <summary>
        /// Gets and sets the property SourceBackupId. 
        /// <para>
        /// The identifier (ID) or the Amazon Resource Name (ARN) of the cluster backup to restore.
        /// Use this value to restore the cluster from a backup instead of creating a new cluster.
        /// To find the backup ID or ARN, use <a>DescribeBackups</a>. <i>If using a backup in
        /// another account, the full ARN must be supplied.</i> 
        /// </para>
        /// </summary>
        public string SourceBackupId { get; set; }

        /// <summary>
        /// Checks to see if the SourceBackupId property is set.
        /// </summary>
        internal bool IsSetSourceBackupId() => this.SourceBackupId != null;

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The identifiers (IDs) of the subnets where you are creating the cluster. You must
        /// specify at least one subnet. If you specify multiple subnets, they must meet the following
        /// criteria:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// All subnets must be in the same virtual private cloud (VPC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can specify only one subnet per Availability Zone.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<string> SubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubnetIds property is set.
        /// </summary>
        internal bool IsSetSubnetIds() => this.SubnetIds != null && (this.SubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TagList. 
        /// <para>
        /// Tags to apply to the CloudHSM cluster during creation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<Tag> TagList { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the TagList property is set.
        /// </summary>
        internal bool IsSetTagList() => this.TagList != null && (this.TagList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
