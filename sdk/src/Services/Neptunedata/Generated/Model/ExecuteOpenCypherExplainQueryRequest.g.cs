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
    /// Container for the parameters to the ExecuteOpenCypherExplainQuery operation. Executes
    /// an openCypher <c>explain</c> request. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-opencypher-explain.html">The
    /// openCypher explain feature</a> for more information. <para> When invoking this operation
    /// in a Neptune cluster that has IAM authentication enabled, the IAM user or role making
    /// the request must have a policy attached that allows the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#readdataviaquery">neptune-db:ReadDataViaQuery</a>
    /// IAM action in that cluster. </para> <para> Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:OpenCypher</a>
    /// IAM condition key can be used in the policy document to restrict the use of openCypher
    /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
    /// keys available in Neptune IAM data-access policy statements</a>). </para>
    /// </summary>
    public partial class ExecuteOpenCypherExplainQueryRequest : AmazonNeptunedataRequest
    {
        /// <summary>
        /// Gets and sets the property ExplainMode. 
        /// <para>
        /// The openCypher <c>explain</c> mode. Can be one of: <c>static</c>, <c>dynamic</c>,
        /// or <c>details</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OpenCypherExplainMode ExplainMode { get; set; }

        /// <summary>
        /// Checks to see if the ExplainMode property is set.
        /// </summary>
        internal bool IsSetExplainMode() => this.ExplainMode != null;

        /// <summary>
        /// Gets and sets the property OpenCypherQuery. 
        /// <para>
        /// The openCypher query string.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OpenCypherQuery { get; set; }

        /// <summary>
        /// Checks to see if the OpenCypherQuery property is set.
        /// </summary>
        internal bool IsSetOpenCypherQuery() => this.OpenCypherQuery != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The openCypher query parameters.
        /// </para>
        /// </summary>
        public string Parameters { get; set; }

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null;
    }
}
