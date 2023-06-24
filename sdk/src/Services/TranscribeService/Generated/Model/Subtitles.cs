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
    /// Generate subtitles for your media file with your transcription request.
    /// 
    ///  
    /// <para>
    /// You can choose a start index of 0 or 1, and you can specify either WebVTT or SubRip
    /// (or both) as your output format.
    /// </para>
    ///  
    /// <para>
    /// Note that your subtitle files are placed in the same location as your transcription
    /// output.
    /// </para>
    /// </summary>
    public partial class Subtitles
    {
        private List<string> _formats = new List<string>();
        private int? _outputStartIndex;

        /// <summary>
        /// Gets and sets the property Formats. 
        /// <para>
        /// Specify the output format for your subtitle file; if you select both WebVTT (<code>vtt</code>)
        /// and SubRip (<code>srt</code>) formats, two output files are generated.
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
        /// Specify the starting value that is assigned to the first subtitle segment.
        /// </para>
        ///  
        /// <para>
        /// The default start index for Amazon Transcribe is <code>0</code>, which differs from
        /// the more widely used standard of <code>1</code>. If you're uncertain which value to
        /// use, we recommend choosing <code>1</code>, as this may improve compatibility with
        /// other services.
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

    }
}