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
    /// CreateWorkspaceBundle Request Marshaller
    /// </summary>
    public partial class CreateWorkspaceBundleRequestMarshaller : IMarshaller<IRequest, CreateWorkspaceBundleRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateWorkspaceBundleRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateWorkspaceBundleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkSpaces");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-04-08";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/WorkspacesService/operation/CreateWorkspaceBundle";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetBundleDescription())
                {
                    context.Writer.WriteTextString("BundleDescription");
                    context.Writer.WriteTextString(publicRequest.BundleDescription);
                }
                if (publicRequest.IsSetBundleName())
                {
                    context.Writer.WriteTextString("BundleName");
                    context.Writer.WriteTextString(publicRequest.BundleName);
                }
                if (publicRequest.IsSetComputeType())
                {
                    context.Writer.WriteTextString("ComputeType");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ComputeTypeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ComputeType, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetImageId())
                {
                    context.Writer.WriteTextString("ImageId");
                    context.Writer.WriteTextString(publicRequest.ImageId);
                }
                if (publicRequest.IsSetRootStorage())
                {
                    context.Writer.WriteTextString("RootStorage");
                    context.Writer.WriteStartMap(null);

                    var marshaller = RootStorageMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RootStorage, context);

                    context.Writer.WriteEndMap();
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
                if (publicRequest.IsSetUserStorage())
                {
                    context.Writer.WriteTextString("UserStorage");
                    context.Writer.WriteStartMap(null);

                    var marshaller = UserStorageMarshaller.Instance;
                    marshaller.Marshall(publicRequest.UserStorage, context);

                    context.Writer.WriteEndMap();
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

        private static readonly CreateWorkspaceBundleRequestMarshaller _instance = new();

        internal static CreateWorkspaceBundleRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateWorkspaceBundleRequestMarshaller Instance => _instance;
    }
}
