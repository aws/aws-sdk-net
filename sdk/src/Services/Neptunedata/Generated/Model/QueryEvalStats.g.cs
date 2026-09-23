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

namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// Structure to capture query statistics such as how many queries are running, accepted
    /// or waiting and their details.
    /// </summary>
    public partial class QueryEvalStats
    {
        /// <summary>
        /// Gets and sets the property Cancelled. 
        /// <para>
        /// Set to <c>TRUE</c> if the query was cancelled, or FALSE otherwise.
        /// </para>
        /// </summary>
        public bool? Cancelled { get; set; }

        /// <summary>
        /// Checks to see if the Cancelled property is set.
        /// </summary>
        internal bool IsSetCancelled() => this.Cancelled.HasValue;

        /// <summary>
        /// Gets and sets the property Elapsed. 
        /// <para>
        /// The number of milliseconds the query has been running so far.
        /// </para>
        /// </summary>
        public int? Elapsed { get; set; }

        /// <summary>
        /// Checks to see if the Elapsed property is set.
        /// </summary>
        internal bool IsSetElapsed() => this.Elapsed.HasValue;

        /// <summary>
        /// Gets and sets the property Subqueries. 
        /// <para>
        /// The number of subqueries in this query.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Subqueries { get; set; }

        /// <summary>
        /// Checks to see if the Subqueries property is set.
        /// </summary>
        internal bool IsSetSubqueries() => !this.Subqueries.IsNull();

        /// <summary>
        /// Gets and sets the property Waited. 
        /// <para>
        /// Indicates how long the query waited, in milliseconds.
        /// </para>
        /// </summary>
        public int? Waited { get; set; }

        /// <summary>
        /// Checks to see if the Waited property is set.
        /// </summary>
        internal bool IsSetWaited() => this.Waited.HasValue;
    }
}
