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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// This is the response object from the ListServerNeighbors operation.
    /// </summary>
    public partial class ListServerNeighborsResponse : AmazonWebServiceResponse
    {
        private long? _knownDependencyCount;
        private List<NeighborConnectionDetail> _neighbors = new List<NeighborConnectionDetail>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property KnownDependencyCount. 
        /// <para>
        /// Count of distinct servers that are one hop away from the given server.
        /// </para>
        /// </summary>
        public long KnownDependencyCount
        {
            get { return this._knownDependencyCount.GetValueOrDefault(); }
            set { this._knownDependencyCount = value; }
        }

        // Check to see if KnownDependencyCount property is set
        internal bool IsSetKnownDependencyCount()
        {
            return this._knownDependencyCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Neighbors. 
        /// <para>
        /// List of distinct servers that are one hop away from the given server.
        /// </para>
        /// </summary>
        public List<NeighborConnectionDetail> Neighbors
        {
            get { return this._neighbors; }
            set { this._neighbors = value; }
        }

        // Check to see if Neighbors property is set
        internal bool IsSetNeighbors()
        {
            return this._neighbors != null && this._neighbors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token to retrieve the next set of results. For example, if you specified 100 IDs for
        /// <code>ListServerNeighborsRequest$neighborConfigurationIds</code> but set <code>ListServerNeighborsRequest$maxResults</code>
        /// to 10, you received a set of 10 results along with this token. Use this token in the
        /// next query to retrieve the next set of 10.
        /// </para>
        /// </summary>
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

    }
}