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
    /// Use Only for Fragmented MP4 or MPEG-TS Outputs. If you specify a preset for which
    /// the value of Container is <code>fmp4</code> (Fragmented MP4) or <code>ts</code> (MPEG-TS),
    /// Playlists contains information about the master playlists that you want Elastic Transcoder
    /// to create. We recommend that you create only one master playlist per output format.
    /// The maximum number of master playlists in a job is 30.
    /// </summary>
    public partial class Playlist
    {
        private string _format;
        private string _name;
        private List<string> _outputKeys = new List<string>();
        private string _status;
        private string _statusDetail;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the output playlist. Valid formats include <code>HLSv3</code>, <code>HLSv4</code>,
        /// and <code>Smooth</code>.
        /// </para>
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name that you want Elastic Transcoder to assign to the master playlist, for example,
        /// nyc-vacation.m3u8. If the name includes a <code>/</code> character, the section of
        /// the name before the last <code>/</code> must be identical for all <code>Name</code>
        /// objects. If you create more than one master playlist, the values of all <code>Name</code>
        /// objects must be unique.
        /// </para>
        ///  
        /// <para>
        /// <b>Note</b>: Elastic Transcoder automatically appends the relevant file extension
        /// to the file name (<code>.m3u8</code> for <code>HLSv3</code> and <code>HLSv4</code>
        /// playlists, and <code>.ism</code> and <code>.ismc</code> for <code>Smooth</code> playlists).
        /// If you include a file extension in <code>Name</code>, the file name will have two
        /// extensions.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OutputKeys. 
        /// <para>
        /// For each output in this job that you want to include in a master playlist, the value
        /// of the Outputs:Key object.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If your output is not <code>HLS</code> or does not have a segment duration set, the
        /// name of the output file is a concatenation of <code>OutputKeyPrefix</code> and <code>Outputs:Key</code>:
        /// </para>
        ///  
        /// <para>
        /// OutputKeyPrefix<code>Outputs:Key</code>
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your output is <code>HLSv3</code> and has a segment duration set, or is not included
        /// in a playlist, Elastic Transcoder creates an output playlist file with a file extension
        /// of <code>.m3u8</code>, and a series of <code>.ts</code> files that include a five-digit
        /// sequential counter beginning with 00000:
        /// </para>
        ///  
        /// <para>
        /// OutputKeyPrefix<code>Outputs:Key</code>.m3u8
        /// </para>
        ///  
        /// <para>
        /// OutputKeyPrefix<code>Outputs:Key</code>00000.ts
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your output is <code>HLSv4</code>, has a segment duration set, and is included
        /// in an <code>HLSv4</code> playlist, Elastic Transcoder creates an output playlist file
        /// with a file extension of <code>_v4.m3u8</code>. If the output is video, Elastic Transcoder
        /// also creates an output file with an extension of <code>_iframe.m3u8</code>:
        /// </para>
        ///  
        /// <para>
        /// OutputKeyPrefix<code>Outputs:Key</code>_v4.m3u8
        /// </para>
        ///  
        /// <para>
        /// OutputKeyPrefix<code>Outputs:Key</code>_iframe.m3u8
        /// </para>
        ///  
        /// <para>
        /// OutputKeyPrefix<code>Outputs:Key</code>.ts
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Elastic Transcoder automatically appends the relevant file extension to the file name.
        /// If you include a file extension in Output Key, the file name will have two extensions.
        /// </para>
        ///  
        /// <para>
        /// If you include more than one output in a playlist, any segment duration settings,
        /// clip settings, or caption settings must be the same for all outputs in the playlist.
        /// For <code>Smooth</code> playlists, the <code>Audio:Profile</code>, <code>Video:Profile</code>,
        /// and <code>Video:FrameRate</code> to <code>Video:KeyframesMaxDist</code> ratio must
        /// be the same for all outputs.
        /// </para>
        /// </summary>
        public List<string> OutputKeys
        {
            get { return this._outputKeys; }
            set { this._outputKeys = value; }
        }

        // Check to see if OutputKeys property is set
        internal bool IsSetOutputKeys()
        {
            return this._outputKeys != null && this._outputKeys.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the job with which the playlist is associated.
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
        /// Information that further explains the status.
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

    }
}