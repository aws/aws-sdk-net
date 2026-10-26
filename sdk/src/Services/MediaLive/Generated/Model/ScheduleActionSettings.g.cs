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
    /// Holds the settings for a single schedule action.
    /// </summary>
    public partial class ScheduleActionSettings
    {
        /// <summary>
        /// Gets and sets the property HlsId3SegmentTaggingSettings. Action to insert ID3 metadata
        /// in every segment, in HLS output groups
        /// </summary>
        public HlsId3SegmentTaggingScheduleActionSettings HlsId3SegmentTaggingSettings { get; set; }

        /// <summary>
        /// Checks to see if the HlsId3SegmentTaggingSettings property is set.
        /// </summary>
        internal bool IsSetHlsId3SegmentTaggingSettings() => this.HlsId3SegmentTaggingSettings != null;

        /// <summary>
        /// Gets and sets the property HlsTimedMetadataSettings. Action to insert ID3 metadata
        /// once, in HLS output groups
        /// </summary>
        public HlsTimedMetadataScheduleActionSettings HlsTimedMetadataSettings { get; set; }

        /// <summary>
        /// Checks to see if the HlsTimedMetadataSettings property is set.
        /// </summary>
        internal bool IsSetHlsTimedMetadataSettings() => this.HlsTimedMetadataSettings != null;

        /// <summary>
        /// Gets and sets the property Id3SegmentTaggingSettings. Action to insert ID3 metadata
        /// in every segment, in applicable output groups
        /// </summary>
        public Id3SegmentTaggingScheduleActionSettings Id3SegmentTaggingSettings { get; set; }

        /// <summary>
        /// Checks to see if the Id3SegmentTaggingSettings property is set.
        /// </summary>
        internal bool IsSetId3SegmentTaggingSettings() => this.Id3SegmentTaggingSettings != null;

        /// <summary>
        /// Gets and sets the property InputPrepareSettings. Action to prepare an input for a
        /// future immediate input switch
        /// </summary>
        public InputPrepareScheduleActionSettings InputPrepareSettings { get; set; }

        /// <summary>
        /// Checks to see if the InputPrepareSettings property is set.
        /// </summary>
        internal bool IsSetInputPrepareSettings() => this.InputPrepareSettings != null;

        /// <summary>
        /// Gets and sets the property InputSwitchSettings. Action to switch the input
        /// </summary>
        public InputSwitchScheduleActionSettings InputSwitchSettings { get; set; }

        /// <summary>
        /// Checks to see if the InputSwitchSettings property is set.
        /// </summary>
        internal bool IsSetInputSwitchSettings() => this.InputSwitchSettings != null;

        /// <summary>
        /// Gets and sets the property MotionGraphicsImageActivateSettings. Action to activate
        /// a motion graphics image overlay
        /// </summary>
        public MotionGraphicsActivateScheduleActionSettings MotionGraphicsImageActivateSettings { get; set; }

        /// <summary>
        /// Checks to see if the MotionGraphicsImageActivateSettings property is set.
        /// </summary>
        internal bool IsSetMotionGraphicsImageActivateSettings() => this.MotionGraphicsImageActivateSettings != null;

        /// <summary>
        /// Gets and sets the property MotionGraphicsImageDeactivateSettings. Action to deactivate
        /// a motion graphics image overlay
        /// </summary>
        public MotionGraphicsDeactivateScheduleActionSettings MotionGraphicsImageDeactivateSettings { get; set; }

        /// <summary>
        /// Checks to see if the MotionGraphicsImageDeactivateSettings property is set.
        /// </summary>
        internal bool IsSetMotionGraphicsImageDeactivateSettings() => this.MotionGraphicsImageDeactivateSettings != null;

        /// <summary>
        /// Gets and sets the property PauseStateSettings. Action to pause or unpause one or both
        /// channel pipelines
        /// </summary>
        public PauseStateScheduleActionSettings PauseStateSettings { get; set; }

        /// <summary>
        /// Checks to see if the PauseStateSettings property is set.
        /// </summary>
        internal bool IsSetPauseStateSettings() => this.PauseStateSettings != null;

        /// <summary>
        /// Gets and sets the property Scte35InputSettings. Action to specify scte35 input
        /// </summary>
        public Scte35InputScheduleActionSettings Scte35InputSettings { get; set; }

        /// <summary>
        /// Checks to see if the Scte35InputSettings property is set.
        /// </summary>
        internal bool IsSetScte35InputSettings() => this.Scte35InputSettings != null;

        /// <summary>
        /// Gets and sets the property Scte35ReturnToNetworkSettings. Action to insert SCTE-35
        /// return_to_network message
        /// </summary>
        public Scte35ReturnToNetworkScheduleActionSettings Scte35ReturnToNetworkSettings { get; set; }

        /// <summary>
        /// Checks to see if the Scte35ReturnToNetworkSettings property is set.
        /// </summary>
        internal bool IsSetScte35ReturnToNetworkSettings() => this.Scte35ReturnToNetworkSettings != null;

        /// <summary>
        /// Gets and sets the property Scte35SpliceInsertSettings. Action to insert SCTE-35 splice_insert
        /// message
        /// </summary>
        public Scte35SpliceInsertScheduleActionSettings Scte35SpliceInsertSettings { get; set; }

        /// <summary>
        /// Checks to see if the Scte35SpliceInsertSettings property is set.
        /// </summary>
        internal bool IsSetScte35SpliceInsertSettings() => this.Scte35SpliceInsertSettings != null;

        /// <summary>
        /// Gets and sets the property Scte35TimeSignalSettings. Action to insert SCTE-35 time_signal
        /// message
        /// </summary>
        public Scte35TimeSignalScheduleActionSettings Scte35TimeSignalSettings { get; set; }

        /// <summary>
        /// Checks to see if the Scte35TimeSignalSettings property is set.
        /// </summary>
        internal bool IsSetScte35TimeSignalSettings() => this.Scte35TimeSignalSettings != null;

        /// <summary>
        /// Gets and sets the property StaticImageActivateSettings. Action to activate a static
        /// image overlay
        /// </summary>
        public StaticImageActivateScheduleActionSettings StaticImageActivateSettings { get; set; }

        /// <summary>
        /// Checks to see if the StaticImageActivateSettings property is set.
        /// </summary>
        internal bool IsSetStaticImageActivateSettings() => this.StaticImageActivateSettings != null;

        /// <summary>
        /// Gets and sets the property StaticImageDeactivateSettings. Action to deactivate a static
        /// image overlay
        /// </summary>
        public StaticImageDeactivateScheduleActionSettings StaticImageDeactivateSettings { get; set; }

        /// <summary>
        /// Checks to see if the StaticImageDeactivateSettings property is set.
        /// </summary>
        internal bool IsSetStaticImageDeactivateSettings() => this.StaticImageDeactivateSettings != null;

        /// <summary>
        /// Gets and sets the property StaticImageOutputActivateSettings. Action to activate a
        /// static image overlay in one or more specified outputs
        /// </summary>
        public StaticImageOutputActivateScheduleActionSettings StaticImageOutputActivateSettings { get; set; }

        /// <summary>
        /// Checks to see if the StaticImageOutputActivateSettings property is set.
        /// </summary>
        internal bool IsSetStaticImageOutputActivateSettings() => this.StaticImageOutputActivateSettings != null;

        /// <summary>
        /// Gets and sets the property StaticImageOutputDeactivateSettings. Action to deactivate
        /// a static image overlay in one or more specified outputs
        /// </summary>
        public StaticImageOutputDeactivateScheduleActionSettings StaticImageOutputDeactivateSettings { get; set; }

        /// <summary>
        /// Checks to see if the StaticImageOutputDeactivateSettings property is set.
        /// </summary>
        internal bool IsSetStaticImageOutputDeactivateSettings() => this.StaticImageOutputDeactivateSettings != null;

        /// <summary>
        /// Gets and sets the property TimedMetadataSettings. Action to insert ID3 metadata once,
        /// in applicable output groups
        /// </summary>
        public TimedMetadataScheduleActionSettings TimedMetadataSettings { get; set; }

        /// <summary>
        /// Checks to see if the TimedMetadataSettings property is set.
        /// </summary>
        internal bool IsSetTimedMetadataSettings() => this.TimedMetadataSettings != null;
    }
}
