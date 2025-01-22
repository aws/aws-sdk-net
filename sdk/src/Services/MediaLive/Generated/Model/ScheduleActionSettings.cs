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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Holds the settings for a single schedule action.
    /// </summary>
    public partial class ScheduleActionSettings
    {
        private HlsId3SegmentTaggingScheduleActionSettings _hlsId3SegmentTaggingSettings;
        private HlsTimedMetadataScheduleActionSettings _hlsTimedMetadataSettings;
        private Id3SegmentTaggingScheduleActionSettings _id3SegmentTaggingSettings;
        private InputPrepareScheduleActionSettings _inputPrepareSettings;
        private InputSwitchScheduleActionSettings _inputSwitchSettings;
        private MotionGraphicsActivateScheduleActionSettings _motionGraphicsImageActivateSettings;
        private MotionGraphicsDeactivateScheduleActionSettings _motionGraphicsImageDeactivateSettings;
        private PauseStateScheduleActionSettings _pauseStateSettings;
        private Scte35InputScheduleActionSettings _scte35InputSettings;
        private Scte35ReturnToNetworkScheduleActionSettings _scte35ReturnToNetworkSettings;
        private Scte35SpliceInsertScheduleActionSettings _scte35SpliceInsertSettings;
        private Scte35TimeSignalScheduleActionSettings _scte35TimeSignalSettings;
        private StaticImageActivateScheduleActionSettings _staticImageActivateSettings;
        private StaticImageDeactivateScheduleActionSettings _staticImageDeactivateSettings;
        private StaticImageOutputActivateScheduleActionSettings _staticImageOutputActivateSettings;
        private StaticImageOutputDeactivateScheduleActionSettings _staticImageOutputDeactivateSettings;
        private TimedMetadataScheduleActionSettings _timedMetadataSettings;

        /// <summary>
        /// Gets and sets the property HlsId3SegmentTaggingSettings. Action to insert ID3 metadata
        /// in every segment, in HLS output groups
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
        /// Gets and sets the property HlsTimedMetadataSettings. Action to insert ID3 metadata
        /// once, in HLS output groups
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
        /// Gets and sets the property Id3SegmentTaggingSettings. Action to insert ID3 metadata
        /// in every segment, in applicable output groups
        /// </summary>
        public Id3SegmentTaggingScheduleActionSettings Id3SegmentTaggingSettings
        {
            get { return this._id3SegmentTaggingSettings; }
            set { this._id3SegmentTaggingSettings = value; }
        }

        // Check to see if Id3SegmentTaggingSettings property is set
        internal bool IsSetId3SegmentTaggingSettings()
        {
            return this._id3SegmentTaggingSettings != null;
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
        /// Gets and sets the property MotionGraphicsImageActivateSettings. Action to activate
        /// a motion graphics image overlay
        /// </summary>
        public MotionGraphicsActivateScheduleActionSettings MotionGraphicsImageActivateSettings
        {
            get { return this._motionGraphicsImageActivateSettings; }
            set { this._motionGraphicsImageActivateSettings = value; }
        }

        // Check to see if MotionGraphicsImageActivateSettings property is set
        internal bool IsSetMotionGraphicsImageActivateSettings()
        {
            return this._motionGraphicsImageActivateSettings != null;
        }

        /// <summary>
        /// Gets and sets the property MotionGraphicsImageDeactivateSettings. Action to deactivate
        /// a motion graphics image overlay
        /// </summary>
        public MotionGraphicsDeactivateScheduleActionSettings MotionGraphicsImageDeactivateSettings
        {
            get { return this._motionGraphicsImageDeactivateSettings; }
            set { this._motionGraphicsImageDeactivateSettings = value; }
        }

        // Check to see if MotionGraphicsImageDeactivateSettings property is set
        internal bool IsSetMotionGraphicsImageDeactivateSettings()
        {
            return this._motionGraphicsImageDeactivateSettings != null;
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
        /// Gets and sets the property Scte35InputSettings. Action to specify scte35 input
        /// </summary>
        public Scte35InputScheduleActionSettings Scte35InputSettings
        {
            get { return this._scte35InputSettings; }
            set { this._scte35InputSettings = value; }
        }

        // Check to see if Scte35InputSettings property is set
        internal bool IsSetScte35InputSettings()
        {
            return this._scte35InputSettings != null;
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

        /// <summary>
        /// Gets and sets the property StaticImageOutputActivateSettings. Action to activate a
        /// static image overlay in one or more specified outputs
        /// </summary>
        public StaticImageOutputActivateScheduleActionSettings StaticImageOutputActivateSettings
        {
            get { return this._staticImageOutputActivateSettings; }
            set { this._staticImageOutputActivateSettings = value; }
        }

        // Check to see if StaticImageOutputActivateSettings property is set
        internal bool IsSetStaticImageOutputActivateSettings()
        {
            return this._staticImageOutputActivateSettings != null;
        }

        /// <summary>
        /// Gets and sets the property StaticImageOutputDeactivateSettings. Action to deactivate
        /// a static image overlay in one or more specified outputs
        /// </summary>
        public StaticImageOutputDeactivateScheduleActionSettings StaticImageOutputDeactivateSettings
        {
            get { return this._staticImageOutputDeactivateSettings; }
            set { this._staticImageOutputDeactivateSettings = value; }
        }

        // Check to see if StaticImageOutputDeactivateSettings property is set
        internal bool IsSetStaticImageOutputDeactivateSettings()
        {
            return this._staticImageOutputDeactivateSettings != null;
        }

        /// <summary>
        /// Gets and sets the property TimedMetadataSettings. Action to insert ID3 metadata once,
        /// in applicable output groups
        /// </summary>
        public TimedMetadataScheduleActionSettings TimedMetadataSettings
        {
            get { return this._timedMetadataSettings; }
            set { this._timedMetadataSettings = value; }
        }

        // Check to see if TimedMetadataSettings property is set
        internal bool IsSetTimedMetadataSettings()
        {
            return this._timedMetadataSettings != null;
        }

    }
}