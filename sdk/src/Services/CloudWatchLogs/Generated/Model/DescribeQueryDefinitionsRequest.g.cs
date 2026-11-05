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
    /// Container for the parameters to the DescribeQueryDefinitions operation. This operation
    /// returns a paginated list of your saved CloudWatch Logs Insights query definitions.
    /// You can retrieve query definitions from the current account or from a source account
    /// that is linked to the current account. <para> You can use the <c>queryDefinitionNamePrefix</c>
    /// parameter to limit the results to only the query definitions that have names that
    /// start with a certain string. </para>
    /// </summary>
    public partial class DescribeQueryDefinitionsRequest : AmazonCloudWatchLogsRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Limits the number of returned query definitions to the specified number.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min = 1)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property QueryDefinitionNamePrefix. 
        /// <para>
        /// Use this parameter to filter your results to only the query definitions that have
        /// names that start with the prefix you specify.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string QueryDefinitionNamePrefix { get; set; }

        /// <summary>
        /// Checks to see if the QueryDefinitionNamePrefix property is set.
        /// </summary>
        internal bool IsSetQueryDefinitionNamePrefix() => this.QueryDefinitionNamePrefix != null;

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
    }
}
