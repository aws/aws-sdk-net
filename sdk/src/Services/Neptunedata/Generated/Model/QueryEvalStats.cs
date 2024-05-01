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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
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
        private bool? _cancelled;
        private int? _elapsed;
        private Amazon.Runtime.Documents.Document _subqueries;
        private int? _waited;

        /// <summary>
        /// Gets and sets the property Cancelled. 
        /// <para>
        /// Set to <c>TRUE</c> if the query was cancelled, or FALSE otherwise.
        /// </para>
        /// </summary>
        public bool? Cancelled
        {
            get { return this._cancelled; }
            set { this._cancelled = value; }
        }

        // Check to see if Cancelled property is set
        internal bool IsSetCancelled()
        {
            return this._cancelled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Elapsed. 
        /// <para>
        /// The number of milliseconds the query has been running so far.
        /// </para>
        /// </summary>
        public int? Elapsed
        {
            get { return this._elapsed; }
            set { this._elapsed = value; }
        }

        // Check to see if Elapsed property is set
        internal bool IsSetElapsed()
        {
            return this._elapsed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Subqueries. 
        /// <para>
        /// The number of subqueries in this query.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Subqueries
        {
            get { return this._subqueries; }
            set { this._subqueries = value; }
        }

        // Check to see if Subqueries property is set
        internal bool IsSetSubqueries()
        {
            return !this._subqueries.IsNull();
        }

        /// <summary>
        /// Gets and sets the property Waited. 
        /// <para>
        /// Indicates how long the query waited, in milliseconds.
        /// </para>
        /// </summary>
        public int? Waited
        {
            get { return this._waited; }
            set { this._waited = value; }
        }

        // Check to see if Waited property is set
        internal bool IsSetWaited()
        {
            return this._waited.HasValue; 
        }

    }
}