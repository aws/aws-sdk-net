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
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.CodeBuild.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ProjectEnvironment Object
    /// </summary>
    public partial class ProjectEnvironmentUnmarshaller : ICborUnmarshaller<ProjectEnvironment, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ProjectEnvironment Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new ProjectEnvironment();
            if (context.IsEmptyResponse) return null;

            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "certificate":
                        context.AddPathSegment("Certificate");
                        unmarshalledObject.Certificate = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "computeConfiguration":
                        context.AddPathSegment("ComputeConfiguration");
                        unmarshalledObject.ComputeConfiguration = ComputeConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "computeType":
                        context.AddPathSegment("ComputeType");
                        unmarshalledObject.ComputeType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "dockerServer":
                        context.AddPathSegment("DockerServer");
                        unmarshalledObject.DockerServer = DockerServerUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "environmentVariables":
                        context.AddPathSegment("EnvironmentVariables");
                        unmarshalledObject.EnvironmentVariables = new CborListUnmarshaller<EnvironmentVariable, EnvironmentVariableUnmarshaller>(EnvironmentVariableUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "fleet":
                        context.AddPathSegment("Fleet");
                        unmarshalledObject.Fleet = ProjectFleetUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "hostKernel":
                        context.AddPathSegment("HostKernel");
                        unmarshalledObject.HostKernel = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "image":
                        context.AddPathSegment("Image");
                        unmarshalledObject.Image = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "imagePullCredentialsType":
                        context.AddPathSegment("ImagePullCredentialsType");
                        unmarshalledObject.ImagePullCredentialsType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "privilegedMode":
                        context.AddPathSegment("PrivilegedMode");
                        unmarshalledObject.PrivilegedMode = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "registryCredential":
                        context.AddPathSegment("RegistryCredential");
                        unmarshalledObject.RegistryCredential = RegistryCredentialUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "type":
                        context.AddPathSegment("Type");
                        unmarshalledObject.Type = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            return unmarshalledObject;
        }

        private static ProjectEnvironmentUnmarshaller _instance = new ProjectEnvironmentUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ProjectEnvironmentUnmarshaller Instance => _instance;
    }
}
