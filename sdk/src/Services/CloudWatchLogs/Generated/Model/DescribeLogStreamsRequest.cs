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
    /// Container for the parameters to the DescribeLogStreams operation.
    /// Returns all the log streams that are associated with the specified log group. The
    /// list returned in the response is ASCII-sorted by log stream name.
    /// 
    ///  
    /// <para>
    /// By default, this operation returns up to 50 log streams. If there are more log streams
    /// to list, the response would contain a <code>nextToken</code> value in the response
    /// body. You can also limit the number of log streams returned in the response by specifying
    /// the <code>limit</code> parameter in the request. This operation has a limit of five
    /// transactions per second, after which transactions are throttled.
    /// </para>
    /// </summary>
    public partial class DescribeLogStreamsRequest : AmazonCloudWatchLogsRequest
    {
        private bool? _descending;
        private int? _limit;
        private string _logGroupName;
        private string _logStreamNamePrefix;
        private string _nextToken;
        private OrderBy _orderBy;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeLogStreamsRequest() { }

        /// <summary>
        /// Instantiates DescribeLogStreamsRequest with the parameterized properties
        /// </summary>
        /// <param name="logGroupName">The log group name for which log streams are to be listed.</param>
        public DescribeLogStreamsRequest(string logGroupName)
        {
            _logGroupName = logGroupName;
        }

        /// <summary>
        /// Gets and sets the property Descending. 
        /// <para>
        /// If set to true, results are returned in descending order. If you don't specify a value
        /// or set it to false, results are returned in ascending order.
        /// </para>
        /// </summary>
        public bool Descending
        {
            get { return this._descending.GetValueOrDefault(); }
            set { this._descending = value; }
        }

        // Check to see if Descending property is set
        internal bool IsSetDescending()
        {
            return this._descending.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of items returned in the response. If you don't specify a value,
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
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The log group name for which log streams are to be listed.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LogStreamNamePrefix. 
        /// <para>
        /// Will only return log streams that match the provided logStreamNamePrefix. If you don't
        /// specify a value, no prefix filter is applied.
        /// </para>
        /// </summary>
        public string LogStreamNamePrefix
        {
            get { return this._logStreamNamePrefix; }
            set { this._logStreamNamePrefix = value; }
        }

        // Check to see if LogStreamNamePrefix property is set
        internal bool IsSetLogStreamNamePrefix()
        {
            return this._logStreamNamePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A string token used for pagination that points to the next page of results. It must
        /// be a value obtained from the response of the previous <code>DescribeLogStreams</code>
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

        /// <summary>
        /// Gets and sets the property OrderBy. 
        /// <para>
        /// Specifies what to order the returned log streams by. Valid arguments are 'LogStreamName'
        /// or 'LastEventTime'. If you don't specify a value, results are ordered by LogStreamName.
        /// If 'LastEventTime' is chosen, the request cannot also contain a logStreamNamePrefix.
        /// </para>
        /// </summary>
        public OrderBy OrderBy
        {
            get { return this._orderBy; }
            set { this._orderBy = value; }
        }

        // Check to see if OrderBy property is set
        internal bool IsSetOrderBy()
        {
            return this._orderBy != null;
        }

    }
}