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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RedshiftServerless.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.RedshiftServerless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateNamespace Request Marshaller
    /// </summary>       
    public class UpdateNamespaceRequestMarshaller : IMarshaller<IRequest, UpdateNamespaceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateNamespaceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateNamespaceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RedshiftServerless");
            string target = "RedshiftServerless.UpdateNamespace";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-04-21";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAdminPasswordSecretKmsKeyId())
                {
                    context.Writer.WritePropertyName("adminPasswordSecretKmsKeyId");
                    context.Writer.Write(publicRequest.AdminPasswordSecretKmsKeyId);
                }

                if(publicRequest.IsSetAdminUsername())
                {
                    context.Writer.WritePropertyName("adminUsername");
                    context.Writer.Write(publicRequest.AdminUsername);
                }

                if(publicRequest.IsSetAdminUserPassword())
                {
                    context.Writer.WritePropertyName("adminUserPassword");
                    context.Writer.Write(publicRequest.AdminUserPassword);
                }

                if(publicRequest.IsSetDefaultIamRoleArn())
                {
                    context.Writer.WritePropertyName("defaultIamRoleArn");
                    context.Writer.Write(publicRequest.DefaultIamRoleArn);
                }

                if(publicRequest.IsSetIamRoles())
                {
                    context.Writer.WritePropertyName("iamRoles");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestIamRolesListValue in publicRequest.IamRoles)
                    {
                            context.Writer.Write(publicRequestIamRolesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetKmsKeyId())
                {
                    context.Writer.WritePropertyName("kmsKeyId");
                    context.Writer.Write(publicRequest.KmsKeyId);
                }

                if(publicRequest.IsSetLogExports())
                {
                    context.Writer.WritePropertyName("logExports");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLogExportsListValue in publicRequest.LogExports)
                    {
                            context.Writer.Write(publicRequestLogExportsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetManageAdminPassword())
                {
                    context.Writer.WritePropertyName("manageAdminPassword");
                    context.Writer.Write(publicRequest.ManageAdminPassword);
                }

                if(publicRequest.IsSetNamespaceName())
                {
                    context.Writer.WritePropertyName("namespaceName");
                    context.Writer.Write(publicRequest.NamespaceName);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateNamespaceRequestMarshaller _instance = new UpdateNamespaceRequestMarshaller();        

        internal static UpdateNamespaceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateNamespaceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618