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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTThingsGraph.Model
{
    /// <summary>
    /// Container for the parameters to the SearchEntities operation.
    /// Searches for entities of the specified type. You can search for entities in your namespace
    /// and the public namespace that you're tracking.
    /// </summary>
    public partial class SearchEntitiesRequest : AmazonIoTThingsGraphRequest
    {
        private List<string> _entityTypes = new List<string>();
        private List<EntityFilter> _filters = new List<EntityFilter>();
        private int? _maxResults;
        private long? _namespaceVersion;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property EntityTypes. 
        /// <para>
        /// The entity types for which to search.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> EntityTypes
        {
            get { return this._entityTypes; }
            set { this._entityTypes = value; }
        }

        // Check to see if EntityTypes property is set
        internal bool IsSetEntityTypes()
        {
            return this._entityTypes != null && this._entityTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Optional filter to apply to the search. Valid filters are <code>NAME</code> <code>NAMESPACE</code>,
        /// <code>SEMANTIC_TYPE_PATH</code> and <code>REFERENCED_ENTITY_ID</code>. <code>REFERENCED_ENTITY_ID</code>
        /// filters on entities that are used by the entity in the result set. For example, you
        /// can filter on the ID of a property that is used in a state.
        /// </para>
        ///  
        /// <para>
        /// Multiple filters function as OR criteria in the query. Multiple values passed inside
        /// the filter function as AND criteria.
        /// </para>
        /// </summary>
        public List<EntityFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
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
        /// Gets and sets the property NamespaceVersion. 
        /// <para>
        /// The version of the user's namespace. Defaults to the latest version of the user's
        /// namespace.
        /// </para>
        /// </summary>
        public long NamespaceVersion
        {
            get { return this._namespaceVersion.GetValueOrDefault(); }
            set { this._namespaceVersion = value; }
        }

        // Check to see if NamespaceVersion property is set
        internal bool IsSetNamespaceVersion()
        {
            return this._namespaceVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The string that specifies the next page of results. Use this when you're paginating
        /// results.
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