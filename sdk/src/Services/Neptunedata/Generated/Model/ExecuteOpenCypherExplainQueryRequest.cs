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
    /// Container for the parameters to the ExecuteOpenCypherExplainQuery operation.
    /// Executes an openCypher <code>explain</code> request. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-opencypher-explain.html">The
    /// openCypher explain feature</a> for more information.
    /// </summary>
    public partial class ExecuteOpenCypherExplainQueryRequest : AmazonNeptunedataRequest
    {
        private OpenCypherExplainMode _explainMode;
        private string _openCypherQuery;
        private string _parameters;

        /// <summary>
        /// Gets and sets the property ExplainMode. 
        /// <para>
        /// The openCypher <code>explain</code> mode. Can be one of: <code>static</code>, <code>dynamic</code>,
        /// or <code>details</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OpenCypherExplainMode ExplainMode
        {
            get { return this._explainMode; }
            set { this._explainMode = value; }
        }

        // Check to see if ExplainMode property is set
        internal bool IsSetExplainMode()
        {
            return this._explainMode != null;
        }

        /// <summary>
        /// Gets and sets the property OpenCypherQuery. 
        /// <para>
        /// The openCypher query string.
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
        /// The openCypher query parameters.
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