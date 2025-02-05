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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
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
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAdminPasswordSecretKmsKeyId())
            {
                context.Writer.WritePropertyName("adminPasswordSecretKmsKeyId");
                context.Writer.WriteStringValue(publicRequest.AdminPasswordSecretKmsKeyId);
            }

            if(publicRequest.IsSetAdminUsername())
            {
                context.Writer.WritePropertyName("adminUsername");
                context.Writer.WriteStringValue(publicRequest.AdminUsername);
            }

            if(publicRequest.IsSetAdminUserPassword())
            {
                context.Writer.WritePropertyName("adminUserPassword");
                context.Writer.WriteStringValue(publicRequest.AdminUserPassword);
            }

            if(publicRequest.IsSetDefaultIamRoleArn())
            {
                context.Writer.WritePropertyName("defaultIamRoleArn");
                context.Writer.WriteStringValue(publicRequest.DefaultIamRoleArn);
            }

            if(publicRequest.IsSetIamRoles())
            {
                context.Writer.WritePropertyName("iamRoles");
                context.Writer.WriteStartArray();
                foreach(var publicRequestIamRolesListValue in publicRequest.IamRoles)
                {
                        context.Writer.WriteStringValue(publicRequestIamRolesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("kmsKeyId");
                context.Writer.WriteStringValue(publicRequest.KmsKeyId);
            }

            if(publicRequest.IsSetLogExports())
            {
                context.Writer.WritePropertyName("logExports");
                context.Writer.WriteStartArray();
                foreach(var publicRequestLogExportsListValue in publicRequest.LogExports)
                {
                        context.Writer.WriteStringValue(publicRequestLogExportsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetManageAdminPassword())
            {
                context.Writer.WritePropertyName("manageAdminPassword");
                context.Writer.WriteBooleanValue(publicRequest.ManageAdminPassword.Value);
            }

            if(publicRequest.IsSetNamespaceName())
            {
                context.Writer.WritePropertyName("namespaceName");
                context.Writer.WriteStringValue(publicRequest.NamespaceName);
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