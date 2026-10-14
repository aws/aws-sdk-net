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
 * Do not modify this file. This file is generated from the endusermessaging-2026-09-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EndUserMessaging.Model;
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
namespace Amazon.EndUserMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ValidateNotifyCodeVerification Request Marshaller
    /// </summary>       
    public class ValidateNotifyCodeVerificationRequestMarshaller : IMarshaller<IRequest, ValidateNotifyCodeVerificationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ValidateNotifyCodeVerificationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ValidateNotifyCodeVerificationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EndUserMessaging");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-09-21";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/notify-code-verifications/validate";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCode())
            {
                context.Writer.WritePropertyName("code");
                context.Writer.WriteStringValue(publicRequest.Code);
            }

            if(publicRequest.IsSetDestinationIdentity())
            {
                context.Writer.WritePropertyName("destinationIdentity");
                context.Writer.WriteStringValue(publicRequest.DestinationIdentity);
            }

            if(publicRequest.IsSetReferenceId())
            {
                context.Writer.WritePropertyName("referenceId");
                context.Writer.WriteStringValue(publicRequest.ReferenceId);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static ValidateNotifyCodeVerificationRequestMarshaller _instance = new ValidateNotifyCodeVerificationRequestMarshaller();        

        internal static ValidateNotifyCodeVerificationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ValidateNotifyCodeVerificationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}