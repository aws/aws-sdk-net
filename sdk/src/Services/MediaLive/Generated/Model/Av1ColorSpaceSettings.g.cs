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
    /// Av1 Color Space Settings
    /// </summary>
    public partial class Av1ColorSpaceSettings
    {
        /// <summary>
        /// Gets and sets the property ColorSpacePassthroughSettings.
        /// </summary>
        public ColorSpacePassthroughSettings ColorSpacePassthroughSettings { get; set; }

        /// <summary>
        /// Checks to see if the ColorSpacePassthroughSettings property is set.
        /// </summary>
        internal bool IsSetColorSpacePassthroughSettings() => this.ColorSpacePassthroughSettings != null;

        /// <summary>
        /// Gets and sets the property Hdr10Settings.
        /// </summary>
        public Hdr10Settings Hdr10Settings { get; set; }

        /// <summary>
        /// Checks to see if the Hdr10Settings property is set.
        /// </summary>
        internal bool IsSetHdr10Settings() => this.Hdr10Settings != null;

        /// <summary>
        /// Gets and sets the property Hlg2020Settings.
        /// </summary>
        public Hlg2020Settings Hlg2020Settings { get; set; }

        /// <summary>
        /// Checks to see if the Hlg2020Settings property is set.
        /// </summary>
        internal bool IsSetHlg2020Settings() => this.Hlg2020Settings != null;

        /// <summary>
        /// Gets and sets the property Rec601Settings.
        /// </summary>
        public Rec601Settings Rec601Settings { get; set; }

        /// <summary>
        /// Checks to see if the Rec601Settings property is set.
        /// </summary>
        internal bool IsSetRec601Settings() => this.Rec601Settings != null;

        /// <summary>
        /// Gets and sets the property Rec709Settings.
        /// </summary>
        public Rec709Settings Rec709Settings { get; set; }

        /// <summary>
        /// Checks to see if the Rec709Settings property is set.
        /// </summary>
        internal bool IsSetRec709Settings() => this.Rec709Settings != null;
    }
}
