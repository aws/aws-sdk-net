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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSOAdmin.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SSOAdmin.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAccountAssignment Request Marshaller
    /// </summary>       
    public class CreateAccountAssignmentRequestMarshaller : IMarshaller<IRequest, CreateAccountAssignmentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAccountAssignmentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAccountAssignmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SSOAdmin");
            string target = "SWBExternalService.CreateAccountAssignment";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-20";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetInstanceArn())
                {
                    context.Writer.WritePropertyName("InstanceArn");
                    context.Writer.Write(publicRequest.InstanceArn);
                }

                if(publicRequest.IsSetPermissionSetArn())
                {
                    context.Writer.WritePropertyName("PermissionSetArn");
                    context.Writer.Write(publicRequest.PermissionSetArn);
                }

                if(publicRequest.IsSetPrincipalId())
                {
                    context.Writer.WritePropertyName("PrincipalId");
                    context.Writer.Write(publicRequest.PrincipalId);
                }

                if(publicRequest.IsSetPrincipalType())
                {
                    context.Writer.WritePropertyName("PrincipalType");
                    context.Writer.Write(publicRequest.PrincipalType);
                }

                if(publicRequest.IsSetTargetId())
                {
                    context.Writer.WritePropertyName("TargetId");
                    context.Writer.Write(publicRequest.TargetId);
                }

                if(publicRequest.IsSetTargetType())
                {
                    context.Writer.WritePropertyName("TargetType");
                    context.Writer.Write(publicRequest.TargetType);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateAccountAssignmentRequestMarshaller _instance = new CreateAccountAssignmentRequestMarshaller();        

        internal static CreateAccountAssignmentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAccountAssignmentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}