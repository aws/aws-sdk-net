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
    /// Required when you set (Type) under (OutputGroups)>(OutputGroupSettings) to HLS_GROUP_SETTINGS.
    /// </summary>
    public partial class HlsGroupSettings
    {
        private List<HlsAdditionalManifest> _additionalManifests = new List<HlsAdditionalManifest>();
        private List<string> _adMarkers = new List<string>();
        private HlsAudioOnlyHeader _audioOnlyHeader;
        private string _baseUrl;
        private List<HlsCaptionLanguageMapping> _captionLanguageMappings = new List<HlsCaptionLanguageMapping>();
        private HlsCaptionLanguageSetting _captionLanguageSetting;
        private HlsClientCache _clientCache;
        private HlsCodecSpecification _codecSpecification;
        private string _destination;
        private DestinationSettings _destinationSettings;
        private HlsDirectoryStructure _directoryStructure;
        private HlsEncryptionSettings _encryption;
        private HlsManifestCompression _manifestCompression;
        private HlsManifestDurationFormat _manifestDurationFormat;
        private double? _minFinalSegmentLength;
        private int? _minSegmentLength;
        private HlsOutputSelection _outputSelection;
        private HlsProgramDateTime _programDateTime;
        private int? _programDateTimePeriod;
        private HlsSegmentControl _segmentControl;
        private int? _segmentLength;
        private int? _segmentsPerSubdirectory;
        private HlsStreamInfResolution _streamInfResolution;
        private HlsTimedMetadataId3Frame _timedMetadataId3Frame;
        private int? _timedMetadataId3Period;
        private int? _timestampDeltaMilliseconds;

        /// <summary>
        /// Gets and sets the property AdditionalManifests. By default, the service creates one
        /// top-level .m3u8 HLS manifest for each HLS output group in your job. This default manifest
        /// references every output in the output group. To create additional top-level manifests
        /// that reference a subset of the outputs in the output group, specify a list of them
        /// here.
        /// </summary>
        public List<HlsAdditionalManifest> AdditionalManifests
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
        /// Gets and sets the property AdMarkers. Choose one or more ad marker types to decorate
        /// your Apple HLS manifest. This setting does not determine whether SCTE-35 markers appear
        /// in the outputs themselves.
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
        /// Gets and sets the property AudioOnlyHeader. Ignore this setting unless you are using
        /// FairPlay DRM with Verimatrix and you encounter playback issues. Keep the default value,
        /// Include (INCLUDE), to output audio-only headers. Choose Exclude (EXCLUDE) to remove
        /// the audio-only headers from your audio segments.
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
        /// </summary>
        public List<HlsCaptionLanguageMapping> CaptionLanguageMappings
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
        /// Gets and sets the property ClientCache. Disable this setting only when your workflow
        /// requires the #EXT-X-ALLOW-CACHE:no tag. Otherwise, keep the default value Enabled
        /// (ENABLED) and control caching in your video distribution set up. For example, use
        /// the Cache-Control http header.
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
        /// Gets and sets the property MinSegmentLength. When set, Minimum Segment Size is enforced
        /// by looking ahead and back within the specified range for a nearby avail and extending
        /// the segment size if needed.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
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
        /// Gets and sets the property SegmentLength. Length of MPEG-2 Transport Stream segments
        /// to create (in seconds). Note that segments will end on the next keyframe after this
        /// number of seconds, so actual segment length may be longer.
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
        /// Gets and sets the property SegmentsPerSubdirectory. Number of segments to write to
        /// a subdirectory before starting a new one. directoryStructure must be SINGLE_DIRECTORY
        /// for this setting to have an effect.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
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
        [AWSProperty(Min=-2147483648, Max=2147483647)]
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
        [AWSProperty(Min=-2147483648, Max=2147483647)]
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

    }
}