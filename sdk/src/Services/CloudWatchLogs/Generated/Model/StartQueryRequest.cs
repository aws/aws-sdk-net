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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
    /// Container for the parameters to the StartQuery operation.
    /// Starts a query of one or more log groups using CloudWatch Logs Insights. You specify
    /// the log groups and time range to query and the query string to use.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CWL_QuerySyntax.html">CloudWatch
    /// Logs Insights Query Syntax</a>.
    /// </para>
    ///  
    /// <para>
    /// After you run a query using <c>StartQuery</c>, the query results are stored by CloudWatch
    /// Logs. You can use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetQueryResults.html">GetQueryResults</a>
    /// to retrieve the results of a query, using the <c>queryId</c> that <c>StartQuery</c>
    /// returns. 
    /// </para>
    ///  <note> 
    /// <para>
    /// To specify the log groups to query, a <c>StartQuery</c> operation must include one
    /// of the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Either exactly one of the following parameters: <c>logGroupName</c>, <c>logGroupNames</c>,
    /// or <c>logGroupIdentifiers</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Or the <c>queryString</c> must include a <c>SOURCE</c> command to select log groups
    /// for the query. The <c>SOURCE</c> command can select log groups based on log group
    /// name prefix, account ID, and log class. 
    /// </para>
    ///  
    /// <para>
    /// For more information about the <c>SOURCE</c> command, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CWL_QuerySyntax-Source.html">SOURCE</a>.
    /// </para>
    ///  </li> </ul> </note> 
    /// <para>
    /// If you have associated a KMS key with the query results in this account, then <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_StartQuery.html">StartQuery</a>
    /// uses that key to encrypt the results when it stores them. If no key is associated
    /// with query results, the query results are encrypted with the default CloudWatch Logs
    /// encryption method.
    /// </para>
    ///  
    /// <para>
    /// Queries time out after 60 minutes of runtime. If your queries are timing out, reduce
    /// the time range being searched or partition your query into a number of queries.
    /// </para>
    ///  
    /// <para>
    /// If you are using CloudWatch cross-account observability, you can use this operation
    /// in a monitoring account to start a query in a linked source account. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
    /// cross-account observability</a>. For a cross-account <c>StartQuery</c> operation,
    /// the query definition must be defined in the monitoring account.
    /// </para>
    ///  
    /// <para>
    /// You can have up to 30 concurrent CloudWatch Logs insights queries, including queries
    /// that have been added to dashboards. 
    /// </para>
    /// </summary>
    public partial class StartQueryRequest : AmazonCloudWatchLogsRequest
    {
        private long? _endTime;
        private int? _limit;
        private List<string> _logGroupIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _logGroupName;
        private List<string> _logGroupNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private QueryLanguage _queryLanguage;
        private string _queryString;
        private long? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time range to query. The range is inclusive, so the specified end time
        /// is included in the query. Specified as epoch time, the number of seconds since <c>January
        /// 1, 1970, 00:00:00 UTC</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of log events to return in the query. If the query string uses
        /// the <c>fields</c> command, only the specified fields and their values are returned.
        /// The default is 10,000.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogGroupIdentifiers. 
        /// <para>
        /// The list of log groups to query. You can include up to 50 log groups.
        /// </para>
        ///  
        /// <para>
        /// You can specify them by the log group name or ARN. If a log group that you're querying
        /// is in a source account and you're using a monitoring account, you must specify the
        /// ARN of the log group here. The query definition must also be defined in the monitoring
        /// account.
        /// </para>
        ///  
        /// <para>
        /// If you specify an ARN, use the format arn:aws:logs:<i>region</i>:<i>account-id</i>:log-group:<i>log_group_name</i>
        /// Don't include an * at the end.
        /// </para>
        ///  
        /// <para>
        /// A <c>StartQuery</c> operation must include exactly one of the following parameters:
        /// <c>logGroupName</c>, <c>logGroupNames</c>, or <c>logGroupIdentifiers</c>. The exception
        /// is queries using the OpenSearch Service SQL query language, where you specify the
        /// log group names inside the <c>querystring</c> instead of here. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LogGroupIdentifiers
        {
            get { return this._logGroupIdentifiers; }
            set { this._logGroupIdentifiers = value; }
        }

        // Check to see if LogGroupIdentifiers property is set
        internal bool IsSetLogGroupIdentifiers()
        {
            return this._logGroupIdentifiers != null && (this._logGroupIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The log group on which to perform the query.
        /// </para>
        ///  <note> 
        /// <para>
        /// A <c>StartQuery</c> operation must include exactly one of the following parameters:
        /// <c>logGroupName</c>, <c>logGroupNames</c>, or <c>logGroupIdentifiers</c>. The exception
        /// is queries using the OpenSearch Service SQL query language, where you specify the
        /// log group names inside the <c>querystring</c> instead of here.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string LogGroupName
        {
            get { return this._logGroupName; }
            set { this._logGroupName = value; }
        }

        // Check to see if LogGroupName property is set
        internal bool IsSetLogGroupName()
        {
            return this._logGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroupNames. 
        /// <para>
        /// The list of log groups to be queried. You can include up to 50 log groups.
        /// </para>
        ///  <note> 
        /// <para>
        /// A <c>StartQuery</c> operation must include exactly one of the following parameters:
        /// <c>logGroupName</c>, <c>logGroupNames</c>, or <c>logGroupIdentifiers</c>. The exception
        /// is queries using the OpenSearch Service SQL query language, where you specify the
        /// log group names inside the <c>querystring</c> instead of here.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LogGroupNames
        {
            get { return this._logGroupNames; }
            set { this._logGroupNames = value; }
        }

        // Check to see if LogGroupNames property is set
        internal bool IsSetLogGroupNames()
        {
            return this._logGroupNames != null && (this._logGroupNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueryLanguage. 
        /// <para>
        /// Specify the query language to use for this query. The options are Logs Insights QL,
        /// OpenSearch PPL, and OpenSearch SQL. For more information about the query languages
        /// that CloudWatch Logs supports, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CWL_AnalyzeLogData_Languages.html">Supported
        /// query languages</a>.
        /// </para>
        /// </summary>
        public QueryLanguage QueryLanguage
        {
            get { return this._queryLanguage; }
            set { this._queryLanguage = value; }
        }

        // Check to see if QueryLanguage property is set
        internal bool IsSetQueryLanguage()
        {
            return this._queryLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The query string to use. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CWL_QuerySyntax.html">CloudWatch
        /// Logs Insights Query Syntax</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10000)]
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The beginning of the time range to query. The range is inclusive, so the specified
        /// start time is included in the query. Specified as epoch time, the number of seconds
        /// since <c>January 1, 1970, 00:00:00 UTC</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}