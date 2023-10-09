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
using ThirdParty.Json.LitJson;

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
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCity())
                {
                    context.Writer.WritePropertyName("City");
                    context.Writer.Write(publicRequest.City);
                }

                if(publicRequest.IsSetCompany())
                {
                    context.Writer.WritePropertyName("Company");
                    context.Writer.Write(publicRequest.Company);
                }

                if(publicRequest.IsSetCountry())
                {
                    context.Writer.WritePropertyName("Country");
                    context.Writer.Write(publicRequest.Country);
                }

                if(publicRequest.IsSetDepartment())
                {
                    context.Writer.WritePropertyName("Department");
                    context.Writer.Write(publicRequest.Department);
                }

                if(publicRequest.IsSetDisplayName())
                {
                    context.Writer.WritePropertyName("DisplayName");
                    context.Writer.Write(publicRequest.DisplayName);
                }

                if(publicRequest.IsSetFirstName())
                {
                    context.Writer.WritePropertyName("FirstName");
                    context.Writer.Write(publicRequest.FirstName);
                }

                if(publicRequest.IsSetHiddenFromGlobalAddressList())
                {
                    context.Writer.WritePropertyName("HiddenFromGlobalAddressList");
                    context.Writer.Write(publicRequest.HiddenFromGlobalAddressList);
                }

                if(publicRequest.IsSetInitials())
                {
                    context.Writer.WritePropertyName("Initials");
                    context.Writer.Write(publicRequest.Initials);
                }

                if(publicRequest.IsSetJobTitle())
                {
                    context.Writer.WritePropertyName("JobTitle");
                    context.Writer.Write(publicRequest.JobTitle);
                }

                if(publicRequest.IsSetLastName())
                {
                    context.Writer.WritePropertyName("LastName");
                    context.Writer.Write(publicRequest.LastName);
                }

                if(publicRequest.IsSetOffice())
                {
                    context.Writer.WritePropertyName("Office");
                    context.Writer.Write(publicRequest.Office);
                }

                if(publicRequest.IsSetOrganizationId())
                {
                    context.Writer.WritePropertyName("OrganizationId");
                    context.Writer.Write(publicRequest.OrganizationId);
                }

                if(publicRequest.IsSetRole())
                {
                    context.Writer.WritePropertyName("Role");
                    context.Writer.Write(publicRequest.Role);
                }

                if(publicRequest.IsSetStreet())
                {
                    context.Writer.WritePropertyName("Street");
                    context.Writer.Write(publicRequest.Street);
                }

                if(publicRequest.IsSetTelephone())
                {
                    context.Writer.WritePropertyName("Telephone");
                    context.Writer.Write(publicRequest.Telephone);
                }

                if(publicRequest.IsSetUserId())
                {
                    context.Writer.WritePropertyName("UserId");
                    context.Writer.Write(publicRequest.UserId);
                }

                if(publicRequest.IsSetZipCode())
                {
                    context.Writer.WritePropertyName("ZipCode");
                    context.Writer.Write(publicRequest.ZipCode);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
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