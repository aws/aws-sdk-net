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
    /// For motion overlays that don't have a built-in frame rate, specify the frame rate
    /// of the overlay in frames per second, as a fraction. For example, specify 24 fps as
    /// 24/1. The overlay frame rate doesn't need to match the frame rate of the underlying
    /// video.
    /// </summary>
    public partial class MotionImageInsertionFramerate
    {
        private int? _framerateDenominator;
        private int? _framerateNumerator;

        /// <summary>
        /// Gets and sets the property FramerateDenominator. The bottom of the fraction that expresses
        /// your overlay frame rate. For example, if your frame rate is 24 fps, set this value
        /// to 1.
        /// </summary>
        [AWSProperty(Min=1, Max=17895697)]
        public int? FramerateDenominator
        {
            get { return this._framerateDenominator; }
            set { this._framerateDenominator = value; }
        }

        // Check to see if FramerateDenominator property is set
        internal bool IsSetFramerateDenominator()
        {
            return this._framerateDenominator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FramerateNumerator. The top of the fraction that expresses
        /// your overlay frame rate. For example, if your frame rate is 24 fps, set this value
        /// to 24.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483640)]
        public int? FramerateNumerator
        {
            get { return this._framerateNumerator; }
            set { this._framerateNumerator = value; }
        }

        // Check to see if FramerateNumerator property is set
        internal bool IsSetFramerateNumerator()
        {
            return this._framerateNumerator.HasValue; 
        }

    }
}