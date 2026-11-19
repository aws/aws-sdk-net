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
    /// DescribeWorkspaces Request Marshaller
    /// </summary>
    public partial class DescribeWorkspacesRequestMarshaller : IMarshaller<IRequest, DescribeWorkspacesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeWorkspacesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribeWorkspacesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkSpaces");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-04-08";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/WorkspacesService/operation/DescribeWorkspaces";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetBundleId())
                {
                    context.Writer.WriteTextString("BundleId");
                    context.Writer.WriteTextString(publicRequest.BundleId);
                }
                if (publicRequest.IsSetDirectoryId())
                {
                    context.Writer.WriteTextString("DirectoryId");
                    context.Writer.WriteTextString(publicRequest.DirectoryId);
                }
                if (publicRequest.IsSetLimit())
                {
                    context.Writer.WriteTextString("Limit");
                    context.Writer.WriteInt32(publicRequest.Limit.Value);
                }
                if (publicRequest.IsSetNextToken())
                {
                    context.Writer.WriteTextString("NextToken");
                    context.Writer.WriteTextString(publicRequest.NextToken);
                }
                if (publicRequest.IsSetUserName())
                {
                    context.Writer.WriteTextString("UserName");
                    context.Writer.WriteTextString(publicRequest.UserName);
                }
                if (publicRequest.IsSetWorkspaceIds())
                {
                    context.Writer.WriteTextString("WorkspaceIds");
                    context.Writer.WriteStartArray(publicRequest.WorkspaceIds.Count);
                    foreach (var publicRequestWorkspaceIdsListValue in publicRequest.WorkspaceIds)
                    {
                        context.Writer.WriteTextString(publicRequestWorkspaceIdsListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetWorkspaceName())
                {
                    context.Writer.WriteTextString("WorkspaceName");
                    context.Writer.WriteTextString(publicRequest.WorkspaceName);
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

        private static readonly DescribeWorkspacesRequestMarshaller _instance = new();

        internal static DescribeWorkspacesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeWorkspacesRequestMarshaller Instance => _instance;
    }
}
