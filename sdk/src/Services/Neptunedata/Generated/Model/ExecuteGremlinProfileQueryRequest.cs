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
    /// Container for the parameters to the ExecuteGremlinProfileQuery operation.
    /// Executes a Gremlin Profile query, which runs a specified traversal, collects various
    /// metrics about the run, and produces a profile report as output. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/gremlin-profile-api.html">Gremlin
    /// profile API in Neptune</a> for details.
    /// 
    ///  
    /// <para>
    /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
    /// the IAM user or role making the request must have a policy attached that allows the
    /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#readdataviaquery">neptune-db:ReadDataViaQuery</a>
    /// IAM action in that cluster.
    /// </para>
    ///  
    /// <para>
    /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Gremlin</a>
    /// IAM condition key can be used in the policy document to restrict the use of Gremlin
    /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
    /// keys available in Neptune IAM data-access policy statements</a>).
    /// </para>
    /// </summary>
    public partial class ExecuteGremlinProfileQueryRequest : AmazonNeptunedataRequest
    {
        private int? _chop;
        private string _gremlinQuery;
        private bool? _indexOps;
        private bool? _results;
        private string _serializer;

        /// <summary>
        /// Gets and sets the property Chop. 
        /// <para>
        /// If non-zero, causes the results string to be truncated at that number of characters.
        /// If set to zero, the string contains all the results.
        /// </para>
        /// </summary>
        public int? Chop
        {
            get { return this._chop; }
            set { this._chop = value; }
        }

        // Check to see if Chop property is set
        internal bool IsSetChop()
        {
            return this._chop.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GremlinQuery. 
        /// <para>
        /// The Gremlin query string to profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GremlinQuery
        {
            get { return this._gremlinQuery; }
            set { this._gremlinQuery = value; }
        }

        // Check to see if GremlinQuery property is set
        internal bool IsSetGremlinQuery()
        {
            return this._gremlinQuery != null;
        }

        /// <summary>
        /// Gets and sets the property IndexOps. 
        /// <para>
        /// If this flag is set to <c>TRUE</c>, the results include a detailed report of all index
        /// operations that took place during query execution and serialization.
        /// </para>
        /// </summary>
        public bool? IndexOps
        {
            get { return this._indexOps; }
            set { this._indexOps = value; }
        }

        // Check to see if IndexOps property is set
        internal bool IsSetIndexOps()
        {
            return this._indexOps.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Results. 
        /// <para>
        /// If this flag is set to <c>TRUE</c>, the query results are gathered and displayed as
        /// part of the profile report. If <c>FALSE</c>, only the result count is displayed.
        /// </para>
        /// </summary>
        public bool? Results
        {
            get { return this._results; }
            set { this._results = value; }
        }

        // Check to see if Results property is set
        internal bool IsSetResults()
        {
            return this._results.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Serializer. 
        /// <para>
        /// If non-null, the gathered results are returned in a serialized response message in
        /// the format specified by this parameter. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/gremlin-profile-api.html">Gremlin
        /// profile API in Neptune</a> for more information.
        /// </para>
        /// </summary>
        public string Serializer
        {
            get { return this._serializer; }
            set { this._serializer = value; }
        }

        // Check to see if Serializer property is set
        internal bool IsSetSerializer()
        {
            return this._serializer != null;
        }

    }
}