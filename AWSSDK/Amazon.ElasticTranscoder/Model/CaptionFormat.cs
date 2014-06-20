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
    /// The file format of the output captions. If you leave this value blank,         Elastic
    /// Transcoder returns an error.
    /// </summary>
    public partial class CaptionFormat
    {
        private string _format;
        private string _pattern;


        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format you specify determines whether Elastic Transcoder generates an        
        /// embedded or sidecar caption for this output.
        /// </para>
        ///       <ul>         <li>
        /// <para>
        /// <b>Valid Embedded Caption Formats:</b>
        /// </para>
        ///             <ul>               <li>
        /// <para>
        /// <b>For MP3</b>: None
        /// </para>
        /// </li>               <li>
        /// <para>
        /// <b>For MP4</b>: mov-text
        /// </para>
        /// </li>               <li>
        /// <para>
        /// <b>For MPEG-TS</b>: None
        /// </para>
        /// </li>               <li>
        /// <para>
        /// <b>For ogg</b>: None
        /// </para>
        /// </li>               <li>
        /// <para>
        /// <b>For webm</b>: None
        /// </para>
        /// </li>            </ul>         </li>         <li>
        /// <para>
        /// <b>Valid Sidecar Caption Formats:</b> Elastic Transcoder            supports dfxp
        /// (first div element only), scc, srt, and webvtt. There are            no container
        /// restrictions on sidecar captions. If you want ttml or smpte-tt            compatible
        /// captions, specify dfxp as your output format.
        /// </para>
        ///          </li>      </ul>
        /// </summary>
        public string Format
        {
            get { return this._format; }
            set { this._format = value; }
        }


        /// <summary>
        /// Sets the Format property
        /// </summary>
        /// <param name="format">The value to set for the Format property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CaptionFormat WithFormat(string format)
        {
            this._format = format;
            return this;
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }


        /// <summary>
        /// Gets and sets the property Pattern. 
        /// <para>
        /// The prefix for caption filenames, in the form <i>description</i>-<code>{language}</code>,
        /// where:
        /// </para>
        ///       <ul>         <li><i>description</i> is a description of the video.</li>    
        ///     <li><code>{language}</code> is a literal value that Elastic Transcoder replaces
        /// with the two- or three-letter            code for the language of the caption in the
        /// output file names.</li>      </ul>      
        /// <para>
        /// If you don't include <code>{language}</code> in the file name pattern, Elastic Transcoder
        /// automatically         appends "<code>{language}</code>" to the value that you specify
        /// for the description.  In addition,         Elastic Transcoder automatically appends
        /// the count to the end of the segment files.
        /// </para>
        ///       
        /// <para>
        /// For example, suppose you're transcoding into srt format. When you enter         "Sydney-{language}-sunrise",
        /// and the language of the captions is English         (en), the name of the first caption
        /// file will be Sydney-en-sunrise00000.srt.
        /// </para>
        /// </summary>
        public string Pattern
        {
            get { return this._pattern; }
            set { this._pattern = value; }
        }


        /// <summary>
        /// Sets the Pattern property
        /// </summary>
        /// <param name="pattern">The value to set for the Pattern property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CaptionFormat WithPattern(string pattern)
        {
            this._pattern = pattern;
            return this;
        }

        // Check to see if Pattern property is set
        internal bool IsSetPattern()
        {
            return this._pattern != null;
        }

    }
}