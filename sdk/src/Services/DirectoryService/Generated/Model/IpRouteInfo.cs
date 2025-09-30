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
    /// Information about one or more IP address blocks.
    /// </summary>
    public partial class IpRouteInfo
    {
        private DateTime? _addedDateTime;
        private string _cidrIp;
        private string _cidrIpv6;
        private string _description;
        private string _directoryId;
        private IpRouteStatusMsg _ipRouteStatusMsg;
        private string _ipRouteStatusReason;

        /// <summary>
        /// Gets and sets the property AddedDateTime. 
        /// <para>
        /// The date and time the address block was added to the directory.
        /// </para>
        /// </summary>
        public DateTime? AddedDateTime
        {
            get { return this._addedDateTime; }
            set { this._addedDateTime = value; }
        }

        // Check to see if AddedDateTime property is set
        internal bool IsSetAddedDateTime()
        {
            return this._addedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CidrIp. 
        /// <para>
        /// IP address block in the <a>IpRoute</a>.
        /// </para>
        /// </summary>
        public string CidrIp
        {
            get { return this._cidrIp; }
            set { this._cidrIp = value; }
        }

        // Check to see if CidrIp property is set
        internal bool IsSetCidrIp()
        {
            return this._cidrIp != null;
        }

        /// <summary>
        /// Gets and sets the property CidrIpv6. 
        /// <para>
        /// IPv6 address block in the <a>IpRoute</a>.
        /// </para>
        /// </summary>
        public string CidrIpv6
        {
            get { return this._cidrIpv6; }
            set { this._cidrIpv6 = value; }
        }

        // Check to see if CidrIpv6 property is set
        internal bool IsSetCidrIpv6()
        {
            return this._cidrIpv6 != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the <a>IpRouteInfo</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// Identifier (ID) of the directory associated with the IP addresses.
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
        /// Gets and sets the property IpRouteStatusMsg. 
        /// <para>
        /// The status of the IP address block.
        /// </para>
        /// </summary>
        public IpRouteStatusMsg IpRouteStatusMsg
        {
            get { return this._ipRouteStatusMsg; }
            set { this._ipRouteStatusMsg = value; }
        }

        // Check to see if IpRouteStatusMsg property is set
        internal bool IsSetIpRouteStatusMsg()
        {
            return this._ipRouteStatusMsg != null;
        }

        /// <summary>
        /// Gets and sets the property IpRouteStatusReason. 
        /// <para>
        /// The reason for the IpRouteStatusMsg.
        /// </para>
        /// </summary>
        public string IpRouteStatusReason
        {
            get { return this._ipRouteStatusReason; }
            set { this._ipRouteStatusReason = value; }
        }

        // Check to see if IpRouteStatusReason property is set
        internal bool IsSetIpRouteStatusReason()
        {
            return this._ipRouteStatusReason != null;
        }

    }
}