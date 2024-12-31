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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// Container for the parameters to the ListEndpoints operation.
    /// List the global endpoints associated with this account. For more information about
    /// global endpoints, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-global-endpoints.html">Making
    /// applications Regional-fault tolerant with global endpoints and event replication</a>
    /// in the <i> <i>Amazon EventBridge User Guide</i> </i>.
    /// </summary>
    public partial class ListEndpointsRequest : AmazonEventBridgeRequest
    {
        private string _homeRegion;
        private int? _maxResults;
        private string _namePrefix;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property HomeRegion. 
        /// <para>
        /// The primary Region of the endpoints associated with this account. For example <c>"HomeRegion":
        /// "us-east-1"</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=9, Max=20)]
        public string HomeRegion
        {
            get { return this._homeRegion; }
            set { this._homeRegion = value; }
        }

        // Check to see if HomeRegion property is set
        internal bool IsSetHomeRegion()
        {
            return this._homeRegion != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results returned by the call.
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
        /// Gets and sets the property NamePrefix. 
        /// <para>
        /// A value that will return a subset of the endpoints associated with this account. For
        /// example, <c>"NamePrefix": "ABC"</c> will return all endpoints with "ABC" in the name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string NamePrefix
        {
            get { return this._namePrefix; }
            set { this._namePrefix = value; }
        }

        // Check to see if NamePrefix property is set
        internal bool IsSetNamePrefix()
        {
            return this._namePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned by a previous call, which you can use to retrieve the next set
        /// of results.
        /// </para>
        ///  
        /// <para>
        /// The value of <c>nextToken</c> is a unique pagination token for each page. To retrieve
        /// the next page of results, make the call again using the returned token. Keep all other
        /// arguments unchanged.
        /// </para>
        ///  
        /// <para>
        ///  Using an expired pagination token results in an <c>HTTP 400 InvalidToken</c> error.
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