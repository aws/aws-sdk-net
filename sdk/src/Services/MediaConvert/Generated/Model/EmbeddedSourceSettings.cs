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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings for embedded captions Source
    /// </summary>
    public partial class EmbeddedSourceSettings
    {
        private EmbeddedConvert608To708 _convert608To708;
        private int? _source608ChannelNumber;
        private int? _source608TrackNumber;

        /// <summary>
        /// Gets and sets the property Convert608To708.
        /// </summary>
        public EmbeddedConvert608To708 Convert608To708
        {
            get { return this._convert608To708; }
            set { this._convert608To708 = value; }
        }

        // Check to see if Convert608To708 property is set
        internal bool IsSetConvert608To708()
        {
            return this._convert608To708 != null;
        }

        /// <summary>
        /// Gets and sets the property Source608ChannelNumber. Specifies the 608/708 channel number
        /// within the video track from which to extract captions. Unused for passthrough.
        /// </summary>
        public int Source608ChannelNumber
        {
            get { return this._source608ChannelNumber.GetValueOrDefault(); }
            set { this._source608ChannelNumber = value; }
        }

        // Check to see if Source608ChannelNumber property is set
        internal bool IsSetSource608ChannelNumber()
        {
            return this._source608ChannelNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Source608TrackNumber. Specifies the video track index used
        /// for extracting captions. The system only supports one input video track, so this should
        /// always be set to '1'.
        /// </summary>
        public int Source608TrackNumber
        {
            get { return this._source608TrackNumber.GetValueOrDefault(); }
            set { this._source608TrackNumber = value; }
        }

        // Check to see if Source608TrackNumber property is set
        internal bool IsSetSource608TrackNumber()
        {
            return this._source608TrackNumber.HasValue; 
        }

    }
}