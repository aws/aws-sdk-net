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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The configuration of a <code>CustomContentVisual</code>.
    /// </summary>
    public partial class CustomContentConfiguration
    {
        private CustomContentType _contentType;
        private string _contentUrl;
        private CustomContentImageScalingConfiguration _imageScaling;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content type of the custom content visual. You can use this to have the visual
        /// render as an image.
        /// </para>
        /// </summary>
        public CustomContentType ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property ContentUrl. 
        /// <para>
        /// The input URL that links to the custom content that you want in the custom visual.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ContentUrl
        {
            get { return this._contentUrl; }
            set { this._contentUrl = value; }
        }

        // Check to see if ContentUrl property is set
        internal bool IsSetContentUrl()
        {
            return this._contentUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ImageScaling. 
        /// <para>
        /// The sizing options for the size of the custom content visual. This structure is required
        /// when the <code>ContentType</code> of the visual is <code>'IMAGE'</code>.
        /// </para>
        /// </summary>
        public CustomContentImageScalingConfiguration ImageScaling
        {
            get { return this._imageScaling; }
            set { this._imageScaling = value; }
        }

        // Check to see if ImageScaling property is set
        internal bool IsSetImageScaling()
        {
            return this._imageScaling != null;
        }

    }
}