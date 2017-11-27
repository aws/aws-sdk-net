/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Enable the Image inserter (ImageInserter) feature to include a graphic overlay on
    /// your video. Enable or disable this feature for each output individually. This setting
    /// is disabled by default.
    /// </summary>
    public partial class ImageInserter
    {
        private List<InsertableImage> _insertableImages = new List<InsertableImage>();

        /// <summary>
        /// Gets and sets the property InsertableImages. Image to insert. Must be 32 bit windows
        /// BMP, PNG, or TGA file. Must not be  larger than the output frames.
        /// </summary>
        public List<InsertableImage> InsertableImages
        {
            get { return this._insertableImages; }
            set { this._insertableImages = value; }
        }

        // Check to see if InsertableImages property is set
        internal bool IsSetInsertableImages()
        {
            return this._insertableImages != null && this._insertableImages.Count > 0; 
        }

    }
}