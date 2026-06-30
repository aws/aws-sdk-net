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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkFirewall.Model;
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
namespace Amazon.NetworkFirewall.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateContainerAssociation Request Marshaller
    /// </summary>       
    public class UpdateContainerAssociationRequestMarshaller : IMarshaller<IRequest, UpdateContainerAssociationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateContainerAssociationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateContainerAssociationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkFirewall");
            string target = "NetworkFirewall_20201112.UpdateContainerAssociation";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-12";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetContainerAssociationArn())
            {
                context.Writer.WritePropertyName("ContainerAssociationArn");
                context.Writer.WriteStringValue(publicRequest.ContainerAssociationArn);
            }

            if(publicRequest.IsSetContainerAssociationName())
            {
                context.Writer.WritePropertyName("ContainerAssociationName");
                context.Writer.WriteStringValue(publicRequest.ContainerAssociationName);
            }

            if(publicRequest.IsSetContainerMonitoringConfigurations())
            {
                context.Writer.WritePropertyName("ContainerMonitoringConfigurations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestContainerMonitoringConfigurationsListValue in publicRequest.ContainerMonitoringConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ContainerMonitoringConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestContainerMonitoringConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteStringValue(publicRequest.Type);
            }

            if(publicRequest.IsSetUpdateToken())
            {
                context.Writer.WritePropertyName("UpdateToken");
                context.Writer.WriteStringValue(publicRequest.UpdateToken);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static UpdateContainerAssociationRequestMarshaller _instance = new UpdateContainerAssociationRequestMarshaller();        

        internal static UpdateContainerAssociationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateContainerAssociationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}