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
    /// Information about the file that you're transcoding.
    /// </summary>
    public partial class JobInput
    {
        private string _aspectRatio;
        private string _container;
        private DetectedProperties _detectedProperties;
        private Encryption _encryption;
        private string _frameRate;
        private InputCaptions _inputCaptions;
        private string _interlaced;
        private string _key;
        private string _resolution;
        private TimeSpan _timeSpan;

        /// <summary>
        /// Gets and sets the property AspectRatio. 
        /// <para>
        ///  The aspect ratio of the input file. If you want Elastic Transcoder to automatically
        /// detect the aspect ratio of the input file, specify <c>auto</c>. If you want to specify
        /// the aspect ratio for the output file, enter one of the following values: 
        /// </para>
        ///  
        /// <para>
        ///  <c>1:1</c>, <c>4:3</c>, <c>3:2</c>, <c>16:9</c> 
        /// </para>
        ///  
        /// <para>
        ///  If you specify a value other than <c>auto</c>, Elastic Transcoder disables automatic
        /// detection of the aspect ratio. 
        /// </para>
        /// </summary>
        public string AspectRatio
        {
            get { return this._aspectRatio; }
            set { this._aspectRatio = value; }
        }

        // Check to see if AspectRatio property is set
        internal bool IsSetAspectRatio()
        {
            return this._aspectRatio != null;
        }

        /// <summary>
        /// Gets and sets the property Container. 
        /// <para>
        /// The container type for the input file. If you want Elastic Transcoder to automatically
        /// detect the container type of the input file, specify <c>auto</c>. If you want to specify
        /// the container type for the input file, enter one of the following values: 
        /// </para>
        ///  
        /// <para>
        ///  <c>3gp</c>, <c>aac</c>, <c>asf</c>, <c>avi</c>, <c>divx</c>, <c>flv</c>, <c>m4a</c>,
        /// <c>mkv</c>, <c>mov</c>, <c>mp3</c>, <c>mp4</c>, <c>mpeg</c>, <c>mpeg-ps</c>, <c>mpeg-ts</c>,
        /// <c>mxf</c>, <c>ogg</c>, <c>vob</c>, <c>wav</c>, <c>webm</c> 
        /// </para>
        /// </summary>
        public string Container
        {
            get { return this._container; }
            set { this._container = value; }
        }

        // Check to see if Container property is set
        internal bool IsSetContainer()
        {
            return this._container != null;
        }

        /// <summary>
        /// Gets and sets the property DetectedProperties. 
        /// <para>
        /// The detected properties of the input file.
        /// </para>
        /// </summary>
        public DetectedProperties DetectedProperties
        {
            get { return this._detectedProperties; }
            set { this._detectedProperties = value; }
        }

        // Check to see if DetectedProperties property is set
        internal bool IsSetDetectedProperties()
        {
            return this._detectedProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Encryption. 
        /// <para>
        /// The encryption settings, if any, that are used for decrypting your input files. If
        /// your input file is encrypted, you must specify the mode that Elastic Transcoder uses
        /// to decrypt your file.
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
        /// Gets and sets the property FrameRate. 
        /// <para>
        /// The frame rate of the input file. If you want Elastic Transcoder to automatically
        /// detect the frame rate of the input file, specify <c>auto</c>. If you want to specify
        /// the frame rate for the input file, enter one of the following values: 
        /// </para>
        ///  
        /// <para>
        ///  <c>10</c>, <c>15</c>, <c>23.97</c>, <c>24</c>, <c>25</c>, <c>29.97</c>, <c>30</c>,
        /// <c>60</c> 
        /// </para>
        ///  
        /// <para>
        /// If you specify a value other than <c>auto</c>, Elastic Transcoder disables automatic
        /// detection of the frame rate.
        /// </para>
        /// </summary>
        public string FrameRate
        {
            get { return this._frameRate; }
            set { this._frameRate = value; }
        }

        // Check to see if FrameRate property is set
        internal bool IsSetFrameRate()
        {
            return this._frameRate != null;
        }

        /// <summary>
        /// Gets and sets the property InputCaptions. 
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
        public InputCaptions InputCaptions
        {
            get { return this._inputCaptions; }
            set { this._inputCaptions = value; }
        }

        // Check to see if InputCaptions property is set
        internal bool IsSetInputCaptions()
        {
            return this._inputCaptions != null;
        }

        /// <summary>
        /// Gets and sets the property Interlaced. 
        /// <para>
        /// Whether the input file is interlaced. If you want Elastic Transcoder to automatically
        /// detect whether the input file is interlaced, specify <c>auto</c>. If you want to specify
        /// whether the input file is interlaced, enter one of the following values:
        /// </para>
        ///  
        /// <para>
        ///  <c>true</c>, <c>false</c> 
        /// </para>
        ///  
        /// <para>
        /// If you specify a value other than <c>auto</c>, Elastic Transcoder disables automatic
        /// detection of interlacing.
        /// </para>
        /// </summary>
        public string Interlaced
        {
            get { return this._interlaced; }
            set { this._interlaced = value; }
        }

        // Check to see if Interlaced property is set
        internal bool IsSetInterlaced()
        {
            return this._interlaced != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        ///  The name of the file to transcode. Elsewhere in the body of the JSON block is the
        /// the ID of the pipeline to use for processing the job. The <c>InputBucket</c> object
        /// in that pipeline tells Elastic Transcoder which Amazon S3 bucket to get the file from.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If the file name includes a prefix, such as <c>cooking/lasagna.mpg</c>, include the
        /// prefix in the key. If the file isn't in the specified bucket, Elastic Transcoder returns
        /// an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property Resolution. 
        /// <para>
        /// This value must be <c>auto</c>, which causes Elastic Transcoder to automatically detect
        /// the resolution of the input file.
        /// </para>
        /// </summary>
        public string Resolution
        {
            get { return this._resolution; }
            set { this._resolution = value; }
        }

        // Check to see if Resolution property is set
        internal bool IsSetResolution()
        {
            return this._resolution != null;
        }

        /// <summary>
        /// Gets and sets the property TimeSpan. 
        /// <para>
        /// Settings for clipping an input. Each input can have different clip settings.
        /// </para>
        /// </summary>
        public TimeSpan TimeSpan
        {
            get { return this._timeSpan; }
            set { this._timeSpan = value; }
        }

        // Check to see if TimeSpan property is set
        internal bool IsSetTimeSpan()
        {
            return this._timeSpan != null;
        }

    }
}