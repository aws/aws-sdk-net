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
    /// RegisterTaskDefinition Request Marshaller
    /// </summary>       
    public class RegisterTaskDefinitionRequestMarshaller : IMarshaller<IRequest, RegisterTaskDefinitionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RegisterTaskDefinitionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RegisterTaskDefinitionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ECS");
            string target = "AmazonEC2ContainerServiceV20141113.RegisterTaskDefinition";
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
            if(publicRequest.IsSetContainerDefinitions())
            {
                context.Writer.WritePropertyName("containerDefinitions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestContainerDefinitionsListValue in publicRequest.ContainerDefinitions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ContainerDefinitionMarshaller.Instance;
                    marshaller.Marshall(publicRequestContainerDefinitionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetCpu())
            {
                context.Writer.WritePropertyName("cpu");
                context.Writer.WriteStringValue(publicRequest.Cpu);
            }

            if(publicRequest.IsSetEnableFaultInjection())
            {
                context.Writer.WritePropertyName("enableFaultInjection");
                context.Writer.WriteBooleanValue(publicRequest.EnableFaultInjection.Value);
            }

            if(publicRequest.IsSetEphemeralStorage())
            {
                context.Writer.WritePropertyName("ephemeralStorage");
                context.Writer.WriteStartObject();

                var marshaller = EphemeralStorageMarshaller.Instance;
                marshaller.Marshall(publicRequest.EphemeralStorage, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetExecutionRoleArn())
            {
                context.Writer.WritePropertyName("executionRoleArn");
                context.Writer.WriteStringValue(publicRequest.ExecutionRoleArn);
            }

            if(publicRequest.IsSetFamily())
            {
                context.Writer.WritePropertyName("family");
                context.Writer.WriteStringValue(publicRequest.Family);
            }

            if(publicRequest.IsSetInferenceAccelerators())
            {
                context.Writer.WritePropertyName("inferenceAccelerators");
                context.Writer.WriteStartArray();
                foreach(var publicRequestInferenceAcceleratorsListValue in publicRequest.InferenceAccelerators)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InferenceAcceleratorMarshaller.Instance;
                    marshaller.Marshall(publicRequestInferenceAcceleratorsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetIpcMode())
            {
                context.Writer.WritePropertyName("ipcMode");
                context.Writer.WriteStringValue(publicRequest.IpcMode);
            }

            if(publicRequest.IsSetMemory())
            {
                context.Writer.WritePropertyName("memory");
                context.Writer.WriteStringValue(publicRequest.Memory);
            }

            if(publicRequest.IsSetNetworkMode())
            {
                context.Writer.WritePropertyName("networkMode");
                context.Writer.WriteStringValue(publicRequest.NetworkMode);
            }

            if(publicRequest.IsSetPidMode())
            {
                context.Writer.WritePropertyName("pidMode");
                context.Writer.WriteStringValue(publicRequest.PidMode);
            }

            if(publicRequest.IsSetPlacementConstraints())
            {
                context.Writer.WritePropertyName("placementConstraints");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPlacementConstraintsListValue in publicRequest.PlacementConstraints)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TaskDefinitionPlacementConstraintMarshaller.Instance;
                    marshaller.Marshall(publicRequestPlacementConstraintsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetProxyConfiguration())
            {
                context.Writer.WritePropertyName("proxyConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ProxyConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ProxyConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRequiresCompatibilities())
            {
                context.Writer.WritePropertyName("requiresCompatibilities");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRequiresCompatibilitiesListValue in publicRequest.RequiresCompatibilities)
                {
                        context.Writer.WriteStringValue(publicRequestRequiresCompatibilitiesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetRuntimePlatform())
            {
                context.Writer.WritePropertyName("runtimePlatform");
                context.Writer.WriteStartObject();

                var marshaller = RuntimePlatformMarshaller.Instance;
                marshaller.Marshall(publicRequest.RuntimePlatform, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTaskRoleArn())
            {
                context.Writer.WritePropertyName("taskRoleArn");
                context.Writer.WriteStringValue(publicRequest.TaskRoleArn);
            }

            if(publicRequest.IsSetVolumes())
            {
                context.Writer.WritePropertyName("volumes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestVolumesListValue in publicRequest.Volumes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = VolumeMarshaller.Instance;
                    marshaller.Marshall(publicRequestVolumesListValue, context);

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
        private static RegisterTaskDefinitionRequestMarshaller _instance = new RegisterTaskDefinitionRequestMarshaller();        

        internal static RegisterTaskDefinitionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RegisterTaskDefinitionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}