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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AmplifyBackend.Model;
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
namespace Amazon.AmplifyBackend.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateBackend Request Marshaller
    /// </summary>       
    public class CreateBackendRequestMarshaller : IMarshaller<IRequest, CreateBackendRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateBackendRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateBackendRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AmplifyBackend");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-11";
            request.HttpMethod = "POST";

            request.ResourcePath = "/backend";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAppId())
            {
                context.Writer.WritePropertyName("appId");
                context.Writer.WriteStringValue(publicRequest.AppId);
            }

            if(publicRequest.IsSetAppName())
            {
                context.Writer.WritePropertyName("appName");
                context.Writer.WriteStringValue(publicRequest.AppName);
            }

            if(publicRequest.IsSetBackendEnvironmentName())
            {
                context.Writer.WritePropertyName("backendEnvironmentName");
                context.Writer.WriteStringValue(publicRequest.BackendEnvironmentName);
            }

            if(publicRequest.IsSetResourceConfig())
            {
                context.Writer.WritePropertyName("resourceConfig");
                context.Writer.WriteStartObject();

                var marshaller = ResourceConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ResourceConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetResourceName())
            {
                context.Writer.WritePropertyName("resourceName");
                context.Writer.WriteStringValue(publicRequest.ResourceName);
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
        private static CreateBackendRequestMarshaller _instance = new CreateBackendRequestMarshaller();        

        internal static CreateBackendRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateBackendRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}