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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Container for the parameters to the ListMobileSdkReleases operation. Retrieves a list
    /// of the available releases for the mobile SDK and the specified device platform. <para>
    /// The mobile SDK is not generally available. Customers who have access to the mobile
    /// SDK can use it to establish and manage WAF tokens for use in HTTP(S) requests from
    /// a mobile device to WAF. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-application-integration.html">WAF
    /// client application integration</a> in the <i>WAF Developer Guide</i>. </para>
    /// </summary>
    public partial class ListMobileSdkReleasesRequest : AmazonWAFV2Request
    {
        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of objects that you want WAF to return for this request. If more
        /// objects are available, in the response, WAF provides a <c>NextMarker</c> value that
        /// you can use in a subsequent call to get the next batch of objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// When you request a list of objects with a <c>Limit</c> setting, if the number of objects
        /// that are still available for retrieval exceeds the limit, WAF returns a <c>NextMarker</c>
        /// value in the response. To retrieve the next batch of objects, provide the marker from
        /// the prior call in your next request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string NextMarker { get; set; }

        /// <summary>
        /// Checks to see if the NextMarker property is set.
        /// </summary>
        internal bool IsSetNextMarker() => this.NextMarker != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The device platform to retrieve the list for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Platform Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;
    }
}
