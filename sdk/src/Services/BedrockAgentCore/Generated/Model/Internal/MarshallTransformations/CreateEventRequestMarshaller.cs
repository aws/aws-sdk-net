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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentCore.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentCore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateEvent Request Marshaller
    /// </summary>       
    public class CreateEventRequestMarshaller : IMarshaller<IRequest, CreateEventRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateEventRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateEventRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCore");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-02-28";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetMemoryId())
                throw new AmazonBedrockAgentCoreException("Request object does not have required field MemoryId set");
            request.AddPathResource("{memoryId}", StringUtils.FromString(publicRequest.MemoryId));
            request.ResourcePath = "/memories/{memoryId}/events";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetActorId())
                {
                    context.Writer.WritePropertyName("actorId");
                    context.Writer.Write(publicRequest.ActorId);
                }

                if(publicRequest.IsSetBranch())
                {
                    context.Writer.WritePropertyName("branch");
                    context.Writer.WriteObjectStart();

                    var marshaller = BranchMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Branch, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetEventTimestamp())
                {
                    context.Writer.WritePropertyName("eventTimestamp");
                    context.Writer.Write(publicRequest.EventTimestamp);
                }

                if(publicRequest.IsSetMetadata())
                {
                    context.Writer.WritePropertyName("metadata");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestMetadataKvp in publicRequest.Metadata)
                    {
                        context.Writer.WritePropertyName(publicRequestMetadataKvp.Key);
                        var publicRequestMetadataValue = publicRequestMetadataKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = MetadataValueMarshaller.Instance;
                        marshaller.Marshall(publicRequestMetadataValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPayload())
                {
                    context.Writer.WritePropertyName("payload");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPayloadListValue in publicRequest.Payload)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = PayloadTypeMarshaller.Instance;
                        marshaller.Marshall(publicRequestPayloadListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSessionId())
                {
                    context.Writer.WritePropertyName("sessionId");
                    context.Writer.Write(publicRequest.SessionId);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateEventRequestMarshaller _instance = new CreateEventRequestMarshaller();        

        internal static CreateEventRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateEventRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}