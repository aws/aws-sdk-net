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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Batch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Batch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EcsTaskProperties Marshaller
    /// </summary>
    public class EcsTaskPropertiesMarshaller : IRequestMarshaller<EcsTaskProperties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EcsTaskProperties requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetContainers())
            {
                context.Writer.WritePropertyName("containers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectContainersListValue in requestObject.Containers)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TaskContainerPropertiesMarshaller.Instance;
                    marshaller.Marshall(requestObjectContainersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEnableExecuteCommand())
            {
                context.Writer.WritePropertyName("enableExecuteCommand");
                context.Writer.WriteBooleanValue(requestObject.EnableExecuteCommand.Value);
            }

            if(requestObject.IsSetEphemeralStorage())
            {
                context.Writer.WritePropertyName("ephemeralStorage");
                context.Writer.WriteStartObject();

                var marshaller = EphemeralStorageMarshaller.Instance;
                marshaller.Marshall(requestObject.EphemeralStorage, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetExecutionRoleArn())
            {
                context.Writer.WritePropertyName("executionRoleArn");
                context.Writer.WriteStringValue(requestObject.ExecutionRoleArn);
            }

            if(requestObject.IsSetIpcMode())
            {
                context.Writer.WritePropertyName("ipcMode");
                context.Writer.WriteStringValue(requestObject.IpcMode);
            }

            if(requestObject.IsSetNetworkConfiguration())
            {
                context.Writer.WritePropertyName("networkConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = NetworkConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.NetworkConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPidMode())
            {
                context.Writer.WritePropertyName("pidMode");
                context.Writer.WriteStringValue(requestObject.PidMode);
            }

            if(requestObject.IsSetPlatformVersion())
            {
                context.Writer.WritePropertyName("platformVersion");
                context.Writer.WriteStringValue(requestObject.PlatformVersion);
            }

            if(requestObject.IsSetRuntimePlatform())
            {
                context.Writer.WritePropertyName("runtimePlatform");
                context.Writer.WriteStartObject();

                var marshaller = RuntimePlatformMarshaller.Instance;
                marshaller.Marshall(requestObject.RuntimePlatform, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTaskRoleArn())
            {
                context.Writer.WritePropertyName("taskRoleArn");
                context.Writer.WriteStringValue(requestObject.TaskRoleArn);
            }

            if(requestObject.IsSetVolumes())
            {
                context.Writer.WritePropertyName("volumes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVolumesListValue in requestObject.Volumes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = VolumeMarshaller.Instance;
                    marshaller.Marshall(requestObjectVolumesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EcsTaskPropertiesMarshaller Instance = new EcsTaskPropertiesMarshaller();

    }
}