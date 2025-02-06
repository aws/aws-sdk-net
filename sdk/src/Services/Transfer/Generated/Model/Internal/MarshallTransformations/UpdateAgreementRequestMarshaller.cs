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
    /// UpdateAgreement Request Marshaller
    /// </summary>       
    public class UpdateAgreementRequestMarshaller : IMarshaller<IRequest, UpdateAgreementRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAgreementRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAgreementRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Transfer");
            string target = "TransferService.UpdateAgreement";
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

            if(publicRequest.IsSetAgreementId())
            {
                context.Writer.WritePropertyName("AgreementId");
                context.Writer.WriteStringValue(publicRequest.AgreementId);
            }

            if(publicRequest.IsSetBaseDirectory())
            {
                context.Writer.WritePropertyName("BaseDirectory");
                context.Writer.WriteStringValue(publicRequest.BaseDirectory);
            }

            if(publicRequest.IsSetCustomDirectories())
            {
                context.Writer.WritePropertyName("CustomDirectories");
                context.Writer.WriteStartObject();

                var marshaller = CustomDirectoriesTypeMarshaller.Instance;
                marshaller.Marshall(publicRequest.CustomDirectories, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEnforceMessageSigning())
            {
                context.Writer.WritePropertyName("EnforceMessageSigning");
                context.Writer.WriteStringValue(publicRequest.EnforceMessageSigning);
            }

            if(publicRequest.IsSetLocalProfileId())
            {
                context.Writer.WritePropertyName("LocalProfileId");
                context.Writer.WriteStringValue(publicRequest.LocalProfileId);
            }

            if(publicRequest.IsSetPartnerProfileId())
            {
                context.Writer.WritePropertyName("PartnerProfileId");
                context.Writer.WriteStringValue(publicRequest.PartnerProfileId);
            }

            if(publicRequest.IsSetPreserveFilename())
            {
                context.Writer.WritePropertyName("PreserveFilename");
                context.Writer.WriteStringValue(publicRequest.PreserveFilename);
            }

            if(publicRequest.IsSetServerId())
            {
                context.Writer.WritePropertyName("ServerId");
                context.Writer.WriteStringValue(publicRequest.ServerId);
            }

            if(publicRequest.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStringValue(publicRequest.Status);
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
        private static UpdateAgreementRequestMarshaller _instance = new UpdateAgreementRequestMarshaller();        

        internal static UpdateAgreementRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAgreementRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}