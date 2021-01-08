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
    /// Container for the parameters to the UpdateService operation.
    /// Submits a request to perform the following operations:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Update the TTL setting for existing <code>DnsRecords</code> configurations
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Add, update, or delete <code>HealthCheckConfig</code> for a specified service
    /// </para>
    ///  <note> 
    /// <para>
    /// You can't add, update, or delete a <code>HealthCheckCustomConfig</code> configuration.
    /// </para>
    ///  </note> </li> </ul> 
    /// <para>
    /// For public and private DNS namespaces, note the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If you omit any existing <code>DnsRecords</code> or <code>HealthCheckConfig</code>
    /// configurations from an <code>UpdateService</code> request, the configurations are
    /// deleted from the service.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you omit an existing <code>HealthCheckCustomConfig</code> configuration from an
    /// <code>UpdateService</code> request, the configuration is not deleted from the service.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When you update settings for a service, AWS Cloud Map also updates the corresponding
    /// settings in all the records and health checks that were created by using the specified
    /// service.
    /// </para>
    /// </summary>
    public partial class UpdateServiceRequest : AmazonServiceDiscoveryRequest
    {
        private string _id;
        private ServiceChange _service;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the service that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
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

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// A complex type that contains the new settings for the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceChange Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

    }
}