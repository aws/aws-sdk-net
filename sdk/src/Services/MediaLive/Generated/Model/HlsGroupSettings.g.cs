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
    /// Hls Group Settings
    /// </summary>
    public partial class HlsGroupSettings
    {
        /// <summary>
        /// Gets and sets the property AdMarkers. Choose one or more ad marker types to pass SCTE35
        /// signals through to this group of Apple HLS outputs.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdMarkers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdMarkers property is set.
        /// </summary>
        internal bool IsSetAdMarkers() => this.AdMarkers != null && (this.AdMarkers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BaseUrlContent. A partial URI prefix that will be prepended
        /// to each output in the media .m3u8 file. Can be used if base manifest is delivered
        /// from a different URL than the main .m3u8 file.
        /// </summary>
        public string BaseUrlContent { get; set; }

        /// <summary>
        /// Checks to see if the BaseUrlContent property is set.
        /// </summary>
        internal bool IsSetBaseUrlContent() => this.BaseUrlContent != null;

        /// <summary>
        /// Gets and sets the property BaseUrlContent1. Optional. One value per output group.
        /// This field is required only if you are completing Base URL content A, and the downstream
        /// system has notified you that the media files for pipeline 1 of all outputs are in
        /// a location different from the media files for pipeline 0.
        /// </summary>
        public string BaseUrlContent1 { get; set; }

        /// <summary>
        /// Checks to see if the BaseUrlContent1 property is set.
        /// </summary>
        internal bool IsSetBaseUrlContent1() => this.BaseUrlContent1 != null;

        /// <summary>
        /// Gets and sets the property BaseUrlManifest. A partial URI prefix that will be prepended
        /// to each output in the media .m3u8 file. Can be used if base manifest is delivered
        /// from a different URL than the main .m3u8 file.
        /// </summary>
        public string BaseUrlManifest { get; set; }

        /// <summary>
        /// Checks to see if the BaseUrlManifest property is set.
        /// </summary>
        internal bool IsSetBaseUrlManifest() => this.BaseUrlManifest != null;

        /// <summary>
        /// Gets and sets the property BaseUrlManifest1. Optional. One value per output group.
        /// Complete this field only if you are completing Base URL manifest A, and the downstream
        /// system has notified you that the child manifest files for pipeline 1 of all outputs
        /// are in a location different from the child manifest files for pipeline 0.
        /// </summary>
        public string BaseUrlManifest1 { get; set; }

        /// <summary>
        /// Checks to see if the BaseUrlManifest1 property is set.
        /// </summary>
        internal bool IsSetBaseUrlManifest1() => this.BaseUrlManifest1 != null;

        /// <summary>
        /// Gets and sets the property CaptionLanguageMappings. Mapping of up to 4 caption channels
        /// to caption languages. Is only meaningful if captionLanguageSetting is set to "insert".
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
        /// Gets and sets the property CaptionLanguageSetting. Applies only to 608 Embedded output
        /// captions. insert: Include CLOSED-CAPTIONS lines in the manifest. Specify at least
        /// one language in the CC1 Language Code field. One CLOSED-CAPTION line is added for
        /// each Language Code you specify. Make sure to specify the languages in the order in
        /// which they appear in the original source (if the source is embedded format) or the
        /// order of the caption selectors (if the source is other than embedded). Otherwise,
        /// languages in the manifest will not match up properly with the output captions. none:
        /// Include CLOSED-CAPTIONS=NONE line in the manifest. omit: Omit any CLOSED-CAPTIONS
        /// line from the manifest.
        /// </summary>
        public HlsCaptionLanguageSetting CaptionLanguageSetting { get; set; }

        /// <summary>
        /// Checks to see if the CaptionLanguageSetting property is set.
        /// </summary>
        internal bool IsSetCaptionLanguageSetting() => this.CaptionLanguageSetting != null;

        /// <summary>
        /// Gets and sets the property ClientCache. When set to "disabled", sets the #EXT-X-ALLOW-CACHE:no
        /// tag in the manifest, which prevents clients from saving media segments for later replay.
        /// </summary>
        public HlsClientCache ClientCache { get; set; }

        /// <summary>
        /// Checks to see if the ClientCache property is set.
        /// </summary>
        internal bool IsSetClientCache() => this.ClientCache != null;

        /// <summary>
        /// Gets and sets the property CodecSpecification. Specification to use (RFC-6381 or the
        /// default RFC-4281) during m3u8 playlist generation.
        /// </summary>
        public HlsCodecSpecification CodecSpecification { get; set; }

        /// <summary>
        /// Checks to see if the CodecSpecification property is set.
        /// </summary>
        internal bool IsSetCodecSpecification() => this.CodecSpecification != null;

        /// <summary>
        /// Gets and sets the property ConstantIv. For use with encryptionType. This is a 128-bit,
        /// 16-byte hex value represented by a 32-character text string. If ivSource is set to
        /// "explicit" then this parameter is required and is used as the IV for encryption.
        /// </summary>
        public string ConstantIv { get; set; }

        /// <summary>
        /// Checks to see if the ConstantIv property is set.
        /// </summary>
        internal bool IsSetConstantIv() => this.ConstantIv != null;

        /// <summary>
        /// Gets and sets the property Destination. A directory or HTTP destination for the HLS
        /// segments, manifest files, and encryption keys (if enabled).
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputLocationRef Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property DirectoryStructure. Place segments in subdirectories.
        /// </summary>
        public HlsDirectoryStructure DirectoryStructure { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryStructure property is set.
        /// </summary>
        internal bool IsSetDirectoryStructure() => this.DirectoryStructure != null;

        /// <summary>
        /// Gets and sets the property DiscontinuityTags. Specifies whether to insert EXT-X-DISCONTINUITY
        /// tags in the HLS child manifests for this output group. Typically, choose Insert because
        /// these tags are required in the manifest (according to the HLS specification) and serve
        /// an important purpose. Choose Never Insert only if the downstream system is doing real-time
        /// failover (without using the MediaLive automatic failover feature) and only if that
        /// downstream system has advised you to exclude the tags.
        /// </summary>
        public HlsDiscontinuityTags DiscontinuityTags { get; set; }

        /// <summary>
        /// Checks to see if the DiscontinuityTags property is set.
        /// </summary>
        internal bool IsSetDiscontinuityTags() => this.DiscontinuityTags != null;

        /// <summary>
        /// Gets and sets the property EncryptionType. Encrypts the segments with the given encryption
        /// scheme. Exclude this parameter if no encryption is desired.
        /// </summary>
        public HlsEncryptionType EncryptionType { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionType property is set.
        /// </summary>
        internal bool IsSetEncryptionType() => this.EncryptionType != null;

        /// <summary>
        /// Gets and sets the property HlsCdnSettings. Parameters that control interactions with
        /// the CDN.
        /// </summary>
        public HlsCdnSettings HlsCdnSettings { get; set; }

        /// <summary>
        /// Checks to see if the HlsCdnSettings property is set.
        /// </summary>
        internal bool IsSetHlsCdnSettings() => this.HlsCdnSettings != null;

        /// <summary>
        /// Gets and sets the property HlsId3SegmentTagging. State of HLS ID3 Segment Tagging
        /// </summary>
        public HlsId3SegmentTaggingState HlsId3SegmentTagging { get; set; }

        /// <summary>
        /// Checks to see if the HlsId3SegmentTagging property is set.
        /// </summary>
        internal bool IsSetHlsId3SegmentTagging() => this.HlsId3SegmentTagging != null;

        /// <summary>
        /// Gets and sets the property IFrameOnlyPlaylists. DISABLED: Do not create an I-frame-only
        /// manifest, but do create the master and media manifests (according to the Output Selection
        /// field). STANDARD: Create an I-frame-only manifest for each output that contains video,
        /// as well as the other manifests (according to the Output Selection field). The I-frame
        /// manifest contains a #EXT-X-I-FRAMES-ONLY tag to indicate it is I-frame only, and one
        /// or more #EXT-X-BYTERANGE entries identifying the I-frame position. For example, #EXT-X-BYTERANGE:160364@1461888"
        /// </summary>
        public IFrameOnlyPlaylistType IFrameOnlyPlaylists { get; set; }

        /// <summary>
        /// Checks to see if the IFrameOnlyPlaylists property is set.
        /// </summary>
        internal bool IsSetIFrameOnlyPlaylists() => this.IFrameOnlyPlaylists != null;

        /// <summary>
        /// Gets and sets the property IncompleteSegmentBehavior. Specifies whether to include
        /// the final (incomplete) segment in the media output when the pipeline stops producing
        /// output because of a channel stop, a channel pause or a loss of input to the pipeline.
        /// Auto means that MediaLive decides whether to include the final segment, depending
        /// on the channel class and the types of output groups. Suppress means to never include
        /// the incomplete segment. We recommend you choose Auto and let MediaLive control the
        /// behavior.
        /// </summary>
        public HlsIncompleteSegmentBehavior IncompleteSegmentBehavior { get; set; }

        /// <summary>
        /// Checks to see if the IncompleteSegmentBehavior property is set.
        /// </summary>
        internal bool IsSetIncompleteSegmentBehavior() => this.IncompleteSegmentBehavior != null;

        /// <summary>
        /// Gets and sets the property IndexNSegments. Applies only if Mode field is LIVE. Specifies
        /// the maximum number of segments in the media manifest file. After this maximum, older
        /// segments are removed from the media manifest. This number must be smaller than the
        /// number in the Keep Segments field.
        /// </summary>
        public int? IndexNSegments { get; set; }

        /// <summary>
        /// Checks to see if the IndexNSegments property is set.
        /// </summary>
        internal bool IsSetIndexNSegments() => this.IndexNSegments.HasValue;

        /// <summary>
        /// Gets and sets the property InputLossAction. Parameter that control output group behavior
        /// on input loss.
        /// </summary>
        public InputLossActionForHlsOut InputLossAction { get; set; }

        /// <summary>
        /// Checks to see if the InputLossAction property is set.
        /// </summary>
        internal bool IsSetInputLossAction() => this.InputLossAction != null;

        /// <summary>
        /// Gets and sets the property IvInManifest. For use with encryptionType. The IV (Initialization
        /// Vector) is a 128-bit number used in conjunction with the key for encrypting blocks.
        /// If set to "include", IV is listed in the manifest, otherwise the IV is not in the
        /// manifest.
        /// </summary>
        public HlsIvInManifest IvInManifest { get; set; }

        /// <summary>
        /// Checks to see if the IvInManifest property is set.
        /// </summary>
        internal bool IsSetIvInManifest() => this.IvInManifest != null;

        /// <summary>
        /// Gets and sets the property IvSource. For use with encryptionType. The IV (Initialization
        /// Vector) is a 128-bit number used in conjunction with the key for encrypting blocks.
        /// If this setting is "followsSegmentNumber", it will cause the IV to change every segment
        /// (to match the segment number). If this is set to "explicit", you must enter a constantIv
        /// value.
        /// </summary>
        public HlsIvSource IvSource { get; set; }

        /// <summary>
        /// Checks to see if the IvSource property is set.
        /// </summary>
        internal bool IsSetIvSource() => this.IvSource != null;

        /// <summary>
        /// Gets and sets the property KeepSegments. Applies only if Mode field is LIVE. Specifies
        /// the number of media segments to retain in the destination directory. This number should
        /// be bigger than indexNSegments (Num segments). We recommend (value = (2 x indexNsegments)
        /// + 1). If this "keep segments" number is too low, the following might happen: the player
        /// is still reading a media manifest file that lists this segment, but that segment has
        /// been removed from the destination directory (as directed by indexNSegments). This
        /// situation would result in a 404 HTTP error on the player.
        /// </summary>
        public int? KeepSegments { get; set; }

        /// <summary>
        /// Checks to see if the KeepSegments property is set.
        /// </summary>
        internal bool IsSetKeepSegments() => this.KeepSegments.HasValue;

        /// <summary>
        /// Gets and sets the property KeyFormat. The value specifies how the key is represented
        /// in the resource identified by the URI. If parameter is absent, an implicit value of
        /// "identity" is used. A reverse DNS string can also be given.
        /// </summary>
        public string KeyFormat { get; set; }

        /// <summary>
        /// Checks to see if the KeyFormat property is set.
        /// </summary>
        internal bool IsSetKeyFormat() => this.KeyFormat != null;

        /// <summary>
        /// Gets and sets the property KeyFormatVersions. Either a single positive integer version
        /// value or a slash delimited list of version values (1/2/3).
        /// </summary>
        public string KeyFormatVersions { get; set; }

        /// <summary>
        /// Checks to see if the KeyFormatVersions property is set.
        /// </summary>
        internal bool IsSetKeyFormatVersions() => this.KeyFormatVersions != null;

        /// <summary>
        /// Gets and sets the property KeyProviderSettings. The key provider settings.
        /// </summary>
        public KeyProviderSettings KeyProviderSettings { get; set; }

        /// <summary>
        /// Checks to see if the KeyProviderSettings property is set.
        /// </summary>
        internal bool IsSetKeyProviderSettings() => this.KeyProviderSettings != null;

        /// <summary>
        /// Gets and sets the property ManifestCompression. When set to gzip, compresses HLS playlist.
        /// </summary>
        public HlsManifestCompression ManifestCompression { get; set; }

        /// <summary>
        /// Checks to see if the ManifestCompression property is set.
        /// </summary>
        internal bool IsSetManifestCompression() => this.ManifestCompression != null;

        /// <summary>
        /// Gets and sets the property ManifestDurationFormat. Indicates whether the output manifest
        /// should use floating point or integer values for segment duration.
        /// </summary>
        public HlsManifestDurationFormat ManifestDurationFormat { get; set; }

        /// <summary>
        /// Checks to see if the ManifestDurationFormat property is set.
        /// </summary>
        internal bool IsSetManifestDurationFormat() => this.ManifestDurationFormat != null;

        /// <summary>
        /// Gets and sets the property MinSegmentLength. Minimum length of MPEG-2 Transport Stream
        /// segments in seconds. When set, minimum segment length is enforced by looking ahead
        /// and back within the specified range for a nearby avail and extending the segment size
        /// if needed.
        /// </summary>
        public int? MinSegmentLength { get; set; }

        /// <summary>
        /// Checks to see if the MinSegmentLength property is set.
        /// </summary>
        internal bool IsSetMinSegmentLength() => this.MinSegmentLength.HasValue;

        /// <summary>
        /// Gets and sets the property Mode. If "vod", all segments are indexed and kept permanently
        /// in the destination and manifest. If "live", only the number segments specified in
        /// keepSegments and indexNSegments are kept; newer segments replace older segments, which
        /// may prevent players from rewinding all the way to the beginning of the event. VOD
        /// mode uses HLS EXT-X-PLAYLIST-TYPE of EVENT while the channel is running, converting
        /// it to a "VOD" type manifest on completion of the stream.
        /// </summary>
        public HlsMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property OutputSelection. MANIFESTS_AND_SEGMENTS: Generates manifests
        /// (master manifest, if applicable, and media manifests) for this output group. VARIANT_MANIFESTS_AND_SEGMENTS:
        /// Generates media manifests for this output group, but not a master manifest. SEGMENTS_ONLY:
        /// Does not generate any manifests for this output group.
        /// </summary>
        public HlsOutputSelection OutputSelection { get; set; }

        /// <summary>
        /// Checks to see if the OutputSelection property is set.
        /// </summary>
        internal bool IsSetOutputSelection() => this.OutputSelection != null;

        /// <summary>
        /// Gets and sets the property ProgramDateTime. Includes or excludes EXT-X-PROGRAM-DATE-TIME
        /// tag in .m3u8 manifest files. The value is calculated using the program date time clock.
        /// </summary>
        public HlsProgramDateTime ProgramDateTime { get; set; }

        /// <summary>
        /// Checks to see if the ProgramDateTime property is set.
        /// </summary>
        internal bool IsSetProgramDateTime() => this.ProgramDateTime != null;

        /// <summary>
        /// Gets and sets the property ProgramDateTimeClock. Specifies the algorithm used to drive
        /// the HLS EXT-X-PROGRAM-DATE-TIME clock. Options include: INITIALIZE_FROM_OUTPUT_TIMECODE:
        /// The PDT clock is initialized as a function of the first output timecode, then incremented
        /// by the EXTINF duration of each encoded segment. SYSTEM_CLOCK: The PDT clock is initialized
        /// as a function of the UTC wall clock, then incremented by the EXTINF duration of each
        /// encoded segment. If the PDT clock diverges from the wall clock by more than 500ms,
        /// it is resynchronized to the wall clock.
        /// </summary>
        public HlsProgramDateTimeClock ProgramDateTimeClock { get; set; }

        /// <summary>
        /// Checks to see if the ProgramDateTimeClock property is set.
        /// </summary>
        internal bool IsSetProgramDateTimeClock() => this.ProgramDateTimeClock != null;

        /// <summary>
        /// Gets and sets the property ProgramDateTimePeriod. Period of insertion of EXT-X-PROGRAM-DATE-TIME
        /// entry, in seconds.
        /// </summary>
        public int? ProgramDateTimePeriod { get; set; }

        /// <summary>
        /// Checks to see if the ProgramDateTimePeriod property is set.
        /// </summary>
        internal bool IsSetProgramDateTimePeriod() => this.ProgramDateTimePeriod.HasValue;

        /// <summary>
        /// Gets and sets the property RedundantManifest. ENABLED: The master manifest (.m3u8
        /// file) for each pipeline includes information about both pipelines: first its own media
        /// files, then the media files of the other pipeline. This feature allows playout device
        /// that support stale manifest detection to switch from one manifest to the other, when
        /// the current manifest seems to be stale. There are still two destinations and two master
        /// manifests, but both master manifests reference the media files from both pipelines.
        /// DISABLED: The master manifest (.m3u8 file) for each pipeline includes information
        /// about its own pipeline only. For an HLS output group with MediaPackage as the destination,
        /// the DISABLED behavior is always followed. MediaPackage regenerates the manifests it
        /// serves to players so a redundant manifest from MediaLive is irrelevant.
        /// </summary>
        public HlsRedundantManifest RedundantManifest { get; set; }

        /// <summary>
        /// Checks to see if the RedundantManifest property is set.
        /// </summary>
        internal bool IsSetRedundantManifest() => this.RedundantManifest != null;

        /// <summary>
        /// Gets and sets the property SegmentLength. Length of MPEG-2 Transport Stream segments
        /// to create in seconds. Note that segments will end on the next keyframe after this
        /// duration, so actual segment length may be longer.
        /// </summary>
        public int? SegmentLength { get; set; }

        /// <summary>
        /// Checks to see if the SegmentLength property is set.
        /// </summary>
        internal bool IsSetSegmentLength() => this.SegmentLength.HasValue;

        /// <summary>
        /// Gets and sets the property SegmentationMode. useInputSegmentation has been deprecated.
        /// The configured segment size is always used.
        /// </summary>
        public HlsSegmentationMode SegmentationMode { get; set; }

        /// <summary>
        /// Checks to see if the SegmentationMode property is set.
        /// </summary>
        internal bool IsSetSegmentationMode() => this.SegmentationMode != null;

        /// <summary>
        /// Gets and sets the property SegmentsPerSubdirectory. Number of segments to write to
        /// a subdirectory before starting a new one. directoryStructure must be subdirectoryPerStream
        /// for this setting to have an effect.
        /// </summary>
        public int? SegmentsPerSubdirectory { get; set; }

        /// <summary>
        /// Checks to see if the SegmentsPerSubdirectory property is set.
        /// </summary>
        internal bool IsSetSegmentsPerSubdirectory() => this.SegmentsPerSubdirectory.HasValue;

        /// <summary>
        /// Gets and sets the property StreamInfResolution. Include or exclude RESOLUTION attribute
        /// for video in EXT-X-STREAM-INF tag of variant manifest.
        /// </summary>
        public HlsStreamInfResolution StreamInfResolution { get; set; }

        /// <summary>
        /// Checks to see if the StreamInfResolution property is set.
        /// </summary>
        internal bool IsSetStreamInfResolution() => this.StreamInfResolution != null;

        /// <summary>
        /// Gets and sets the property TimedMetadataId3Frame. Indicates ID3 frame that has the
        /// timecode.
        /// </summary>
        public HlsTimedMetadataId3Frame TimedMetadataId3Frame { get; set; }

        /// <summary>
        /// Checks to see if the TimedMetadataId3Frame property is set.
        /// </summary>
        internal bool IsSetTimedMetadataId3Frame() => this.TimedMetadataId3Frame != null;

        /// <summary>
        /// Gets and sets the property TimedMetadataId3Period. Timed Metadata interval in seconds.
        /// </summary>
        public int? TimedMetadataId3Period { get; set; }

        /// <summary>
        /// Checks to see if the TimedMetadataId3Period property is set.
        /// </summary>
        internal bool IsSetTimedMetadataId3Period() => this.TimedMetadataId3Period.HasValue;

        /// <summary>
        /// Gets and sets the property TimestampDeltaMilliseconds. Provides an extra millisecond
        /// delta offset to fine tune the timestamps.
        /// </summary>
        public int? TimestampDeltaMilliseconds { get; set; }

        /// <summary>
        /// Checks to see if the TimestampDeltaMilliseconds property is set.
        /// </summary>
        internal bool IsSetTimestampDeltaMilliseconds() => this.TimestampDeltaMilliseconds.HasValue;

        /// <summary>
        /// Gets and sets the property TsFileMode. SEGMENTED_FILES: Emit the program as segments
        /// - multiple .ts media files. SINGLE_FILE: Applies only if Mode field is VOD. Emit the
        /// program as a single .ts media file. The media manifest includes #EXT-X-BYTERANGE tags
        /// to index segments for playback. A typical use for this value is when sending the output
        /// to AWS Elemental MediaConvert, which can accept only a single media file. Playback
        /// while the channel is running is not guaranteed due to HTTP server caching.
        /// </summary>
        public HlsTsFileMode TsFileMode { get; set; }

        /// <summary>
        /// Checks to see if the TsFileMode property is set.
        /// </summary>
        internal bool IsSetTsFileMode() => this.TsFileMode != null;
    }
}
