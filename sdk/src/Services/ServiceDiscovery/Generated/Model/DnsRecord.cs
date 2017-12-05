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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// A complex type that contains information about the resource record sets that you want
    /// Amazon Route 53 to create when you register an instance.
    /// </summary>
    public partial class DnsRecord
    {
        private long? _ttl;
        private RecordType _type;

        /// <summary>
        /// Gets and sets the property TTL. 
        /// <para>
        /// The amount of time, in seconds, that you want DNS resolvers to cache the settings
        /// for this resource record set.
        /// </para>
        /// </summary>
        public long TTL
        {
            get { return this._ttl.GetValueOrDefault(); }
            set { this._ttl = value; }
        }

        // Check to see if TTL property is set
        internal bool IsSetTTL()
        {
            return this._ttl.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the resource, which indicates the value that Amazon Route 53 returns in
        /// response to DNS queries. The following values are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>A</b>: Amazon Route 53 returns the IP address of the resource in IPv4 format,
        /// such as 192.0.2.44.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>AAAA</b>: Amazon Route 53 returns the IP address of the resource in IPv6 format,
        /// such as 2001:0db8:85a3:0000:0000:abcd:0001:2345.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>SRV</b>: Amazon Route 53 returns the value for an SRV record. The value for an
        /// SRV record uses the following template, which can't be changed:
        /// </para>
        ///  
        /// <para>
        ///  <code>priority weight port resource-record-set-name</code> 
        /// </para>
        ///  
        /// <para>
        /// The values of <code>priority</code> and <code>weight</code> are both set to 1. The
        /// value of port comes from the value that you specify for <code>Port</code> when you
        /// submit a <a>RegisterInstance</a> request.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RecordType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}