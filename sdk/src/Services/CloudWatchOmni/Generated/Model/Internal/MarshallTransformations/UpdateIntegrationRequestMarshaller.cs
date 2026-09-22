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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchOmni.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchOmni.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateIntegration Request Marshaller
    /// </summary>       
    public class UpdateIntegrationRequestMarshaller : IMarshaller<IRequest, UpdateIntegrationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateIntegrationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateIntegrationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchOmni");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/CloudWatchOmniFrontend/operation/UpdateIntegration";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-01-01";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetCredential())
                {
                    context.Writer.WriteTextString("credential");
                    context.Writer.WriteStartMap(null);

                    var marshaller = IntegrationCredentialMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Credential, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetIdentifier())
                {
                    context.Writer.WriteTextString("identifier");
                    context.Writer.WriteStartMap(null);

                    var marshaller = IntegrationIdentifierMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Identifier, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetIntegrationAttributes())
                {
                    context.Writer.WriteTextString("integrationAttributes");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestIntegrationAttributesKvp in publicRequest.IntegrationAttributes)
                    {
                        context.Writer.WriteTextString(publicRequestIntegrationAttributesKvp.Key);
                        var publicRequestIntegrationAttributesValue = publicRequestIntegrationAttributesKvp.Value;

                            context.Writer.WriteTextString(publicRequestIntegrationAttributesValue);
                    }
                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetRoleArn())
                {
                    context.Writer.WriteTextString("roleArn");
                    context.Writer.WriteTextString(publicRequest.RoleArn);
                }
                writer.WriteEndMap();
#if !NETFRAMEWORK
                // Encode directly into a pooled buffer instead of allocating a new byte[] per request.
                // The buffer is pre-sized to writer.BytesWritten so it's rented at the right size up front,
                // avoiding the default-size rent followed by a resize+return.
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
        private static UpdateIntegrationRequestMarshaller _instance = new UpdateIntegrationRequestMarshaller();        

        internal static UpdateIntegrationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateIntegrationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}