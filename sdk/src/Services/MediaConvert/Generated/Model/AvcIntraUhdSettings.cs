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
    /// Optional when you set AVC-Intra class to Class 4K/2K. When you set AVC-Intra class
    /// to a different value, this object isn't allowed.
    /// </summary>
    public partial class AvcIntraUhdSettings
    {
        private AvcIntraUhdQualityTuningLevel _qualityTuningLevel;

        /// <summary>
        /// Gets and sets the property QualityTuningLevel. Optional. Use Quality tuning level
        /// to choose how many transcoding passes MediaConvert does with your video. When you
        /// choose Multi-pass, your video quality is better and your output bitrate is more accurate.
        /// That is, the actual bitrate of your output is closer to the target bitrate defined
        /// in the specification. When you choose Single-pass, your encoding time is faster. The
        /// default behavior is Single-pass.
        /// </summary>
        public AvcIntraUhdQualityTuningLevel QualityTuningLevel
        {
            get { return this._qualityTuningLevel; }
            set { this._qualityTuningLevel = value; }
        }

        // Check to see if QualityTuningLevel property is set
        internal bool IsSetQualityTuningLevel()
        {
            return this._qualityTuningLevel != null;
        }

    }
}