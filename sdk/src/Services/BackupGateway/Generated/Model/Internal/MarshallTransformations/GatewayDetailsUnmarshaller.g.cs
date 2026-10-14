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

using Amazon.BackupGateway.Model;
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
    public partial class GatewayDetailsUnmarshaller : ICborUnmarshaller<GatewayDetails, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public GatewayDetails Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new GatewayDetails();
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
                    case "DeprecationDate":
                        context.AddPathSegment("DeprecationDate");
                        unmarshalledObject.DeprecationDate = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "GatewayArn":
                        context.AddPathSegment("GatewayArn");
                        unmarshalledObject.GatewayArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "GatewayDisplayName":
                        context.AddPathSegment("GatewayDisplayName");
                        unmarshalledObject.GatewayDisplayName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "GatewayType":
                        context.AddPathSegment("GatewayType");
                        unmarshalledObject.GatewayType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "HypervisorId":
                        context.AddPathSegment("HypervisorId");
                        unmarshalledObject.HypervisorId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LastSeenTime":
                        context.AddPathSegment("LastSeenTime");
                        unmarshalledObject.LastSeenTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "MaintenanceStartTime":
                        context.AddPathSegment("MaintenanceStartTime");
                        unmarshalledObject.MaintenanceStartTime = MaintenanceStartTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NextUpdateAvailabilityTime":
                        context.AddPathSegment("NextUpdateAvailabilityTime");
                        unmarshalledObject.NextUpdateAvailabilityTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SoftwareVersion":
                        context.AddPathSegment("SoftwareVersion");
                        unmarshalledObject.SoftwareVersion = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "VpcEndpoint":
                        context.AddPathSegment("VpcEndpoint");
                        unmarshalledObject.VpcEndpoint = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static GatewayDetailsUnmarshaller _instance = new GatewayDetailsUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GatewayDetailsUnmarshaller Instance => _instance;
    }
}
