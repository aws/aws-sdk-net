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
    /// This is the response object from the StartStreamTranscription operation.
    /// </summary>
    public partial class StartStreamTranscriptionResponse : AmazonWebServiceResponse, Amazon.Runtime.EventStreams.IEventInputStreamContextOwner, IDisposable
    {
        /// <summary>
        /// Gets and sets the property ContentIdentificationType. 
        /// <para>
        /// Shows whether content identification was enabled for your transcription.
        /// </para>
        /// </summary>
        public ContentIdentificationType ContentIdentificationType { get; set; }

        /// <summary>
        /// Checks to see if the ContentIdentificationType property is set.
        /// </summary>
        internal bool IsSetContentIdentificationType() => this.ContentIdentificationType != null;

        /// <summary>
        /// Gets and sets the property ContentRedactionType. 
        /// <para>
        /// Shows whether content redaction was enabled for your transcription.
        /// </para>
        /// </summary>
        public ContentRedactionType ContentRedactionType { get; set; }

        /// <summary>
        /// Checks to see if the ContentRedactionType property is set.
        /// </summary>
        internal bool IsSetContentRedactionType() => this.ContentRedactionType != null;

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
        /// Gets and sets the property EnablePartialResultsStabilization. 
        /// <para>
        /// Shows whether partial results stabilization was enabled for your transcription.
        /// </para>
        /// </summary>
        public bool? EnablePartialResultsStabilization { get; set; }

        /// <summary>
        /// Checks to see if the EnablePartialResultsStabilization property is set.
        /// </summary>
        internal bool IsSetEnablePartialResultsStabilization() => this.EnablePartialResultsStabilization.HasValue;

        /// <summary>
        /// Gets and sets the property IdentifyLanguage. 
        /// <para>
        /// Shows whether automatic language identification was enabled for your transcription.
        /// </para>
        /// </summary>
        public bool? IdentifyLanguage { get; set; }

        /// <summary>
        /// Checks to see if the IdentifyLanguage property is set.
        /// </summary>
        internal bool IsSetIdentifyLanguage() => this.IdentifyLanguage.HasValue;

        /// <summary>
        /// Gets and sets the property IdentifyMultipleLanguages. 
        /// <para>
        /// Shows whether automatic multi-language identification was enabled for your transcription.
        /// </para>
        /// </summary>
        public bool? IdentifyMultipleLanguages { get; set; }

        /// <summary>
        /// Checks to see if the IdentifyMultipleLanguages property is set.
        /// </summary>
        internal bool IsSetIdentifyMultipleLanguages() => this.IdentifyMultipleLanguages.HasValue;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// Provides the language code that you specified in your request.
        /// </para>
        /// </summary>
        public LanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property LanguageModelName. 
        /// <para>
        /// Provides the name of the custom language model that you specified in your request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string LanguageModelName { get; set; }

        /// <summary>
        /// Checks to see if the LanguageModelName property is set.
        /// </summary>
        internal bool IsSetLanguageModelName() => this.LanguageModelName != null;

        /// <summary>
        /// Gets and sets the property LanguageOptions. 
        /// <para>
        /// Provides the language codes that you specified in your request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string LanguageOptions { get; set; }

        /// <summary>
        /// Checks to see if the LanguageOptions property is set.
        /// </summary>
        internal bool IsSetLanguageOptions() => this.LanguageOptions != null;

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
        /// Gets and sets the property PartialResultsStability. 
        /// <para>
        /// Provides the stabilization level used for your transcription.
        /// </para>
        /// </summary>
        public PartialResultsStability PartialResultsStability { get; set; }

        /// <summary>
        /// Checks to see if the PartialResultsStability property is set.
        /// </summary>
        internal bool IsSetPartialResultsStability() => this.PartialResultsStability != null;

        /// <summary>
        /// Gets and sets the property PiiEntityTypes. 
        /// <para>
        /// Lists the PII entity types you specified in your request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string PiiEntityTypes { get; set; }

        /// <summary>
        /// Checks to see if the PiiEntityTypes property is set.
        /// </summary>
        internal bool IsSetPiiEntityTypes() => this.PiiEntityTypes != null;

        /// <summary>
        /// Gets and sets the property PreferredLanguage. 
        /// <para>
        /// Provides the preferred language that you specified in your request.
        /// </para>
        /// </summary>
        public LanguageCode PreferredLanguage { get; set; }

        /// <summary>
        /// Checks to see if the PreferredLanguage property is set.
        /// </summary>
        internal bool IsSetPreferredLanguage() => this.PreferredLanguage != null;

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
        /// Gets and sets the property SessionResumeWindow. 
        /// <para>
        /// Provides the session resume window, in minutes, that you specified in your request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public int? SessionResumeWindow { get; set; }

        /// <summary>
        /// Checks to see if the SessionResumeWindow property is set.
        /// </summary>
        internal bool IsSetSessionResumeWindow() => this.SessionResumeWindow.HasValue;

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
        /// Gets and sets the property TranscriptFormat. 
        /// <para>
        /// Provides the transcript format that you specified in your request.
        /// </para>
        /// </summary>
        public TranscriptFormat TranscriptFormat { get; set; }

        /// <summary>
        /// Checks to see if the TranscriptFormat property is set.
        /// </summary>
        internal bool IsSetTranscriptFormat() => this.TranscriptFormat != null;

        /// <summary>
        /// Gets and sets the property TranscriptResultStream. 
        /// <para>
        /// Provides detailed information about your streaming session.
        /// </para>
        /// </summary>
        public TranscriptResultStream TranscriptResultStream { get; set; }

        /// <summary>
        /// Checks to see if the TranscriptResultStream property is set.
        /// </summary>
        internal bool IsSetTranscriptResultStream() => this.TranscriptResultStream != null;

        /// <summary>
        /// Gets and sets the property VocabularyFilterMethod. 
        /// <para>
        /// Provides the vocabulary filtering method used in your transcription.
        /// </para>
        /// </summary>
        public VocabularyFilterMethod VocabularyFilterMethod { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyFilterMethod property is set.
        /// </summary>
        internal bool IsSetVocabularyFilterMethod() => this.VocabularyFilterMethod != null;

        /// <summary>
        /// Gets and sets the property VocabularyFilterName. 
        /// <para>
        /// Provides the name of the custom vocabulary filter that you specified in your request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string VocabularyFilterName { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyFilterName property is set.
        /// </summary>
        internal bool IsSetVocabularyFilterName() => this.VocabularyFilterName != null;

        /// <summary>
        /// Gets and sets the property VocabularyFilterNames. 
        /// <para>
        /// Provides the names of the custom vocabulary filters that you specified in your request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 3000)]
        public string VocabularyFilterNames { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyFilterNames property is set.
        /// </summary>
        internal bool IsSetVocabularyFilterNames() => this.VocabularyFilterNames != null;

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

        /// <summary>
        /// Gets and sets the property VocabularyNames. 
        /// <para>
        /// Provides the names of the custom vocabularies that you specified in your request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 3000)]
        public string VocabularyNames { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyNames property is set.
        /// </summary>
        internal bool IsSetVocabularyNames() => this.VocabularyNames != null;

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
