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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings related to your DASH output package. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/outputs-file-ABR.html.
    /// When you work directly in your JSON job specification, include this object and any
    /// required children when you set Type, under OutputGroupSettings, to DASH_ISO_GROUP_SETTINGS.
    /// </summary>
    public partial class DashIsoGroupSettings
    {
        private List<DashAdditionalManifest> _additionalManifests = new List<DashAdditionalManifest>();
        private DashIsoGroupAudioChannelConfigSchemeIdUri _audioChannelConfigSchemeIdUri;
        private string _baseUrl;
        private string _destination;
        private DestinationSettings _destinationSettings;
        private DashIsoEncryptionSettings _encryption;
        private int? _fragmentLength;
        private DashIsoHbbtvCompliance _hbbtvCompliance;
        private DashIsoImageBasedTrickPlay _imageBasedTrickPlay;
        private DashIsoImageBasedTrickPlaySettings _imageBasedTrickPlaySettings;
        private int? _minBufferTime;
        private double? _minFinalSegmentLength;
        private DashIsoMpdManifestBandwidthType _mpdManifestBandwidthType;
        private DashIsoMpdProfile _mpdProfile;
        private DashIsoPtsOffsetHandlingForBFrames _ptsOffsetHandlingForBFrames;
        private DashIsoSegmentControl _segmentControl;
        private int? _segmentLength;
        private DashIsoSegmentLengthControl _segmentLengthControl;
        private DashIsoVideoCompositionOffsets _videoCompositionOffsets;
        private DashIsoWriteSegmentTimelineInRepresentation _writeSegmentTimelineInRepresentation;

        /// <summary>
        /// Gets and sets the property AdditionalManifests. By default, the service creates one
        /// .mpd DASH manifest for each DASH ISO output group in your job. This default manifest
        /// references every output in the output group. To create additional DASH manifests that
        /// reference a subset of the outputs in the output group, specify a list of them here.
        /// </summary>
        public List<DashAdditionalManifest> AdditionalManifests
        {
            get { return this._additionalManifests; }
            set { this._additionalManifests = value; }
        }

        // Check to see if AdditionalManifests property is set
        internal bool IsSetAdditionalManifests()
        {
            return this._additionalManifests != null && this._additionalManifests.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AudioChannelConfigSchemeIdUri. Use this setting only when
        /// your audio codec is a Dolby one (AC3, EAC3, or Atmos) and your downstream workflow
        /// requires that your DASH manifest use the Dolby channel configuration tag, rather than
        /// the MPEG one. For example, you might need to use this to make dynamic ad insertion
        /// work. Specify which audio channel configuration scheme ID URI MediaConvert writes
        /// in your DASH manifest. Keep the default value, MPEG channel configuration (MPEG_CHANNEL_CONFIGURATION),
        /// to have MediaConvert write this: urn:mpeg:mpegB:cicp:ChannelConfiguration. Choose
        /// Dolby channel configuration (DOLBY_CHANNEL_CONFIGURATION) to have MediaConvert write
        /// this instead: tag:dolby.com,2014:dash:audio_channel_configuration:2011.
        /// </summary>
        public DashIsoGroupAudioChannelConfigSchemeIdUri AudioChannelConfigSchemeIdUri
        {
            get { return this._audioChannelConfigSchemeIdUri; }
            set { this._audioChannelConfigSchemeIdUri = value; }
        }

        // Check to see if AudioChannelConfigSchemeIdUri property is set
        internal bool IsSetAudioChannelConfigSchemeIdUri()
        {
            return this._audioChannelConfigSchemeIdUri != null;
        }

        /// <summary>
        /// Gets and sets the property BaseUrl. A partial URI prefix that will be put in the manifest
        /// (.mpd) file at the top level BaseURL element. Can be used if streams are delivered
        /// from a different URL than the manifest file.
        /// </summary>
        public string BaseUrl
        {
            get { return this._baseUrl; }
            set { this._baseUrl = value; }
        }

        // Check to see if BaseUrl property is set
        internal bool IsSetBaseUrl()
        {
            return this._baseUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Destination. Use Destination (Destination) to specify the
        /// S3 output location and the output filename base. Destination accepts format identifiers.
        /// If you do not specify the base filename in the URI, the service will use the filename
        /// of the input file. If your job has multiple inputs, the service uses the filename
        /// of the first input file.
        /// </summary>
        public string Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationSettings. Settings associated with the destination.
        /// Will vary based on the type of destination
        /// </summary>
        public DestinationSettings DestinationSettings
        {
            get { return this._destinationSettings; }
            set { this._destinationSettings = value; }
        }

        // Check to see if DestinationSettings property is set
        internal bool IsSetDestinationSettings()
        {
            return this._destinationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Encryption. DRM settings.
        /// </summary>
        public DashIsoEncryptionSettings Encryption
        {
            get { return this._encryption; }
            set { this._encryption = value; }
        }

        // Check to see if Encryption property is set
        internal bool IsSetEncryption()
        {
            return this._encryption != null;
        }

        /// <summary>
        /// Gets and sets the property FragmentLength. Length of fragments to generate (in seconds).
        /// Fragment length must be compatible with GOP size and Framerate. Note that fragments
        /// will end on the next keyframe after this number of seconds, so actual fragment length
        /// may be longer. When Emit Single File is checked, the fragmentation is internal to
        /// a single output file and it does not cause the creation of many output files as in
        /// other output types.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int FragmentLength
        {
            get { return this._fragmentLength.GetValueOrDefault(); }
            set { this._fragmentLength = value; }
        }

        // Check to see if FragmentLength property is set
        internal bool IsSetFragmentLength()
        {
            return this._fragmentLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HbbtvCompliance. Supports HbbTV specification as indicated
        /// </summary>
        public DashIsoHbbtvCompliance HbbtvCompliance
        {
            get { return this._hbbtvCompliance; }
            set { this._hbbtvCompliance = value; }
        }

        // Check to see if HbbtvCompliance property is set
        internal bool IsSetHbbtvCompliance()
        {
            return this._hbbtvCompliance != null;
        }

        /// <summary>
        /// Gets and sets the property ImageBasedTrickPlay. Specify whether MediaConvert generates
        /// images for trick play. Keep the default value, None (NONE), to not generate any images.
        /// Choose Thumbnail (THUMBNAIL) to generate tiled thumbnails. Choose Thumbnail and full
        /// frame (THUMBNAIL_AND_FULLFRAME) to generate tiled thumbnails and full-resolution images
        /// of single frames. MediaConvert adds an entry in the .mpd manifest for each set of
        /// images that you generate. A common application for these images is Roku trick mode.
        /// The thumbnails and full-frame images that MediaConvert creates with this feature are
        /// compatible with this Roku specification: https://developer.roku.com/docs/developer-program/media-playback/trick-mode/hls-and-dash.md
        /// </summary>
        public DashIsoImageBasedTrickPlay ImageBasedTrickPlay
        {
            get { return this._imageBasedTrickPlay; }
            set { this._imageBasedTrickPlay = value; }
        }

        // Check to see if ImageBasedTrickPlay property is set
        internal bool IsSetImageBasedTrickPlay()
        {
            return this._imageBasedTrickPlay != null;
        }

        /// <summary>
        /// Gets and sets the property ImageBasedTrickPlaySettings. Tile and thumbnail settings
        /// applicable when imageBasedTrickPlay is ADVANCED
        /// </summary>
        public DashIsoImageBasedTrickPlaySettings ImageBasedTrickPlaySettings
        {
            get { return this._imageBasedTrickPlaySettings; }
            set { this._imageBasedTrickPlaySettings = value; }
        }

        // Check to see if ImageBasedTrickPlaySettings property is set
        internal bool IsSetImageBasedTrickPlaySettings()
        {
            return this._imageBasedTrickPlaySettings != null;
        }

        /// <summary>
        /// Gets and sets the property MinBufferTime. Minimum time of initially buffered media
        /// that is needed to ensure smooth playout.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int MinBufferTime
        {
            get { return this._minBufferTime.GetValueOrDefault(); }
            set { this._minBufferTime = value; }
        }

        // Check to see if MinBufferTime property is set
        internal bool IsSetMinBufferTime()
        {
            return this._minBufferTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinFinalSegmentLength. Keep this setting at the default
        /// value of 0, unless you are troubleshooting a problem with how devices play back the
        /// end of your video asset. If you know that player devices are hanging on the final
        /// segment of your video because the length of your final segment is too short, use this
        /// setting to specify a minimum final segment length, in seconds. Choose a value that
        /// is greater than or equal to 1 and less than your segment length. When you specify
        /// a value for this setting, the encoder will combine any final segment that is shorter
        /// than the length that you specify with the previous segment. For example, your segment
        /// length is 3 seconds and your final segment is .5 seconds without a minimum final segment
        /// length; when you set the minimum final segment length to 1, your final segment is
        /// 3.5 seconds.
        /// </summary>
        public double MinFinalSegmentLength
        {
            get { return this._minFinalSegmentLength.GetValueOrDefault(); }
            set { this._minFinalSegmentLength = value; }
        }

        // Check to see if MinFinalSegmentLength property is set
        internal bool IsSetMinFinalSegmentLength()
        {
            return this._minFinalSegmentLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MpdManifestBandwidthType. Specify how the value for bandwidth
        /// is determined for each video Representation in your output MPD manifest. We recommend
        /// that you choose a MPD manifest bandwidth type that is compatible with your downstream
        /// player configuration. Max: Use the same value that you specify for Max bitrate in
        /// the video output, in bits per second. Average: Use the calculated average bitrate
        /// of the encoded video output, in bits per second.
        /// </summary>
        public DashIsoMpdManifestBandwidthType MpdManifestBandwidthType
        {
            get { return this._mpdManifestBandwidthType; }
            set { this._mpdManifestBandwidthType = value; }
        }

        // Check to see if MpdManifestBandwidthType property is set
        internal bool IsSetMpdManifestBandwidthType()
        {
            return this._mpdManifestBandwidthType != null;
        }

        /// <summary>
        /// Gets and sets the property MpdProfile. Specify whether your DASH profile is on-demand
        /// or main. When you choose Main profile (MAIN_PROFILE), the service signals  urn:mpeg:dash:profile:isoff-main:2011
        /// in your .mpd DASH manifest. When you choose On-demand (ON_DEMAND_PROFILE), the service
        /// signals urn:mpeg:dash:profile:isoff-on-demand:2011 in your .mpd. When you choose On-demand,
        /// you must also set the output group setting Segment control (SegmentControl) to Single
        /// file (SINGLE_FILE).
        /// </summary>
        public DashIsoMpdProfile MpdProfile
        {
            get { return this._mpdProfile; }
            set { this._mpdProfile = value; }
        }

        // Check to see if MpdProfile property is set
        internal bool IsSetMpdProfile()
        {
            return this._mpdProfile != null;
        }

        /// <summary>
        /// Gets and sets the property PtsOffsetHandlingForBFrames. Use this setting only when
        /// your output video stream has B-frames, which causes the initial presentation time
        /// stamp (PTS) to be offset from the initial decode time stamp (DTS). Specify how MediaConvert
        /// handles PTS when writing time stamps in output DASH manifests. Choose Match initial
        /// PTS (MATCH_INITIAL_PTS) when you want MediaConvert to use the initial PTS as the first
        /// time stamp in the manifest. Choose Zero-based (ZERO_BASED) to have MediaConvert ignore
        /// the initial PTS in the video stream and instead write the initial time stamp as zero
        /// in the manifest. For outputs that don't have B-frames, the time stamps in your DASH
        /// manifests start at zero regardless of your choice here.
        /// </summary>
        public DashIsoPtsOffsetHandlingForBFrames PtsOffsetHandlingForBFrames
        {
            get { return this._ptsOffsetHandlingForBFrames; }
            set { this._ptsOffsetHandlingForBFrames = value; }
        }

        // Check to see if PtsOffsetHandlingForBFrames property is set
        internal bool IsSetPtsOffsetHandlingForBFrames()
        {
            return this._ptsOffsetHandlingForBFrames != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentControl. When set to SINGLE_FILE, a single output
        /// file is generated, which is internally segmented using the Fragment Length and Segment
        /// Length. When set to SEGMENTED_FILES, separate segment files will be created.
        /// </summary>
        public DashIsoSegmentControl SegmentControl
        {
            get { return this._segmentControl; }
            set { this._segmentControl = value; }
        }

        // Check to see if SegmentControl property is set
        internal bool IsSetSegmentControl()
        {
            return this._segmentControl != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentLength. Specify the length, in whole seconds, of
        /// each segment. When you don't specify a value, MediaConvert defaults to 30. Related
        /// settings: Use Segment length control (SegmentLengthControl) to specify whether the
        /// encoder enforces this value strictly. Use Segment control (DashIsoSegmentControl)
        /// to specify whether MediaConvert creates separate segment files or one content file
        /// that has metadata to mark the segment boundaries.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int SegmentLength
        {
            get { return this._segmentLength.GetValueOrDefault(); }
            set { this._segmentLength = value; }
        }

        // Check to see if SegmentLength property is set
        internal bool IsSetSegmentLength()
        {
            return this._segmentLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SegmentLengthControl. Specify how you want MediaConvert
        /// to determine the segment length. Choose Exact (EXACT) to have the encoder use the
        /// exact length that you specify with the setting Segment length (SegmentLength). This
        /// might result in extra I-frames. Choose Multiple of GOP (GOP_MULTIPLE) to have the
        /// encoder round up the segment lengths to match the next GOP boundary.
        /// </summary>
        public DashIsoSegmentLengthControl SegmentLengthControl
        {
            get { return this._segmentLengthControl; }
            set { this._segmentLengthControl = value; }
        }

        // Check to see if SegmentLengthControl property is set
        internal bool IsSetSegmentLengthControl()
        {
            return this._segmentLengthControl != null;
        }

        /// <summary>
        /// Gets and sets the property VideoCompositionOffsets. Specify the video sample composition
        /// time offset mode in the output fMP4 TRUN box. For wider player compatibility, set
        /// Video composition offsets to Unsigned or leave blank. The earliest presentation time
        /// may be greater than zero, and sample composition time offsets will increment using
        /// unsigned integers. For strict fMP4 video and audio timing, set Video composition offsets
        /// to Signed. The earliest presentation time will be equal to zero, and sample composition
        /// time offsets will increment using signed integers.
        /// </summary>
        public DashIsoVideoCompositionOffsets VideoCompositionOffsets
        {
            get { return this._videoCompositionOffsets; }
            set { this._videoCompositionOffsets = value; }
        }

        // Check to see if VideoCompositionOffsets property is set
        internal bool IsSetVideoCompositionOffsets()
        {
            return this._videoCompositionOffsets != null;
        }

        /// <summary>
        /// Gets and sets the property WriteSegmentTimelineInRepresentation. If you get an HTTP
        /// error in the 400 range when you play back your DASH output, enable this setting and
        /// run your transcoding job again. When you enable this setting, the service writes precise
        /// segment durations in the DASH manifest. The segment duration information appears inside
        /// the SegmentTimeline element, inside SegmentTemplate at the Representation level. When
        /// you don't enable this setting, the service writes approximate segment durations in
        /// your DASH manifest.
        /// </summary>
        public DashIsoWriteSegmentTimelineInRepresentation WriteSegmentTimelineInRepresentation
        {
            get { return this._writeSegmentTimelineInRepresentation; }
            set { this._writeSegmentTimelineInRepresentation = value; }
        }

        // Check to see if WriteSegmentTimelineInRepresentation property is set
        internal bool IsSetWriteSegmentTimelineInRepresentation()
        {
            return this._writeSegmentTimelineInRepresentation != null;
        }

    }
}