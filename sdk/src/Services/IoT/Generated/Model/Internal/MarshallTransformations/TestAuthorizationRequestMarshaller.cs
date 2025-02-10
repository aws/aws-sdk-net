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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
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
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-05-28";
            request.HttpMethod = "POST";

            
            if (publicRequest.IsSetClientId())
                request.Parameters.Add("clientId", StringUtils.FromString(publicRequest.ClientId));
            request.ResourcePath = "/test-authorization";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAuthInfos())
            {
                context.Writer.WritePropertyName("authInfos");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAuthInfosListValue in publicRequest.AuthInfos)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AuthInfoMarshaller.Instance;
                    marshaller.Marshall(publicRequestAuthInfosListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetCognitoIdentityPoolId())
            {
                context.Writer.WritePropertyName("cognitoIdentityPoolId");
                context.Writer.WriteStringValue(publicRequest.CognitoIdentityPoolId);
            }

            if(publicRequest.IsSetPolicyNamesToAdd())
            {
                context.Writer.WritePropertyName("policyNamesToAdd");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPolicyNamesToAddListValue in publicRequest.PolicyNamesToAdd)
                {
                        context.Writer.WriteStringValue(publicRequestPolicyNamesToAddListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetPolicyNamesToSkip())
            {
                context.Writer.WritePropertyName("policyNamesToSkip");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPolicyNamesToSkipListValue in publicRequest.PolicyNamesToSkip)
                {
                        context.Writer.WriteStringValue(publicRequestPolicyNamesToSkipListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetPrincipal())
            {
                context.Writer.WritePropertyName("principal");
                context.Writer.WriteStringValue(publicRequest.Principal);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

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