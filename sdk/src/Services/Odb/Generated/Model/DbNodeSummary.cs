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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
        private string _additionalDetails;
        private string _backupIpId;
        private string _backupVnic2Id;
        private string _backupVnicId;
        private int? _cpuCoreCount;
        private DateTime? _createdAt;
        private string _dbNodeArn;
        private string _dbNodeId;
        private int? _dbNodeStorageSizeInGBs;
        private string _dbServerId;
        private string _dbSystemId;
        private string _faultDomain;
        private string _hostIpId;
        private string _hostname;
        private DbNodeMaintenanceType _maintenanceType;
        private int? _memorySizeInGBs;
        private string _ocid;
        private string _ociResourceAnchorName;
        private int? _softwareStorageSizeInGB;
        private DbNodeResourceStatus _status;
        private string _statusReason;
        private string _timeMaintenanceWindowEnd;
        private string _timeMaintenanceWindowStart;
        private int? _totalCpuCoreCount;
        private string _vnic2Id;
        private string _vnicId;

        /// <summary>
        /// Gets and sets the property AdditionalDetails. 
        /// <para>
        /// Additional information about the planned maintenance.
        /// </para>
        /// </summary>
        public string AdditionalDetails
        {
            get { return this._additionalDetails; }
            set { this._additionalDetails = value; }
        }

        // Check to see if AdditionalDetails property is set
        internal bool IsSetAdditionalDetails()
        {
            return this._additionalDetails != null;
        }

        /// <summary>
        /// Gets and sets the property BackupIpId. 
        /// <para>
        /// The Oracle Cloud ID (OCID) of the backup IP address that's associated with the DB
        /// node.
        /// </para>
        /// </summary>
        public string BackupIpId
        {
            get { return this._backupIpId; }
            set { this._backupIpId = value; }
        }

        // Check to see if BackupIpId property is set
        internal bool IsSetBackupIpId()
        {
            return this._backupIpId != null;
        }

        /// <summary>
        /// Gets and sets the property BackupVnic2Id. 
        /// <para>
        /// The OCID of the second backup virtual network interface card (VNIC) for the DB node.
        /// </para>
        /// </summary>
        public string BackupVnic2Id
        {
            get { return this._backupVnic2Id; }
            set { this._backupVnic2Id = value; }
        }

        // Check to see if BackupVnic2Id property is set
        internal bool IsSetBackupVnic2Id()
        {
            return this._backupVnic2Id != null;
        }

        /// <summary>
        /// Gets and sets the property BackupVnicId. 
        /// <para>
        /// The OCID of the backup VNIC for the DB node.
        /// </para>
        /// </summary>
        public string BackupVnicId
        {
            get { return this._backupVnicId; }
            set { this._backupVnicId = value; }
        }

        // Check to see if BackupVnicId property is set
        internal bool IsSetBackupVnicId()
        {
            return this._backupVnicId != null;
        }

        /// <summary>
        /// Gets and sets the property CpuCoreCount. 
        /// <para>
        /// The number of CPU cores enabled on the DB node.
        /// </para>
        /// </summary>
        public int? CpuCoreCount
        {
            get { return this._cpuCoreCount; }
            set { this._cpuCoreCount = value; }
        }

        // Check to see if CpuCoreCount property is set
        internal bool IsSetCpuCoreCount()
        {
            return this._cpuCoreCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the DB node was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DbNodeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the DB node.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string DbNodeArn
        {
            get { return this._dbNodeArn; }
            set { this._dbNodeArn = value; }
        }

        // Check to see if DbNodeArn property is set
        internal bool IsSetDbNodeArn()
        {
            return this._dbNodeArn != null;
        }

        /// <summary>
        /// Gets and sets the property DbNodeId. 
        /// <para>
        /// The unique identifier of the DB node.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=64)]
        public string DbNodeId
        {
            get { return this._dbNodeId; }
            set { this._dbNodeId = value; }
        }

        // Check to see if DbNodeId property is set
        internal bool IsSetDbNodeId()
        {
            return this._dbNodeId != null;
        }

        /// <summary>
        /// Gets and sets the property DbNodeStorageSizeInGBs. 
        /// <para>
        /// The amount of local node storage, in gigabytes (GB), that's allocated on the DB node.
        /// </para>
        /// </summary>
        public int? DbNodeStorageSizeInGBs
        {
            get { return this._dbNodeStorageSizeInGBs; }
            set { this._dbNodeStorageSizeInGBs = value; }
        }

        // Check to see if DbNodeStorageSizeInGBs property is set
        internal bool IsSetDbNodeStorageSizeInGBs()
        {
            return this._dbNodeStorageSizeInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DbServerId. 
        /// <para>
        /// The unique identifier of the database server that's associated with the DB node.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=64)]
        public string DbServerId
        {
            get { return this._dbServerId; }
            set { this._dbServerId = value; }
        }

        // Check to see if DbServerId property is set
        internal bool IsSetDbServerId()
        {
            return this._dbServerId != null;
        }

        /// <summary>
        /// Gets and sets the property DbSystemId. 
        /// <para>
        /// The OCID of the DB system.
        /// </para>
        /// </summary>
        public string DbSystemId
        {
            get { return this._dbSystemId; }
            set { this._dbSystemId = value; }
        }

        // Check to see if DbSystemId property is set
        internal bool IsSetDbSystemId()
        {
            return this._dbSystemId != null;
        }

        /// <summary>
        /// Gets and sets the property FaultDomain. 
        /// <para>
        /// The name of the fault domain where the DB node is located.
        /// </para>
        /// </summary>
        public string FaultDomain
        {
            get { return this._faultDomain; }
            set { this._faultDomain = value; }
        }

        // Check to see if FaultDomain property is set
        internal bool IsSetFaultDomain()
        {
            return this._faultDomain != null;
        }

        /// <summary>
        /// Gets and sets the property HostIpId. 
        /// <para>
        /// The OCID of the host IP address that's associated with the DB node.
        /// </para>
        /// </summary>
        public string HostIpId
        {
            get { return this._hostIpId; }
            set { this._hostIpId = value; }
        }

        // Check to see if HostIpId property is set
        internal bool IsSetHostIpId()
        {
            return this._hostIpId != null;
        }

        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The host name for the DB node.
        /// </para>
        /// </summary>
        public string Hostname
        {
            get { return this._hostname; }
            set { this._hostname = value; }
        }

        // Check to see if Hostname property is set
        internal bool IsSetHostname()
        {
            return this._hostname != null;
        }

        /// <summary>
        /// Gets and sets the property MaintenanceType. 
        /// <para>
        /// The type of maintenance the DB node. 
        /// </para>
        /// </summary>
        public DbNodeMaintenanceType MaintenanceType
        {
            get { return this._maintenanceType; }
            set { this._maintenanceType = value; }
        }

        // Check to see if MaintenanceType property is set
        internal bool IsSetMaintenanceType()
        {
            return this._maintenanceType != null;
        }

        /// <summary>
        /// Gets and sets the property MemorySizeInGBs. 
        /// <para>
        /// The amount of memory, in gigabytes (GB), that allocated on the DB node.
        /// </para>
        /// </summary>
        public int? MemorySizeInGBs
        {
            get { return this._memorySizeInGBs; }
            set { this._memorySizeInGBs = value; }
        }

        // Check to see if MemorySizeInGBs property is set
        internal bool IsSetMemorySizeInGBs()
        {
            return this._memorySizeInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ocid. 
        /// <para>
        /// The OCID of the DB node.
        /// </para>
        /// </summary>
        public string Ocid
        {
            get { return this._ocid; }
            set { this._ocid = value; }
        }

        // Check to see if Ocid property is set
        internal bool IsSetOcid()
        {
            return this._ocid != null;
        }

        /// <summary>
        /// Gets and sets the property OciResourceAnchorName. 
        /// <para>
        /// The name of the OCI resource anchor for the DB node.
        /// </para>
        /// </summary>
        public string OciResourceAnchorName
        {
            get { return this._ociResourceAnchorName; }
            set { this._ociResourceAnchorName = value; }
        }

        // Check to see if OciResourceAnchorName property is set
        internal bool IsSetOciResourceAnchorName()
        {
            return this._ociResourceAnchorName != null;
        }

        /// <summary>
        /// Gets and sets the property SoftwareStorageSizeInGB. 
        /// <para>
        /// The size of the block storage volume, in gigabytes (GB), that's allocated for the
        /// DB system. This attribute applies only for virtual machine DB systems.
        /// </para>
        /// </summary>
        public int? SoftwareStorageSizeInGB
        {
            get { return this._softwareStorageSizeInGB; }
            set { this._softwareStorageSizeInGB = value; }
        }

        // Check to see if SoftwareStorageSizeInGB property is set
        internal bool IsSetSoftwareStorageSizeInGB()
        {
            return this._softwareStorageSizeInGB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the DB node.
        /// </para>
        /// </summary>
        public DbNodeResourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information about the status of the DB node.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property TimeMaintenanceWindowEnd. 
        /// <para>
        /// The end date and time of the maintenance window.
        /// </para>
        /// </summary>
        public string TimeMaintenanceWindowEnd
        {
            get { return this._timeMaintenanceWindowEnd; }
            set { this._timeMaintenanceWindowEnd = value; }
        }

        // Check to see if TimeMaintenanceWindowEnd property is set
        internal bool IsSetTimeMaintenanceWindowEnd()
        {
            return this._timeMaintenanceWindowEnd != null;
        }

        /// <summary>
        /// Gets and sets the property TimeMaintenanceWindowStart. 
        /// <para>
        /// The start date and time of the maintenance window.
        /// </para>
        /// </summary>
        public string TimeMaintenanceWindowStart
        {
            get { return this._timeMaintenanceWindowStart; }
            set { this._timeMaintenanceWindowStart = value; }
        }

        // Check to see if TimeMaintenanceWindowStart property is set
        internal bool IsSetTimeMaintenanceWindowStart()
        {
            return this._timeMaintenanceWindowStart != null;
        }

        /// <summary>
        /// Gets and sets the property TotalCpuCoreCount. 
        /// <para>
        /// The total number of CPU cores reserved on the DB node.
        /// </para>
        /// </summary>
        public int? TotalCpuCoreCount
        {
            get { return this._totalCpuCoreCount; }
            set { this._totalCpuCoreCount = value; }
        }

        // Check to see if TotalCpuCoreCount property is set
        internal bool IsSetTotalCpuCoreCount()
        {
            return this._totalCpuCoreCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Vnic2Id. 
        /// <para>
        /// The OCID of the second VNIC.
        /// </para>
        /// </summary>
        public string Vnic2Id
        {
            get { return this._vnic2Id; }
            set { this._vnic2Id = value; }
        }

        // Check to see if Vnic2Id property is set
        internal bool IsSetVnic2Id()
        {
            return this._vnic2Id != null;
        }

        /// <summary>
        /// Gets and sets the property VnicId. 
        /// <para>
        /// The OCID of the VNIC.
        /// </para>
        /// </summary>
        public string VnicId
        {
            get { return this._vnicId; }
            set { this._vnicId = value; }
        }

        // Check to see if VnicId property is set
        internal bool IsSetVnicId()
        {
            return this._vnicId != null;
        }

    }
}