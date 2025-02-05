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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
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
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-10-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDesiredPlayerSessions())
            {
                context.Writer.WritePropertyName("DesiredPlayerSessions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDesiredPlayerSessionsListValue in publicRequest.DesiredPlayerSessions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DesiredPlayerSessionMarshaller.Instance;
                    marshaller.Marshall(publicRequestDesiredPlayerSessionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetGameProperties())
            {
                context.Writer.WritePropertyName("GameProperties");
                context.Writer.WriteStartArray();
                foreach(var publicRequestGamePropertiesListValue in publicRequest.GameProperties)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = GamePropertyMarshaller.Instance;
                    marshaller.Marshall(publicRequestGamePropertiesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetGameSessionData())
            {
                context.Writer.WritePropertyName("GameSessionData");
                context.Writer.WriteStringValue(publicRequest.GameSessionData);
            }

            if(publicRequest.IsSetGameSessionName())
            {
                context.Writer.WritePropertyName("GameSessionName");
                context.Writer.WriteStringValue(publicRequest.GameSessionName);
            }

            if(publicRequest.IsSetGameSessionQueueName())
            {
                context.Writer.WritePropertyName("GameSessionQueueName");
                context.Writer.WriteStringValue(publicRequest.GameSessionQueueName);
            }

            if(publicRequest.IsSetMaximumPlayerSessionCount())
            {
                context.Writer.WritePropertyName("MaximumPlayerSessionCount");
                context.Writer.WriteNumberValue(publicRequest.MaximumPlayerSessionCount.Value);
            }

            if(publicRequest.IsSetPlacementId())
            {
                context.Writer.WritePropertyName("PlacementId");
                context.Writer.WriteStringValue(publicRequest.PlacementId);
            }

            if(publicRequest.IsSetPlayerLatencies())
            {
                context.Writer.WritePropertyName("PlayerLatencies");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPlayerLatenciesListValue in publicRequest.PlayerLatencies)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PlayerLatencyMarshaller.Instance;
                    marshaller.Marshall(publicRequestPlayerLatenciesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetPriorityConfigurationOverride())
            {
                context.Writer.WritePropertyName("PriorityConfigurationOverride");
                context.Writer.WriteStartObject();

                var marshaller = PriorityConfigurationOverrideMarshaller.Instance;
                marshaller.Marshall(publicRequest.PriorityConfigurationOverride, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


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