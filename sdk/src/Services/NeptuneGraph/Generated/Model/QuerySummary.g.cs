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
    /// Details of the query listed.
    /// </summary>
    public partial class QuerySummary
    {
        /// <summary>
        /// Gets and sets the property Elapsed. 
        /// <para>
        /// The running time of the query, in milliseconds.
        /// </para>
        /// </summary>
        public int? Elapsed { get; set; }

        /// <summary>
        /// Checks to see if the Elapsed property is set.
        /// </summary>
        internal bool IsSetElapsed() => this.Elapsed.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A string representation of the id of the query.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The actual query text. The <c>queryString</c> may be truncated if the actual query
        /// string is too long.
        /// </para>
        /// </summary>
        public string QueryString { get; set; }

        /// <summary>
        /// Checks to see if the QueryString property is set.
        /// </summary>
        internal bool IsSetQueryString() => this.QueryString != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// State of the query.
        /// </para>
        /// </summary>
        public QueryState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Waited. 
        /// <para>
        /// The amount of time, in milliseconds, the query has waited in the queue before being
        /// picked up by a worker thread.
        /// </para>
        /// </summary>
        public int? Waited { get; set; }

        /// <summary>
        /// Checks to see if the Waited property is set.
        /// </summary>
        internal bool IsSetWaited() => this.Waited.HasValue;
    }
}
