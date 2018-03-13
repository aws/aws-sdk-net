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
    /// A complex type that contains information about an instance that Amazon Route 53 creates
    /// when you submit a <code>RegisterInstance</code> request.
    /// </summary>
    public partial class Instance
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private string _creatorRequestId;
        private string _id;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A string map that contains the following information for the service that you specify
        /// in <code>ServiceId</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The attributes that apply to the records that are defined in the service. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For each attribute, the applicable value.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Supported attribute keys include the following:
        /// </para>
        ///  
        /// <para>
        ///  <b>AWS_ALIAS_DNS_NAME</b> 
        /// </para>
        ///  
        /// <para>
        ///  <b/> 
        /// </para>
        ///  
        /// <para>
        /// If you want Route 53 to create an alias record that routes traffic to an Elastic Load
        /// Balancing load balancer, specify the DNS name that is associated with the load balancer.
        /// For information about how to get the DNS name, see "DNSName" in the topic <a href="http://docs.aws.amazon.com/http:/docs.aws.amazon.com/Route53/latest/APIReference/API_AliasTarget.html">AliasTarget</a>.
        /// </para>
        ///  
        /// <para>
        /// Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The configuration for the service that is specified by <code>ServiceId</code> must
        /// include settings for an A record, an AAAA record, or both.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In the service that is specified by <code>ServiceId</code>, the value of <code>RoutingPolicy</code>
        /// must be <code>WEIGHTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the service that is specified by <code>ServiceId</code> includes <code>HealthCheckConfig</code>
        /// settings, Route 53 will create the health check, but it won't associate the health
        /// check with the alias record.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Auto naming currently doesn't support creating alias records that route traffic to
        /// AWS resources other than ELB load balancers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify a value for <code>AWS_ALIAS_DNS_NAME</code>, don't specify values for
        /// any of the <code>AWS_INSTANCE</code> attributes.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>AWS_INSTANCE_CNAME</b> 
        /// </para>
        ///  
        /// <para>
        /// If the service configuration includes a CNAME record, the domain name that you want
        /// Route 53 to return in response to DNS queries, for example, <code>example.com</code>.
        /// </para>
        ///  
        /// <para>
        /// This value is required if the service specified by <code>ServiceId</code> includes
        /// settings for an CNAME record.
        /// </para>
        ///  
        /// <para>
        ///  <b>AWS_INSTANCE_IPV4</b> 
        /// </para>
        ///  
        /// <para>
        /// If the service configuration includes an A record, the IPv4 address that you want
        /// Route 53 to return in response to DNS queries, for example, <code>192.0.2.44</code>.
        /// </para>
        ///  
        /// <para>
        /// This value is required if the service specified by <code>ServiceId</code> includes
        /// settings for an A record. If the service includes settings for an SRV record, you
        /// must specify a value for <code>AWS_INSTANCE_IPV4</code>, <code>AWS_INSTANCE_IPV6</code>,
        /// or both.
        /// </para>
        ///  
        /// <para>
        ///  <b>AWS_INSTANCE_IPV6</b> 
        /// </para>
        ///  
        /// <para>
        /// If the service configuration includes an AAAA record, the IPv6 address that you want
        /// Route 53 to return in response to DNS queries, for example, <code>2001:0db8:85a3:0000:0000:abcd:0001:2345</code>.
        /// </para>
        ///  
        /// <para>
        /// This value is required if the service specified by <code>ServiceId</code> includes
        /// settings for an AAAA record. If the service includes settings for an SRV record, you
        /// must specify a value for <code>AWS_INSTANCE_IPV4</code>, <code>AWS_INSTANCE_IPV6</code>,
        /// or both.
        /// </para>
        ///  
        /// <para>
        ///  <b>AWS_INSTANCE_PORT</b> 
        /// </para>
        ///  
        /// <para>
        /// If the service includes an SRV record, the value that you want Route 53 to return
        /// for the port.
        /// </para>
        ///  
        /// <para>
        /// If the service includes <code>HealthCheckConfig</code>, the port on the endpoint that
        /// you want Route 53 to send requests to. 
        /// </para>
        ///  
        /// <para>
        /// This value is required if you specified settings for an SRV record when you created
        /// the service.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that identifies the request and that allows failed <code>RegisterInstance</code>
        /// requests to be retried without the risk of executing the operation twice. You must
        /// use a unique <code>CreatorRequestId</code> string every time you submit a <code>RegisterInstance</code>
        /// request if you're registering additional instances for the same namespace and service.
        /// <code>CreatorRequestId</code> can be any unique string, for example, a date/time stamp.
        /// </para>
        /// </summary>
        public string CreatorRequestId
        {
            get { return this._creatorRequestId; }
            set { this._creatorRequestId = value; }
        }

        // Check to see if CreatorRequestId property is set
        internal bool IsSetCreatorRequestId()
        {
            return this._creatorRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// An identifier that you want to associate with the instance. Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the service that is specified by <code>ServiceId</code> includes settings for an
        /// SRV record, the value of <code>InstanceId</code> is automatically included as part
        /// of the value for the SRV record. For more information, see <a>DnsRecord$Type</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can use this value to update an existing instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To register a new instance, you must specify a value that is unique among instances
        /// that you register by using the same service. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify an existing <code>InstanceId</code> and <code>ServiceId</code>, Route
        /// 53 updates the existing records. If there's also an existing health check, Route 53
        /// deletes the old health check and creates a new one. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The health check isn't deleted immediately, so it will still appear for a while if
        /// you submit a <code>ListHealthChecks</code> request, for example.
        /// </para>
        ///  </note> </li> </ul>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

    }
}