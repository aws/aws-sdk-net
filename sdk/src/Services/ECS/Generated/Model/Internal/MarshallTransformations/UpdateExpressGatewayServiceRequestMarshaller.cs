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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECS.Model;
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
namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateExpressGatewayService Request Marshaller
    /// </summary>       
    public class UpdateExpressGatewayServiceRequestMarshaller : IMarshaller<IRequest, UpdateExpressGatewayServiceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateExpressGatewayServiceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateExpressGatewayServiceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ECS");
            string target = "AmazonEC2ContainerServiceV20141113.UpdateExpressGatewayService";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-11-13";
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
            if(publicRequest.IsSetCpu())
            {
                context.Writer.WritePropertyName("cpu");
                context.Writer.WriteStringValue(publicRequest.Cpu);
            }

            if(publicRequest.IsSetExecutionRoleArn())
            {
                context.Writer.WritePropertyName("executionRoleArn");
                context.Writer.WriteStringValue(publicRequest.ExecutionRoleArn);
            }

            if(publicRequest.IsSetHealthCheckPath())
            {
                context.Writer.WritePropertyName("healthCheckPath");
                context.Writer.WriteStringValue(publicRequest.HealthCheckPath);
            }

            if(publicRequest.IsSetMemory())
            {
                context.Writer.WritePropertyName("memory");
                context.Writer.WriteStringValue(publicRequest.Memory);
            }

            if(publicRequest.IsSetNetworkConfiguration())
            {
                context.Writer.WritePropertyName("networkConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ExpressGatewayServiceNetworkConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.NetworkConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPrimaryContainer())
            {
                context.Writer.WritePropertyName("primaryContainer");
                context.Writer.WriteStartObject();

                var marshaller = ExpressGatewayContainerMarshaller.Instance;
                marshaller.Marshall(publicRequest.PrimaryContainer, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetScalingTarget())
            {
                context.Writer.WritePropertyName("scalingTarget");
                context.Writer.WriteStartObject();

                var marshaller = ExpressGatewayScalingTargetMarshaller.Instance;
                marshaller.Marshall(publicRequest.ScalingTarget, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetServiceArn())
            {
                context.Writer.WritePropertyName("serviceArn");
                context.Writer.WriteStringValue(publicRequest.ServiceArn);
            }

            if(publicRequest.IsSetTaskRoleArn())
            {
                context.Writer.WritePropertyName("taskRoleArn");
                context.Writer.WriteStringValue(publicRequest.TaskRoleArn);
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
        private static UpdateExpressGatewayServiceRequestMarshaller _instance = new UpdateExpressGatewayServiceRequestMarshaller();        

        internal static UpdateExpressGatewayServiceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateExpressGatewayServiceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}