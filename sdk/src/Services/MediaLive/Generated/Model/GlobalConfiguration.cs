/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Placeholder documentation for GlobalConfiguration
    /// </summary>
    public partial class GlobalConfiguration
    {
        private int? _initialAudioGain;
        private GlobalConfigurationInputEndAction _inputEndAction;
        private InputLossBehavior _inputLossBehavior;
        private GlobalConfigurationOutputTimingSource _outputTimingSource;
        private GlobalConfigurationLowFramerateInputs _supportLowFramerateInputs;

        /// <summary>
        /// Gets and sets the property InitialAudioGain. Value to set the initial audio gain for
        /// the Live Event.
        /// </summary>
        public int InitialAudioGain
        {
            get { return this._initialAudioGain.GetValueOrDefault(); }
            set { this._initialAudioGain = value; }
        }

        // Check to see if InitialAudioGain property is set
        internal bool IsSetInitialAudioGain()
        {
            return this._initialAudioGain.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputEndAction. Indicates the action to take when the input
        /// completes (e.g. end-of-file). Options include looping on the input (via "switchAndLoopInputs")
        /// or transcoding black / color / slate images per the "Input Loss Behavior" configuration
        /// (via "none").
        /// </summary>
        public GlobalConfigurationInputEndAction InputEndAction
        {
            get { return this._inputEndAction; }
            set { this._inputEndAction = value; }
        }

        // Check to see if InputEndAction property is set
        internal bool IsSetInputEndAction()
        {
            return this._inputEndAction != null;
        }

        /// <summary>
        /// Gets and sets the property InputLossBehavior. Settings for system actions when input
        /// is lost.
        /// </summary>
        public InputLossBehavior InputLossBehavior
        {
            get { return this._inputLossBehavior; }
            set { this._inputLossBehavior = value; }
        }

        // Check to see if InputLossBehavior property is set
        internal bool IsSetInputLossBehavior()
        {
            return this._inputLossBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property OutputTimingSource. Indicates whether the rate of frames
        /// emitted by the Live encoder should be paced by its system clock (which optionally
        /// may be locked to another source via NTP) or should be locked to the clock of the source
        /// that is providing the input stream.
        /// </summary>
        public GlobalConfigurationOutputTimingSource OutputTimingSource
        {
            get { return this._outputTimingSource; }
            set { this._outputTimingSource = value; }
        }

        // Check to see if OutputTimingSource property is set
        internal bool IsSetOutputTimingSource()
        {
            return this._outputTimingSource != null;
        }

        /// <summary>
        /// Gets and sets the property SupportLowFramerateInputs. Adjusts video input buffer for
        /// streams with very low video framerates. This is commonly set to enabled for music
        /// channels with less than one video frame per second.
        /// </summary>
        public GlobalConfigurationLowFramerateInputs SupportLowFramerateInputs
        {
            get { return this._supportLowFramerateInputs; }
            set { this._supportLowFramerateInputs = value; }
        }

        // Check to see if SupportLowFramerateInputs property is set
        internal bool IsSetSupportLowFramerateInputs()
        {
            return this._supportLowFramerateInputs != null;
        }

    }
}