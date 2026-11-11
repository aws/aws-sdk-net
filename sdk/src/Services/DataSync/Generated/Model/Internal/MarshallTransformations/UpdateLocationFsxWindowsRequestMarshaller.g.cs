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
    /// UpdateLocationFsxWindows Request Marshaller
    /// </summary>
    public partial class UpdateLocationFsxWindowsRequestMarshaller : IMarshaller<IRequest, UpdateLocationFsxWindowsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateLocationFsxWindowsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateLocationFsxWindowsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataSync");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-09";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/FmrsService/operation/UpdateLocationFsxWindows";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
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
                if (publicRequest.IsSetDomain())
                {
                    context.Writer.WriteTextString("Domain");
                    context.Writer.WriteTextString(publicRequest.Domain);
                }
                if (publicRequest.IsSetLocationArn())
                {
                    context.Writer.WriteTextString("LocationArn");
                    context.Writer.WriteTextString(publicRequest.LocationArn);
                }
                if (publicRequest.IsSetPassword())
                {
                    context.Writer.WriteTextString("Password");
                    context.Writer.WriteTextString(publicRequest.Password);
                }
                if (publicRequest.IsSetSubdirectory())
                {
                    context.Writer.WriteTextString("Subdirectory");
                    context.Writer.WriteTextString(publicRequest.Subdirectory);
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

        private static readonly UpdateLocationFsxWindowsRequestMarshaller _instance = new();

        internal static UpdateLocationFsxWindowsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateLocationFsxWindowsRequestMarshaller Instance => _instance;
    }
}
