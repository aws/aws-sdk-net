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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.VerifiedPermissions.Model;
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
namespace Amazon.VerifiedPermissions.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// IsAuthorizedWithToken Request Marshaller
    /// </summary>       
    public class IsAuthorizedWithTokenRequestMarshaller : IMarshaller<IRequest, IsAuthorizedWithTokenRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((IsAuthorizedWithTokenRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(IsAuthorizedWithTokenRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.VerifiedPermissions");
            string target = "VerifiedPermissions.IsAuthorizedWithToken";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-12-01";
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
            if(publicRequest.IsSetAccessToken())
            {
                context.Writer.WritePropertyName("accessToken");
                context.Writer.WriteStringValue(publicRequest.AccessToken);
            }

            if(publicRequest.IsSetAction())
            {
                context.Writer.WritePropertyName("action");
                context.Writer.WriteStartObject();

                var marshaller = ActionIdentifierMarshaller.Instance;
                marshaller.Marshall(publicRequest.Action, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetContext())
            {
                context.Writer.WritePropertyName("context");
                context.Writer.WriteStartObject();

                var marshaller = ContextDefinitionMarshaller.Instance;
                marshaller.Marshall(publicRequest.Context, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEntities())
            {
                context.Writer.WritePropertyName("entities");
                context.Writer.WriteStartObject();

                var marshaller = EntitiesDefinitionMarshaller.Instance;
                marshaller.Marshall(publicRequest.Entities, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetIdentityToken())
            {
                context.Writer.WritePropertyName("identityToken");
                context.Writer.WriteStringValue(publicRequest.IdentityToken);
            }

            if(publicRequest.IsSetPolicyStoreId())
            {
                context.Writer.WritePropertyName("policyStoreId");
                context.Writer.WriteStringValue(publicRequest.PolicyStoreId);
            }

            if(publicRequest.IsSetResource())
            {
                context.Writer.WritePropertyName("resource");
                context.Writer.WriteStartObject();

                var marshaller = EntityIdentifierMarshaller.Instance;
                marshaller.Marshall(publicRequest.Resource, context);

                context.Writer.WriteEndObject();
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
        private static IsAuthorizedWithTokenRequestMarshaller _instance = new IsAuthorizedWithTokenRequestMarshaller();        

        internal static IsAuthorizedWithTokenRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static IsAuthorizedWithTokenRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}