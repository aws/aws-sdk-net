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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This is the response object from the GetQueryResults operation.
    /// </summary>
    public partial class GetQueryResultsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        /// If you associated an KMS key with the CloudWatch Logs Insights query results in this
        /// account, this field displays the ARN of the key that's used to encrypt the query results
        /// when <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_StartQuery.html">StartQuery</a>
        /// stores them.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKey property is set.
        /// </summary>
        internal bool IsSetEncryptionKey() => this.EncryptionKey != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are more log events remaining in the results, the response includes a <c>nextToken</c>.
        /// You can use this token in a subsequent <c>GetQueryResults</c> request to get the next
        /// set of results. You can retrieve up to 100,000 log event results from a query by paginating
        /// with this token. This is only supported for Logs Insights QL and is currently not
        /// supported for PPL and SQL query languages.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property QueryLanguage. 
        /// <para>
        /// The query language used for this query. For more information about the query languages
        /// that CloudWatch Logs supports, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CWL_AnalyzeLogData_Languages.html">Supported
        /// query languages</a>.
        /// </para>
        /// </summary>
        public QueryLanguage QueryLanguage { get; set; }

        /// <summary>
        /// Checks to see if the QueryLanguage property is set.
        /// </summary>
        internal bool IsSetQueryLanguage() => this.QueryLanguage != null;

        /// <summary>
        /// Gets and sets the property Results. 
        /// <para>
        /// The log events that matched the query criteria during the most recent time it ran.
        /// </para>
        ///  
        /// <para>
        /// The <c>results</c> value is an array of arrays. Each log event is one object in the
        /// top-level array. Each of these log event objects is an array of <c>field</c>/<c>value</c>
        /// pairs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<List<ResultField>> Results { get; set; } = AWSConfigs.InitializeCollections ? new List<List<ResultField>>() : null;

        /// <summary>
        /// Checks to see if the Results property is set.
        /// </summary>
        internal bool IsSetResults() => this.Results != null && (this.Results.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// Includes the number of log events scanned by the query, the number of log events that
        /// matched the query criteria, and the total number of bytes in the scanned log events.
        /// These values reflect the full raw results of the query.
        /// </para>
        /// </summary>
        public QueryStatistics Statistics { get; set; }

        /// <summary>
        /// Checks to see if the Statistics property is set.
        /// </summary>
        internal bool IsSetStatistics() => this.Statistics != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the most recent running of the query. Possible values are <c>Cancelled</c>,
        /// <c>Complete</c>, <c>Failed</c>, <c>Running</c>, <c>Scheduled</c>, <c>Timeout</c>,
        /// and <c>Unknown</c>.
        /// </para>
        ///  
        /// <para>
        /// Queries time out after 60 minutes of runtime. To avoid having your queries time out,
        /// reduce the time range being searched or partition your query into a number of queries.
        /// </para>
        /// </summary>
        public QueryStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
