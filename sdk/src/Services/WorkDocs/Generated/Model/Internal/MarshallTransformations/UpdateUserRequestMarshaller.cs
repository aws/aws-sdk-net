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
    /// UpdateUser Request Marshaller
    /// </summary>       
    public class UpdateUserRequestMarshaller : IMarshaller<IRequest, UpdateUserRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateUserRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateUserRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkDocs");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-05-01";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetUserId())
                throw new AmazonWorkDocsException("Request object does not have required field UserId set");
            request.AddPathResource("{UserId}", StringUtils.FromString(publicRequest.UserId));
            request.ResourcePath = "/api/v1/users/{UserId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetGivenName())
            {
                context.Writer.WritePropertyName("GivenName");
                context.Writer.WriteStringValue(publicRequest.GivenName);
            }

            if(publicRequest.IsSetGrantPoweruserPrivileges())
            {
                context.Writer.WritePropertyName("GrantPoweruserPrivileges");
                context.Writer.WriteStringValue(publicRequest.GrantPoweruserPrivileges);
            }

            if(publicRequest.IsSetLocale())
            {
                context.Writer.WritePropertyName("Locale");
                context.Writer.WriteStringValue(publicRequest.Locale);
            }

            if(publicRequest.IsSetStorageRule())
            {
                context.Writer.WritePropertyName("StorageRule");
                context.Writer.WriteStartObject();

                var marshaller = StorageRuleTypeMarshaller.Instance;
                marshaller.Marshall(publicRequest.StorageRule, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSurname())
            {
                context.Writer.WritePropertyName("Surname");
                context.Writer.WriteStringValue(publicRequest.Surname);
            }

            if(publicRequest.IsSetTimeZoneId())
            {
                context.Writer.WritePropertyName("TimeZoneId");
                context.Writer.WriteStringValue(publicRequest.TimeZoneId);
            }

            if(publicRequest.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteStringValue(publicRequest.Type);
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
        private static UpdateUserRequestMarshaller _instance = new UpdateUserRequestMarshaller();        

        internal static UpdateUserRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateUserRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}