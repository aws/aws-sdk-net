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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
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
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateWorkteam Request Marshaller
    /// </summary>       
    public class UpdateWorkteamRequestMarshaller : IMarshaller<IRequest, UpdateWorkteamRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateWorkteamRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateWorkteamRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.UpdateWorkteam";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-24";
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
            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetMemberDefinitions())
            {
                context.Writer.WritePropertyName("MemberDefinitions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestMemberDefinitionsListValue in publicRequest.MemberDefinitions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MemberDefinitionMarshaller.Instance;
                    marshaller.Marshall(publicRequestMemberDefinitionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetNotificationConfiguration())
            {
                context.Writer.WritePropertyName("NotificationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = NotificationConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.NotificationConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetWorkerAccessConfiguration())
            {
                context.Writer.WritePropertyName("WorkerAccessConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = WorkerAccessConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.WorkerAccessConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetWorkteamName())
            {
                context.Writer.WritePropertyName("WorkteamName");
                context.Writer.WriteStringValue(publicRequest.WorkteamName);
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
        private static UpdateWorkteamRequestMarshaller _instance = new UpdateWorkteamRequestMarshaller();        

        internal static UpdateWorkteamRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateWorkteamRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}