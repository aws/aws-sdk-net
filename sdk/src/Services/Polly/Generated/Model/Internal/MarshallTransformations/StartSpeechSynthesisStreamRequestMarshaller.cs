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
 * Do not modify this file. This file is generated from the polly-2016-06-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Polly.Model;
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
namespace Amazon.Polly.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartSpeechSynthesisStream Request Marshaller
    /// </summary>       
    public class StartSpeechSynthesisStreamRequestMarshaller : IMarshaller<IRequest, StartSpeechSynthesisStreamRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartSpeechSynthesisStreamRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartSpeechSynthesisStreamRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Polly");
#if NET8_0_OR_GREATER
            request.HttpProtocolVersion = System.Net.HttpVersion.Version20;
#endif
            request.Headers["Content-Type"] = "application/vnd.amazon.eventstream";
            request.EventStreamPublisher = new StartSpeechSynthesisStreamActionStreamPublisherMarshaller(publicRequest.ActionStreamPublisher);

            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-06-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/synthesisStream";
        
            if (publicRequest.IsSetEngine()) 
            {
                request.Headers["x-amzn-Engine"] = publicRequest.Engine;
            }
        
            if (publicRequest.IsSetLanguageCode()) 
            {
                request.Headers["x-amzn-LanguageCode"] = publicRequest.LanguageCode;
            }
        
            if (publicRequest.IsSetLexiconNames()) 
            {
                        request.Headers["x-amzn-LexiconNames"] = StringUtils.FromList(publicRequest.LexiconNames);
            }
        
            if (publicRequest.IsSetOutputFormat()) 
            {
                request.Headers["x-amzn-OutputFormat"] = publicRequest.OutputFormat;
            }
        
            if (publicRequest.IsSetSampleRate()) 
            {
                request.Headers["x-amzn-SampleRate"] = publicRequest.SampleRate;
            }
        
            if (publicRequest.IsSetVoiceId()) 
            {
                request.Headers["x-amzn-VoiceId"] = publicRequest.VoiceId;
            }

            return request;
        }
        private static StartSpeechSynthesisStreamRequestMarshaller _instance = new StartSpeechSynthesisStreamRequestMarshaller();        

        internal static StartSpeechSynthesisStreamRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartSpeechSynthesisStreamRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}