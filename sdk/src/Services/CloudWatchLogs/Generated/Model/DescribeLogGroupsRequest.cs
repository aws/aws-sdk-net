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
    /// </summary>
    public partial class DescribeLogGroupsRequest : AmazonCloudWatchLogsRequest
    {
        private int? _limit;
        private string _logGroupNamePrefix;
        private string _nextToken;

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
        /// Gets and sets the property LogGroupNamePrefix. 
        /// <para>
        /// The prefix to match.
        /// </para>
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