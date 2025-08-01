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
    /// Container for the parameters to the DescribeLogGroups operation.
    /// Returns information about log groups. You can return all your log groups or filter
    /// the results by prefix. The results are ASCII-sorted by log group name.
    /// 
    ///  
    /// <para>
    /// CloudWatch Logs doesn't support IAM policies that control access to the <c>DescribeLogGroups</c>
    /// action by using the <c>aws:ResourceTag/<i>key-name</i> </c> condition key. Other CloudWatch
    /// Logs actions do support the use of the <c>aws:ResourceTag/<i>key-name</i> </c> condition
    /// key to control access. For more information about using tags to control access, see
    /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Controlling
    /// access to Amazon Web Services resources using tags</a>.
    /// </para>
    ///  
    /// <para>
    /// If you are using CloudWatch cross-account observability, you can use this operation
    /// in a monitoring account and view data from the linked source accounts. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
    /// cross-account observability</a>.
    /// </para>
    /// </summary>
    public partial class DescribeLogGroupsRequest : AmazonCloudWatchLogsRequest
    {
        private List<string> _accountIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _includeLinkedAccounts;
        private int? _limit;
        private LogGroupClass _logGroupClass;
        private List<string> _logGroupIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _logGroupNamePattern;
        private string _logGroupNamePrefix;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AccountIdentifiers. 
        /// <para>
        /// When <c>includeLinkedAccounts</c> is set to <c>true</c>, use this parameter to specify
        /// the list of accounts to search. You can specify as many as 20 account IDs in the array.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<string> AccountIdentifiers
        {
            get { return this._accountIdentifiers; }
            set { this._accountIdentifiers = value; }
        }

        // Check to see if AccountIdentifiers property is set
        internal bool IsSetAccountIdentifiers()
        {
            return this._accountIdentifiers != null && (this._accountIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public bool? IncludeLinkedAccounts
        {
            get { return this._includeLinkedAccounts; }
            set { this._includeLinkedAccounts = value; }
        }

        // Check to see if IncludeLinkedAccounts property is set
        internal bool IsSetIncludeLinkedAccounts()
        {
            return this._includeLinkedAccounts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of items returned. If you don't specify a value, the default is
        /// up to 50 items.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// Gets and sets the property LogGroupClass. 
        /// <para>
        /// Use this parameter to limit the results to only those log groups in the specified
        /// log group class. If you omit this parameter, log groups of all classes can be returned.
        /// </para>
        ///  
        /// <para>
        /// Specifies the log group class for this log group. There are three classes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>Standard</c> log class supports all CloudWatch Logs features.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>Infrequent Access</c> log class supports a subset of CloudWatch Logs features
        /// and incurs lower costs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the <c>Delivery</c> log class only for delivering Lambda logs to store in Amazon
        /// S3 or Amazon Data Firehose. Log events in log groups in the Delivery class are kept
        /// in CloudWatch Logs for only one day. This log class doesn't offer rich CloudWatch
        /// Logs capabilities such as CloudWatch Logs Insights queries.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For details about the features supported by each class, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch_Logs_Log_Classes.html">Log
        /// classes</a> 
        /// </para>
        /// </summary>
        public LogGroupClass LogGroupClass
        {
            get { return this._logGroupClass; }
            set { this._logGroupClass = value; }
        }

        // Check to see if LogGroupClass property is set
        internal bool IsSetLogGroupClass()
        {
            return this._logGroupClass != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroupIdentifiers. 
        /// <para>
        /// Use this array to filter the list of log groups returned. If you specify this parameter,
        /// the only other filter that you can choose to specify is <c>includeLinkedAccounts</c>.
        /// </para>
        ///  
        /// <para>
        /// If you are using this operation in a monitoring account, you can specify the ARNs
        /// of log groups in source accounts and in the monitoring account itself. If you are
        /// using this operation in an account that is not a cross-account monitoring account,
        /// you can specify only log group names in the same account as the operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// Gets and sets the property LogGroupNamePattern. 
        /// <para>
        /// If you specify a string for this parameter, the operation returns only log groups
        /// that have names that match the string based on a case-sensitive substring search.
        /// For example, if you specify <c>DataLogs</c>, log groups named <c>DataLogs</c>, <c>aws/DataLogs</c>,
        /// and <c>GroupDataLogs</c> would match, but <c>datalogs</c>, <c>Data/log/s</c> and <c>Groupdata</c>
        /// would not match.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>logGroupNamePattern</c> in your request, then only <c>arn</c>, <c>creationTime</c>,
        /// and <c>logGroupName</c> are included in the response. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>logGroupNamePattern</c> and <c>logGroupNamePrefix</c> are mutually exclusive.
        /// Only one of these parameters can be passed. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
        public string LogGroupNamePattern
        {
            get { return this._logGroupNamePattern; }
            set { this._logGroupNamePattern = value; }
        }

        // Check to see if LogGroupNamePattern property is set
        internal bool IsSetLogGroupNamePattern()
        {
            return this._logGroupNamePattern != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroupNamePrefix. 
        /// <para>
        /// The prefix to match.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>logGroupNamePrefix</c> and <c>logGroupNamePattern</c> are mutually exclusive.
        /// Only one of these parameters can be passed. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string LogGroupNamePrefix
        {
            get { return this._logGroupNamePrefix; }
            set { this._logGroupNamePrefix = value; }
        }

        // Check to see if LogGroupNamePrefix property is set
        internal bool IsSetLogGroupNamePrefix()
        {
            return this._logGroupNamePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}