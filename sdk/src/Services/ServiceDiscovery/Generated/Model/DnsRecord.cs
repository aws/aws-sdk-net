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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// A complex type that contains information about the Route 53 DNS records that you want
    /// AWS Cloud Map to create when you register an instance.
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
        /// Alias records don't include a TTL because Route 53 uses the TTL for the AWS resource
        /// that an alias record routes traffic to. If you include the <code>AWS_ALIAS_DNS_NAME</code>
        /// attribute when you submit a <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_RegisterInstance.html">RegisterInstance</a>
        /// request, the <code>TTL</code> value is ignored. Always specify a TTL for the service;
        /// you can use a service to register instances that create either alias or non-alias
        /// records.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2147483647)]
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
        /// The type of the resource, which indicates the type of value that Route 53 returns
        /// in response to DNS queries. You can specify values for <code>Type</code> in the following
        /// combinations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>A</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AAAA</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>A</code> and <code>AAAA</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SRV</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CNAME</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you want AWS Cloud Map to create a Route 53 alias record when you register an instance,
        /// specify <code>A</code> or <code>AAAA</code> for <code>Type</code>.
        /// </para>
        ///  
        /// <para>
        /// You specify other settings, such as the IP address for <code>A</code> and <code>AAAA</code>
        /// records, when you register an instance. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_RegisterInstance.html">RegisterInstance</a>.
        /// </para>
        ///  
        /// <para>
        /// The following values are supported:
        /// </para>
        ///  
        /// <para>
        ///  <code>A</code> <b> <code/> </b> 
        /// </para>
        ///  
        /// <para>
        /// Route 53 returns the IP address of the resource in IPv4 format, such as 192.0.2.44.
        /// </para>
        ///  
        /// <para>
        ///  <code>AAAA</code> <b> <code/> </b> 
        /// </para>
        ///  
        /// <para>
        /// Route 53 returns the IP address of the resource in IPv6 format, such as 2001:0db8:85a3:0000:0000:abcd:0001:2345.
        /// </para>
        ///  
        /// <para>
        ///  <code>CNAME</code> <b> <code/> </b> 
        /// </para>
        ///  
        /// <para>
        /// Route 53 returns the domain name of the resource, such as www.example.com. Note the
        /// following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You specify the domain name that you want to route traffic to when you register an
        /// instance. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_RegisterInstance.html#cloudmap-RegisterInstance-request-Attributes">Attributes</a>
        /// in the topic <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_RegisterInstance.html">RegisterInstance</a>.
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
        /// Route 53 returns the value for an <code>SRV</code> record. The value for an <code>SRV</code>
        /// record uses the following values:
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
        /// attribute when you submit a <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_RegisterInstance.html">RegisterInstance</a>
        /// request. 
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
        /// If you specify settings for an <code>SRV</code> record, note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify values for <code>AWS_INSTANCE_IPV4</code>, <code>AWS_INSTANCE_IPV6</code>,
        /// or both in the <code>RegisterInstance</code> request, AWS Cloud Map automatically
        /// creates <code>A</code> and/or <code>AAAA</code> records that have the same name as
        /// the value of <code>service-hostname</code> in the <code>SRV</code> record. You can
        /// ignore these records.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you're using a system that requires a specific <code>SRV</code> format, such as
        /// HAProxy, see the <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_CreateService.html#cloudmap-CreateService-request-Name">Name</a>
        /// element in the documentation about <code>CreateService</code> for information about
        /// how to specify the correct name format.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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