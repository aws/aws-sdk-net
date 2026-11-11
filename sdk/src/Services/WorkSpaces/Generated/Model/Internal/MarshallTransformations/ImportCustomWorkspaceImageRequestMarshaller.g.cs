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

using Amazon.WorkSpaces.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.WorkSpaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImportCustomWorkspaceImage Request Marshaller
    /// </summary>
    public partial class ImportCustomWorkspaceImageRequestMarshaller : IMarshaller<IRequest, ImportCustomWorkspaceImageRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ImportCustomWorkspaceImageRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ImportCustomWorkspaceImageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkSpaces");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-04-08";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/WorkspacesService/operation/ImportCustomWorkspaceImage";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetComputeType())
                {
                    context.Writer.WriteTextString("ComputeType");
                    context.Writer.WriteTextString(publicRequest.ComputeType);
                }
                if (publicRequest.IsSetImageDescription())
                {
                    context.Writer.WriteTextString("ImageDescription");
                    context.Writer.WriteTextString(publicRequest.ImageDescription);
                }
                if (publicRequest.IsSetImageName())
                {
                    context.Writer.WriteTextString("ImageName");
                    context.Writer.WriteTextString(publicRequest.ImageName);
                }
                if (publicRequest.IsSetImageSource())
                {
                    context.Writer.WriteTextString("ImageSource");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ImageSourceIdentifierMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ImageSource, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetImageValidationMode())
                {
                    context.Writer.WriteTextString("ImageValidationMode");
                    context.Writer.WriteTextString(publicRequest.ImageValidationMode);
                }
                if (publicRequest.IsSetInfrastructureConfigurationArn())
                {
                    context.Writer.WriteTextString("InfrastructureConfigurationArn");
                    context.Writer.WriteTextString(publicRequest.InfrastructureConfigurationArn);
                }
                if (publicRequest.IsSetOsVersion())
                {
                    context.Writer.WriteTextString("OsVersion");
                    context.Writer.WriteTextString(publicRequest.OsVersion);
                }
                if (publicRequest.IsSetPlatform())
                {
                    context.Writer.WriteTextString("Platform");
                    context.Writer.WriteTextString(publicRequest.Platform);
                }
                if (publicRequest.IsSetProtocol())
                {
                    context.Writer.WriteTextString("Protocol");
                    context.Writer.WriteTextString(publicRequest.Protocol);
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

        private static readonly ImportCustomWorkspaceImageRequestMarshaller _instance = new();

        internal static ImportCustomWorkspaceImageRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ImportCustomWorkspaceImageRequestMarshaller Instance => _instance;
    }
}
