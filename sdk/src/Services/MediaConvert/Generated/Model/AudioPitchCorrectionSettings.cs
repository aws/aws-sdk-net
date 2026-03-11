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
    /// Settings for audio pitch correction during framerate conversion.
    /// </summary>
    public partial class AudioPitchCorrectionSettings
    {
        private SlowPalPitchCorrection _slowPalPitchCorrection;

        /// <summary>
        /// Gets and sets the property SlowPalPitchCorrection. Use Slow PAL pitch correction to
        /// compensate for audio pitch changes during slow PAL frame rate conversion. This setting
        /// only applies when Slow PAL is enabled in your output video codec settings. To automatically
        /// apply audio pitch correction: Choose Enabled. MediaConvert automatically applies a
        /// pitch correction to your output to match the original content's audio pitch. To not
        /// apply audio pitch correction: Keep the default value, Disabled.
        /// </summary>
        public SlowPalPitchCorrection SlowPalPitchCorrection
        {
            get { return this._slowPalPitchCorrection; }
            set { this._slowPalPitchCorrection = value; }
        }

        // Check to see if SlowPalPitchCorrection property is set
        internal bool IsSetSlowPalPitchCorrection()
        {
            return this._slowPalPitchCorrection != null;
        }

    }
}