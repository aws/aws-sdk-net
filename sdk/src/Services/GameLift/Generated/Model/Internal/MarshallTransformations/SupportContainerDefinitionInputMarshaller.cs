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
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SupportContainerDefinitionInput Marshaller
    /// </summary>
    public class SupportContainerDefinitionInputMarshaller : IRequestMarshaller<SupportContainerDefinitionInput, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SupportContainerDefinitionInput requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetContainerName())
            {
                context.Writer.WriteTextString("ContainerName");
                context.Writer.WriteTextString(requestObject.ContainerName);
            }
            if (requestObject.IsSetDependsOn())
            {
                context.Writer.WriteTextString("DependsOn");
                context.Writer.WriteStartArray(requestObject.DependsOn.Count);
                foreach(var requestObjectDependsOnListValue in requestObject.DependsOn)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = ContainerDependencyMarshaller.Instance;
                    marshaller.Marshall(requestObjectDependsOnListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetEnvironmentOverride())
            {
                context.Writer.WriteTextString("EnvironmentOverride");
                context.Writer.WriteStartArray(requestObject.EnvironmentOverride.Count);
                foreach(var requestObjectEnvironmentOverrideListValue in requestObject.EnvironmentOverride)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = ContainerEnvironmentMarshaller.Instance;
                    marshaller.Marshall(requestObjectEnvironmentOverrideListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetEssential())
            {
                context.Writer.WriteTextString("Essential");
                context.Writer.WriteBoolean(requestObject.Essential.Value);
            }
            if (requestObject.IsSetHealthCheck())
            {
                context.Writer.WriteTextString("HealthCheck");
                context.Writer.WriteStartMap(null);

                var marshaller = ContainerHealthCheckMarshaller.Instance;
                marshaller.Marshall(requestObject.HealthCheck, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetImageUri())
            {
                context.Writer.WriteTextString("ImageUri");
                context.Writer.WriteTextString(requestObject.ImageUri);
            }
            if (requestObject.IsSetMemoryHardLimitMebibytes())
            {
                context.Writer.WriteTextString("MemoryHardLimitMebibytes");
                context.Writer.WriteInt32(requestObject.MemoryHardLimitMebibytes.Value);
            }
            if (requestObject.IsSetMountPoints())
            {
                context.Writer.WriteTextString("MountPoints");
                context.Writer.WriteStartArray(requestObject.MountPoints.Count);
                foreach(var requestObjectMountPointsListValue in requestObject.MountPoints)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = ContainerMountPointMarshaller.Instance;
                    marshaller.Marshall(requestObjectMountPointsListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetPortConfiguration())
            {
                context.Writer.WriteTextString("PortConfiguration");
                context.Writer.WriteStartMap(null);

                var marshaller = ContainerPortConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.PortConfiguration, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetVcpu())
            {
                context.Writer.WriteTextString("Vcpu");
                context.Writer.WriteOptimizedNumber(requestObject.Vcpu.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SupportContainerDefinitionInputMarshaller Instance = new SupportContainerDefinitionInputMarshaller();

    }
}