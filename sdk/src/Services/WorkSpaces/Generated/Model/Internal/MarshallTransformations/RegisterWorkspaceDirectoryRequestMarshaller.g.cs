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
    /// RegisterWorkspaceDirectory Request Marshaller
    /// </summary>
    public partial class RegisterWorkspaceDirectoryRequestMarshaller : IMarshaller<IRequest, RegisterWorkspaceDirectoryRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RegisterWorkspaceDirectoryRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(RegisterWorkspaceDirectoryRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkSpaces");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-04-08";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/WorkspacesService/operation/RegisterWorkspaceDirectory";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetActiveDirectoryConfig())
                {
                    context.Writer.WriteTextString("ActiveDirectoryConfig");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ActiveDirectoryConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ActiveDirectoryConfig, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetDirectoryId())
                {
                    context.Writer.WriteTextString("DirectoryId");
                    context.Writer.WriteTextString(publicRequest.DirectoryId);
                }
                if (publicRequest.IsSetEnableSelfService())
                {
                    context.Writer.WriteTextString("EnableSelfService");
                    context.Writer.WriteBoolean(publicRequest.EnableSelfService.Value);
                }
                if (publicRequest.IsSetIdcInstanceArn())
                {
                    context.Writer.WriteTextString("IdcInstanceArn");
                    context.Writer.WriteTextString(publicRequest.IdcInstanceArn);
                }
                if (publicRequest.IsSetMicrosoftEntraConfig())
                {
                    context.Writer.WriteTextString("MicrosoftEntraConfig");
                    context.Writer.WriteStartMap(null);

                    var marshaller = MicrosoftEntraConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MicrosoftEntraConfig, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetSubnetIds())
                {
                    context.Writer.WriteTextString("SubnetIds");
                    context.Writer.WriteStartArray(publicRequest.SubnetIds.Count);
                    foreach (var publicRequestSubnetIdsListValue in publicRequest.SubnetIds)
                    {
                        context.Writer.WriteTextString(publicRequestSubnetIdsListValue);
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
                if (publicRequest.IsSetTenancy())
                {
                    context.Writer.WriteTextString("Tenancy");
                    context.Writer.WriteTextString(publicRequest.Tenancy);
                }
                if (publicRequest.IsSetUserIdentityType())
                {
                    context.Writer.WriteTextString("UserIdentityType");
                    context.Writer.WriteTextString(publicRequest.UserIdentityType);
                }
                if (publicRequest.IsSetWorkspaceDirectoryDescription())
                {
                    context.Writer.WriteTextString("WorkspaceDirectoryDescription");
                    context.Writer.WriteTextString(publicRequest.WorkspaceDirectoryDescription);
                }
                if (publicRequest.IsSetWorkspaceDirectoryName())
                {
                    context.Writer.WriteTextString("WorkspaceDirectoryName");
                    context.Writer.WriteTextString(publicRequest.WorkspaceDirectoryName);
                }
                if (publicRequest.IsSetWorkspaceType())
                {
                    context.Writer.WriteTextString("WorkspaceType");
                    context.Writer.WriteTextString(publicRequest.WorkspaceType);
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

        private static readonly RegisterWorkspaceDirectoryRequestMarshaller _instance = new();

        internal static RegisterWorkspaceDirectoryRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RegisterWorkspaceDirectoryRequestMarshaller Instance => _instance;
    }
}
