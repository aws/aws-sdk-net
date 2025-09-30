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
    /// Configuration for the FSx for NetApp ONTAP file system.
    /// </summary>
    public partial class OntapFileSystemConfiguration
    {
        private int? _automaticBackupRetentionDays;
        private string _dailyAutomaticBackupStartTime;
        private OntapDeploymentType _deploymentType;
        private DiskIopsConfiguration _diskIopsConfiguration;
        private string _endpointIpAddressRange;
        private string _endpointIpv6AddressRange;
        private FileSystemEndpoints _endpoints;
        private string _fsxAdminPassword;
        private int? _haPairs;
        private string _preferredSubnetId;
        private List<string> _routeTableIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _throughputCapacity;
        private int? _throughputCapacityPerHAPair;
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
        /// Specifies the FSx for ONTAP file system deployment type in use in the file system.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>MULTI_AZ_1</c> - A high availability file system configured for Multi-AZ redundancy
        /// to tolerate temporary Availability Zone (AZ) unavailability. This is a first-generation
        /// FSx for ONTAP file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MULTI_AZ_2</c> - A high availability file system configured for Multi-AZ redundancy
        /// to tolerate temporary AZ unavailability. This is a second-generation FSx for ONTAP
        /// file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SINGLE_AZ_1</c> - A file system configured for Single-AZ redundancy. This is a
        /// first-generation FSx for ONTAP file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SINGLE_AZ_2</c> - A file system configured with multiple high-availability (HA)
        /// pairs for Single-AZ redundancy. This is a second-generation FSx for ONTAP file system.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about the use cases for Multi-AZ and Single-AZ deployments, refer
        /// to <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/high-availability-multiAZ.html">Choosing
        /// Multi-AZ or Single-AZ file system deployment</a>. 
        /// </para>
        /// </summary>
        public OntapDeploymentType DeploymentType
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
        /// <para>
        /// The SSD IOPS configuration for the ONTAP file system, specifying the number of provisioned
        /// IOPS and the provision mode.
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
        /// Gets and sets the property EndpointIpAddressRange. 
        /// <para>
        /// (Multi-AZ only) Specifies the IPv4 address range in which the endpoints to access
        /// your file system will be created. By default in the Amazon FSx API, Amazon FSx selects
        /// an unused IP address range for you from the 198.19.* range. By default in the Amazon
        /// FSx console, Amazon FSx chooses the last 64 IP addresses from the VPC’s primary CIDR
        /// range to use as the endpoint IP address range for the file system. You can have overlapping
        /// endpoint IP addresses for file systems deployed in the same VPC/route tables.
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
        /// Gets and sets the property Endpoints. 
        /// <para>
        /// The <c>Management</c> and <c>Intercluster</c> endpoints that are used to access data
        /// or to manage the file system using the NetApp ONTAP CLI, REST API, or NetApp SnapMirror.
        /// </para>
        /// </summary>
        public FileSystemEndpoints Endpoints
        {
            get { return this._endpoints; }
            set { this._endpoints = value; }
        }

        // Check to see if Endpoints property is set
        internal bool IsSetEndpoints()
        {
            return this._endpoints != null;
        }

        /// <summary>
        /// Gets and sets the property FsxAdminPassword. 
        /// <para>
        /// You can use the <c>fsxadmin</c> user account to access the NetApp ONTAP CLI and REST
        /// API. The password value is always redacted in the response.
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
        /// Gets and sets the property HAPairs. 
        /// <para>
        /// Specifies how many high-availability (HA) file server pairs the file system will have.
        /// The default value is 1. The value of this property affects the values of <c>StorageCapacity</c>,
        /// <c>Iops</c>, and <c>ThroughputCapacity</c>. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/HA-pairs.html">High-availability
        /// (HA) pairs</a> in the FSx for ONTAP user guide.
        /// </para>
        ///  
        /// <para>
        /// Amazon FSx responds with an HTTP status code 400 (Bad Request) for the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The value of <c>HAPairs</c> is less than 1 or greater than 12.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The value of <c>HAPairs</c> is greater than 1 and the value of <c>DeploymentType</c>
        /// is <c>SINGLE_AZ_1</c>, <c>MULTI_AZ_1</c>, or <c>MULTI_AZ_2</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=12)]
        public int? HAPairs
        {
            get { return this._haPairs; }
            set { this._haPairs = value; }
        }

        // Check to see if HAPairs property is set
        internal bool IsSetHAPairs()
        {
            return this._haPairs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PreferredSubnetId.
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
        /// Use to choose the throughput capacity per HA pair. When the value of <c>HAPairs</c>
        /// is equal to 1, the value of <c>ThroughputCapacityPerHAPair</c> is the total throughput
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
        /// For <c>SINGLE_AZ_1</c> and <c>MULTI_AZ_1</c> file systems, valid values are 128, 256,
        /// 512, 1024, 2048, or 4096 MBps.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>SINGLE_AZ_2</c>, valid values are 1536, 3072, or 6144 MBps.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>MULTI_AZ_2</c>, valid values are 384, 768, 1536, 3072, or 6144 MBps.
        /// </para>
        ///  </li> </ul> 
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
        /// The value of deployment type is <c>SINGLE_AZ_2</c> and <c>ThroughputCapacity</c> /
        /// <c>ThroughputCapacityPerHAPair</c> is not a valid HA pair (a value between 1 and 12).
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