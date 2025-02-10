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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpacesWeb.Model;
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
namespace Amazon.WorkSpacesWeb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateTrustStore Request Marshaller
    /// </summary>       
    public class UpdateTrustStoreRequestMarshaller : IMarshaller<IRequest, UpdateTrustStoreRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateTrustStoreRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateTrustStoreRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkSpacesWeb");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-08";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetTrustStoreArn())
                throw new AmazonWorkSpacesWebException("Request object does not have required field TrustStoreArn set");
            request.AddPathResource("{trustStoreArn+}", StringUtils.FromString(publicRequest.TrustStoreArn.TrimStart('/')));
            request.ResourcePath = "/trustStores/{trustStoreArn+}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCertificatesToAdd())
            {
                context.Writer.WritePropertyName("certificatesToAdd");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCertificatesToAddListValue in publicRequest.CertificatesToAdd)
                {
                    context.Writer.WriteStringValue(StringUtils.FromMemoryStream(publicRequestCertificatesToAddListValue));
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetCertificatesToDelete())
            {
                context.Writer.WritePropertyName("certificatesToDelete");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCertificatesToDeleteListValue in publicRequest.CertificatesToDelete)
                {
                        context.Writer.WriteStringValue(publicRequestCertificatesToDeleteListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
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
        private static UpdateTrustStoreRequestMarshaller _instance = new UpdateTrustStoreRequestMarshaller();        

        internal static UpdateTrustStoreRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateTrustStoreRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}