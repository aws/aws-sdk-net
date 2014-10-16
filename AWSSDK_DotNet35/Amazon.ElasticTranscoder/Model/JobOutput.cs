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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// <important>Outputs recommended instead.</important>If you specified one output for
    /// a job, information about that output. If you specified multiple outputs for a job,
    /// the <code>Output</code> object lists information about the first output. This duplicates
    /// the information that is listed for the first output in the <code>Outputs</code> object.
    /// </summary>
    public partial class JobOutput
    {
        private JobAlbumArt _albumArt;
        private Captions _captions;
        private List<Clip> _composition = new List<Clip>();
        private long? _duration;
        private int? _height;
        private string _id;
        private string _key;
        private string _presetId;
        private string _rotate;
        private string _segmentDuration;
        private string _status;
        private string _statusDetail;
        private string _thumbnailPattern;
        private List<JobWatermark> _watermarks = new List<JobWatermark>();
        private int? _width;

        /// <summary>
        /// Gets and sets the property AlbumArt. 
        /// <para>
        /// The album art to be associated with the output file, if any.
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
        /// <b>Embedded:</b> Embedded captions are included in the same file as the audio and
        /// video. Elastic Transcoder supports only one embedded caption per language, to a maximum
        /// of 300 embedded captions per file.
        /// </para>
        ///  
        /// <para>
        /// Valid input values include: <code>CEA-608 (EIA-608</code>, first non-empty channel
        /// only), <code>CEA-708 (EIA-708</code>, first non-empty channel only), and <code>mov-text</code>
        /// </para>
        ///  
        /// <para>
        /// Valid outputs include: <code>mov-text</code>
        /// </para>
        ///  
        /// <para>
        /// Elastic Transcoder supports a maximum of one embedded format per output.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>Sidecar:</b> Sidecar captions are kept in a separate metadata file from the audio
        /// and video data. Sidecar captions require a player that is capable of understanding
        /// the relationship between the video file and the sidecar file. Elastic Transcoder supports
        /// only one sidecar caption per language, to a maximum of 20 sidecar captions per file.
        /// </para>
        ///  
        /// <para>
        /// Valid input values include: <code>dfxp</code> (first div element only), <code>ebu-tt</code>,
        /// <code>scc</code>, <code>smpt</code>, <code>srt</code>, <code>ttml</code> (first div
        /// element only), and <code>webvtt</code>
        /// </para>
        ///  
        /// <para>
        /// Valid outputs include: <code>dfxp</code> (first div element only), <code>scc</code>,
        /// <code>srt</code>, and <code>webvtt</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If you want ttml or smpte-tt compatible captions, specify dfxp as your output format.
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
        /// To remove captions or leave the captions empty, set <code>Captions</code> to null.
        /// To pass through existing captions unchanged, set the <code>MergePolicy</code> to <code>MergeRetain</code>,
        /// and pass in a null <code>CaptionSources</code> array.
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
        /// </summary>
        public List<Clip> Composition
        {
            get { return this._composition; }
            set { this._composition = value; }
        }

        // Check to see if Composition property is set
        internal bool IsSetComposition()
        {
            return this._composition != null && this._composition.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// Duration of the output file, in seconds.
        /// </para>
        /// </summary>
        public long Duration
        {
            get { return this._duration.GetValueOrDefault(); }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Height. 
        /// <para>
        /// Height of the output file, in pixels.
        /// </para>
        /// </summary>
        public int Height
        {
            get { return this._height.GetValueOrDefault(); }
            set { this._height = value; }
        }

        // Check to see if Height property is set
        internal bool IsSetHeight()
        {
            return this._height.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A sequential counter, starting with 1, that identifies an output among the outputs
        /// from the current job. In the Output syntax, this value is always 1.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        ///  The name to assign to the transcoded file. Elastic Transcoder saves the file in the
        /// Amazon S3 bucket specified by the <code>OutputBucket</code> object in the pipeline
        /// that is specified by the pipeline ID.
        /// </para>
        /// </summary>
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
        /// The value of the <code>Id</code> object for the preset that you want to use for this
        /// job. The preset determines the audio, video, and thumbnail settings that Elastic Transcoder
        /// uses for transcoding. To use a preset that you created, specify the preset ID that
        /// Elastic Transcoder returned in the response when you created the preset. You can also
        /// use the Elastic Transcoder system presets, which you can get with <code>ListPresets</code>.
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
        /// output relative to the input. Enter one of the following values: 
        /// </para>
        ///  
        /// <para>
        /// <code>auto</code>, <code>0</code>, <code>90</code>, <code>180</code>, <code>270</code>
        /// </para>
        ///  
        /// <para>
        ///  The value <code>auto</code> generally works only if the file that you're transcoding
        /// contains rotation metadata.
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
        /// Gets and sets the property SegmentDuration. 
        /// <para>
        /// <important>(Outputs in Fragmented MP4 or MPEG-TS format only.</important>If you specify
        /// a preset in <code>PresetId</code> for which the value of <code>Container</code> is
        /// <code>fmp4</code> (Fragmented MP4) or <code>ts</code> (MPEG-TS), <code>SegmentDuration</code>
        /// is the target maximum duration of each segment in seconds. For <code>HLSv3</code>
        /// format playlists, each media segment is stored in a separate <code>.ts</code> file.
        /// For <code>HLSv4</code> and <code>Smooth</code> playlists, all media segments for an
        /// output are stored in a single file. Each segment is approximately the length of the
        /// <code>SegmentDuration</code>, though individual segments might be shorter or longer.
        /// </para>
        ///  
        /// <para>
        /// The range of valid values is 1 to 60 seconds. If the duration of the video is not
        /// evenly divisible by <code>SegmentDuration</code>, the duration of the last segment
        /// is the remainder of total length/SegmentDuration.
        /// </para>
        ///  
        /// <para>
        /// Elastic Transcoder creates an output-specific playlist for each output <code>HLS</code>
        /// output that you specify in OutputKeys. To add an output to the master playlist for
        /// this job, include it in the <code>OutputKeys</code> of the associated playlist.
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
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of one output in a job. If you specified only one output for the job,
        /// <code>Outputs:Status</code> is always the same as <code>Job:Status</code>. If you
        /// specified more than one output: <ul> <li> <code>Job:Status</code> and <code>Outputs:Status</code>
        /// for all of the outputs is Submitted until Elastic Transcoder starts to process the
        /// first output.</li> <li>When Elastic Transcoder starts to process the first output,
        /// <code>Outputs:Status</code> for that output and <code>Job:Status</code> both change
        /// to Progressing. For each output, the value of <code>Outputs:Status</code> remains
        /// Submitted until Elastic Transcoder starts to process the output.</li> <li>Job:Status
        /// remains Progressing until all of the outputs reach a terminal status, either Complete
        /// or Error.</li> <li>When all of the outputs reach a terminal status, <code>Job:Status</code>
        /// changes to Complete only if <code>Outputs:Status</code> for all of the outputs is
        /// <code>Complete</code>. If <code>Outputs:Status</code> for one or more outputs is <code>Error</code>,
        /// the terminal status for <code>Job:Status</code> is also <code>Error</code>.</li> </ul>
        /// The value of <code>Status</code> is one of the following: <code>Submitted</code>,
        /// <code>Progressing</code>, <code>Complete</code>, <code>Canceled</code>, or <code>Error</code>.
        /// 
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusDetail. 
        /// <para>
        /// Information that further explains <code>Status</code>.
        /// </para>
        /// </summary>
        public string StatusDetail
        {
            get { return this._statusDetail; }
            set { this._statusDetail = value; }
        }

        // Check to see if StatusDetail property is set
        internal bool IsSetStatusDetail()
        {
            return this._statusDetail != null;
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
        ///  If you do want Elastic Transcoder to create thumbnails, specify the information that
        /// you want to include in the file name for each thumbnail. You can specify the following
        /// values in any sequence: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b><code>{count}</code> (Required)</b>: If you want to create thumbnails, you must
        /// include <code>{count}</code> in the <code>ThumbnailPattern</code> object. Wherever
        /// you specify <code>{count}</code>, Elastic Transcoder adds a five-digit sequence number
        /// (beginning with <b>00001</b>) to thumbnail file names. The number indicates where
        /// a given thumbnail appears in the sequence of thumbnails for a transcoded file. 
        /// </para>
        ///  <important>If you specify a literal value and/or <code>{resolution}</code> but you
        /// omit <code>{count}</code>, Elastic Transcoder returns a validation error and does
        /// not create the job.</important> </li> <li> 
        /// <para>
        ///  <b>Literal values (Optional)</b>: You can specify literal values anywhere in the
        /// <code>ThumbnailPattern</code> object. For example, you can include them as a file
        /// name prefix or as a delimiter between <code>{resolution}</code> and <code>{count}</code>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b><code>{resolution}</code> (Optional)</b>: If you want Elastic Transcoder to include
        /// the resolution in the file name, include <code>{resolution}</code> in the <code>ThumbnailPattern</code>
        /// object. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When creating thumbnails, Elastic Transcoder automatically saves the files in the
        /// format (.jpg or .png) that appears in the preset that you specified in the <code>PresetID</code>
        /// value of <code>CreateJobOutput</code>. Elastic Transcoder also appends the applicable
        /// file name extension.
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
        /// for each watermark must be defined in the preset that you specify in <code>Preset</code>
        /// for the current output.
        /// </para>
        ///  
        /// <para>
        /// Watermarks are added to the output video in the sequence in which you list them in
        /// the job output&#x2014;the first watermark in the list is added to the output video
        /// first, the second watermark in the list is added next, and so on. As a result, if
        /// the settings in a preset cause Elastic Transcoder to place all watermarks in the same
        /// location, the second watermark that you add will cover the first one, the third one
        /// will cover the second, and the fourth one will cover the third.
        /// </para>
        /// </summary>
        public List<JobWatermark> Watermarks
        {
            get { return this._watermarks; }
            set { this._watermarks = value; }
        }

        // Check to see if Watermarks property is set
        internal bool IsSetWatermarks()
        {
            return this._watermarks != null && this._watermarks.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Width. 
        /// <para>
        /// Specifies the width of the output file in pixels.
        /// </para>
        /// </summary>
        public int Width
        {
            get { return this._width.GetValueOrDefault(); }
            set { this._width = value; }
        }

        // Check to see if Width property is set
        internal bool IsSetWidth()
        {
            return this._width.HasValue; 
        }

    }
}