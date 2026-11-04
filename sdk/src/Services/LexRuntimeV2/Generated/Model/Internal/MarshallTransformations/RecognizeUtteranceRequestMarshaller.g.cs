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
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.LexRuntimeV2.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.LexRuntimeV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RecognizeUtterance Request Marshaller
    /// </summary>
    public partial class RecognizeUtteranceRequestMarshaller : IMarshaller<IRequest, RecognizeUtteranceRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RecognizeUtteranceRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(RecognizeUtteranceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LexRuntimeV2");
            request.Headers["Content-Type"] = "application/octet-stream";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-07";
            request.HttpMethod = "POST";

            if (publicRequest.IsSetRequestAttributes())
            {
                request.Headers["x-amz-lex-request-attributes"] = publicRequest.RequestAttributes;
            }

            if (publicRequest.IsSetRequestContentType())
            {
                request.Headers["Content-Type"] = publicRequest.RequestContentType;
            }

            if (publicRequest.IsSetResponseContentType())
            {
                request.Headers["Response-Content-Type"] = publicRequest.ResponseContentType;
            }

            if (publicRequest.IsSetSessionStateValue())
            {
                request.Headers["x-amz-lex-session-state"] = publicRequest.SessionStateValue;
            }

            if (!publicRequest.IsSetBotAliasId())
            {
                throw new AmazonLexRuntimeV2Exception("Request object does not have required field BotAliasId set");
            }
            request.AddPathResource("{botAliasId}", StringUtils.FromString(publicRequest.BotAliasId));

            if (!publicRequest.IsSetBotId())
            {
                throw new AmazonLexRuntimeV2Exception("Request object does not have required field BotId set");
            }
            request.AddPathResource("{botId}", StringUtils.FromString(publicRequest.BotId));

            if (!publicRequest.IsSetLocaleId())
            {
                throw new AmazonLexRuntimeV2Exception("Request object does not have required field LocaleId set");
            }
            request.AddPathResource("{localeId}", StringUtils.FromString(publicRequest.LocaleId));

            if (!publicRequest.IsSetSessionId())
            {
                throw new AmazonLexRuntimeV2Exception("Request object does not have required field SessionId set");
            }
            request.AddPathResource("{sessionId}", StringUtils.FromString(publicRequest.SessionId));

            request.ResourcePath = "/bots/{botId}/botAliases/{botAliasId}/botLocales/{localeId}/sessions/{sessionId}/utterance";
            request.ContentStream = publicRequest.InputStream ?? new MemoryStream();
            if (request.ContentStream.CanSeek)
            {
                request.ContentStream.Seek(0, SeekOrigin.Begin);
                request.Headers[Amazon.Util.HeaderKeys.ContentLengthHeader] = request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                request.Headers[Amazon.Util.HeaderKeys.TransferEncodingHeader] = "chunked";
            }
            request.DisablePayloadSigning = true;

            return request;
        }

        private static readonly RecognizeUtteranceRequestMarshaller _instance = new();

        internal static RecognizeUtteranceRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RecognizeUtteranceRequestMarshaller Instance => _instance;
    }
}
