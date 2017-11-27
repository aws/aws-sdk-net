/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Required when you set (Type) under (OutputGroups)>(OutputGroupSettings) to HLS_GROUP_SETTINGS.
    /// </summary>
    public partial class HlsGroupSettings
    {
        private List<string> _adMarkers = new List<string>();
        private string _baseUrl;
        private List<HlsCaptionLanguageMapping> _captionLanguageMappings = new List<HlsCaptionLanguageMapping>();
        private HlsCaptionLanguageSetting _captionLanguageSetting;
        private HlsClientCache _clientCache;
        private HlsCodecSpecification _codecSpecification;
        private string _destination;
        private HlsDirectoryStructure _directoryStructure;
        private HlsEncryptionSettings _encryption;
        private HlsManifestCompression _manifestCompression;
        private HlsManifestDurationFormat _manifestDurationFormat;
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
        /// Gets and sets the property CaptionLanguageSetting.
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
        /// Gets and sets the property ClientCache.
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
        /// Gets and sets the property CodecSpecification.
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
        /// Gets and sets the property DirectoryStructure.
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
        /// Gets and sets the property ManifestCompression.
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
        /// Gets and sets the property ManifestDurationFormat.
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
        /// Gets and sets the property MinSegmentLength. When set, Minimum Segment Size is enforced
        /// by looking ahead and back within the specified range for a nearby avail and extending
        /// the segment size if needed.
        /// </summary>
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
        /// Gets and sets the property OutputSelection.
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
        /// Gets and sets the property ProgramDateTime.
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
        /// Gets and sets the property SegmentControl.
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
        /// Gets and sets the property StreamInfResolution.
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
        /// Gets and sets the property TimedMetadataId3Frame.
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