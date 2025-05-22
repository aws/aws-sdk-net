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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeBuild.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CodeBuild.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ProjectEnvironment Marshaller
    /// </summary>
    public class ProjectEnvironmentMarshaller : IRequestMarshaller<ProjectEnvironment, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ProjectEnvironment requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCertificate())
            {
                context.Writer.WritePropertyName("certificate");
                context.Writer.WriteStringValue(requestObject.Certificate);
            }

            if(requestObject.IsSetComputeConfiguration())
            {
                context.Writer.WritePropertyName("computeConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ComputeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ComputeConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetComputeType())
            {
                context.Writer.WritePropertyName("computeType");
                context.Writer.WriteStringValue(requestObject.ComputeType);
            }

            if(requestObject.IsSetDockerServer())
            {
                context.Writer.WritePropertyName("dockerServer");
                context.Writer.WriteStartObject();

                var marshaller = DockerServerMarshaller.Instance;
                marshaller.Marshall(requestObject.DockerServer, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEnvironmentVariables())
            {
                context.Writer.WritePropertyName("environmentVariables");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEnvironmentVariablesListValue in requestObject.EnvironmentVariables)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EnvironmentVariableMarshaller.Instance;
                    marshaller.Marshall(requestObjectEnvironmentVariablesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFleet())
            {
                context.Writer.WritePropertyName("fleet");
                context.Writer.WriteStartObject();

                var marshaller = ProjectFleetMarshaller.Instance;
                marshaller.Marshall(requestObject.Fleet, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetImage())
            {
                context.Writer.WritePropertyName("image");
                context.Writer.WriteStringValue(requestObject.Image);
            }

            if(requestObject.IsSetImagePullCredentialsType())
            {
                context.Writer.WritePropertyName("imagePullCredentialsType");
                context.Writer.WriteStringValue(requestObject.ImagePullCredentialsType);
            }

            if(requestObject.IsSetPrivilegedMode())
            {
                context.Writer.WritePropertyName("privilegedMode");
                context.Writer.WriteBooleanValue(requestObject.PrivilegedMode.Value);
            }

            if(requestObject.IsSetRegistryCredential())
            {
                context.Writer.WritePropertyName("registryCredential");
                context.Writer.WriteStartObject();

                var marshaller = RegistryCredentialMarshaller.Instance;
                marshaller.Marshall(requestObject.RegistryCredential, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ProjectEnvironmentMarshaller Instance = new ProjectEnvironmentMarshaller();

    }
}