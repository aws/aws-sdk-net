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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
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
namespace Amazon.OpsWorksCM.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEvents operation.
    /// Describes events for a specified server. Results are ordered by time, with newest
    /// events first. 
    /// 
    ///  
    /// <para>
    ///  This operation is synchronous. 
    /// </para>
    ///  
    /// <para>
    ///  A <c>ResourceNotFoundException</c> is thrown when the server does not exist. A <c>ValidationException</c>
    /// is raised when parameters of the request are not valid. 
    /// </para>
    /// </summary>
    public partial class DescribeEventsRequest : AmazonOpsWorksCMRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _serverName;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// To receive a paginated response, use this parameter to specify the maximum number
        /// of results to be returned with a single call. If the number of available results exceeds
        /// this maximum, the response includes a <c>NextToken</c> value that you can assign to
        /// the <c>NextToken</c> request parameter to get the next set of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// NextToken is a string that is returned in some command responses. It indicates that
        /// not all entries have been returned, and that you must run at least one more request
        /// to get remaining items. To get remaining results, call <c>DescribeEvents</c> again,
        /// and assign the token from the previous results as the value of the <c>nextToken</c>
        /// parameter. If there are no more results, the response object's <c>nextToken</c> parameter
        /// value is <c>null</c>. Setting a <c>nextToken</c> value that was not returned in your
        /// previous results causes an <c>InvalidNextTokenException</c> to occur. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=10000)]
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
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The name of the server for which you want to view events.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=40)]
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }

        // Check to see if ServerName property is set
        internal bool IsSetServerName()
        {
            return this._serverName != null;
        }

    }
}