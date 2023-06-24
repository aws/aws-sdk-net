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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// This is the response object from the ListMapRuns operation.
    /// </summary>
    public partial class ListMapRunsResponse : AmazonWebServiceResponse
    {
        private List<MapRunListItem> _mapRuns = new List<MapRunListItem>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MapRuns. 
        /// <para>
        /// An array that lists information related to a Map Run, such as the Amazon Resource
        /// Name (ARN) of the Map Run and the ARN of the state machine that started the Map Run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<MapRunListItem> MapRuns
        {
            get { return this._mapRuns; }
            set { this._mapRuns = value; }
        }

        // Check to see if MapRuns property is set
        internal bool IsSetMapRuns()
        {
            return this._mapRuns != null && this._mapRuns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If <code>nextToken</code> is returned, there are more results available. The value
        /// of <code>nextToken</code> is a unique pagination token for each page. Make the call
        /// again using the returned token to retrieve the next page. Keep all other arguments
        /// unchanged. Each pagination token expires after 24 hours. Using an expired pagination
        /// token will return an <i>HTTP 400 InvalidToken</i> error.
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