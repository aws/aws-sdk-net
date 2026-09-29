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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the ListQueries operation. Lists active openCypher
    /// queries.
    /// </summary>
    public partial class ListQueriesRequest : AmazonNeptuneGraphRequest
    {
        /// <summary>
        /// Gets and sets the property GraphIdentifier. 
        /// <para>
        /// The unique identifier of the Neptune Analytics graph.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GraphIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the GraphIdentifier property is set.
        /// </summary>
        internal bool IsSetGraphIdentifier() => this.GraphIdentifier != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to be fetched by the API.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Filtered list of queries based on state.
        /// </para>
        /// </summary>
        public QueryStateInput State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
