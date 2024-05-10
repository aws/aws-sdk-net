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
 * Do not modify this file. This file is generated from the wisdom-2020-10-19.normal.json service model.
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
namespace Amazon.ConnectWisdomService.Model
{
    /// <summary>
    /// This is the response object from the SearchSessions operation.
    /// </summary>
    public partial class SearchSessionsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SessionSummary> _sessionSummaries = AWSConfigs.InitializeCollections ? new List<SessionSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are additional results, this is the token for the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property SessionSummaries. 
        /// <para>
        /// Summary information about the sessions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SessionSummary> SessionSummaries
        {
            get { return this._sessionSummaries; }
            set { this._sessionSummaries = value; }
        }

        // Check to see if SessionSummaries property is set
        internal bool IsSetSessionSummaries()
        {
            return this._sessionSummaries != null && (this._sessionSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}