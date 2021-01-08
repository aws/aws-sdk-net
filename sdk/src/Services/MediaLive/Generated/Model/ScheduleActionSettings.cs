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
    /// Holds the settings for a single schedule action.
    /// </summary>
    public partial class ScheduleActionSettings
    {
        private HlsId3SegmentTaggingScheduleActionSettings _hlsId3SegmentTaggingSettings;
        private HlsTimedMetadataScheduleActionSettings _hlsTimedMetadataSettings;
        private InputPrepareScheduleActionSettings _inputPrepareSettings;
        private InputSwitchScheduleActionSettings _inputSwitchSettings;
        private PauseStateScheduleActionSettings _pauseStateSettings;
        private Scte35ReturnToNetworkScheduleActionSettings _scte35ReturnToNetworkSettings;
        private Scte35SpliceInsertScheduleActionSettings _scte35SpliceInsertSettings;
        private Scte35TimeSignalScheduleActionSettings _scte35TimeSignalSettings;
        private StaticImageActivateScheduleActionSettings _staticImageActivateSettings;
        private StaticImageDeactivateScheduleActionSettings _staticImageDeactivateSettings;

        /// <summary>
        /// Gets and sets the property HlsId3SegmentTaggingSettings. Action to insert HLS ID3
        /// segment tagging
        /// </summary>
        public HlsId3SegmentTaggingScheduleActionSettings HlsId3SegmentTaggingSettings
        {
            get { return this._hlsId3SegmentTaggingSettings; }
            set { this._hlsId3SegmentTaggingSettings = value; }
        }

        // Check to see if HlsId3SegmentTaggingSettings property is set
        internal bool IsSetHlsId3SegmentTaggingSettings()
        {
            return this._hlsId3SegmentTaggingSettings != null;
        }

        /// <summary>
        /// Gets and sets the property HlsTimedMetadataSettings. Action to insert HLS metadata
        /// </summary>
        public HlsTimedMetadataScheduleActionSettings HlsTimedMetadataSettings
        {
            get { return this._hlsTimedMetadataSettings; }
            set { this._hlsTimedMetadataSettings = value; }
        }

        // Check to see if HlsTimedMetadataSettings property is set
        internal bool IsSetHlsTimedMetadataSettings()
        {
            return this._hlsTimedMetadataSettings != null;
        }

        /// <summary>
        /// Gets and sets the property InputPrepareSettings. Action to prepare an input for a
        /// future immediate input switch
        /// </summary>
        public InputPrepareScheduleActionSettings InputPrepareSettings
        {
            get { return this._inputPrepareSettings; }
            set { this._inputPrepareSettings = value; }
        }

        // Check to see if InputPrepareSettings property is set
        internal bool IsSetInputPrepareSettings()
        {
            return this._inputPrepareSettings != null;
        }

        /// <summary>
        /// Gets and sets the property InputSwitchSettings. Action to switch the input
        /// </summary>
        public InputSwitchScheduleActionSettings InputSwitchSettings
        {
            get { return this._inputSwitchSettings; }
            set { this._inputSwitchSettings = value; }
        }

        // Check to see if InputSwitchSettings property is set
        internal bool IsSetInputSwitchSettings()
        {
            return this._inputSwitchSettings != null;
        }

        /// <summary>
        /// Gets and sets the property PauseStateSettings. Action to pause or unpause one or both
        /// channel pipelines
        /// </summary>
        public PauseStateScheduleActionSettings PauseStateSettings
        {
            get { return this._pauseStateSettings; }
            set { this._pauseStateSettings = value; }
        }

        // Check to see if PauseStateSettings property is set
        internal bool IsSetPauseStateSettings()
        {
            return this._pauseStateSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Scte35ReturnToNetworkSettings. Action to insert SCTE-35
        /// return_to_network message
        /// </summary>
        public Scte35ReturnToNetworkScheduleActionSettings Scte35ReturnToNetworkSettings
        {
            get { return this._scte35ReturnToNetworkSettings; }
            set { this._scte35ReturnToNetworkSettings = value; }
        }

        // Check to see if Scte35ReturnToNetworkSettings property is set
        internal bool IsSetScte35ReturnToNetworkSettings()
        {
            return this._scte35ReturnToNetworkSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Scte35SpliceInsertSettings. Action to insert SCTE-35 splice_insert
        /// message
        /// </summary>
        public Scte35SpliceInsertScheduleActionSettings Scte35SpliceInsertSettings
        {
            get { return this._scte35SpliceInsertSettings; }
            set { this._scte35SpliceInsertSettings = value; }
        }

        // Check to see if Scte35SpliceInsertSettings property is set
        internal bool IsSetScte35SpliceInsertSettings()
        {
            return this._scte35SpliceInsertSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Scte35TimeSignalSettings. Action to insert SCTE-35 time_signal
        /// message
        /// </summary>
        public Scte35TimeSignalScheduleActionSettings Scte35TimeSignalSettings
        {
            get { return this._scte35TimeSignalSettings; }
            set { this._scte35TimeSignalSettings = value; }
        }

        // Check to see if Scte35TimeSignalSettings property is set
        internal bool IsSetScte35TimeSignalSettings()
        {
            return this._scte35TimeSignalSettings != null;
        }

        /// <summary>
        /// Gets and sets the property StaticImageActivateSettings. Action to activate a static
        /// image overlay
        /// </summary>
        public StaticImageActivateScheduleActionSettings StaticImageActivateSettings
        {
            get { return this._staticImageActivateSettings; }
            set { this._staticImageActivateSettings = value; }
        }

        // Check to see if StaticImageActivateSettings property is set
        internal bool IsSetStaticImageActivateSettings()
        {
            return this._staticImageActivateSettings != null;
        }

        /// <summary>
        /// Gets and sets the property StaticImageDeactivateSettings. Action to deactivate a static
        /// image overlay
        /// </summary>
        public StaticImageDeactivateScheduleActionSettings StaticImageDeactivateSettings
        {
            get { return this._staticImageDeactivateSettings; }
            set { this._staticImageDeactivateSettings = value; }
        }

        // Check to see if StaticImageDeactivateSettings property is set
        internal bool IsSetStaticImageDeactivateSettings()
        {
            return this._staticImageDeactivateSettings != null;
        }

    }
}