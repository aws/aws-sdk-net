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
    /// Information about a DB node.
    /// </summary>
    public partial class DbNodeSummary
    {
        /// <summary>
        /// Gets and sets the property AdditionalDetails. 
        /// <para>
        /// Additional information about the planned maintenance.
        /// </para>
        /// </summary>
        public string AdditionalDetails { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalDetails property is set.
        /// </summary>
        internal bool IsSetAdditionalDetails() => this.AdditionalDetails != null;

        /// <summary>
        /// Gets and sets the property BackupIpId. 
        /// <para>
        /// The Oracle Cloud ID (OCID) of the backup IP address that's associated with the DB
        /// node.
        /// </para>
        /// </summary>
        public string BackupIpId { get; set; }

        /// <summary>
        /// Checks to see if the BackupIpId property is set.
        /// </summary>
        internal bool IsSetBackupIpId() => this.BackupIpId != null;

        /// <summary>
        /// Gets and sets the property BackupVnic2Id. 
        /// <para>
        /// The OCID of the second backup virtual network interface card (VNIC) for the DB node.
        /// </para>
        /// </summary>
        public string BackupVnic2Id { get; set; }

        /// <summary>
        /// Checks to see if the BackupVnic2Id property is set.
        /// </summary>
        internal bool IsSetBackupVnic2Id() => this.BackupVnic2Id != null;

        /// <summary>
        /// Gets and sets the property BackupVnicId. 
        /// <para>
        /// The OCID of the backup VNIC for the DB node.
        /// </para>
        /// </summary>
        public string BackupVnicId { get; set; }

        /// <summary>
        /// Checks to see if the BackupVnicId property is set.
        /// </summary>
        internal bool IsSetBackupVnicId() => this.BackupVnicId != null;

        /// <summary>
        /// Gets and sets the property CpuCoreCount. 
        /// <para>
        /// The number of CPU cores enabled on the DB node.
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
        /// The date and time when the DB node was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DbNodeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the DB node.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string DbNodeArn { get; set; }

        /// <summary>
        /// Checks to see if the DbNodeArn property is set.
        /// </summary>
        internal bool IsSetDbNodeArn() => this.DbNodeArn != null;

        /// <summary>
        /// Gets and sets the property DbNodeId. 
        /// <para>
        /// The unique identifier of the DB node.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 64)]
        public string DbNodeId { get; set; }

        /// <summary>
        /// Checks to see if the DbNodeId property is set.
        /// </summary>
        internal bool IsSetDbNodeId() => this.DbNodeId != null;

        /// <summary>
        /// Gets and sets the property DbNodeStorageSizeInGBs. 
        /// <para>
        /// The amount of local node storage, in gigabytes (GB), that's allocated on the DB node.
        /// </para>
        /// </summary>
        public int? DbNodeStorageSizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the DbNodeStorageSizeInGBs property is set.
        /// </summary>
        internal bool IsSetDbNodeStorageSizeInGBs() => this.DbNodeStorageSizeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property DbServerId. 
        /// <para>
        /// The unique identifier of the database server that's associated with the DB node.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 64)]
        public string DbServerId { get; set; }

        /// <summary>
        /// Checks to see if the DbServerId property is set.
        /// </summary>
        internal bool IsSetDbServerId() => this.DbServerId != null;

        /// <summary>
        /// Gets and sets the property DbSystemId. 
        /// <para>
        /// The OCID of the DB system.
        /// </para>
        /// </summary>
        public string DbSystemId { get; set; }

        /// <summary>
        /// Checks to see if the DbSystemId property is set.
        /// </summary>
        internal bool IsSetDbSystemId() => this.DbSystemId != null;

        /// <summary>
        /// Gets and sets the property FaultDomain. 
        /// <para>
        /// The name of the fault domain where the DB node is located.
        /// </para>
        /// </summary>
        public string FaultDomain { get; set; }

        /// <summary>
        /// Checks to see if the FaultDomain property is set.
        /// </summary>
        internal bool IsSetFaultDomain() => this.FaultDomain != null;

        /// <summary>
        /// Gets and sets the property HostIpId. 
        /// <para>
        /// The OCID of the host IP address that's associated with the DB node.
        /// </para>
        /// </summary>
        public string HostIpId { get; set; }

        /// <summary>
        /// Checks to see if the HostIpId property is set.
        /// </summary>
        internal bool IsSetHostIpId() => this.HostIpId != null;

        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The host name for the DB node.
        /// </para>
        /// </summary>
        public string Hostname { get; set; }

        /// <summary>
        /// Checks to see if the Hostname property is set.
        /// </summary>
        internal bool IsSetHostname() => this.Hostname != null;

        /// <summary>
        /// Gets and sets the property MaintenanceType. 
        /// <para>
        /// The type of maintenance the DB node. 
        /// </para>
        /// </summary>
        public DbNodeMaintenanceType MaintenanceType { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceType property is set.
        /// </summary>
        internal bool IsSetMaintenanceType() => this.MaintenanceType != null;

        /// <summary>
        /// Gets and sets the property MemorySizeInGBs. 
        /// <para>
        /// The amount of memory, in gigabytes (GB), that allocated on the DB node.
        /// </para>
        /// </summary>
        public int? MemorySizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the MemorySizeInGBs property is set.
        /// </summary>
        internal bool IsSetMemorySizeInGBs() => this.MemorySizeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property OciResourceAnchorName. 
        /// <para>
        /// The name of the OCI resource anchor for the DB node.
        /// </para>
        /// </summary>
        public string OciResourceAnchorName { get; set; }

        /// <summary>
        /// Checks to see if the OciResourceAnchorName property is set.
        /// </summary>
        internal bool IsSetOciResourceAnchorName() => this.OciResourceAnchorName != null;

        /// <summary>
        /// Gets and sets the property Ocid. 
        /// <para>
        /// The OCID of the DB node.
        /// </para>
        /// </summary>
        public string Ocid { get; set; }

        /// <summary>
        /// Checks to see if the Ocid property is set.
        /// </summary>
        internal bool IsSetOcid() => this.Ocid != null;

        /// <summary>
        /// Gets and sets the property SoftwareStorageSizeInGB. 
        /// <para>
        /// The size of the block storage volume, in gigabytes (GB), that's allocated for the
        /// DB system. This attribute applies only for virtual machine DB systems.
        /// </para>
        /// </summary>
        public int? SoftwareStorageSizeInGB { get; set; }

        /// <summary>
        /// Checks to see if the SoftwareStorageSizeInGB property is set.
        /// </summary>
        internal bool IsSetSoftwareStorageSizeInGB() => this.SoftwareStorageSizeInGB.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the DB node.
        /// </para>
        /// </summary>
        public DbNodeResourceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information about the status of the DB node.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property TimeMaintenanceWindowEnd. 
        /// <para>
        /// The end date and time of the maintenance window.
        /// </para>
        /// </summary>
        public string TimeMaintenanceWindowEnd { get; set; }

        /// <summary>
        /// Checks to see if the TimeMaintenanceWindowEnd property is set.
        /// </summary>
        internal bool IsSetTimeMaintenanceWindowEnd() => this.TimeMaintenanceWindowEnd != null;

        /// <summary>
        /// Gets and sets the property TimeMaintenanceWindowStart. 
        /// <para>
        /// The start date and time of the maintenance window.
        /// </para>
        /// </summary>
        public string TimeMaintenanceWindowStart { get; set; }

        /// <summary>
        /// Checks to see if the TimeMaintenanceWindowStart property is set.
        /// </summary>
        internal bool IsSetTimeMaintenanceWindowStart() => this.TimeMaintenanceWindowStart != null;

        /// <summary>
        /// Gets and sets the property TotalCpuCoreCount. 
        /// <para>
        /// The total number of CPU cores reserved on the DB node.
        /// </para>
        /// </summary>
        public int? TotalCpuCoreCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalCpuCoreCount property is set.
        /// </summary>
        internal bool IsSetTotalCpuCoreCount() => this.TotalCpuCoreCount.HasValue;

        /// <summary>
        /// Gets and sets the property Vnic2Id. 
        /// <para>
        /// The OCID of the second VNIC.
        /// </para>
        /// </summary>
        public string Vnic2Id { get; set; }

        /// <summary>
        /// Checks to see if the Vnic2Id property is set.
        /// </summary>
        internal bool IsSetVnic2Id() => this.Vnic2Id != null;

        /// <summary>
        /// Gets and sets the property VnicId. 
        /// <para>
        /// The OCID of the VNIC.
        /// </para>
        /// </summary>
        public string VnicId { get; set; }

        /// <summary>
        /// Checks to see if the VnicId property is set.
        /// </summary>
        internal bool IsSetVnicId() => this.VnicId != null;
    }
}
