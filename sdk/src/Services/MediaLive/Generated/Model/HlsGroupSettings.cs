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
    /// Hls Group Settings
    /// </summary>
    public partial class HlsGroupSettings
    {
        private List<string> _adMarkers = new List<string>();
        private string _baseUrlContent;
        private string _baseUrlContent1;
        private string _baseUrlManifest;
        private string _baseUrlManifest1;
        private List<CaptionLanguageMapping> _captionLanguageMappings = new List<CaptionLanguageMapping>();
        private HlsCaptionLanguageSetting _captionLanguageSetting;
        private HlsClientCache _clientCache;
        private HlsCodecSpecification _codecSpecification;
        private string _constantIv;
        private OutputLocationRef _destination;
        private HlsDirectoryStructure _directoryStructure;
        private HlsDiscontinuityTags _discontinuityTags;
        private HlsEncryptionType _encryptionType;
        private HlsCdnSettings _hlsCdnSettings;
        private HlsId3SegmentTaggingState _hlsId3SegmentTagging;
        private IFrameOnlyPlaylistType _iFrameOnlyPlaylists;
        private HlsIncompleteSegmentBehavior _incompleteSegmentBehavior;
        private int? _indexNSegments;
        private InputLossActionForHlsOut _inputLossAction;
        private HlsIvInManifest _ivInManifest;
        private HlsIvSource _ivSource;
        private int? _keepSegments;
        private string _keyFormat;
        private string _keyFormatVersions;
        private KeyProviderSettings _keyProviderSettings;
        private HlsManifestCompression _manifestCompression;
        private HlsManifestDurationFormat _manifestDurationFormat;
        private int? _minSegmentLength;
        private HlsMode _mode;
        private HlsOutputSelection _outputSelection;
        private HlsProgramDateTime _programDateTime;
        private HlsProgramDateTimeClock _programDateTimeClock;
        private int? _programDateTimePeriod;
        private HlsRedundantManifest _redundantManifest;
        private HlsSegmentationMode _segmentationMode;
        private int? _segmentLength;
        private int? _segmentsPerSubdirectory;
        private HlsStreamInfResolution _streamInfResolution;
        private HlsTimedMetadataId3Frame _timedMetadataId3Frame;
        private int? _timedMetadataId3Period;
        private int? _timestampDeltaMilliseconds;
        private HlsTsFileMode _tsFileMode;

        /// <summary>
        /// Gets and sets the property AdMarkers. Choose one or more ad marker types to pass SCTE35
        /// signals through to this group of Apple HLS outputs.
        /// </summary>
        public List<string> AdMarkers
        {
            get { return this._adMarkers; }
            set { this._adMarkers = value; }
        }

        // Check to see if AdMarkers property is set
        internal bool IsSetAdMarkers()
        {
            return this._adMarkers != null && this._adMarkers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BaseUrlContent. A partial URI prefix that will be prepended
        /// to each output in the media .m3u8 file. Can be used if base manifest is delivered
        /// from a different URL than the main .m3u8 file.
        /// </summary>
        public string BaseUrlContent
        {
            get { return this._baseUrlContent; }
            set { this._baseUrlContent = value; }
        }

        // Check to see if BaseUrlContent property is set
        internal bool IsSetBaseUrlContent()
        {
            return this._baseUrlContent != null;
        }

        /// <summary>
        /// Gets and sets the property BaseUrlContent1. Optional. One value per output group.This
        /// field is required only if you are completing Base URL content A, and the downstream
        /// system has notified you that the media files for pipeline 1 of all outputs are in
        /// a location different from the media files for pipeline 0.
        /// </summary>
        public string BaseUrlContent1
        {
            get { return this._baseUrlContent1; }
            set { this._baseUrlContent1 = value; }
        }

        // Check to see if BaseUrlContent1 property is set
        internal bool IsSetBaseUrlContent1()
        {
            return this._baseUrlContent1 != null;
        }

        /// <summary>
        /// Gets and sets the property BaseUrlManifest. A partial URI prefix that will be prepended
        /// to each output in the media .m3u8 file. Can be used if base manifest is delivered
        /// from a different URL than the main .m3u8 file.
        /// </summary>
        public string BaseUrlManifest
        {
            get { return this._baseUrlManifest; }
            set { this._baseUrlManifest = value; }
        }

        // Check to see if BaseUrlManifest property is set
        internal bool IsSetBaseUrlManifest()
        {
            return this._baseUrlManifest != null;
        }

        /// <summary>
        /// Gets and sets the property BaseUrlManifest1. Optional. One value per output group.Complete
        /// this field only if you are completing Base URL manifest A, and the downstream system
        /// has notified you that the child manifest files for pipeline 1 of all outputs are in
        /// a location different from the child manifest files for pipeline 0.
        /// </summary>
        public string BaseUrlManifest1
        {
            get { return this._baseUrlManifest1; }
            set { this._baseUrlManifest1 = value; }
        }

        // Check to see if BaseUrlManifest1 property is set
        internal bool IsSetBaseUrlManifest1()
        {
            return this._baseUrlManifest1 != null;
        }

        /// <summary>
        /// Gets and sets the property CaptionLanguageMappings. Mapping of up to 4 caption channels
        /// to caption languages.  Is only meaningful if captionLanguageSetting is set to "insert".
        /// </summary>
        public List<CaptionLanguageMapping> CaptionLanguageMappings
        {
            get { return this._captionLanguageMappings; }
            set { this._captionLanguageMappings = value; }
        }

        // Check to see if CaptionLanguageMappings property is set
        internal bool IsSetCaptionLanguageMappings()
        {
            return this._captionLanguageMappings != null && this._captionLanguageMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CaptionLanguageSetting. Applies only to 608 Embedded output
        /// captions.insert: Include CLOSED-CAPTIONS lines in the manifest. Specify at least one
        /// language in the CC1 Language Code field. One CLOSED-CAPTION line is added for each
        /// Language Code you specify. Make sure to specify the languages in the order in which
        /// they appear in the original source (if the source is embedded format) or the order
        /// of the caption selectors (if the source is other than embedded). Otherwise, languages
        /// in the manifest will not match up properly with the output captions.none: Include
        /// CLOSED-CAPTIONS=NONE line in the manifest.omit: Omit any CLOSED-CAPTIONS line from
        /// the manifest.
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
        /// Gets and sets the property ClientCache. When set to "disabled", sets the #EXT-X-ALLOW-CACHE:no
        /// tag in the manifest, which prevents clients from saving media segments for later replay.
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
        /// Gets and sets the property ConstantIv. For use with encryptionType. This is a 128-bit,
        /// 16-byte hex value represented by a 32-character text string. If ivSource is set to
        /// "explicit" then this parameter is required and is used as the IV for encryption.
        /// </summary>
        [AWSProperty(Min=32, Max=32)]
        public string ConstantIv
        {
            get { return this._constantIv; }
            set { this._constantIv = value; }
        }

        // Check to see if ConstantIv property is set
        internal bool IsSetConstantIv()
        {
            return this._constantIv != null;
        }

        /// <summary>
        /// Gets and sets the property Destination. A directory or HTTP destination for the HLS
        /// segments, manifest files, and encryption keys (if enabled).
        /// </summary>
        [AWSProperty(Required=true)]
        public OutputLocationRef Destination
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
        /// Gets and sets the property DirectoryStructure. Place segments in subdirectories.
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
        /// Gets and sets the property DiscontinuityTags. Specifies whether to insert EXT-X-DISCONTINUITY
        /// tags in the HLS child manifests for this output group.Typically, choose Insert because
        /// these tags are required in the manifest (according to the HLS specification) and serve
        /// an important purpose.Choose Never Insert only if the downstream system is doing real-time
        /// failover (without using the MediaLive automatic failover feature) and only if that
        /// downstream system has advised you to exclude the tags.
        /// </summary>
        public HlsDiscontinuityTags DiscontinuityTags
        {
            get { return this._discontinuityTags; }
            set { this._discontinuityTags = value; }
        }

        // Check to see if DiscontinuityTags property is set
        internal bool IsSetDiscontinuityTags()
        {
            return this._discontinuityTags != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionType. Encrypts the segments with the given encryption
        /// scheme.  Exclude this parameter if no encryption is desired.
        /// </summary>
        public HlsEncryptionType EncryptionType
        {
            get { return this._encryptionType; }
            set { this._encryptionType = value; }
        }

        // Check to see if EncryptionType property is set
        internal bool IsSetEncryptionType()
        {
            return this._encryptionType != null;
        }

        /// <summary>
        /// Gets and sets the property HlsCdnSettings. Parameters that control interactions with
        /// the CDN.
        /// </summary>
        public HlsCdnSettings HlsCdnSettings
        {
            get { return this._hlsCdnSettings; }
            set { this._hlsCdnSettings = value; }
        }

        // Check to see if HlsCdnSettings property is set
        internal bool IsSetHlsCdnSettings()
        {
            return this._hlsCdnSettings != null;
        }

        /// <summary>
        /// Gets and sets the property HlsId3SegmentTagging. State of HLS ID3 Segment Tagging
        /// </summary>
        public HlsId3SegmentTaggingState HlsId3SegmentTagging
        {
            get { return this._hlsId3SegmentTagging; }
            set { this._hlsId3SegmentTagging = value; }
        }

        // Check to see if HlsId3SegmentTagging property is set
        internal bool IsSetHlsId3SegmentTagging()
        {
            return this._hlsId3SegmentTagging != null;
        }

        /// <summary>
        /// Gets and sets the property IFrameOnlyPlaylists. DISABLED: Do not create an I-frame-only
        /// manifest, but do create the master and media manifests (according to the Output Selection
        /// field).STANDARD: Create an I-frame-only manifest for each output that contains video,
        /// as well as the other manifests (according to the Output Selection field). The I-frame
        /// manifest contains a #EXT-X-I-FRAMES-ONLY tag to indicate it is I-frame only, and one
        /// or more #EXT-X-BYTERANGE entries identifying the I-frame position. For example, #EXT-X-BYTERANGE:160364@1461888"
        /// </summary>
        public IFrameOnlyPlaylistType IFrameOnlyPlaylists
        {
            get { return this._iFrameOnlyPlaylists; }
            set { this._iFrameOnlyPlaylists = value; }
        }

        // Check to see if IFrameOnlyPlaylists property is set
        internal bool IsSetIFrameOnlyPlaylists()
        {
            return this._iFrameOnlyPlaylists != null;
        }

        /// <summary>
        /// Gets and sets the property IncompleteSegmentBehavior. Specifies whether to include
        /// the final (incomplete) segment in the media output when the pipeline stops producing
        /// output because of a channel stop, a channel pause or a loss of input to the pipeline.Auto
        /// means that MediaLive decides whether to include the final segment, depending on the
        /// channel class and the types of output groups.Suppress means to never include the incomplete
        /// segment. We recommend you choose Auto and let MediaLive control the behavior.
        /// </summary>
        public HlsIncompleteSegmentBehavior IncompleteSegmentBehavior
        {
            get { return this._incompleteSegmentBehavior; }
            set { this._incompleteSegmentBehavior = value; }
        }

        // Check to see if IncompleteSegmentBehavior property is set
        internal bool IsSetIncompleteSegmentBehavior()
        {
            return this._incompleteSegmentBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property IndexNSegments. Applies only if Mode field is LIVE.Specifies
        /// the maximum number of segments in the media manifest file. After this maximum, older
        /// segments are removed from the media manifest. This number must be smaller than the
        /// number in the Keep Segments field.
        /// </summary>
        [AWSProperty(Min=3)]
        public int IndexNSegments
        {
            get { return this._indexNSegments.GetValueOrDefault(); }
            set { this._indexNSegments = value; }
        }

        // Check to see if IndexNSegments property is set
        internal bool IsSetIndexNSegments()
        {
            return this._indexNSegments.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputLossAction. Parameter that control output group behavior
        /// on input loss.
        /// </summary>
        public InputLossActionForHlsOut InputLossAction
        {
            get { return this._inputLossAction; }
            set { this._inputLossAction = value; }
        }

        // Check to see if InputLossAction property is set
        internal bool IsSetInputLossAction()
        {
            return this._inputLossAction != null;
        }

        /// <summary>
        /// Gets and sets the property IvInManifest. For use with encryptionType. The IV (Initialization
        /// Vector) is a 128-bit number used in conjunction with the key for encrypting blocks.
        /// If set to "include", IV is listed in the manifest, otherwise the IV is not in the
        /// manifest.
        /// </summary>
        public HlsIvInManifest IvInManifest
        {
            get { return this._ivInManifest; }
            set { this._ivInManifest = value; }
        }

        // Check to see if IvInManifest property is set
        internal bool IsSetIvInManifest()
        {
            return this._ivInManifest != null;
        }

        /// <summary>
        /// Gets and sets the property IvSource. For use with encryptionType. The IV (Initialization
        /// Vector) is a 128-bit number used in conjunction with the key for encrypting blocks.
        /// If this setting is "followsSegmentNumber", it will cause the IV to change every segment
        /// (to match the segment number). If this is set to "explicit", you must enter a constantIv
        /// value.
        /// </summary>
        public HlsIvSource IvSource
        {
            get { return this._ivSource; }
            set { this._ivSource = value; }
        }

        // Check to see if IvSource property is set
        internal bool IsSetIvSource()
        {
            return this._ivSource != null;
        }

        /// <summary>
        /// Gets and sets the property KeepSegments. Applies only if Mode field is LIVE.Specifies
        /// the number of media segments to retain in the destination directory. This number should
        /// be bigger than indexNSegments (Num segments). We recommend (value = (2 x indexNsegments)
        /// + 1).If this "keep segments" number is too low, the following might happen: the player
        /// is still reading a media manifest file that lists this segment, but that segment has
        /// been removed from the destination directory (as directed by indexNSegments). This
        /// situation would result in a 404 HTTP error on the player.
        /// </summary>
        [AWSProperty(Min=1)]
        public int KeepSegments
        {
            get { return this._keepSegments.GetValueOrDefault(); }
            set { this._keepSegments = value; }
        }

        // Check to see if KeepSegments property is set
        internal bool IsSetKeepSegments()
        {
            return this._keepSegments.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeyFormat. The value specifies how the key is represented
        /// in the resource identified by the URI.  If parameter is absent, an implicit value
        /// of "identity" is used.  A reverse DNS string can also be given.
        /// </summary>
        public string KeyFormat
        {
            get { return this._keyFormat; }
            set { this._keyFormat = value; }
        }

        // Check to see if KeyFormat property is set
        internal bool IsSetKeyFormat()
        {
            return this._keyFormat != null;
        }

        /// <summary>
        /// Gets and sets the property KeyFormatVersions. Either a single positive integer version
        /// value or a slash delimited list of version values (1/2/3).
        /// </summary>
        public string KeyFormatVersions
        {
            get { return this._keyFormatVersions; }
            set { this._keyFormatVersions = value; }
        }

        // Check to see if KeyFormatVersions property is set
        internal bool IsSetKeyFormatVersions()
        {
            return this._keyFormatVersions != null;
        }

        /// <summary>
        /// Gets and sets the property KeyProviderSettings. The key provider settings.
        /// </summary>
        public KeyProviderSettings KeyProviderSettings
        {
            get { return this._keyProviderSettings; }
            set { this._keyProviderSettings = value; }
        }

        // Check to see if KeyProviderSettings property is set
        internal bool IsSetKeyProviderSettings()
        {
            return this._keyProviderSettings != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestCompression. When set to gzip, compresses HLS playlist.
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
        /// should use floating point or integer values for segment duration.
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
        /// Gets and sets the property MinSegmentLength. Minimum length of MPEG-2 Transport Stream
        /// segments in seconds. When set, minimum segment length is enforced by looking ahead
        /// and back within the specified range for a nearby avail and extending the segment size
        /// if needed.
        /// </summary>
        [AWSProperty(Min=0)]
        public int MinSegmentLength
        {
            get { return this._minSegmentLength.GetValueOrDefault(); }
            set { this._minSegmentLength = value; }
        }

        // Check to see if MinSegmentLength property is set
        internal bool IsSetMinSegmentLength()
        {
            return this._minSegmentLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Mode. If "vod", all segments are indexed and kept permanently
        /// in the destination and manifest. If "live", only the number segments specified in
        /// keepSegments and indexNSegments are kept; newer segments replace older segments, which
        /// may prevent players from rewinding all the way to the beginning of the event.VOD mode
        /// uses HLS EXT-X-PLAYLIST-TYPE of EVENT while the channel is running, converting it
        /// to a "VOD" type manifest on completion of the stream.
        /// </summary>
        public HlsMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property OutputSelection. MANIFESTS_AND_SEGMENTS: Generates manifests
        /// (master manifest, if applicable, and media manifests) for this output group.VARIANT_MANIFESTS_AND_SEGMENTS:
        /// Generates media manifests for this output group, but not a master manifest.SEGMENTS_ONLY:
        /// Does not generate any manifests for this output group.
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
        /// tag in .m3u8 manifest files. The value is calculated using the program date time clock.
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
        /// Gets and sets the property ProgramDateTimeClock. Specifies the algorithm used to drive
        /// the HLS EXT-X-PROGRAM-DATE-TIME clock. Options include:INITIALIZE_FROM_OUTPUT_TIMECODE:
        /// The PDT clock is initialized as a function of the first output timecode, then incremented
        /// by the EXTINF duration of each encoded segment.SYSTEM_CLOCK: The PDT clock is initialized
        /// as a function of the UTC wall clock, then incremented by the EXTINF duration of each
        /// encoded segment. If the PDT clock diverges from the wall clock by more than 500ms,
        /// it is resynchronized to the wall clock.
        /// </summary>
        public HlsProgramDateTimeClock ProgramDateTimeClock
        {
            get { return this._programDateTimeClock; }
            set { this._programDateTimeClock = value; }
        }

        // Check to see if ProgramDateTimeClock property is set
        internal bool IsSetProgramDateTimeClock()
        {
            return this._programDateTimeClock != null;
        }

        /// <summary>
        /// Gets and sets the property ProgramDateTimePeriod. Period of insertion of EXT-X-PROGRAM-DATE-TIME
        /// entry, in seconds.
        /// </summary>
        [AWSProperty(Min=0, Max=3600)]
        public int ProgramDateTimePeriod
        {
            get { return this._programDateTimePeriod.GetValueOrDefault(); }
            set { this._programDateTimePeriod = value; }
        }

        // Check to see if ProgramDateTimePeriod property is set
        internal bool IsSetProgramDateTimePeriod()
        {
            return this._programDateTimePeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RedundantManifest. ENABLED: The master manifest (.m3u8
        /// file) for each pipeline includes information about both pipelines: first its own media
        /// files, then the media files of the other pipeline. This feature allows playout device
        /// that support stale manifest detection to switch from one manifest to the other, when
        /// the current manifest seems to be stale. There are still two destinations and two master
        /// manifests, but both master manifests reference the media files from both pipelines.DISABLED:
        /// The master manifest (.m3u8 file) for each pipeline includes information about its
        /// own pipeline only.For an HLS output group with MediaPackage as the destination, the
        /// DISABLED behavior is always followed. MediaPackage regenerates the manifests it serves
        /// to players so a redundant manifest from MediaLive is irrelevant.
        /// </summary>
        public HlsRedundantManifest RedundantManifest
        {
            get { return this._redundantManifest; }
            set { this._redundantManifest = value; }
        }

        // Check to see if RedundantManifest property is set
        internal bool IsSetRedundantManifest()
        {
            return this._redundantManifest != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentationMode. useInputSegmentation has been deprecated.
        /// The configured segment size is always used.
        /// </summary>
        public HlsSegmentationMode SegmentationMode
        {
            get { return this._segmentationMode; }
            set { this._segmentationMode = value; }
        }

        // Check to see if SegmentationMode property is set
        internal bool IsSetSegmentationMode()
        {
            return this._segmentationMode != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentLength. Length of MPEG-2 Transport Stream segments
        /// to create in seconds. Note that segments will end on the next keyframe after this
        /// duration, so actual segment length may be longer.
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property SegmentsPerSubdirectory. Number of segments to write to
        /// a subdirectory before starting a new one. directoryStructure must be subdirectoryPerStream
        /// for this setting to have an effect.
        /// </summary>
        [AWSProperty(Min=1)]
        public int SegmentsPerSubdirectory
        {
            get { return this._segmentsPerSubdirectory.GetValueOrDefault(); }
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
        /// Gets and sets the property TimedMetadataId3Frame. Indicates ID3 frame that has the
        /// timecode.
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
        /// Gets and sets the property TimedMetadataId3Period. Timed Metadata interval in seconds.
        /// </summary>
        [AWSProperty(Min=0)]
        public int TimedMetadataId3Period
        {
            get { return this._timedMetadataId3Period.GetValueOrDefault(); }
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
        [AWSProperty(Min=0)]
        public int TimestampDeltaMilliseconds
        {
            get { return this._timestampDeltaMilliseconds.GetValueOrDefault(); }
            set { this._timestampDeltaMilliseconds = value; }
        }

        // Check to see if TimestampDeltaMilliseconds property is set
        internal bool IsSetTimestampDeltaMilliseconds()
        {
            return this._timestampDeltaMilliseconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TsFileMode. SEGMENTED_FILES: Emit the program as segments
        /// - multiple .ts media files.SINGLE_FILE: Applies only if Mode field is VOD. Emit the
        /// program as a single .ts media file. The media manifest includes #EXT-X-BYTERANGE tags
        /// to index segments for playback. A typical use for this value is when sending the output
        /// to AWS Elemental MediaConvert, which can accept only a single media file. Playback
        /// while the channel is running is not guaranteed due to HTTP server caching.
        /// </summary>
        public HlsTsFileMode TsFileMode
        {
            get { return this._tsFileMode; }
            set { this._tsFileMode = value; }
        }

        // Check to see if TsFileMode property is set
        internal bool IsSetTsFileMode()
        {
            return this._tsFileMode != null;
        }

    }
}