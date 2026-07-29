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
 * Do not modify this file. This file is generated from the gameliftstreams-2018-05-10.normal.json service model.
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
namespace Amazon.GameLiftStreams.Model
{
    /// <summary>
    /// Contains the width and height dimensions, in pixels, that define the resolution of
    /// the stream session's virtual monitor. The total number of pixels (width × height)
    /// must not exceed 2,073,600 (equivalent to 1920 × 1080).
    /// </summary>
    public partial class Resolution
    {
        private int? _height;
        private int? _width;

        /// <summary>
        /// Gets and sets the property Height. 
        /// <para>
        /// The height of the stream session's virtual monitor, in pixels. The value must be an
        /// even number.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=320, Max=4096)]
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
        /// Gets and sets the property Width. 
        /// <para>
        /// The width of the stream session's virtual monitor, in pixels. The value must be an
        /// even number.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=320, Max=4096)]
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