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
    /// UpdateLocationHdfs Request Marshaller
    /// </summary>
    public partial class UpdateLocationHdfsRequestMarshaller : IMarshaller<IRequest, UpdateLocationHdfsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateLocationHdfsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateLocationHdfsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataSync");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-09";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/FmrsService/operation/UpdateLocationHdfs";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
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
                if (publicRequest.IsSetAuthenticationType())
                {
                    context.Writer.WriteTextString("AuthenticationType");
                    context.Writer.WriteTextString(publicRequest.AuthenticationType);
                }
                if (publicRequest.IsSetBlockSize())
                {
                    context.Writer.WriteTextString("BlockSize");
                    context.Writer.WriteInt32(publicRequest.BlockSize.Value);
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
                if (publicRequest.IsSetKerberosKeytab())
                {
                    context.Writer.WriteTextString("KerberosKeytab");
                    context.Writer.WriteByteString(publicRequest.KerberosKeytab);
                }
                if (publicRequest.IsSetKerberosKrb5Conf())
                {
                    context.Writer.WriteTextString("KerberosKrb5Conf");
                    context.Writer.WriteByteString(publicRequest.KerberosKrb5Conf);
                }
                if (publicRequest.IsSetKerberosPrincipal())
                {
                    context.Writer.WriteTextString("KerberosPrincipal");
                    context.Writer.WriteTextString(publicRequest.KerberosPrincipal);
                }
                if (publicRequest.IsSetKmsKeyProviderUri())
                {
                    context.Writer.WriteTextString("KmsKeyProviderUri");
                    context.Writer.WriteTextString(publicRequest.KmsKeyProviderUri);
                }
                if (publicRequest.IsSetLocationArn())
                {
                    context.Writer.WriteTextString("LocationArn");
                    context.Writer.WriteTextString(publicRequest.LocationArn);
                }
                if (publicRequest.IsSetNameNodes())
                {
                    context.Writer.WriteTextString("NameNodes");
                    context.Writer.WriteStartArray(publicRequest.NameNodes.Count);
                    foreach (var publicRequestNameNodesListValue in publicRequest.NameNodes)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = HdfsNameNodeMarshaller.Instance;
                        marshaller.Marshall(publicRequestNameNodesListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetQopConfiguration())
                {
                    context.Writer.WriteTextString("QopConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = QopConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.QopConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetReplicationFactor())
                {
                    context.Writer.WriteTextString("ReplicationFactor");
                    context.Writer.WriteInt32(publicRequest.ReplicationFactor.Value);
                }
                if (publicRequest.IsSetSimpleUser())
                {
                    context.Writer.WriteTextString("SimpleUser");
                    context.Writer.WriteTextString(publicRequest.SimpleUser);
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

        private static readonly UpdateLocationHdfsRequestMarshaller _instance = new();

        internal static UpdateLocationHdfsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateLocationHdfsRequestMarshaller Instance => _instance;
    }
}
