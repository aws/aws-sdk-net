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
    /// Container for the parameters to the ExecuteGremlinQuery operation.
    /// This commands executes a Gremlin query. Amazon Neptune is compatible with Apache TinkerPop3
    /// and Gremlin, so you can use the Gremlin traversal language to query the graph, as
    /// described under <a href="https://tinkerpop.apache.org/docs/current/reference/#graph">The
    /// Graph</a> in the Apache TinkerPop3 documentation. More details can also be found in
    /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-gremlin.html">Accessing
    /// a Neptune graph with Gremlin</a>.
    /// 
    ///  
    /// <para>
    /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
    /// the IAM user or role making the request must have a policy attached that enables one
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
    public partial class ExecuteGremlinQueryRequest : AmazonNeptunedataRequest
    {
        private string _gremlinQuery;
        private string _serializer;

        /// <summary>
        /// Gets and sets the property GremlinQuery. 
        /// <para>
        /// Using this API, you can run Gremlin queries in string format much as you can using
        /// the HTTP endpoint. The interface is compatible with whatever Gremlin version your
        /// DB cluster is using (see the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-gremlin-client.html#best-practices-gremlin-java-latest">Tinkerpop
        /// client section</a> to determine which Gremlin releases your engine version supports).
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
        /// Gets and sets the property Serializer. 
        /// <para>
        /// If non-null, the query results are returned in a serialized response message in the
        /// format specified by this parameter. See the <a href="https://tinkerpop.apache.org/docs/current/reference/#_graphson">GraphSON</a>
        /// section in the TinkerPop documentation for a list of the formats that are currently
        /// supported.
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