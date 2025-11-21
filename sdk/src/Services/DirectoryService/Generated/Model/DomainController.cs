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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Contains information about the domain controllers for a specified directory.
    /// </summary>
    public partial class DomainController
    {
        private string _availabilityZone;
        private string _directoryId;
        private string _dnsIpAddr;
        private string _dnsIpv6Addr;
        private string _domainControllerId;
        private DateTime? _launchTime;
        private DomainControllerStatus _status;
        private DateTime? _statusLastUpdatedDateTime;
        private string _statusReason;
        private string _subnetId;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone where the domain controller is located.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// Identifier of the directory where the domain controller resides.
        /// </para>
        /// </summary>
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property DnsIpAddr. 
        /// <para>
        /// The IP address of the domain controller.
        /// </para>
        /// </summary>
        public string DnsIpAddr
        {
            get { return this._dnsIpAddr; }
            set { this._dnsIpAddr = value; }
        }

        // Check to see if DnsIpAddr property is set
        internal bool IsSetDnsIpAddr()
        {
            return this._dnsIpAddr != null;
        }

        /// <summary>
        /// Gets and sets the property DnsIpv6Addr. 
        /// <para>
        /// The IPv6 address of the domain controller.
        /// </para>
        /// </summary>
        public string DnsIpv6Addr
        {
            get { return this._dnsIpv6Addr; }
            set { this._dnsIpv6Addr = value; }
        }

        // Check to see if DnsIpv6Addr property is set
        internal bool IsSetDnsIpv6Addr()
        {
            return this._dnsIpv6Addr != null;
        }

        /// <summary>
        /// Gets and sets the property DomainControllerId. 
        /// <para>
        /// Identifies a specific domain controller in the directory.
        /// </para>
        /// </summary>
        public string DomainControllerId
        {
            get { return this._domainControllerId; }
            set { this._domainControllerId = value; }
        }

        // Check to see if DomainControllerId property is set
        internal bool IsSetDomainControllerId()
        {
            return this._domainControllerId != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchTime. 
        /// <para>
        /// Specifies when the domain controller was created.
        /// </para>
        /// </summary>
        public DateTime? LaunchTime
        {
            get { return this._launchTime; }
            set { this._launchTime = value; }
        }

        // Check to see if LaunchTime property is set
        internal bool IsSetLaunchTime()
        {
            return this._launchTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the domain controller.
        /// </para>
        /// </summary>
        public DomainControllerStatus Status
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
        /// Gets and sets the property StatusLastUpdatedDateTime. 
        /// <para>
        /// The date and time that the status was last updated.
        /// </para>
        /// </summary>
        public DateTime? StatusLastUpdatedDateTime
        {
            get { return this._statusLastUpdatedDateTime; }
            set { this._statusLastUpdatedDateTime = value; }
        }

        // Check to see if StatusLastUpdatedDateTime property is set
        internal bool IsSetStatusLastUpdatedDateTime()
        {
            return this._statusLastUpdatedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A description of the domain controller state.
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
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// Identifier of the subnet in the VPC that contains the domain controller.
        /// </para>
        /// </summary>
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The identifier of the VPC that contains the domain controller.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}