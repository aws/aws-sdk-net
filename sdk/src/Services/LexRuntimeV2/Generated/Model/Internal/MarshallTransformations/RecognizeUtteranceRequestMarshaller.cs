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
 * Do not modify this file. This file is generated from the runtime.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexRuntimeV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LexRuntimeV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RecognizeUtterance Request Marshaller
    /// </summary>       
    public class RecognizeUtteranceRequestMarshaller : IMarshaller<IRequest, RecognizeUtteranceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RecognizeUtteranceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RecognizeUtteranceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LexRuntimeV2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-07";            
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetBotAliasId())
                throw new AmazonLexRuntimeV2Exception("Request object does not have required field BotAliasId set");
            request.AddPathResource("{botAliasId}", StringUtils.FromString(publicRequest.BotAliasId));
            if (!publicRequest.IsSetBotId())
                throw new AmazonLexRuntimeV2Exception("Request object does not have required field BotId set");
            request.AddPathResource("{botId}", StringUtils.FromString(publicRequest.BotId));
            if (!publicRequest.IsSetLocaleId())
                throw new AmazonLexRuntimeV2Exception("Request object does not have required field LocaleId set");
            request.AddPathResource("{localeId}", StringUtils.FromString(publicRequest.LocaleId));
            if (!publicRequest.IsSetSessionId())
                throw new AmazonLexRuntimeV2Exception("Request object does not have required field SessionId set");
            request.AddPathResource("{sessionId}", StringUtils.FromString(publicRequest.SessionId));
            request.ResourcePath = "/bots/{botId}/botAliases/{botAliasId}/botLocales/{localeId}/sessions/{sessionId}/utterance";
            request.MarshallerVersion = 2;
            request.ContentStream =  publicRequest.InputStream ?? new MemoryStream();
            if(request.ContentStream.CanSeek)
            {
                request.Headers[Amazon.Util.HeaderKeys.ContentLengthHeader] =  
                    request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                request.Headers[Amazon.Util.HeaderKeys.TransferEncodingHeader] = "chunked";
            }
            request.Headers[Amazon.Util.HeaderKeys.ContentTypeHeader] = "binary/octet-stream";
        
            if(publicRequest.IsSetRequestAttributes())
                request.Headers["x-amz-lex-request-attributes"] = publicRequest.RequestAttributes;
        
            if(publicRequest.IsSetRequestContentType())
                request.Headers["Content-Type"] = publicRequest.RequestContentType;
        
            if(publicRequest.IsSetResponseContentType())
                request.Headers["Response-Content-Type"] = publicRequest.ResponseContentType;
        
            if(publicRequest.IsSetSessionStateValue())
                request.Headers["x-amz-lex-session-state"] = publicRequest.SessionStateValue;

            return request;
        }
        private static RecognizeUtteranceRequestMarshaller _instance = new RecognizeUtteranceRequestMarshaller();        

        internal static RecognizeUtteranceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RecognizeUtteranceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}