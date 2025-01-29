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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppStream.Model;
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
namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDirectoryConfig Request Marshaller
    /// </summary>       
    public class CreateDirectoryConfigRequestMarshaller : IMarshaller<IRequest, CreateDirectoryConfigRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDirectoryConfigRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDirectoryConfigRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppStream");
            string target = "PhotonAdminProxyService.CreateDirectoryConfig";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-12-01";
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
            if(publicRequest.IsSetCertificateBasedAuthProperties())
            {
                context.Writer.WritePropertyName("CertificateBasedAuthProperties");
                context.Writer.WriteStartObject();

                var marshaller = CertificateBasedAuthPropertiesMarshaller.Instance;
                marshaller.Marshall(publicRequest.CertificateBasedAuthProperties, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDirectoryName())
            {
                context.Writer.WritePropertyName("DirectoryName");
                context.Writer.WriteStringValue(publicRequest.DirectoryName);
            }

            if(publicRequest.IsSetOrganizationalUnitDistinguishedNames())
            {
                context.Writer.WritePropertyName("OrganizationalUnitDistinguishedNames");
                context.Writer.WriteStartArray();
                foreach(var publicRequestOrganizationalUnitDistinguishedNamesListValue in publicRequest.OrganizationalUnitDistinguishedNames)
                {
                        context.Writer.WriteStringValue(publicRequestOrganizationalUnitDistinguishedNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetServiceAccountCredentials())
            {
                context.Writer.WritePropertyName("ServiceAccountCredentials");
                context.Writer.WriteStartObject();

                var marshaller = ServiceAccountCredentialsMarshaller.Instance;
                marshaller.Marshall(publicRequest.ServiceAccountCredentials, context);

                context.Writer.WriteEndObject();
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
        private static CreateDirectoryConfigRequestMarshaller _instance = new CreateDirectoryConfigRequestMarshaller();        

        internal static CreateDirectoryConfigRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDirectoryConfigRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}