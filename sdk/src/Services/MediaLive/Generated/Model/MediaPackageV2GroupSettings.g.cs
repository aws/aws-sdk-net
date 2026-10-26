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
    /// Media Package V2 Group Settings
    /// </summary>
    public partial class MediaPackageV2GroupSettings
    {
        /// <summary>
        /// Gets and sets the property AdditionalDestinations. Optional an array of additional
        /// destinational HTTP destinations for the OutputGroup outputs
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MediaPackageAdditionalDestinations> AdditionalDestinations { get; set; } = AWSConfigs.InitializeCollections ? new List<MediaPackageAdditionalDestinations>() : null;

        /// <summary>
        /// Checks to see if the AdditionalDestinations property is set.
        /// </summary>
        internal bool IsSetAdditionalDestinations() => this.AdditionalDestinations != null && (this.AdditionalDestinations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CaptionLanguageMappings. Mapping of up to 4 caption channels
        /// to caption languages.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CaptionLanguageMapping> CaptionLanguageMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<CaptionLanguageMapping>() : null;

        /// <summary>
        /// Checks to see if the CaptionLanguageMappings property is set.
        /// </summary>
        internal bool IsSetCaptionLanguageMappings() => this.CaptionLanguageMappings != null && (this.CaptionLanguageMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Id3Behavior. Set to ENABLED to enable ID3 metadata insertion.
        /// To include metadata, you configure other parameters in the output group, or you add
        /// an ID3 action to the channel schedule.
        /// </summary>
        public CmafId3Behavior Id3Behavior { get; set; }

        /// <summary>
        /// Checks to see if the Id3Behavior property is set.
        /// </summary>
        internal bool IsSetId3Behavior() => this.Id3Behavior != null;

        /// <summary>
        /// Gets and sets the property KlvBehavior. If set to passthrough, passes any KLV data
        /// from the input source to this output.
        /// </summary>
        public CmafKLVBehavior KlvBehavior { get; set; }

        /// <summary>
        /// Checks to see if the KlvBehavior property is set.
        /// </summary>
        internal bool IsSetKlvBehavior() => this.KlvBehavior != null;

        /// <summary>
        /// Gets and sets the property NielsenId3Behavior. If set to passthrough, Nielsen inaudible
        /// tones for media tracking will be detected in the input audio and an equivalent ID3
        /// tag will be inserted in the output.
        /// </summary>
        public CmafNielsenId3Behavior NielsenId3Behavior { get; set; }

        /// <summary>
        /// Checks to see if the NielsenId3Behavior property is set.
        /// </summary>
        internal bool IsSetNielsenId3Behavior() => this.NielsenId3Behavior != null;

        /// <summary>
        /// Gets and sets the property Scte35Type. SCTE-35 insertion type. Option "none" indicates
        /// that a SCTE-35 marker will not be inserted, nor will an IDR be inserted at the SCTE-35
        /// cue point, nor will the segment be segmented. Option "scte35WithoutIdr" indicates
        /// that a SCTE-35 marker will be inserted to indicate the cue point, but MediaLive will
        /// not insert an IDR on that frame nor will it introduce a new segment boundary there
        /// if it wasn't already going to be one (this option is required for use with downstream
        /// multiview bitstream stitching workflows). Option "scte35WithoutSegmentation" indicates
        /// that a SCTE-35 marker will be inserted to indicate the cue point, and an IDR will
        /// be inserted on that frame so that a downstream re-packager might split the segment
        /// there, but MediaLive itself will not introduce a new segment boundary there.
        /// </summary>
        public Scte35Type Scte35Type { get; set; }

        /// <summary>
        /// Checks to see if the Scte35Type property is set.
        /// </summary>
        internal bool IsSetScte35Type() => this.Scte35Type != null;

        /// <summary>
        /// Gets and sets the property SegmentLength. The nominal duration of segments. The units
        /// are specified in SegmentLengthUnits. The segments will end on the next keyframe after
        /// the specified duration, so the actual segment length might be longer, and it might
        /// be a fraction of the units.
        /// </summary>
        public int? SegmentLength { get; set; }

        /// <summary>
        /// Checks to see if the SegmentLength property is set.
        /// </summary>
        internal bool IsSetSegmentLength() => this.SegmentLength.HasValue;

        /// <summary>
        /// Gets and sets the property SegmentLengthUnits. Time unit for segment length parameter.
        /// </summary>
        public CmafIngestSegmentLengthUnits SegmentLengthUnits { get; set; }

        /// <summary>
        /// Checks to see if the SegmentLengthUnits property is set.
        /// </summary>
        internal bool IsSetSegmentLengthUnits() => this.SegmentLengthUnits != null;

        /// <summary>
        /// Gets and sets the property TimedMetadataId3Frame. Set to none if you don't want to
        /// insert a timecode in the output. Otherwise choose the frame type for the timecode.
        /// </summary>
        public CmafTimedMetadataId3Frame TimedMetadataId3Frame { get; set; }

        /// <summary>
        /// Checks to see if the TimedMetadataId3Frame property is set.
        /// </summary>
        internal bool IsSetTimedMetadataId3Frame() => this.TimedMetadataId3Frame != null;

        /// <summary>
        /// Gets and sets the property TimedMetadataId3Period. If you set up to insert a timecode
        /// in the output, specify the frequency for the frame, in seconds.
        /// </summary>
        public int? TimedMetadataId3Period { get; set; }

        /// <summary>
        /// Checks to see if the TimedMetadataId3Period property is set.
        /// </summary>
        internal bool IsSetTimedMetadataId3Period() => this.TimedMetadataId3Period.HasValue;

        /// <summary>
        /// Gets and sets the property TimedMetadataPassthrough. Set to enabled to pass through
        /// ID3 metadata from the input sources.
        /// </summary>
        public CmafTimedMetadataPassthrough TimedMetadataPassthrough { get; set; }

        /// <summary>
        /// Checks to see if the TimedMetadataPassthrough property is set.
        /// </summary>
        internal bool IsSetTimedMetadataPassthrough() => this.TimedMetadataPassthrough != null;

        /// <summary>
        /// Gets and sets the property WatermarkingSettings. Specifies the type of watermarking
        /// technology to use.
        /// </summary>
        public MediaPackageV2WatermarkingSettings WatermarkingSettings { get; set; }

        /// <summary>
        /// Checks to see if the WatermarkingSettings property is set.
        /// </summary>
        internal bool IsSetWatermarkingSettings() => this.WatermarkingSettings != null;
    }
}
