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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Polly.Model
{
    /// <summary>
    /// This is the response object from the SynthesizeSpeech operation.
    /// </summary>
    public partial class SynthesizeSpeechResponse : AmazonWebServiceResponse, IDisposable
    {
        /// <summary>
        /// Gets and sets the property AudioStream. 
        /// <para>
        ///  Stream containing the synthesized speech. 
        /// </para>
        /// </summary>
        public Stream AudioStream { get; set; }

        /// <summary>
        /// Checks to see if the AudioStream property is set.
        /// </summary>
        internal bool IsSetAudioStream() => this.AudioStream != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        ///  Specifies the type audio stream. This should reflect the <c>OutputFormat</c> parameter
        /// in your request. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  If you request <c>mp3</c> as the <c>OutputFormat</c>, the <c>ContentType</c> returned
        /// is audio/mpeg. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you request <c>ogg_vorbis</c> as the <c>OutputFormat</c>, the <c>ContentType</c>
        /// returned is audio/ogg. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you request <c>ogg_opus</c> as the <c>OutputFormat</c>, the <c>ContentType</c>
        /// returned is audio/ogg. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you request <c>pcm</c> as the <c>OutputFormat</c>, the <c>ContentType</c> returned
        /// is audio/pcm in a signed 16-bit, 1 channel (mono), little-endian format. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you request <c>mu-law</c> as the <c>OutputFormat</c>, the <c>ContentType</c> returned
        /// is audio/mulaw. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you request <c>a-law</c> as the <c>OutputFormat</c>, the <c>ContentType</c> returned
        /// is audio/alaw. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you request <c>json</c> as the <c>OutputFormat</c>, the <c>ContentType</c> returned
        /// is application/x-json-stream.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  
        /// </para>
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property RequestCharacters. 
        /// <para>
        /// Number of characters synthesized.
        /// </para>
        /// </summary>
        public int? RequestCharacters { get; set; }

        /// <summary>
        /// Checks to see if the RequestCharacters property is set.
        /// </summary>
        internal bool IsSetRequestCharacters() => this.RequestCharacters.HasValue;

        #region Dispose Pattern

        private bool _disposed;

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                this.AudioStream?.Dispose();
                this.AudioStream = null;
            }

            this._disposed = true;
        }

        #endregion
    }
}
