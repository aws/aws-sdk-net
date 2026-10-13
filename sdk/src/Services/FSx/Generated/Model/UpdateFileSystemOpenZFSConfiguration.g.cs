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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// The configuration updates for an Amazon FSx for OpenZFS file system.
    /// </summary>
    public partial class UpdateFileSystemOpenZFSConfiguration
    {
        /// <summary>
        /// Gets and sets the property AddRouteTableIds. 
        /// <para>
        /// (Multi-AZ only) A list of IDs of new virtual private cloud (VPC) route tables to associate
        /// (add) with your Amazon FSx for OpenZFS file system.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> AddRouteTableIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AddRouteTableIds property is set.
        /// </summary>
        internal bool IsSetAddRouteTableIds() => this.AddRouteTableIds != null && (this.AddRouteTableIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AutomaticBackupRetentionDays.
        /// </summary>
        [AWSProperty(Min = 0, Max = 90)]
        public int? AutomaticBackupRetentionDays { get; set; }

        /// <summary>
        /// Checks to see if the AutomaticBackupRetentionDays property is set.
        /// </summary>
        internal bool IsSetAutomaticBackupRetentionDays() => this.AutomaticBackupRetentionDays.HasValue;

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
        public bool? CopyTagsToBackups { get; set; }

        /// <summary>
        /// Checks to see if the CopyTagsToBackups property is set.
        /// </summary>
        internal bool IsSetCopyTagsToBackups() => this.CopyTagsToBackups.HasValue;

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
        public bool? CopyTagsToVolumes { get; set; }

        /// <summary>
        /// Checks to see if the CopyTagsToVolumes property is set.
        /// </summary>
        internal bool IsSetCopyTagsToVolumes() => this.CopyTagsToVolumes.HasValue;

        /// <summary>
        /// Gets and sets the property DailyAutomaticBackupStartTime.
        /// </summary>
        [AWSProperty(Min = 5, Max = 5)]
        public string DailyAutomaticBackupStartTime { get; set; }

        /// <summary>
        /// Checks to see if the DailyAutomaticBackupStartTime property is set.
        /// </summary>
        internal bool IsSetDailyAutomaticBackupStartTime() => this.DailyAutomaticBackupStartTime != null;

        /// <summary>
        /// Gets and sets the property DiskIopsConfiguration.
        /// </summary>
        public DiskIopsConfiguration DiskIopsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DiskIopsConfiguration property is set.
        /// </summary>
        internal bool IsSetDiskIopsConfiguration() => this.DiskIopsConfiguration != null;

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
        [AWSProperty(Min = 4, Max = 43)]
        public string EndpointIpv6AddressRange { get; set; }

        /// <summary>
        /// Checks to see if the EndpointIpv6AddressRange property is set.
        /// </summary>
        internal bool IsSetEndpointIpv6AddressRange() => this.EndpointIpv6AddressRange != null;

        /// <summary>
        /// Gets and sets the property ReadCacheConfiguration. 
        /// <para>
        ///  The configuration for the optional provisioned SSD read cache on file systems that
        /// use the Intelligent-Tiering storage class.
        /// </para>
        /// </summary>
        public OpenZFSReadCacheConfiguration ReadCacheConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ReadCacheConfiguration property is set.
        /// </summary>
        internal bool IsSetReadCacheConfiguration() => this.ReadCacheConfiguration != null;

        /// <summary>
        /// Gets and sets the property RemoveRouteTableIds. 
        /// <para>
        /// (Multi-AZ only) A list of IDs of existing virtual private cloud (VPC) route tables
        /// to disassociate (remove) from your Amazon FSx for OpenZFS file system. You can use
        /// the API operation to retrieve the list of VPC route table IDs for a file system.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> RemoveRouteTableIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RemoveRouteTableIds property is set.
        /// </summary>
        internal bool IsSetRemoveRouteTableIds() => this.RemoveRouteTableIds != null && (this.RemoveRouteTableIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThroughputCapacity. 
        /// <para>
        /// The throughput of an Amazon FSx for OpenZFS file system, measured in megabytes per
        /// second (MB/s). Valid values depend on the DeploymentType you choose, as follows:
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
        [AWSProperty(Min = 8, Max = 2147483647)]
        public int? ThroughputCapacity { get; set; }

        /// <summary>
        /// Checks to see if the ThroughputCapacity property is set.
        /// </summary>
        internal bool IsSetThroughputCapacity() => this.ThroughputCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property WeeklyMaintenanceStartTime.
        /// </summary>
        [AWSProperty(Min = 7, Max = 7)]
        public string WeeklyMaintenanceStartTime { get; set; }

        /// <summary>
        /// Checks to see if the WeeklyMaintenanceStartTime property is set.
        /// </summary>
        internal bool IsSetWeeklyMaintenanceStartTime() => this.WeeklyMaintenanceStartTime != null;
    }
}
