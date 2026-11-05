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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.GameLift.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateContainerGroupDefinition Request Marshaller
    /// </summary>
    public partial class CreateContainerGroupDefinitionRequestMarshaller : IMarshaller<IRequest, CreateContainerGroupDefinitionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateContainerGroupDefinitionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateContainerGroupDefinitionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameLift");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-10-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/GameLift/operation/CreateContainerGroupDefinition";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetContainerGroupType())
                {
                    context.Writer.WriteTextString("ContainerGroupType");
                    context.Writer.WriteTextString(publicRequest.ContainerGroupType);
                }
                if (publicRequest.IsSetGameServerContainerDefinition())
                {
                    context.Writer.WriteTextString("GameServerContainerDefinition");
                    context.Writer.WriteStartMap(null);

                    var marshaller = GameServerContainerDefinitionInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.GameServerContainerDefinition, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetName())
                {
                    context.Writer.WriteTextString("Name");
                    context.Writer.WriteTextString(publicRequest.Name);
                }
                if (publicRequest.IsSetOperatingSystem())
                {
                    context.Writer.WriteTextString("OperatingSystem");
                    context.Writer.WriteTextString(publicRequest.OperatingSystem);
                }
                if (publicRequest.IsSetSupportContainerDefinitions())
                {
                    context.Writer.WriteTextString("SupportContainerDefinitions");
                    context.Writer.WriteStartArray(publicRequest.SupportContainerDefinitions.Count);
                    foreach (var publicRequestSupportContainerDefinitionsListValue in publicRequest.SupportContainerDefinitions)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = SupportContainerDefinitionInputMarshaller.Instance;
                        marshaller.Marshall(publicRequestSupportContainerDefinitionsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetTags())
                {
                    context.Writer.WriteTextString("Tags");
                    context.Writer.WriteStartArray(publicRequest.Tags.Count);
                    foreach (var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetTotalMemoryLimitMebibytes())
                {
                    context.Writer.WriteTextString("TotalMemoryLimitMebibytes");
                    context.Writer.WriteInt32(publicRequest.TotalMemoryLimitMebibytes.Value);
                }
                if (publicRequest.IsSetTotalVcpuLimit())
                {
                    context.Writer.WriteTextString("TotalVcpuLimit");
                    context.Writer.WriteOptimizedNumber(publicRequest.TotalVcpuLimit.Value);
                }
                if (publicRequest.IsSetVersionDescription())
                {
                    context.Writer.WriteTextString("VersionDescription");
                    context.Writer.WriteTextString(publicRequest.VersionDescription);
                }
                writer.WriteEndMap();
#if !NETFRAMEWORK
                var encodedLength = writer.BytesWritten;
                request.ContentStream = new PooledContentStream(encodedLength);
                var bufferWriter = ((PooledContentStream)request.ContentStream).BufferWriter;
                var span = bufferWriter.GetSpan(encodedLength);
                var bytesWritten = writer.Encode(span);
                bufferWriter.Advance(bytesWritten);
#else
                request.Content = writer.Encode();
#endif
            }
            finally
            {
                CborWriterPool.Return(writer);
            }

            return request;
        }

        private static readonly CreateContainerGroupDefinitionRequestMarshaller _instance = new();

        internal static CreateContainerGroupDefinitionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateContainerGroupDefinitionRequestMarshaller Instance => _instance;
    }
}
