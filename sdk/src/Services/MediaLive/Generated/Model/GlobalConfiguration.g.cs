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
    /// Global Configuration
    /// </summary>
    public partial class GlobalConfiguration
    {
        /// <summary>
        /// Gets and sets the property InitialAudioGain. Value to set the initial audio gain for
        /// the Live Event.
        /// </summary>
        public int? InitialAudioGain { get; set; }

        /// <summary>
        /// Checks to see if the InitialAudioGain property is set.
        /// </summary>
        internal bool IsSetInitialAudioGain() => this.InitialAudioGain.HasValue;

        /// <summary>
        /// Gets and sets the property InputEndAction. Indicates the action to take when the current
        /// input completes (e.g. end-of-file). When switchAndLoopInputs is configured the encoder
        /// will restart at the beginning of the first input. When "none" is configured the encoder
        /// will transcode either black, a solid color, or a user specified slate images per the
        /// "Input Loss Behavior" configuration until the next input switch occurs (which is controlled
        /// through the Channel Schedule API).
        /// </summary>
        public GlobalConfigurationInputEndAction InputEndAction { get; set; }

        /// <summary>
        /// Checks to see if the InputEndAction property is set.
        /// </summary>
        internal bool IsSetInputEndAction() => this.InputEndAction != null;

        /// <summary>
        /// Gets and sets the property InputLossBehavior. Settings for system actions when input
        /// is lost.
        /// </summary>
        public InputLossBehavior InputLossBehavior { get; set; }

        /// <summary>
        /// Checks to see if the InputLossBehavior property is set.
        /// </summary>
        internal bool IsSetInputLossBehavior() => this.InputLossBehavior != null;

        /// <summary>
        /// Gets and sets the property OutputLockingMode. Indicates how MediaLive pipelines are
        /// synchronized. PIPELINE_LOCKING - MediaLive will attempt to synchronize the output
        /// of each pipeline to the other. EPOCH_LOCKING - MediaLive will attempt to synchronize
        /// the output of each pipeline to the Unix epoch. DISABLED - MediaLive will not attempt
        /// to synchronize the output of pipelines. We advise against disabling output locking
        /// because it has negative side effects in most workflows. For more information, see
        /// the section about output locking (pipeline locking) in the Medialive user guide.
        /// </summary>
        public GlobalConfigurationOutputLockingMode OutputLockingMode { get; set; }

        /// <summary>
        /// Checks to see if the OutputLockingMode property is set.
        /// </summary>
        internal bool IsSetOutputLockingMode() => this.OutputLockingMode != null;

        /// <summary>
        /// Gets and sets the property OutputLockingSettings. Advanced output locking settings
        /// </summary>
        public OutputLockingSettings OutputLockingSettings { get; set; }

        /// <summary>
        /// Checks to see if the OutputLockingSettings property is set.
        /// </summary>
        internal bool IsSetOutputLockingSettings() => this.OutputLockingSettings != null;

        /// <summary>
        /// Gets and sets the property OutputTimingSource. Indicates whether the rate of frames
        /// emitted by the Live encoder should be paced by its system clock (which optionally
        /// may be locked to another source via NTP) or should be locked to the clock of the source
        /// that is providing the input stream.
        /// </summary>
        public GlobalConfigurationOutputTimingSource OutputTimingSource { get; set; }

        /// <summary>
        /// Checks to see if the OutputTimingSource property is set.
        /// </summary>
        internal bool IsSetOutputTimingSource() => this.OutputTimingSource != null;

        /// <summary>
        /// Gets and sets the property SupportLowFramerateInputs. Adjusts video input buffer for
        /// streams with very low video framerates. This is commonly set to enabled for music
        /// channels with less than one video frame per second.
        /// </summary>
        public GlobalConfigurationLowFramerateInputs SupportLowFramerateInputs { get; set; }

        /// <summary>
        /// Checks to see if the SupportLowFramerateInputs property is set.
        /// </summary>
        internal bool IsSetSupportLowFramerateInputs() => this.SupportLowFramerateInputs != null;
    }
}
