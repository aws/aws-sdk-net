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
    /// This is the response object from the StartStreamTranscription operation.
    /// </summary>
    public partial class StartStreamTranscriptionResponse : AmazonWebServiceResponse, Amazon.Runtime.EventStreams.IEventInputStreamContextOwner, IDisposable
    {
        private ContentIdentificationType _contentIdentificationType;
        private ContentRedactionType _contentRedactionType;
        private bool? _enableChannelIdentification;
        private bool? _enablePartialResultsStabilization;
        private bool? _identifyLanguage;
        private bool? _identifyMultipleLanguages;
        private LanguageCode _languageCode;
        private string _languageModelName;
        private string _languageOptions;
        private MediaEncoding _mediaEncoding;
        private int? _mediaSampleRateHertz;
        private int? _numberOfChannels;
        private PartialResultsStability _partialResultsStability;
        private string _piiEntityTypes;
        private LanguageCode _preferredLanguage;
        private string _requestId;
        private string _sessionId;
        private bool? _showSpeakerLabel;
        private TranscriptResultStream _transcriptResultStream;
        private VocabularyFilterMethod _vocabularyFilterMethod;
        private string _vocabularyFilterName;
        private string _vocabularyFilterNames;
        private string _vocabularyName;
        private string _vocabularyNames;

        /// <summary>
        /// Gets and sets the property ContentIdentificationType. 
        /// <para>
        /// Shows whether content identification was enabled for your transcription.
        /// </para>
        /// </summary>
        public ContentIdentificationType ContentIdentificationType
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
        /// Gets and sets the property ContentRedactionType. 
        /// <para>
        /// Shows whether content redaction was enabled for your transcription.
        /// </para>
        /// </summary>
        public ContentRedactionType ContentRedactionType
        {
            get { return this._contentRedactionType; }
            set { this._contentRedactionType = value; }
        }

        // Check to see if ContentRedactionType property is set
        internal bool IsSetContentRedactionType()
        {
            return this._contentRedactionType != null;
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
        /// Gets and sets the property EnablePartialResultsStabilization. 
        /// <para>
        /// Shows whether partial results stabilization was enabled for your transcription.
        /// </para>
        /// </summary>
        public bool? EnablePartialResultsStabilization
        {
            get { return this._enablePartialResultsStabilization; }
            set { this._enablePartialResultsStabilization = value; }
        }

        // Check to see if EnablePartialResultsStabilization property is set
        internal bool IsSetEnablePartialResultsStabilization()
        {
            return this._enablePartialResultsStabilization.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdentifyLanguage. 
        /// <para>
        /// Shows whether automatic language identification was enabled for your transcription.
        /// </para>
        /// </summary>
        public bool? IdentifyLanguage
        {
            get { return this._identifyLanguage; }
            set { this._identifyLanguage = value; }
        }

        // Check to see if IdentifyLanguage property is set
        internal bool IsSetIdentifyLanguage()
        {
            return this._identifyLanguage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdentifyMultipleLanguages. 
        /// <para>
        /// Shows whether automatic multi-language identification was enabled for your transcription.
        /// </para>
        /// </summary>
        public bool? IdentifyMultipleLanguages
        {
            get { return this._identifyMultipleLanguages; }
            set { this._identifyMultipleLanguages = value; }
        }

        // Check to see if IdentifyMultipleLanguages property is set
        internal bool IsSetIdentifyMultipleLanguages()
        {
            return this._identifyMultipleLanguages.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// Provides the language code that you specified in your request.
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
        /// Gets and sets the property LanguageModelName. 
        /// <para>
        /// Provides the name of the custom language model that you specified in your request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string LanguageModelName
        {
            get { return this._languageModelName; }
            set { this._languageModelName = value; }
        }

        // Check to see if LanguageModelName property is set
        internal bool IsSetLanguageModelName()
        {
            return this._languageModelName != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageOptions. 
        /// <para>
        /// Provides the language codes that you specified in your request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string LanguageOptions
        {
            get { return this._languageOptions; }
            set { this._languageOptions = value; }
        }

        // Check to see if LanguageOptions property is set
        internal bool IsSetLanguageOptions()
        {
            return this._languageOptions != null;
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
        /// Gets and sets the property PartialResultsStability. 
        /// <para>
        /// Provides the stabilization level used for your transcription.
        /// </para>
        /// </summary>
        public PartialResultsStability PartialResultsStability
        {
            get { return this._partialResultsStability; }
            set { this._partialResultsStability = value; }
        }

        // Check to see if PartialResultsStability property is set
        internal bool IsSetPartialResultsStability()
        {
            return this._partialResultsStability != null;
        }

        /// <summary>
        /// Gets and sets the property PiiEntityTypes. 
        /// <para>
        /// Lists the PII entity types you specified in your request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string PiiEntityTypes
        {
            get { return this._piiEntityTypes; }
            set { this._piiEntityTypes = value; }
        }

        // Check to see if PiiEntityTypes property is set
        internal bool IsSetPiiEntityTypes()
        {
            return this._piiEntityTypes != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredLanguage. 
        /// <para>
        /// Provides the preferred language that you specified in your request.
        /// </para>
        /// </summary>
        public LanguageCode PreferredLanguage
        {
            get { return this._preferredLanguage; }
            set { this._preferredLanguage = value; }
        }

        // Check to see if PreferredLanguage property is set
        internal bool IsSetPreferredLanguage()
        {
            return this._preferredLanguage != null;
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
        /// Gets and sets the property TranscriptResultStream. 
        /// <para>
        /// Provides detailed information about your streaming session.
        /// </para>
        /// </summary>
        public TranscriptResultStream TranscriptResultStream
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
        /// Gets and sets the property VocabularyFilterMethod. 
        /// <para>
        /// Provides the vocabulary filtering method used in your transcription.
        /// </para>
        /// </summary>
        public VocabularyFilterMethod VocabularyFilterMethod
        {
            get { return this._vocabularyFilterMethod; }
            set { this._vocabularyFilterMethod = value; }
        }

        // Check to see if VocabularyFilterMethod property is set
        internal bool IsSetVocabularyFilterMethod()
        {
            return this._vocabularyFilterMethod != null;
        }

        /// <summary>
        /// Gets and sets the property VocabularyFilterName. 
        /// <para>
        /// Provides the name of the custom vocabulary filter that you specified in your request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string VocabularyFilterName
        {
            get { return this._vocabularyFilterName; }
            set { this._vocabularyFilterName = value; }
        }

        // Check to see if VocabularyFilterName property is set
        internal bool IsSetVocabularyFilterName()
        {
            return this._vocabularyFilterName != null;
        }

        /// <summary>
        /// Gets and sets the property VocabularyFilterNames. 
        /// <para>
        /// Provides the names of the custom vocabulary filters that you specified in your request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3000)]
        public string VocabularyFilterNames
        {
            get { return this._vocabularyFilterNames; }
            set { this._vocabularyFilterNames = value; }
        }

        // Check to see if VocabularyFilterNames property is set
        internal bool IsSetVocabularyFilterNames()
        {
            return this._vocabularyFilterNames != null;
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

        /// <summary>
        /// Gets and sets the property VocabularyNames. 
        /// <para>
        /// Provides the names of the custom vocabularies that you specified in your request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3000)]
        public string VocabularyNames
        {
            get { return this._vocabularyNames; }
            set { this._vocabularyNames = value; }
        }

        // Check to see if VocabularyNames property is set
        internal bool IsSetVocabularyNames()
        {
            return this._vocabularyNames != null;
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