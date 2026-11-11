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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the ListDistributionsByCachePolicyId operation. Gets
    /// a list of distribution IDs for distributions that have a cache behavior that's associated
    /// with the specified cache policy. <para> You can optionally specify the maximum number
    /// of items to receive in the response. If the total number of items in the list exceeds
    /// the maximum that you specify, or the default maximum, the response is paginated. To
    /// get the next page of items, send a subsequent request that specifies the <c>NextMarker</c>
    /// value from the current response as the <c>Marker</c> value in the subsequent request.
    /// </para>
    /// </summary>
    public partial class ListDistributionsByCachePolicyIdRequest : AmazonCloudFrontRequest
    {
        /// <summary>
        /// Gets and sets the property CachePolicyId. 
        /// <para>
        /// The ID of the cache policy whose associated distribution IDs you want to list.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CachePolicyId { get; set; }

        /// <summary>
        /// Checks to see if the CachePolicyId property is set.
        /// </summary>
        internal bool IsSetCachePolicyId() => this.CachePolicyId != null;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Use this field when paginating results to indicate where to begin in your list of
        /// distribution IDs. The response includes distribution IDs in the list that occur after
        /// the marker. To get the next page of the list, set this field's value to the value
        /// of <c>NextMarker</c> from the current page's response.
        /// </para>
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of distribution IDs that you want in the response.
        /// </para>
        /// </summary>
        public string MaxItems { get; set; }

        /// <summary>
        /// Checks to see if the MaxItems property is set.
        /// </summary>
        internal bool IsSetMaxItems() => this.MaxItems != null;
    }
}
