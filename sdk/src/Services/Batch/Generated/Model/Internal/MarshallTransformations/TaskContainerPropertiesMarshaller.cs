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
    /// TaskContainerProperties Marshaller
    /// </summary>
    public class TaskContainerPropertiesMarshaller : IRequestMarshaller<TaskContainerProperties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TaskContainerProperties requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCommand())
            {
                context.Writer.WritePropertyName("command");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCommandListValue in requestObject.Command)
                {
                        context.Writer.WriteStringValue(requestObjectCommandListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDependsOn())
            {
                context.Writer.WritePropertyName("dependsOn");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDependsOnListValue in requestObject.DependsOn)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TaskContainerDependencyMarshaller.Instance;
                    marshaller.Marshall(requestObjectDependsOnListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEnvironment())
            {
                context.Writer.WritePropertyName("environment");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEnvironmentListValue in requestObject.Environment)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = KeyValuePairMarshaller.Instance;
                    marshaller.Marshall(requestObjectEnvironmentListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEssential())
            {
                context.Writer.WritePropertyName("essential");
                context.Writer.WriteBooleanValue(requestObject.Essential.Value);
            }

            if(requestObject.IsSetFirelensConfiguration())
            {
                context.Writer.WritePropertyName("firelensConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = FirelensConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.FirelensConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetImage())
            {
                context.Writer.WritePropertyName("image");
                context.Writer.WriteStringValue(requestObject.Image);
            }

            if(requestObject.IsSetLinuxParameters())
            {
                context.Writer.WritePropertyName("linuxParameters");
                context.Writer.WriteStartObject();

                var marshaller = LinuxParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.LinuxParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLogConfiguration())
            {
                context.Writer.WritePropertyName("logConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = LogConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.LogConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMountPoints())
            {
                context.Writer.WritePropertyName("mountPoints");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMountPointsListValue in requestObject.MountPoints)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MountPointMarshaller.Instance;
                    marshaller.Marshall(requestObjectMountPointsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetPrivileged())
            {
                context.Writer.WritePropertyName("privileged");
                context.Writer.WriteBooleanValue(requestObject.Privileged.Value);
            }

            if(requestObject.IsSetReadonlyRootFilesystem())
            {
                context.Writer.WritePropertyName("readonlyRootFilesystem");
                context.Writer.WriteBooleanValue(requestObject.ReadonlyRootFilesystem.Value);
            }

            if(requestObject.IsSetRepositoryCredentials())
            {
                context.Writer.WritePropertyName("repositoryCredentials");
                context.Writer.WriteStartObject();

                var marshaller = RepositoryCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.RepositoryCredentials, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetResourceRequirements())
            {
                context.Writer.WritePropertyName("resourceRequirements");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceRequirementsListValue in requestObject.ResourceRequirements)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ResourceRequirementMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceRequirementsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSecrets())
            {
                context.Writer.WritePropertyName("secrets");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSecretsListValue in requestObject.Secrets)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SecretMarshaller.Instance;
                    marshaller.Marshall(requestObjectSecretsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetUlimits())
            {
                context.Writer.WritePropertyName("ulimits");
                context.Writer.WriteStartArray();
                foreach(var requestObjectUlimitsListValue in requestObject.Ulimits)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = UlimitMarshaller.Instance;
                    marshaller.Marshall(requestObjectUlimitsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetUser())
            {
                context.Writer.WritePropertyName("user");
                context.Writer.WriteStringValue(requestObject.User);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TaskContainerPropertiesMarshaller Instance = new TaskContainerPropertiesMarshaller();

    }
}