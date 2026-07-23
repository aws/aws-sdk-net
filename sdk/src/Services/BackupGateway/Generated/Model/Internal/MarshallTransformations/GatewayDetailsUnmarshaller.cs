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
 * Do not modify this file. This file is generated from the backup-gateway-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.BackupGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.BackupGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GatewayDetails Object
    /// </summary>  
    public class GatewayDetailsUnmarshaller : ICborUnmarshaller<GatewayDetails, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public GatewayDetails Unmarshall(CborUnmarshallerContext context)
        {
            GatewayDetails unmarshalledObject = new GatewayDetails();
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
                    case "DeprecationDate":
                        {
                            context.AddPathSegment("DeprecationDate");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.DeprecationDate = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GatewayArn":
                        {
                            context.AddPathSegment("GatewayArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.GatewayArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GatewayDisplayName":
                        {
                            context.AddPathSegment("GatewayDisplayName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.GatewayDisplayName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GatewayType":
                        {
                            context.AddPathSegment("GatewayType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.GatewayType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "HypervisorId":
                        {
                            context.AddPathSegment("HypervisorId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.HypervisorId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LastSeenTime":
                        {
                            context.AddPathSegment("LastSeenTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.LastSeenTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "MaintenanceStartTime":
                        {
                            context.AddPathSegment("MaintenanceStartTime");
                            var unmarshaller = MaintenanceStartTimeUnmarshaller.Instance;
                            unmarshalledObject.MaintenanceStartTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "NextUpdateAvailabilityTime":
                        {
                            context.AddPathSegment("NextUpdateAvailabilityTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.NextUpdateAvailabilityTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SoftwareVersion":
                        {
                            context.AddPathSegment("SoftwareVersion");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SoftwareVersion = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "VpcEndpoint":
                        {
                            context.AddPathSegment("VpcEndpoint");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.VpcEndpoint = unmarshaller.Unmarshall(context);
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


        private static GatewayDetailsUnmarshaller _instance = new GatewayDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GatewayDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}