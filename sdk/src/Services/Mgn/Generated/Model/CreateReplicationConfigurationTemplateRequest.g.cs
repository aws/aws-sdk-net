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
    /// Container for the parameters to the CreateReplicationConfigurationTemplate operation.
    /// Creates a new ReplicationConfigurationTemplate.
    /// </summary>
    public partial class CreateReplicationConfigurationTemplateRequest : AmazonMgnRequest
    {
        /// <summary>
        /// Gets and sets the property AssociateDefaultSecurityGroup. 
        /// <para>
        /// Request to associate the default Application Migration Service Security group with
        /// the Replication Settings template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? AssociateDefaultSecurityGroup { get; set; }

        /// <summary>
        /// Checks to see if the AssociateDefaultSecurityGroup property is set.
        /// </summary>
        internal bool IsSetAssociateDefaultSecurityGroup() => this.AssociateDefaultSecurityGroup.HasValue;

        /// <summary>
        /// Gets and sets the property BandwidthThrottling. 
        /// <para>
        /// Request to configure bandwidth throttling during Replication Settings template creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10000)]
        public long? BandwidthThrottling { get; set; }

        /// <summary>
        /// Checks to see if the BandwidthThrottling property is set.
        /// </summary>
        internal bool IsSetBandwidthThrottling() => this.BandwidthThrottling.HasValue;

        /// <summary>
        /// Gets and sets the property CreatePublicIP. 
        /// <para>
        /// Request to create Public IP during Replication Settings template creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? CreatePublicIP { get; set; }

        /// <summary>
        /// Checks to see if the CreatePublicIP property is set.
        /// </summary>
        internal bool IsSetCreatePublicIP() => this.CreatePublicIP.HasValue;

        /// <summary>
        /// Gets and sets the property DataPlaneRouting. 
        /// <para>
        /// Request to configure data plane routing during Replication Settings template creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReplicationConfigurationDataPlaneRouting DataPlaneRouting { get; set; }

        /// <summary>
        /// Checks to see if the DataPlaneRouting property is set.
        /// </summary>
        internal bool IsSetDataPlaneRouting() => this.DataPlaneRouting != null;

        /// <summary>
        /// Gets and sets the property DefaultLargeStagingDiskType. 
        /// <para>
        /// Request to configure the default large staging disk EBS volume type during Replication
        /// Settings template creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReplicationConfigurationDefaultLargeStagingDiskType DefaultLargeStagingDiskType { get; set; }

        /// <summary>
        /// Checks to see if the DefaultLargeStagingDiskType property is set.
        /// </summary>
        internal bool IsSetDefaultLargeStagingDiskType() => this.DefaultLargeStagingDiskType != null;

        /// <summary>
        /// Gets and sets the property EbsEncryption. 
        /// <para>
        /// Request to configure EBS encryption during Replication Settings template creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReplicationConfigurationEbsEncryption EbsEncryption { get; set; }

        /// <summary>
        /// Checks to see if the EbsEncryption property is set.
        /// </summary>
        internal bool IsSetEbsEncryption() => this.EbsEncryption != null;

        /// <summary>
        /// Gets and sets the property EbsEncryptionKeyArn. 
        /// <para>
        /// Request to configure an EBS encryption key during Replication Settings template creation.
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
        /// Request to configure the internet protocol to IPv4 or IPv6.
        /// </para>
        /// </summary>
        public InternetProtocol InternetProtocol { get; set; }

        /// <summary>
        /// Checks to see if the InternetProtocol property is set.
        /// </summary>
        internal bool IsSetInternetProtocol() => this.InternetProtocol != null;

        /// <summary>
        /// Gets and sets the property ReplicationServerInstanceType. 
        /// <para>
        /// Request to configure the Replication Server instance type during Replication Settings
        /// template creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string ReplicationServerInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationServerInstanceType property is set.
        /// </summary>
        internal bool IsSetReplicationServerInstanceType() => this.ReplicationServerInstanceType != null;

        /// <summary>
        /// Gets and sets the property ReplicationServersSecurityGroupsIDs. 
        /// <para>
        /// Request to configure the Replication Server Security group ID during Replication Settings
        /// template creation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 32)]
        public List<string> ReplicationServersSecurityGroupsIDs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReplicationServersSecurityGroupsIDs property is set.
        /// </summary>
        internal bool IsSetReplicationServersSecurityGroupsIDs() => this.ReplicationServersSecurityGroupsIDs != null && (this.ReplicationServersSecurityGroupsIDs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StagingAreaSubnetId. 
        /// <para>
        /// Request to configure the Staging Area subnet ID during Replication Settings template
        /// creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string StagingAreaSubnetId { get; set; }

        /// <summary>
        /// Checks to see if the StagingAreaSubnetId property is set.
        /// </summary>
        internal bool IsSetStagingAreaSubnetId() => this.StagingAreaSubnetId != null;

        /// <summary>
        /// Gets and sets the property StagingAreaTags. 
        /// <para>
        /// Request to configure Staging Area tags during Replication Settings template creation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 50)]
        public Dictionary<string, string> StagingAreaTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the StagingAreaTags property is set.
        /// </summary>
        internal bool IsSetStagingAreaTags() => this.StagingAreaTags != null && (this.StagingAreaTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StorageConfiguration. 
        /// <para>
        /// Request to configure storage during Replication Settings template creation.
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
        /// Request to store snapshot on local zone during Replication Settings template creation.
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
        /// Request to configure tags during Replication Settings template creation.
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
        /// Request to use Dedicated Replication Servers during Replication Settings template
        /// creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? UseDedicatedReplicationServer { get; set; }

        /// <summary>
        /// Checks to see if the UseDedicatedReplicationServer property is set.
        /// </summary>
        internal bool IsSetUseDedicatedReplicationServer() => this.UseDedicatedReplicationServer.HasValue;

        /// <summary>
        /// Gets and sets the property UseFipsEndpoint. 
        /// <para>
        /// Request to use Fips Endpoint during Replication Settings template creation.
        /// </para>
        /// </summary>
        public bool? UseFipsEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the UseFipsEndpoint property is set.
        /// </summary>
        internal bool IsSetUseFipsEndpoint() => this.UseFipsEndpoint.HasValue;
    }
}
