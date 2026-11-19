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
    /// CreateLocationSmb Request Marshaller
    /// </summary>
    public partial class CreateLocationSmbRequestMarshaller : IMarshaller<IRequest, CreateLocationSmbRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateLocationSmbRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateLocationSmbRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataSync");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-09";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/FmrsService/operation/CreateLocationSmb";
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
                if (publicRequest.IsSetDnsIpAddresses())
                {
                    context.Writer.WriteTextString("DnsIpAddresses");
                    context.Writer.WriteStartArray(publicRequest.DnsIpAddresses.Count);
                    foreach (var publicRequestDnsIpAddressesListValue in publicRequest.DnsIpAddresses)
                    {
                        context.Writer.WriteTextString(publicRequestDnsIpAddressesListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetDomain())
                {
                    context.Writer.WriteTextString("Domain");
                    context.Writer.WriteTextString(publicRequest.Domain);
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
                if (publicRequest.IsSetMountOptions())
                {
                    context.Writer.WriteTextString("MountOptions");
                    context.Writer.WriteStartMap(null);

                    var marshaller = SmbMountOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MountOptions, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetPassword())
                {
                    context.Writer.WriteTextString("Password");
                    context.Writer.WriteTextString(publicRequest.Password);
                }
                if (publicRequest.IsSetServerHostname())
                {
                    context.Writer.WriteTextString("ServerHostname");
                    context.Writer.WriteTextString(publicRequest.ServerHostname);
                }
                if (publicRequest.IsSetSubdirectory())
                {
                    context.Writer.WriteTextString("Subdirectory");
                    context.Writer.WriteTextString(publicRequest.Subdirectory);
                }
                if (publicRequest.IsSetTags())
                {
                    context.Writer.WriteTextString("Tags");
                    context.Writer.WriteStartArray(publicRequest.Tags.Count);
                    foreach (var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = TagListEntryMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetUser())
                {
                    context.Writer.WriteTextString("User");
                    context.Writer.WriteTextString(publicRequest.User);
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

        private static readonly CreateLocationSmbRequestMarshaller _instance = new();

        internal static CreateLocationSmbRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateLocationSmbRequestMarshaller Instance => _instance;
    }
}
