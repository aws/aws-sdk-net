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

namespace Amazon.Drs.Model
{
    /// <summary>
    /// This is the response object from the CreateReplicationConfigurationTemplate operation.
    /// </summary>
    public partial class CreateReplicationConfigurationTemplateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Replication Configuration Template ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AssociateDefaultSecurityGroup. 
        /// <para>
        /// Whether to associate the default Elastic Disaster Recovery Security group with the
        /// Replication Configuration Template.
        /// </para>
        /// </summary>
        public bool? AssociateDefaultSecurityGroup { get; set; }

        /// <summary>
        /// Checks to see if the AssociateDefaultSecurityGroup property is set.
        /// </summary>
        internal bool IsSetAssociateDefaultSecurityGroup() => this.AssociateDefaultSecurityGroup.HasValue;

        /// <summary>
        /// Gets and sets the property AutoReplicateNewDisks. 
        /// <para>
        /// Whether to allow the AWS replication agent to automatically replicate newly added
        /// disks.
        /// </para>
        /// </summary>
        public bool? AutoReplicateNewDisks { get; set; }

        /// <summary>
        /// Checks to see if the AutoReplicateNewDisks property is set.
        /// </summary>
        internal bool IsSetAutoReplicateNewDisks() => this.AutoReplicateNewDisks.HasValue;

        /// <summary>
        /// Gets and sets the property BandwidthThrottling. 
        /// <para>
        /// Configure bandwidth throttling for the outbound data transfer rate of the Source Server
        /// in Mbps.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? BandwidthThrottling { get; set; }

        /// <summary>
        /// Checks to see if the BandwidthThrottling property is set.
        /// </summary>
        internal bool IsSetBandwidthThrottling() => this.BandwidthThrottling.HasValue;

        /// <summary>
        /// Gets and sets the property CreatePublicIP. 
        /// <para>
        /// Whether to create a Public IP for the Recovery Instance by default.
        /// </para>
        /// </summary>
        public bool? CreatePublicIP { get; set; }

        /// <summary>
        /// Checks to see if the CreatePublicIP property is set.
        /// </summary>
        internal bool IsSetCreatePublicIP() => this.CreatePublicIP.HasValue;

        /// <summary>
        /// Gets and sets the property DataPlaneRouting. 
        /// <para>
        /// The data plane routing mechanism that will be used for replication.
        /// </para>
        /// </summary>
        public ReplicationConfigurationDataPlaneRouting DataPlaneRouting { get; set; }

        /// <summary>
        /// Checks to see if the DataPlaneRouting property is set.
        /// </summary>
        internal bool IsSetDataPlaneRouting() => this.DataPlaneRouting != null;

        /// <summary>
        /// Gets and sets the property DefaultLargeStagingDiskType. 
        /// <para>
        /// The Staging Disk EBS volume type to be used during replication.
        /// </para>
        /// </summary>
        public ReplicationConfigurationDefaultLargeStagingDiskType DefaultLargeStagingDiskType { get; set; }

        /// <summary>
        /// Checks to see if the DefaultLargeStagingDiskType property is set.
        /// </summary>
        internal bool IsSetDefaultLargeStagingDiskType() => this.DefaultLargeStagingDiskType != null;

        /// <summary>
        /// Gets and sets the property EbsEncryption. 
        /// <para>
        /// The type of EBS encryption to be used during replication.
        /// </para>
        /// </summary>
        public ReplicationConfigurationEbsEncryption EbsEncryption { get; set; }

        /// <summary>
        /// Checks to see if the EbsEncryption property is set.
        /// </summary>
        internal bool IsSetEbsEncryption() => this.EbsEncryption != null;

        /// <summary>
        /// Gets and sets the property EbsEncryptionKeyArn. 
        /// <para>
        /// The ARN of the EBS encryption key to be used during replication.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string EbsEncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the EbsEncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetEbsEncryptionKeyArn() => this.EbsEncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property InternetProtocol. 
        /// <para>
        /// Which version of the Internet Protocol to use for replication of data. (IPv4 or IPv6)
        /// </para>
        /// </summary>
        public InternetProtocol InternetProtocol { get; set; }

        /// <summary>
        /// Checks to see if the InternetProtocol property is set.
        /// </summary>
        internal bool IsSetInternetProtocol() => this.InternetProtocol != null;

        /// <summary>
        /// Gets and sets the property PitPolicy. 
        /// <para>
        /// The Point in time (PIT) policy to manage snapshots taken during replication.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 3, Max = 3)]
        public List<PITPolicyRule> PitPolicy { get; set; } = AWSConfigs.InitializeCollections ? new List<PITPolicyRule>() : null;

        /// <summary>
        /// Checks to see if the PitPolicy property is set.
        /// </summary>
        internal bool IsSetPitPolicy() => this.PitPolicy != null && (this.PitPolicy.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReplicationConfigurationTemplateID. 
        /// <para>
        /// The Replication Configuration Template ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 21, Max = 21)]
        public string ReplicationConfigurationTemplateID { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationConfigurationTemplateID property is set.
        /// </summary>
        internal bool IsSetReplicationConfigurationTemplateID() => this.ReplicationConfigurationTemplateID != null;

        /// <summary>
        /// Gets and sets the property ReplicationServerInstanceType. 
        /// <para>
        /// The instance type to be used for the replication server.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string ReplicationServerInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationServerInstanceType property is set.
        /// </summary>
        internal bool IsSetReplicationServerInstanceType() => this.ReplicationServerInstanceType != null;

        /// <summary>
        /// Gets and sets the property ReplicationServersSecurityGroupsIDs. 
        /// <para>
        /// The security group IDs that will be used by the replication server.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public List<string> ReplicationServersSecurityGroupsIDs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReplicationServersSecurityGroupsIDs property is set.
        /// </summary>
        internal bool IsSetReplicationServersSecurityGroupsIDs() => this.ReplicationServersSecurityGroupsIDs != null && (this.ReplicationServersSecurityGroupsIDs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StagingAreaSubnetId. 
        /// <para>
        /// The subnet to be used by the replication staging area.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string StagingAreaSubnetId { get; set; }

        /// <summary>
        /// Checks to see if the StagingAreaSubnetId property is set.
        /// </summary>
        internal bool IsSetStagingAreaSubnetId() => this.StagingAreaSubnetId != null;

        /// <summary>
        /// Gets and sets the property StagingAreaTags. 
        /// <para>
        /// A set of tags to be associated with all resources created in the replication staging
        /// area: EC2 replication server, EBS volumes, EBS snapshots, etc.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> StagingAreaTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the StagingAreaTags property is set.
        /// </summary>
        internal bool IsSetStagingAreaTags() => this.StagingAreaTags != null && (this.StagingAreaTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of tags to be associated with the Replication Configuration Template resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UseDedicatedReplicationServer. 
        /// <para>
        /// Whether to use a dedicated Replication Server in the replication staging area.
        /// </para>
        /// </summary>
        public bool? UseDedicatedReplicationServer { get; set; }

        /// <summary>
        /// Checks to see if the UseDedicatedReplicationServer property is set.
        /// </summary>
        internal bool IsSetUseDedicatedReplicationServer() => this.UseDedicatedReplicationServer.HasValue;
    }
}
