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
    /// The configuration for the Amazon FSx for OpenZFS file system.
    /// </summary>
    public partial class OpenZFSFileSystemConfiguration
    {
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
        /// A Boolean value indicating whether tags on the file system should be copied to backups.
        /// If it's set to <c>true</c>, all tags on the file system are copied to all automatic
        /// backups and any user-initiated backups where the user doesn't specify any tags. If
        /// this value is <c>true</c> and you specify one or more tags, only the specified tags
        /// are copied to backups. If you specify one or more tags when creating a user-initiated
        /// backup, no tags are copied from the file system, regardless of this value. 
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
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// Specifies the file-system deployment type. Amazon FSx for OpenZFS supports <c>MULTI_AZ_1</c>,
        /// <c>SINGLE_AZ_HA_2</c>, <c>SINGLE_AZ_HA_1</c>, <c>SINGLE_AZ_2</c>, and <c>SINGLE_AZ_1</c>.
        /// </para>
        /// </summary>
        public OpenZFSDeploymentType DeploymentType { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentType property is set.
        /// </summary>
        internal bool IsSetDeploymentType() => this.DeploymentType != null;

        /// <summary>
        /// Gets and sets the property DiskIopsConfiguration.
        /// </summary>
        public DiskIopsConfiguration DiskIopsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DiskIopsConfiguration property is set.
        /// </summary>
        internal bool IsSetDiskIopsConfiguration() => this.DiskIopsConfiguration != null;

        /// <summary>
        /// Gets and sets the property EndpointIpAddress. 
        /// <para>
        /// The IPv4 address of the endpoint that is used to access data or to manage the file
        /// system.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 45)]
        public string EndpointIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the EndpointIpAddress property is set.
        /// </summary>
        internal bool IsSetEndpointIpAddress() => this.EndpointIpAddress != null;

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
        [AWSProperty(Min = 9, Max = 17)]
        public string EndpointIpAddressRange { get; set; }

        /// <summary>
        /// Checks to see if the EndpointIpAddressRange property is set.
        /// </summary>
        internal bool IsSetEndpointIpAddressRange() => this.EndpointIpAddressRange != null;

        /// <summary>
        /// Gets and sets the property EndpointIpv6Address. 
        /// <para>
        /// The IPv6 address of the endpoint that is used to access data or to manage the file
        /// system.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 45)]
        public string EndpointIpv6Address { get; set; }

        /// <summary>
        /// Checks to see if the EndpointIpv6Address property is set.
        /// </summary>
        internal bool IsSetEndpointIpv6Address() => this.EndpointIpv6Address != null;

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
        /// Gets and sets the property PreferredSubnetId. 
        /// <para>
        /// Required when <c>DeploymentType</c> is set to <c>MULTI_AZ_1</c>. This specifies the
        /// subnet in which you want the preferred file server to be located.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 15, Max = 24)]
        public string PreferredSubnetId { get; set; }

        /// <summary>
        /// Checks to see if the PreferredSubnetId property is set.
        /// </summary>
        internal bool IsSetPreferredSubnetId() => this.PreferredSubnetId != null;

        /// <summary>
        /// Gets and sets the property ReadCacheConfiguration. 
        /// <para>
        ///  Required when <c>StorageType</c> is set to <c>INTELLIGENT_TIERING</c>. Specifies
        /// the optional provisioned SSD read cache. 
        /// </para>
        /// </summary>
        public OpenZFSReadCacheConfiguration ReadCacheConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ReadCacheConfiguration property is set.
        /// </summary>
        internal bool IsSetReadCacheConfiguration() => this.ReadCacheConfiguration != null;

        /// <summary>
        /// Gets and sets the property RootVolumeId. 
        /// <para>
        /// The ID of the root volume of the OpenZFS file system. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 23, Max = 23)]
        public string RootVolumeId { get; set; }

        /// <summary>
        /// Checks to see if the RootVolumeId property is set.
        /// </summary>
        internal bool IsSetRootVolumeId() => this.RootVolumeId != null;

        /// <summary>
        /// Gets and sets the property RouteTableIds. 
        /// <para>
        /// (Multi-AZ only) The VPC route tables in which your file system's endpoints are created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> RouteTableIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RouteTableIds property is set.
        /// </summary>
        internal bool IsSetRouteTableIds() => this.RouteTableIds != null && (this.RouteTableIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThroughputCapacity. 
        /// <para>
        /// The throughput of an Amazon FSx file system, measured in megabytes per second (MBps).
        /// </para>
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
