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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Container for the parameters to the ListAssets operation.
    /// Lists the hardware assets in an Outpost. If you are using Dedicated Hosts on Amazon
    /// Web Services Outposts, you can filter your request by host ID to return a list of
    /// hardware assets that allocate resources for Dedicated Hosts.
    /// </summary>
    public partial class ListAssetsRequest : AmazonOutpostsRequest
    {
        private List<string> _hostIdFilter = new List<string>();
        private int? _maxResults;
        private string _nextToken;
        private string _outpostIdentifier;

        /// <summary>
        /// Gets and sets the property HostIdFilter. 
        /// <para>
        ///  A filter for the host ID of Dedicated Hosts on the Outpost. 
        /// </para>
        ///  
        /// <para>
        /// Filter values are case sensitive. If you specify multiple values for a filter, the
        /// values are joined with an <code>OR</code>, and the request returns all results that
        /// match any of the specified values.
        /// </para>
        /// </summary>
        public List<string> HostIdFilter
        {
            get { return this._hostIdFilter; }
            set { this._hostIdFilter = value; }
        }

        // Check to see if HostIdFilter property is set
        internal bool IsSetHostIdFilter()
        {
            return this._hostIdFilter != null && this._hostIdFilter.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// </summary>
        [AWSProperty(Min=1, Max=1005)]
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
        /// Gets and sets the property OutpostIdentifier. 
        /// <para>
        ///  The ID or the Amazon Resource Name (ARN) of the Outpost. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=180)]
        public string OutpostIdentifier
        {
            get { return this._outpostIdentifier; }
            set { this._outpostIdentifier = value; }
        }

        // Check to see if OutpostIdentifier property is set
        internal bool IsSetOutpostIdentifier()
        {
            return this._outpostIdentifier != null;
        }

    }
}