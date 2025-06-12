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
    /// Container for the parameters to the ExecuteQuery operation.
    /// Execute an openCypher query.
    /// 
    ///  
    /// <para>
    ///  When invoking this operation in a Neptune Analytics cluster, the IAM user or role
    /// making the request must have a policy attached that allows one of the following IAM
    /// actions in that cluster, depending on the query: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// neptune-graph:ReadDataViaQuery
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// neptune-graph:WriteDataViaQuery
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// neptune-graph:DeleteDataViaQuery
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ExecuteQueryRequest : AmazonNeptuneGraphRequest
    {
        private ExplainMode _explainMode;
        private string _graphIdentifier;
        private QueryLanguage _language;
        private Dictionary<string, Amazon.Runtime.Documents.Document> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, Amazon.Runtime.Documents.Document>() : null;
        private PlanCacheType _planCache;
        private string _queryString;
        private int? _queryTimeoutMilliseconds;

        /// <summary>
        /// Gets and sets the property ExplainMode. 
        /// <para>
        /// The explain mode parameter returns a query explain instead of the actual query results.
        /// A query explain can be used to gather insights about the query execution such as planning
        /// decisions, time spent on each operator, solutions flowing etc.
        /// </para>
        /// </summary>
        public ExplainMode ExplainMode
        {
            get { return this._explainMode; }
            set { this._explainMode = value; }
        }

        // Check to see if ExplainMode property is set
        internal bool IsSetExplainMode()
        {
            return this._explainMode != null;
        }

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
        /// Gets and sets the property Language. 
        /// <para>
        /// The query language the query is written in. Currently only openCypher is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public QueryLanguage Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The data parameters the query can use in JSON format. For example: {"name": "john",
        /// "age": 20}. (optional) 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Amazon.Runtime.Documents.Document> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PlanCache. 
        /// <para>
        /// Query plan cache is a feature that saves the query plan and reuses it on successive
        /// executions of the same query. This reduces query latency, and works for both <c>READ</c>
        /// and <c>UPDATE</c> queries. The plan cache is an LRU cache with a 5 minute TTL and
        /// a capacity of 1000.
        /// </para>
        /// </summary>
        public PlanCacheType PlanCache
        {
            get { return this._planCache; }
            set { this._planCache = value; }
        }

        // Check to see if PlanCache property is set
        internal bool IsSetPlanCache()
        {
            return this._planCache != null;
        }

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The query string to be executed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QueryString
        {
            get { return this._queryString; }
            set { this._queryString = value; }
        }

        // Check to see if QueryString property is set
        internal bool IsSetQueryString()
        {
            return this._queryString != null;
        }

        /// <summary>
        /// Gets and sets the property QueryTimeoutMilliseconds. 
        /// <para>
        /// Specifies the query timeout duration, in milliseconds. (optional)
        /// </para>
        /// </summary>
        public int? QueryTimeoutMilliseconds
        {
            get { return this._queryTimeoutMilliseconds; }
            set { this._queryTimeoutMilliseconds = value; }
        }

        // Check to see if QueryTimeoutMilliseconds property is set
        internal bool IsSetQueryTimeoutMilliseconds()
        {
            return this._queryTimeoutMilliseconds.HasValue; 
        }

    }
}