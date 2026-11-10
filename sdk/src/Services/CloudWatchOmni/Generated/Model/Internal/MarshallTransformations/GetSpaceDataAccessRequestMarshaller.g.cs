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

using Amazon.CloudWatchOmni.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.CloudWatchOmni.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetSpaceDataAccess Request Marshaller
    /// </summary>
    public partial class GetSpaceDataAccessRequestMarshaller : IMarshaller<IRequest, GetSpaceDataAccessRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetSpaceDataAccessRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetSpaceDataAccessRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchOmni");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-01-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/CloudWatchOmniFrontend/operation/GetSpaceDataAccess";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAuditContext())
                {
                    context.Writer.WriteTextString("auditContext");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestAuditContextKvp in publicRequest.AuditContext)
                    {
                        context.Writer.WriteTextString(publicRequestAuditContextKvp.Key);
                        var publicRequestAuditContextValue = publicRequestAuditContextKvp.Value;
                        context.Writer.WriteTextString(publicRequestAuditContextValue);
                    }
                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetDurationSeconds())
                {
                    context.Writer.WriteTextString("durationSeconds");
                    context.Writer.WriteInt32(publicRequest.DurationSeconds.Value);
                }
                if (publicRequest.IsSetSpaceId())
                {
                    context.Writer.WriteTextString("spaceId");
                    context.Writer.WriteTextString(publicRequest.SpaceId);
                }
                if (publicRequest.IsSetTargetScopes())
                {
                    context.Writer.WriteTextString("targetScopes");
                    context.Writer.WriteStartArray(publicRequest.TargetScopes.Count);
                    foreach (var publicRequestTargetScopesListValue in publicRequest.TargetScopes)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = DataAccessTargetMarshaller.Instance;
                        marshaller.Marshall(publicRequestTargetScopesListValue, context);

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

        private static readonly GetSpaceDataAccessRequestMarshaller _instance = new();

        internal static GetSpaceDataAccessRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetSpaceDataAccessRequestMarshaller Instance => _instance;
    }
}
