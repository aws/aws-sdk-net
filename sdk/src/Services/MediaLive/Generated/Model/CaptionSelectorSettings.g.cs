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
    /// Caption Selector Settings
    /// </summary>
    public partial class CaptionSelectorSettings
    {
        /// <summary>
        /// Gets and sets the property AncillarySourceSettings.
        /// </summary>
        public AncillarySourceSettings AncillarySourceSettings { get; set; }

        /// <summary>
        /// Checks to see if the AncillarySourceSettings property is set.
        /// </summary>
        internal bool IsSetAncillarySourceSettings() => this.AncillarySourceSettings != null;

        /// <summary>
        /// Gets and sets the property AribSourceSettings.
        /// </summary>
        public AribSourceSettings AribSourceSettings { get; set; }

        /// <summary>
        /// Checks to see if the AribSourceSettings property is set.
        /// </summary>
        internal bool IsSetAribSourceSettings() => this.AribSourceSettings != null;

        /// <summary>
        /// Gets and sets the property DvbSubSourceSettings.
        /// </summary>
        public DvbSubSourceSettings DvbSubSourceSettings { get; set; }

        /// <summary>
        /// Checks to see if the DvbSubSourceSettings property is set.
        /// </summary>
        internal bool IsSetDvbSubSourceSettings() => this.DvbSubSourceSettings != null;

        /// <summary>
        /// Gets and sets the property EmbeddedSourceSettings.
        /// </summary>
        public EmbeddedSourceSettings EmbeddedSourceSettings { get; set; }

        /// <summary>
        /// Checks to see if the EmbeddedSourceSettings property is set.
        /// </summary>
        internal bool IsSetEmbeddedSourceSettings() => this.EmbeddedSourceSettings != null;

        /// <summary>
        /// Gets and sets the property Scte20SourceSettings.
        /// </summary>
        public Scte20SourceSettings Scte20SourceSettings { get; set; }

        /// <summary>
        /// Checks to see if the Scte20SourceSettings property is set.
        /// </summary>
        internal bool IsSetScte20SourceSettings() => this.Scte20SourceSettings != null;

        /// <summary>
        /// Gets and sets the property Scte27SourceSettings.
        /// </summary>
        public Scte27SourceSettings Scte27SourceSettings { get; set; }

        /// <summary>
        /// Checks to see if the Scte27SourceSettings property is set.
        /// </summary>
        internal bool IsSetScte27SourceSettings() => this.Scte27SourceSettings != null;

        /// <summary>
        /// Gets and sets the property SmartSubtitleSourceSettings.
        /// </summary>
        public SmartSubtitleSourceSettings SmartSubtitleSourceSettings { get; set; }

        /// <summary>
        /// Checks to see if the SmartSubtitleSourceSettings property is set.
        /// </summary>
        internal bool IsSetSmartSubtitleSourceSettings() => this.SmartSubtitleSourceSettings != null;

        /// <summary>
        /// Gets and sets the property TeletextSourceSettings.
        /// </summary>
        public TeletextSourceSettings TeletextSourceSettings { get; set; }

        /// <summary>
        /// Checks to see if the TeletextSourceSettings property is set.
        /// </summary>
        internal bool IsSetTeletextSourceSettings() => this.TeletextSourceSettings != null;
    }
}
