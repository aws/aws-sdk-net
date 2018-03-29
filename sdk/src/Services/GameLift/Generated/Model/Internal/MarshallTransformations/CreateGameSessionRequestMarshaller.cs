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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameLift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateGameSession Request Marshaller
    /// </summary>       
    public class CreateGameSessionRequestMarshaller : IMarshaller<IRequest, CreateGameSessionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateGameSessionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateGameSessionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameLift");
            string target = "GameLift.CreateGameSession";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAliasId())
                {
                    context.Writer.WritePropertyName("AliasId");
                    context.Writer.Write(publicRequest.AliasId);
                }

                if(publicRequest.IsSetCreatorId())
                {
                    context.Writer.WritePropertyName("CreatorId");
                    context.Writer.Write(publicRequest.CreatorId);
                }

                if(publicRequest.IsSetFleetId())
                {
                    context.Writer.WritePropertyName("FleetId");
                    context.Writer.Write(publicRequest.FleetId);
                }

                if(publicRequest.IsSetGameProperties())
                {
                    context.Writer.WritePropertyName("GameProperties");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestGamePropertiesListValue in publicRequest.GameProperties)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = GamePropertyMarshaller.Instance;
                        marshaller.Marshall(publicRequestGamePropertiesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetGameSessionData())
                {
                    context.Writer.WritePropertyName("GameSessionData");
                    context.Writer.Write(publicRequest.GameSessionData);
                }

                if(publicRequest.IsSetGameSessionId())
                {
                    context.Writer.WritePropertyName("GameSessionId");
                    context.Writer.Write(publicRequest.GameSessionId);
                }

                if(publicRequest.IsSetIdempotencyToken())
                {
                    context.Writer.WritePropertyName("IdempotencyToken");
                    context.Writer.Write(publicRequest.IdempotencyToken);
                }

                if(publicRequest.IsSetMaximumPlayerSessionCount())
                {
                    context.Writer.WritePropertyName("MaximumPlayerSessionCount");
                    context.Writer.Write(publicRequest.MaximumPlayerSessionCount);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateGameSessionRequestMarshaller _instance = new CreateGameSessionRequestMarshaller();        

        internal static CreateGameSessionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateGameSessionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}