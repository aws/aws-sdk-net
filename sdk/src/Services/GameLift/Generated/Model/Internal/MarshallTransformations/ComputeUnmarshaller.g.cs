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
    /// Response Unmarshaller for Compute Object
    /// </summary>
    public partial class ComputeUnmarshaller : ICborUnmarshaller<Compute, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Compute Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new Compute();
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
                    case "ComputeArn":
                        context.AddPathSegment("ComputeArn");
                        unmarshalledObject.ComputeArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ComputeName":
                        context.AddPathSegment("ComputeName");
                        unmarshalledObject.ComputeName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ComputeStatus":
                        context.AddPathSegment("ComputeStatus");
                        unmarshalledObject.ComputeStatus = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ContainerAttributes":
                        context.AddPathSegment("ContainerAttributes");
                        unmarshalledObject.ContainerAttributes = new CborListUnmarshaller<ContainerAttribute, ContainerAttributeUnmarshaller>(ContainerAttributeUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CreationTime":
                        context.AddPathSegment("CreationTime");
                        unmarshalledObject.CreationTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DnsName":
                        context.AddPathSegment("DnsName");
                        unmarshalledObject.DnsName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FleetArn":
                        context.AddPathSegment("FleetArn");
                        unmarshalledObject.FleetArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FleetId":
                        context.AddPathSegment("FleetId");
                        unmarshalledObject.FleetId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "GameLiftAgentEndpoint":
                        context.AddPathSegment("GameLiftAgentEndpoint");
                        unmarshalledObject.GameLiftAgentEndpoint = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "GameLiftServiceSdkEndpoint":
                        context.AddPathSegment("GameLiftServiceSdkEndpoint");
                        unmarshalledObject.GameLiftServiceSdkEndpoint = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "GameServerContainerGroupDefinitionArn":
                        context.AddPathSegment("GameServerContainerGroupDefinitionArn");
                        unmarshalledObject.GameServerContainerGroupDefinitionArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "InstanceId":
                        context.AddPathSegment("InstanceId");
                        unmarshalledObject.InstanceId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "IpAddress":
                        context.AddPathSegment("IpAddress");
                        unmarshalledObject.IpAddress = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Location":
                        context.AddPathSegment("Location");
                        unmarshalledObject.Location = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "OperatingSystem":
                        context.AddPathSegment("OperatingSystem");
                        unmarshalledObject.OperatingSystem = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Type":
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

        private static ComputeUnmarshaller _instance = new ComputeUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ComputeUnmarshaller Instance => _instance;
    }
}
