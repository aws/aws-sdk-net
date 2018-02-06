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
    /// A complex type that contains information about the records that you want Route 53
    /// to create when you register an instance.
    /// </summary>
    public partial class DnsRecord
    {
        private long? _ttl;
        private RecordType _type;

        /// <summary>
        /// Gets and sets the property TTL. 
        /// <para>
        /// The amount of time, in seconds, that you want DNS resolvers to cache the settings
        /// for this record.
        /// </para>
        ///  <note> 
        /// <para>
        /// Alias records don't include a TTL because Route 53 uses the TTL for the AWS resource
        /// that an alias record routes traffic to. If you include the <code>AWS_ALIAS_DNS_NAME</code>
        /// attribute when you submit a <a>RegisterInstance</a> request, the <code>TTL</code>
        /// value is ignored. Always specify a TTL for the service; you can use a service to register
        /// instances that create either alias or non-alias records.
        /// </para>
        ///  </note>
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
        /// The type of the resource, which indicates the type of value that Route 53 returns
        /// in response to DNS queries.
        /// </para>
        ///  
        /// <para>
        /// Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>A, AAAA, and SRV records: You can specify settings for a maximum of one A, one
        /// AAAA, and one SRV record. You can specify them in any combination.</b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CNAME records:</b> If you specify <code>CNAME</code> for <code>Type</code>, you
        /// can't define any other records. This is a limitation of DNS—you can't create a CNAME
        /// record and any other type of record that has the same name as a CNAME record.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Alias records:</b> If you want Route 53 to create an alias record when you register
        /// an instance, specify <code>A</code> or <code>AAAA</code> for <code>Type</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>All records:</b> You specify settings other than <code>TTL</code> and <code>Type</code>
        /// when you register an instance.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following values are supported:
        /// </para>
        ///  
        /// <para>
        ///  <b>A</b> 
        /// </para>
        ///  
        /// <para>
        /// Route 53 returns the IP address of the resource in IPv4 format, such as 192.0.2.44.
        /// </para>
        ///  
        /// <para>
        ///  <b>AAAA</b> 
        /// </para>
        ///  
        /// <para>
        /// Route 53 returns the IP address of the resource in IPv6 format, such as 2001:0db8:85a3:0000:0000:abcd:0001:2345.
        /// </para>
        ///  
        /// <para>
        ///  <b>CNAME</b> 
        /// </para>
        ///  
        /// <para>
        /// Route 53 returns the domain name of the resource, such as www.example.com. Note the
        /// following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You specify the domain name that you want to route traffic to when you register an
        /// instance. For more information, see <a>RegisterInstanceRequest$Attributes</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must specify <code>WEIGHTED</code> for the value of <code>RoutingPolicy</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't specify both <code>CNAME</code> for <code>Type</code> and settings for <code>HealthCheckConfig</code>.
        /// If you do, the request will fail with an <code>InvalidInput</code> error.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>SRV</b> 
        /// </para>
        ///  
        /// <para>
        /// Route 53 returns the value for an SRV record. The value for an SRV record uses the
        /// following values:
        /// </para>
        ///  
        /// <para>
        ///  <code>priority weight port service-hostname</code> 
        /// </para>
        ///  
        /// <para>
        /// Note the following about the values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The values of <code>priority</code> and <code>weight</code> are both set to <code>1</code>
        /// and can't be changed. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The value of <code>port</code> comes from the value that you specify for the <code>AWS_INSTANCE_PORT</code>
        /// attribute when you submit a <a>RegisterInstance</a> request. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The value of <code>service-hostname</code> is a concatenation of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The value that you specify for <code>InstanceId</code> when you register an instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The name of the service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The name of the namespace. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, if the value of <code>InstanceId</code> is <code>test</code>, the name
        /// of the service is <code>backend</code>, and the name of the namespace is <code>example.com</code>,
        /// the value of <code>service-hostname</code> is:
        /// </para>
        ///  
        /// <para>
        ///  <code>test.backend.example.com</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify settings for an SRV record and if you specify values for <code>AWS_INSTANCE_IPV4</code>,
        /// <code>AWS_INSTANCE_IPV6</code>, or both in the <code>RegisterInstance</code> request,
        /// Route 53 automatically creates <code>A</code> and/or <code>AAAA</code> records that
        /// have the same name as the value of <code>service-hostname</code> in the SRV record.
        /// You can ignore these records.
        /// </para>
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