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
 * Do not modify this file. This file is generated from the sagemaker-edge-2020-09-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SagemakerEdgeManager.Model;
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
namespace Amazon.SagemakerEdgeManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SendHeartbeat Request Marshaller
    /// </summary>       
    public class SendHeartbeatRequestMarshaller : IMarshaller<IRequest, SendHeartbeatRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendHeartbeatRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SendHeartbeatRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SagemakerEdgeManager");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-09-23";
            request.HttpMethod = "POST";

            request.ResourcePath = "/SendHeartbeat";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAgentMetrics())
            {
                context.Writer.WritePropertyName("AgentMetrics");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAgentMetricsListValue in publicRequest.AgentMetrics)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EdgeMetricMarshaller.Instance;
                    marshaller.Marshall(publicRequestAgentMetricsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAgentVersion())
            {
                context.Writer.WritePropertyName("AgentVersion");
                context.Writer.WriteStringValue(publicRequest.AgentVersion);
            }

            if(publicRequest.IsSetDeploymentResult())
            {
                context.Writer.WritePropertyName("DeploymentResult");
                context.Writer.WriteStartObject();

                var marshaller = DeploymentResultMarshaller.Instance;
                marshaller.Marshall(publicRequest.DeploymentResult, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDeviceFleetName())
            {
                context.Writer.WritePropertyName("DeviceFleetName");
                context.Writer.WriteStringValue(publicRequest.DeviceFleetName);
            }

            if(publicRequest.IsSetDeviceName())
            {
                context.Writer.WritePropertyName("DeviceName");
                context.Writer.WriteStringValue(publicRequest.DeviceName);
            }

            if(publicRequest.IsSetModels())
            {
                context.Writer.WritePropertyName("Models");
                context.Writer.WriteStartArray();
                foreach(var publicRequestModelsListValue in publicRequest.Models)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ModelMarshaller.Instance;
                    marshaller.Marshall(publicRequestModelsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
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
        private static SendHeartbeatRequestMarshaller _instance = new SendHeartbeatRequestMarshaller();        

        internal static SendHeartbeatRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendHeartbeatRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}