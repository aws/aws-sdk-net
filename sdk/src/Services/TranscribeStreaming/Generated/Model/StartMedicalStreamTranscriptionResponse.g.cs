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
    /// This is the response object from the StartMedicalStreamTranscription operation.
    /// </summary>
    public partial class StartMedicalStreamTranscriptionResponse : AmazonWebServiceResponse, Amazon.Runtime.EventStreams.IEventInputStreamContextOwner, IDisposable
    {
        /// <summary>
        /// Gets and sets the property ContentIdentificationType. 
        /// <para>
        /// Shows whether content identification was enabled for your transcription.
        /// </para>
        /// </summary>
        public MedicalContentIdentificationType ContentIdentificationType { get; set; }

        /// <summary>
        /// Checks to see if the ContentIdentificationType property is set.
        /// </summary>
        internal bool IsSetContentIdentificationType() => this.ContentIdentificationType != null;

        /// <summary>
        /// Gets and sets the property EnableChannelIdentification. 
        /// <para>
        /// Shows whether channel identification was enabled for your transcription.
        /// </para>
        /// </summary>
        public bool? EnableChannelIdentification { get; set; }

        /// <summary>
        /// Checks to see if the EnableChannelIdentification property is set.
        /// </summary>
        internal bool IsSetEnableChannelIdentification() => this.EnableChannelIdentification.HasValue;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// Provides the language code that you specified in your request. This must be <c>en-US</c>.
        /// </para>
        /// </summary>
        public LanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property MediaEncoding. 
        /// <para>
        /// Provides the media encoding you specified in your request.
        /// </para>
        /// </summary>
        public MediaEncoding MediaEncoding { get; set; }

        /// <summary>
        /// Checks to see if the MediaEncoding property is set.
        /// </summary>
        internal bool IsSetMediaEncoding() => this.MediaEncoding != null;

        /// <summary>
        /// Gets and sets the property MediaSampleRateHertz. 
        /// <para>
        /// Provides the sample rate that you specified in your request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 8000, Max = 48000)]
        public int? MediaSampleRateHertz { get; set; }

        /// <summary>
        /// Checks to see if the MediaSampleRateHertz property is set.
        /// </summary>
        internal bool IsSetMediaSampleRateHertz() => this.MediaSampleRateHertz.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfChannels. 
        /// <para>
        /// Provides the number of channels that you specified in your request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2)]
        public int? NumberOfChannels { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfChannels property is set.
        /// </summary>
        internal bool IsSetNumberOfChannels() => this.NumberOfChannels.HasValue;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// Provides the identifier for your streaming request.
        /// </para>
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// Provides the identifier for your transcription session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property ShowSpeakerLabel. 
        /// <para>
        /// Shows whether speaker partitioning was enabled for your transcription.
        /// </para>
        /// </summary>
        public bool? ShowSpeakerLabel { get; set; }

        /// <summary>
        /// Checks to see if the ShowSpeakerLabel property is set.
        /// </summary>
        internal bool IsSetShowSpeakerLabel() => this.ShowSpeakerLabel.HasValue;

        /// <summary>
        /// Gets and sets the property Specialty. 
        /// <para>
        /// Provides the medical specialty that you specified in your request.
        /// </para>
        /// </summary>
        public Specialty Specialty { get; set; }

        /// <summary>
        /// Checks to see if the Specialty property is set.
        /// </summary>
        internal bool IsSetSpecialty() => this.Specialty != null;

        /// <summary>
        /// Gets and sets the property TranscriptResultStream. 
        /// <para>
        /// Provides detailed information about your streaming session.
        /// </para>
        /// </summary>
        public MedicalTranscriptResultStream TranscriptResultStream { get; set; }

        /// <summary>
        /// Checks to see if the TranscriptResultStream property is set.
        /// </summary>
        internal bool IsSetTranscriptResultStream() => this.TranscriptResultStream != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Provides the type of audio you specified in your request.
        /// </para>
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VocabularyName. 
        /// <para>
        /// Provides the name of the custom vocabulary that you specified in your request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string VocabularyName { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyName property is set.
        /// </summary>
        internal bool IsSetVocabularyName() => this.VocabularyName != null;

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
                this.TranscriptResultStream?.Dispose();
                this.TranscriptResultStream = null;
            }

            this._disposed = true;
        }

        #endregion
    }
}
