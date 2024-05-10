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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// A complex type that contains information about the Route 53 DNS records that you want
    /// Cloud Map to create when you register an instance.
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
        /// Alias records don't include a TTL because Route 53 uses the TTL for the Amazon Web
        /// Services resource that an alias record routes traffic to. If you include the <c>AWS_ALIAS_DNS_NAME</c>
        /// attribute when you submit a <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_RegisterInstance.html">RegisterInstance</a>
        /// request, the <c>TTL</c> value is ignored. Always specify a TTL for the service; you
        /// can use a service to register instances that create either alias or non-alias records.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2147483647)]
        public long? TTL
        {
            get { return this._ttl; }
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
        /// in response to DNS queries. You can specify values for <c>Type</c> in the following
        /// combinations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>A</c> </b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>AAAA</c> </b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>A</c> </b> and <b> <c>AAAA</c> </b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>SRV</c> </b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>CNAME</c> </b> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you want Cloud Map to create a Route 53 alias record when you register an instance,
        /// specify <c>A</c> or <c>AAAA</c> for <c>Type</c>.
        /// </para>
        ///  
        /// <para>
        /// You specify other settings, such as the IP address for <c>A</c> and <c>AAAA</c> records,
        /// when you register an instance. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_RegisterInstance.html">RegisterInstance</a>.
        /// </para>
        ///  
        /// <para>
        /// The following values are supported:
        /// </para>
        ///  <dl> <dt>A</dt> <dd> 
        /// <para>
        /// Route 53 returns the IP address of the resource in IPv4 format, such as 192.0.2.44.
        /// </para>
        ///  </dd> <dt>AAAA</dt> <dd> 
        /// <para>
        /// Route 53 returns the IP address of the resource in IPv6 format, such as 2001:0db8:85a3:0000:0000:abcd:0001:2345.
        /// </para>
        ///  </dd> <dt>CNAME</dt> <dd> 
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
        /// You must specify <c>WEIGHTED</c> for the value of <c>RoutingPolicy</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't specify both <c>CNAME</c> for <c>Type</c> and settings for <c>HealthCheckConfig</c>.
        /// If you do, the request will fail with an <c>InvalidInput</c> error.
        /// </para>
        ///  </li> </ul> </dd> <dt>SRV</dt> <dd> 
        /// <para>
        /// Route 53 returns the value for an <c>SRV</c> record. The value for an <c>SRV</c> record
        /// uses the following values:
        /// </para>
        ///  
        /// <para>
        ///  <c>priority weight port service-hostname</c> 
        /// </para>
        ///  
        /// <para>
        /// Note the following about the values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The values of <c>priority</c> and <c>weight</c> are both set to <c>1</c> and can't
        /// be changed. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The value of <c>port</c> comes from the value that you specify for the <c>AWS_INSTANCE_PORT</c>
        /// attribute when you submit a <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_RegisterInstance.html">RegisterInstance</a>
        /// request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The value of <c>service-hostname</c> is a concatenation of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The value that you specify for <c>InstanceId</c> when you register an instance.
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
        /// For example, if the value of <c>InstanceId</c> is <c>test</c>, the name of the service
        /// is <c>backend</c>, and the name of the namespace is <c>example.com</c>, the value
        /// of <c>service-hostname</c> is the following:
        /// </para>
        ///  
        /// <para>
        ///  <c>test.backend.example.com</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify settings for an <c>SRV</c> record, note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify values for <c>AWS_INSTANCE_IPV4</c>, <c>AWS_INSTANCE_IPV6</c>, or both
        /// in the <c>RegisterInstance</c> request, Cloud Map automatically creates <c>A</c> and/or
        /// <c>AAAA</c> records that have the same name as the value of <c>service-hostname</c>
        /// in the <c>SRV</c> record. You can ignore these records.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you're using a system that requires a specific <c>SRV</c> format, such as HAProxy,
        /// see the <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_CreateService.html#cloudmap-CreateService-request-Name">Name</a>
        /// element in the documentation about <c>CreateService</c> for information about how
        /// to specify the correct name format.
        /// </para>
        ///  </li> </ul> </dd> </dl>
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