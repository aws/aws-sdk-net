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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Provides information about your subtitle file, including format, start index, and
    /// Amazon S3 location.
    /// </summary>
    public partial class SubtitlesOutput
    {
        private List<string> _formats = new List<string>();
        private int? _outputStartIndex;
        private List<string> _subtitleFileUris = new List<string>();

        /// <summary>
        /// Gets and sets the property Formats. 
        /// <para>
        /// Provides the format of your subtitle files. If your request included both WebVTT (<code>vtt</code>)
        /// and SubRip (<code>srt</code>) formats, both formats are shown.
        /// </para>
        /// </summary>
        public List<string> Formats
        {
            get { return this._formats; }
            set { this._formats = value; }
        }

        // Check to see if Formats property is set
        internal bool IsSetFormats()
        {
            return this._formats != null && this._formats.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OutputStartIndex. 
        /// <para>
        /// Provides the start index value for your subtitle files. If you did not specify a value
        /// in your request, the default value of <code>0</code> is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public int OutputStartIndex
        {
            get { return this._outputStartIndex.GetValueOrDefault(); }
            set { this._outputStartIndex = value; }
        }

        // Check to see if OutputStartIndex property is set
        internal bool IsSetOutputStartIndex()
        {
            return this._outputStartIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubtitleFileUris. 
        /// <para>
        /// The Amazon S3 location of your transcript. You can use this URI to access or download
        /// your subtitle file. Your subtitle file is stored in the same location as your transcript.
        /// If you specified both WebVTT and SubRip subtitle formats, two URIs are provided.
        /// </para>
        ///  
        /// <para>
        /// If you included <code>OutputBucketName</code> in your transcription job request, this
        /// is the URI of that bucket. If you also included <code>OutputKey</code> in your request,
        /// your output is located in the path you specified in your request.
        /// </para>
        ///  
        /// <para>
        /// If you didn't include <code>OutputBucketName</code> in your transcription job request,
        /// your subtitle file is stored in a service-managed bucket, and <code>TranscriptFileUri</code>
        /// provides you with a temporary URI you can use for secure access to your subtitle file.
        /// </para>
        ///  <note> 
        /// <para>
        /// Temporary URIs for service-managed Amazon S3 buckets are only valid for 15 minutes.
        /// If you get an <code>AccesDenied</code> error, you can get a new temporary URI by running
        /// a <code>GetTranscriptionJob</code> or <code>ListTranscriptionJob</code> request.
        /// </para>
        ///  </note>
        /// </summary>
        public List<string> SubtitleFileUris
        {
            get { return this._subtitleFileUris; }
            set { this._subtitleFileUris = value; }
        }

        // Check to see if SubtitleFileUris property is set
        internal bool IsSetSubtitleFileUris()
        {
            return this._subtitleFileUris != null && this._subtitleFileUris.Count > 0; 
        }

    }
}