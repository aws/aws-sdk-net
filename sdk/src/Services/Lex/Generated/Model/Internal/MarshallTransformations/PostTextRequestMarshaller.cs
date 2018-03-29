/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using ThirdParty.Json.LitJson;

namespace Amazon.Lex.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PostText Request Marshaller
    /// </summary>       
    public class PostTextRequestMarshaller : IMarshaller<IRequest, PostTextRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PostTextRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PostTextRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lex");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/bot/{botName}/alias/{botAlias}/user/{userId}/text";
            if (!publicRequest.IsSetBotAlias())
                throw new AmazonLexException("Request object does not have required field BotAlias set");
            uriResourcePath = uriResourcePath.Replace("{botAlias}", StringUtils.FromString(publicRequest.BotAlias));
            if (!publicRequest.IsSetBotName())
                throw new AmazonLexException("Request object does not have required field BotName set");
            uriResourcePath = uriResourcePath.Replace("{botName}", StringUtils.FromString(publicRequest.BotName));
            if (!publicRequest.IsSetUserId())
                throw new AmazonLexException("Request object does not have required field UserId set");
            uriResourcePath = uriResourcePath.Replace("{userId}", StringUtils.FromString(publicRequest.UserId));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetInputText())
                {
                    context.Writer.WritePropertyName("inputText");
                    context.Writer.Write(publicRequest.InputText);
                }

                if(publicRequest.IsSetRequestAttributes())
                {
                    context.Writer.WritePropertyName("requestAttributes");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestRequestAttributesKvp in publicRequest.RequestAttributes)
                    {
                        context.Writer.WritePropertyName(publicRequestRequestAttributesKvp.Key);
                        var publicRequestRequestAttributesValue = publicRequestRequestAttributesKvp.Value;

                            context.Writer.Write(publicRequestRequestAttributesValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSessionAttributes())
                {
                    context.Writer.WritePropertyName("sessionAttributes");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestSessionAttributesKvp in publicRequest.SessionAttributes)
                    {
                        context.Writer.WritePropertyName(publicRequestSessionAttributesKvp.Key);
                        var publicRequestSessionAttributesValue = publicRequestSessionAttributesKvp.Value;

                            context.Writer.Write(publicRequestSessionAttributesValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PostTextRequestMarshaller _instance = new PostTextRequestMarshaller();        

        internal static PostTextRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PostTextRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}