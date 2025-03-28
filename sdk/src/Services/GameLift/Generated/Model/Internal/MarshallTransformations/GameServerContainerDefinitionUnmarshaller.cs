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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GameServerContainerDefinition Object
    /// </summary>  
    public class GameServerContainerDefinitionUnmarshaller : IUnmarshaller<GameServerContainerDefinition, XmlUnmarshallerContext>, IUnmarshaller<GameServerContainerDefinition, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        GameServerContainerDefinition IUnmarshaller<GameServerContainerDefinition, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public GameServerContainerDefinition Unmarshall(JsonUnmarshallerContext context)
        {
            GameServerContainerDefinition unmarshalledObject = new GameServerContainerDefinition();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ContainerName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ContainerName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DependsOn", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ContainerDependency, ContainerDependencyUnmarshaller>(ContainerDependencyUnmarshaller.Instance);
                    unmarshalledObject.DependsOn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnvironmentOverride", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ContainerEnvironment, ContainerEnvironmentUnmarshaller>(ContainerEnvironmentUnmarshaller.Instance);
                    unmarshalledObject.EnvironmentOverride = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ImageUri", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImageUri = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MountPoints", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ContainerMountPoint, ContainerMountPointUnmarshaller>(ContainerMountPointUnmarshaller.Instance);
                    unmarshalledObject.MountPoints = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PortConfiguration", targetDepth))
                {
                    var unmarshaller = ContainerPortConfigurationUnmarshaller.Instance;
                    unmarshalledObject.PortConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResolvedImageDigest", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResolvedImageDigest = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServerSdkVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServerSdkVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
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