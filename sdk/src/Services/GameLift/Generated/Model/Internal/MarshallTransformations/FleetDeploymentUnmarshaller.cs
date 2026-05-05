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
    /// Response Unmarshaller for FleetDeployment Object
    /// </summary>  
    public class FleetDeploymentUnmarshaller : ICborUnmarshaller<FleetDeployment, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public FleetDeployment Unmarshall(CborUnmarshallerContext context)
        {
            FleetDeployment unmarshalledObject = new FleetDeployment();
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
                    case "CreationTime":
                        {
                            context.AddPathSegment("CreationTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DeploymentConfiguration":
                        {
                            context.AddPathSegment("DeploymentConfiguration");
                            var unmarshaller = DeploymentConfigurationUnmarshaller.Instance;
                            unmarshalledObject.DeploymentConfiguration = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DeploymentId":
                        {
                            context.AddPathSegment("DeploymentId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.DeploymentId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DeploymentStatus":
                        {
                            context.AddPathSegment("DeploymentStatus");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.DeploymentStatus = unmarshaller.Unmarshall(context);
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
                    case "GameServerBinaryArn":
                        {
                            context.AddPathSegment("GameServerBinaryArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.GameServerBinaryArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PerInstanceBinaryArn":
                        {
                            context.AddPathSegment("PerInstanceBinaryArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PerInstanceBinaryArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "RollbackGameServerBinaryArn":
                        {
                            context.AddPathSegment("RollbackGameServerBinaryArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.RollbackGameServerBinaryArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "RollbackPerInstanceBinaryArn":
                        {
                            context.AddPathSegment("RollbackPerInstanceBinaryArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.RollbackPerInstanceBinaryArn = unmarshaller.Unmarshall(context);
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


        private static FleetDeploymentUnmarshaller _instance = new FleetDeploymentUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FleetDeploymentUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}