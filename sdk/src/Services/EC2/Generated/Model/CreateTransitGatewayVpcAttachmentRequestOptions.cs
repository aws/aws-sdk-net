/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the options for a VPC attachment.
    /// </summary>
    public partial class CreateTransitGatewayVpcAttachmentRequestOptions
    {
        private DnsSupportValue _dnsSupport;
        private Ipv6SupportValue _ipv6Support;

        /// <summary>
        /// Gets and sets the property DnsSupport. 
        /// <para>
        /// Enable or disable DNS support. The default is <code>enable</code>.
        /// </para>
        /// </summary>
        public DnsSupportValue DnsSupport
        {
            get { return this._dnsSupport; }
            set { this._dnsSupport = value; }
        }

        // Check to see if DnsSupport property is set
        internal bool IsSetDnsSupport()
        {
            return this._dnsSupport != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6Support. 
        /// <para>
        /// Enable or disable IPv6 support. The default is <code>enable</code>.
        /// </para>
        /// </summary>
        public Ipv6SupportValue Ipv6Support
        {
            get { return this._ipv6Support; }
            set { this._ipv6Support = value; }
        }

        // Check to see if Ipv6Support property is set
        internal bool IsSetIpv6Support()
        {
            return this._ipv6Support != null;
        }

    }
}