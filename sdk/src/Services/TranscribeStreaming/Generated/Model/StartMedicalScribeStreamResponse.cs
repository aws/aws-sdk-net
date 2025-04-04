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
 * Do not modify this file. This file is generated from the transcribe-streaming-2017-10-26.normal.json service model.
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
namespace Amazon.TranscribeStreaming.Model
{
    /// <summary>
    /// This is the response object from the StartMedicalScribeStream operation.
    /// </summary>
    public partial class StartMedicalScribeStreamResponse : AmazonWebServiceResponse, Amazon.Runtime.EventStreams.IEventInputStreamContextOwner, IDisposable
    {
        private MedicalScribeLanguageCode _languageCode;
        private MedicalScribeMediaEncoding _mediaEncoding;
        private int? _mediaSampleRateHertz;
        private string _requestId;
        private MedicalScribeResultStream _resultStream;
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The Language Code that you specified in your request. Same as provided in the <c>StartMedicalScribeStreamRequest</c>.
        /// 
        /// </para>
        /// </summary>
        public MedicalScribeLanguageCode LanguageCode
        {
            get { return this._languageCode; }
            set { this._languageCode = value; }
        }

        // Check to see if LanguageCode property is set
        internal bool IsSetLanguageCode()
        {
            return this._languageCode != null;
        }

        /// <summary>
        /// Gets and sets the property MediaEncoding. 
        /// <para>
        /// The Media Encoding you specified in your request. Same as provided in the <c>StartMedicalScribeStreamRequest</c>
        /// 
        /// </para>
        /// </summary>
        public MedicalScribeMediaEncoding MediaEncoding
        {
            get { return this._mediaEncoding; }
            set { this._mediaEncoding = value; }
        }

        // Check to see if MediaEncoding property is set
        internal bool IsSetMediaEncoding()
        {
            return this._mediaEncoding != null;
        }

        /// <summary>
        /// Gets and sets the property MediaSampleRateHertz. 
        /// <para>
        /// The sample rate (in hertz) that you specified in your request. Same as provided in
        /// the <c>StartMedicalScribeStreamRequest</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=16000, Max=48000)]
        public int? MediaSampleRateHertz
        {
            get { return this._mediaSampleRateHertz; }
            set { this._mediaSampleRateHertz = value; }
        }

        // Check to see if MediaSampleRateHertz property is set
        internal bool IsSetMediaSampleRateHertz()
        {
            return this._mediaSampleRateHertz.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The unique identifier for your streaming request. 
        /// </para>
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property ResultStream. 
        /// <para>
        /// The result stream where you will receive the output events. 
        /// </para>
        /// </summary>
        public MedicalScribeResultStream ResultStream
        {
            get { return this._resultStream; }
            set { this._resultStream = value; }
        }

        // Check to see if ResultStream property is set
        internal bool IsSetResultStream()
        {
            return this._resultStream != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier (in UUID format) for your streaming session.
        /// </para>
        ///  
        /// <para>
        /// If you already started streaming, this is same ID as the one you specified in your
        /// initial <c>StartMedicalScribeStreamRequest</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

#pragma warning disable CA1033

        Amazon.Runtime.EventStreams.EventInputStreamContext _eventInputStreamContext;
        void Amazon.Runtime.EventStreams.IEventInputStreamContextOwner.SetEventInputStreamContext(Amazon.Runtime.EventStreams.EventInputStreamContext eventInputStreamContext)
        {
            this._eventInputStreamContext = eventInputStreamContext;
        }
#pragma warning restore CA1033
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
                return;

            if (disposing)
            {
                this._eventInputStreamContext?.Dispose();
                this._eventInputStreamContext = null;
                this._resultStream?.Dispose();
                this._resultStream = null;
            }

            this._disposed = true;
         }

         #endregion
    }
}