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
        /// A string map that contains attribute keys and values. Supported attribute keys include
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
        ///  <code>AWS_INSTANCE_IP</code>: If the service that you specify contains a resource
        /// record set template for an A or AAAA record, the IP address that you want Amazon Route
        /// 53 to use for the value of the A record.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS_INSTANCE_WEIGHT</code>: The weight value in an SRV record if the service
        /// that you specify includes an SRV record. You can also specify a default weight that
        /// is applied to all instances in the <code>Service</code> configuration. For more information,
        /// see <a>CreateService</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS_INSTANCE_PRIORITY</code>: The priority value in an SRV record if the service
        /// that you specify includes an SRV record.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// An identifier that you want to associate with the instance. Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can use this value to update an existing instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To associate a new instance, you must specify a value that is unique among instances
        /// that you associate by using the same service.
        /// </para>
        ///  </li> </ul>
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