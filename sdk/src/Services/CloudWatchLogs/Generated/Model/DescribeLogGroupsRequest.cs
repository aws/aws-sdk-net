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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeLogGroups operation.
    /// Lists the specified log groups. You can list all your log groups or filter the results
    /// by prefix. The results are ASCII-sorted by log group name.
    /// 
    ///  
    /// <para>
    /// CloudWatch Logs doesn’t support IAM policies that control access to the <code>DescribeLogGroups</code>
    /// action by using the <code>aws:ResourceTag/<i>key-name</i> </code> condition key. Other
    /// CloudWatch Logs actions do support the use of the <code>aws:ResourceTag/<i>key-name</i>
    /// </code> condition key to control access. For more information about using tags to
    /// control access, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Controlling
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
        private List<string> _accountIdentifiers = new List<string>();
        private bool? _includeLinkedAccounts;
        private int? _limit;
        private string _logGroupNamePattern;
        private string _logGroupNamePrefix;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AccountIdentifiers. 
        /// <para>
        /// When <code>includeLinkedAccounts</code> is set to <code>True</code>, use this parameter
        /// to specify the list of accounts to search. You can specify as many as 20 account IDs
        /// in the array. 
        /// </para>
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
            return this._accountIdentifiers != null && this._accountIdentifiers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IncludeLinkedAccounts. 
        /// <para>
        /// If you are using a monitoring account, set this to <code>True</code> to have the operation
        /// return log groups in the accounts listed in <code>accountIdentifiers</code>.
        /// </para>
        ///  
        /// <para>
        /// If this parameter is set to <code>true</code> and <code>accountIdentifiers</code>
        /// contains a null value, the operation returns all log groups in the monitoring account
        /// and all log groups in all source accounts that are linked to the monitoring account.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        ///  If you specify <code>includeLinkedAccounts</code> in your request, then <code>metricFilterCount</code>,
        /// <code>retentionInDays</code>, and <code>storedBytes</code> are not included in the
        /// response. 
        /// </para>
        ///  </note>
        /// </summary>
        public bool IncludeLinkedAccounts
        {
            get { return this._includeLinkedAccounts.GetValueOrDefault(); }
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
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogGroupNamePattern. 
        /// <para>
        /// If you specify a string for this parameter, the operation returns only log groups
        /// that have names that match the string based on a case-sensitive substring search.
        /// For example, if you specify <code>Foo</code>, log groups named <code>FooBar</code>,
        /// <code>aws/Foo</code>, and <code>GroupFoo</code> would match, but <code>foo</code>,
        /// <code>F/o/o</code> and <code>Froo</code> would not match.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>logGroupNamePattern</code> and <code>logGroupNamePrefix</code> are mutually
        /// exclusive. Only one of these parameters can be passed. 
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
        ///  <code>logGroupNamePrefix</code> and <code>logGroupNamePattern</code> are mutually
        /// exclusive. Only one of these parameters can be passed. 
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