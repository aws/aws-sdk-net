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
    /// A complex type that controls which HTTP methods CloudFront processes and forwards
    /// to your Amazon S3 bucket or your custom origin. There are three choices:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// CloudFront forwards only <c>GET</c> and <c>HEAD</c> requests.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CloudFront forwards only <c>GET</c>, <c>HEAD</c>, and <c>OPTIONS</c> requests.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CloudFront forwards <c>GET, HEAD, OPTIONS, PUT, PATCH, POST</c>, and <c>DELETE</c>
    /// requests.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you pick the third choice, you may need to restrict access to your Amazon S3 bucket
    /// or to your custom origin so users can't perform operations that you don't want them
    /// to. For example, you might not want users to have permissions to delete objects from
    /// your origin.
    /// </para>
    /// </summary>
    public partial class AllowedMethods
    {
        /// <summary>
        /// Gets and sets the property CachedMethods.
        /// </summary>
        public CachedMethods CachedMethods { get; set; }

        /// <summary>
        /// Checks to see if the CachedMethods property is set.
        /// </summary>
        internal bool IsSetCachedMethods() => this.CachedMethods != null;

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// A complex type that contains the HTTP methods that you want CloudFront to process
        /// and forward to your origin.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Items { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Items property is set.
        /// </summary>
        internal bool IsSetItems() => this.Items != null && (this.Items.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Quantity. 
        /// <para>
        /// The number of HTTP methods that you want CloudFront to forward to your origin. Valid
        /// values are 2 (for <c>GET</c> and <c>HEAD</c> requests), 3 (for <c>GET</c>, <c>HEAD</c>,
        /// and <c>OPTIONS</c> requests) and 7 (for <c>GET, HEAD, OPTIONS, PUT, PATCH, POST</c>,
        /// and <c>DELETE</c> requests).
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
