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
    /// Caption Destination Settings
    /// </summary>
    public partial class CaptionDestinationSettings
    {
        /// <summary>
        /// Gets and sets the property AribDestinationSettings.
        /// </summary>
        public AribDestinationSettings AribDestinationSettings { get; set; }

        /// <summary>
        /// Checks to see if the AribDestinationSettings property is set.
        /// </summary>
        internal bool IsSetAribDestinationSettings() => this.AribDestinationSettings != null;

        /// <summary>
        /// Gets and sets the property BurnInDestinationSettings.
        /// </summary>
        public BurnInDestinationSettings BurnInDestinationSettings { get; set; }

        /// <summary>
        /// Checks to see if the BurnInDestinationSettings property is set.
        /// </summary>
        internal bool IsSetBurnInDestinationSettings() => this.BurnInDestinationSettings != null;

        /// <summary>
        /// Gets and sets the property DvbSubDestinationSettings.
        /// </summary>
        public DvbSubDestinationSettings DvbSubDestinationSettings { get; set; }

        /// <summary>
        /// Checks to see if the DvbSubDestinationSettings property is set.
        /// </summary>
        internal bool IsSetDvbSubDestinationSettings() => this.DvbSubDestinationSettings != null;

        /// <summary>
        /// Gets and sets the property EbuTtDDestinationSettings.
        /// </summary>
        public EbuTtDDestinationSettings EbuTtDDestinationSettings { get; set; }

        /// <summary>
        /// Checks to see if the EbuTtDDestinationSettings property is set.
        /// </summary>
        internal bool IsSetEbuTtDDestinationSettings() => this.EbuTtDDestinationSettings != null;

        /// <summary>
        /// Gets and sets the property EmbeddedDestinationSettings.
        /// </summary>
        public EmbeddedDestinationSettings EmbeddedDestinationSettings { get; set; }

        /// <summary>
        /// Checks to see if the EmbeddedDestinationSettings property is set.
        /// </summary>
        internal bool IsSetEmbeddedDestinationSettings() => this.EmbeddedDestinationSettings != null;

        /// <summary>
        /// Gets and sets the property EmbeddedPlusScte20DestinationSettings.
        /// </summary>
        public EmbeddedPlusScte20DestinationSettings EmbeddedPlusScte20DestinationSettings { get; set; }

        /// <summary>
        /// Checks to see if the EmbeddedPlusScte20DestinationSettings property is set.
        /// </summary>
        internal bool IsSetEmbeddedPlusScte20DestinationSettings() => this.EmbeddedPlusScte20DestinationSettings != null;

        /// <summary>
        /// Gets and sets the property RtmpCaptionInfoDestinationSettings.
        /// </summary>
        public RtmpCaptionInfoDestinationSettings RtmpCaptionInfoDestinationSettings { get; set; }

        /// <summary>
        /// Checks to see if the RtmpCaptionInfoDestinationSettings property is set.
        /// </summary>
        internal bool IsSetRtmpCaptionInfoDestinationSettings() => this.RtmpCaptionInfoDestinationSettings != null;

        /// <summary>
        /// Gets and sets the property Scte20PlusEmbeddedDestinationSettings.
        /// </summary>
        public Scte20PlusEmbeddedDestinationSettings Scte20PlusEmbeddedDestinationSettings { get; set; }

        /// <summary>
        /// Checks to see if the Scte20PlusEmbeddedDestinationSettings property is set.
        /// </summary>
        internal bool IsSetScte20PlusEmbeddedDestinationSettings() => this.Scte20PlusEmbeddedDestinationSettings != null;

        /// <summary>
        /// Gets and sets the property Scte27DestinationSettings.
        /// </summary>
        public Scte27DestinationSettings Scte27DestinationSettings { get; set; }

        /// <summary>
        /// Checks to see if the Scte27DestinationSettings property is set.
        /// </summary>
        internal bool IsSetScte27DestinationSettings() => this.Scte27DestinationSettings != null;

        /// <summary>
        /// Gets and sets the property SmpteTtDestinationSettings.
        /// </summary>
        public SmpteTtDestinationSettings SmpteTtDestinationSettings { get; set; }

        /// <summary>
        /// Checks to see if the SmpteTtDestinationSettings property is set.
        /// </summary>
        internal bool IsSetSmpteTtDestinationSettings() => this.SmpteTtDestinationSettings != null;

        /// <summary>
        /// Gets and sets the property TeletextDestinationSettings.
        /// </summary>
        public TeletextDestinationSettings TeletextDestinationSettings { get; set; }

        /// <summary>
        /// Checks to see if the TeletextDestinationSettings property is set.
        /// </summary>
        internal bool IsSetTeletextDestinationSettings() => this.TeletextDestinationSettings != null;

        /// <summary>
        /// Gets and sets the property TtmlDestinationSettings.
        /// </summary>
        public TtmlDestinationSettings TtmlDestinationSettings { get; set; }

        /// <summary>
        /// Checks to see if the TtmlDestinationSettings property is set.
        /// </summary>
        internal bool IsSetTtmlDestinationSettings() => this.TtmlDestinationSettings != null;

        /// <summary>
        /// Gets and sets the property WebvttDestinationSettings.
        /// </summary>
        public WebvttDestinationSettings WebvttDestinationSettings { get; set; }

        /// <summary>
        /// Checks to see if the WebvttDestinationSettings property is set.
        /// </summary>
        internal bool IsSetWebvttDestinationSettings() => this.WebvttDestinationSettings != null;
    }
}
