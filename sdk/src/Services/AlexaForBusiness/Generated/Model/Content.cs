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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// The content definition. This can contain only one text, SSML, or audio list object.
    /// </summary>
    public partial class Content
    {
        private List<Audio> _audioList = new List<Audio>();
        private List<Ssml> _ssmlList = new List<Ssml>();
        private List<Text> _textList = new List<Text>();

        /// <summary>
        /// Gets and sets the property AudioList. 
        /// <para>
        /// The list of audio messages.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<Audio> AudioList
        {
            get { return this._audioList; }
            set { this._audioList = value; }
        }

        // Check to see if AudioList property is set
        internal bool IsSetAudioList()
        {
            return this._audioList != null && this._audioList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SsmlList. 
        /// <para>
        /// The list of SSML messages.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<Ssml> SsmlList
        {
            get { return this._ssmlList; }
            set { this._ssmlList = value; }
        }

        // Check to see if SsmlList property is set
        internal bool IsSetSsmlList()
        {
            return this._ssmlList != null && this._ssmlList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TextList. 
        /// <para>
        /// The list of text messages.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<Text> TextList
        {
            get { return this._textList; }
            set { this._textList = value; }
        }

        // Check to see if TextList property is set
        internal bool IsSetTextList()
        {
            return this._textList != null && this._textList.Count > 0; 
        }

    }
}