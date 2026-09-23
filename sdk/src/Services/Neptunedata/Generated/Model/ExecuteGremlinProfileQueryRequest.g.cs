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
    /// Container for the parameters to the ExecuteGremlinProfileQuery operation. Executes
    /// a Gremlin Profile query, which runs a specified traversal, collects various metrics
    /// about the run, and produces a profile report as output. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/gremlin-profile-api.html">Gremlin
    /// profile API in Neptune</a> for details. <para> When invoking this operation in a Neptune
    /// cluster that has IAM authentication enabled, the IAM user or role making the request
    /// must have a policy attached that allows the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#readdataviaquery">neptune-db:ReadDataViaQuery</a>
    /// IAM action in that cluster. </para> <para> Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Gremlin</a>
    /// IAM condition key can be used in the policy document to restrict the use of Gremlin
    /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
    /// keys available in Neptune IAM data-access policy statements</a>). </para>
    /// </summary>
    public partial class ExecuteGremlinProfileQueryRequest : AmazonNeptunedataRequest
    {
        /// <summary>
        /// Gets and sets the property Chop. 
        /// <para>
        /// If non-zero, causes the results string to be truncated at that number of characters.
        /// If set to zero, the string contains all the results.
        /// </para>
        /// </summary>
        public int? Chop { get; set; }

        /// <summary>
        /// Checks to see if the Chop property is set.
        /// </summary>
        internal bool IsSetChop() => this.Chop.HasValue;

        /// <summary>
        /// Gets and sets the property GremlinQuery. 
        /// <para>
        /// The Gremlin query string to profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GremlinQuery { get; set; }

        /// <summary>
        /// Checks to see if the GremlinQuery property is set.
        /// </summary>
        internal bool IsSetGremlinQuery() => this.GremlinQuery != null;

        /// <summary>
        /// Gets and sets the property IndexOps. 
        /// <para>
        /// If this flag is set to <c>TRUE</c>, the results include a detailed report of all index
        /// operations that took place during query execution and serialization.
        /// </para>
        /// </summary>
        public bool? IndexOps { get; set; }

        /// <summary>
        /// Checks to see if the IndexOps property is set.
        /// </summary>
        internal bool IsSetIndexOps() => this.IndexOps.HasValue;

        /// <summary>
        /// Gets and sets the property Results. 
        /// <para>
        /// If this flag is set to <c>TRUE</c>, the query results are gathered and displayed as
        /// part of the profile report. If <c>FALSE</c>, only the result count is displayed.
        /// </para>
        /// </summary>
        public bool? Results { get; set; }

        /// <summary>
        /// Checks to see if the Results property is set.
        /// </summary>
        internal bool IsSetResults() => this.Results.HasValue;

        /// <summary>
        /// Gets and sets the property Serializer. 
        /// <para>
        /// If non-null, the gathered results are returned in a serialized response message in
        /// the format specified by this parameter. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/gremlin-profile-api.html">Gremlin
        /// profile API in Neptune</a> for more information.
        /// </para>
        /// </summary>
        public string Serializer { get; set; }

        /// <summary>
        /// Checks to see if the Serializer property is set.
        /// </summary>
        internal bool IsSetSerializer() => this.Serializer != null;
    }
}
