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
    /// Container for the parameters to the ListStreamUrls operation.
    /// Retrieves a list of the stream URLs in the current Amazon Web Services Region for
    /// your Amazon Web Services account. You can filter the results by status or by stream
    /// group. Use the pagination parameters to retrieve results as a set of sequential pages.
    /// If you delete the stream group or application that backs a stream URL, this operation
    /// updates that stream URL's status to <c>REVOKED</c>.
    /// </summary>
    public partial class ListStreamUrlsRequest : AmazonGameLiftStreamsRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private StreamUrlStatus _status;
        private string _streamGroupIdentifier;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page. Valid values are 1-100. The default
        /// is 25.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// The token that marks the start of the next set of results. Use this token when you
        /// retrieve results as sequential pages. To get the first page of results, omit a token
        /// value. To get the remaining pages, provide the token returned with the previous result
        /// set. 
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
        /// Gets and sets the property Status. 
        /// <para>
        /// Filters the list to stream URLs with the specified status.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c>: The stream URL is valid and can start stream sessions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXPIRED</c>: The stream URL has passed its expiration time and can no longer start
        /// stream sessions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REVOKED</c>: The stream URL was revoked and can no longer start stream sessions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LIMIT_REACHED</c>: The stream URL has been used the maximum number of times and
        /// can no longer start stream sessions.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StreamUrlStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StreamGroupIdentifier. 
        /// <para>
        /// Filters the list to stream URLs that belong to the specified stream group.
        /// </para>
        ///  
        /// <para>
        /// This value is an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Name (ARN)</a> or ID that uniquely identifies the stream group resource.
        /// Example ARN: <c>arn:aws:gameliftstreams:us-west-2:111122223333:streamgroup/sg-1AB2C3De4</c>.
        /// Example ID: <c>sg-1AB2C3De4</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string StreamGroupIdentifier
        {
            get { return this._streamGroupIdentifier; }
            set { this._streamGroupIdentifier = value; }
        }

        // Check to see if StreamGroupIdentifier property is set
        internal bool IsSetStreamGroupIdentifier()
        {
            return this._streamGroupIdentifier != null;
        }

    }
}