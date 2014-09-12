/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeLogGroups operation.
    /// Returns all the log groups that are associated with the AWS account making the request.
    /// The list returned in the response is ASCII-sorted by log group name. 
    /// 
    ///  
    /// <para>
    ///  By default, this operation returns up to 50 log groups. If there are more log groups
    /// to list, the response would contain a <code class="code">nextToken</code> value in
    /// the response body. You can also limit the number of log groups returned in the response
    /// by specifying the <code class="code">limit</code> parameter in the request. 
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
        ///  The maximum number of items returned in the response. If you don't specify a value,
        /// the request would return up to 50 items. 
        /// </para>
        /// </summary>
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
        /// </summary>
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
        ///  A string token used for pagination that points to the next page of results. It must
        /// be a value obtained from the response of the previous <code class="code">DescribeLogGroups</code>
        /// request. 
        /// </para>
        /// </summary>
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