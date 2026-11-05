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
    /// Container for the parameters to the ListLogGroups operation. Returns a list of log
    /// groups in the Region in your account. If you are performing this action in a monitoring
    /// account, you can choose to also return log groups from source accounts that are linked
    /// to the monitoring account. For more information about using cross-account observability
    /// to set up monitoring accounts and source accounts, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">
    /// CloudWatch cross-account observability</a>. <para> You can optionally filter the results
    /// by log group class, log group name pattern, field indexes, data sources, field index
    /// names, or log group tags. If you specify more than one filter type, the results include
    /// log groups that satisfy all filters. </para> <para> This operation is paginated. By
    /// default, your first use of this operation returns 50 results, and includes a token
    /// to use in a subsequent operation to return more results. </para>
    /// </summary>
    public partial class ListLogGroupsRequest : AmazonCloudWatchLogsRequest
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
        /// An array of data source filters to filter log groups by their associated data sources.
        /// You can filter by data source name, type, or both. Multiple filters within the same
        /// dimension are combined with OR logic, while filters across different dimensions are
        /// combined with AND logic.
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
        /// Gets and sets the property FieldIndexNames. 
        /// <para>
        /// An array of field index names to filter log groups that have specific field indexes.
        /// Only log groups containing all specified field indexes are returned. You can specify
        /// 1 to 20 field index names, each with 1 to 512 characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<string> FieldIndexNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FieldIndexNames property is set.
        /// </summary>
        internal bool IsSetFieldIndexNames() => this.FieldIndexNames != null && (this.FieldIndexNames.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// The maximum number of log groups to return. If you omit this parameter, the default
        /// is up to 50 log groups.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property LogGroupClass. 
        /// <para>
        /// Use this parameter to limit the results to only those log groups in the specified
        /// log group class. If you omit this parameter, log groups of all classes can be returned.
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
        /// Gets and sets the property LogGroupTags. 
        /// <para>
        /// An array of tag filters to return only log groups that have specific tags. Multiple
        /// filters are combined with AND logic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<TagFilter> LogGroupTags { get; set; } = AWSConfigs.InitializeCollections ? new List<TagFilter>() : null;

        /// <summary>
        /// Checks to see if the LogGroupTags property is set.
        /// </summary>
        internal bool IsSetLogGroupTags() => this.LogGroupTags != null && (this.LogGroupTags.Count > 0 || !AWSConfigs.InitializeCollections);

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
