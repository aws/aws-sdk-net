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
    /// The file format of the output captions. If you leave this value blank, Elastic Transcoder
    /// returns an error.
    /// </summary>
    public partial class CaptionFormat
    {
        private Encryption _encryption;
        private string _format;
        private string _pattern;

        /// <summary>
        /// Gets and sets the property Encryption. 
        /// <para>
        /// The encryption settings, if any, that you want Elastic Transcoder to apply to your
        /// caption formats.
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
        /// Gets and sets the property Format. 
        /// <para>
        /// The format you specify determines whether Elastic Transcoder generates an embedded
        /// or sidecar caption for this output.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Valid Embedded Caption Formats:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>for FLAC</b>: None
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>For MP3</b>: None
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>For MP4</b>: mov-text
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>For MPEG-TS</b>: None
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>For ogg</b>: None
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>For webm</b>: None
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b>Valid Sidecar Caption Formats:</b> Elastic Transcoder supports dfxp (first div
        /// element only), scc, srt, and webvtt. If you want ttml or smpte-tt compatible captions,
        /// specify dfxp as your output format.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>For FMP4</b>: dfxp
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Non-FMP4 outputs</b>: All sidecar types
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>fmp4</c> captions have an extension of <c>.ismt</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property Pattern. 
        /// <para>
        /// The prefix for caption filenames, in the form <i>description</i>-<c>{language}</c>,
        /// where:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>description</i> is a description of the video.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>{language}</c> is a literal value that Elastic Transcoder replaces with the two-
        /// or three-letter code for the language of the caption in the output file names.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't include <c>{language}</c> in the file name pattern, Elastic Transcoder
        /// automatically appends "<c>{language}</c>" to the value that you specify for the description.
        /// In addition, Elastic Transcoder automatically appends the count to the end of the
        /// segment files.
        /// </para>
        ///  
        /// <para>
        /// For example, suppose you're transcoding into srt format. When you enter "Sydney-{language}-sunrise",
        /// and the language of the captions is English (en), the name of the first caption file
        /// is be Sydney-en-sunrise00000.srt.
        /// </para>
        /// </summary>
        public string Pattern
        {
            get { return this._pattern; }
            set { this._pattern = value; }
        }

        // Check to see if Pattern property is set
        internal bool IsSetPattern()
        {
            return this._pattern != null;
        }

    }
}