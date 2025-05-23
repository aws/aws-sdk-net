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
    /// StartTask Request Marshaller
    /// </summary>       
    public class StartTaskRequestMarshaller : IMarshaller<IRequest, StartTaskRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartTaskRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ECS");
            string target = "AmazonEC2ContainerServiceV20141113.StartTask";
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
            if(publicRequest.IsSetCluster())
            {
                context.Writer.WritePropertyName("cluster");
                context.Writer.WriteStringValue(publicRequest.Cluster);
            }

            if(publicRequest.IsSetContainerInstances())
            {
                context.Writer.WritePropertyName("containerInstances");
                context.Writer.WriteStartArray();
                foreach(var publicRequestContainerInstancesListValue in publicRequest.ContainerInstances)
                {
                        context.Writer.WriteStringValue(publicRequestContainerInstancesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetEnableECSManagedTags())
            {
                context.Writer.WritePropertyName("enableECSManagedTags");
                context.Writer.WriteBooleanValue(publicRequest.EnableECSManagedTags.Value);
            }

            if(publicRequest.IsSetEnableExecuteCommand())
            {
                context.Writer.WritePropertyName("enableExecuteCommand");
                context.Writer.WriteBooleanValue(publicRequest.EnableExecuteCommand.Value);
            }

            if(publicRequest.IsSetGroup())
            {
                context.Writer.WritePropertyName("group");
                context.Writer.WriteStringValue(publicRequest.Group);
            }

            if(publicRequest.IsSetNetworkConfiguration())
            {
                context.Writer.WritePropertyName("networkConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = NetworkConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.NetworkConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOverrides())
            {
                context.Writer.WritePropertyName("overrides");
                context.Writer.WriteStartObject();

                var marshaller = TaskOverrideMarshaller.Instance;
                marshaller.Marshall(publicRequest.Overrides, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPropagateTags())
            {
                context.Writer.WritePropertyName("propagateTags");
                context.Writer.WriteStringValue(publicRequest.PropagateTags);
            }

            if(publicRequest.IsSetReferenceId())
            {
                context.Writer.WritePropertyName("referenceId");
                context.Writer.WriteStringValue(publicRequest.ReferenceId);
            }

            if(publicRequest.IsSetStartedBy())
            {
                context.Writer.WritePropertyName("startedBy");
                context.Writer.WriteStringValue(publicRequest.StartedBy);
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

            if(publicRequest.IsSetTaskDefinition())
            {
                context.Writer.WritePropertyName("taskDefinition");
                context.Writer.WriteStringValue(publicRequest.TaskDefinition);
            }

            if(publicRequest.IsSetVolumeConfigurations())
            {
                context.Writer.WritePropertyName("volumeConfigurations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestVolumeConfigurationsListValue in publicRequest.VolumeConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TaskVolumeConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestVolumeConfigurationsListValue, context);

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
        private static StartTaskRequestMarshaller _instance = new StartTaskRequestMarshaller();        

        internal static StartTaskRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartTaskRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}