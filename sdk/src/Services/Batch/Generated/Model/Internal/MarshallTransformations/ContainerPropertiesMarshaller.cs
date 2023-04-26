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
using ThirdParty.Json.LitJson;

namespace Amazon.Batch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ContainerProperties Marshaller
    /// </summary>
    public class ContainerPropertiesMarshaller : IRequestMarshaller<ContainerProperties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ContainerProperties requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCommand())
            {
                context.Writer.WritePropertyName("command");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCommandListValue in requestObject.Command)
                {
                        context.Writer.Write(requestObjectCommandListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEnvironment())
            {
                context.Writer.WritePropertyName("environment");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEnvironmentListValue in requestObject.Environment)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = KeyValuePairMarshaller.Instance;
                    marshaller.Marshall(requestObjectEnvironmentListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEphemeralStorage())
            {
                context.Writer.WritePropertyName("ephemeralStorage");
                context.Writer.WriteObjectStart();

                var marshaller = EphemeralStorageMarshaller.Instance;
                marshaller.Marshall(requestObject.EphemeralStorage, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetExecutionRoleArn())
            {
                context.Writer.WritePropertyName("executionRoleArn");
                context.Writer.Write(requestObject.ExecutionRoleArn);
            }

            if(requestObject.IsSetFargatePlatformConfiguration())
            {
                context.Writer.WritePropertyName("fargatePlatformConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = FargatePlatformConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.FargatePlatformConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetImage())
            {
                context.Writer.WritePropertyName("image");
                context.Writer.Write(requestObject.Image);
            }

            if(requestObject.IsSetInstanceType())
            {
                context.Writer.WritePropertyName("instanceType");
                context.Writer.Write(requestObject.InstanceType);
            }

            if(requestObject.IsSetJobRoleArn())
            {
                context.Writer.WritePropertyName("jobRoleArn");
                context.Writer.Write(requestObject.JobRoleArn);
            }

            if(requestObject.IsSetLinuxParameters())
            {
                context.Writer.WritePropertyName("linuxParameters");
                context.Writer.WriteObjectStart();

                var marshaller = LinuxParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.LinuxParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLogConfiguration())
            {
                context.Writer.WritePropertyName("logConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = LogConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.LogConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMemory())
            {
                context.Writer.WritePropertyName("memory");
                context.Writer.Write(requestObject.Memory);
            }

            if(requestObject.IsSetMountPoints())
            {
                context.Writer.WritePropertyName("mountPoints");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMountPointsListValue in requestObject.MountPoints)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = MountPointMarshaller.Instance;
                    marshaller.Marshall(requestObjectMountPointsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNetworkConfiguration())
            {
                context.Writer.WritePropertyName("networkConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = NetworkConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.NetworkConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPrivileged())
            {
                context.Writer.WritePropertyName("privileged");
                context.Writer.Write(requestObject.Privileged);
            }

            if(requestObject.IsSetReadonlyRootFilesystem())
            {
                context.Writer.WritePropertyName("readonlyRootFilesystem");
                context.Writer.Write(requestObject.ReadonlyRootFilesystem);
            }

            if(requestObject.IsSetResourceRequirements())
            {
                context.Writer.WritePropertyName("resourceRequirements");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceRequirementsListValue in requestObject.ResourceRequirements)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ResourceRequirementMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceRequirementsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSecrets())
            {
                context.Writer.WritePropertyName("secrets");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSecretsListValue in requestObject.Secrets)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = SecretMarshaller.Instance;
                    marshaller.Marshall(requestObjectSecretsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetUlimits())
            {
                context.Writer.WritePropertyName("ulimits");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectUlimitsListValue in requestObject.Ulimits)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = UlimitMarshaller.Instance;
                    marshaller.Marshall(requestObjectUlimitsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetUser())
            {
                context.Writer.WritePropertyName("user");
                context.Writer.Write(requestObject.User);
            }

            if(requestObject.IsSetVcpus())
            {
                context.Writer.WritePropertyName("vcpus");
                context.Writer.Write(requestObject.Vcpus);
            }

            if(requestObject.IsSetVolumes())
            {
                context.Writer.WritePropertyName("volumes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectVolumesListValue in requestObject.Volumes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = VolumeMarshaller.Instance;
                    marshaller.Marshall(requestObjectVolumesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ContainerPropertiesMarshaller Instance = new ContainerPropertiesMarshaller();

    }
}