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
    /// CreateWorkspacesPool Request Marshaller
    /// </summary>
    public partial class CreateWorkspacesPoolRequestMarshaller : IMarshaller<IRequest, CreateWorkspacesPoolRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateWorkspacesPoolRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateWorkspacesPoolRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkSpaces");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-04-08";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/WorkspacesService/operation/CreateWorkspacesPool";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetApplicationSettings())
                {
                    context.Writer.WriteTextString("ApplicationSettings");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ApplicationSettingsRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ApplicationSettings, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetBundleId())
                {
                    context.Writer.WriteTextString("BundleId");
                    context.Writer.WriteTextString(publicRequest.BundleId);
                }
                if (publicRequest.IsSetCapacity())
                {
                    context.Writer.WriteTextString("Capacity");
                    context.Writer.WriteStartMap(null);

                    var marshaller = CapacityMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Capacity, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetDescription())
                {
                    context.Writer.WriteTextString("Description");
                    context.Writer.WriteTextString(publicRequest.Description);
                }
                if (publicRequest.IsSetDirectoryId())
                {
                    context.Writer.WriteTextString("DirectoryId");
                    context.Writer.WriteTextString(publicRequest.DirectoryId);
                }
                if (publicRequest.IsSetPoolName())
                {
                    context.Writer.WriteTextString("PoolName");
                    context.Writer.WriteTextString(publicRequest.PoolName);
                }
                if (publicRequest.IsSetRunningMode())
                {
                    context.Writer.WriteTextString("RunningMode");
                    context.Writer.WriteTextString(publicRequest.RunningMode);
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
                if (publicRequest.IsSetTimeoutSettings())
                {
                    context.Writer.WriteTextString("TimeoutSettings");
                    context.Writer.WriteStartMap(null);

                    var marshaller = TimeoutSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TimeoutSettings, context);

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

        private static readonly CreateWorkspacesPoolRequestMarshaller _instance = new();

        internal static CreateWorkspacesPoolRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateWorkspacesPoolRequestMarshaller Instance => _instance;
    }
}
