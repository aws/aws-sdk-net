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
    /// Lists the origin access identities for CloudFront.Send a <c>GET</c> request to the
    /// <c>/<i>CloudFront API version</i>/origin-access-identity/cloudfront</c> resource.
    /// The response includes a <c>CloudFrontOriginAccessIdentityList</c> element with zero
    /// or more <c>CloudFrontOriginAccessIdentitySummary</c> child elements. By default, your
    /// entire list of origin access identities is returned in one single page. If the list
    /// is long, you can paginate it using the <c>MaxItems</c> and <c>Marker</c> parameters.
    /// </summary>
    public partial class CloudFrontOriginAccessIdentityList
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public CloudFrontOriginAccessIdentityList() { }

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// A flag that indicates whether more origin access identities remain to be listed. If
        /// your results were truncated, you can make a follow-up pagination request using the
        /// <c>Marker</c> request parameter to retrieve more items in the list.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// Checks to see if the IsTruncated property is set.
        /// </summary>
        internal bool IsSetIsTruncated() => this.IsTruncated.HasValue;

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// A complex type that contains one <c>CloudFrontOriginAccessIdentitySummary</c> element
        /// for each origin access identity that was created by the current Amazon Web Services
        /// account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CloudFrontOriginAccessIdentitySummary> Items { get; set; } = AWSConfigs.InitializeCollections ? new List<CloudFrontOriginAccessIdentitySummary>() : null;

        /// <summary>
        /// Checks to see if the Items property is set.
        /// </summary>
        internal bool IsSetItems() => this.Items != null && (this.Items.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Use this when paginating results to indicate where to begin in your list of origin
        /// access identities. The results include identities in the list that occur after the
        /// marker. To get the next page of results, set the <c>Marker</c> to the value of the
        /// <c>NextMarker</c> from the current page's response (which is also the ID of the last
        /// identity on that page).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of origin access identities you want in the response body.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MaxItems { get; set; }

        /// <summary>
        /// Checks to see if the MaxItems property is set.
        /// </summary>
        internal bool IsSetMaxItems() => this.MaxItems.HasValue;

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// If <c>IsTruncated</c> is <c>true</c>, this element is present and contains the value
        /// you can use for the <c>Marker</c> request parameter to continue listing your origin
        /// access identities where they left off.
        /// </para>
        /// </summary>
        public string NextMarker { get; set; }

        /// <summary>
        /// Checks to see if the NextMarker property is set.
        /// </summary>
        internal bool IsSetNextMarker() => this.NextMarker != null;

        /// <summary>
        /// Gets and sets the property Quantity. 
        /// <para>
        /// The number of CloudFront origin access identities that were created by the current
        /// Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Checks to see if the Quantity property is set.
        /// </summary>
        internal bool IsSetQuantity() => this.Quantity.HasValue;
    }
}
