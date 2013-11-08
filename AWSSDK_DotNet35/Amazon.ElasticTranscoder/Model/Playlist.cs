/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// <para> Use Only for MPEG-TS Outputs. If you specify a preset for which the value of Container is <c>ts</c> (MPEG-TS), Playlists contains
    /// information about the master playlists that you want Elastic Transcoder to create. We recommend that you create only one master playlist.
    /// The maximum number of master playlists in a job is 30. </para>
    /// </summary>
    public class Playlist
    {
        
        private string name;
        private string format;
        private List<string> outputKeys = new List<string>();
        private string status;
        private string statusDetail;


        /// <summary>
        /// The name that you want Elastic Transcoder to assign to the master playlist, for example, nyc-vacation.m3u8. The name cannot include a /
        /// character. If you create more than one master playlist (not recommended), the values of all <c>Name</c> objects must be unique. <b>Note</b>:
        /// Elastic Transcoder automatically appends .m3u8 to the file name. If you include .m3u8 in <c>Name</c>, it will appear twice in the file name.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// This value must currently be <c>HLSv3</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^HLSv3$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Format
        {
            get { return this.format; }
            set { this.format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this.format != null;
        }

        /// <summary>
        /// For each output in this job that you want to include in a master playlist, the value of the Outputs:Key object. If you include more than one
        /// output in a playlist, the value of <c>SegmentDuration</c> for all of the outputs must be the same.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 30</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<string> OutputKeys
        {
            get { return this.outputKeys; }
            set { this.outputKeys = value; }
        }

        // Check to see if OutputKeys property is set
        internal bool IsSetOutputKeys()
        {
            return this.outputKeys.Count > 0;
        }

        /// <summary>
        /// The status of the job with which the playlist is associated.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^Submitted$)|(^Progressing$)|(^Complete$)|(^Canceled$)|(^Error$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// Information that further explains the status.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string StatusDetail
        {
            get { return this.statusDetail; }
            set { this.statusDetail = value; }
        }

        // Check to see if StatusDetail property is set
        internal bool IsSetStatusDetail()
        {
            return this.statusDetail != null;
        }
    }
}
