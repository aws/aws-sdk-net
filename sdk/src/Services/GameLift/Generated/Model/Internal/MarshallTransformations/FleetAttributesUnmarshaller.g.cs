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
    /// Response Unmarshaller for FleetAttributes Object
    /// </summary>
    public partial class FleetAttributesUnmarshaller : ICborUnmarshaller<FleetAttributes, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public FleetAttributes Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new FleetAttributes();
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
                    case "AnywhereConfiguration":
                        context.AddPathSegment("AnywhereConfiguration");
                        unmarshalledObject.AnywhereConfiguration = AnywhereConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "BuildArn":
                        context.AddPathSegment("BuildArn");
                        unmarshalledObject.BuildArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "BuildId":
                        context.AddPathSegment("BuildId");
                        unmarshalledObject.BuildId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CertificateConfiguration":
                        context.AddPathSegment("CertificateConfiguration");
                        unmarshalledObject.CertificateConfiguration = CertificateConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ComputeType":
                        context.AddPathSegment("ComputeType");
                        unmarshalledObject.ComputeType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CreationTime":
                        context.AddPathSegment("CreationTime");
                        unmarshalledObject.CreationTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Description":
                        context.AddPathSegment("Description");
                        unmarshalledObject.Description = CborStringUnmarshaller.Instance.Unmarshall(context);
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

                    case "FleetType":
                        context.AddPathSegment("FleetType");
                        unmarshalledObject.FleetType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "InstanceRoleArn":
                        context.AddPathSegment("InstanceRoleArn");
                        unmarshalledObject.InstanceRoleArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "InstanceRoleCredentialsProvider":
                        context.AddPathSegment("InstanceRoleCredentialsProvider");
                        unmarshalledObject.InstanceRoleCredentialsProvider = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "InstanceType":
                        context.AddPathSegment("InstanceType");
                        unmarshalledObject.InstanceType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LogPaths":
                        context.AddPathSegment("LogPaths");
                        unmarshalledObject.LogPaths = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "MetricGroups":
                        context.AddPathSegment("MetricGroups");
                        unmarshalledObject.MetricGroups = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Name":
                        context.AddPathSegment("Name");
                        unmarshalledObject.Name = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NewGameSessionProtectionPolicy":
                        context.AddPathSegment("NewGameSessionProtectionPolicy");
                        unmarshalledObject.NewGameSessionProtectionPolicy = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "OperatingSystem":
                        context.AddPathSegment("OperatingSystem");
                        unmarshalledObject.OperatingSystem = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PlayerGatewayConfiguration":
                        context.AddPathSegment("PlayerGatewayConfiguration");
                        unmarshalledObject.PlayerGatewayConfiguration = PlayerGatewayConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PlayerGatewayMode":
                        context.AddPathSegment("PlayerGatewayMode");
                        unmarshalledObject.PlayerGatewayMode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ResourceCreationLimitPolicy":
                        context.AddPathSegment("ResourceCreationLimitPolicy");
                        unmarshalledObject.ResourceCreationLimitPolicy = ResourceCreationLimitPolicyUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ScriptArn":
                        context.AddPathSegment("ScriptArn");
                        unmarshalledObject.ScriptArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ScriptId":
                        context.AddPathSegment("ScriptId");
                        unmarshalledObject.ScriptId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ServerLaunchParameters":
                        context.AddPathSegment("ServerLaunchParameters");
                        unmarshalledObject.ServerLaunchParameters = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ServerLaunchPath":
                        context.AddPathSegment("ServerLaunchPath");
                        unmarshalledObject.ServerLaunchPath = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Status":
                        context.AddPathSegment("Status");
                        unmarshalledObject.Status = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StoppedActions":
                        context.AddPathSegment("StoppedActions");
                        unmarshalledObject.StoppedActions = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TerminationTime":
                        context.AddPathSegment("TerminationTime");
                        unmarshalledObject.TerminationTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
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

        private static FleetAttributesUnmarshaller _instance = new FleetAttributesUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static FleetAttributesUnmarshaller Instance => _instance;
    }
}
