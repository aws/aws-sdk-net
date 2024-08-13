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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Specify the offset between the upper-left corner of the video frame and the top left
    /// corner of the overlay.
    /// </summary>
    public partial class MotionImageInsertionOffset
    {
        private int? _imageX;
        private int? _imageY;

        /// <summary>
        /// Gets and sets the property ImageX. Set the distance, in pixels, between the overlay
        /// and the left edge of the video frame.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? ImageX
        {
            get { return this._imageX; }
            set { this._imageX = value; }
        }

        // Check to see if ImageX property is set
        internal bool IsSetImageX()
        {
            return this._imageX.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageY. Set the distance, in pixels, between the overlay
        /// and the top edge of the video frame.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? ImageY
        {
            get { return this._imageY; }
            set { this._imageY = value; }
        }

        // Check to see if ImageY property is set
        internal bool IsSetImageY()
        {
            return this._imageY.HasValue; 
        }

    }
}