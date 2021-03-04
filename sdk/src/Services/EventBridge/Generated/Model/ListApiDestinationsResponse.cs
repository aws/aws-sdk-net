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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// This is the response object from the ListApiDestinations operation.
    /// </summary>
    public partial class ListApiDestinationsResponse : AmazonWebServiceResponse
    {
        private List<ApiDestination> _apiDestinations = new List<ApiDestination>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ApiDestinations. 
        /// <para>
        /// An array of <code>ApiDestination</code> objects that include information about an
        /// API destination.
        /// </para>
        /// </summary>
        public List<ApiDestination> ApiDestinations
        {
            get { return this._apiDestinations; }
            set { this._apiDestinations = value; }
        }

        // Check to see if ApiDestinations property is set
        internal bool IsSetApiDestinations()
        {
            return this._apiDestinations != null && this._apiDestinations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token you can use in a subsequent request to retrieve the next set of results.
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

    }
}