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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pipes.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Pipes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EcsTaskOverride Marshaller
    /// </summary>
    public class EcsTaskOverrideMarshaller : IRequestMarshaller<EcsTaskOverride, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EcsTaskOverride requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetContainerOverrides())
            {
                context.Writer.WritePropertyName("ContainerOverrides");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectContainerOverridesListValue in requestObject.ContainerOverrides)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = EcsContainerOverrideMarshaller.Instance;
                    marshaller.Marshall(requestObjectContainerOverridesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCpu())
            {
                context.Writer.WritePropertyName("Cpu");
                context.Writer.Write(requestObject.Cpu);
            }

            if(requestObject.IsSetEphemeralStorage())
            {
                context.Writer.WritePropertyName("EphemeralStorage");
                context.Writer.WriteObjectStart();

                var marshaller = EcsEphemeralStorageMarshaller.Instance;
                marshaller.Marshall(requestObject.EphemeralStorage, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetExecutionRoleArn())
            {
                context.Writer.WritePropertyName("ExecutionRoleArn");
                context.Writer.Write(requestObject.ExecutionRoleArn);
            }

            if(requestObject.IsSetInferenceAcceleratorOverrides())
            {
                context.Writer.WritePropertyName("InferenceAcceleratorOverrides");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInferenceAcceleratorOverridesListValue in requestObject.InferenceAcceleratorOverrides)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = EcsInferenceAcceleratorOverrideMarshaller.Instance;
                    marshaller.Marshall(requestObjectInferenceAcceleratorOverridesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMemory())
            {
                context.Writer.WritePropertyName("Memory");
                context.Writer.Write(requestObject.Memory);
            }

            if(requestObject.IsSetTaskRoleArn())
            {
                context.Writer.WritePropertyName("TaskRoleArn");
                context.Writer.Write(requestObject.TaskRoleArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EcsTaskOverrideMarshaller Instance = new EcsTaskOverrideMarshaller();

    }
}