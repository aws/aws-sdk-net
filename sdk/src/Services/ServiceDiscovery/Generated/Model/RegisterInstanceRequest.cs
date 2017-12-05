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
    /// Container for the parameters to the RegisterInstance operation.
    /// Creates one or more resource record sets and optionally a health check based on the
    /// settings in a specified service. When you submit a <code>RegisterInstance</code> request,
    /// Amazon Route 53 does the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Creates a resource record set for each resource record set template in the service
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Creates a health check based on the settings in the health check template in the service,
    /// if any
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Associates the health check, if any, with each of the resource record sets
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// One <code>RegisterInstance</code> request must complete before you can submit another
    /// request and specify the same service and instance ID.
    /// </para>
    ///  </important> 
    /// <para>
    /// For more information, see <a>CreateService</a>.
    /// </para>
    ///  
    /// <para>
    /// When Amazon Route 53 receives a DNS query for the specified DNS name, it returns the
    /// applicable value:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>If the health check is healthy</b>: returns all the resource record sets
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>If the health check is unhealthy</b>: returns the IP address of the last healthy
    /// instance
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>If you didn't specify a health check template</b>: returns all the resource record
    /// sets
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RegisterInstanceRequest : AmazonServiceDiscoveryRequest
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private string _creatorRequestId;
        private string _instanceId;
        private string _serviceId;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A string map that contain attribute keys and values. Supported attribute keys include
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AWS_INSTANCE_PORT</code>: The port on the endpoint that you want Amazon Route
        /// 53 to perform health checks on. This value is also used for the port value in an SRV
        /// record if the service that you specify includes an SRV record. For more information,
        /// see <a>CreateService</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS_INSTANCE_IPV4</code>: If the service that you specify contains a resource
        /// record set template for an A record, the IPv4 address that you want Amazon Route 53
        /// to use for the value of the A record.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS_INSTANCE_IPV6</code>: If the service that you specify contains a resource
        /// record set template for an AAAA record, the IPv6 address that you want Amazon Route
        /// 53 to use for the value of the AAAA record.
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
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// An optional parameter that you can use to resolve concurrent creation requests. <code>CreatorRequestId</code>
        /// helps to determine if a specific client owns the namespace.
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
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// An identifier that you want to associate with the instance. Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can use this value to update an existing instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To register a new instance, you must specify a value that is unique among instances
        /// that you register by using the same service.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// The ID of the service that you want to use for settings for the resource record sets
        /// and health check that Amazon Route 53 will create.
        /// </para>
        /// </summary>
        public string ServiceId
        {
            get { return this._serviceId; }
            set { this._serviceId = value; }
        }

        // Check to see if ServiceId property is set
        internal bool IsSetServiceId()
        {
            return this._serviceId != null;
        }

    }
}