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
    /// Use Only for MPEG-TS Outputs. If you specify a preset for which the value of Container
    ///            is <code>ts</code> (MPEG-TS), Playlists contains information about the
    /// master playlists            that you want Elastic Transcoder to create. We recommend
    /// that you create only one master            playlist. The maximum number of master
    /// playlists in a job is 30.
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
        /// This value must currently be <code>HLSv3</code>.
        /// </para>
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
        public Playlist WithFormat(string format)
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name that you want Elastic Transcoder to assign to the master playlist, for example,
        ///            nyc-vacation.m3u8. The name cannot include a / character. If you create
        /// more than one            master playlist (not recommended), the values of all <code>Name</code>
        /// objects must be            unique. <b>Note</b>: Elastic Transcoder automatically appends
        /// .m3u8 to the file name. If you include            .m3u8 in <code>Name</code>, it will
        /// appear twice in the file name.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }


        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Playlist WithName(string name)
        {
            this._name = name;
            return this;
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
        /// of            the Outputs:Key object. If you include more than one output in a playlist,
        /// the value of                <code>SegmentDuration</code> for all of the outputs must
        /// be the same.
        /// </para>
        /// </summary>
        public List<string> OutputKeys
        {
            get { return this._outputKeys; }
            set { this._outputKeys = value; }
        }

        /// <summary>
        /// Sets the OutputKeys property
        /// </summary>
        /// <param name="outputKeys">The values to add to the OutputKeys collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Playlist WithOutputKeys(params string[] outputKeys)
        {
            foreach (var element in outputKeys)
            {
                this._outputKeys.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the OutputKeys property
        /// </summary>
        /// <param name="outputKeys">The values to add to the OutputKeys collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Playlist WithOutputKeys(IEnumerable<string> outputKeys)
        {
            foreach (var element in outputKeys)
            {
                this._outputKeys.Add(element);
            }
            return this;
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


        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Playlist WithStatus(string status)
        {
            this._status = status;
            return this;
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


        /// <summary>
        /// Sets the StatusDetail property
        /// </summary>
        /// <param name="statusDetail">The value to set for the StatusDetail property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Playlist WithStatusDetail(string statusDetail)
        {
            this._statusDetail = statusDetail;
            return this;
        }

        // Check to see if StatusDetail property is set
        internal bool IsSetStatusDetail()
        {
            return this._statusDetail != null;
        }

    }
}