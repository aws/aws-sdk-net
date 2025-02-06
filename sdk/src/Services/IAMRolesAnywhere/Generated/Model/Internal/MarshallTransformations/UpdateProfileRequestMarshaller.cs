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
 * Do not modify this file. This file is generated from the rolesanywhere-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IAMRolesAnywhere.Model;
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
namespace Amazon.IAMRolesAnywhere.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateProfile Request Marshaller
    /// </summary>       
    public class UpdateProfileRequestMarshaller : IMarshaller<IRequest, UpdateProfileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateProfileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IAMRolesAnywhere");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetProfileId())
                throw new AmazonIAMRolesAnywhereException("Request object does not have required field ProfileId set");
            request.AddPathResource("{profileId}", StringUtils.FromString(publicRequest.ProfileId));
            request.ResourcePath = "/profile/{profileId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAcceptRoleSessionName())
            {
                context.Writer.WritePropertyName("acceptRoleSessionName");
                context.Writer.WriteBooleanValue(publicRequest.AcceptRoleSessionName.Value);
            }

            if(publicRequest.IsSetDurationSeconds())
            {
                context.Writer.WritePropertyName("durationSeconds");
                context.Writer.WriteNumberValue(publicRequest.DurationSeconds.Value);
            }

            if(publicRequest.IsSetManagedPolicyArns())
            {
                context.Writer.WritePropertyName("managedPolicyArns");
                context.Writer.WriteStartArray();
                foreach(var publicRequestManagedPolicyArnsListValue in publicRequest.ManagedPolicyArns)
                {
                        context.Writer.WriteStringValue(publicRequestManagedPolicyArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetRoleArns())
            {
                context.Writer.WritePropertyName("roleArns");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRoleArnsListValue in publicRequest.RoleArns)
                {
                        context.Writer.WriteStringValue(publicRequestRoleArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSessionPolicy())
            {
                context.Writer.WritePropertyName("sessionPolicy");
                context.Writer.WriteStringValue(publicRequest.SessionPolicy);
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
        private static UpdateProfileRequestMarshaller _instance = new UpdateProfileRequestMarshaller();        

        internal static UpdateProfileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateProfileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}