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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
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
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAgent Request Marshaller
    /// </summary>       
    public class UpdateAgentRequestMarshaller : IMarshaller<IRequest, UpdateAgentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAgentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAgentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QuickSight");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-01";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetAgentId())
                throw new AmazonQuickSightException("Request object does not have required field AgentId set");
            request.AddPathResource("{AgentId}", StringUtils.FromString(publicRequest.AgentId));
            if (!publicRequest.IsSetAwsAccountId())
                throw new AmazonQuickSightException("Request object does not have required field AwsAccountId set");
            request.AddPathResource("{AwsAccountId}", StringUtils.FromString(publicRequest.AwsAccountId));
            request.ResourcePath = "/accounts/{AwsAccountId}/agents/{AgentId}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetActionConnectorsToAdd())
            {
                context.Writer.WritePropertyName("ActionConnectorsToAdd");
                context.Writer.WriteStartArray();
                foreach(var publicRequestActionConnectorsToAddListValue in publicRequest.ActionConnectorsToAdd)
                {
                        context.Writer.WriteStringValue(publicRequestActionConnectorsToAddListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetActionConnectorsToRemove())
            {
                context.Writer.WritePropertyName("ActionConnectorsToRemove");
                context.Writer.WriteStartArray();
                foreach(var publicRequestActionConnectorsToRemoveListValue in publicRequest.ActionConnectorsToRemove)
                {
                        context.Writer.WriteStringValue(publicRequestActionConnectorsToRemoveListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetCustomPromptInput())
            {
                context.Writer.WritePropertyName("CustomPromptInput");
                context.Writer.WriteStartObject();

                var marshaller = CustomPromptInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.CustomPromptInput, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetIconId())
            {
                context.Writer.WritePropertyName("IconId");
                context.Writer.WriteStringValue(publicRequest.IconId);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetSpacesToAdd())
            {
                context.Writer.WritePropertyName("SpacesToAdd");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSpacesToAddListValue in publicRequest.SpacesToAdd)
                {
                        context.Writer.WriteStringValue(publicRequestSpacesToAddListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSpacesToRemove())
            {
                context.Writer.WritePropertyName("SpacesToRemove");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSpacesToRemoveListValue in publicRequest.SpacesToRemove)
                {
                        context.Writer.WriteStringValue(publicRequestSpacesToRemoveListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetStarterPrompts())
            {
                context.Writer.WritePropertyName("StarterPrompts");
                context.Writer.WriteStartArray();
                foreach(var publicRequestStarterPromptsListValue in publicRequest.StarterPrompts)
                {
                        context.Writer.WriteStringValue(publicRequestStarterPromptsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetWelcomeMessage())
            {
                context.Writer.WritePropertyName("WelcomeMessage");
                context.Writer.WriteStringValue(publicRequest.WelcomeMessage);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static UpdateAgentRequestMarshaller _instance = new UpdateAgentRequestMarshaller();        

        internal static UpdateAgentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAgentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}