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

namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// An embedded promotional video for a product.
    /// </summary>
    public partial class PromotionalEmbeddedVideo
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description of the video.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Preview. 
        /// <para>
        /// The URL of the high-resolution preview image for the video.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Preview { get; set; }

        /// <summary>
        /// Checks to see if the Preview property is set.
        /// </summary>
        internal bool IsSetPreview() => this.Preview != null;

        /// <summary>
        /// Gets and sets the property Thumbnail. 
        /// <para>
        /// The URL of the thumbnail image for the video.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Thumbnail { get; set; }

        /// <summary>
        /// Checks to see if the Thumbnail property is set.
        /// </summary>
        internal bool IsSetThumbnail() => this.Thumbnail != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title displayed when hovering over the video.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL of the video file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
