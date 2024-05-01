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
    /// Use automated encoding to have MediaConvert choose your encoding settings for you,
    /// based on characteristics of your input video.
    /// </summary>
    public partial class AutomatedEncodingSettings
    {
        private AutomatedAbrSettings _abrSettings;

        /// <summary>
        /// Gets and sets the property AbrSettings. Use automated ABR to have MediaConvert set
        /// up the renditions in your ABR package for you automatically, based on characteristics
        /// of your input video. This feature optimizes video quality while minimizing the overall
        /// size of your ABR package.
        /// </summary>
        public AutomatedAbrSettings AbrSettings
        {
            get { return this._abrSettings; }
            set { this._abrSettings = value; }
        }

        // Check to see if AbrSettings property is set
        internal bool IsSetAbrSettings()
        {
            return this._abrSettings != null;
        }

    }
}