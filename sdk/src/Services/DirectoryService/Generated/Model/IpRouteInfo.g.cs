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

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Information about one or more IP address blocks.
    /// </summary>
    public partial class IpRouteInfo
    {
        /// <summary>
        /// Gets and sets the property AddedDateTime. 
        /// <para>
        /// The date and time the address block was added to the directory.
        /// </para>
        /// </summary>
        public DateTime? AddedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the AddedDateTime property is set.
        /// </summary>
        internal bool IsSetAddedDateTime() => this.AddedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property CidrIp. 
        /// <para>
        /// IP address block in the <a>IpRoute</a>.
        /// </para>
        /// </summary>
        public string CidrIp { get; set; }

        /// <summary>
        /// Checks to see if the CidrIp property is set.
        /// </summary>
        internal bool IsSetCidrIp() => this.CidrIp != null;

        /// <summary>
        /// Gets and sets the property CidrIpv6. 
        /// <para>
        /// IPv6 address block in the <a>IpRoute</a>.
        /// </para>
        /// </summary>
        public string CidrIpv6 { get; set; }

        /// <summary>
        /// Checks to see if the CidrIpv6 property is set.
        /// </summary>
        internal bool IsSetCidrIpv6() => this.CidrIpv6 != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the <a>IpRouteInfo</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// Identifier (ID) of the directory associated with the IP addresses.
        /// </para>
        /// </summary>
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property IpRouteStatusMsg. 
        /// <para>
        /// The status of the IP address block.
        /// </para>
        /// </summary>
        public IpRouteStatusMsg IpRouteStatusMsg { get; set; }

        /// <summary>
        /// Checks to see if the IpRouteStatusMsg property is set.
        /// </summary>
        internal bool IsSetIpRouteStatusMsg() => this.IpRouteStatusMsg != null;

        /// <summary>
        /// Gets and sets the property IpRouteStatusReason. 
        /// <para>
        /// The reason for the IpRouteStatusMsg.
        /// </para>
        /// </summary>
        public string IpRouteStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the IpRouteStatusReason property is set.
        /// </summary>
        internal bool IsSetIpRouteStatusReason() => this.IpRouteStatusReason != null;
    }
}
