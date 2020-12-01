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
 * Do not modify this file. This file is generated from the connect-contact-lens-2020-08-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConnectContactLens.Model
{
    /// <summary>
    /// This is the response object from the ListRealtimeContactAnalysisSegments operation.
    /// </summary>
    public partial class ListRealtimeContactAnalysisSegmentsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RealtimeContactAnalysisSegment> _segments = new List<RealtimeContactAnalysisSegment>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are additional results, this is the token for the next set of results. If
        /// response includes <code>nextToken</code> there are two possible scenarios:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// There are more segments so another call is required to get them.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are no more segments at this time, but more may be available later (real-time
        /// analysis is in progress) so the client should call the operation again to get new
        /// segments.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If response does not include <code>nextToken</code>, the analysis is completed (successfully
        /// or failed) and there are no more segments to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=131070)]
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
        /// Gets and sets the property Segments. 
        /// <para>
        /// An analyzed transcript or category.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<RealtimeContactAnalysisSegment> Segments
        {
            get { return this._segments; }
            set { this._segments = value; }
        }

        // Check to see if Segments property is set
        internal bool IsSetSegments()
        {
            return this._segments != null && this._segments.Count > 0; 
        }

    }
}