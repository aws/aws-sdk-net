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
 * Do not modify this file. This file is generated from the gameliftstreams-2018-05-10.normal.json service model.
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
namespace Amazon.GameLiftStreams.Model
{
    /// <summary>
    /// Container for the parameters to the ListStreamGroups operation.
    /// Retrieves a list of all Amazon GameLift Streams stream groups that are associated
    /// with the Amazon Web Services account in use. This operation returns stream groups
    /// in all statuses, in no particular order. You can paginate the results as needed.
    /// </summary>
    public partial class ListStreamGroupsRequest : AmazonGameLiftStreamsRequest
    {
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of results to return. Use this parameter with <c>NextToken</c> to return
        /// results in sequential pages. Default value is <c>25</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// A token that marks the start of the next set of results. Use this token when you retrieve
        /// results as sequential pages. To get the first page of results, omit a token value.
        /// To get the remaining pages, provide the token returned with the previous result set.
        /// 
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