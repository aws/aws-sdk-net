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
 * Do not modify this file. This file is generated from the lambda-microvms-2025-09-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LambdaMicrovms.Model;
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
namespace Amazon.LambdaMicrovms.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RunMicrovm Request Marshaller
    /// </summary>       
    public class RunMicrovmRequestMarshaller : IMarshaller<IRequest, RunMicrovmRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RunMicrovmRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RunMicrovmRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LambdaMicrovms");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-09-09";
            request.HttpMethod = "POST";

            request.ResourcePath = "/2025-09-09/microvms";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetEgressNetworkConnectors())
            {
                context.Writer.WritePropertyName("egressNetworkConnectors");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEgressNetworkConnectorsListValue in publicRequest.EgressNetworkConnectors)
                {
                        context.Writer.WriteStringValue(publicRequestEgressNetworkConnectorsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetExecutionRoleArn())
            {
                context.Writer.WritePropertyName("executionRoleArn");
                context.Writer.WriteStringValue(publicRequest.ExecutionRoleArn);
            }

            if(publicRequest.IsSetIdlePolicy())
            {
                context.Writer.WritePropertyName("idlePolicy");
                context.Writer.WriteStartObject();

                var marshaller = IdlePolicyMarshaller.Instance;
                marshaller.Marshall(publicRequest.IdlePolicy, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetImageIdentifier())
            {
                context.Writer.WritePropertyName("imageIdentifier");
                context.Writer.WriteStringValue(publicRequest.ImageIdentifier);
            }

            if(publicRequest.IsSetImageVersion())
            {
                context.Writer.WritePropertyName("imageVersion");
                context.Writer.WriteStringValue(publicRequest.ImageVersion);
            }

            if(publicRequest.IsSetIngressNetworkConnectors())
            {
                context.Writer.WritePropertyName("ingressNetworkConnectors");
                context.Writer.WriteStartArray();
                foreach(var publicRequestIngressNetworkConnectorsListValue in publicRequest.IngressNetworkConnectors)
                {
                        context.Writer.WriteStringValue(publicRequestIngressNetworkConnectorsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetLogging())
            {
                context.Writer.WritePropertyName("logging");
                context.Writer.WriteStartObject();

                var marshaller = LoggingMarshaller.Instance;
                marshaller.Marshall(publicRequest.Logging, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMaximumDurationInSeconds())
            {
                context.Writer.WritePropertyName("maximumDurationInSeconds");
                context.Writer.WriteNumberValue(publicRequest.MaximumDurationInSeconds.Value);
            }

            if(publicRequest.IsSetRunHookPayload())
            {
                context.Writer.WritePropertyName("runHookPayload");
                context.Writer.WriteStringValue(publicRequest.RunHookPayload);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static RunMicrovmRequestMarshaller _instance = new RunMicrovmRequestMarshaller();        

        internal static RunMicrovmRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RunMicrovmRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}