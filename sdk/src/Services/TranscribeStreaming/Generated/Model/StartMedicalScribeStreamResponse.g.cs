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

namespace Amazon.TranscribeStreaming.Model
{
    /// <summary>
    /// This is the response object from the StartMedicalScribeStream operation.
    /// </summary>
    public partial class StartMedicalScribeStreamResponse : AmazonWebServiceResponse, Amazon.Runtime.EventStreams.IEventInputStreamContextOwner, IDisposable
    {
        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The Language Code that you specified in your request. Same as provided in the <c>StartMedicalScribeStreamRequest</c>.
        /// 
        /// </para>
        /// </summary>
        public MedicalScribeLanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property MediaEncoding. 
        /// <para>
        /// The Media Encoding you specified in your request. Same as provided in the <c>StartMedicalScribeStreamRequest</c>
        /// 
        /// </para>
        /// </summary>
        public MedicalScribeMediaEncoding MediaEncoding { get; set; }

        /// <summary>
        /// Checks to see if the MediaEncoding property is set.
        /// </summary>
        internal bool IsSetMediaEncoding() => this.MediaEncoding != null;

        /// <summary>
        /// Gets and sets the property MediaSampleRateHertz. 
        /// <para>
        /// The sample rate (in hertz) that you specified in your request. Same as provided in
        /// the <c>StartMedicalScribeStreamRequest</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 16000, Max = 48000)]
        public int? MediaSampleRateHertz { get; set; }

        /// <summary>
        /// Checks to see if the MediaSampleRateHertz property is set.
        /// </summary>
        internal bool IsSetMediaSampleRateHertz() => this.MediaSampleRateHertz.HasValue;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The unique identifier for your streaming request. 
        /// </para>
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property ResultStream. 
        /// <para>
        /// The result stream where you will receive the output events. 
        /// </para>
        /// </summary>
        public MedicalScribeResultStream ResultStream { get; set; }

        /// <summary>
        /// Checks to see if the ResultStream property is set.
        /// </summary>
        internal bool IsSetResultStream() => this.ResultStream != null;

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
        [AWSProperty(Min = 36, Max = 36)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

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
            {
                return;
            }

            if (disposing)
            {
                this._eventInputStreamContext?.Dispose();
                this._eventInputStreamContext = null;
                this.ResultStream?.Dispose();
                this.ResultStream = null;
            }

            this._disposed = true;
        }

        #endregion
    }
}
