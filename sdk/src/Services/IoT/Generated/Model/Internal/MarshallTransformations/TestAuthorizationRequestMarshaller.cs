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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TestAuthorization Request Marshaller
    /// </summary>       
    public class TestAuthorizationRequestMarshaller : IMarshaller<IRequest, TestAuthorizationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((TestAuthorizationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(TestAuthorizationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "POST";

            string uriResourcePath = "/test-authorization";
            
            if (publicRequest.IsSetClientId())
                request.Parameters.Add("clientId", StringUtils.FromString(publicRequest.ClientId));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAuthInfos())
                {
                    context.Writer.WritePropertyName("authInfos");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAuthInfosListValue in publicRequest.AuthInfos)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AuthInfoMarshaller.Instance;
                        marshaller.Marshall(publicRequestAuthInfosListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetCognitoIdentityPoolId())
                {
                    context.Writer.WritePropertyName("cognitoIdentityPoolId");
                    context.Writer.Write(publicRequest.CognitoIdentityPoolId);
                }

                if(publicRequest.IsSetPolicyNamesToAdd())
                {
                    context.Writer.WritePropertyName("policyNamesToAdd");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPolicyNamesToAddListValue in publicRequest.PolicyNamesToAdd)
                    {
                            context.Writer.Write(publicRequestPolicyNamesToAddListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPolicyNamesToSkip())
                {
                    context.Writer.WritePropertyName("policyNamesToSkip");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPolicyNamesToSkipListValue in publicRequest.PolicyNamesToSkip)
                    {
                            context.Writer.Write(publicRequestPolicyNamesToSkipListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPrincipal())
                {
                    context.Writer.WritePropertyName("principal");
                    context.Writer.Write(publicRequest.Principal);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            request.UseQueryString = true;

            return request;
        }
        private static TestAuthorizationRequestMarshaller _instance = new TestAuthorizationRequestMarshaller();        

        internal static TestAuthorizationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TestAuthorizationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}