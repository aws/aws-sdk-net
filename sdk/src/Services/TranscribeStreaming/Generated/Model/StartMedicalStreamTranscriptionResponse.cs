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
    /// This is the response object from the StartMedicalStreamTranscription operation.
    /// </summary>
    public partial class StartMedicalStreamTranscriptionResponse : AmazonWebServiceResponse, Amazon.Runtime.EventStreams.IEventInputStreamContextOwner, IDisposable
    {
        private MedicalContentIdentificationType _contentIdentificationType;
        private bool? _enableChannelIdentification;
        private LanguageCode _languageCode;
        private MediaEncoding _mediaEncoding;
        private int? _mediaSampleRateHertz;
        private int? _numberOfChannels;
        private string _requestId;
        private string _sessionId;
        private bool? _showSpeakerLabel;
        private Specialty _specialty;
        private MedicalTranscriptResultStream _transcriptResultStream;
        private Type _type;
        private string _vocabularyName;

        /// <summary>
        /// Gets and sets the property ContentIdentificationType. 
        /// <para>
        /// Shows whether content identification was enabled for your transcription.
        /// </para>
        /// </summary>
        public MedicalContentIdentificationType ContentIdentificationType
        {
            get { return this._contentIdentificationType; }
            set { this._contentIdentificationType = value; }
        }

        // Check to see if ContentIdentificationType property is set
        internal bool IsSetContentIdentificationType()
        {
            return this._contentIdentificationType != null;
        }

        /// <summary>
        /// Gets and sets the property EnableChannelIdentification. 
        /// <para>
        /// Shows whether channel identification was enabled for your transcription.
        /// </para>
        /// </summary>
        public bool? EnableChannelIdentification
        {
            get { return this._enableChannelIdentification; }
            set { this._enableChannelIdentification = value; }
        }

        // Check to see if EnableChannelIdentification property is set
        internal bool IsSetEnableChannelIdentification()
        {
            return this._enableChannelIdentification.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// Provides the language code that you specified in your request. This must be <c>en-US</c>.
        /// </para>
        /// </summary>
        public LanguageCode LanguageCode
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
        /// Provides the media encoding you specified in your request.
        /// </para>
        /// </summary>
        public MediaEncoding MediaEncoding
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
        /// Provides the sample rate that you specified in your request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8000, Max=48000)]
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
        /// Gets and sets the property NumberOfChannels. 
        /// <para>
        /// Provides the number of channels that you specified in your request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2)]
        public int? NumberOfChannels
        {
            get { return this._numberOfChannels; }
            set { this._numberOfChannels = value; }
        }

        // Check to see if NumberOfChannels property is set
        internal bool IsSetNumberOfChannels()
        {
            return this._numberOfChannels.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// Provides the identifier for your streaming request.
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
        /// Gets and sets the property SessionId. 
        /// <para>
        /// Provides the identifier for your transcription session.
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

        /// <summary>
        /// Gets and sets the property ShowSpeakerLabel. 
        /// <para>
        /// Shows whether speaker partitioning was enabled for your transcription.
        /// </para>
        /// </summary>
        public bool? ShowSpeakerLabel
        {
            get { return this._showSpeakerLabel; }
            set { this._showSpeakerLabel = value; }
        }

        // Check to see if ShowSpeakerLabel property is set
        internal bool IsSetShowSpeakerLabel()
        {
            return this._showSpeakerLabel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Specialty. 
        /// <para>
        /// Provides the medical specialty that you specified in your request.
        /// </para>
        /// </summary>
        public Specialty Specialty
        {
            get { return this._specialty; }
            set { this._specialty = value; }
        }

        // Check to see if Specialty property is set
        internal bool IsSetSpecialty()
        {
            return this._specialty != null;
        }

        /// <summary>
        /// Gets and sets the property TranscriptResultStream. 
        /// <para>
        /// Provides detailed information about your streaming session.
        /// </para>
        /// </summary>
        public MedicalTranscriptResultStream TranscriptResultStream
        {
            get { return this._transcriptResultStream; }
            set { this._transcriptResultStream = value; }
        }

        // Check to see if TranscriptResultStream property is set
        internal bool IsSetTranscriptResultStream()
        {
            return this._transcriptResultStream != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Provides the type of audio you specified in your request.
        /// </para>
        /// </summary>
        public Type Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property VocabularyName. 
        /// <para>
        /// Provides the name of the custom vocabulary that you specified in your request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string VocabularyName
        {
            get { return this._vocabularyName; }
            set { this._vocabularyName = value; }
        }

        // Check to see if VocabularyName property is set
        internal bool IsSetVocabularyName()
        {
            return this._vocabularyName != null;
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
                this._transcriptResultStream?.Dispose();
                this._transcriptResultStream = null;
            }

            this._disposed = true;
         }

         #endregion
    }
}