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
    /// Use Force include renditions to specify one or more resolutions to include your ABR
    /// stack. * (Recommended) To optimize automated ABR, specify as few resolutions as possible.
    /// * (Required) The number of resolutions that you specify must be equal to, or less
    /// than, the Max renditions setting. * If you specify a Min top rendition size rule,
    /// specify at least one resolution that is equal to, or greater than, Min top rendition
    /// size. * If you specify a Min bottom rendition size rule, only specify resolutions
    /// that are equal to, or greater than, Min bottom rendition size. * If you specify a
    /// Force include renditions rule, do not specify a separate rule for Allowed renditions.
    /// * Note: The ABR stack may include other resolutions that you do not specify here,
    /// depending on the Max renditions setting.
    /// </summary>
    public partial class ForceIncludeRenditionSize
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