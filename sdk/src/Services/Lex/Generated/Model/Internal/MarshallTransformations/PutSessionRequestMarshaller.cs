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
using ThirdParty.Json.LitJson;

namespace Amazon.Lex.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutSession Request Marshaller
    /// </summary>       
    public class PutSessionRequestMarshaller : IMarshaller<IRequest, PutSessionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutSessionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutSessionRequest publicRequest)
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
            request.ResourcePath = "/bot/{botName}/alias/{botAlias}/user/{userId}/session";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetActiveContexts())
                {
                    context.Writer.WritePropertyName("activeContexts");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestActiveContextsListValue in publicRequest.ActiveContexts)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ActiveContextMarshaller.Instance;
                        marshaller.Marshall(publicRequestActiveContextsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDialogAction())
                {
                    context.Writer.WritePropertyName("dialogAction");
                    context.Writer.WriteObjectStart();

                    var marshaller = DialogActionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DialogAction, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRecentIntentSummaryView())
                {
                    context.Writer.WritePropertyName("recentIntentSummaryView");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRecentIntentSummaryViewListValue in publicRequest.RecentIntentSummaryView)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = IntentSummaryMarshaller.Instance;
                        marshaller.Marshall(publicRequestRecentIntentSummaryViewListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
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

        
            if(publicRequest.IsSetAccept())
                request.Headers["Accept"] = publicRequest.Accept;

            return request;
        }
        private static PutSessionRequestMarshaller _instance = new PutSessionRequestMarshaller();        

        internal static PutSessionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutSessionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}