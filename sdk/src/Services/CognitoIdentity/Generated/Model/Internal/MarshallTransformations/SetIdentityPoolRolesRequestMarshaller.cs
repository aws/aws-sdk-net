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
 * Do not modify this file. This file is generated from the cognito-identity-2014-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CognitoIdentity.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SetIdentityPoolRoles Request Marshaller
    /// </summary>       
    public class SetIdentityPoolRolesRequestMarshaller : IMarshaller<IRequest, SetIdentityPoolRolesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SetIdentityPoolRolesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SetIdentityPoolRolesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoIdentity");
            string target = "AWSCognitoIdentityService.SetIdentityPoolRoles";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetIdentityPoolId())
                {
                    context.Writer.WritePropertyName("IdentityPoolId");
                    context.Writer.Write(publicRequest.IdentityPoolId);
                }

                if(publicRequest.IsSetRoleMappings())
                {
                    context.Writer.WritePropertyName("RoleMappings");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestRoleMappingsKvp in publicRequest.RoleMappings)
                    {
                        context.Writer.WritePropertyName(publicRequestRoleMappingsKvp.Key);
                        var publicRequestRoleMappingsValue = publicRequestRoleMappingsKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = RoleMappingMarshaller.Instance;
                        marshaller.Marshall(publicRequestRoleMappingsValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRoles())
                {
                    context.Writer.WritePropertyName("Roles");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestRolesKvp in publicRequest.Roles)
                    {
                        context.Writer.WritePropertyName(publicRequestRolesKvp.Key);
                        var publicRequestRolesValue = publicRequestRolesKvp.Value;

                            context.Writer.Write(publicRequestRolesValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static SetIdentityPoolRolesRequestMarshaller _instance = new SetIdentityPoolRolesRequestMarshaller();        

        internal static SetIdentityPoolRolesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SetIdentityPoolRolesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}