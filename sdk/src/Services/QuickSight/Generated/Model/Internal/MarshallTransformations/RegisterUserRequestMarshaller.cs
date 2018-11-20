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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RegisterUser Request Marshaller
    /// </summary>       
    public class RegisterUserRequestMarshaller : IMarshaller<IRequest, RegisterUserRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RegisterUserRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RegisterUserRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QuickSight");
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.HttpMethod = "POST";

            string uriResourcePath = "/accounts/{AwsAccountId}/namespaces/{Namespace}/users";
            if (!publicRequest.IsSetAwsAccountId())
                throw new AmazonQuickSightException("Request object does not have required field AwsAccountId set");
            uriResourcePath = uriResourcePath.Replace("{AwsAccountId}", StringUtils.FromStringWithSlashEncoding(publicRequest.AwsAccountId));
            if (!publicRequest.IsSetNamespace())
                throw new AmazonQuickSightException("Request object does not have required field Namespace set");
            uriResourcePath = uriResourcePath.Replace("{Namespace}", StringUtils.FromStringWithSlashEncoding(publicRequest.Namespace));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetEmail())
                {
                    context.Writer.WritePropertyName("Email");
                    context.Writer.Write(publicRequest.Email);
                }

                if(publicRequest.IsSetIamArn())
                {
                    context.Writer.WritePropertyName("IamArn");
                    context.Writer.Write(publicRequest.IamArn);
                }

                if(publicRequest.IsSetIdentityType())
                {
                    context.Writer.WritePropertyName("IdentityType");
                    context.Writer.Write(publicRequest.IdentityType);
                }

                if(publicRequest.IsSetSessionName())
                {
                    context.Writer.WritePropertyName("SessionName");
                    context.Writer.Write(publicRequest.SessionName);
                }

                if(publicRequest.IsSetUserName())
                {
                    context.Writer.WritePropertyName("UserName");
                    context.Writer.Write(publicRequest.UserName);
                }

                if(publicRequest.IsSetUserRole())
                {
                    context.Writer.WritePropertyName("UserRole");
                    context.Writer.Write(publicRequest.UserRole);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static RegisterUserRequestMarshaller _instance = new RegisterUserRequestMarshaller();        

        internal static RegisterUserRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RegisterUserRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}