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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the ListDistributionsByCachePolicyId operation.
    /// Gets a list of distribution IDs for distributions that have a cache behavior that's
    /// associated with the specified cache policy.
    /// 
    ///  
    /// <para>
    /// You can optionally specify the maximum number of items to receive in the response.
    /// If the total number of items in the list exceeds the maximum that you specify, or
    /// the default maximum, the response is paginated. To get the next page of items, send
    /// a subsequent request that specifies the <code>NextMarker</code> value from the current
    /// response as the <code>Marker</code> value in the subsequent request.
    /// </para>
    /// </summary>
    public partial class ListDistributionsByCachePolicyIdRequest : AmazonCloudFrontRequest
    {
        private string _cachePolicyId;
        private string _marker;
        private string _maxItems;

        /// <summary>
        /// Gets and sets the property CachePolicyId. 
        /// <para>
        /// The ID of the cache policy whose associated distribution IDs you want to list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CachePolicyId
        {
            get { return this._cachePolicyId; }
            set { this._cachePolicyId = value; }
        }

        // Check to see if CachePolicyId property is set
        internal bool IsSetCachePolicyId()
        {
            return this._cachePolicyId != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Use this field when paginating results to indicate where to begin in your list of
        /// distribution IDs. The response includes distribution IDs in the list that occur after
        /// the marker. To get the next page of the list, set this field's value to the value
        /// of <code>NextMarker</code> from the current page's response.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of distribution IDs that you want in the response.
        /// </para>
        /// </summary>
        public string MaxItems
        {
            get { return this._maxItems; }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems != null;
        }

    }
}