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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The frame resolution used by the video stream.
    /// </summary>
    public partial class FrameResolution
    {
        private int? _frameHeight;
        private int? _frameWidth;

        /// <summary>
        /// Gets and sets the property FrameHeight. 
        /// <para>
        ///  The number of pixels in the height of the video frame.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? FrameHeight
        {
            get { return this._frameHeight; }
            set { this._frameHeight = value; }
        }

        // Check to see if FrameHeight property is set
        internal bool IsSetFrameHeight()
        {
            return this._frameHeight.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FrameWidth. 
        /// <para>
        ///  The number of pixels in the width of the video frame.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? FrameWidth
        {
            get { return this._frameWidth; }
            set { this._frameWidth = value; }
        }

        // Check to see if FrameWidth property is set
        internal bool IsSetFrameWidth()
        {
            return this._frameWidth.HasValue; 
        }

    }
}