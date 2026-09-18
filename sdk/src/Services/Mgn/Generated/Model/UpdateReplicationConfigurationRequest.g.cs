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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateReplicationConfiguration operation. Allows
    /// you to update multiple ReplicationConfigurations by Source Server ID.
    /// </summary>
    public partial class UpdateReplicationConfigurationRequest : AmazonMgnRequest
    {
        /// <summary>
        /// Gets and sets the property AccountID. 
        /// <para>
        /// Update replication configuration Account ID request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountID { get; set; }

        /// <summary>
        /// Checks to see if the AccountID property is set.
        /// </summary>
        internal bool IsSetAccountID() => this.AccountID != null;

        /// <summary>
        /// Gets and sets the property AssociateDefaultSecurityGroup. 
        /// <para>
        /// Update replication configuration associate default Application Migration Service Security
        /// group request.
        /// </para>
        /// </summary>
        public bool? AssociateDefaultSecurityGroup { get; set; }

        /// <summary>
        /// Checks to see if the AssociateDefaultSecurityGroup property is set.
        /// </summary>
        internal bool IsSetAssociateDefaultSecurityGroup() => this.AssociateDefaultSecurityGroup.HasValue;

        /// <summary>
        /// Gets and sets the property BandwidthThrottling. 
        /// <para>
        /// Update replication configuration bandwidth throttling request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public long? BandwidthThrottling { get; set; }

        /// <summary>
        /// Checks to see if the BandwidthThrottling property is set.
        /// </summary>
        internal bool IsSetBandwidthThrottling() => this.BandwidthThrottling.HasValue;

        /// <summary>
        /// Gets and sets the property CreatePublicIP. 
        /// <para>
        /// Update replication configuration create Public IP request.
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
        /// Update replication configuration data plane routing request.
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
        /// Update replication configuration use default large Staging Disk type request.
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
        /// Update replication configuration EBS encryption request.
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
        /// Update replication configuration EBS encryption key ARN request.
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
        /// Update replication configuration internet protocol.
        /// </para>
        /// </summary>
        public InternetProtocol InternetProtocol { get; set; }

        /// <summary>
        /// Checks to see if the InternetProtocol property is set.
        /// </summary>
        internal bool IsSetInternetProtocol() => this.InternetProtocol != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Update replication configuration name request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ReplicatedDisks. 
        /// <para>
        /// Update replication configuration replicated disks request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 60)]
        public List<ReplicationConfigurationReplicatedDisk> ReplicatedDisks { get; set; } = AWSConfigs.InitializeCollections ? new List<ReplicationConfigurationReplicatedDisk>() : null;

        /// <summary>
        /// Checks to see if the ReplicatedDisks property is set.
        /// </summary>
        internal bool IsSetReplicatedDisks() => this.ReplicatedDisks != null && (this.ReplicatedDisks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReplicationServerInstanceType. 
        /// <para>
        /// Update replication configuration Replication Server instance type request.
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
        /// Update replication configuration Replication Server Security Groups IDs request.
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
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// Update replication configuration Source Server ID request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 19, Max = 19)]
        public string SourceServerID { get; set; }

        /// <summary>
        /// Checks to see if the SourceServerID property is set.
        /// </summary>
        internal bool IsSetSourceServerID() => this.SourceServerID != null;

        /// <summary>
        /// Gets and sets the property StagingAreaSubnetId. 
        /// <para>
        /// Update replication configuration Staging Area subnet request.
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
        /// Update replication configuration Staging Area Tags request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 50)]
        public Dictionary<string, string> StagingAreaTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the StagingAreaTags property is set.
        /// </summary>
        internal bool IsSetStagingAreaTags() => this.StagingAreaTags != null && (this.StagingAreaTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StorageConfiguration. 
        /// <para>
        /// Update replication configuration storage configuration.
        /// </para>
        /// </summary>
        public StorageConfiguration StorageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the StorageConfiguration property is set.
        /// </summary>
        internal bool IsSetStorageConfiguration() => this.StorageConfiguration != null;

        /// <summary>
        /// Gets and sets the property StoreSnapshotOnLocalZone. 
        /// <para>
        /// Update replication configuration store snapshot on local zone.
        /// </para>
        /// </summary>
        public bool? StoreSnapshotOnLocalZone { get; set; }

        /// <summary>
        /// Checks to see if the StoreSnapshotOnLocalZone property is set.
        /// </summary>
        internal bool IsSetStoreSnapshotOnLocalZone() => this.StoreSnapshotOnLocalZone.HasValue;

        /// <summary>
        /// Gets and sets the property UseDedicatedReplicationServer. 
        /// <para>
        /// Update replication configuration use dedicated Replication Server request.
        /// </para>
        /// </summary>
        public bool? UseDedicatedReplicationServer { get; set; }

        /// <summary>
        /// Checks to see if the UseDedicatedReplicationServer property is set.
        /// </summary>
        internal bool IsSetUseDedicatedReplicationServer() => this.UseDedicatedReplicationServer.HasValue;

        /// <summary>
        /// Gets and sets the property UseFipsEndpoint. 
        /// <para>
        /// Update replication configuration use Fips Endpoint.
        /// </para>
        /// </summary>
        public bool? UseFipsEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the UseFipsEndpoint property is set.
        /// </summary>
        internal bool IsSetUseFipsEndpoint() => this.UseFipsEndpoint.HasValue;
    }
}
