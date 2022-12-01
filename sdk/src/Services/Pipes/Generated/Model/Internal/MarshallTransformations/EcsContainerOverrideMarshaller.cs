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
    /// EcsContainerOverride Marshaller
    /// </summary>
    public class EcsContainerOverrideMarshaller : IRequestMarshaller<EcsContainerOverride, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EcsContainerOverride requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCommand())
            {
                context.Writer.WritePropertyName("Command");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCommandListValue in requestObject.Command)
                {
                        context.Writer.Write(requestObjectCommandListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCpu())
            {
                context.Writer.WritePropertyName("Cpu");
                context.Writer.Write(requestObject.Cpu);
            }

            if(requestObject.IsSetEnvironment())
            {
                context.Writer.WritePropertyName("Environment");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEnvironmentListValue in requestObject.Environment)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = EcsEnvironmentVariableMarshaller.Instance;
                    marshaller.Marshall(requestObjectEnvironmentListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEnvironmentFiles())
            {
                context.Writer.WritePropertyName("EnvironmentFiles");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEnvironmentFilesListValue in requestObject.EnvironmentFiles)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = EcsEnvironmentFileMarshaller.Instance;
                    marshaller.Marshall(requestObjectEnvironmentFilesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMemory())
            {
                context.Writer.WritePropertyName("Memory");
                context.Writer.Write(requestObject.Memory);
            }

            if(requestObject.IsSetMemoryReservation())
            {
                context.Writer.WritePropertyName("MemoryReservation");
                context.Writer.Write(requestObject.MemoryReservation);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetResourceRequirements())
            {
                context.Writer.WritePropertyName("ResourceRequirements");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceRequirementsListValue in requestObject.ResourceRequirements)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = EcsResourceRequirementMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceRequirementsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EcsContainerOverrideMarshaller Instance = new EcsContainerOverrideMarshaller();

    }
}