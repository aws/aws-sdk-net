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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsEcsTaskDefinitionDetails Marshaller
    /// </summary>
    public class AwsEcsTaskDefinitionDetailsMarshaller : IRequestMarshaller<AwsEcsTaskDefinitionDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEcsTaskDefinitionDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetContainerDefinitions())
            {
                context.Writer.WritePropertyName("ContainerDefinitions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectContainerDefinitionsListValue in requestObject.ContainerDefinitions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEcsTaskDefinitionContainerDefinitionsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectContainerDefinitionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCpu())
            {
                context.Writer.WritePropertyName("Cpu");
                context.Writer.WriteStringValue(requestObject.Cpu);
            }

            if(requestObject.IsSetExecutionRoleArn())
            {
                context.Writer.WritePropertyName("ExecutionRoleArn");
                context.Writer.WriteStringValue(requestObject.ExecutionRoleArn);
            }

            if(requestObject.IsSetFamily())
            {
                context.Writer.WritePropertyName("Family");
                context.Writer.WriteStringValue(requestObject.Family);
            }

            if(requestObject.IsSetInferenceAccelerators())
            {
                context.Writer.WritePropertyName("InferenceAccelerators");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInferenceAcceleratorsListValue in requestObject.InferenceAccelerators)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEcsTaskDefinitionInferenceAcceleratorsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectInferenceAcceleratorsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetIpcMode())
            {
                context.Writer.WritePropertyName("IpcMode");
                context.Writer.WriteStringValue(requestObject.IpcMode);
            }

            if(requestObject.IsSetMemory())
            {
                context.Writer.WritePropertyName("Memory");
                context.Writer.WriteStringValue(requestObject.Memory);
            }

            if(requestObject.IsSetNetworkMode())
            {
                context.Writer.WritePropertyName("NetworkMode");
                context.Writer.WriteStringValue(requestObject.NetworkMode);
            }

            if(requestObject.IsSetPidMode())
            {
                context.Writer.WritePropertyName("PidMode");
                context.Writer.WriteStringValue(requestObject.PidMode);
            }

            if(requestObject.IsSetPlacementConstraints())
            {
                context.Writer.WritePropertyName("PlacementConstraints");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPlacementConstraintsListValue in requestObject.PlacementConstraints)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEcsTaskDefinitionPlacementConstraintsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectPlacementConstraintsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetProxyConfiguration())
            {
                context.Writer.WritePropertyName("ProxyConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AwsEcsTaskDefinitionProxyConfigurationDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.ProxyConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRequiresCompatibilities())
            {
                context.Writer.WritePropertyName("RequiresCompatibilities");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRequiresCompatibilitiesListValue in requestObject.RequiresCompatibilities)
                {
                        context.Writer.WriteStringValue(requestObjectRequiresCompatibilitiesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStringValue(requestObject.Status);
            }

            if(requestObject.IsSetTaskRoleArn())
            {
                context.Writer.WritePropertyName("TaskRoleArn");
                context.Writer.WriteStringValue(requestObject.TaskRoleArn);
            }

            if(requestObject.IsSetVolumes())
            {
                context.Writer.WritePropertyName("Volumes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVolumesListValue in requestObject.Volumes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEcsTaskDefinitionVolumesDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectVolumesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEcsTaskDefinitionDetailsMarshaller Instance = new AwsEcsTaskDefinitionDetailsMarshaller();

    }
}