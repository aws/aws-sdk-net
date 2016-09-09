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
    /// Container for the parameters to the DescribeSubscriptionFilters operation.
    /// Returns all the subscription filters associated with the specified log group. The
    /// list returned in the response is ASCII-sorted by filter name.
    /// 
    ///  
    /// <para>
    /// By default, this operation returns up to 50 subscription filters. If there are more
    /// subscription filters to list, the response would contain a <code>nextToken</code>
    /// value in the response body. You can also limit the number of subscription filters
    /// returned in the response by specifying the <code>limit</code> parameter in the request.
    /// </para>
    /// </summary>
    public partial class DescribeSubscriptionFiltersRequest : AmazonCloudWatchLogsRequest
    {
        private string _filterNamePrefix;
        private int? _limit;
        private string _logGroupName;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FilterNamePrefix. 
        /// <para>
        /// Will only return subscription filters that match the provided filterNamePrefix. If
        /// you don't specify a value, no prefix filter is applied.
        /// </para>
        /// </summary>
        public string FilterNamePrefix
        {
            get { return this._filterNamePrefix; }
            set { this._filterNamePrefix = value; }
        }

        // Check to see if FilterNamePrefix property is set
        internal bool IsSetFilterNamePrefix()
        {
            return this._filterNamePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property Limit.
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
        /// The log group name for which subscription filters are to be listed.
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
        /// Gets and sets the property NextToken.
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