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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Specifies a particular video stream within an input source. An input may have only
    /// a single video selector.
    /// </summary>
    public partial class VideoSelector
    {
        /// <summary>
        /// Gets and sets the property ColorSpace. Controls how MediaLive will use the color space
        /// metadata from the source. Typically, choose FOLLOW, which means to use the color space
        /// metadata without changing it. Or choose another value (a standard). In this case,
        /// the handling is controlled by the colorspaceUsage property.
        /// </summary>
        public VideoSelectorColorSpace ColorSpace { get; set; }

        /// <summary>
        /// Checks to see if the ColorSpace property is set.
        /// </summary>
        internal bool IsSetColorSpace() => this.ColorSpace != null;

        /// <summary>
        /// Gets and sets the property ColorSpaceSettings. Choose HDR10 only if the following
        /// situation applies. Firstly, you specified HDR10 in ColorSpace. Secondly, the attached
        /// input is for AWS Elemental Link. Thirdly, you plan to convert the content to another
        /// color space. You need to specify the color space metadata that is missing from the
        /// source sent from AWS Elemental Link.
        /// </summary>
        public VideoSelectorColorSpaceSettings ColorSpaceSettings { get; set; }

        /// <summary>
        /// Checks to see if the ColorSpaceSettings property is set.
        /// </summary>
        internal bool IsSetColorSpaceSettings() => this.ColorSpaceSettings != null;

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
        public VideoSelectorColorSpaceUsage ColorSpaceUsage { get; set; }

        /// <summary>
        /// Checks to see if the ColorSpaceUsage property is set.
        /// </summary>
        internal bool IsSetColorSpaceUsage() => this.ColorSpaceUsage != null;

        /// <summary>
        /// Gets and sets the property SelectorSettings. The video selector settings.
        /// </summary>
        public VideoSelectorSettings SelectorSettings { get; set; }

        /// <summary>
        /// Checks to see if the SelectorSettings property is set.
        /// </summary>
        internal bool IsSetSelectorSettings() => this.SelectorSettings != null;
    }
}
