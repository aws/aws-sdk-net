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
 * Do not modify this file. This file is generated from the interconnect-2022-07-26.normal.json service model.
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
namespace Amazon.Interconnect.Model
{
    /// <summary>
    /// Container for the parameters to the ListConnections operation.
    /// Lists all connection objects to which the caller has access.
    /// 
    ///  
    /// <para>
    /// Allows for optional filtering by the following properties:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>state</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>environmentId</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>provider</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>attach point</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Only <a>Connection</a> objects matching all filters will be returned.
    /// </para>
    /// </summary>
    public partial class ListConnectionsRequest : AmazonInterconnectRequest
    {
        private AttachPoint _attachPoint;
        private string _environmentId;
        private int? _maxResults;
        private string _nextToken;
        private Provider _provider;
        private ConnectionState _state;

        /// <summary>
        /// Gets and sets the property AttachPoint. 
        /// <para>
        /// Filter results to only include <a>Connection</a> objects attached to the given <a>AttachPoint</a>.
        /// </para>
        /// </summary>
        public AttachPoint AttachPoint
        {
            get { return this._attachPoint; }
            set { this._attachPoint = value; }
        }

        // Check to see if AttachPoint property is set
        internal bool IsSetAttachPoint()
        {
            return this._attachPoint != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// Filter the results to only include <a>Connection</a> objects on the given <a>Environment</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The max number of list results in a single paginated response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token from a previous paginated response indicating you wish to get the
        /// next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// Filter the results to only include <a>Connection</a> objects to the given <a>Provider</a>.
        /// </para>
        /// </summary>
        public Provider Provider
        {
            get { return this._provider; }
            set { this._provider = value; }
        }

        // Check to see if Provider property is set
        internal bool IsSetProvider()
        {
            return this._provider != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Filter the results to only include <a>Connection</a> objects in the given <a>Connection$state</a>.
        /// </para>
        /// </summary>
        public ConnectionState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}