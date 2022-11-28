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
    /// This is the response object from the DescribeLogGroups operation.
    /// </summary>
    public partial class DescribeLogGroupsResponse : AmazonWebServiceResponse
    {
        private List<LogGroup> _logGroups = new List<LogGroup>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property LogGroups. 
        /// <para>
        /// The log groups.
        /// </para>
        ///  
        /// <para>
        /// If the <code>retentionInDays</code> value is not included for a log group, then that
        /// log group's events do not expire.
        /// </para>
        /// </summary>
        public List<LogGroup> LogGroups
        {
            get { return this._logGroups; }
            set { this._logGroups = value; }
        }

        // Check to see if LogGroups property is set
        internal bool IsSetLogGroups()
        {
            return this._logGroups != null && this._logGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken.
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