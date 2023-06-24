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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// In the response to a <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_GetResolverEndpoint.html">GetResolverEndpoint</a>
    /// request, information about the IP addresses that the Resolver endpoint uses for DNS
    /// queries.
    /// </summary>
    public partial class IpAddressResponse
    {
        private string _creationTime;
        private string _ip;
        private string _ipId;
        private string _ipv6;
        private string _modificationTime;
        private IpAddressStatus _status;
        private string _statusMessage;
        private string _subnetId;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the IP address was created, in Unix time format and Coordinated
        /// Universal Time (UTC).
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=40)]
        public string CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime != null;
        }

        /// <summary>
        /// Gets and sets the property Ip. 
        /// <para>
        /// One IPv4 address that the Resolver endpoint uses for DNS queries.
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=36)]
        public string Ip
        {
            get { return this._ip; }
            set { this._ip = value; }
        }

        // Check to see if Ip property is set
        internal bool IsSetIp()
        {
            return this._ip != null;
        }

        /// <summary>
        /// Gets and sets the property IpId. 
        /// <para>
        /// The ID of one IP address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string IpId
        {
            get { return this._ipId; }
            set { this._ipId = value; }
        }

        // Check to see if IpId property is set
        internal bool IsSetIpId()
        {
            return this._ipId != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6. 
        /// <para>
        ///  One IPv6 address that the Resolver endpoint uses for DNS queries. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=39)]
        public string Ipv6
        {
            get { return this._ipv6; }
            set { this._ipv6 = value; }
        }

        // Check to see if Ipv6 property is set
        internal bool IsSetIpv6()
        {
            return this._ipv6 != null;
        }

        /// <summary>
        /// Gets and sets the property ModificationTime. 
        /// <para>
        /// The date and time that the IP address was last modified, in Unix time format and Coordinated
        /// Universal Time (UTC).
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=40)]
        public string ModificationTime
        {
            get { return this._modificationTime; }
            set { this._modificationTime = value; }
        }

        // Check to see if ModificationTime property is set
        internal bool IsSetModificationTime()
        {
            return this._modificationTime != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A status code that gives the current status of the request.
        /// </para>
        /// </summary>
        public IpAddressStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message that provides additional information about the status of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of one subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
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

    }
}