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
    /// The ONTAP configuration properties of the FSx for ONTAP file system that you are creating.
    /// </summary>
    public partial class CreateFileSystemOntapConfiguration
    {
        private int? _automaticBackupRetentionDays;
        private string _dailyAutomaticBackupStartTime;
        private OntapDeploymentType _deploymentType;
        private DiskIopsConfiguration _diskIopsConfiguration;
        private string _endpointIpAddressRange;
        private string _fsxAdminPassword;
        private string _preferredSubnetId;
        private List<string> _routeTableIds = new List<string>();
        private int? _throughputCapacity;
        private string _weeklyMaintenanceStartTime;

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
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// Specifies the FSx for ONTAP file system deployment type to use in creating the file
        /// system. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>MULTI_AZ_1</code> - (Default) A high availability file system configured for
        /// Multi-AZ redundancy to tolerate temporary Availability Zone (AZ) unavailability. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SINGLE_AZ_1</code> - A file system configured for Single-AZ redundancy.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about the use cases for Multi-AZ and Single-AZ deployments, refer
        /// to <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/high-availability-AZ.html">Choosing
        /// a file system deployment type</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The SSD IOPS configuration for the FSx for ONTAP file system.
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
        /// (Multi-AZ only) Specifies the IP address range in which the endpoints to access your
        /// file system will be created. By default in the Amazon FSx API, Amazon FSx selects
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
        /// Gets and sets the property FsxAdminPassword. 
        /// <para>
        /// The ONTAP administrative password for the <code>fsxadmin</code> user with which you
        /// administer your file system using the NetApp ONTAP CLI and REST API.
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
        /// Gets and sets the property PreferredSubnetId. 
        /// <para>
        /// Required when <code>DeploymentType</code> is set to <code>MULTI_AZ_1</code>. This
        /// specifies the subnet in which you want the preferred file server to be located.
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
        /// Gets and sets the property RouteTableIds. 
        /// <para>
        /// (Multi-AZ only) Specifies the virtual private cloud (VPC) route tables in which your
        /// file system's endpoints will be created. You should specify all VPC route tables associated
        /// with the subnets in which your clients are located. By default, Amazon FSx selects
        /// your VPC's default route table.
        /// </para>
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
            return this._routeTableIds != null && this._routeTableIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ThroughputCapacity. 
        /// <para>
        /// Sets the throughput capacity for the file system that you're creating. Valid values
        /// are 128, 256, 512, 1024, 2048, and 4096 MBps.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=100000)]
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