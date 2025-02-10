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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkMail.Model;
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
namespace Amazon.WorkMail.Model.Internal.MarshallTransformations
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
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkMail");
            string target = "WorkMailService.UpdateUser";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-01";
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
            if(publicRequest.IsSetCity())
            {
                context.Writer.WritePropertyName("City");
                context.Writer.WriteStringValue(publicRequest.City);
            }

            if(publicRequest.IsSetCompany())
            {
                context.Writer.WritePropertyName("Company");
                context.Writer.WriteStringValue(publicRequest.Company);
            }

            if(publicRequest.IsSetCountry())
            {
                context.Writer.WritePropertyName("Country");
                context.Writer.WriteStringValue(publicRequest.Country);
            }

            if(publicRequest.IsSetDepartment())
            {
                context.Writer.WritePropertyName("Department");
                context.Writer.WriteStringValue(publicRequest.Department);
            }

            if(publicRequest.IsSetDisplayName())
            {
                context.Writer.WritePropertyName("DisplayName");
                context.Writer.WriteStringValue(publicRequest.DisplayName);
            }

            if(publicRequest.IsSetFirstName())
            {
                context.Writer.WritePropertyName("FirstName");
                context.Writer.WriteStringValue(publicRequest.FirstName);
            }

            if(publicRequest.IsSetHiddenFromGlobalAddressList())
            {
                context.Writer.WritePropertyName("HiddenFromGlobalAddressList");
                context.Writer.WriteBooleanValue(publicRequest.HiddenFromGlobalAddressList.Value);
            }

            if(publicRequest.IsSetIdentityProviderUserId())
            {
                context.Writer.WritePropertyName("IdentityProviderUserId");
                context.Writer.WriteStringValue(publicRequest.IdentityProviderUserId);
            }

            if(publicRequest.IsSetInitials())
            {
                context.Writer.WritePropertyName("Initials");
                context.Writer.WriteStringValue(publicRequest.Initials);
            }

            if(publicRequest.IsSetJobTitle())
            {
                context.Writer.WritePropertyName("JobTitle");
                context.Writer.WriteStringValue(publicRequest.JobTitle);
            }

            if(publicRequest.IsSetLastName())
            {
                context.Writer.WritePropertyName("LastName");
                context.Writer.WriteStringValue(publicRequest.LastName);
            }

            if(publicRequest.IsSetOffice())
            {
                context.Writer.WritePropertyName("Office");
                context.Writer.WriteStringValue(publicRequest.Office);
            }

            if(publicRequest.IsSetOrganizationId())
            {
                context.Writer.WritePropertyName("OrganizationId");
                context.Writer.WriteStringValue(publicRequest.OrganizationId);
            }

            if(publicRequest.IsSetRole())
            {
                context.Writer.WritePropertyName("Role");
                context.Writer.WriteStringValue(publicRequest.Role);
            }

            if(publicRequest.IsSetStreet())
            {
                context.Writer.WritePropertyName("Street");
                context.Writer.WriteStringValue(publicRequest.Street);
            }

            if(publicRequest.IsSetTelephone())
            {
                context.Writer.WritePropertyName("Telephone");
                context.Writer.WriteStringValue(publicRequest.Telephone);
            }

            if(publicRequest.IsSetUserId())
            {
                context.Writer.WritePropertyName("UserId");
                context.Writer.WriteStringValue(publicRequest.UserId);
            }

            if(publicRequest.IsSetZipCode())
            {
                context.Writer.WritePropertyName("ZipCode");
                context.Writer.WriteStringValue(publicRequest.ZipCode);
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