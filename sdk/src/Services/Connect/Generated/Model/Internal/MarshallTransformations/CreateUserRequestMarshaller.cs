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
using ThirdParty.Json.LitJson;

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
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "PUT";

            string uriResourcePath = "/users/{InstanceId}";
            if (!publicRequest.IsSetInstanceId())
                throw new AmazonConnectException("Request object does not have required field InstanceId set");
            uriResourcePath = uriResourcePath.Replace("{InstanceId}", StringUtils.FromStringWithSlashEncoding(publicRequest.InstanceId));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDirectoryUserId())
                {
                    context.Writer.WritePropertyName("DirectoryUserId");
                    context.Writer.Write(publicRequest.DirectoryUserId);
                }

                if(publicRequest.IsSetHierarchyGroupId())
                {
                    context.Writer.WritePropertyName("HierarchyGroupId");
                    context.Writer.Write(publicRequest.HierarchyGroupId);
                }

                if(publicRequest.IsSetIdentityInfo())
                {
                    context.Writer.WritePropertyName("IdentityInfo");
                    context.Writer.WriteObjectStart();

                    var marshaller = UserIdentityInfoMarshaller.Instance;
                    marshaller.Marshall(publicRequest.IdentityInfo, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPassword())
                {
                    context.Writer.WritePropertyName("Password");
                    context.Writer.Write(publicRequest.Password);
                }

                if(publicRequest.IsSetPhoneConfig())
                {
                    context.Writer.WritePropertyName("PhoneConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = UserPhoneConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PhoneConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRoutingProfileId())
                {
                    context.Writer.WritePropertyName("RoutingProfileId");
                    context.Writer.Write(publicRequest.RoutingProfileId);
                }

                if(publicRequest.IsSetSecurityProfileIds())
                {
                    context.Writer.WritePropertyName("SecurityProfileIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSecurityProfileIdsListValue in publicRequest.SecurityProfileIds)
                    {
                            context.Writer.Write(publicRequestSecurityProfileIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetUsername())
                {
                    context.Writer.WritePropertyName("Username");
                    context.Writer.Write(publicRequest.Username);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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