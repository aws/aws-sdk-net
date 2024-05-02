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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Specifies a particular video stream within an input source. An input may have only
    /// a single video selector.
    /// </summary>
    public partial class VideoSelector
    {
        private VideoSelectorColorSpace _colorSpace;
        private VideoSelectorColorSpaceSettings _colorSpaceSettings;
        private VideoSelectorColorSpaceUsage _colorSpaceUsage;
        private VideoSelectorSettings _selectorSettings;

        /// <summary>
        /// Gets and sets the property ColorSpace. Specifies the color space of an input. This
        /// setting works in tandem with colorSpaceUsage and a video description's colorSpaceSettingsChoice
        /// to determine if any conversion will be performed.
        /// </summary>
        public VideoSelectorColorSpace ColorSpace
        {
            get { return this._colorSpace; }
            set { this._colorSpace = value; }
        }

        // Check to see if ColorSpace property is set
        internal bool IsSetColorSpace()
        {
            return this._colorSpace != null;
        }

        /// <summary>
        /// Gets and sets the property ColorSpaceSettings. Color space settings
        /// </summary>
        public VideoSelectorColorSpaceSettings ColorSpaceSettings
        {
            get { return this._colorSpaceSettings; }
            set { this._colorSpaceSettings = value; }
        }

        // Check to see if ColorSpaceSettings property is set
        internal bool IsSetColorSpaceSettings()
        {
            return this._colorSpaceSettings != null;
        }

        /// <summary>
        /// Gets and sets the property ColorSpaceUsage. Applies only if colorSpace is a value
        /// other than follow. This field controls how the value in the colorSpace field will
        /// be used. fallback means that when the input does include color space data, that data
        /// will be used, but when the input has no color space data, the value in colorSpace
        /// will be used. Choose fallback if your input is sometimes missing color space data,
        /// but when it does have color space data, that data is correct. force means to always
        /// use the value in colorSpace. Choose force if your input usually has no color space
        /// data or might have unreliable color space data.
        /// </summary>
        public VideoSelectorColorSpaceUsage ColorSpaceUsage
        {
            get { return this._colorSpaceUsage; }
            set { this._colorSpaceUsage = value; }
        }

        // Check to see if ColorSpaceUsage property is set
        internal bool IsSetColorSpaceUsage()
        {
            return this._colorSpaceUsage != null;
        }

        /// <summary>
        /// Gets and sets the property SelectorSettings. The video selector settings.
        /// </summary>
        public VideoSelectorSettings SelectorSettings
        {
            get { return this._selectorSettings; }
            set { this._selectorSettings = value; }
        }

        // Check to see if SelectorSettings property is set
        internal bool IsSetSelectorSettings()
        {
            return this._selectorSettings != null;
        }

    }
}