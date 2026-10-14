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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// Information about a VM cluster.
    /// </summary>
    public partial class CloudVmCluster
    {
        /// <summary>
        /// Gets and sets the property CloudExadataInfrastructureArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Exadata infrastructure that this VM cluster
        /// belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string CloudExadataInfrastructureArn { get; set; }

        /// <summary>
        /// Checks to see if the CloudExadataInfrastructureArn property is set.
        /// </summary>
        internal bool IsSetCloudExadataInfrastructureArn() => this.CloudExadataInfrastructureArn != null;

        /// <summary>
        /// Gets and sets the property CloudExadataInfrastructureId. 
        /// <para>
        /// The unique identifier of the Exadata infrastructure that this VM cluster belongs to.
        /// </para>
        /// </summary>
        public string CloudExadataInfrastructureId { get; set; }

        /// <summary>
        /// Checks to see if the CloudExadataInfrastructureId property is set.
        /// </summary>
        internal bool IsSetCloudExadataInfrastructureId() => this.CloudExadataInfrastructureId != null;

        /// <summary>
        /// Gets and sets the property CloudVmClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the VM cluster.
        /// </para>
        /// </summary>
        public string CloudVmClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the CloudVmClusterArn property is set.
        /// </summary>
        internal bool IsSetCloudVmClusterArn() => this.CloudVmClusterArn != null;

        /// <summary>
        /// Gets and sets the property CloudVmClusterId. 
        /// <para>
        /// The unique identifier of the VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 64)]
        public string CloudVmClusterId { get; set; }

        /// <summary>
        /// Checks to see if the CloudVmClusterId property is set.
        /// </summary>
        internal bool IsSetCloudVmClusterId() => this.CloudVmClusterId != null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the Grid Infrastructure (GI) cluster.
        /// </para>
        /// </summary>
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property ComputeModel. 
        /// <para>
        /// The OCI model compute model used when you create or clone an instance: ECPU or OCPU.
        /// An ECPU is an abstracted measure of compute resources. ECPUs are based on the number
        /// of cores elastically allocated from a pool of compute and storage servers. An OCPU
        /// is a legacy physical measure of compute resources. OCPUs are based on the physical
        /// core of a processor with hyper-threading enabled. 
        /// </para>
        /// </summary>
        public ComputeModel ComputeModel { get; set; }

        /// <summary>
        /// Checks to see if the ComputeModel property is set.
        /// </summary>
        internal bool IsSetComputeModel() => this.ComputeModel != null;

        /// <summary>
        /// Gets and sets the property CpuCoreCount. 
        /// <para>
        /// The number of CPU cores enabled on the VM cluster.
        /// </para>
        /// </summary>
        public int? CpuCoreCount { get; set; }

        /// <summary>
        /// Checks to see if the CpuCoreCount property is set.
        /// </summary>
        internal bool IsSetCpuCoreCount() => this.CpuCoreCount.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the VM cluster was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DataCollectionOptions. 
        /// <para>
        /// The set of diagnostic collection options enabled for the VM cluster.
        /// </para>
        /// </summary>
        public DataCollectionOptions DataCollectionOptions { get; set; }

        /// <summary>
        /// Checks to see if the DataCollectionOptions property is set.
        /// </summary>
        internal bool IsSetDataCollectionOptions() => this.DataCollectionOptions != null;

        /// <summary>
        /// Gets and sets the property DataStorageSizeInTBs. 
        /// <para>
        /// The size of the data disk group, in terabytes (TB), that's allocated for the VM cluster.
        /// </para>
        /// </summary>
        public double? DataStorageSizeInTBs { get; set; }

        /// <summary>
        /// Checks to see if the DataStorageSizeInTBs property is set.
        /// </summary>
        internal bool IsSetDataStorageSizeInTBs() => this.DataStorageSizeInTBs.HasValue;

        /// <summary>
        /// Gets and sets the property DbNodeStorageSizeInGBs. 
        /// <para>
        /// The amount of local node storage, in gigabytes (GB), that's allocated for the VM cluster.
        /// </para>
        /// </summary>
        public int? DbNodeStorageSizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the DbNodeStorageSizeInGBs property is set.
        /// </summary>
        internal bool IsSetDbNodeStorageSizeInGBs() => this.DbNodeStorageSizeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property DbServers. 
        /// <para>
        /// The list of database servers for the VM cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public List<string> DbServers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DbServers property is set.
        /// </summary>
        internal bool IsSetDbServers() => this.DbServers != null && (this.DbServers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DiskRedundancy. 
        /// <para>
        /// The type of redundancy configured for the VM cluster. <c>NORMAL</c> is 2-way redundancy.
        /// <c>HIGH</c> is 3-way redundancy.
        /// </para>
        /// </summary>
        public DiskRedundancy DiskRedundancy { get; set; }

        /// <summary>
        /// Checks to see if the DiskRedundancy property is set.
        /// </summary>
        internal bool IsSetDiskRedundancy() => this.DiskRedundancy != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The user-friendly name for the VM cluster.
        /// </para>
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain of the VM cluster.
        /// </para>
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property GiVersion. 
        /// <para>
        /// The software version of the Oracle Grid Infrastructure (GI) for the VM cluster.
        /// </para>
        /// </summary>
        public string GiVersion { get; set; }

        /// <summary>
        /// Checks to see if the GiVersion property is set.
        /// </summary>
        internal bool IsSetGiVersion() => this.GiVersion != null;

        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The host name for the VM cluster.
        /// </para>
        /// </summary>
        public string Hostname { get; set; }

        /// <summary>
        /// Checks to see if the Hostname property is set.
        /// </summary>
        internal bool IsSetHostname() => this.Hostname != null;

        /// <summary>
        /// Gets and sets the property IamRoles. 
        /// <para>
        /// The Amazon Web Services Identity and Access Management (IAM) service roles associated
        /// with the VM cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IamRole> IamRoles { get; set; } = AWSConfigs.InitializeCollections ? new List<IamRole>() : null;

        /// <summary>
        /// Checks to see if the IamRoles property is set.
        /// </summary>
        internal bool IsSetIamRoles() => this.IamRoles != null && (this.IamRoles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IormConfigCache. 
        /// <para>
        /// The ExadataIormConfig cache details for the VM cluster.
        /// </para>
        /// </summary>
        public ExadataIormConfig IormConfigCache { get; set; }

        /// <summary>
        /// Checks to see if the IormConfigCache property is set.
        /// </summary>
        internal bool IsSetIormConfigCache() => this.IormConfigCache != null;

        /// <summary>
        /// Gets and sets the property IsLocalBackupEnabled. 
        /// <para>
        /// Indicates whether database backups to local Exadata storage is enabled for the VM
        /// cluster.
        /// </para>
        /// </summary>
        public bool? IsLocalBackupEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsLocalBackupEnabled property is set.
        /// </summary>
        internal bool IsSetIsLocalBackupEnabled() => this.IsLocalBackupEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property IsSparseDiskgroupEnabled. 
        /// <para>
        /// Indicates whether the VM cluster is configured with a sparse disk group.
        /// </para>
        /// </summary>
        public bool? IsSparseDiskgroupEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsSparseDiskgroupEnabled property is set.
        /// </summary>
        internal bool IsSetIsSparseDiskgroupEnabled() => this.IsSparseDiskgroupEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdateHistoryEntryId. 
        /// <para>
        /// The Oracle Cloud ID (OCID) of the last maintenance update history entry.
        /// </para>
        /// </summary>
        public string LastUpdateHistoryEntryId { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateHistoryEntryId property is set.
        /// </summary>
        internal bool IsSetLastUpdateHistoryEntryId() => this.LastUpdateHistoryEntryId != null;

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The Oracle license model applied to the VM cluster.
        /// </para>
        /// </summary>
        public LicenseModel LicenseModel { get; set; }

        /// <summary>
        /// Checks to see if the LicenseModel property is set.
        /// </summary>
        internal bool IsSetLicenseModel() => this.LicenseModel != null;

        /// <summary>
        /// Gets and sets the property ListenerPort. 
        /// <para>
        /// The port number configured for the listener on the VM cluster.
        /// </para>
        /// </summary>
        public int? ListenerPort { get; set; }

        /// <summary>
        /// Checks to see if the ListenerPort property is set.
        /// </summary>
        internal bool IsSetListenerPort() => this.ListenerPort.HasValue;

        /// <summary>
        /// Gets and sets the property MemorySizeInGBs. 
        /// <para>
        /// The amount of memory, in gigabytes (GB), that's allocated for the VM cluster.
        /// </para>
        /// </summary>
        public int? MemorySizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the MemorySizeInGBs property is set.
        /// </summary>
        internal bool IsSetMemorySizeInGBs() => this.MemorySizeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property NodeCount. 
        /// <para>
        /// The number of nodes in the VM cluster.
        /// </para>
        /// </summary>
        public int? NodeCount { get; set; }

        /// <summary>
        /// Checks to see if the NodeCount property is set.
        /// </summary>
        internal bool IsSetNodeCount() => this.NodeCount.HasValue;

        /// <summary>
        /// Gets and sets the property OciResourceAnchorName. 
        /// <para>
        /// The name of the OCI resource anchor for the VM cluster.
        /// </para>
        /// </summary>
        public string OciResourceAnchorName { get; set; }

        /// <summary>
        /// Checks to see if the OciResourceAnchorName property is set.
        /// </summary>
        internal bool IsSetOciResourceAnchorName() => this.OciResourceAnchorName != null;

        /// <summary>
        /// Gets and sets the property OciUrl. 
        /// <para>
        /// The HTTPS link to the VM cluster in OCI.
        /// </para>
        /// </summary>
        public string OciUrl { get; set; }

        /// <summary>
        /// Checks to see if the OciUrl property is set.
        /// </summary>
        internal bool IsSetOciUrl() => this.OciUrl != null;

        /// <summary>
        /// Gets and sets the property Ocid. 
        /// <para>
        /// The OCID of the VM cluster.
        /// </para>
        /// </summary>
        public string Ocid { get; set; }

        /// <summary>
        /// Checks to see if the Ocid property is set.
        /// </summary>
        internal bool IsSetOcid() => this.Ocid != null;

        /// <summary>
        /// Gets and sets the property OdbNetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ODB network associated with this VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string OdbNetworkArn { get; set; }

        /// <summary>
        /// Checks to see if the OdbNetworkArn property is set.
        /// </summary>
        internal bool IsSetOdbNetworkArn() => this.OdbNetworkArn != null;

        /// <summary>
        /// Gets and sets the property OdbNetworkId. 
        /// <para>
        /// The unique identifier of the ODB network for the VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 2048)]
        public string OdbNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the OdbNetworkId property is set.
        /// </summary>
        internal bool IsSetOdbNetworkId() => this.OdbNetworkId != null;

        /// <summary>
        /// Gets and sets the property PercentProgress. 
        /// <para>
        /// The amount of progress made on the current operation on the VM cluster, expressed
        /// as a percentage.
        /// </para>
        /// </summary>
        public float? PercentProgress { get; set; }

        /// <summary>
        /// Checks to see if the PercentProgress property is set.
        /// </summary>
        internal bool IsSetPercentProgress() => this.PercentProgress.HasValue;

        /// <summary>
        /// Gets and sets the property ScanDnsName. 
        /// <para>
        /// The fully qualified domain name (FQDN) of the DNS record for the Single Client Access
        /// Name (SCAN) IP addresses that are associated with the VM cluster.
        /// </para>
        /// </summary>
        public string ScanDnsName { get; set; }

        /// <summary>
        /// Checks to see if the ScanDnsName property is set.
        /// </summary>
        internal bool IsSetScanDnsName() => this.ScanDnsName != null;

        /// <summary>
        /// Gets and sets the property ScanDnsRecordId. 
        /// <para>
        /// The OCID of the DNS record for the SCAN IP addresses that are associated with the
        /// VM cluster.
        /// </para>
        /// </summary>
        public string ScanDnsRecordId { get; set; }

        /// <summary>
        /// Checks to see if the ScanDnsRecordId property is set.
        /// </summary>
        internal bool IsSetScanDnsRecordId() => this.ScanDnsRecordId != null;

        /// <summary>
        /// Gets and sets the property ScanIpIds. 
        /// <para>
        /// The OCID of the SCAN IP addresses that are associated with the VM cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public List<string> ScanIpIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ScanIpIds property is set.
        /// </summary>
        internal bool IsSetScanIpIds() => this.ScanIpIds != null && (this.ScanIpIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Shape. 
        /// <para>
        /// The hardware model name of the Exadata infrastructure that's running the VM cluster.
        /// </para>
        /// </summary>
        public string Shape { get; set; }

        /// <summary>
        /// Checks to see if the Shape property is set.
        /// </summary>
        internal bool IsSetShape() => this.Shape != null;

        /// <summary>
        /// Gets and sets the property SshPublicKeys. 
        /// <para>
        /// The public key portion of one or more key pairs used for SSH access to the VM cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SshPublicKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SshPublicKeys property is set.
        /// </summary>
        internal bool IsSetSshPublicKeys() => this.SshPublicKeys != null && (this.SshPublicKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the VM cluster.
        /// </para>
        /// </summary>
        public ResourceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information about the status of the VM cluster.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property StorageSizeInGBs. 
        /// <para>
        /// The amount of local node storage, in gigabytes (GB), that's allocated to the VM cluster.
        /// </para>
        /// </summary>
        public int? StorageSizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the StorageSizeInGBs property is set.
        /// </summary>
        internal bool IsSetStorageSizeInGBs() => this.StorageSizeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property SystemVersion. 
        /// <para>
        /// The operating system version of the image chosen for the VM cluster.
        /// </para>
        /// </summary>
        public string SystemVersion { get; set; }

        /// <summary>
        /// Checks to see if the SystemVersion property is set.
        /// </summary>
        internal bool IsSetSystemVersion() => this.SystemVersion != null;

        /// <summary>
        /// Gets and sets the property TimeZone. 
        /// <para>
        /// The time zone of the VM cluster.
        /// </para>
        /// </summary>
        public string TimeZone { get; set; }

        /// <summary>
        /// Checks to see if the TimeZone property is set.
        /// </summary>
        internal bool IsSetTimeZone() => this.TimeZone != null;

        /// <summary>
        /// Gets and sets the property VipIds. 
        /// <para>
        /// The virtual IP (VIP) addresses that are associated with the VM cluster. Oracle's Cluster
        /// Ready Services (CRS) creates and maintains one VIP address for each node in the VM
        /// cluster to enable failover. If one node fails, the VIP is reassigned to another active
        /// node in the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public List<string> VipIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the VipIds property is set.
        /// </summary>
        internal bool IsSetVipIds() => this.VipIds != null && (this.VipIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
