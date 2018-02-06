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
    /// A complex type that contains information about the instances that you registered by
    /// using a specified service.
    /// </summary>
    public partial class InstanceSummary
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private string _id;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A string map that contains the following information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The attributes that are associate with the instance. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For each attribute, the applicable value.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Supported attribute keys include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AWS_ALIAS_DNS_NAME</code>: For an alias record that routes traffic to an Elastic
        /// Load Balancing load balancer, the DNS name that is associated with the load balancer.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS_INSTANCE_CNAME</code>: For a CNAME record, the domain name that Route 53
        /// returns in response to DNS queries, for example, <code>example.com</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS_INSTANCE_IPV4</code>: For an A record, the IPv4 address that Route 53 returns
        /// in response to DNS queries, for example, <code>192.0.2.44</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS_INSTANCE_IPV6</code>: For an AAAA record, the IPv6 address that Route 53
        /// returns in response to DNS queries, for example, <code>2001:0db8:85a3:0000:0000:abcd:0001:2345</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS_INSTANCE_PORT</code>: For an SRV record, the value that Route 53 returns
        /// for the port. In addition, if the service includes <code>HealthCheckConfig</code>,
        /// the port on the endpoint that Route 53 sends requests to.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID for an instance that you created by using a specified service.
        /// </para>
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