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
    /// This is the response object from the ListQueries operation.
    /// </summary>
    public partial class ListQueriesResponse : AmazonWebServiceResponse
    {
        private List<QuerySummary> _queries = AWSConfigs.InitializeCollections ? new List<QuerySummary>() : null;

        /// <summary>
        /// Gets and sets the property Queries. 
        /// <para>
        /// A list of current openCypher queries.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<QuerySummary> Queries
        {
            get { return this._queries; }
            set { this._queries = value; }
        }

        // Check to see if Queries property is set
        internal bool IsSetQueries()
        {
            return this._queries != null && (this._queries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}