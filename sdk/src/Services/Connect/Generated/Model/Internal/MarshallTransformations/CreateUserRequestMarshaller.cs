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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
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
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateUser Request Marshaller
    /// </summary>       
    public class CreateUserRequestMarshaller : IMarshaller<IRequest, CreateUserRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateUserRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateUserRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetInstanceId())
                throw new AmazonConnectException("Request object does not have required field InstanceId set");
            request.AddPathResource("{InstanceId}", StringUtils.FromString(publicRequest.InstanceId));
            request.ResourcePath = "/users/{InstanceId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDirectoryUserId())
            {
                context.Writer.WritePropertyName("DirectoryUserId");
                context.Writer.WriteStringValue(publicRequest.DirectoryUserId);
            }

            if(publicRequest.IsSetHierarchyGroupId())
            {
                context.Writer.WritePropertyName("HierarchyGroupId");
                context.Writer.WriteStringValue(publicRequest.HierarchyGroupId);
            }

            if(publicRequest.IsSetIdentityInfo())
            {
                context.Writer.WritePropertyName("IdentityInfo");
                context.Writer.WriteStartObject();

                var marshaller = UserIdentityInfoMarshaller.Instance;
                marshaller.Marshall(publicRequest.IdentityInfo, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPassword())
            {
                context.Writer.WritePropertyName("Password");
                context.Writer.WriteStringValue(publicRequest.Password);
            }

            if(publicRequest.IsSetPhoneConfig())
            {
                context.Writer.WritePropertyName("PhoneConfig");
                context.Writer.WriteStartObject();

                var marshaller = UserPhoneConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.PhoneConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRoutingProfileId())
            {
                context.Writer.WritePropertyName("RoutingProfileId");
                context.Writer.WriteStringValue(publicRequest.RoutingProfileId);
            }

            if(publicRequest.IsSetSecurityProfileIds())
            {
                context.Writer.WritePropertyName("SecurityProfileIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSecurityProfileIdsListValue in publicRequest.SecurityProfileIds)
                {
                        context.Writer.WriteStringValue(publicRequestSecurityProfileIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetUsername())
            {
                context.Writer.WritePropertyName("Username");
                context.Writer.WriteStringValue(publicRequest.Username);
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
        private static CreateUserRequestMarshaller _instance = new CreateUserRequestMarshaller();        

        internal static CreateUserRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateUserRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}