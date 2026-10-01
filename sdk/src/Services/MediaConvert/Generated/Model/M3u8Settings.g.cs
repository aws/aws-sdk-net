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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// These settings relate to the MPEG-2 transport stream (MPEG2-TS) container for the
    /// MPEG2-TS segments in your HLS outputs.
    /// </summary>
    public partial class M3u8Settings
    {
        /// <summary>
        /// Gets and sets the property AudioDuration. Specify this setting only when your output
        /// will be consumed by a downstream repackaging workflow that is sensitive to very small
        /// duration differences between video and audio. For this situation, choose Match video
        /// duration. In all other cases, keep the default value, Default codec duration. When
        /// you choose Match video duration, MediaConvert pads the output audio streams with silence
        /// or trims them to ensure that the total duration of each audio stream is at least as
        /// long as the total duration of the video stream. After padding or trimming, the audio
        /// stream duration is no more than one frame longer than the video stream. MediaConvert
        /// applies audio padding or trimming only to the end of the last segment of the output.
        /// For unsegmented outputs, MediaConvert adds padding only to the end of the file. When
        /// you keep the default value, any minor discrepancies between audio and video duration
        /// will depend on your output audio codec.
        /// </summary>
        public M3u8AudioDuration AudioDuration { get; set; }

        /// <summary>
        /// Checks to see if the AudioDuration property is set.
        /// </summary>
        internal bool IsSetAudioDuration() => this.AudioDuration != null;

        /// <summary>
        /// Gets and sets the property AudioFramesPerPes. The number of audio frames to insert
        /// for each PES packet.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? AudioFramesPerPes { get; set; }

        /// <summary>
        /// Checks to see if the AudioFramesPerPes property is set.
        /// </summary>
        internal bool IsSetAudioFramesPerPes() => this.AudioFramesPerPes.HasValue;

        /// <summary>
        /// Gets and sets the property AudioPids. Packet Identifier (PID) of the elementary audio
        /// stream(s) in the transport stream. Multiple values are accepted, and can be entered
        /// in ranges and/or by comma separation.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> AudioPids { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the AudioPids property is set.
        /// </summary>
        internal bool IsSetAudioPids() => this.AudioPids != null && (this.AudioPids.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AudioPtsOffsetDelta. Manually specify the difference in
        /// PTS offset that will be applied to the audio track, in seconds or milliseconds, when
        /// you set PTS offset to Seconds or Milliseconds. Enter an integer from -10000 to 10000.
        /// Leave blank to keep the default value 0.
        /// </summary>
        [AWSProperty(Min = -10000, Max = 10000)]
        public int? AudioPtsOffsetDelta { get; set; }

        /// <summary>
        /// Checks to see if the AudioPtsOffsetDelta property is set.
        /// </summary>
        internal bool IsSetAudioPtsOffsetDelta() => this.AudioPtsOffsetDelta.HasValue;

        /// <summary>
        /// Gets and sets the property DataPTSControl. If you select ALIGN_TO_VIDEO, MediaConvert
        /// writes captions and data packets with Presentation Timestamp (PTS) values greater
        /// than or equal to the first video packet PTS (MediaConvert drops captions and data
        /// packets with lesser PTS values). Keep the default value AUTO to allow all PTS values.
        /// </summary>
        public M3u8DataPtsControl DataPTSControl { get; set; }

        /// <summary>
        /// Checks to see if the DataPTSControl property is set.
        /// </summary>
        internal bool IsSetDataPTSControl() => this.DataPTSControl != null;

        /// <summary>
        /// Gets and sets the property MaxPcrInterval. Specify the maximum time, in milliseconds,
        /// between Program Clock References (PCRs) inserted into the transport stream.
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public int? MaxPcrInterval { get; set; }

        /// <summary>
        /// Checks to see if the MaxPcrInterval property is set.
        /// </summary>
        internal bool IsSetMaxPcrInterval() => this.MaxPcrInterval.HasValue;

        /// <summary>
        /// Gets and sets the property NielsenId3. If INSERT, Nielsen inaudible tones for media
        /// tracking will be detected in the input audio and an equivalent ID3 tag will be inserted
        /// in the output.
        /// </summary>
        public M3u8NielsenId3 NielsenId3 { get; set; }

        /// <summary>
        /// Checks to see if the NielsenId3 property is set.
        /// </summary>
        internal bool IsSetNielsenId3() => this.NielsenId3 != null;

        /// <summary>
        /// Gets and sets the property PatInterval. The number of milliseconds between instances
        /// of this table in the output transport stream.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public int? PatInterval { get; set; }

        /// <summary>
        /// Checks to see if the PatInterval property is set.
        /// </summary>
        internal bool IsSetPatInterval() => this.PatInterval.HasValue;

        /// <summary>
        /// Gets and sets the property PcrControl. When set to PCR_EVERY_PES_PACKET a Program
        /// Clock Reference value is inserted for every Packetized Elementary Stream (PES) header.
        /// This parameter is effective only when the PCR PID is the same as the video or audio
        /// elementary stream.
        /// </summary>
        public M3u8PcrControl PcrControl { get; set; }

        /// <summary>
        /// Checks to see if the PcrControl property is set.
        /// </summary>
        internal bool IsSetPcrControl() => this.PcrControl != null;

        /// <summary>
        /// Gets and sets the property PcrPid. Packet Identifier (PID) of the Program Clock Reference
        /// (PCR) in the transport stream. When no value is given, the encoder will assign the
        /// same value as the Video PID.
        /// </summary>
        [AWSProperty(Min = 32, Max = 8182)]
        public int? PcrPid { get; set; }

        /// <summary>
        /// Checks to see if the PcrPid property is set.
        /// </summary>
        internal bool IsSetPcrPid() => this.PcrPid.HasValue;

        /// <summary>
        /// Gets and sets the property PmtInterval. The number of milliseconds between instances
        /// of this table in the output transport stream.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public int? PmtInterval { get; set; }

        /// <summary>
        /// Checks to see if the PmtInterval property is set.
        /// </summary>
        internal bool IsSetPmtInterval() => this.PmtInterval.HasValue;

        /// <summary>
        /// Gets and sets the property PmtPid. Packet Identifier (PID) for the Program Map Table
        /// (PMT) in the transport stream.
        /// </summary>
        [AWSProperty(Min = 32, Max = 8182)]
        public int? PmtPid { get; set; }

        /// <summary>
        /// Checks to see if the PmtPid property is set.
        /// </summary>
        internal bool IsSetPmtPid() => this.PmtPid.HasValue;

        /// <summary>
        /// Gets and sets the property PrivateMetadataPid. Packet Identifier (PID) of the private
        /// metadata stream in the transport stream.
        /// </summary>
        [AWSProperty(Min = 32, Max = 8182)]
        public int? PrivateMetadataPid { get; set; }

        /// <summary>
        /// Checks to see if the PrivateMetadataPid property is set.
        /// </summary>
        internal bool IsSetPrivateMetadataPid() => this.PrivateMetadataPid.HasValue;

        /// <summary>
        /// Gets and sets the property ProgramNumber. The value of the program number field in
        /// the Program Map Table.
        /// </summary>
        [AWSProperty(Min = 0, Max = 65535)]
        public int? ProgramNumber { get; set; }

        /// <summary>
        /// Checks to see if the ProgramNumber property is set.
        /// </summary>
        internal bool IsSetProgramNumber() => this.ProgramNumber.HasValue;

        /// <summary>
        /// Gets and sets the property PtsOffset. Manually specify the initial PTS offset, in
        /// seconds, when you set PTS offset to Seconds. Enter an integer from 0 to 3600. Leave
        /// blank to keep the default value 2.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3600)]
        public int? PtsOffset { get; set; }

        /// <summary>
        /// Checks to see if the PtsOffset property is set.
        /// </summary>
        internal bool IsSetPtsOffset() => this.PtsOffset.HasValue;

        /// <summary>
        /// Gets and sets the property PtsOffsetMode. Specify the initial presentation timestamp
        /// (PTS) offset for your transport stream output. To let MediaConvert automatically determine
        /// the initial PTS offset: Keep the default value, Auto. We recommend that you choose
        /// Auto for the widest player compatibility. The initial PTS will be at least two seconds
        /// and vary depending on your output's bitrate, HRD buffer size and HRD buffer initial
        /// fill percentage. To manually specify an initial PTS offset: Choose Seconds or Milliseconds.
        /// Then specify the number of seconds or milliseconds with PTS offset.
        /// </summary>
        public TsPtsOffset PtsOffsetMode { get; set; }

        /// <summary>
        /// Checks to see if the PtsOffsetMode property is set.
        /// </summary>
        internal bool IsSetPtsOffsetMode() => this.PtsOffsetMode != null;

        /// <summary>
        /// Gets and sets the property Scte35Pid. Packet Identifier (PID) of the SCTE-35 stream
        /// in the transport stream.
        /// </summary>
        [AWSProperty(Min = 32, Max = 8182)]
        public int? Scte35Pid { get; set; }

        /// <summary>
        /// Checks to see if the Scte35Pid property is set.
        /// </summary>
        internal bool IsSetScte35Pid() => this.Scte35Pid.HasValue;

        /// <summary>
        /// Gets and sets the property Scte35Source. For SCTE-35 markers from your input-- Choose
        /// Passthrough if you want SCTE-35 markers that appear in your input to also appear in
        /// this output. Choose None if you don't want SCTE-35 markers in this output. For SCTE-35
        /// markers from an ESAM XML document-- Choose None if you don't want manifest conditioning.
        /// Choose Passthrough and choose Ad markers if you do want manifest conditioning. In
        /// both cases, also provide the ESAM XML as a string in the setting Signal processing
        /// notification XML. For SCTE-35 markers from your input HLS manifest-- Choose Manifest
        /// cues to pass through CUE markers in your HLS manifest as segment boundaries and SCTE-35
        /// markers in this output at each EXT-X-CUE-OUT splice point in the input manifest.
        /// </summary>
        public M3u8Scte35Source Scte35Source { get; set; }

        /// <summary>
        /// Checks to see if the Scte35Source property is set.
        /// </summary>
        internal bool IsSetScte35Source() => this.Scte35Source != null;

        /// <summary>
        /// Gets and sets the property TimedMetadata. Set ID3 metadata to Passthrough to include
        /// ID3 metadata in this output. This includes ID3 metadata from the following features:
        /// ID3 timestamp period, and Custom ID3 metadata inserter. To exclude this ID3 metadata
        /// in this output: set ID3 metadata to None or leave blank.
        /// </summary>
        public TimedMetadata TimedMetadata { get; set; }

        /// <summary>
        /// Checks to see if the TimedMetadata property is set.
        /// </summary>
        internal bool IsSetTimedMetadata() => this.TimedMetadata != null;

        /// <summary>
        /// Gets and sets the property TimedMetadataPid. Packet Identifier (PID) of the ID3 metadata
        /// stream in the transport stream.
        /// </summary>
        [AWSProperty(Min = 32, Max = 8182)]
        public int? TimedMetadataPid { get; set; }

        /// <summary>
        /// Checks to see if the TimedMetadataPid property is set.
        /// </summary>
        internal bool IsSetTimedMetadataPid() => this.TimedMetadataPid.HasValue;

        /// <summary>
        /// Gets and sets the property TransportStreamId. The value of the transport stream ID
        /// field in the Program Map Table.
        /// </summary>
        [AWSProperty(Min = 0, Max = 65535)]
        public int? TransportStreamId { get; set; }

        /// <summary>
        /// Checks to see if the TransportStreamId property is set.
        /// </summary>
        internal bool IsSetTransportStreamId() => this.TransportStreamId.HasValue;

        /// <summary>
        /// Gets and sets the property VideoPid. Packet Identifier (PID) of the elementary video
        /// stream in the transport stream.
        /// </summary>
        [AWSProperty(Min = 32, Max = 8182)]
        public int? VideoPid { get; set; }

        /// <summary>
        /// Checks to see if the VideoPid property is set.
        /// </summary>
        internal bool IsSetVideoPid() => this.VideoPid.HasValue;
    }
}
