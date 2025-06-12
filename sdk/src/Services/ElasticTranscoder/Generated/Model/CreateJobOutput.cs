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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
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
namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// The <c>CreateJobOutput</c> structure.
    /// </summary>
    public partial class CreateJobOutput
    {
        private JobAlbumArt _albumArt;
        private Captions _captions;
        private List<Clip> _composition = AWSConfigs.InitializeCollections ? new List<Clip>() : null;
        private Encryption _encryption;
        private string _key;
        private string _presetId;
        private string _rotate;
        private string _segmentDuration;
        private Encryption _thumbnailEncryption;
        private string _thumbnailPattern;
        private List<JobWatermark> _watermarks = AWSConfigs.InitializeCollections ? new List<JobWatermark>() : null;

        /// <summary>
        /// Gets and sets the property AlbumArt. 
        /// <para>
        /// Information about the album art that you want Elastic Transcoder to add to the file
        /// during transcoding. You can specify up to twenty album artworks for each output. Settings
        /// for each artwork must be defined in the job for the current output.
        /// </para>
        /// </summary>
        public JobAlbumArt AlbumArt
        {
            get { return this._albumArt; }
            set { this._albumArt = value; }
        }

        // Check to see if AlbumArt property is set
        internal bool IsSetAlbumArt()
        {
            return this._albumArt != null;
        }

        /// <summary>
        /// Gets and sets the property Captions. 
        /// <para>
        /// You can configure Elastic Transcoder to transcode captions, or subtitles, from one
        /// format to another. All captions must be in UTF-8. Elastic Transcoder supports two
        /// types of captions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Embedded:</b> Embedded captions are included in the same file as the audio and
        /// video. Elastic Transcoder supports only one embedded caption per language, to a maximum
        /// of 300 embedded captions per file.
        /// </para>
        ///  
        /// <para>
        /// Valid input values include: <c>CEA-608 (EIA-608</c>, first non-empty channel only),
        /// <c>CEA-708 (EIA-708</c>, first non-empty channel only), and <c>mov-text</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid outputs include: <c>mov-text</c> 
        /// </para>
        ///  
        /// <para>
        /// Elastic Transcoder supports a maximum of one embedded format per output.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Sidecar:</b> Sidecar captions are kept in a separate metadata file from the audio
        /// and video data. Sidecar captions require a player that is capable of understanding
        /// the relationship between the video file and the sidecar file. Elastic Transcoder supports
        /// only one sidecar caption per language, to a maximum of 20 sidecar captions per file.
        /// </para>
        ///  
        /// <para>
        /// Valid input values include: <c>dfxp</c> (first div element only), <c>ebu-tt</c>, <c>scc</c>,
        /// <c>smpt</c>, <c>srt</c>, <c>ttml</c> (first div element only), and <c>webvtt</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid outputs include: <c>dfxp</c> (first div element only), <c>scc</c>, <c>srt</c>,
        /// and <c>webvtt</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you want ttml or smpte-tt compatible captions, specify dfxp as your output format.
        /// </para>
        ///  
        /// <para>
        /// Elastic Transcoder does not support OCR (Optical Character Recognition), does not
        /// accept pictures as a valid input for captions, and is not available for audio-only
        /// transcoding. Elastic Transcoder does not preserve text formatting (for example, italics)
        /// during the transcoding process.
        /// </para>
        ///  
        /// <para>
        /// To remove captions or leave the captions empty, set <c>Captions</c> to null. To pass
        /// through existing captions unchanged, set the <c>MergePolicy</c> to <c>MergeRetain</c>,
        /// and pass in a null <c>CaptionSources</c> array.
        /// </para>
        ///  
        /// <para>
        /// For more information on embedded files, see the Subtitles Wikipedia page.
        /// </para>
        ///  
        /// <para>
        /// For more information on sidecar files, see the Extensible Metadata Platform and Sidecar
        /// file Wikipedia pages.
        /// </para>
        /// </summary>
        public Captions Captions
        {
            get { return this._captions; }
            set { this._captions = value; }
        }

        // Check to see if Captions property is set
        internal bool IsSetCaptions()
        {
            return this._captions != null;
        }

        /// <summary>
        /// Gets and sets the property Composition. 
        /// <para>
        /// You can create an output file that contains an excerpt from the input file. This excerpt,
        /// called a clip, can come from the beginning, middle, or end of the file. The Composition
        /// object contains settings for the clips that make up an output file. For the current
        /// release, you can only specify settings for a single clip per output file. The Composition
        /// object cannot be null.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("This property is deprecated")]
        public List<Clip> Composition
        {
            get { return this._composition; }
            set { this._composition = value; }
        }

        // Check to see if Composition property is set
        internal bool IsSetComposition()
        {
            return this._composition != null && (this._composition.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Encryption. 
        /// <para>
        /// You can specify encryption settings for any output files that you want to use for
        /// a transcoding job. This includes the output file and any watermarks, thumbnails, album
        /// art, or captions that you want to use. You must specify encryption settings for each
        /// file individually.
        /// </para>
        /// </summary>
        public Encryption Encryption
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
        /// Gets and sets the property Key. 
        /// <para>
        ///  The name to assign to the transcoded file. Elastic Transcoder saves the file in the
        /// Amazon S3 bucket specified by the <c>OutputBucket</c> object in the pipeline that
        /// is specified by the pipeline ID. If a file with the specified name already exists
        /// in the output bucket, the job fails. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property PresetId. 
        /// <para>
        ///  The <c>Id</c> of the preset to use for this job. The preset determines the audio,
        /// video, and thumbnail settings that Elastic Transcoder uses for transcoding. 
        /// </para>
        /// </summary>
        public string PresetId
        {
            get { return this._presetId; }
            set { this._presetId = value; }
        }

        // Check to see if PresetId property is set
        internal bool IsSetPresetId()
        {
            return this._presetId != null;
        }

        /// <summary>
        /// Gets and sets the property Rotate. 
        /// <para>
        ///  The number of degrees clockwise by which you want Elastic Transcoder to rotate the
        /// output relative to the input. Enter one of the following values: <c>auto</c>, <c>0</c>,
        /// <c>90</c>, <c>180</c>, <c>270</c>. The value <c>auto</c> generally works only if the
        /// file that you're transcoding contains rotation metadata. 
        /// </para>
        /// </summary>
        public string Rotate
        {
            get { return this._rotate; }
            set { this._rotate = value; }
        }

        // Check to see if Rotate property is set
        internal bool IsSetRotate()
        {
            return this._rotate != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentDuration. <important> 
        /// <para>
        /// (Outputs in Fragmented MP4 or MPEG-TS format only.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you specify a preset in <c>PresetId</c> for which the value of <c>Container</c>
        /// is <c>fmp4</c> (Fragmented MP4) or <c>ts</c> (MPEG-TS), <c>SegmentDuration</c> is
        /// the target maximum duration of each segment in seconds. For <c>HLSv3</c> format playlists,
        /// each media segment is stored in a separate <c>.ts</c> file. For <c>HLSv4</c> and <c>Smooth</c>
        /// playlists, all media segments for an output are stored in a single file. Each segment
        /// is approximately the length of the <c>SegmentDuration</c>, though individual segments
        /// might be shorter or longer.
        /// </para>
        ///  
        /// <para>
        /// The range of valid values is 1 to 60 seconds. If the duration of the video is not
        /// evenly divisible by <c>SegmentDuration</c>, the duration of the last segment is the
        /// remainder of total length/SegmentDuration.
        /// </para>
        ///  
        /// <para>
        /// Elastic Transcoder creates an output-specific playlist for each output <c>HLS</c>
        /// output that you specify in OutputKeys. To add an output to the master playlist for
        /// this job, include it in the <c>OutputKeys</c> of the associated playlist.
        /// </para>
        /// </summary>
        public string SegmentDuration
        {
            get { return this._segmentDuration; }
            set { this._segmentDuration = value; }
        }

        // Check to see if SegmentDuration property is set
        internal bool IsSetSegmentDuration()
        {
            return this._segmentDuration != null;
        }

        /// <summary>
        /// Gets and sets the property ThumbnailEncryption. 
        /// <para>
        /// The encryption settings, if any, that you want Elastic Transcoder to apply to your
        /// thumbnail.
        /// </para>
        /// </summary>
        public Encryption ThumbnailEncryption
        {
            get { return this._thumbnailEncryption; }
            set { this._thumbnailEncryption = value; }
        }

        // Check to see if ThumbnailEncryption property is set
        internal bool IsSetThumbnailEncryption()
        {
            return this._thumbnailEncryption != null;
        }

        /// <summary>
        /// Gets and sets the property ThumbnailPattern. 
        /// <para>
        /// Whether you want Elastic Transcoder to create thumbnails for your videos and, if so,
        /// how you want Elastic Transcoder to name the files.
        /// </para>
        ///  
        /// <para>
        /// If you don't want Elastic Transcoder to create thumbnails, specify "".
        /// </para>
        ///  
        /// <para>
        /// If you do want Elastic Transcoder to create thumbnails, specify the information that
        /// you want to include in the file name for each thumbnail. You can specify the following
        /// values in any sequence:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>{count}</c> (Required)</b>: If you want to create thumbnails, you must include
        /// <c>{count}</c> in the <c>ThumbnailPattern</c> object. Wherever you specify <c>{count}</c>,
        /// Elastic Transcoder adds a five-digit sequence number (beginning with <b>00001</b>)
        /// to thumbnail file names. The number indicates where a given thumbnail appears in the
        /// sequence of thumbnails for a transcoded file. 
        /// </para>
        ///  <important> 
        /// <para>
        /// If you specify a literal value and/or <c>{resolution}</c> but you omit <c>{count}</c>,
        /// Elastic Transcoder returns a validation error and does not create the job.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        ///  <b>Literal values (Optional)</b>: You can specify literal values anywhere in the
        /// <c>ThumbnailPattern</c> object. For example, you can include them as a file name prefix
        /// or as a delimiter between <c>{resolution}</c> and <c>{count}</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>{resolution}</c> (Optional)</b>: If you want Elastic Transcoder to include
        /// the resolution in the file name, include <c>{resolution}</c> in the <c>ThumbnailPattern</c>
        /// object. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When creating thumbnails, Elastic Transcoder automatically saves the files in the
        /// format (.jpg or .png) that appears in the preset that you specified in the <c>PresetID</c>
        /// value of <c>CreateJobOutput</c>. Elastic Transcoder also appends the applicable file
        /// name extension.
        /// </para>
        /// </summary>
        public string ThumbnailPattern
        {
            get { return this._thumbnailPattern; }
            set { this._thumbnailPattern = value; }
        }

        // Check to see if ThumbnailPattern property is set
        internal bool IsSetThumbnailPattern()
        {
            return this._thumbnailPattern != null;
        }

        /// <summary>
        /// Gets and sets the property Watermarks. 
        /// <para>
        /// Information about the watermarks that you want Elastic Transcoder to add to the video
        /// during transcoding. You can specify up to four watermarks for each output. Settings
        /// for each watermark must be defined in the preset for the current output.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<JobWatermark> Watermarks
        {
            get { return this._watermarks; }
            set { this._watermarks = value; }
        }

        // Check to see if Watermarks property is set
        internal bool IsSetWatermarks()
        {
            return this._watermarks != null && (this._watermarks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}