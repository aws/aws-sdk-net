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
    /// Embedded promotional media for a product, such as images or videos. Each element contains
    /// exactly one media type.
    /// </summary>
    public partial class PromotionalMedia
    {
        /// <summary>
        /// Gets and sets the property EmbeddedImage.
        /// </summary>
        public PromotionalEmbeddedImage EmbeddedImage { get; set; }

        /// <summary>
        /// Checks to see if the EmbeddedImage property is set.
        /// </summary>
        internal bool IsSetEmbeddedImage() => this.EmbeddedImage != null;

        /// <summary>
        /// Gets and sets the property EmbeddedVideo.
        /// </summary>
        public PromotionalEmbeddedVideo EmbeddedVideo { get; set; }

        /// <summary>
        /// Checks to see if the EmbeddedVideo property is set.
        /// </summary>
        internal bool IsSetEmbeddedVideo() => this.EmbeddedVideo != null;
    }
}
