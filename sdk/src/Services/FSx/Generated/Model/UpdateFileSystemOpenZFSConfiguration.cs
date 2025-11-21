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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.FSx.Model
{
    /// <summary>
    /// The configuration updates for an Amazon FSx for OpenZFS file system.
    /// </summary>
    public partial class UpdateFileSystemOpenZFSConfiguration
    {
        private List<string> _addRouteTableIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _automaticBackupRetentionDays;
        private bool? _copyTagsToBackups;
        private bool? _copyTagsToVolumes;
        private string _dailyAutomaticBackupStartTime;
        private DiskIopsConfiguration _diskIopsConfiguration;
        private string _endpointIpv6AddressRange;
        private OpenZFSReadCacheConfiguration _readCacheConfiguration;
        private List<string> _removeRouteTableIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _throughputCapacity;
        private string _weeklyMaintenanceStartTime;

        /// <summary>
        /// Gets and sets the property AddRouteTableIds. 
        /// <para>
        /// (Multi-AZ only) A list of IDs of new virtual private cloud (VPC) route tables to associate
        /// (add) with your Amazon FSx for OpenZFS file system.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._addRouteTableIds != null && (this._addRouteTableIds.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property CopyTagsToBackups. 
        /// <para>
        /// A Boolean value indicating whether tags for the file system should be copied to backups.
        /// This value defaults to <c>false</c>. If it's set to <c>true</c>, all tags for the
        /// file system are copied to all automatic and user-initiated backups where the user
        /// doesn't specify tags. If this value is <c>true</c> and you specify one or more tags,
        /// only the specified tags are copied to backups. If you specify one or more tags when
        /// creating a user-initiated backup, no tags are copied from the file system, regardless
        /// of this value.
        /// </para>
        /// </summary>
        public bool? CopyTagsToBackups
        {
            get { return this._copyTagsToBackups; }
            set { this._copyTagsToBackups = value; }
        }

        // Check to see if CopyTagsToBackups property is set
        internal bool IsSetCopyTagsToBackups()
        {
            return this._copyTagsToBackups.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CopyTagsToVolumes. 
        /// <para>
        /// A Boolean value indicating whether tags for the volume should be copied to snapshots.
        /// This value defaults to <c>false</c>. If it's set to <c>true</c>, all tags for the
        /// volume are copied to snapshots where the user doesn't specify tags. If this value
        /// is <c>true</c> and you specify one or more tags, only the specified tags are copied
        /// to snapshots. If you specify one or more tags when creating the snapshot, no tags
        /// are copied from the volume, regardless of this value.
        /// </para>
        /// </summary>
        public bool? CopyTagsToVolumes
        {
            get { return this._copyTagsToVolumes; }
            set { this._copyTagsToVolumes = value; }
        }

        // Check to see if CopyTagsToVolumes property is set
        internal bool IsSetCopyTagsToVolumes()
        {
            return this._copyTagsToVolumes.HasValue; 
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
        /// Gets and sets the property EndpointIpv6AddressRange. 
        /// <para>
        /// (Multi-AZ only) Specifies the IPv6 address range in which the endpoints to access
        /// your file system will be created. By default in the Amazon FSx API and Amazon FSx
        /// console, Amazon FSx selects an available /118 IP address range for you from one of
        /// the VPC's CIDR ranges. You can have overlapping endpoint IP addresses for file systems
        /// deployed in the same VPC/route tables, as long as they don't overlap with any subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=43)]
        public string EndpointIpv6AddressRange
        {
            get { return this._endpointIpv6AddressRange; }
            set { this._endpointIpv6AddressRange = value; }
        }

        // Check to see if EndpointIpv6AddressRange property is set
        internal bool IsSetEndpointIpv6AddressRange()
        {
            return this._endpointIpv6AddressRange != null;
        }

        /// <summary>
        /// Gets and sets the property ReadCacheConfiguration. 
        /// <para>
        ///  The configuration for the optional provisioned SSD read cache on file systems that
        /// use the Intelligent-Tiering storage class.
        /// </para>
        /// </summary>
        public OpenZFSReadCacheConfiguration ReadCacheConfiguration
        {
            get { return this._readCacheConfiguration; }
            set { this._readCacheConfiguration = value; }
        }

        // Check to see if ReadCacheConfiguration property is set
        internal bool IsSetReadCacheConfiguration()
        {
            return this._readCacheConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveRouteTableIds. 
        /// <para>
        /// (Multi-AZ only) A list of IDs of existing virtual private cloud (VPC) route tables
        /// to disassociate (remove) from your Amazon FSx for OpenZFS file system. You can use
        /// the API operation to retrieve the list of VPC route table IDs for a file system.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._removeRouteTableIds != null && (this._removeRouteTableIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ThroughputCapacity. 
        /// <para>
        /// The throughput of an Amazon FSx for OpenZFS file system, measured in megabytes per
        /// second&#x2028; (MB/s). Valid values depend on the DeploymentType you choose, as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>MULTI_AZ_1</c> and <c>SINGLE_AZ_2</c>, valid values are 160, 320, 640, 1280,
        /// 2560, 3840, 5120, 7680, or 10240 MB/s.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>SINGLE_AZ_1</c>, valid values are 64, 128, 256, 512, 1024, 2048, 3072, or 4096
        /// MB/s.
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