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
using ThirdParty.Json.LitJson;

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
                context.Writer.Write(requestObject.ContainerName);
            }

            if(requestObject.IsSetDependsOn())
            {
                context.Writer.WritePropertyName("DependsOn");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDependsOnListValue in requestObject.DependsOn)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ContainerDependencyMarshaller.Instance;
                    marshaller.Marshall(requestObjectDependsOnListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEnvironmentOverride())
            {
                context.Writer.WritePropertyName("EnvironmentOverride");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEnvironmentOverrideListValue in requestObject.EnvironmentOverride)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ContainerEnvironmentMarshaller.Instance;
                    marshaller.Marshall(requestObjectEnvironmentOverrideListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEssential())
            {
                context.Writer.WritePropertyName("Essential");
                context.Writer.Write(requestObject.Essential);
            }

            if(requestObject.IsSetHealthCheck())
            {
                context.Writer.WritePropertyName("HealthCheck");
                context.Writer.WriteObjectStart();

                var marshaller = ContainerHealthCheckMarshaller.Instance;
                marshaller.Marshall(requestObject.HealthCheck, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetImageUri())
            {
                context.Writer.WritePropertyName("ImageUri");
                context.Writer.Write(requestObject.ImageUri);
            }

            if(requestObject.IsSetMemoryHardLimitMebibytes())
            {
                context.Writer.WritePropertyName("MemoryHardLimitMebibytes");
                context.Writer.Write(requestObject.MemoryHardLimitMebibytes);
            }

            if(requestObject.IsSetMountPoints())
            {
                context.Writer.WritePropertyName("MountPoints");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMountPointsListValue in requestObject.MountPoints)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ContainerMountPointMarshaller.Instance;
                    marshaller.Marshall(requestObjectMountPointsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPortConfiguration())
            {
                context.Writer.WritePropertyName("PortConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ContainerPortConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.PortConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVcpu())
            {
                context.Writer.WritePropertyName("Vcpu");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Vcpu))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.Vcpu));
                }
                else
                {
                    context.Writer.Write(requestObject.Vcpu);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SupportContainerDefinitionInputMarshaller Instance = new SupportContainerDefinitionInputMarshaller();

    }
}