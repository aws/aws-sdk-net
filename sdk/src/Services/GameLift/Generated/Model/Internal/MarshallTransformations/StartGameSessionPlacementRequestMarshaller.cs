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
    /// StartGameSessionPlacement Request Marshaller
    /// </summary>       
    public class StartGameSessionPlacementRequestMarshaller : IMarshaller<IRequest, StartGameSessionPlacementRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartGameSessionPlacementRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartGameSessionPlacementRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameLift");
            string target = "GameLift.StartGameSessionPlacement";
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
                if(publicRequest.IsSetDesiredPlayerSessions())
                {
                    context.Writer.WritePropertyName("DesiredPlayerSessions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDesiredPlayerSessionsListValue in publicRequest.DesiredPlayerSessions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = DesiredPlayerSessionMarshaller.Instance;
                        marshaller.Marshall(publicRequestDesiredPlayerSessionsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
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

                if(publicRequest.IsSetGameSessionName())
                {
                    context.Writer.WritePropertyName("GameSessionName");
                    context.Writer.Write(publicRequest.GameSessionName);
                }

                if(publicRequest.IsSetGameSessionQueueName())
                {
                    context.Writer.WritePropertyName("GameSessionQueueName");
                    context.Writer.Write(publicRequest.GameSessionQueueName);
                }

                if(publicRequest.IsSetMaximumPlayerSessionCount())
                {
                    context.Writer.WritePropertyName("MaximumPlayerSessionCount");
                    context.Writer.Write(publicRequest.MaximumPlayerSessionCount);
                }

                if(publicRequest.IsSetPlacementId())
                {
                    context.Writer.WritePropertyName("PlacementId");
                    context.Writer.Write(publicRequest.PlacementId);
                }

                if(publicRequest.IsSetPlayerLatencies())
                {
                    context.Writer.WritePropertyName("PlayerLatencies");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPlayerLatenciesListValue in publicRequest.PlayerLatencies)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = PlayerLatencyMarshaller.Instance;
                        marshaller.Marshall(publicRequestPlayerLatenciesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartGameSessionPlacementRequestMarshaller _instance = new StartGameSessionPlacementRequestMarshaller();        

        internal static StartGameSessionPlacementRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartGameSessionPlacementRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}