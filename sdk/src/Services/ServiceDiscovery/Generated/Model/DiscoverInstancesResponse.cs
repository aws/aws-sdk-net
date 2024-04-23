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
    /// This is the response object from the DiscoverInstances operation.
    /// </summary>
    public partial class DiscoverInstancesResponse : AmazonWebServiceResponse
    {
        private List<HttpInstanceSummary> _instances = AWSConfigs.InitializeCollections ? new List<HttpInstanceSummary>() : null;
        private long? _instancesRevision;

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// A complex type that contains one <c>HttpInstanceSummary</c> for each registered instance.
        /// </para>
        /// </summary>
        public List<HttpInstanceSummary> Instances
        {
            get { return this._instances; }
            set { this._instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this._instances != null && (this._instances.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstancesRevision. 
        /// <para>
        /// The increasing revision associated to the response Instances list. If a new instance
        /// is registered or deregistered, the <c>InstancesRevision</c> updates. The health status
        /// updates don't update <c>InstancesRevision</c>.
        /// </para>
        /// </summary>
        public long InstancesRevision
        {
            get { return this._instancesRevision.GetValueOrDefault(); }
            set { this._instancesRevision = value; }
        }

        // Check to see if InstancesRevision property is set
        internal bool IsSetInstancesRevision()
        {
            return this._instancesRevision.HasValue; 
        }

    }
}