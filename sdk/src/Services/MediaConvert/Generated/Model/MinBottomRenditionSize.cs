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
    /// Use Min bottom rendition size to specify a minimum size for the lowest resolution
    /// in your ABR stack. * The lowest resolution in your ABR stack will be equal to or greater
    /// than the value that you enter. For example: If you specify 640x360 the lowest resolution
    /// in your ABR stack will be equal to or greater than to 640x360. * If you specify a
    /// Min top rendition size rule, the value that you specify for Min bottom rendition size
    /// must be less than, or equal to, Min top rendition size.
    /// </summary>
    public partial class MinBottomRenditionSize
    {
        private int? _height;
        private int? _width;

        /// <summary>
        /// Gets and sets the property Height. Use Height to define the video resolution height,
        /// in pixels, for this rule.
        /// </summary>
        [AWSProperty(Min=32, Max=8192)]
        public int? Height
        {
            get { return this._height; }
            set { this._height = value; }
        }

        // Check to see if Height property is set
        internal bool IsSetHeight()
        {
            return this._height.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Width. Use Width to define the video resolution width,
        /// in pixels, for this rule.
        /// </summary>
        [AWSProperty(Min=32, Max=8192)]
        public int? Width
        {
            get { return this._width; }
            set { this._width = value; }
        }

        // Check to see if Width property is set
        internal bool IsSetWidth()
        {
            return this._width.HasValue; 
        }

    }
}