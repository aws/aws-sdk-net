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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the ListStreamUrls operation. Retrieves a list of
    /// the stream URLs in the current Amazon Web Services Region for your Amazon Web Services
    /// account. You can filter the results by status or by stream group. Use the pagination
    /// parameters to retrieve results as a set of sequential pages. If you delete the stream
    /// group or application that backs a stream URL, this operation updates that stream URL's
    /// status to <c>REVOKED</c>.
    /// </summary>
    public partial class ListStreamUrlsRequest : AmazonGameLiftStreamsRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page. Valid values are 1-100. The default
        /// is 25.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token that marks the start of the next set of results. Use this token when you
        /// retrieve results as sequential pages. To get the first page of results, omit a token
        /// value. To get the remaining pages, provide the token returned with the previous result
        /// set. 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

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
        public StreamUrlStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

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
        [AWSProperty(Min = 1, Max = 128)]
        public string StreamGroupIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the StreamGroupIdentifier property is set.
        /// </summary>
        internal bool IsSetStreamGroupIdentifier() => this.StreamGroupIdentifier != null;
    }
}
