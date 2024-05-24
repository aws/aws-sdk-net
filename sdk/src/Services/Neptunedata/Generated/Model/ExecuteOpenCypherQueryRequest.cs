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
    /// Container for the parameters to the ExecuteOpenCypherQuery operation.
    /// Executes an openCypher query. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-opencypher.html">Accessing
    /// the Neptune Graph with openCypher</a> for more information.
    /// 
    ///  
    /// <para>
    /// Neptune supports building graph applications using openCypher, which is currently
    /// one of the most popular query languages among developers working with graph databases.
    /// Developers, business analysts, and data scientists like openCypher's declarative,
    /// SQL-inspired syntax because it provides a familiar structure in which to querying
    /// property graphs.
    /// </para>
    ///  
    /// <para>
    /// The openCypher language was originally developed by Neo4j, then open-sourced in 2015
    /// and contributed to the <a href="https://opencypher.org/">openCypher project</a> under
    /// an Apache 2 open-source license.
    /// </para>
    ///  
    /// <para>
    /// Note that when invoking this operation in a Neptune cluster that has IAM authentication
    /// enabled, the IAM user or role making the request must have a policy attached that
    /// allows one of the following IAM actions in that cluster, depending on the query:
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
    /// Note also that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:OpenCypher</a>
    /// IAM condition key can be used in the policy document to restrict the use of openCypher
    /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
    /// keys available in Neptune IAM data-access policy statements</a>).
    /// </para>
    /// </summary>
    public partial class ExecuteOpenCypherQueryRequest : AmazonNeptunedataRequest
    {
        private string _openCypherQuery;
        private string _parameters;

        /// <summary>
        /// Gets and sets the property OpenCypherQuery. 
        /// <para>
        /// The openCypher query string to be executed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OpenCypherQuery
        {
            get { return this._openCypherQuery; }
            set { this._openCypherQuery = value; }
        }

        // Check to see if OpenCypherQuery property is set
        internal bool IsSetOpenCypherQuery()
        {
            return this._openCypherQuery != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The openCypher query parameters for query execution. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/opencypher-parameterized-queries.html">Examples
        /// of openCypher parameterized queries</a> for more information.
        /// </para>
        /// </summary>
        public string Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null;
        }

    }
}