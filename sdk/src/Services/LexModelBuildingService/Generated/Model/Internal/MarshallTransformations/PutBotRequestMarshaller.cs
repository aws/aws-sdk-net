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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelBuildingService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LexModelBuildingService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutBot Request Marshaller
    /// </summary>       
    public class PutBotRequestMarshaller : IMarshaller<IRequest, PutBotRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutBotRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutBotRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LexModelBuildingService");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "PUT";

            string uriResourcePath = "/bots/{name}/versions/$LATEST";
            if (!publicRequest.IsSetName())
                throw new AmazonLexModelBuildingServiceException("Request object does not have required field Name set");
            uriResourcePath = uriResourcePath.Replace("{name}", StringUtils.FromString(publicRequest.Name));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAbortStatement())
                {
                    context.Writer.WritePropertyName("abortStatement");
                    context.Writer.WriteObjectStart();

                    var marshaller = StatementMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AbortStatement, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetChecksum())
                {
                    context.Writer.WritePropertyName("checksum");
                    context.Writer.Write(publicRequest.Checksum);
                }

                if(publicRequest.IsSetChildDirected())
                {
                    context.Writer.WritePropertyName("childDirected");
                    context.Writer.Write(publicRequest.ChildDirected);
                }

                if(publicRequest.IsSetClarificationPrompt())
                {
                    context.Writer.WritePropertyName("clarificationPrompt");
                    context.Writer.WriteObjectStart();

                    var marshaller = PromptMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ClarificationPrompt, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCreateVersion())
                {
                    context.Writer.WritePropertyName("createVersion");
                    context.Writer.Write(publicRequest.CreateVersion);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetIdleSessionTTLInSeconds())
                {
                    context.Writer.WritePropertyName("idleSessionTTLInSeconds");
                    context.Writer.Write(publicRequest.IdleSessionTTLInSeconds);
                }

                if(publicRequest.IsSetIntents())
                {
                    context.Writer.WritePropertyName("intents");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestIntentsListValue in publicRequest.Intents)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = IntentMarshaller.Instance;
                        marshaller.Marshall(publicRequestIntentsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetLocale())
                {
                    context.Writer.WritePropertyName("locale");
                    context.Writer.Write(publicRequest.Locale);
                }

                if(publicRequest.IsSetProcessBehavior())
                {
                    context.Writer.WritePropertyName("processBehavior");
                    context.Writer.Write(publicRequest.ProcessBehavior);
                }

                if(publicRequest.IsSetVoiceId())
                {
                    context.Writer.WritePropertyName("voiceId");
                    context.Writer.Write(publicRequest.VoiceId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutBotRequestMarshaller _instance = new PutBotRequestMarshaller();        

        internal static PutBotRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutBotRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}