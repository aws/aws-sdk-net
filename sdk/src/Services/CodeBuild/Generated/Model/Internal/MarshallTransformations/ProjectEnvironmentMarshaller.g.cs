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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.CodeBuild.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.CodeBuild.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ProjectEnvironment Marshaller
    /// </summary>
    public partial class ProjectEnvironmentMarshaller : IRequestMarshaller<ProjectEnvironment, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ProjectEnvironment requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetCertificate())
            {
                context.Writer.WriteTextString("certificate");
                context.Writer.WriteTextString(requestObject.Certificate);
            }

            if (requestObject.IsSetComputeConfiguration())
            {
                context.Writer.WriteTextString("computeConfiguration");
                context.Writer.WriteStartMap(null);

                var marshaller = ComputeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ComputeConfiguration, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetComputeType())
            {
                context.Writer.WriteTextString("computeType");
                context.Writer.WriteTextString(requestObject.ComputeType);
            }

            if (requestObject.IsSetDockerServer())
            {
                context.Writer.WriteTextString("dockerServer");
                context.Writer.WriteStartMap(null);

                var marshaller = DockerServerMarshaller.Instance;
                marshaller.Marshall(requestObject.DockerServer, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetEnvironmentVariables())
            {
                context.Writer.WriteTextString("environmentVariables");
                context.Writer.WriteStartArray(requestObject.EnvironmentVariables.Count);
                foreach (var requestObjectEnvironmentVariablesListValue in requestObject.EnvironmentVariables)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = EnvironmentVariableMarshaller.Instance;
                    marshaller.Marshall(requestObjectEnvironmentVariablesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetFleet())
            {
                context.Writer.WriteTextString("fleet");
                context.Writer.WriteStartMap(null);

                var marshaller = ProjectFleetMarshaller.Instance;
                marshaller.Marshall(requestObject.Fleet, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetHostKernel())
            {
                context.Writer.WriteTextString("hostKernel");
                context.Writer.WriteTextString(requestObject.HostKernel);
            }

            if (requestObject.IsSetImage())
            {
                context.Writer.WriteTextString("image");
                context.Writer.WriteTextString(requestObject.Image);
            }

            if (requestObject.IsSetImagePullCredentialsType())
            {
                context.Writer.WriteTextString("imagePullCredentialsType");
                context.Writer.WriteTextString(requestObject.ImagePullCredentialsType);
            }

            if (requestObject.IsSetPrivilegedMode())
            {
                context.Writer.WriteTextString("privilegedMode");
                context.Writer.WriteBoolean(requestObject.PrivilegedMode.Value);
            }

            if (requestObject.IsSetRegistryCredential())
            {
                context.Writer.WriteTextString("registryCredential");
                context.Writer.WriteStartMap(null);

                var marshaller = RegistryCredentialMarshaller.Instance;
                marshaller.Marshall(requestObject.RegistryCredential, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetType())
            {
                context.Writer.WriteTextString("type");
                context.Writer.WriteTextString(requestObject.Type);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ProjectEnvironmentMarshaller Instance = new ProjectEnvironmentMarshaller();
    }
}
