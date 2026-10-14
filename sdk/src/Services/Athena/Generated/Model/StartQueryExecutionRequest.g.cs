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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Container for the parameters to the StartQueryExecution operation. Runs the SQL query
    /// statements contained in the <c>Query</c>. Requires you to have access to the workgroup
    /// in which the query ran. Running queries against an external catalog requires <a>GetDataCatalog</a>
    /// permission to the catalog. For code samples using the Amazon Web Services SDK for
    /// Java, see <a href="http://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
    /// and Code Samples</a> in the <i>Amazon Athena User Guide</i>.
    /// </summary>
    public partial class StartQueryExecutionRequest : AmazonAthenaRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique case-sensitive string used to ensure the request to create the query is idempotent
        /// (executes only once). If another <c>StartQueryExecution</c> request is received, the
        /// same response is returned and another query is not created. An error is returned if
        /// a parameter, such as <c>QueryString</c>, has changed. A call to <c>StartQueryExecution</c>
        /// that uses a previous client request token returns the same <c>QueryExecutionId</c>
        /// even if the requester doesn't have permission on the tables specified in <c>QueryString</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// This token is listed as not required because Amazon Web Services SDKs (for example
        /// the Amazon Web Services SDK for Java) auto-generate the token for users. If you are
        /// not using the Amazon Web Services SDK or the Amazon Web Services CLI, you must provide
        /// this token or the action will fail.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 32, Max = 128)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property EngineConfiguration. 
        /// <para>
        /// The engine configuration for the workgroup, which includes the minimum/maximum number
        /// of Data Processing Units (DPU) that queries should use when running in provisioned
        /// capacity. If not specified, Athena uses default values (Default value for min is 4
        /// and for max is Minimum of 124 and allocated DPUs).
        /// </para>
        ///  
        /// <para>
        /// To specify minimum and maximum DPU values for Capacity Reservations queries, the workgroup
        /// containing <c>EngineConfiguration</c> should have the following values: The name of
        /// the <c>Classifications</c> should be <c>athena-query-engine-properties</c>, with the
        /// only allowed properties as <c>max-dpu-count</c> and <c>min-dpu-count</c>.
        /// </para>
        /// </summary>
        public EngineConfiguration EngineConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EngineConfiguration property is set.
        /// </summary>
        internal bool IsSetEngineConfiguration() => this.EngineConfiguration != null;

        /// <summary>
        /// Gets and sets the property ExecutionParameters. 
        /// <para>
        /// A list of values for the parameters in a query. The values are applied sequentially
        /// to the parameters in the query in the order in which the parameters occur.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> ExecutionParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExecutionParameters property is set.
        /// </summary>
        internal bool IsSetExecutionParameters() => this.ExecutionParameters != null && (this.ExecutionParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueryExecutionContext. 
        /// <para>
        /// The database within which the query executes.
        /// </para>
        /// </summary>
        public QueryExecutionContext QueryExecutionContext { get; set; }

        /// <summary>
        /// Checks to see if the QueryExecutionContext property is set.
        /// </summary>
        internal bool IsSetQueryExecutionContext() => this.QueryExecutionContext != null;

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The SQL query statements to be executed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 262144)]
        public string QueryString { get; set; }

        /// <summary>
        /// Checks to see if the QueryString property is set.
        /// </summary>
        internal bool IsSetQueryString() => this.QueryString != null;

        /// <summary>
        /// Gets and sets the property ResultConfiguration. 
        /// <para>
        /// Specifies information about where and how to save the results of the query execution.
        /// If the query runs in a workgroup, then workgroup's settings may override query settings.
        /// This affects the query results location. The workgroup settings override is specified
        /// in EnforceWorkGroupConfiguration (true/false) in the WorkGroupConfiguration. See <a>WorkGroupConfiguration$EnforceWorkGroupConfiguration</a>.
        /// </para>
        /// </summary>
        public ResultConfiguration ResultConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ResultConfiguration property is set.
        /// </summary>
        internal bool IsSetResultConfiguration() => this.ResultConfiguration != null;

        /// <summary>
        /// Gets and sets the property ResultReuseConfiguration. 
        /// <para>
        /// Specifies the query result reuse behavior for the query.
        /// </para>
        /// </summary>
        public ResultReuseConfiguration ResultReuseConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ResultReuseConfiguration property is set.
        /// </summary>
        internal bool IsSetResultReuseConfiguration() => this.ResultReuseConfiguration != null;

        /// <summary>
        /// Gets and sets the property WorkGroup. 
        /// <para>
        /// The name of the workgroup in which the query is being started.
        /// </para>
        /// </summary>
        public string WorkGroup { get; set; }

        /// <summary>
        /// Checks to see if the WorkGroup property is set.
        /// </summary>
        internal bool IsSetWorkGroup() => this.WorkGroup != null;
    }
}
