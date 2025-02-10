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
 * Do not modify this file. This file is generated from the taxsettings-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.TaxSettings.Model;
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
namespace Amazon.TaxSettings.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutTaxExemption Request Marshaller
    /// </summary>       
    public class PutTaxExemptionRequestMarshaller : IMarshaller<IRequest, PutTaxExemptionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutTaxExemptionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutTaxExemptionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.TaxSettings");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/PutTaxExemption";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAccountIds())
            {
                context.Writer.WritePropertyName("accountIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAccountIdsListValue in publicRequest.AccountIds)
                {
                        context.Writer.WriteStringValue(publicRequestAccountIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAuthority())
            {
                context.Writer.WritePropertyName("authority");
                context.Writer.WriteStartObject();

                var marshaller = AuthorityMarshaller.Instance;
                marshaller.Marshall(publicRequest.Authority, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetExemptionCertificate())
            {
                context.Writer.WritePropertyName("exemptionCertificate");
                context.Writer.WriteStartObject();

                var marshaller = ExemptionCertificateMarshaller.Instance;
                marshaller.Marshall(publicRequest.ExemptionCertificate, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetExemptionType())
            {
                context.Writer.WritePropertyName("exemptionType");
                context.Writer.WriteStringValue(publicRequest.ExemptionType);
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
        private static PutTaxExemptionRequestMarshaller _instance = new PutTaxExemptionRequestMarshaller();        

        internal static PutTaxExemptionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutTaxExemptionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}