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
    /// ImportCertificate Request Marshaller
    /// </summary>       
    public class ImportCertificateRequestMarshaller : IMarshaller<IRequest, ImportCertificateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ImportCertificateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ImportCertificateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Transfer");
            string target = "TransferService.ImportCertificate";
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
            if(publicRequest.IsSetActiveDate())
            {
                context.Writer.WritePropertyName("ActiveDate");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.ActiveDate.Value)));
            }

            if(publicRequest.IsSetCertificate())
            {
                context.Writer.WritePropertyName("Certificate");
                context.Writer.WriteStringValue(publicRequest.Certificate);
            }

            if(publicRequest.IsSetCertificateChain())
            {
                context.Writer.WritePropertyName("CertificateChain");
                context.Writer.WriteStringValue(publicRequest.CertificateChain);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetInactiveDate())
            {
                context.Writer.WritePropertyName("InactiveDate");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.InactiveDate.Value)));
            }

            if(publicRequest.IsSetPrivateKey())
            {
                context.Writer.WritePropertyName("PrivateKey");
                context.Writer.WriteStringValue(publicRequest.PrivateKey);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetUsage())
            {
                context.Writer.WritePropertyName("Usage");
                context.Writer.WriteStringValue(publicRequest.Usage);
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
        private static ImportCertificateRequestMarshaller _instance = new ImportCertificateRequestMarshaller();        

        internal static ImportCertificateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ImportCertificateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}