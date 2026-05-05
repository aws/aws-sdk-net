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
    /// Response Unmarshaller for FleetAttributes Object
    /// </summary>  
    public class FleetAttributesUnmarshaller : ICborUnmarshaller<FleetAttributes, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public FleetAttributes Unmarshall(CborUnmarshallerContext context)
        {
            FleetAttributes unmarshalledObject = new FleetAttributes();
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
                    case "AnywhereConfiguration":
                        {
                            context.AddPathSegment("AnywhereConfiguration");
                            var unmarshaller = AnywhereConfigurationUnmarshaller.Instance;
                            unmarshalledObject.AnywhereConfiguration = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "BuildArn":
                        {
                            context.AddPathSegment("BuildArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.BuildArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "BuildId":
                        {
                            context.AddPathSegment("BuildId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.BuildId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CertificateConfiguration":
                        {
                            context.AddPathSegment("CertificateConfiguration");
                            var unmarshaller = CertificateConfigurationUnmarshaller.Instance;
                            unmarshalledObject.CertificateConfiguration = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ComputeType":
                        {
                            context.AddPathSegment("ComputeType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ComputeType = unmarshaller.Unmarshall(context);
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
                    case "Description":
                        {
                            context.AddPathSegment("Description");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Description = unmarshaller.Unmarshall(context);
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
                    case "FleetType":
                        {
                            context.AddPathSegment("FleetType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.FleetType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "InstanceRoleArn":
                        {
                            context.AddPathSegment("InstanceRoleArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.InstanceRoleArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "InstanceRoleCredentialsProvider":
                        {
                            context.AddPathSegment("InstanceRoleCredentialsProvider");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.InstanceRoleCredentialsProvider = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "InstanceType":
                        {
                            context.AddPathSegment("InstanceType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LogPaths":
                        {
                            context.AddPathSegment("LogPaths");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.LogPaths = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "MetricGroups":
                        {
                            context.AddPathSegment("MetricGroups");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.MetricGroups = unmarshaller.Unmarshall(context);
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
                    case "NewGameSessionProtectionPolicy":
                        {
                            context.AddPathSegment("NewGameSessionProtectionPolicy");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.NewGameSessionProtectionPolicy = unmarshaller.Unmarshall(context);
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
                    case "PlayerGatewayConfiguration":
                        {
                            context.AddPathSegment("PlayerGatewayConfiguration");
                            var unmarshaller = PlayerGatewayConfigurationUnmarshaller.Instance;
                            unmarshalledObject.PlayerGatewayConfiguration = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PlayerGatewayMode":
                        {
                            context.AddPathSegment("PlayerGatewayMode");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PlayerGatewayMode = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ResourceCreationLimitPolicy":
                        {
                            context.AddPathSegment("ResourceCreationLimitPolicy");
                            var unmarshaller = ResourceCreationLimitPolicyUnmarshaller.Instance;
                            unmarshalledObject.ResourceCreationLimitPolicy = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ScriptArn":
                        {
                            context.AddPathSegment("ScriptArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ScriptArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ScriptId":
                        {
                            context.AddPathSegment("ScriptId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ScriptId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ServerLaunchParameters":
                        {
                            context.AddPathSegment("ServerLaunchParameters");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ServerLaunchParameters = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ServerLaunchPath":
                        {
                            context.AddPathSegment("ServerLaunchPath");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ServerLaunchPath = unmarshaller.Unmarshall(context);
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
                    case "StoppedActions":
                        {
                            context.AddPathSegment("StoppedActions");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.StoppedActions = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "TerminationTime":
                        {
                            context.AddPathSegment("TerminationTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.TerminationTime = unmarshaller.Unmarshall(context);
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


        private static FleetAttributesUnmarshaller _instance = new FleetAttributesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FleetAttributesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}