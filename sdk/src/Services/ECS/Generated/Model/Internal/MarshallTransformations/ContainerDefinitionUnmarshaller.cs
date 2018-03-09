/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ContainerDefinition Object
    /// </summary>  
    public class ContainerDefinitionUnmarshaller : IUnmarshaller<ContainerDefinition, XmlUnmarshallerContext>, IUnmarshaller<ContainerDefinition, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ContainerDefinition IUnmarshaller<ContainerDefinition, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ContainerDefinition Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ContainerDefinition unmarshalledObject = new ContainerDefinition();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("command", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Command = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("cpu", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Cpu = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("disableNetworking", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DisableNetworking = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dnsSearchDomains", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.DnsSearchDomains = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dnsServers", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.DnsServers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dockerLabels", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.DockerLabels = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dockerSecurityOptions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.DockerSecurityOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("entryPoint", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.EntryPoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("environment", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<KeyValuePair, KeyValuePairUnmarshaller>(KeyValuePairUnmarshaller.Instance);
                    unmarshalledObject.Environment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("essential", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Essential = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("extraHosts", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<HostEntry, HostEntryUnmarshaller>(HostEntryUnmarshaller.Instance);
                    unmarshalledObject.ExtraHosts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("healthCheck", targetDepth))
                {
                    var unmarshaller = HealthCheckUnmarshaller.Instance;
                    unmarshalledObject.HealthCheck = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("hostname", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Hostname = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("image", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Image = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("links", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Links = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("linuxParameters", targetDepth))
                {
                    var unmarshaller = LinuxParametersUnmarshaller.Instance;
                    unmarshalledObject.LinuxParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("logConfiguration", targetDepth))
                {
                    var unmarshaller = LogConfigurationUnmarshaller.Instance;
                    unmarshalledObject.LogConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("memory", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Memory = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("memoryReservation", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MemoryReservation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mountPoints", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MountPoint, MountPointUnmarshaller>(MountPointUnmarshaller.Instance);
                    unmarshalledObject.MountPoints = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("portMappings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PortMapping, PortMappingUnmarshaller>(PortMappingUnmarshaller.Instance);
                    unmarshalledObject.PortMappings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("privileged", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Privileged = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("readonlyRootFilesystem", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ReadonlyRootFilesystem = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ulimits", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Ulimit, UlimitUnmarshaller>(UlimitUnmarshaller.Instance);
                    unmarshalledObject.Ulimits = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("user", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.User = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("volumesFrom", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<VolumeFrom, VolumeFromUnmarshaller>(VolumeFromUnmarshaller.Instance);
                    unmarshalledObject.VolumesFrom = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("workingDirectory", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WorkingDirectory = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ContainerDefinitionUnmarshaller _instance = new ContainerDefinitionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ContainerDefinitionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}