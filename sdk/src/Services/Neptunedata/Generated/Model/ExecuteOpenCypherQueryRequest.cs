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