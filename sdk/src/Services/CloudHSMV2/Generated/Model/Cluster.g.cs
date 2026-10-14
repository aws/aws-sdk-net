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
    /// Contains information about an CloudHSM cluster.
    /// </summary>
    public partial class Cluster
    {
        /// <summary>
        /// Gets and sets the property BackupPolicy. 
        /// <para>
        /// The cluster's backup policy.
        /// </para>
        /// </summary>
        public BackupPolicy BackupPolicy { get; set; }

        /// <summary>
        /// Checks to see if the BackupPolicy property is set.
        /// </summary>
        internal bool IsSetBackupPolicy() => this.BackupPolicy != null;

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
        /// Gets and sets the property Certificates. 
        /// <para>
        /// Contains one or more certificates or a certificate signing request (CSR).
        /// </para>
        /// </summary>
        public Certificates Certificates { get; set; }

        /// <summary>
        /// Checks to see if the Certificates property is set.
        /// </summary>
        internal bool IsSetCertificates() => this.Certificates != null;

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The cluster's identifier (ID).
        /// </para>
        /// </summary>
        public string ClusterId { get; set; }

        /// <summary>
        /// Checks to see if the ClusterId property is set.
        /// </summary>
        internal bool IsSetClusterId() => this.ClusterId != null;

        /// <summary>
        /// Gets and sets the property CreateTimestamp. 
        /// <para>
        /// The date and time when the cluster was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreateTimestamp property is set.
        /// </summary>
        internal bool IsSetCreateTimestamp() => this.CreateTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property HsmType. 
        /// <para>
        /// The type of HSM that the cluster contains.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string HsmType { get; set; }

        /// <summary>
        /// Checks to see if the HsmType property is set.
        /// </summary>
        internal bool IsSetHsmType() => this.HsmType != null;

        /// <summary>
        /// Gets and sets the property HsmTypeRollbackExpiration. 
        /// <para>
        /// The timestamp until when the cluster can be rolled back to its original HSM type.
        /// </para>
        /// </summary>
        public DateTime? HsmTypeRollbackExpiration { get; set; }

        /// <summary>
        /// Checks to see if the HsmTypeRollbackExpiration property is set.
        /// </summary>
        internal bool IsSetHsmTypeRollbackExpiration() => this.HsmTypeRollbackExpiration.HasValue;

        /// <summary>
        /// Gets and sets the property Hsms. 
        /// <para>
        /// Contains information about the HSMs in the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Hsm> Hsms { get; set; } = AWSConfigs.InitializeCollections ? new List<Hsm>() : null;

        /// <summary>
        /// Checks to see if the Hsms property is set.
        /// </summary>
        internal bool IsSetHsms() => this.Hsms != null && (this.Hsms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The mode of the cluster.
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
        /// The cluster's NetworkType can be IPv4 (the default) or DUALSTACK. The IPv4 NetworkType
        /// restricts communication between your application and the hardware security modules
        /// (HSMs) to the IPv4 protocol only. The DUALSTACK NetworkType enables communication
        /// over both IPv4 and IPv6 protocols. To use DUALSTACK, configure your virtual private
        /// cloud (VPC) and subnets to support both IPv4 and IPv6. This configuration involves
        /// adding IPv6 Classless Inter-Domain Routing (CIDR) blocks to the existing IPv4 CIDR
        /// blocks in your subnets. The NetworkType you choose affects the network addressing
        /// options for your cluster. DUALSTACK provides more flexibility by supporting both IPv4
        /// and IPv6 communication.
        /// </para>
        /// </summary>
        public NetworkType NetworkType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkType property is set.
        /// </summary>
        internal bool IsSetNetworkType() => this.NetworkType != null;

        /// <summary>
        /// Gets and sets the property PreCoPassword. 
        /// <para>
        /// The default password for the cluster's Pre-Crypto Officer (PRECO) user.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 7, Max = 32)]
        public string PreCoPassword { get; set; }

        /// <summary>
        /// Checks to see if the PreCoPassword property is set.
        /// </summary>
        internal bool IsSetPreCoPassword() => this.PreCoPassword != null;

        /// <summary>
        /// Gets and sets the property SecurityGroup. 
        /// <para>
        /// The identifier (ID) of the cluster's security group.
        /// </para>
        /// </summary>
        public string SecurityGroup { get; set; }

        /// <summary>
        /// Checks to see if the SecurityGroup property is set.
        /// </summary>
        internal bool IsSetSecurityGroup() => this.SecurityGroup != null;

        /// <summary>
        /// Gets and sets the property SourceBackupId. 
        /// <para>
        /// The identifier (ID) of the backup used to create the cluster. This value exists only
        /// when the cluster was created from a backup.
        /// </para>
        /// </summary>
        public string SourceBackupId { get; set; }

        /// <summary>
        /// Checks to see if the SourceBackupId property is set.
        /// </summary>
        internal bool IsSetSourceBackupId() => this.SourceBackupId != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The cluster's state.
        /// </para>
        /// </summary>
        public ClusterState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateMessage. 
        /// <para>
        /// A description of the cluster's state.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 300)]
        public string StateMessage { get; set; }

        /// <summary>
        /// Checks to see if the StateMessage property is set.
        /// </summary>
        internal bool IsSetStateMessage() => this.StateMessage != null;

        /// <summary>
        /// Gets and sets the property SubnetMapping. 
        /// <para>
        /// A map from availability zone to the cluster’s subnet in that availability zone.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> SubnetMapping { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the SubnetMapping property is set.
        /// </summary>
        internal bool IsSetSubnetMapping() => this.SubnetMapping != null && (this.SubnetMapping.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TagList. 
        /// <para>
        /// The list of tags for the cluster.
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

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The identifier (ID) of the virtual private cloud (VPC) that contains the cluster.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
