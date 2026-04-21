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
    /// Response Unmarshaller for ContainerGroupDefinition Object
    /// </summary>  
    public class ContainerGroupDefinitionUnmarshaller : ICborUnmarshaller<ContainerGroupDefinition, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ContainerGroupDefinition Unmarshall(CborUnmarshallerContext context)
        {
            ContainerGroupDefinition unmarshalledObject = new ContainerGroupDefinition();
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
                    case "ContainerGroupDefinitionArn":
                        {
                            context.AddPathSegment("ContainerGroupDefinitionArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ContainerGroupDefinitionArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ContainerGroupType":
                        {
                            context.AddPathSegment("ContainerGroupType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ContainerGroupType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CreationTime":
                        {
                            context.AddPathSegment("CreationTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GameServerContainerDefinition":
                        {
                            context.AddPathSegment("GameServerContainerDefinition");
                            var unmarshaller = GameServerContainerDefinitionUnmarshaller.Instance;
                            unmarshalledObject.GameServerContainerDefinition = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Name":
                        {
                            context.AddPathSegment("Name");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "OperatingSystem":
                        {
                            context.AddPathSegment("OperatingSystem");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.OperatingSystem = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Status":
                        {
                            context.AddPathSegment("Status");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StatusReason":
                        {
                            context.AddPathSegment("StatusReason");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.StatusReason = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SupportContainerDefinitions":
                        {
                            context.AddPathSegment("SupportContainerDefinitions");
                            var unmarshaller = new CborListUnmarshaller<SupportContainerDefinition, SupportContainerDefinitionUnmarshaller>(SupportContainerDefinitionUnmarshaller.Instance);
                            unmarshalledObject.SupportContainerDefinitions = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "TotalMemoryLimitMebibytes":
                        {
                            context.AddPathSegment("TotalMemoryLimitMebibytes");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.TotalMemoryLimitMebibytes = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "TotalVcpuLimit":
                        {
                            context.AddPathSegment("TotalVcpuLimit");
                            var unmarshaller = CborNullableDoubleUnmarshaller.Instance;
                            unmarshalledObject.TotalVcpuLimit = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "VersionDescription":
                        {
                            context.AddPathSegment("VersionDescription");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.VersionDescription = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "VersionNumber":
                        {
                            context.AddPathSegment("VersionNumber");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.VersionNumber = unmarshaller.Unmarshall(context);
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


        private static ContainerGroupDefinitionUnmarshaller _instance = new ContainerGroupDefinitionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ContainerGroupDefinitionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}