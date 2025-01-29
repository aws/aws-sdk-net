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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameLift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SupportContainerDefinitionInput Marshaller
    /// </summary>
    public class SupportContainerDefinitionInputMarshaller : IRequestMarshaller<SupportContainerDefinitionInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SupportContainerDefinitionInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetContainerName())
            {
                context.Writer.WritePropertyName("ContainerName");
                context.Writer.WriteStringValue(requestObject.ContainerName);
            }

            if(requestObject.IsSetDependsOn())
            {
                context.Writer.WritePropertyName("DependsOn");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDependsOnListValue in requestObject.DependsOn)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ContainerDependencyMarshaller.Instance;
                    marshaller.Marshall(requestObjectDependsOnListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEnvironmentOverride())
            {
                context.Writer.WritePropertyName("EnvironmentOverride");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEnvironmentOverrideListValue in requestObject.EnvironmentOverride)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ContainerEnvironmentMarshaller.Instance;
                    marshaller.Marshall(requestObjectEnvironmentOverrideListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEssential())
            {
                context.Writer.WritePropertyName("Essential");
                context.Writer.WriteBooleanValue(requestObject.Essential.Value);
            }

            if(requestObject.IsSetHealthCheck())
            {
                context.Writer.WritePropertyName("HealthCheck");
                context.Writer.WriteStartObject();

                var marshaller = ContainerHealthCheckMarshaller.Instance;
                marshaller.Marshall(requestObject.HealthCheck, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetImageUri())
            {
                context.Writer.WritePropertyName("ImageUri");
                context.Writer.WriteStringValue(requestObject.ImageUri);
            }

            if(requestObject.IsSetMemoryHardLimitMebibytes())
            {
                context.Writer.WritePropertyName("MemoryHardLimitMebibytes");
                context.Writer.WriteNumberValue(requestObject.MemoryHardLimitMebibytes.Value);
            }

            if(requestObject.IsSetMountPoints())
            {
                context.Writer.WritePropertyName("MountPoints");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMountPointsListValue in requestObject.MountPoints)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ContainerMountPointMarshaller.Instance;
                    marshaller.Marshall(requestObjectMountPointsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPortConfiguration())
            {
                context.Writer.WritePropertyName("PortConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ContainerPortConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.PortConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVcpu())
            {
                context.Writer.WritePropertyName("Vcpu");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Vcpu.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Vcpu.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Vcpu.Value);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SupportContainerDefinitionInputMarshaller Instance = new SupportContainerDefinitionInputMarshaller();

    }
}