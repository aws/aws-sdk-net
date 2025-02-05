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
 * Do not modify this file. This file is generated from the runtime.lex-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lex.Model;
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
namespace Amazon.Lex.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PostContent Request Marshaller
    /// </summary>       
    public class PostContentRequestMarshaller : IMarshaller<IRequest, PostContentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PostContentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PostContentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lex");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-11-28";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetBotAlias())
                throw new AmazonLexException("Request object does not have required field BotAlias set");
            request.AddPathResource("{botAlias}", StringUtils.FromString(publicRequest.BotAlias));
            if (!publicRequest.IsSetBotName())
                throw new AmazonLexException("Request object does not have required field BotName set");
            request.AddPathResource("{botName}", StringUtils.FromString(publicRequest.BotName));
            if (!publicRequest.IsSetUserId())
                throw new AmazonLexException("Request object does not have required field UserId set");
            request.AddPathResource("{userId}", StringUtils.FromString(publicRequest.UserId));
            request.ResourcePath = "/bot/{botName}/alias/{botAlias}/user/{userId}/content";
            request.ContentStream =  publicRequest.InputStream ?? new MemoryStream();
            if (request.ContentStream.CanSeek)
            {
                request.ContentStream.Seek(0, SeekOrigin.Begin);
                request.Headers[Amazon.Util.HeaderKeys.ContentLengthHeader] =  
                    request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                request.Headers[Amazon.Util.HeaderKeys.TransferEncodingHeader] = "chunked";
            }
            request.Headers[Amazon.Util.HeaderKeys.ContentTypeHeader] = "application/octet-stream";
        
            if (publicRequest.IsSetAccept()) 
            {
                request.Headers["Accept"] = publicRequest.Accept;
            }
        
            if (publicRequest.IsSetActiveContexts()) 
            {
                request.Headers["x-amz-lex-active-contexts"] = Convert.ToBase64String(Encoding.UTF8.GetBytes(publicRequest.ActiveContexts));
            }
        
            if (publicRequest.IsSetContentType()) 
            {
                request.Headers["Content-Type"] = publicRequest.ContentType;
            }
        
            if (publicRequest.IsSetRequestAttributes()) 
            {
                request.Headers["x-amz-lex-request-attributes"] = Convert.ToBase64String(Encoding.UTF8.GetBytes(publicRequest.RequestAttributes));
            }
        
            if (publicRequest.IsSetSessionAttributes()) 
            {
                request.Headers["x-amz-lex-session-attributes"] = Convert.ToBase64String(Encoding.UTF8.GetBytes(publicRequest.SessionAttributes));
            }

            return request;
        }
        private static PostContentRequestMarshaller _instance = new PostContentRequestMarshaller();        

        internal static PostContentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PostContentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}