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
    /// The configuration for the Amazon FSx for OpenZFS file system.
    /// </summary>
    public partial class OpenZFSFileSystemConfiguration
    {
        private int? _automaticBackupRetentionDays;
        private bool? _copyTagsToBackups;
        private bool? _copyTagsToVolumes;
        private string _dailyAutomaticBackupStartTime;
        private OpenZFSDeploymentType _deploymentType;
        private DiskIopsConfiguration _diskIopsConfiguration;
        private string _endpointIpAddress;
        private string _endpointIpAddressRange;
        private string _endpointIpv6Address;
        private string _endpointIpv6AddressRange;
        private string _preferredSubnetId;
        private OpenZFSReadCacheConfiguration _readCacheConfiguration;
        private string _rootVolumeId;
        private List<string> _routeTableIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _throughputCapacity;
        private string _weeklyMaintenanceStartTime;

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
        /// A Boolean value indicating whether tags on the file system should be copied to backups.
        /// If it's set to <c>true</c>, all tags on the file system are copied to all automatic
        /// backups and any user-initiated backups where the user doesn't specify any tags. If
        /// this value is <c>true</c> and you specify one or more tags, only the specified tags
        /// are copied to backups. If you specify one or more tags when creating a user-initiated
        /// backup, no tags are copied from the file system, regardless of this value. 
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
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// Specifies the file-system deployment type. Amazon FSx for OpenZFS supports&#x2028;
        /// <c>MULTI_AZ_1</c>, <c>SINGLE_AZ_HA_2</c>, <c>SINGLE_AZ_HA_1</c>, <c>SINGLE_AZ_2</c>,
        /// and <c>SINGLE_AZ_1</c>.
        /// </para>
        /// </summary>
        public OpenZFSDeploymentType DeploymentType
        {
            get { return this._deploymentType; }
            set { this._deploymentType = value; }
        }

        // Check to see if DeploymentType property is set
        internal bool IsSetDeploymentType()
        {
            return this._deploymentType != null;
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
        /// Gets and sets the property EndpointIpAddress. 
        /// <para>
        /// The IPv4 address of the endpoint that is used to access data or to manage the file
        /// system.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=45)]
        public string EndpointIpAddress
        {
            get { return this._endpointIpAddress; }
            set { this._endpointIpAddress = value; }
        }

        // Check to see if EndpointIpAddress property is set
        internal bool IsSetEndpointIpAddress()
        {
            return this._endpointIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointIpAddressRange. 
        /// <para>
        /// (Multi-AZ only) Specifies the IPv4 address range in which the endpoints to access
        /// your file system will be created. By default in the Amazon FSx API and Amazon FSx
        /// console, Amazon FSx selects an available /28 IP address range for you from one of
        /// the VPC's CIDR ranges. You can have overlapping endpoint IP addresses for file systems
        /// deployed in the same VPC/route tables.
        /// </para>
        /// </summary>
        [AWSProperty(Min=9, Max=17)]
        public string EndpointIpAddressRange
        {
            get { return this._endpointIpAddressRange; }
            set { this._endpointIpAddressRange = value; }
        }

        // Check to see if EndpointIpAddressRange property is set
        internal bool IsSetEndpointIpAddressRange()
        {
            return this._endpointIpAddressRange != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointIpv6Address. 
        /// <para>
        /// The IPv6 address of the endpoint that is used to access data or to manage the file
        /// system.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=45)]
        public string EndpointIpv6Address
        {
            get { return this._endpointIpv6Address; }
            set { this._endpointIpv6Address = value; }
        }

        // Check to see if EndpointIpv6Address property is set
        internal bool IsSetEndpointIpv6Address()
        {
            return this._endpointIpv6Address != null;
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
        /// Gets and sets the property PreferredSubnetId. 
        /// <para>
        /// Required when <c>DeploymentType</c> is set to <c>MULTI_AZ_1</c>. This specifies the
        /// subnet in which you want the preferred file server to be located.
        /// </para>
        /// </summary>
        [AWSProperty(Min=15, Max=24)]
        public string PreferredSubnetId
        {
            get { return this._preferredSubnetId; }
            set { this._preferredSubnetId = value; }
        }

        // Check to see if PreferredSubnetId property is set
        internal bool IsSetPreferredSubnetId()
        {
            return this._preferredSubnetId != null;
        }

        /// <summary>
        /// Gets and sets the property ReadCacheConfiguration. 
        /// <para>
        ///  Required when <c>StorageType</c> is set to <c>INTELLIGENT_TIERING</c>. Specifies
        /// the optional provisioned SSD read cache. 
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
        /// Gets and sets the property RootVolumeId. 
        /// <para>
        /// The ID of the root volume of the OpenZFS file system. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=23, Max=23)]
        public string RootVolumeId
        {
            get { return this._rootVolumeId; }
            set { this._rootVolumeId = value; }
        }

        // Check to see if RootVolumeId property is set
        internal bool IsSetRootVolumeId()
        {
            return this._rootVolumeId != null;
        }

        /// <summary>
        /// Gets and sets the property RouteTableIds. 
        /// <para>
        /// (Multi-AZ only) The VPC route tables in which your file system's endpoints are created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> RouteTableIds
        {
            get { return this._routeTableIds; }
            set { this._routeTableIds = value; }
        }

        // Check to see if RouteTableIds property is set
        internal bool IsSetRouteTableIds()
        {
            return this._routeTableIds != null && (this._routeTableIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ThroughputCapacity. 
        /// <para>
        /// The throughput of an Amazon FSx file system, measured in megabytes per second (MBps).
        /// </para>
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