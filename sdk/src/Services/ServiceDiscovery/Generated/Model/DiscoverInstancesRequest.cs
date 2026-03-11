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
    /// Container for the parameters to the DiscoverInstances operation.
    /// Discovers registered instances for a specified namespace and service. You can use
    /// <c>DiscoverInstances</c> to discover instances for any type of namespace. <c>DiscoverInstances</c>
    /// returns a randomized list of instances allowing customers to distribute traffic evenly
    /// across instances. For public and private DNS namespaces, you can also use DNS queries
    /// to discover instances.
    /// </summary>
    public partial class DiscoverInstancesRequest : AmazonServiceDiscoveryRequest
    {
        private HealthStatusFilter _healthStatus;
        private int? _maxResults;
        private string _namespaceName;
        private Dictionary<string, string> _optionalParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _ownerAccount;
        private Dictionary<string, string> _queryParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _serviceName;

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// The health status of the instances that you want to discover. This parameter is ignored
        /// for services that don't have a health check configured, and all instances are returned.
        /// </para>
        ///  <dl> <dt>HEALTHY</dt> <dd> 
        /// <para>
        /// Returns healthy instances.
        /// </para>
        ///  </dd> <dt>UNHEALTHY</dt> <dd> 
        /// <para>
        /// Returns unhealthy instances.
        /// </para>
        ///  </dd> <dt>ALL</dt> <dd> 
        /// <para>
        /// Returns all instances.
        /// </para>
        ///  </dd> <dt>HEALTHY_OR_ELSE_ALL</dt> <dd> 
        /// <para>
        /// Returns healthy instances, unless none are reporting a healthy state. In that case,
        /// return all instances. This is also called failing open.
        /// </para>
        ///  </dd> </dl>
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
        /// to a <c>DiscoverInstances</c> request. If you don't specify a value for <c>MaxResults</c>,
        /// Cloud Map returns up to 100 instances.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        /// The <c>HttpName</c> name of the namespace. The <c>HttpName</c> is found in the <c>HttpProperties</c>
        /// member of the <c>Properties</c> member of the namespace. In most cases, <c>Name</c>
        /// and <c>HttpName</c> match. However, if you reuse <c>Name</c> for namespace creation,
        /// a generated hash is added to <c>HttpName</c> to distinguish the two.
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
        /// instances that match both the filters specified in both the <c>QueryParameters</c>
        /// parameter and this parameter, all of these instances are returned. Otherwise, the
        /// filters are ignored, and only instances that match the filters that are specified
        /// in the <c>QueryParameters</c> parameter are returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> OptionalParameters
        {
            get { return this._optionalParameters; }
            set { this._optionalParameters = value; }
        }

        // Check to see if OptionalParameters property is set
        internal bool IsSetOptionalParameters()
        {
            return this._optionalParameters != null && (this._optionalParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the namespace associated with
        /// the instance, as specified in the namespace <c>ResourceOwner</c> field. For instances
        /// associated with namespaces that are shared with your account, you must specify an
        /// <c>OwnerAccount</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string OwnerAccount
        {
            get { return this._ownerAccount; }
            set { this._ownerAccount = value; }
        }

        // Check to see if OwnerAccount property is set
        internal bool IsSetOwnerAccount()
        {
            return this._ownerAccount != null;
        }

        /// <summary>
        /// Gets and sets the property QueryParameters. 
        /// <para>
        /// Filters to scope the results based on custom attributes for the instance (for example,
        /// <c>{version=v1, az=1a}</c>). Only instances that match all the specified key-value
        /// pairs are returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> QueryParameters
        {
            get { return this._queryParameters; }
            set { this._queryParameters = value; }
        }

        // Check to see if QueryParameters property is set
        internal bool IsSetQueryParameters()
        {
            return this._queryParameters != null && (this._queryParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
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