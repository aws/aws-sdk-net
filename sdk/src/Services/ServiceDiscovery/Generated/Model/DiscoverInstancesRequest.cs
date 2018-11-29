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
    /// Container for the parameters to the DiscoverInstances operation.
    /// Discovers registered instances for a specified namespace and service.
    /// </summary>
    public partial class DiscoverInstancesRequest : AmazonServiceDiscoveryRequest
    {
        private HealthStatusFilter _healthStatus;
        private int? _maxResults;
        private string _namespaceName;
        private Dictionary<string, string> _queryParameters = new Dictionary<string, string>();
        private string _serviceName;

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// The health status of the instances that you want to discover.
        /// </para>
        /// </summary>
        public HealthStatusFilter HealthStatus
        {
            get { return this._healthStatus; }
            set { this._healthStatus = value; }
        }

        // Check to see if HealthStatus property is set
        internal bool IsSetHealthStatus()
        {
            return this._healthStatus != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of instances that you want Cloud Map to return in the response
        /// to a <code>DiscoverInstances</code> request. If you don't specify a value for <code>MaxResults</code>,
        /// Cloud Map returns up to 100 instances.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The name of the namespace that you specified when you registered the instance.
        /// </para>
        /// </summary>
        public string NamespaceName
        {
            get { return this._namespaceName; }
            set { this._namespaceName = value; }
        }

        // Check to see if NamespaceName property is set
        internal bool IsSetNamespaceName()
        {
            return this._namespaceName != null;
        }

        /// <summary>
        /// Gets and sets the property QueryParameters. 
        /// <para>
        /// A string map that contains attributes with values that you can use to filter instances
        /// by any custom attribute that you specified when you registered the instance. Only
        /// instances that match all the specified key/value pairs will be returned.
        /// </para>
        /// </summary>
        public Dictionary<string, string> QueryParameters
        {
            get { return this._queryParameters; }
            set { this._queryParameters = value; }
        }

        // Check to see if QueryParameters property is set
        internal bool IsSetQueryParameters()
        {
            return this._queryParameters != null && this._queryParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service that you specified when you registered the instance.
        /// </para>
        /// </summary>
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

    }
}