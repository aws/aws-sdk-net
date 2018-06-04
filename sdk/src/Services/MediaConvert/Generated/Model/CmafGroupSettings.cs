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
    /// Required when you set (Type) under (OutputGroups)>(OutputGroupSettings) to CMAF_GROUP_SETTINGS.
    /// </summary>
    public partial class CmafGroupSettings
    {
        private string _baseUrl;
        private CmafClientCache _clientCache;
        private CmafCodecSpecification _codecSpecification;
        private string _destination;
        private CmafEncryptionSettings _encryption;
        private int? _fragmentLength;
        private CmafManifestCompression _manifestCompression;
        private CmafManifestDurationFormat _manifestDurationFormat;
        private int? _minBufferTime;
        private CmafSegmentControl _segmentControl;
        private int? _segmentLength;
        private CmafStreamInfResolution _streamInfResolution;
        private CmafWriteDASHManifest _writeDashManifest;
        private CmafWriteHLSManifest _writeHlsManifest;

        /// <summary>
        /// Gets and sets the property BaseUrl. A partial URI prefix that will be put in the manifest
        /// file at the top level BaseURL element. Can be used if streams are delivered from a
        /// different URL than the manifest file.
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
        /// Gets and sets the property ClientCache.
        /// </summary>
        public CmafClientCache ClientCache
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
        public CmafCodecSpecification CodecSpecification
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
        /// Gets and sets the property Encryption. DRM settings.
        /// </summary>
        public CmafEncryptionSettings Encryption
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
        /// Gets and sets the property ManifestCompression.
        /// </summary>
        public CmafManifestCompression ManifestCompression
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
        public CmafManifestDurationFormat ManifestDurationFormat
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
        /// Gets and sets the property MinBufferTime. Minimum time of initially buffered media
        /// that is needed to ensure smooth playout.
        /// </summary>
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
        /// Gets and sets the property SegmentControl.
        /// </summary>
        public CmafSegmentControl SegmentControl
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
        /// Gets and sets the property SegmentLength. Use this setting to specify the length,
        /// in seconds, of each individual CMAF segment. This value applies to the whole package;
        /// that is, to every output in the output group. Note that segments end on the first
        /// keyframe after this number of seconds, so the actual segment length might be slightly
        /// longer. If you set Segment control (CmafSegmentControl) to single file, the service
        /// puts the content of each output in a single file that has metadata that marks these
        /// segments. If you set it to segmented files, the service creates multiple files for
        /// each output, each with the content of one segment.
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
        /// Gets and sets the property StreamInfResolution.
        /// </summary>
        public CmafStreamInfResolution StreamInfResolution
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
        /// Gets and sets the property WriteDashManifest.
        /// </summary>
        public CmafWriteDASHManifest WriteDashManifest
        {
            get { return this._writeDashManifest; }
            set { this._writeDashManifest = value; }
        }

        // Check to see if WriteDashManifest property is set
        internal bool IsSetWriteDashManifest()
        {
            return this._writeDashManifest != null;
        }

        /// <summary>
        /// Gets and sets the property WriteHlsManifest.
        /// </summary>
        public CmafWriteHLSManifest WriteHlsManifest
        {
            get { return this._writeHlsManifest; }
            set { this._writeHlsManifest = value; }
        }

        // Check to see if WriteHlsManifest property is set
        internal bool IsSetWriteHlsManifest()
        {
            return this._writeHlsManifest != null;
        }

    }
}