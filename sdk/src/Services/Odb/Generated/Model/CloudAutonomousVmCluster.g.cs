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
    /// Information about an Autonomous VM cluster resource.
    /// </summary>
    public partial class CloudAutonomousVmCluster
    {
        /// <summary>
        /// Gets and sets the property AutonomousDataStoragePercentage. 
        /// <para>
        /// The percentage of data storage currently in use for Autonomous Databases in the Autonomous
        /// VM cluster.
        /// </para>
        /// </summary>
        public float? AutonomousDataStoragePercentage { get; set; }

        /// <summary>
        /// Checks to see if the AutonomousDataStoragePercentage property is set.
        /// </summary>
        internal bool IsSetAutonomousDataStoragePercentage() => this.AutonomousDataStoragePercentage.HasValue;

        /// <summary>
        /// Gets and sets the property AutonomousDataStorageSizeInTBs. 
        /// <para>
        /// The data storage size allocated for Autonomous Databases in the Autonomous VM cluster,
        /// in TB.
        /// </para>
        /// </summary>
        public double? AutonomousDataStorageSizeInTBs { get; set; }

        /// <summary>
        /// Checks to see if the AutonomousDataStorageSizeInTBs property is set.
        /// </summary>
        internal bool IsSetAutonomousDataStorageSizeInTBs() => this.AutonomousDataStorageSizeInTBs.HasValue;

        /// <summary>
        /// Gets and sets the property AvailableAutonomousDataStorageSizeInTBs. 
        /// <para>
        /// The available data storage space for Autonomous Databases in the Autonomous VM cluster,
        /// in TB.
        /// </para>
        /// </summary>
        public double? AvailableAutonomousDataStorageSizeInTBs { get; set; }

        /// <summary>
        /// Checks to see if the AvailableAutonomousDataStorageSizeInTBs property is set.
        /// </summary>
        internal bool IsSetAvailableAutonomousDataStorageSizeInTBs() => this.AvailableAutonomousDataStorageSizeInTBs.HasValue;

        /// <summary>
        /// Gets and sets the property AvailableContainerDatabases. 
        /// <para>
        /// The number of Autonomous CDBs that you can create with the currently available storage.
        /// </para>
        /// </summary>
        public int? AvailableContainerDatabases { get; set; }

        /// <summary>
        /// Checks to see if the AvailableContainerDatabases property is set.
        /// </summary>
        internal bool IsSetAvailableContainerDatabases() => this.AvailableContainerDatabases.HasValue;

        /// <summary>
        /// Gets and sets the property AvailableCpus. 
        /// <para>
        /// The number of CPU cores available for allocation to Autonomous Databases.
        /// </para>
        /// </summary>
        public float? AvailableCpus { get; set; }

        /// <summary>
        /// Checks to see if the AvailableCpus property is set.
        /// </summary>
        internal bool IsSetAvailableCpus() => this.AvailableCpus.HasValue;

        /// <summary>
        /// Gets and sets the property CloudAutonomousVmClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the Autonomous VM cluster.
        /// </para>
        /// </summary>
        public string CloudAutonomousVmClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the CloudAutonomousVmClusterArn property is set.
        /// </summary>
        internal bool IsSetCloudAutonomousVmClusterArn() => this.CloudAutonomousVmClusterArn != null;

        /// <summary>
        /// Gets and sets the property CloudAutonomousVmClusterId. 
        /// <para>
        /// The unique identifier of the Autonomous VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 64)]
        public string CloudAutonomousVmClusterId { get; set; }

        /// <summary>
        /// Checks to see if the CloudAutonomousVmClusterId property is set.
        /// </summary>
        internal bool IsSetCloudAutonomousVmClusterId() => this.CloudAutonomousVmClusterId != null;

        /// <summary>
        /// Gets and sets the property CloudExadataInfrastructureArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Cloud Exadata Infrastructure containing this
        /// Autonomous VM cluster.
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
        /// The unique identifier of the Cloud Exadata Infrastructure containing this Autonomous
        /// VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 2048)]
        public string CloudExadataInfrastructureId { get; set; }

        /// <summary>
        /// Checks to see if the CloudExadataInfrastructureId property is set.
        /// </summary>
        internal bool IsSetCloudExadataInfrastructureId() => this.CloudExadataInfrastructureId != null;

        /// <summary>
        /// Gets and sets the property ComputeModel. 
        /// <para>
        /// The compute model of the Autonomous VM cluster: ECPU or OCPU.
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
        /// The total number of CPU cores in the Autonomous VM cluster.
        /// </para>
        /// </summary>
        public int? CpuCoreCount { get; set; }

        /// <summary>
        /// Checks to see if the CpuCoreCount property is set.
        /// </summary>
        internal bool IsSetCpuCoreCount() => this.CpuCoreCount.HasValue;

        /// <summary>
        /// Gets and sets the property CpuCoreCountPerNode. 
        /// <para>
        /// The number of CPU cores enabled per node in the Autonomous VM cluster.
        /// </para>
        /// </summary>
        public int? CpuCoreCountPerNode { get; set; }

        /// <summary>
        /// Checks to see if the CpuCoreCountPerNode property is set.
        /// </summary>
        internal bool IsSetCpuCoreCountPerNode() => this.CpuCoreCountPerNode.HasValue;

        /// <summary>
        /// Gets and sets the property CpuPercentage. 
        /// <para>
        /// The percentage of total CPU cores currently in use in the Autonomous VM cluster.
        /// </para>
        /// </summary>
        public float? CpuPercentage { get; set; }

        /// <summary>
        /// Checks to see if the CpuPercentage property is set.
        /// </summary>
        internal bool IsSetCpuPercentage() => this.CpuPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the Autonomous VM cluster was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DataStorageSizeInGBs. 
        /// <para>
        /// The total data storage allocated to the Autonomous VM cluster, in GB.
        /// </para>
        /// </summary>
        public double? DataStorageSizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the DataStorageSizeInGBs property is set.
        /// </summary>
        internal bool IsSetDataStorageSizeInGBs() => this.DataStorageSizeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property DataStorageSizeInTBs. 
        /// <para>
        /// The total data storage allocated to the Autonomous VM cluster, in TB.
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
        /// The local node storage allocated to the Autonomous VM cluster, in gigabytes (GB).
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
        /// The list of database servers associated with the Autonomous VM cluster.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The user-provided description of the Autonomous VM cluster.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the Autonomous VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain name for the Autonomous VM cluster.
        /// </para>
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property ExadataStorageInTBsLowestScaledValue. 
        /// <para>
        /// The minimum value to which you can scale down the Exadata storage, in TB.
        /// </para>
        /// </summary>
        public double? ExadataStorageInTBsLowestScaledValue { get; set; }

        /// <summary>
        /// Checks to see if the ExadataStorageInTBsLowestScaledValue property is set.
        /// </summary>
        internal bool IsSetExadataStorageInTBsLowestScaledValue() => this.ExadataStorageInTBsLowestScaledValue.HasValue;

        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The hostname for the Autonomous VM cluster.
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
        /// with the Autonomous VM cluster.
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
        /// Gets and sets the property IsMtlsEnabledVmCluster. 
        /// <para>
        /// Indicates whether mutual TLS (mTLS) authentication is enabled for the Autonomous VM
        /// cluster.
        /// </para>
        /// </summary>
        public bool? IsMtlsEnabledVmCluster { get; set; }

        /// <summary>
        /// Checks to see if the IsMtlsEnabledVmCluster property is set.
        /// </summary>
        internal bool IsSetIsMtlsEnabledVmCluster() => this.IsMtlsEnabledVmCluster.HasValue;

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The Oracle license model that applies to the Autonomous VM cluster.
        /// </para>
        /// </summary>
        public LicenseModel LicenseModel { get; set; }

        /// <summary>
        /// Checks to see if the LicenseModel property is set.
        /// </summary>
        internal bool IsSetLicenseModel() => this.LicenseModel != null;

        /// <summary>
        /// Gets and sets the property MaintenanceWindow. 
        /// <para>
        /// The scheduling details for the maintenance window. Patching and system updates take
        /// place during the maintenance window.
        /// </para>
        /// </summary>
        public MaintenanceWindow MaintenanceWindow { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceWindow property is set.
        /// </summary>
        internal bool IsSetMaintenanceWindow() => this.MaintenanceWindow != null;

        /// <summary>
        /// Gets and sets the property MaxAcdsLowestScaledValue. 
        /// <para>
        /// The minimum value to which you can scale down the maximum number of Autonomous CDBs.
        /// </para>
        /// </summary>
        public int? MaxAcdsLowestScaledValue { get; set; }

        /// <summary>
        /// Checks to see if the MaxAcdsLowestScaledValue property is set.
        /// </summary>
        internal bool IsSetMaxAcdsLowestScaledValue() => this.MaxAcdsLowestScaledValue.HasValue;

        /// <summary>
        /// Gets and sets the property MemoryPerOracleComputeUnitInGBs. 
        /// <para>
        /// The amount of memory allocated per Oracle Compute Unit, in GB.
        /// </para>
        /// </summary>
        public int? MemoryPerOracleComputeUnitInGBs { get; set; }

        /// <summary>
        /// Checks to see if the MemoryPerOracleComputeUnitInGBs property is set.
        /// </summary>
        internal bool IsSetMemoryPerOracleComputeUnitInGBs() => this.MemoryPerOracleComputeUnitInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property MemorySizeInGBs. 
        /// <para>
        /// The total amount of memory allocated to the Autonomous VM cluster, in gigabytes (GB).
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
        /// The number of database server nodes in the Autonomous VM cluster.
        /// </para>
        /// </summary>
        public int? NodeCount { get; set; }

        /// <summary>
        /// Checks to see if the NodeCount property is set.
        /// </summary>
        internal bool IsSetNodeCount() => this.NodeCount.HasValue;

        /// <summary>
        /// Gets and sets the property NonProvisionableAutonomousContainerDatabases. 
        /// <para>
        /// The number of Autonomous CDBs that can't be provisioned because of resource constraints.
        /// </para>
        /// </summary>
        public int? NonProvisionableAutonomousContainerDatabases { get; set; }

        /// <summary>
        /// Checks to see if the NonProvisionableAutonomousContainerDatabases property is set.
        /// </summary>
        internal bool IsSetNonProvisionableAutonomousContainerDatabases() => this.NonProvisionableAutonomousContainerDatabases.HasValue;

        /// <summary>
        /// Gets and sets the property OciResourceAnchorName. 
        /// <para>
        /// The name of the OCI resource anchor associated with this Autonomous VM cluster.
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
        /// The URL for accessing the OCI console page for this Autonomous VM cluster.
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
        /// The Oracle Cloud Identifier (OCID) of the Autonomous VM cluster.
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
        /// The Amazon Resource Name (ARN) of the ODB network associated with this Autonomous
        /// VM cluster.
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
        /// The unique identifier of the ODB network associated with this Autonomous VM cluster.
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
        /// The progress of the current operation on the Autonomous VM cluster, as a percentage.
        /// </para>
        /// </summary>
        public float? PercentProgress { get; set; }

        /// <summary>
        /// Checks to see if the PercentProgress property is set.
        /// </summary>
        internal bool IsSetPercentProgress() => this.PercentProgress.HasValue;

        /// <summary>
        /// Gets and sets the property ProvisionableAutonomousContainerDatabases. 
        /// <para>
        /// The number of Autonomous CDBs that can be provisioned in the Autonomous VM cluster.
        /// </para>
        /// </summary>
        public int? ProvisionableAutonomousContainerDatabases { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionableAutonomousContainerDatabases property is set.
        /// </summary>
        internal bool IsSetProvisionableAutonomousContainerDatabases() => this.ProvisionableAutonomousContainerDatabases.HasValue;

        /// <summary>
        /// Gets and sets the property ProvisionedAutonomousContainerDatabases. 
        /// <para>
        /// The number of Autonomous CDBs currently provisioned in the Autonomous VM cluster.
        /// </para>
        /// </summary>
        public int? ProvisionedAutonomousContainerDatabases { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedAutonomousContainerDatabases property is set.
        /// </summary>
        internal bool IsSetProvisionedAutonomousContainerDatabases() => this.ProvisionedAutonomousContainerDatabases.HasValue;

        /// <summary>
        /// Gets and sets the property ProvisionedCpus. 
        /// <para>
        /// The number of CPU cores currently provisioned in the Autonomous VM cluster.
        /// </para>
        /// </summary>
        public float? ProvisionedCpus { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedCpus property is set.
        /// </summary>
        internal bool IsSetProvisionedCpus() => this.ProvisionedCpus.HasValue;

        /// <summary>
        /// Gets and sets the property ReclaimableCpus. 
        /// <para>
        /// The number of CPU cores that can be reclaimed from terminated or scaled-down Autonomous
        /// Databases.
        /// </para>
        /// </summary>
        public float? ReclaimableCpus { get; set; }

        /// <summary>
        /// Checks to see if the ReclaimableCpus property is set.
        /// </summary>
        internal bool IsSetReclaimableCpus() => this.ReclaimableCpus.HasValue;

        /// <summary>
        /// Gets and sets the property ReservedCpus. 
        /// <para>
        /// The number of CPU cores reserved for system operations and redundancy.
        /// </para>
        /// </summary>
        public float? ReservedCpus { get; set; }

        /// <summary>
        /// Checks to see if the ReservedCpus property is set.
        /// </summary>
        internal bool IsSetReservedCpus() => this.ReservedCpus.HasValue;

        /// <summary>
        /// Gets and sets the property ScanListenerPortNonTls. 
        /// <para>
        /// The SCAN listener port for non-TLS (TCP) protocol. The default is 1521.
        /// </para>
        /// </summary>
        public int? ScanListenerPortNonTls { get; set; }

        /// <summary>
        /// Checks to see if the ScanListenerPortNonTls property is set.
        /// </summary>
        internal bool IsSetScanListenerPortNonTls() => this.ScanListenerPortNonTls.HasValue;

        /// <summary>
        /// Gets and sets the property ScanListenerPortTls. 
        /// <para>
        /// The SCAN listener port for TLS (TCP) protocol. The default is 2484.
        /// </para>
        /// </summary>
        public int? ScanListenerPortTls { get; set; }

        /// <summary>
        /// Checks to see if the ScanListenerPortTls property is set.
        /// </summary>
        internal bool IsSetScanListenerPortTls() => this.ScanListenerPortTls.HasValue;

        /// <summary>
        /// Gets and sets the property Shape. 
        /// <para>
        /// The shape of the Exadata infrastructure for the Autonomous VM cluster.
        /// </para>
        /// </summary>
        public string Shape { get; set; }

        /// <summary>
        /// Checks to see if the Shape property is set.
        /// </summary>
        internal bool IsSetShape() => this.Shape != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the Autonomous VM cluster. Possible values include <c>CREATING</c>,
        /// <c>AVAILABLE</c>, <c>UPDATING</c>, <c>DELETING</c>, <c>DELETED</c>, <c>FAILED</c>.
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
        /// Additional information about the current status of the Autonomous VM cluster.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property TimeDatabaseSslCertificateExpires. 
        /// <para>
        /// The expiration date and time of the database SSL certificate.
        /// </para>
        /// </summary>
        public DateTime? TimeDatabaseSslCertificateExpires { get; set; }

        /// <summary>
        /// Checks to see if the TimeDatabaseSslCertificateExpires property is set.
        /// </summary>
        internal bool IsSetTimeDatabaseSslCertificateExpires() => this.TimeDatabaseSslCertificateExpires.HasValue;

        /// <summary>
        /// Gets and sets the property TimeOrdsCertificateExpires. 
        /// <para>
        /// The expiration date and time of the Oracle REST Data Services (ORDS) certificate.
        /// </para>
        /// </summary>
        public DateTime? TimeOrdsCertificateExpires { get; set; }

        /// <summary>
        /// Checks to see if the TimeOrdsCertificateExpires property is set.
        /// </summary>
        internal bool IsSetTimeOrdsCertificateExpires() => this.TimeOrdsCertificateExpires.HasValue;

        /// <summary>
        /// Gets and sets the property TimeZone. 
        /// <para>
        /// The time zone of the Autonomous VM cluster.
        /// </para>
        /// </summary>
        public string TimeZone { get; set; }

        /// <summary>
        /// Checks to see if the TimeZone property is set.
        /// </summary>
        internal bool IsSetTimeZone() => this.TimeZone != null;

        /// <summary>
        /// Gets and sets the property TotalContainerDatabases. 
        /// <para>
        /// The total number of Autonomous Container Databases that can be created with the allocated
        /// local storage.
        /// </para>
        /// </summary>
        public int? TotalContainerDatabases { get; set; }

        /// <summary>
        /// Checks to see if the TotalContainerDatabases property is set.
        /// </summary>
        internal bool IsSetTotalContainerDatabases() => this.TotalContainerDatabases.HasValue;
    }
}
