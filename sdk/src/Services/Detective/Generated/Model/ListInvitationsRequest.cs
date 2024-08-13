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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
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
namespace Amazon.Detective.Model
{
    /// <summary>
    /// Container for the parameters to the ListInvitations operation.
    /// Retrieves the list of open and accepted behavior graph invitations for the member
    /// account. This operation can only be called by an invited member account.
    /// 
    ///  
    /// <para>
    /// Open invitations are invitations that the member account has not responded to.
    /// </para>
    ///  
    /// <para>
    /// The results do not include behavior graphs for which the member account declined the
    /// invitation. The results also do not include behavior graphs that the member account
    /// resigned from or was removed from.
    /// </para>
    /// </summary>
    public partial class ListInvitationsRequest : AmazonDetectiveRequest
    {
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of behavior graph invitations to return in the response. The total
        /// must be less than the overall limit on the number of results to return, which is currently
        /// 200.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        /// For requests to retrieve the next page of results, the pagination token that was returned
        /// with the previous page of results. The initial request does not include a pagination
        /// token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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