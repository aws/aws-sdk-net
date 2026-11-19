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

using Amazon.CodeBuild.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.CodeBuild.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateWebhook Request Marshaller
    /// </summary>
    public partial class UpdateWebhookRequestMarshaller : IMarshaller<IRequest, UpdateWebhookRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateWebhookRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateWebhookRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeBuild");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-10-06";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/CodeBuild_20161006/operation/UpdateWebhook";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetBranchFilter())
                {
                    context.Writer.WriteTextString("branchFilter");
                    context.Writer.WriteTextString(publicRequest.BranchFilter);
                }
                if (publicRequest.IsSetBuildType())
                {
                    context.Writer.WriteTextString("buildType");
                    context.Writer.WriteTextString(publicRequest.BuildType);
                }
                if (publicRequest.IsSetFilterGroups())
                {
                    context.Writer.WriteTextString("filterGroups");
                    context.Writer.WriteStartArray(publicRequest.FilterGroups.Count);
                    foreach (var publicRequestFilterGroupsListValue in publicRequest.FilterGroups)
                    {
                        context.Writer.WriteStartArray(publicRequestFilterGroupsListValue.Count);
                        foreach (var publicRequestFilterGroupsListValueListValue in publicRequestFilterGroupsListValue)
                        {
                            context.Writer.WriteStartMap(null);

                            var marshaller = WebhookFilterMarshaller.Instance;
                            marshaller.Marshall(publicRequestFilterGroupsListValueListValue, context);

                            context.Writer.WriteEndMap();
                        }
                        context.Writer.WriteEndArray();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetProjectName())
                {
                    context.Writer.WriteTextString("projectName");
                    context.Writer.WriteTextString(publicRequest.ProjectName);
                }
                if (publicRequest.IsSetPullRequestBuildPolicy())
                {
                    context.Writer.WriteTextString("pullRequestBuildPolicy");
                    context.Writer.WriteStartMap(null);

                    var marshaller = PullRequestBuildPolicyMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PullRequestBuildPolicy, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetRotateSecret())
                {
                    context.Writer.WriteTextString("rotateSecret");
                    context.Writer.WriteBoolean(publicRequest.RotateSecret.Value);
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

        private static readonly UpdateWebhookRequestMarshaller _instance = new();

        internal static UpdateWebhookRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateWebhookRequestMarshaller Instance => _instance;
    }
}
