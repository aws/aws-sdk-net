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
    /// Response Unmarshaller for Compute Object
    /// </summary>  
    public class ComputeUnmarshaller : ICborUnmarshaller<Compute, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Compute Unmarshall(CborUnmarshallerContext context)
        {
            Compute unmarshalledObject = new Compute();
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
                    case "ComputeArn":
                        {
                            context.AddPathSegment("ComputeArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ComputeArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ComputeName":
                        {
                            context.AddPathSegment("ComputeName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ComputeName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ComputeStatus":
                        {
                            context.AddPathSegment("ComputeStatus");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ComputeStatus = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ContainerAttributes":
                        {
                            context.AddPathSegment("ContainerAttributes");
                            var unmarshaller = new CborListUnmarshaller<ContainerAttribute, ContainerAttributeUnmarshaller>(ContainerAttributeUnmarshaller.Instance);
                            unmarshalledObject.ContainerAttributes = unmarshaller.Unmarshall(context);
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
                    case "DnsName":
                        {
                            context.AddPathSegment("DnsName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.DnsName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "FleetArn":
                        {
                            context.AddPathSegment("FleetArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.FleetArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "FleetId":
                        {
                            context.AddPathSegment("FleetId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.FleetId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GameLiftAgentEndpoint":
                        {
                            context.AddPathSegment("GameLiftAgentEndpoint");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.GameLiftAgentEndpoint = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GameLiftServiceSdkEndpoint":
                        {
                            context.AddPathSegment("GameLiftServiceSdkEndpoint");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.GameLiftServiceSdkEndpoint = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GameServerContainerGroupDefinitionArn":
                        {
                            context.AddPathSegment("GameServerContainerGroupDefinitionArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.GameServerContainerGroupDefinitionArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "InstanceId":
                        {
                            context.AddPathSegment("InstanceId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.InstanceId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "IpAddress":
                        {
                            context.AddPathSegment("IpAddress");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.IpAddress = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Location":
                        {
                            context.AddPathSegment("Location");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Location = unmarshaller.Unmarshall(context);
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
                    case "Type":
                        {
                            context.AddPathSegment("Type");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Type = unmarshaller.Unmarshall(context);
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


        private static ComputeUnmarshaller _instance = new ComputeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ComputeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}