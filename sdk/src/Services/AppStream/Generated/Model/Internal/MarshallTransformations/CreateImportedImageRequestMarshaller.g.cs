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

using Amazon.AppStream.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateImportedImage Request Marshaller
    /// </summary>
    public partial class CreateImportedImageRequestMarshaller : IMarshaller<IRequest, CreateImportedImageRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateImportedImageRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateImportedImageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppStream");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-12-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/PhotonAdminProxyService/operation/CreateImportedImage";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAgentSoftwareVersion())
                {
                    context.Writer.WriteTextString("AgentSoftwareVersion");
                    context.Writer.WriteTextString(publicRequest.AgentSoftwareVersion);
                }
                if (publicRequest.IsSetAppCatalogConfig())
                {
                    context.Writer.WriteTextString("AppCatalogConfig");
                    context.Writer.WriteStartArray(publicRequest.AppCatalogConfig.Count);
                    foreach (var publicRequestAppCatalogConfigListValue in publicRequest.AppCatalogConfig)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = ApplicationConfigMarshaller.Instance;
                        marshaller.Marshall(publicRequestAppCatalogConfigListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetDescription())
                {
                    context.Writer.WriteTextString("Description");
                    context.Writer.WriteTextString(publicRequest.Description);
                }
                if (publicRequest.IsSetDisplayName())
                {
                    context.Writer.WriteTextString("DisplayName");
                    context.Writer.WriteTextString(publicRequest.DisplayName);
                }
                if (publicRequest.IsSetDryRun())
                {
                    context.Writer.WriteTextString("DryRun");
                    context.Writer.WriteBoolean(publicRequest.DryRun.Value);
                }
                if (publicRequest.IsSetIamRoleArn())
                {
                    context.Writer.WriteTextString("IamRoleArn");
                    context.Writer.WriteTextString(publicRequest.IamRoleArn);
                }
                if (publicRequest.IsSetName())
                {
                    context.Writer.WriteTextString("Name");
                    context.Writer.WriteTextString(publicRequest.Name);
                }
                if (publicRequest.IsSetRuntimeValidationConfig())
                {
                    context.Writer.WriteTextString("RuntimeValidationConfig");
                    context.Writer.WriteStartMap(null);

                    var marshaller = RuntimeValidationConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RuntimeValidationConfig, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetSourceAmiId())
                {
                    context.Writer.WriteTextString("SourceAmiId");
                    context.Writer.WriteTextString(publicRequest.SourceAmiId);
                }
                if (publicRequest.IsSetTags())
                {
                    context.Writer.WriteTextString("Tags");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WriteTextString(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;
                        context.Writer.WriteTextString(publicRequestTagsValue);
                    }
                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetWorkspaceImageId())
                {
                    context.Writer.WriteTextString("WorkspaceImageId");
                    context.Writer.WriteTextString(publicRequest.WorkspaceImageId);
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

        private static readonly CreateImportedImageRequestMarshaller _instance = new();

        internal static CreateImportedImageRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateImportedImageRequestMarshaller Instance => _instance;
    }
}
