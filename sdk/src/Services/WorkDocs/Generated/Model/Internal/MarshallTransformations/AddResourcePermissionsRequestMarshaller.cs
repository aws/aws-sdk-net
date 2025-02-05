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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkDocs.Model;
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
namespace Amazon.WorkDocs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AddResourcePermissions Request Marshaller
    /// </summary>       
    public class AddResourcePermissionsRequestMarshaller : IMarshaller<IRequest, AddResourcePermissionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AddResourcePermissionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AddResourcePermissionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkDocs");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-05-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetResourceId())
                throw new AmazonWorkDocsException("Request object does not have required field ResourceId set");
            request.AddPathResource("{ResourceId}", StringUtils.FromString(publicRequest.ResourceId));
            request.ResourcePath = "/api/v1/resources/{ResourceId}/permissions";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetNotificationOptions())
            {
                context.Writer.WritePropertyName("NotificationOptions");
                context.Writer.WriteStartObject();

                var marshaller = NotificationOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.NotificationOptions, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPrincipals())
            {
                context.Writer.WritePropertyName("Principals");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPrincipalsListValue in publicRequest.Principals)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SharePrincipalMarshaller.Instance;
                    marshaller.Marshall(publicRequestPrincipalsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

        
            if (publicRequest.IsSetAuthenticationToken()) 
            {
                request.Headers["Authentication"] = publicRequest.AuthenticationToken;
            }

            return request;
        }
        private static AddResourcePermissionsRequestMarshaller _instance = new AddResourcePermissionsRequestMarshaller();        

        internal static AddResourcePermissionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AddResourcePermissionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}