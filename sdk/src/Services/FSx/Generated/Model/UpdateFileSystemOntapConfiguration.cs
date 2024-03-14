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
        private int? _throughputCapacityPerHAPair;
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
        public int? AutomaticBackupRetentionDays
        {
            get { return this._automaticBackupRetentionDays; }
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
        /// The SSD IOPS (input output operations per second) configuration for an Amazon FSx
        /// for NetApp ONTAP file system. The default is 3 IOPS per GB of storage capacity, but
        /// you can provision additional IOPS per GB of storage. The configuration consists of
        /// an IOPS mode (<c>AUTOMATIC</c> or <c>USER_PROVISIONED</c>), and in the case of <c>USER_PROVISIONED</c>
        /// IOPS, the total number of SSD IOPS provisioned. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/increase-primary-storage.html">Updating
        /// SSD storage capacity and IOPS</a>.
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
        /// Update the password for the <c>fsxadmin</c> user by entering a new password. You use
        /// the <c>fsxadmin</c> user to access the NetApp ONTAP CLI and REST API to manage your
        /// file system resources. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/managing-resources-ontap-apps.html">Managing
        /// resources using NetApp Applicaton</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=8, Max=50)]
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
        /// Enter a new value to change the amount of throughput capacity for the file system
        /// in megabytes per second (MBps). For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/managing-throughput-capacity.html">Managing
        /// throughput capacity</a> in the FSx for ONTAP User Guide.
        /// </para>
        ///  
        /// <para>
        /// Amazon FSx responds with an HTTP status code 400 (Bad Request) for the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The value of <c>ThroughputCapacity</c> and <c>ThroughputCapacityPerHAPair</c> are
        /// not the same value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The value of <c>ThroughputCapacity</c> when divided by the value of <c>HAPairs</c>
        /// is outside of the valid range for <c>ThroughputCapacity</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=8, Max=100000)]
        public int? ThroughputCapacity
        {
            get { return this._throughputCapacity; }
            set { this._throughputCapacity = value; }
        }

        // Check to see if ThroughputCapacity property is set
        internal bool IsSetThroughputCapacity()
        {
            return this._throughputCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThroughputCapacityPerHAPair. 
        /// <para>
        /// Use to choose the throughput capacity per HA pair, rather than the total throughput
        /// for the file system. 
        /// </para>
        ///  
        /// <para>
        /// This field and <c>ThroughputCapacity</c> cannot be defined in the same API call, but
        /// one is required.
        /// </para>
        ///  
        /// <para>
        /// This field and <c>ThroughputCapacity</c> are the same for file systems with one HA
        /// pair.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>SINGLE_AZ_1</c> and <c>MULTI_AZ_1</c>, valid values are 128, 256, 512, 1024,
        /// 2048, or 4096 MBps.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>SINGLE_AZ_2</c>, valid values are 3072 or 6144 MBps.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon FSx responds with an HTTP status code 400 (Bad Request) for the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The value of <c>ThroughputCapacity</c> and <c>ThroughputCapacityPerHAPair</c> are
        /// not the same value for file systems with one HA pair.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The value of deployment type is <c>SINGLE_AZ_2</c> and <c>ThroughputCapacity</c> /
        /// <c>ThroughputCapacityPerHAPair</c> is a valid HA pair (a value between 2 and 6).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The value of <c>ThroughputCapacityPerHAPair</c> is not a valid value.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=128, Max=6144)]
        public int? ThroughputCapacityPerHAPair
        {
            get { return this._throughputCapacityPerHAPair; }
            set { this._throughputCapacityPerHAPair = value; }
        }

        // Check to see if ThroughputCapacityPerHAPair property is set
        internal bool IsSetThroughputCapacityPerHAPair()
        {
            return this._throughputCapacityPerHAPair.HasValue; 
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