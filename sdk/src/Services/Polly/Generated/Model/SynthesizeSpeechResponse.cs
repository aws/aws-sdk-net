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
 * Do not modify this file. This file is generated from the polly-2016-06-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Polly.Model
{
    /// <summary>
    /// This is the response object from the SynthesizeSpeech operation.
    /// </summary>
    public partial class SynthesizeSpeechResponse : AmazonWebServiceResponse
    {
        private Stream _audioStream;
        private string _contentType;
        private int? _requestCharacters;

        /// <summary>
        /// Gets and sets the property AudioStream. 
        /// <para>
        ///  Stream containing the synthesized speech. 
        /// </para>
        /// </summary>
        public Stream AudioStream
        {
            get { return this._audioStream; }
            set { this._audioStream = value; }
        }

        // Check to see if AudioStream property is set
        internal bool IsSetAudioStream()
        {
            return this._audioStream != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        ///  Specifies the type audio stream. This should reflect the <code>OutputFormat</code>
        /// parameter in your request. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  If you request <code>mp3</code> as the <code>OutputFormat</code>, the <code>ContentType</code>
        /// returned is audio/mpeg. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you request <code>ogg_vorbis</code> as the <code>OutputFormat</code>, the <code>ContentType</code>
        /// returned is audio/ogg. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you request <code>pcm</code> as the <code>OutputFormat</code>, the <code>ContentType</code>
        /// returned is audio/pcm in a signed 16-bit, 1 channel (mono), little-endian format.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  
        /// </para>
        /// </summary>
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property RequestCharacters. 
        /// <para>
        /// Number of characters synthesized.
        /// </para>
        /// </summary>
        public int RequestCharacters
        {
            get { return this._requestCharacters.GetValueOrDefault(); }
            set { this._requestCharacters = value; }
        }

        // Check to see if RequestCharacters property is set
        internal bool IsSetRequestCharacters()
        {
            return this._requestCharacters.HasValue; 
        }

    }
}