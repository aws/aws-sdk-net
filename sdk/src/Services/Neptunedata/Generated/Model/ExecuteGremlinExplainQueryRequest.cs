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
    /// Container for the parameters to the ExecuteGremlinExplainQuery operation.
    /// Executes a Gremlin Explain query.
    /// 
    ///  
    /// <para>
    /// Amazon Neptune has added a Gremlin feature named <c>explain</c> that provides is a
    /// self-service tool for understanding the execution approach being taken by the Neptune
    /// engine for the query. You invoke it by adding an <c>explain</c> parameter to an HTTP
    /// call that submits a Gremlin query.
    /// </para>
    ///  
    /// <para>
    /// The explain feature provides information about the logical structure of query execution
    /// plans. You can use this information to identify potential evaluation and execution
    /// bottlenecks and to tune your query, as explained in <a href="https://docs.aws.amazon.com/neptune/latest/userguide/gremlin-traversal-tuning.html">Tuning
    /// Gremlin queries</a>. You can also use query hints to improve query execution plans.
    /// </para>
    ///  
    /// <para>
    /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
    /// the IAM user or role making the request must have a policy attached that allows one
    /// of the following IAM actions in that cluster, depending on the query:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#readdataviaquery">neptune-db:ReadDataViaQuery</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#writedataviaquery">neptune-db:WriteDataViaQuery</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#deletedataviaquery">neptune-db:DeleteDataViaQuery</a>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Gremlin</a>
    /// IAM condition key can be used in the policy document to restrict the use of Gremlin
    /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
    /// keys available in Neptune IAM data-access policy statements</a>).
    /// </para>
    /// </summary>
    public partial class ExecuteGremlinExplainQueryRequest : AmazonNeptunedataRequest
    {
        private string _gremlinQuery;

        /// <summary>
        /// Gets and sets the property GremlinQuery. 
        /// <para>
        /// The Gremlin explain query string.
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

    }
}