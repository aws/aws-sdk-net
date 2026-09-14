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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Use these settings to specify static color calibration metadata, as defined by SMPTE
    /// ST 2086. These values don't affect the pixel values that are encoded in the video
    /// stream. They are intended to help the downstream video player display content in a
    /// way that reflects the intentions of the the content creator.
    /// </summary>
    public partial class Hdr10Metadata
    {
        /// <summary>
        /// Gets and sets the property BluePrimaryX. HDR Master Display Information must be provided
        /// by a color grader, using color grading tools. Range is 0 to 50,000, each increment
        /// represents 0.00002 in CIE1931 color coordinate. Note that this setting is not for
        /// color correction.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50000)]
        public int? BluePrimaryX { get; set; }

        /// <summary>
        /// Checks to see if the BluePrimaryX property is set.
        /// </summary>
        internal bool IsSetBluePrimaryX() => this.BluePrimaryX.HasValue;

        /// <summary>
        /// Gets and sets the property BluePrimaryY. HDR Master Display Information must be provided
        /// by a color grader, using color grading tools. Range is 0 to 50,000, each increment
        /// represents 0.00002 in CIE1931 color coordinate. Note that this setting is not for
        /// color correction.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50000)]
        public int? BluePrimaryY { get; set; }

        /// <summary>
        /// Checks to see if the BluePrimaryY property is set.
        /// </summary>
        internal bool IsSetBluePrimaryY() => this.BluePrimaryY.HasValue;

        /// <summary>
        /// Gets and sets the property GreenPrimaryX. HDR Master Display Information must be provided
        /// by a color grader, using color grading tools. Range is 0 to 50,000, each increment
        /// represents 0.00002 in CIE1931 color coordinate. Note that this setting is not for
        /// color correction.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50000)]
        public int? GreenPrimaryX { get; set; }

        /// <summary>
        /// Checks to see if the GreenPrimaryX property is set.
        /// </summary>
        internal bool IsSetGreenPrimaryX() => this.GreenPrimaryX.HasValue;

        /// <summary>
        /// Gets and sets the property GreenPrimaryY. HDR Master Display Information must be provided
        /// by a color grader, using color grading tools. Range is 0 to 50,000, each increment
        /// represents 0.00002 in CIE1931 color coordinate. Note that this setting is not for
        /// color correction.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50000)]
        public int? GreenPrimaryY { get; set; }

        /// <summary>
        /// Checks to see if the GreenPrimaryY property is set.
        /// </summary>
        internal bool IsSetGreenPrimaryY() => this.GreenPrimaryY.HasValue;

        /// <summary>
        /// Gets and sets the property MaxContentLightLevel. Maximum light level among all samples
        /// in the coded video sequence, in units of candelas per square meter. This setting doesn't
        /// have a default value; you must specify a value that is suitable for the content.
        /// </summary>
        [AWSProperty(Min = 0, Max = 65535)]
        public int? MaxContentLightLevel { get; set; }

        /// <summary>
        /// Checks to see if the MaxContentLightLevel property is set.
        /// </summary>
        internal bool IsSetMaxContentLightLevel() => this.MaxContentLightLevel.HasValue;

        /// <summary>
        /// Gets and sets the property MaxFrameAverageLightLevel. Maximum average light level
        /// of any frame in the coded video sequence, in units of candelas per square meter. This
        /// setting doesn't have a default value; you must specify a value that is suitable for
        /// the content.
        /// </summary>
        [AWSProperty(Min = 0, Max = 65535)]
        public int? MaxFrameAverageLightLevel { get; set; }

        /// <summary>
        /// Checks to see if the MaxFrameAverageLightLevel property is set.
        /// </summary>
        internal bool IsSetMaxFrameAverageLightLevel() => this.MaxFrameAverageLightLevel.HasValue;

        /// <summary>
        /// Gets and sets the property MaxLuminance. Nominal maximum mastering display luminance
        /// in units of of 0.0001 candelas per square meter.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? MaxLuminance { get; set; }

        /// <summary>
        /// Checks to see if the MaxLuminance property is set.
        /// </summary>
        internal bool IsSetMaxLuminance() => this.MaxLuminance.HasValue;

        /// <summary>
        /// Gets and sets the property MinLuminance. Nominal minimum mastering display luminance
        /// in units of of 0.0001 candelas per square meter
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? MinLuminance { get; set; }

        /// <summary>
        /// Checks to see if the MinLuminance property is set.
        /// </summary>
        internal bool IsSetMinLuminance() => this.MinLuminance.HasValue;

        /// <summary>
        /// Gets and sets the property RedPrimaryX. HDR Master Display Information must be provided
        /// by a color grader, using color grading tools. Range is 0 to 50,000, each increment
        /// represents 0.00002 in CIE1931 color coordinate. Note that this setting is not for
        /// color correction.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50000)]
        public int? RedPrimaryX { get; set; }

        /// <summary>
        /// Checks to see if the RedPrimaryX property is set.
        /// </summary>
        internal bool IsSetRedPrimaryX() => this.RedPrimaryX.HasValue;

        /// <summary>
        /// Gets and sets the property RedPrimaryY. HDR Master Display Information must be provided
        /// by a color grader, using color grading tools. Range is 0 to 50,000, each increment
        /// represents 0.00002 in CIE1931 color coordinate. Note that this setting is not for
        /// color correction.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50000)]
        public int? RedPrimaryY { get; set; }

        /// <summary>
        /// Checks to see if the RedPrimaryY property is set.
        /// </summary>
        internal bool IsSetRedPrimaryY() => this.RedPrimaryY.HasValue;

        /// <summary>
        /// Gets and sets the property WhitePointX. HDR Master Display Information must be provided
        /// by a color grader, using color grading tools. Range is 0 to 50,000, each increment
        /// represents 0.00002 in CIE1931 color coordinate. Note that this setting is not for
        /// color correction.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50000)]
        public int? WhitePointX { get; set; }

        /// <summary>
        /// Checks to see if the WhitePointX property is set.
        /// </summary>
        internal bool IsSetWhitePointX() => this.WhitePointX.HasValue;

        /// <summary>
        /// Gets and sets the property WhitePointY. HDR Master Display Information must be provided
        /// by a color grader, using color grading tools. Range is 0 to 50,000, each increment
        /// represents 0.00002 in CIE1931 color coordinate. Note that this setting is not for
        /// color correction.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50000)]
        public int? WhitePointY { get; set; }

        /// <summary>
        /// Checks to see if the WhitePointY property is set.
        /// </summary>
        internal bool IsSetWhitePointY() => this.WhitePointY.HasValue;
    }
}
