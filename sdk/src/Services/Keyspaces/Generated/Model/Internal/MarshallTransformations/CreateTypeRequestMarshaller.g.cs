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

using Amazon.Keyspaces.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.Keyspaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateType Request Marshaller
    /// </summary>
    public partial class CreateTypeRequestMarshaller : IMarshaller<IRequest, CreateTypeRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTypeRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateTypeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Keyspaces");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-02-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/KeyspacesService/operation/CreateType";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetFieldDefinitions())
                {
                    context.Writer.WriteTextString("fieldDefinitions");
                    context.Writer.WriteStartArray(publicRequest.FieldDefinitions.Count);
                    foreach (var publicRequestFieldDefinitionsListValue in publicRequest.FieldDefinitions)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = FieldDefinitionMarshaller.Instance;
                        marshaller.Marshall(publicRequestFieldDefinitionsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetKeyspaceName())
                {
                    context.Writer.WriteTextString("keyspaceName");
                    context.Writer.WriteTextString(publicRequest.KeyspaceName);
                }
                if (publicRequest.IsSetTypeName())
                {
                    context.Writer.WriteTextString("typeName");
                    context.Writer.WriteTextString(publicRequest.TypeName);
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

        private static readonly CreateTypeRequestMarshaller _instance = new();

        internal static CreateTypeRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateTypeRequestMarshaller Instance => _instance;
    }
}
