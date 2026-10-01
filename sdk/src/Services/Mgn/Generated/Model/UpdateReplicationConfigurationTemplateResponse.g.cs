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
    /// This is the response object from the UpdateReplicationConfigurationTemplate operation.
    /// </summary>
    public partial class UpdateReplicationConfigurationTemplateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Replication Configuration template ARN.
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
        /// Replication Configuration template associate default Application Migration Service
        /// Security group.
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
        /// Replication Configuration template bandwidth throttling.
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
        /// Replication Configuration template create Public IP.
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
        /// Replication Configuration template data plane routing.
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
        /// Replication Configuration template use default large Staging Disk type.
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
        /// Replication Configuration template EBS encryption.
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
        /// Replication Configuration template EBS encryption key ARN.
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
        /// Replication Configuration template internet protocol.
        /// </para>
        /// </summary>
        public InternetProtocol InternetProtocol { get; set; }

        /// <summary>
        /// Checks to see if the InternetProtocol property is set.
        /// </summary>
        internal bool IsSetInternetProtocol() => this.InternetProtocol != null;

        /// <summary>
        /// Gets and sets the property ReplicationConfigurationTemplateID. 
        /// <para>
        /// Replication Configuration template ID.
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
        /// Replication Configuration template server instance type.
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
        /// Replication Configuration template server Security Groups IDs.
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
        /// Replication Configuration template Staging Area subnet ID.
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
        /// Replication Configuration template Staging Area Tags.
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
        /// Replication Configuration template storage configuration.
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
        /// Replication Configuration template store snapshot on local zone.
        /// </para>
        /// </summary>
        public bool? StoreSnapshotOnLocalZone { get; set; }

        /// <summary>
        /// Checks to see if the StoreSnapshotOnLocalZone property is set.
        /// </summary>
        internal bool IsSetStoreSnapshotOnLocalZone() => this.StoreSnapshotOnLocalZone.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Replication Configuration template Tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UseDedicatedReplicationServer. 
        /// <para>
        /// Replication Configuration template use Dedicated Replication Server.
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
        /// Replication Configuration template use Fips Endpoint.
        /// </para>
        /// </summary>
        public bool? UseFipsEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the UseFipsEndpoint property is set.
        /// </summary>
        internal bool IsSetUseFipsEndpoint() => this.UseFipsEndpoint.HasValue;
    }
}
