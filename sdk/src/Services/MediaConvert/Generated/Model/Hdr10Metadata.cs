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
        private int? _bluePrimaryX;
        private int? _bluePrimaryY;
        private int? _greenPrimaryX;
        private int? _greenPrimaryY;
        private int? _maxContentLightLevel;
        private int? _maxFrameAverageLightLevel;
        private int? _maxLuminance;
        private int? _minLuminance;
        private int? _redPrimaryX;
        private int? _redPrimaryY;
        private int? _whitePointX;
        private int? _whitePointY;

        /// <summary>
        /// Gets and sets the property BluePrimaryX. HDR Master Display Information must be provided
        /// by a color grader, using color grading tools. Range is 0 to 50,000, each increment
        /// represents 0.00002 in CIE1931 color coordinate. Note that this setting is not for
        /// color correction.
        /// </summary>
        [AWSProperty(Min=0, Max=50000)]
        public int BluePrimaryX
        {
            get { return this._bluePrimaryX.GetValueOrDefault(); }
            set { this._bluePrimaryX = value; }
        }

        // Check to see if BluePrimaryX property is set
        internal bool IsSetBluePrimaryX()
        {
            return this._bluePrimaryX.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BluePrimaryY. HDR Master Display Information must be provided
        /// by a color grader, using color grading tools. Range is 0 to 50,000, each increment
        /// represents 0.00002 in CIE1931 color coordinate. Note that this setting is not for
        /// color correction.
        /// </summary>
        [AWSProperty(Min=0, Max=50000)]
        public int BluePrimaryY
        {
            get { return this._bluePrimaryY.GetValueOrDefault(); }
            set { this._bluePrimaryY = value; }
        }

        // Check to see if BluePrimaryY property is set
        internal bool IsSetBluePrimaryY()
        {
            return this._bluePrimaryY.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GreenPrimaryX. HDR Master Display Information must be provided
        /// by a color grader, using color grading tools. Range is 0 to 50,000, each increment
        /// represents 0.00002 in CIE1931 color coordinate. Note that this setting is not for
        /// color correction.
        /// </summary>
        [AWSProperty(Min=0, Max=50000)]
        public int GreenPrimaryX
        {
            get { return this._greenPrimaryX.GetValueOrDefault(); }
            set { this._greenPrimaryX = value; }
        }

        // Check to see if GreenPrimaryX property is set
        internal bool IsSetGreenPrimaryX()
        {
            return this._greenPrimaryX.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GreenPrimaryY. HDR Master Display Information must be provided
        /// by a color grader, using color grading tools. Range is 0 to 50,000, each increment
        /// represents 0.00002 in CIE1931 color coordinate. Note that this setting is not for
        /// color correction.
        /// </summary>
        [AWSProperty(Min=0, Max=50000)]
        public int GreenPrimaryY
        {
            get { return this._greenPrimaryY.GetValueOrDefault(); }
            set { this._greenPrimaryY = value; }
        }

        // Check to see if GreenPrimaryY property is set
        internal bool IsSetGreenPrimaryY()
        {
            return this._greenPrimaryY.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxContentLightLevel. Maximum light level among all samples
        /// in the coded video sequence, in units of candelas per square meter. This setting doesn't
        /// have a default value; you must specify a value that is suitable for the content.
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public int MaxContentLightLevel
        {
            get { return this._maxContentLightLevel.GetValueOrDefault(); }
            set { this._maxContentLightLevel = value; }
        }

        // Check to see if MaxContentLightLevel property is set
        internal bool IsSetMaxContentLightLevel()
        {
            return this._maxContentLightLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxFrameAverageLightLevel. Maximum average light level
        /// of any frame in the coded video sequence, in units of candelas per square meter. This
        /// setting doesn't have a default value; you must specify a value that is suitable for
        /// the content.
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public int MaxFrameAverageLightLevel
        {
            get { return this._maxFrameAverageLightLevel.GetValueOrDefault(); }
            set { this._maxFrameAverageLightLevel = value; }
        }

        // Check to see if MaxFrameAverageLightLevel property is set
        internal bool IsSetMaxFrameAverageLightLevel()
        {
            return this._maxFrameAverageLightLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxLuminance. Nominal maximum mastering display luminance
        /// in units of of 0.0001 candelas per square meter.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int MaxLuminance
        {
            get { return this._maxLuminance.GetValueOrDefault(); }
            set { this._maxLuminance = value; }
        }

        // Check to see if MaxLuminance property is set
        internal bool IsSetMaxLuminance()
        {
            return this._maxLuminance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinLuminance. Nominal minimum mastering display luminance
        /// in units of of 0.0001 candelas per square meter
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int MinLuminance
        {
            get { return this._minLuminance.GetValueOrDefault(); }
            set { this._minLuminance = value; }
        }

        // Check to see if MinLuminance property is set
        internal bool IsSetMinLuminance()
        {
            return this._minLuminance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RedPrimaryX. HDR Master Display Information must be provided
        /// by a color grader, using color grading tools. Range is 0 to 50,000, each increment
        /// represents 0.00002 in CIE1931 color coordinate. Note that this setting is not for
        /// color correction.
        /// </summary>
        [AWSProperty(Min=0, Max=50000)]
        public int RedPrimaryX
        {
            get { return this._redPrimaryX.GetValueOrDefault(); }
            set { this._redPrimaryX = value; }
        }

        // Check to see if RedPrimaryX property is set
        internal bool IsSetRedPrimaryX()
        {
            return this._redPrimaryX.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RedPrimaryY. HDR Master Display Information must be provided
        /// by a color grader, using color grading tools. Range is 0 to 50,000, each increment
        /// represents 0.00002 in CIE1931 color coordinate. Note that this setting is not for
        /// color correction.
        /// </summary>
        [AWSProperty(Min=0, Max=50000)]
        public int RedPrimaryY
        {
            get { return this._redPrimaryY.GetValueOrDefault(); }
            set { this._redPrimaryY = value; }
        }

        // Check to see if RedPrimaryY property is set
        internal bool IsSetRedPrimaryY()
        {
            return this._redPrimaryY.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WhitePointX. HDR Master Display Information must be provided
        /// by a color grader, using color grading tools. Range is 0 to 50,000, each increment
        /// represents 0.00002 in CIE1931 color coordinate. Note that this setting is not for
        /// color correction.
        /// </summary>
        [AWSProperty(Min=0, Max=50000)]
        public int WhitePointX
        {
            get { return this._whitePointX.GetValueOrDefault(); }
            set { this._whitePointX = value; }
        }

        // Check to see if WhitePointX property is set
        internal bool IsSetWhitePointX()
        {
            return this._whitePointX.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WhitePointY. HDR Master Display Information must be provided
        /// by a color grader, using color grading tools. Range is 0 to 50,000, each increment
        /// represents 0.00002 in CIE1931 color coordinate. Note that this setting is not for
        /// color correction.
        /// </summary>
        [AWSProperty(Min=0, Max=50000)]
        public int WhitePointY
        {
            get { return this._whitePointY.GetValueOrDefault(); }
            set { this._whitePointY = value; }
        }

        // Check to see if WhitePointY property is set
        internal bool IsSetWhitePointY()
        {
            return this._whitePointY.HasValue; 
        }

    }
}