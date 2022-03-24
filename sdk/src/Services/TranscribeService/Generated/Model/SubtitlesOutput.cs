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
    /// The S3 location where your subtitle files are located. Note that your subtitle files
    /// are placed in the same location as your transcription output. Refer to <code>TranscriptFileUri</code>
    /// to download your files.
    /// </summary>
    public partial class SubtitlesOutput
    {
        private List<string> _formats = new List<string>();
        private int? _outputStartIndex;
        private List<string> _subtitleFileUris = new List<string>();

        /// <summary>
        /// Gets and sets the property Formats. 
        /// <para>
        /// The format of your subtitle files. If your request specified both <code>srt</code>
        /// and <code>vtt</code> formats, both formats are shown.
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
        /// Shows the output start index value for your subtitle files. If you did not specify
        /// a value in your request, the default value of <code>0</code> is used.
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
        /// Contains the output location for your subtitle file. This location must be an S3 bucket.
        /// </para>
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