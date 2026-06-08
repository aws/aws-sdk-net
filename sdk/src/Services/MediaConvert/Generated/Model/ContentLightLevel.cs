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
    /// Content light level information (CTA-861.3). Describes the light level characteristics
    /// of the content.
    /// </summary>
    public partial class ContentLightLevel
    {
        private int? _maxContentLightLevel;
        private int? _maxFrameAverageLightLevel;

        /// <summary>
        /// Gets and sets the property MaxContentLightLevel. Maximum content light level (MaxCLL),
        /// in cd/m².
        /// </summary>
        public int? MaxContentLightLevel
        {
            get { return this._maxContentLightLevel; }
            set { this._maxContentLightLevel = value; }
        }

        // Check to see if MaxContentLightLevel property is set
        internal bool IsSetMaxContentLightLevel()
        {
            return this._maxContentLightLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxFrameAverageLightLevel. Maximum frame-average light
        /// level (MaxFALL), in cd/m².
        /// </summary>
        public int? MaxFrameAverageLightLevel
        {
            get { return this._maxFrameAverageLightLevel; }
            set { this._maxFrameAverageLightLevel = value; }
        }

        // Check to see if MaxFrameAverageLightLevel property is set
        internal bool IsSetMaxFrameAverageLightLevel()
        {
            return this._maxFrameAverageLightLevel.HasValue; 
        }

    }
}