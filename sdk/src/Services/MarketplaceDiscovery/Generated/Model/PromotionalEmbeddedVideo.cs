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
 * Do not modify this file. This file is generated from the marketplace-discovery-2026-02-05.normal.json service model.
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
        private string _description;
        private string _preview;
        private string _thumbnail;
        private string _title;
        private string _url;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description of the video.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Preview. 
        /// <para>
        /// The URL of the high-resolution preview image for the video.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Preview
        {
            get { return this._preview; }
            set { this._preview = value; }
        }

        // Check to see if Preview property is set
        internal bool IsSetPreview()
        {
            return this._preview != null;
        }

        /// <summary>
        /// Gets and sets the property Thumbnail. 
        /// <para>
        /// The URL of the thumbnail image for the video.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Thumbnail
        {
            get { return this._thumbnail; }
            set { this._thumbnail = value; }
        }

        // Check to see if Thumbnail property is set
        internal bool IsSetThumbnail()
        {
            return this._thumbnail != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title displayed when hovering over the video.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL of the video file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}