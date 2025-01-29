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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTTwinMaker.Model;
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
namespace Amazon.IoTTwinMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateEntity Request Marshaller
    /// </summary>       
    public class UpdateEntityRequestMarshaller : IMarshaller<IRequest, UpdateEntityRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateEntityRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateEntityRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTTwinMaker");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-11-29";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetEntityId())
                throw new AmazonIoTTwinMakerException("Request object does not have required field EntityId set");
            request.AddPathResource("{entityId}", StringUtils.FromString(publicRequest.EntityId));
            if (!publicRequest.IsSetWorkspaceId())
                throw new AmazonIoTTwinMakerException("Request object does not have required field WorkspaceId set");
            request.AddPathResource("{workspaceId}", StringUtils.FromString(publicRequest.WorkspaceId));
            request.ResourcePath = "/workspaces/{workspaceId}/entities/{entityId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetComponentUpdates())
            {
                context.Writer.WritePropertyName("componentUpdates");
                context.Writer.WriteStartObject();
                foreach (var publicRequestComponentUpdatesKvp in publicRequest.ComponentUpdates)
                {
                    context.Writer.WritePropertyName(publicRequestComponentUpdatesKvp.Key);
                    var publicRequestComponentUpdatesValue = publicRequestComponentUpdatesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = ComponentUpdateRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequestComponentUpdatesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCompositeComponentUpdates())
            {
                context.Writer.WritePropertyName("compositeComponentUpdates");
                context.Writer.WriteStartObject();
                foreach (var publicRequestCompositeComponentUpdatesKvp in publicRequest.CompositeComponentUpdates)
                {
                    context.Writer.WritePropertyName(publicRequestCompositeComponentUpdatesKvp.Key);
                    var publicRequestCompositeComponentUpdatesValue = publicRequestCompositeComponentUpdatesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = CompositeComponentUpdateRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequestCompositeComponentUpdatesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEntityName())
            {
                context.Writer.WritePropertyName("entityName");
                context.Writer.WriteStringValue(publicRequest.EntityName);
            }

            if(publicRequest.IsSetParentEntityUpdate())
            {
                context.Writer.WritePropertyName("parentEntityUpdate");
                context.Writer.WriteStartObject();

                var marshaller = ParentEntityUpdateRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.ParentEntityUpdate, context);

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
            

            
            request.HostPrefix = $"api.";

            return request;
        }
        private static UpdateEntityRequestMarshaller _instance = new UpdateEntityRequestMarshaller();        

        internal static UpdateEntityRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateEntityRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}