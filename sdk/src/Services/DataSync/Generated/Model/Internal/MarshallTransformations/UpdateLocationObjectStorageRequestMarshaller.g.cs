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

using Amazon.DataSync.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.DataSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateLocationObjectStorage Request Marshaller
    /// </summary>
    public partial class UpdateLocationObjectStorageRequestMarshaller : IMarshaller<IRequest, UpdateLocationObjectStorageRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateLocationObjectStorageRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateLocationObjectStorageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataSync");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-09";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/FmrsService/operation/UpdateLocationObjectStorage";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAccessKey())
                {
                    context.Writer.WriteTextString("AccessKey");
                    context.Writer.WriteTextString(publicRequest.AccessKey);
                }
                if (publicRequest.IsSetAgentArns())
                {
                    context.Writer.WriteTextString("AgentArns");
                    context.Writer.WriteStartArray(publicRequest.AgentArns.Count);
                    foreach (var publicRequestAgentArnsListValue in publicRequest.AgentArns)
                    {
                        context.Writer.WriteTextString(publicRequestAgentArnsListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetCmkSecretConfig())
                {
                    context.Writer.WriteTextString("CmkSecretConfig");
                    context.Writer.WriteStartMap(null);

                    var marshaller = CmkSecretConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CmkSecretConfig, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetCustomSecretConfig())
                {
                    context.Writer.WriteTextString("CustomSecretConfig");
                    context.Writer.WriteStartMap(null);

                    var marshaller = CustomSecretConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CustomSecretConfig, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetFederatedIdentity())
                {
                    context.Writer.WriteTextString("FederatedIdentity");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ObjectStorageFederatedIdentityConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.FederatedIdentity, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetLocationArn())
                {
                    context.Writer.WriteTextString("LocationArn");
                    context.Writer.WriteTextString(publicRequest.LocationArn);
                }
                if (publicRequest.IsSetSecretKey())
                {
                    context.Writer.WriteTextString("SecretKey");
                    context.Writer.WriteTextString(publicRequest.SecretKey);
                }
                if (publicRequest.IsSetServerCertificate())
                {
                    context.Writer.WriteTextString("ServerCertificate");
                    context.Writer.WriteByteString(publicRequest.ServerCertificate);
                }
                if (publicRequest.IsSetServerHostname())
                {
                    context.Writer.WriteTextString("ServerHostname");
                    context.Writer.WriteTextString(publicRequest.ServerHostname);
                }
                if (publicRequest.IsSetServerPort())
                {
                    context.Writer.WriteTextString("ServerPort");
                    context.Writer.WriteInt32(publicRequest.ServerPort.Value);
                }
                if (publicRequest.IsSetServerProtocol())
                {
                    context.Writer.WriteTextString("ServerProtocol");
                    context.Writer.WriteTextString(publicRequest.ServerProtocol);
                }
                if (publicRequest.IsSetSubdirectory())
                {
                    context.Writer.WriteTextString("Subdirectory");
                    context.Writer.WriteTextString(publicRequest.Subdirectory);
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

        private static readonly UpdateLocationObjectStorageRequestMarshaller _instance = new();

        internal static UpdateLocationObjectStorageRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateLocationObjectStorageRequestMarshaller Instance => _instance;
    }
}
