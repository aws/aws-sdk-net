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

using Amazon.GameLift.Model;
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
    public partial class ContainerGroupDefinitionUnmarshaller : ICborUnmarshaller<ContainerGroupDefinition, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ContainerGroupDefinition Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new ContainerGroupDefinition();
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
                    case "ContainerGroupDefinitionArn":
                        context.AddPathSegment("ContainerGroupDefinitionArn");
                        unmarshalledObject.ContainerGroupDefinitionArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ContainerGroupType":
                        context.AddPathSegment("ContainerGroupType");
                        unmarshalledObject.ContainerGroupType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CreationTime":
                        context.AddPathSegment("CreationTime");
                        unmarshalledObject.CreationTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "GameServerContainerDefinition":
                        context.AddPathSegment("GameServerContainerDefinition");
                        unmarshalledObject.GameServerContainerDefinition = GameServerContainerDefinitionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Name":
                        context.AddPathSegment("Name");
                        unmarshalledObject.Name = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "OperatingSystem":
                        context.AddPathSegment("OperatingSystem");
                        unmarshalledObject.OperatingSystem = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Status":
                        context.AddPathSegment("Status");
                        unmarshalledObject.Status = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StatusReason":
                        context.AddPathSegment("StatusReason");
                        unmarshalledObject.StatusReason = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SupportContainerDefinitions":
                        context.AddPathSegment("SupportContainerDefinitions");
                        unmarshalledObject.SupportContainerDefinitions = new CborListUnmarshaller<SupportContainerDefinition, SupportContainerDefinitionUnmarshaller>(SupportContainerDefinitionUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TotalMemoryLimitMebibytes":
                        context.AddPathSegment("TotalMemoryLimitMebibytes");
                        unmarshalledObject.TotalMemoryLimitMebibytes = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TotalVcpuLimit":
                        context.AddPathSegment("TotalVcpuLimit");
                        unmarshalledObject.TotalVcpuLimit = CborNullableDoubleUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "VersionDescription":
                        context.AddPathSegment("VersionDescription");
                        unmarshalledObject.VersionDescription = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "VersionNumber":
                        context.AddPathSegment("VersionNumber");
                        unmarshalledObject.VersionNumber = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
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

        private static ContainerGroupDefinitionUnmarshaller _instance = new ContainerGroupDefinitionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ContainerGroupDefinitionUnmarshaller Instance => _instance;
    }
}
