/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using ThirdParty.Json.LitJson;

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
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "PATCH";

            string uriResourcePath = "/api/v1/users/{UserId}";
            if (!publicRequest.IsSetUserId())
                throw new AmazonWorkDocsException("Request object does not have required field UserId set");
            uriResourcePath = uriResourcePath.Replace("{UserId}", StringUtils.FromString(publicRequest.UserId));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetGivenName())
                {
                    context.Writer.WritePropertyName("GivenName");
                    context.Writer.Write(publicRequest.GivenName);
                }

                if(publicRequest.IsSetGrantPoweruserPrivileges())
                {
                    context.Writer.WritePropertyName("GrantPoweruserPrivileges");
                    context.Writer.Write(publicRequest.GrantPoweruserPrivileges);
                }

                if(publicRequest.IsSetLocale())
                {
                    context.Writer.WritePropertyName("Locale");
                    context.Writer.Write(publicRequest.Locale);
                }

                if(publicRequest.IsSetStorageRule())
                {
                    context.Writer.WritePropertyName("StorageRule");
                    context.Writer.WriteObjectStart();

                    var marshaller = StorageRuleTypeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.StorageRule, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSurname())
                {
                    context.Writer.WritePropertyName("Surname");
                    context.Writer.Write(publicRequest.Surname);
                }

                if(publicRequest.IsSetTimeZoneId())
                {
                    context.Writer.WritePropertyName("TimeZoneId");
                    context.Writer.Write(publicRequest.TimeZoneId);
                }

                if(publicRequest.IsSetType())
                {
                    context.Writer.WritePropertyName("Type");
                    context.Writer.Write(publicRequest.Type);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

        
            if(publicRequest.IsSetAuthenticationToken())
                request.Headers["Authentication"] = publicRequest.AuthenticationToken;

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