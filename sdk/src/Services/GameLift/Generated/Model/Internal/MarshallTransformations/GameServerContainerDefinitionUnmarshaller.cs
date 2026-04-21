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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameLift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GameServerContainerDefinition Object
    /// </summary>  
    public class GameServerContainerDefinitionUnmarshaller : ICborUnmarshaller<GameServerContainerDefinition, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public GameServerContainerDefinition Unmarshall(CborUnmarshallerContext context)
        {
            GameServerContainerDefinition unmarshalledObject = new GameServerContainerDefinition();
            if (context.IsEmptyResponse)
                return null;
            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "ContainerName":
                        {
                            context.AddPathSegment("ContainerName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ContainerName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DependsOn":
                        {
                            context.AddPathSegment("DependsOn");
                            var unmarshaller = new CborListUnmarshaller<ContainerDependency, ContainerDependencyUnmarshaller>(ContainerDependencyUnmarshaller.Instance);
                            unmarshalledObject.DependsOn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EnvironmentOverride":
                        {
                            context.AddPathSegment("EnvironmentOverride");
                            var unmarshaller = new CborListUnmarshaller<ContainerEnvironment, ContainerEnvironmentUnmarshaller>(ContainerEnvironmentUnmarshaller.Instance);
                            unmarshalledObject.EnvironmentOverride = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ImageUri":
                        {
                            context.AddPathSegment("ImageUri");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ImageUri = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "MountPoints":
                        {
                            context.AddPathSegment("MountPoints");
                            var unmarshaller = new CborListUnmarshaller<ContainerMountPoint, ContainerMountPointUnmarshaller>(ContainerMountPointUnmarshaller.Instance);
                            unmarshalledObject.MountPoints = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PortConfiguration":
                        {
                            context.AddPathSegment("PortConfiguration");
                            var unmarshaller = ContainerPortConfigurationUnmarshaller.Instance;
                            unmarshalledObject.PortConfiguration = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ResolvedImageDigest":
                        {
                            context.AddPathSegment("ResolvedImageDigest");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ResolvedImageDigest = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ServerSdkVersion":
                        {
                            context.AddPathSegment("ServerSdkVersion");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ServerSdkVersion = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            return unmarshalledObject;
        }


        private static GameServerContainerDefinitionUnmarshaller _instance = new GameServerContainerDefinitionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GameServerContainerDefinitionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}