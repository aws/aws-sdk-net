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
 * Do not modify this file. This file is generated from the signin-2023-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Signin.Model;
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
namespace Amazon.Signin.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateOAuth2TokenWithIAM Request Marshaller
    /// </summary>       
    public class CreateOAuth2TokenWithIAMRequestMarshaller : IMarshaller<IRequest, CreateOAuth2TokenWithIAMRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateOAuth2TokenWithIAMRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateOAuth2TokenWithIAMRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Signin");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-01-01";
            request.HttpMethod = "POST";

            request.AddSubResource("x-amz-client-auth-method", "iam");
            request.ResourcePath = "/v1/token";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetGrantType())
            {
                context.Writer.WritePropertyName("grant_type");
                context.Writer.WriteStringValue(publicRequest.GrantType);
            }

            if(publicRequest.IsSetResource())
            {
                context.Writer.WritePropertyName("resource");
                context.Writer.WriteStringValue(publicRequest.Resource);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateOAuth2TokenWithIAMRequestMarshaller _instance = new CreateOAuth2TokenWithIAMRequestMarshaller();        

        internal static CreateOAuth2TokenWithIAMRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateOAuth2TokenWithIAMRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}