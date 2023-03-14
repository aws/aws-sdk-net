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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the DNS options for an endpoint.
    /// </summary>
    public partial class DnsOptions
    {
        private DnsRecordIpType _dnsRecordIpType;
        private bool? _privateDnsOnlyForInboundResolverEndpoint;

        /// <summary>
        /// Gets and sets the property DnsRecordIpType. 
        /// <para>
        /// The DNS records created for the endpoint.
        /// </para>
        /// </summary>
        public DnsRecordIpType DnsRecordIpType
        {
            get { return this._dnsRecordIpType; }
            set { this._dnsRecordIpType = value; }
        }

        // Check to see if DnsRecordIpType property is set
        internal bool IsSetDnsRecordIpType()
        {
            return this._dnsRecordIpType != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateDnsOnlyForInboundResolverEndpoint. 
        /// <para>
        /// Indicates whether to enable private DNS only for inbound endpoints.
        /// </para>
        /// </summary>
        public bool PrivateDnsOnlyForInboundResolverEndpoint
        {
            get { return this._privateDnsOnlyForInboundResolverEndpoint.GetValueOrDefault(); }
            set { this._privateDnsOnlyForInboundResolverEndpoint = value; }
        }

        // Check to see if PrivateDnsOnlyForInboundResolverEndpoint property is set
        internal bool IsSetPrivateDnsOnlyForInboundResolverEndpoint()
        {
            return this._privateDnsOnlyForInboundResolverEndpoint.HasValue; 
        }

    }
}