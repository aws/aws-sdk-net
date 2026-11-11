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
    /// Container for the parameters to the ListAggregateLogGroupSummaries operation. Returns
    /// an aggregate summary of all log groups in the Region grouped by specified data source
    /// characteristics. Supports optional filtering by log group class, name patterns, and
    /// data sources. If you perform this action in a monitoring account, you can also return
    /// aggregated summaries of log groups from source accounts that are linked to the monitoring
    /// account. For more information about using cross-account observability to set up monitoring
    /// accounts and source accounts, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
    /// cross-account observability</a>. <para> The operation aggregates log groups by data
    /// source name and type and optionally format, providing counts of log groups that share
    /// these characteristics. The operation paginates results. By default, it returns up
    /// to 50 results and includes a token to retrieve more results. </para>
    /// </summary>
    public partial class ListAggregateLogGroupSummariesRequest : AmazonCloudWatchLogsRequest
    {
        /// <summary>
        /// Gets and sets the property AccountIdentifiers. 
        /// <para>
        /// When <c>includeLinkedAccounts</c> is set to <c>true</c>, use this parameter to specify
        /// the list of accounts to search. You can specify as many as 20 account IDs in the array.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<string> AccountIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AccountIdentifiers property is set.
        /// </summary>
        internal bool IsSetAccountIdentifiers() => this.AccountIdentifiers != null && (this.AccountIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataSources. 
        /// <para>
        /// Filters the results by data source characteristics to include only log groups associated
        /// with the specified data sources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<DataSourceFilter> DataSources { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSourceFilter>() : null;

        /// <summary>
        /// Checks to see if the DataSources property is set.
        /// </summary>
        internal bool IsSetDataSources() => this.DataSources != null && (this.DataSources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GroupBy. 
        /// <para>
        /// Specifies how to group the log groups in the summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ListAggregateLogGroupSummariesGroupBy GroupBy { get; set; }

        /// <summary>
        /// Checks to see if the GroupBy property is set.
        /// </summary>
        internal bool IsSetGroupBy() => this.GroupBy != null;

        /// <summary>
        /// Gets and sets the property IncludeLinkedAccounts. 
        /// <para>
        /// If you are using a monitoring account, set this to <c>true</c> to have the operation
        /// return log groups in the accounts listed in <c>accountIdentifiers</c>.
        /// </para>
        ///  
        /// <para>
        /// If this parameter is set to <c>true</c> and <c>accountIdentifiers</c> contains a null
        /// value, the operation returns all log groups in the monitoring account and all log
        /// groups in all source accounts that are linked to the monitoring account. 
        /// </para>
        ///  
        /// <para>
        /// The default for this parameter is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? IncludeLinkedAccounts { get; set; }

        /// <summary>
        /// Checks to see if the IncludeLinkedAccounts property is set.
        /// </summary>
        internal bool IsSetIncludeLinkedAccounts() => this.IncludeLinkedAccounts.HasValue;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of aggregated summaries to return. If you omit this parameter,
        /// the default is up to 50 aggregated summaries.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property LogGroupClass. 
        /// <para>
        /// Filters the results by log group class to include only log groups of the specified
        /// class.
        /// </para>
        /// </summary>
        public LogGroupClass LogGroupClass { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupClass property is set.
        /// </summary>
        internal bool IsSetLogGroupClass() => this.LogGroupClass != null;

        /// <summary>
        /// Gets and sets the property LogGroupNamePattern. 
        /// <para>
        /// Use this parameter to limit the returned log groups to only those with names that
        /// match the pattern that you specify. This parameter is a regular expression that can
        /// match prefixes and substrings, and supports wildcard matching and matching multiple
        /// patterns, as in the following examples. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use <c>^</c> to match log group names by prefix.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For a substring match, specify the string to match. All matches are case sensitive
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To match multiple patterns, separate them with a <c>|</c> as in the example <c>^/aws/lambda|discovery</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can specify as many as five different regular expression patterns in this field,
        /// each of which must be between 3 and 24 characters. You can include the <c>^</c> symbol
        /// as many as five times, and include the <c>|</c> symbol as many as four times.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 129)]
        public string LogGroupNamePattern { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupNamePattern property is set.
        /// </summary>
        internal bool IsSetLogGroupNamePattern() => this.LogGroupNamePattern != null;

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min = 1)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
