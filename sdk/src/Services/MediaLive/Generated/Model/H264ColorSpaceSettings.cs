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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// H264 Color Space Settings
    /// </summary>
    public partial class H264ColorSpaceSettings
    {
        private ColorSpacePassthroughSettings _colorSpacePassthroughSettings;
        private Rec601Settings _rec601Settings;
        private Rec709Settings _rec709Settings;

        /// <summary>
        /// Gets and sets the property ColorSpacePassthroughSettings.
        /// </summary>
        public ColorSpacePassthroughSettings ColorSpacePassthroughSettings
        {
            get { return this._colorSpacePassthroughSettings; }
            set { this._colorSpacePassthroughSettings = value; }
        }

        // Check to see if ColorSpacePassthroughSettings property is set
        internal bool IsSetColorSpacePassthroughSettings()
        {
            return this._colorSpacePassthroughSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Rec601Settings.
        /// </summary>
        public Rec601Settings Rec601Settings
        {
            get { return this._rec601Settings; }
            set { this._rec601Settings = value; }
        }

        // Check to see if Rec601Settings property is set
        internal bool IsSetRec601Settings()
        {
            return this._rec601Settings != null;
        }

        /// <summary>
        /// Gets and sets the property Rec709Settings.
        /// </summary>
        public Rec709Settings Rec709Settings
        {
            get { return this._rec709Settings; }
            set { this._rec709Settings = value; }
        }

        // Check to see if Rec709Settings property is set
        internal bool IsSetRec709Settings()
        {
            return this._rec709Settings != null;
        }

    }
}