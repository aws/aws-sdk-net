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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.TranscribeStreaming.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.TranscribeStreaming.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartStreamTranscription Request Marshaller
    /// </summary>       
    public class StartStreamTranscriptionRequestMarshaller : IMarshaller<IRequest, StartStreamTranscriptionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartStreamTranscriptionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartStreamTranscriptionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.TranscribeStreaming");
#if NET8_0_OR_GREATER
            request.HttpProtocolVersion = System.Net.HttpVersion.Version20;
#endif
            request.Headers["Content-Type"] = "application/vnd.amazon.eventstream";
            request.EventStreamPublisher = new AudioStreamPublisherMarshaller(publicRequest.AudioStreamPublisher);

            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/stream-transcription";
        
            if (publicRequest.IsSetContentIdentificationType()) 
            {
                request.Headers["x-amzn-transcribe-content-identification-type"] = publicRequest.ContentIdentificationType;
            }
        
            if (publicRequest.IsSetContentRedactionType()) 
            {
                request.Headers["x-amzn-transcribe-content-redaction-type"] = publicRequest.ContentRedactionType;
            }
        
            if (publicRequest.IsSetEnableChannelIdentification()) 
            {
                request.Headers["x-amzn-transcribe-enable-channel-identification"] = StringUtils.FromBool(publicRequest.EnableChannelIdentification);
            }
        
            if (publicRequest.IsSetEnablePartialResultsStabilization()) 
            {
                request.Headers["x-amzn-transcribe-enable-partial-results-stabilization"] = StringUtils.FromBool(publicRequest.EnablePartialResultsStabilization);
            }
        
            if (publicRequest.IsSetIdentifyLanguage()) 
            {
                request.Headers["x-amzn-transcribe-identify-language"] = StringUtils.FromBool(publicRequest.IdentifyLanguage);
            }
        
            if (publicRequest.IsSetIdentifyMultipleLanguages()) 
            {
                request.Headers["x-amzn-transcribe-identify-multiple-languages"] = StringUtils.FromBool(publicRequest.IdentifyMultipleLanguages);
            }
        
            if (publicRequest.IsSetLanguageCode()) 
            {
                request.Headers["x-amzn-transcribe-language-code"] = publicRequest.LanguageCode;
            }
        
            if (publicRequest.IsSetLanguageModelName()) 
            {
                request.Headers["x-amzn-transcribe-language-model-name"] = publicRequest.LanguageModelName;
            }
        
            if (publicRequest.IsSetLanguageOptions()) 
            {
                request.Headers["x-amzn-transcribe-language-options"] = publicRequest.LanguageOptions;
            }
        
            if (publicRequest.IsSetMediaEncoding()) 
            {
                request.Headers["x-amzn-transcribe-media-encoding"] = publicRequest.MediaEncoding;
            }
        
            if (publicRequest.IsSetMediaSampleRateHertz()) 
            {
                request.Headers["x-amzn-transcribe-sample-rate"] = StringUtils.FromInt(publicRequest.MediaSampleRateHertz);
            }
        
            if (publicRequest.IsSetNumberOfChannels()) 
            {
                request.Headers["x-amzn-transcribe-number-of-channels"] = StringUtils.FromInt(publicRequest.NumberOfChannels);
            }
        
            if (publicRequest.IsSetPartialResultsStability()) 
            {
                request.Headers["x-amzn-transcribe-partial-results-stability"] = publicRequest.PartialResultsStability;
            }
        
            if (publicRequest.IsSetPiiEntityTypes()) 
            {
                request.Headers["x-amzn-transcribe-pii-entity-types"] = publicRequest.PiiEntityTypes;
            }
        
            if (publicRequest.IsSetPreferredLanguage()) 
            {
                request.Headers["x-amzn-transcribe-preferred-language"] = publicRequest.PreferredLanguage;
            }
        
            if (publicRequest.IsSetSessionId()) 
            {
                request.Headers["x-amzn-transcribe-session-id"] = publicRequest.SessionId;
            }
        
            if (publicRequest.IsSetShowSpeakerLabel()) 
            {
                request.Headers["x-amzn-transcribe-show-speaker-label"] = StringUtils.FromBool(publicRequest.ShowSpeakerLabel);
            }
        
            if (publicRequest.IsSetVocabularyFilterMethod()) 
            {
                request.Headers["x-amzn-transcribe-vocabulary-filter-method"] = publicRequest.VocabularyFilterMethod;
            }
        
            if (publicRequest.IsSetVocabularyFilterName()) 
            {
                request.Headers["x-amzn-transcribe-vocabulary-filter-name"] = publicRequest.VocabularyFilterName;
            }
        
            if (publicRequest.IsSetVocabularyFilterNames()) 
            {
                request.Headers["x-amzn-transcribe-vocabulary-filter-names"] = publicRequest.VocabularyFilterNames;
            }
        
            if (publicRequest.IsSetVocabularyName()) 
            {
                request.Headers["x-amzn-transcribe-vocabulary-name"] = publicRequest.VocabularyName;
            }
        
            if (publicRequest.IsSetVocabularyNames()) 
            {
                request.Headers["x-amzn-transcribe-vocabulary-names"] = publicRequest.VocabularyNames;
            }

            return request;
        }
        private static StartStreamTranscriptionRequestMarshaller _instance = new StartStreamTranscriptionRequestMarshaller();        

        internal static StartStreamTranscriptionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartStreamTranscriptionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}