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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Container for the parameters to the StartQueryExecution operation.
    /// Runs the SQL query statements contained in the <code>Query</code>. Requires you to
    /// have access to the workgroup in which the query ran. Running queries against an external
    /// catalog requires <a>GetDataCatalog</a> permission to the catalog. For code samples
    /// using the AWS SDK for Java, see <a href="http://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
    /// and Code Samples</a> in the <i>Amazon Athena User Guide</i>.
    /// </summary>
    public partial class StartQueryExecutionRequest : AmazonAthenaRequest
    {
        private string _clientRequestToken;
        private QueryExecutionContext _queryExecutionContext;
        private string _queryString;
        private ResultConfiguration _resultConfiguration;
        private string _workGroup;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique case-sensitive string used to ensure the request to create the query is idempotent
        /// (executes only once). If another <code>StartQueryExecution</code> request is received,
        /// the same response is returned and another query is not created. If a parameter has
        /// changed, for example, the <code>QueryString</code>, an error is returned.
        /// </para>
        ///  <important> 
        /// <para>
        /// This token is listed as not required because AWS SDKs (for example the AWS SDK for
        /// Java) auto-generate the token for users. If you are not using the AWS SDK or the AWS
        /// CLI, you must provide this token or the action will fail.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=32, Max=128)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property QueryExecutionContext. 
        /// <para>
        /// The database within which the query executes.
        /// </para>
        /// </summary>
        public QueryExecutionContext QueryExecutionContext
        {
            get { return this._queryExecutionContext; }
            set { this._queryExecutionContext = value; }
        }

        // Check to see if QueryExecutionContext property is set
        internal bool IsSetQueryExecutionContext()
        {
            return this._queryExecutionContext != null;
        }

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The SQL query statements to be executed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=262144)]
        public string QueryString
        {
            get { return this._queryString; }
            set { this._queryString = value; }
        }

        // Check to see if QueryString property is set
        internal bool IsSetQueryString()
        {
            return this._queryString != null;
        }

        /// <summary>
        /// Gets and sets the property ResultConfiguration. 
        /// <para>
        /// Specifies information about where and how to save the results of the query execution.
        /// If the query runs in a workgroup, then workgroup's settings may override query settings.
        /// This affects the query results location. The workgroup settings override is specified
        /// in EnforceWorkGroupConfiguration (true/false) in the WorkGroupConfiguration. See <a>WorkGroupConfiguration$EnforceWorkGroupConfiguration</a>.
        /// </para>
        /// </summary>
        public ResultConfiguration ResultConfiguration
        {
            get { return this._resultConfiguration; }
            set { this._resultConfiguration = value; }
        }

        // Check to see if ResultConfiguration property is set
        internal bool IsSetResultConfiguration()
        {
            return this._resultConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property WorkGroup. 
        /// <para>
        /// The name of the workgroup in which the query is being started.
        /// </para>
        /// </summary>
        public string WorkGroup
        {
            get { return this._workGroup; }
            set { this._workGroup = value; }
        }

        // Check to see if WorkGroup property is set
        internal bool IsSetWorkGroup()
        {
            return this._workGroup != null;
        }

    }
}