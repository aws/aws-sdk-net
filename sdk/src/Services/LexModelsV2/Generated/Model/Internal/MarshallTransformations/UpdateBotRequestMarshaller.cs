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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateBot Request Marshaller
    /// </summary>       
    public class UpdateBotRequestMarshaller : IMarshaller<IRequest, UpdateBotRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateBotRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateBotRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LexModelsV2");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-07";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetBotId())
                throw new AmazonLexModelsV2Exception("Request object does not have required field BotId set");
            request.AddPathResource("{botId}", StringUtils.FromString(publicRequest.BotId));
            request.ResourcePath = "/bots/{botId}/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBotMembers())
                {
                    context.Writer.WritePropertyName("botMembers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestBotMembersListValue in publicRequest.BotMembers)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = BotMemberMarshaller.Instance;
                        marshaller.Marshall(publicRequestBotMembersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetBotName())
                {
                    context.Writer.WritePropertyName("botName");
                    context.Writer.Write(publicRequest.BotName);
                }

                if(publicRequest.IsSetBotType())
                {
                    context.Writer.WritePropertyName("botType");
                    context.Writer.Write(publicRequest.BotType);
                }

                if(publicRequest.IsSetDataPrivacy())
                {
                    context.Writer.WritePropertyName("dataPrivacy");
                    context.Writer.WriteObjectStart();

                    var marshaller = DataPrivacyMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DataPrivacy, context);

                    context.Writer.WriteObjectEnd();
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

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("roleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateBotRequestMarshaller _instance = new UpdateBotRequestMarshaller();        

        internal static UpdateBotRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateBotRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}