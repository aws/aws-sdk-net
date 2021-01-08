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
    /// Container for the parameters to the DiscoverInstances operation.
    /// Discovers registered instances for a specified namespace and service. You can use
    /// <code>DiscoverInstances</code> to discover instances for any type of namespace. For
    /// public and private DNS namespaces, you can also use DNS queries to discover instances.
    /// </summary>
    public partial class DiscoverInstancesRequest : AmazonServiceDiscoveryRequest
    {
        private HealthStatusFilter _healthStatus;
        private int? _maxResults;
        private string _namespaceName;
        private Dictionary<string, string> _optionalParameters = new Dictionary<string, string>();
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
        /// The maximum number of instances that you want AWS Cloud Map to return in the response
        /// to a <code>DiscoverInstances</code> request. If you don't specify a value for <code>MaxResults</code>,
        /// AWS Cloud Map returns up to 100 instances.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        [AWSProperty(Required=true, Max=1024)]
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
        /// Gets and sets the property OptionalParameters. 
        /// <para>
        /// Opportunistic filters to scope the results based on custom attributes. If there are
        /// instances that match both the filters specified in both the <code>QueryParameters</code>
        /// parameter and this parameter, they are returned. Otherwise, these filters are ignored
        /// and only instances that match the filters specified in the <code>QueryParameters</code>
        /// parameter are returned.
        /// </para>
        /// </summary>
        public Dictionary<string, string> OptionalParameters
        {
            get { return this._optionalParameters; }
            set { this._optionalParameters = value; }
        }

        // Check to see if OptionalParameters property is set
        internal bool IsSetOptionalParameters()
        {
            return this._optionalParameters != null && this._optionalParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property QueryParameters. 
        /// <para>
        /// Filters to scope the results based on custom attributes for the instance. For example,
        /// <code>{version=v1, az=1a}</code>. Only instances that match all the specified key-value
        /// pairs will be returned.
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
        [AWSProperty(Required=true)]
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