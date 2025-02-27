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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
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
namespace Amazon.NeptuneGraph.Model
{
    /// <summary>
    /// Container for the parameters to the ListQueries operation.
    /// Lists active openCypher queries.
    /// </summary>
    public partial class ListQueriesRequest : AmazonNeptuneGraphRequest
    {
        private string _graphIdentifier;
        private int? _maxResults;
        private QueryStateInput _state;

        /// <summary>
        /// Gets and sets the property GraphIdentifier. 
        /// <para>
        /// The unique identifier of the Neptune Analytics graph.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GraphIdentifier
        {
            get { return this._graphIdentifier; }
            set { this._graphIdentifier = value; }
        }

        // Check to see if GraphIdentifier property is set
        internal bool IsSetGraphIdentifier()
        {
            return this._graphIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to be fetched by the API.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property State. 
        /// <para>
        /// Filtered list of queries based on state.
        /// </para>
        /// </summary>
        public QueryStateInput State
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