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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings related to your HLS output package. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/outputs-file-ABR.html.
    /// </summary>
    public partial class HlsGroupSettings
    {
        private List<HlsAdditionalManifest> _additionalManifests = AWSConfigs.InitializeCollections ? new List<HlsAdditionalManifest>() : null;
        private List<string> _adMarkers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private HlsAudioOnlyHeader _audioOnlyHeader;
        private string _baseUrl;
        private List<HlsCaptionLanguageMapping> _captionLanguageMappings = AWSConfigs.InitializeCollections ? new List<HlsCaptionLanguageMapping>() : null;
        private HlsCaptionLanguageSetting _captionLanguageSetting;
        private HlsCaptionSegmentLengthControl _captionSegmentLengthControl;
        private HlsClientCache _clientCache;
        private HlsCodecSpecification _codecSpecification;
        private string _destination;
        private DestinationSettings _destinationSettings;
        private HlsDirectoryStructure _directoryStructure;
        private HlsEncryptionSettings _encryption;
        private HlsImageBasedTrickPlay _imageBasedTrickPlay;
        private HlsImageBasedTrickPlaySettings _imageBasedTrickPlaySettings;
        private HlsManifestCompression _manifestCompression;
        private HlsManifestDurationFormat _manifestDurationFormat;
        private double? _minFinalSegmentLength;
        private int? _minSegmentLength;
        private HlsOutputSelection _outputSelection;
        private HlsProgramDateTime _programDateTime;
        private int? _programDateTimePeriod;
        private HlsProgressiveWriteHlsManifest _progressiveWriteHlsManifest;
        private HlsSegmentControl _segmentControl;
        private int? _segmentLength;
        private HlsSegmentLengthControl _segmentLengthControl;
        private int? _segmentsPerSubdirectory;
        private HlsStreamInfResolution _streamInfResolution;
        private HlsTargetDurationCompatibilityMode _targetDurationCompatibilityMode;
        private HlsTimedMetadataId3Frame _timedMetadataId3Frame;
        private int? _timedMetadataId3Period;
        private int? _timestampDeltaMilliseconds;

        /// <summary>
        /// Gets and sets the property AdditionalManifests. By default, the service creates one
        /// top-level .m3u8 HLS manifest for each HLS output group in your job. This default manifest
        /// references every output in the output group. To create additional top-level manifests
        /// that reference a subset of the outputs in the output group, specify a list of them
        /// here.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HlsAdditionalManifest> AdditionalManifests
        {
            get { return this._additionalManifests; }
            set { this._additionalManifests = value; }
        }

        // Check to see if AdditionalManifests property is set
        internal bool IsSetAdditionalManifests()
        {
            return this._additionalManifests != null && (this._additionalManifests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AdMarkers. Choose one or more ad marker types to decorate
        /// your Apple HLS manifest. This setting does not determine whether SCTE-35 markers appear
        /// in the outputs themselves.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdMarkers
        {
            get { return this._adMarkers; }
            set { this._adMarkers = value; }
        }

        // Check to see if AdMarkers property is set
        internal bool IsSetAdMarkers()
        {
            return this._adMarkers != null && (this._adMarkers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AudioOnlyHeader. Ignore this setting unless you are using
        /// FairPlay DRM with Verimatrix and you encounter playback issues. Keep the default value,
        /// Include, to output audio-only headers. Choose Exclude to remove the audio-only headers
        /// from your audio segments.
        /// </summary>
        public HlsAudioOnlyHeader AudioOnlyHeader
        {
            get { return this._audioOnlyHeader; }
            set { this._audioOnlyHeader = value; }
        }

        // Check to see if AudioOnlyHeader property is set
        internal bool IsSetAudioOnlyHeader()
        {
            return this._audioOnlyHeader != null;
        }

        /// <summary>
        /// Gets and sets the property BaseUrl. A partial URI prefix that will be prepended to
        /// each output in the media .m3u8 file. Can be used if base manifest is delivered from
        /// a different URL than the main .m3u8 file.
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
        /// Gets and sets the property CaptionLanguageMappings. Language to be used on Caption
        /// outputs
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HlsCaptionLanguageMapping> CaptionLanguageMappings
        {
            get { return this._captionLanguageMappings; }
            set { this._captionLanguageMappings = value; }
        }

        // Check to see if CaptionLanguageMappings property is set
        internal bool IsSetCaptionLanguageMappings()
        {
            return this._captionLanguageMappings != null && (this._captionLanguageMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CaptionLanguageSetting. Applies only to 608 Embedded output
        /// captions. Insert: Include CLOSED-CAPTIONS lines in the manifest. Specify at least
        /// one language in the CC1 Language Code field. One CLOSED-CAPTION line is added for
        /// each Language Code you specify. Make sure to specify the languages in the order in
        /// which they appear in the original source (if the source is embedded format) or the
        /// order of the caption selectors (if the source is other than embedded). Otherwise,
        /// languages in the manifest will not match up properly with the output captions. None:
        /// Include CLOSED-CAPTIONS=NONE line in the manifest. Omit: Omit any CLOSED-CAPTIONS
        /// line from the manifest.
        /// </summary>
        public HlsCaptionLanguageSetting CaptionLanguageSetting
        {
            get { return this._captionLanguageSetting; }
            set { this._captionLanguageSetting = value; }
        }

        // Check to see if CaptionLanguageSetting property is set
        internal bool IsSetCaptionLanguageSetting()
        {
            return this._captionLanguageSetting != null;
        }

        /// <summary>
        /// Gets and sets the property CaptionSegmentLengthControl. Set Caption segment length
        /// control to Match video to create caption segments that align with the video segments
        /// from the first video output in this output group. For example, if the video segments
        /// are 2 seconds long, your WebVTT segments will also be 2 seconds long. Keep the default
        /// setting, Large segments to create caption segments that are 300 seconds long.
        /// </summary>
        public HlsCaptionSegmentLengthControl CaptionSegmentLengthControl
        {
            get { return this._captionSegmentLengthControl; }
            set { this._captionSegmentLengthControl = value; }
        }

        // Check to see if CaptionSegmentLengthControl property is set
        internal bool IsSetCaptionSegmentLengthControl()
        {
            return this._captionSegmentLengthControl != null;
        }

        /// <summary>
        /// Gets and sets the property ClientCache. Disable this setting only when your workflow
        /// requires the #EXT-X-ALLOW-CACHE:no tag. Otherwise, keep the default value Enabled
        /// and control caching in your video distribution set up. For example, use the Cache-Control
        /// http header.
        /// </summary>
        public HlsClientCache ClientCache
        {
            get { return this._clientCache; }
            set { this._clientCache = value; }
        }

        // Check to see if ClientCache property is set
        internal bool IsSetClientCache()
        {
            return this._clientCache != null;
        }

        /// <summary>
        /// Gets and sets the property CodecSpecification. Specification to use (RFC-6381 or the
        /// default RFC-4281) during m3u8 playlist generation.
        /// </summary>
        public HlsCodecSpecification CodecSpecification
        {
            get { return this._codecSpecification; }
            set { this._codecSpecification = value; }
        }

        // Check to see if CodecSpecification property is set
        internal bool IsSetCodecSpecification()
        {
            return this._codecSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property Destination. Use Destination to specify the S3 output location
        /// and the output filename base. Destination accepts format identifiers. If you do not
        /// specify the base filename in the URI, the service will use the filename of the input
        /// file. If your job has multiple inputs, the service uses the filename of the first
        /// input file.
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
        /// Gets and sets the property DirectoryStructure. Indicates whether segments should be
        /// placed in subdirectories.
        /// </summary>
        public HlsDirectoryStructure DirectoryStructure
        {
            get { return this._directoryStructure; }
            set { this._directoryStructure = value; }
        }

        // Check to see if DirectoryStructure property is set
        internal bool IsSetDirectoryStructure()
        {
            return this._directoryStructure != null;
        }

        /// <summary>
        /// Gets and sets the property Encryption. DRM settings.
        /// </summary>
        public HlsEncryptionSettings Encryption
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
        /// Gets and sets the property ImageBasedTrickPlay. Specify whether MediaConvert generates
        /// images for trick play. Keep the default value, None, to not generate any images. Choose
        /// Thumbnail to generate tiled thumbnails. Choose Thumbnail and full frame to generate
        /// tiled thumbnails and full-resolution images of single frames. MediaConvert creates
        /// a child manifest for each set of images that you generate and adds corresponding entries
        /// to the parent manifest. A common application for these images is Roku trick mode.
        /// The thumbnails and full-frame images that MediaConvert creates with this feature are
        /// compatible with this Roku specification: https://developer.roku.com/docs/developer-program/media-playback/trick-mode/hls-and-dash.md
        /// </summary>
        public HlsImageBasedTrickPlay ImageBasedTrickPlay
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
        public HlsImageBasedTrickPlaySettings ImageBasedTrickPlaySettings
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
        /// Gets and sets the property ManifestCompression. When set to GZIP, compresses HLS playlist.
        /// </summary>
        public HlsManifestCompression ManifestCompression
        {
            get { return this._manifestCompression; }
            set { this._manifestCompression = value; }
        }

        // Check to see if ManifestCompression property is set
        internal bool IsSetManifestCompression()
        {
            return this._manifestCompression != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestDurationFormat. Indicates whether the output manifest
        /// should use floating point values for segment duration.
        /// </summary>
        public HlsManifestDurationFormat ManifestDurationFormat
        {
            get { return this._manifestDurationFormat; }
            set { this._manifestDurationFormat = value; }
        }

        // Check to see if ManifestDurationFormat property is set
        internal bool IsSetManifestDurationFormat()
        {
            return this._manifestDurationFormat != null;
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
        public double? MinFinalSegmentLength
        {
            get { return this._minFinalSegmentLength; }
            set { this._minFinalSegmentLength = value; }
        }

        // Check to see if MinFinalSegmentLength property is set
        internal bool IsSetMinFinalSegmentLength()
        {
            return this._minFinalSegmentLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinSegmentLength. When set, Minimum Segment Size is enforced
        /// by looking ahead and back within the specified range for a nearby avail and extending
        /// the segment size if needed.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? MinSegmentLength
        {
            get { return this._minSegmentLength; }
            set { this._minSegmentLength = value; }
        }

        // Check to see if MinSegmentLength property is set
        internal bool IsSetMinSegmentLength()
        {
            return this._minSegmentLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputSelection. Indicates whether the .m3u8 manifest file
        /// should be generated for this HLS output group.
        /// </summary>
        public HlsOutputSelection OutputSelection
        {
            get { return this._outputSelection; }
            set { this._outputSelection = value; }
        }

        // Check to see if OutputSelection property is set
        internal bool IsSetOutputSelection()
        {
            return this._outputSelection != null;
        }

        /// <summary>
        /// Gets and sets the property ProgramDateTime. Includes or excludes EXT-X-PROGRAM-DATE-TIME
        /// tag in .m3u8 manifest files. The value is calculated as follows: either the program
        /// date and time are initialized using the input timecode source, or the time is initialized
        /// using the input timecode source and the date is initialized using the timestamp_offset.
        /// </summary>
        public HlsProgramDateTime ProgramDateTime
        {
            get { return this._programDateTime; }
            set { this._programDateTime = value; }
        }

        // Check to see if ProgramDateTime property is set
        internal bool IsSetProgramDateTime()
        {
            return this._programDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property ProgramDateTimePeriod. Period of insertion of EXT-X-PROGRAM-DATE-TIME
        /// entry, in seconds.
        /// </summary>
        [AWSProperty(Min=0, Max=3600)]
        public int? ProgramDateTimePeriod
        {
            get { return this._programDateTimePeriod; }
            set { this._programDateTimePeriod = value; }
        }

        // Check to see if ProgramDateTimePeriod property is set
        internal bool IsSetProgramDateTimePeriod()
        {
            return this._programDateTimePeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProgressiveWriteHlsManifest. Specify whether MediaConvert
        /// generates HLS manifests while your job is running or when your job is complete. To
        /// generate HLS manifests while your job is running: Choose Enabled. Use if you want
        /// to play back your content as soon as it's available. MediaConvert writes the parent
        /// and child manifests after the first three media segments are written to your destination
        /// S3 bucket. It then writes new updated manifests after each additional segment is written.
        /// The parent manifest includes the latest BANDWIDTH and AVERAGE-BANDWIDTH attributes,
        /// and child manifests include the latest available media segment. When your job completes,
        /// the final child playlists include an EXT-X-ENDLIST tag. To generate HLS manifests
        /// only when your job completes: Choose Disabled.
        /// </summary>
        public HlsProgressiveWriteHlsManifest ProgressiveWriteHlsManifest
        {
            get { return this._progressiveWriteHlsManifest; }
            set { this._progressiveWriteHlsManifest = value; }
        }

        // Check to see if ProgressiveWriteHlsManifest property is set
        internal bool IsSetProgressiveWriteHlsManifest()
        {
            return this._progressiveWriteHlsManifest != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentControl. When set to SINGLE_FILE, emits program
        /// as a single media resource (.ts) file, uses #EXT-X-BYTERANGE tags to index segment
        /// for playback.
        /// </summary>
        public HlsSegmentControl SegmentControl
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
        /// each segment. When you don't specify a value, MediaConvert defaults to 10. Related
        /// settings: Use Segment length control to specify whether the encoder enforces this
        /// value strictly. Use Segment control to specify whether MediaConvert creates separate
        /// segment files or one content file that has metadata to mark the segment boundaries.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int? SegmentLength
        {
            get { return this._segmentLength; }
            set { this._segmentLength = value; }
        }

        // Check to see if SegmentLength property is set
        internal bool IsSetSegmentLength()
        {
            return this._segmentLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SegmentLengthControl. Specify how you want MediaConvert
        /// to determine segment lengths in this output group. To use the exact value that you
        /// specify under Segment length: Choose Exact. Note that this might result in additional
        /// I-frames in the output GOP. To create segment lengths that are a multiple of the GOP:
        /// Choose Multiple of GOP. MediaConvert will round up the segment lengths to match the
        /// next GOP boundary. To have MediaConvert automatically determine a segment duration
        /// that is a multiple of both the audio packets and the frame rates: Choose Match. When
        /// you do, also specify a target segment duration under Segment length. This is useful
        /// for some ad-insertion or segment replacement workflows. Note that Match has the following
        /// requirements: - Output containers: Include at least one video output and at least
        /// one audio output. Audio-only outputs are not supported. - Output frame rate: Follow
        /// source is not supported. - Multiple output frame rates: When you specify multiple
        /// outputs, we recommend they share a similar frame rate (as in X/3, X/2, X, or 2X).
        /// For example: 5, 15, 30 and 60. Or: 25 and 50. (Outputs must share an integer multiple.)
        /// - Output audio codec: Specify Advanced Audio Coding (AAC). - Output sample rate: Choose
        /// 48kHz.
        /// </summary>
        public HlsSegmentLengthControl SegmentLengthControl
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
        /// Gets and sets the property SegmentsPerSubdirectory. Specify the number of segments
        /// to write to a subdirectory before starting a new one. You must also set Directory
        /// structure to Subdirectory per stream for this setting to have an effect.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int? SegmentsPerSubdirectory
        {
            get { return this._segmentsPerSubdirectory; }
            set { this._segmentsPerSubdirectory = value; }
        }

        // Check to see if SegmentsPerSubdirectory property is set
        internal bool IsSetSegmentsPerSubdirectory()
        {
            return this._segmentsPerSubdirectory.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamInfResolution. Include or exclude RESOLUTION attribute
        /// for video in EXT-X-STREAM-INF tag of variant manifest.
        /// </summary>
        public HlsStreamInfResolution StreamInfResolution
        {
            get { return this._streamInfResolution; }
            set { this._streamInfResolution = value; }
        }

        // Check to see if StreamInfResolution property is set
        internal bool IsSetStreamInfResolution()
        {
            return this._streamInfResolution != null;
        }

        /// <summary>
        /// Gets and sets the property TargetDurationCompatibilityMode. When set to LEGACY, the
        /// segment target duration is always rounded up to the nearest integer value above its
        /// current value in seconds. When set to SPEC\\_COMPLIANT, the segment target duration
        /// is rounded up to the nearest integer value if fraction seconds are greater than or
        /// equal to 0.5 (>= 0.5) and rounded down if less than 0.5 (< 0.5). You may need to use
        /// LEGACY if your client needs to ensure that the target duration is always longer than
        /// the actual duration of the segment. Some older players may experience interrupted
        /// playback when the actual duration of a track in a segment is longer than the target
        /// duration.
        /// </summary>
        public HlsTargetDurationCompatibilityMode TargetDurationCompatibilityMode
        {
            get { return this._targetDurationCompatibilityMode; }
            set { this._targetDurationCompatibilityMode = value; }
        }

        // Check to see if TargetDurationCompatibilityMode property is set
        internal bool IsSetTargetDurationCompatibilityMode()
        {
            return this._targetDurationCompatibilityMode != null;
        }

        /// <summary>
        /// Gets and sets the property TimedMetadataId3Frame. Specify the type of the ID3 frame
        /// to use for ID3 timestamps in your output. To include ID3 timestamps: Specify PRIV
        /// or TDRL and set ID3 metadata to Passthrough. To exclude ID3 timestamps: Set ID3 timestamp
        /// frame type to None.
        /// </summary>
        public HlsTimedMetadataId3Frame TimedMetadataId3Frame
        {
            get { return this._timedMetadataId3Frame; }
            set { this._timedMetadataId3Frame = value; }
        }

        // Check to see if TimedMetadataId3Frame property is set
        internal bool IsSetTimedMetadataId3Frame()
        {
            return this._timedMetadataId3Frame != null;
        }

        /// <summary>
        /// Gets and sets the property TimedMetadataId3Period. Specify the interval in seconds
        /// to write ID3 timestamps in your output. The first timestamp starts at the output timecode
        /// and date, and increases incrementally with each ID3 timestamp. To use the default
        /// interval of 10 seconds: Leave blank. To include this metadata in your output: Set
        /// ID3 timestamp frame type to PRIV or TDRL, and set ID3 metadata to Passthrough.
        /// </summary>
        [AWSProperty(Min=-2147483648, Max=2147483647)]
        public int? TimedMetadataId3Period
        {
            get { return this._timedMetadataId3Period; }
            set { this._timedMetadataId3Period = value; }
        }

        // Check to see if TimedMetadataId3Period property is set
        internal bool IsSetTimedMetadataId3Period()
        {
            return this._timedMetadataId3Period.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimestampDeltaMilliseconds. Provides an extra millisecond
        /// delta offset to fine tune the timestamps.
        /// </summary>
        [AWSProperty(Min=-2147483648, Max=2147483647)]
        public int? TimestampDeltaMilliseconds
        {
            get { return this._timestampDeltaMilliseconds; }
            set { this._timestampDeltaMilliseconds = value; }
        }

        // Check to see if TimestampDeltaMilliseconds property is set
        internal bool IsSetTimestampDeltaMilliseconds()
        {
            return this._timestampDeltaMilliseconds.HasValue; 
        }

    }
}