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

using Amazon.MailManager.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.MailManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateTrafficPolicy Request Marshaller
    /// </summary>
    public partial class UpdateTrafficPolicyRequestMarshaller : IMarshaller<IRequest, UpdateTrafficPolicyRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateTrafficPolicyRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateTrafficPolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MailManager");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-10-17";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/MailManagerSvc/operation/UpdateTrafficPolicy";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetDefaultAction())
                {
                    context.Writer.WriteTextString("DefaultAction");
                    context.Writer.WriteTextString(publicRequest.DefaultAction);
                }
                if (publicRequest.IsSetMaxMessageSizeBytes())
                {
                    context.Writer.WriteTextString("MaxMessageSizeBytes");
                    context.Writer.WriteInt32(publicRequest.MaxMessageSizeBytes.Value);
                }
                if (publicRequest.IsSetPolicyStatements())
                {
                    context.Writer.WriteTextString("PolicyStatements");
                    context.Writer.WriteStartArray(publicRequest.PolicyStatements.Count);
                    foreach (var publicRequestPolicyStatementsListValue in publicRequest.PolicyStatements)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = PolicyStatementMarshaller.Instance;
                        marshaller.Marshall(publicRequestPolicyStatementsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetTrafficPolicyId())
                {
                    context.Writer.WriteTextString("TrafficPolicyId");
                    context.Writer.WriteTextString(publicRequest.TrafficPolicyId);
                }
                if (publicRequest.IsSetTrafficPolicyName())
                {
                    context.Writer.WriteTextString("TrafficPolicyName");
                    context.Writer.WriteTextString(publicRequest.TrafficPolicyName);
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

        private static readonly UpdateTrafficPolicyRequestMarshaller _instance = new();

        internal static UpdateTrafficPolicyRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateTrafficPolicyRequestMarshaller Instance => _instance;
    }
}
