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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Transfer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.Transfer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateConnector Request Marshaller
    /// </summary>       
    public class UpdateConnectorRequestMarshaller : IMarshaller<IRequest, UpdateConnectorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateConnectorRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateConnectorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Transfer");
            string target = "TransferService.UpdateConnector";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-05";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAccessRole())
            {
                context.Writer.WritePropertyName("AccessRole");
                context.Writer.WriteStringValue(publicRequest.AccessRole);
            }

            if(publicRequest.IsSetAs2Config())
            {
                context.Writer.WritePropertyName("As2Config");
                context.Writer.WriteStartObject();

                var marshaller = As2ConnectorConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.As2Config, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetConnectorId())
            {
                context.Writer.WritePropertyName("ConnectorId");
                context.Writer.WriteStringValue(publicRequest.ConnectorId);
            }

            if(publicRequest.IsSetLoggingRole())
            {
                context.Writer.WritePropertyName("LoggingRole");
                context.Writer.WriteStringValue(publicRequest.LoggingRole);
            }

            if(publicRequest.IsSetSecurityPolicyName())
            {
                context.Writer.WritePropertyName("SecurityPolicyName");
                context.Writer.WriteStringValue(publicRequest.SecurityPolicyName);
            }

            if(publicRequest.IsSetSftpConfig())
            {
                context.Writer.WritePropertyName("SftpConfig");
                context.Writer.WriteStartObject();

                var marshaller = SftpConnectorConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.SftpConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetUrl())
            {
                context.Writer.WritePropertyName("Url");
                context.Writer.WriteStringValue(publicRequest.Url);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static UpdateConnectorRequestMarshaller _instance = new UpdateConnectorRequestMarshaller();        

        internal static UpdateConnectorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateConnectorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}