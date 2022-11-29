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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// The configuration updates for an Amazon FSx for NetApp ONTAP file system.
    /// </summary>
    public partial class UpdateFileSystemOntapConfiguration
    {
        private List<string> _addRouteTableIds = new List<string>();
        private int? _automaticBackupRetentionDays;
        private string _dailyAutomaticBackupStartTime;
        private DiskIopsConfiguration _diskIopsConfiguration;
        private string _fsxAdminPassword;
        private List<string> _removeRouteTableIds = new List<string>();
        private int? _throughputCapacity;
        private string _weeklyMaintenanceStartTime;

        /// <summary>
        /// Gets and sets the property AddRouteTableIds. 
        /// <para>
        /// (Multi-AZ only) A list of IDs of new virtual private cloud (VPC) route tables to associate
        /// (add) with your Amazon FSx for NetApp ONTAP file system.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> AddRouteTableIds
        {
            get { return this._addRouteTableIds; }
            set { this._addRouteTableIds = value; }
        }

        // Check to see if AddRouteTableIds property is set
        internal bool IsSetAddRouteTableIds()
        {
            return this._addRouteTableIds != null && this._addRouteTableIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AutomaticBackupRetentionDays.
        /// </summary>
        [AWSProperty(Min=0, Max=90)]
        public int AutomaticBackupRetentionDays
        {
            get { return this._automaticBackupRetentionDays.GetValueOrDefault(); }
            set { this._automaticBackupRetentionDays = value; }
        }

        // Check to see if AutomaticBackupRetentionDays property is set
        internal bool IsSetAutomaticBackupRetentionDays()
        {
            return this._automaticBackupRetentionDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DailyAutomaticBackupStartTime.
        /// </summary>
        [AWSProperty(Min=5, Max=5)]
        public string DailyAutomaticBackupStartTime
        {
            get { return this._dailyAutomaticBackupStartTime; }
            set { this._dailyAutomaticBackupStartTime = value; }
        }

        // Check to see if DailyAutomaticBackupStartTime property is set
        internal bool IsSetDailyAutomaticBackupStartTime()
        {
            return this._dailyAutomaticBackupStartTime != null;
        }

        /// <summary>
        /// Gets and sets the property DiskIopsConfiguration. 
        /// <para>
        /// The SSD IOPS (input/output operations per second) configuration for an Amazon FSx
        /// for NetApp ONTAP file system. The default is 3 IOPS per GB of storage capacity, but
        /// you can provision additional IOPS per GB of storage. The configuration consists of
        /// an IOPS mode (<code>AUTOMATIC</code> or <code>USER_PROVISIONED</code>), and in the
        /// case of <code>USER_PROVISIONED</code> IOPS, the total number of SSD IOPS provisioned.
        /// </para>
        /// </summary>
        public DiskIopsConfiguration DiskIopsConfiguration
        {
            get { return this._diskIopsConfiguration; }
            set { this._diskIopsConfiguration = value; }
        }

        // Check to see if DiskIopsConfiguration property is set
        internal bool IsSetDiskIopsConfiguration()
        {
            return this._diskIopsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property FsxAdminPassword. 
        /// <para>
        /// The ONTAP administrative password for the <code>fsxadmin</code> user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=50)]
        public string FsxAdminPassword
        {
            get { return this._fsxAdminPassword; }
            set { this._fsxAdminPassword = value; }
        }

        // Check to see if FsxAdminPassword property is set
        internal bool IsSetFsxAdminPassword()
        {
            return this._fsxAdminPassword != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveRouteTableIds. 
        /// <para>
        /// (Multi-AZ only) A list of IDs of existing virtual private cloud (VPC) route tables
        /// to disassociate (remove) from your Amazon FSx for NetApp ONTAP file system. You can
        /// use the API operation to retrieve the list of VPC route table IDs for a file system.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> RemoveRouteTableIds
        {
            get { return this._removeRouteTableIds; }
            set { this._removeRouteTableIds = value; }
        }

        // Check to see if RemoveRouteTableIds property is set
        internal bool IsSetRemoveRouteTableIds()
        {
            return this._removeRouteTableIds != null && this._removeRouteTableIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ThroughputCapacity. 
        /// <para>
        /// Specifies the throughput of an FSx for NetApp ONTAP file system, measured in megabytes
        /// per second (MBps). Valid values are 128, 256, 512, 1024, 2048, and 4096 MBps.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=100000)]
        public int ThroughputCapacity
        {
            get { return this._throughputCapacity.GetValueOrDefault(); }
            set { this._throughputCapacity = value; }
        }

        // Check to see if ThroughputCapacity property is set
        internal bool IsSetThroughputCapacity()
        {
            return this._throughputCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WeeklyMaintenanceStartTime.
        /// </summary>
        [AWSProperty(Min=7, Max=7)]
        public string WeeklyMaintenanceStartTime
        {
            get { return this._weeklyMaintenanceStartTime; }
            set { this._weeklyMaintenanceStartTime = value; }
        }

        // Check to see if WeeklyMaintenanceStartTime property is set
        internal bool IsSetWeeklyMaintenanceStartTime()
        {
            return this._weeklyMaintenanceStartTime != null;
        }

    }
}