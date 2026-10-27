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

using Amazon.AppStream.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Fleet Object
    /// </summary>
    public partial class FleetUnmarshaller : ICborUnmarshaller<Fleet, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Fleet Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new Fleet();
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
                    case "Arn":
                        context.AddPathSegment("Arn");
                        unmarshalledObject.Arn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ComputeCapacityStatus":
                        context.AddPathSegment("ComputeCapacityStatus");
                        unmarshalledObject.ComputeCapacityStatus = ComputeCapacityStatusUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CreatedTime":
                        context.AddPathSegment("CreatedTime");
                        unmarshalledObject.CreatedTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Description":
                        context.AddPathSegment("Description");
                        unmarshalledObject.Description = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DisableIMDSV1":
                        context.AddPathSegment("DisableIMDSV1");
                        unmarshalledObject.DisableIMDSV1 = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DisconnectTimeoutInSeconds":
                        context.AddPathSegment("DisconnectTimeoutInSeconds");
                        unmarshalledObject.DisconnectTimeoutInSeconds = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DisplayName":
                        context.AddPathSegment("DisplayName");
                        unmarshalledObject.DisplayName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DomainJoinInfo":
                        context.AddPathSegment("DomainJoinInfo");
                        unmarshalledObject.DomainJoinInfo = DomainJoinInfoUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EnableDefaultInternetAccess":
                        context.AddPathSegment("EnableDefaultInternetAccess");
                        unmarshalledObject.EnableDefaultInternetAccess = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FleetErrors":
                        context.AddPathSegment("FleetErrors");
                        unmarshalledObject.FleetErrors = new CborListUnmarshaller<FleetError, FleetErrorUnmarshaller>(FleetErrorUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FleetType":
                        context.AddPathSegment("FleetType");
                        unmarshalledObject.FleetType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "IamRoleArn":
                        context.AddPathSegment("IamRoleArn");
                        unmarshalledObject.IamRoleArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "IdleDisconnectTimeoutInSeconds":
                        context.AddPathSegment("IdleDisconnectTimeoutInSeconds");
                        unmarshalledObject.IdleDisconnectTimeoutInSeconds = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ImageArn":
                        context.AddPathSegment("ImageArn");
                        unmarshalledObject.ImageArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ImageName":
                        context.AddPathSegment("ImageName");
                        unmarshalledObject.ImageName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "InstanceType":
                        context.AddPathSegment("InstanceType");
                        unmarshalledObject.InstanceType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "MaxConcurrentSessions":
                        context.AddPathSegment("MaxConcurrentSessions");
                        unmarshalledObject.MaxConcurrentSessions = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "MaxSessionsPerInstance":
                        context.AddPathSegment("MaxSessionsPerInstance");
                        unmarshalledObject.MaxSessionsPerInstance = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "MaxUserDurationInSeconds":
                        context.AddPathSegment("MaxUserDurationInSeconds");
                        unmarshalledObject.MaxUserDurationInSeconds = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Name":
                        context.AddPathSegment("Name");
                        unmarshalledObject.Name = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Platform":
                        context.AddPathSegment("Platform");
                        unmarshalledObject.Platform = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RootVolumeConfig":
                        context.AddPathSegment("RootVolumeConfig");
                        unmarshalledObject.RootVolumeConfig = VolumeConfigUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SessionScriptS3Location":
                        context.AddPathSegment("SessionScriptS3Location");
                        unmarshalledObject.SessionScriptS3Location = S3LocationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "State":
                        context.AddPathSegment("State");
                        unmarshalledObject.State = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StreamView":
                        context.AddPathSegment("StreamView");
                        unmarshalledObject.StreamView = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "UsbDeviceFilterStrings":
                        context.AddPathSegment("UsbDeviceFilterStrings");
                        unmarshalledObject.UsbDeviceFilterStrings = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "VpcConfig":
                        context.AddPathSegment("VpcConfig");
                        unmarshalledObject.VpcConfig = VpcConfigUnmarshaller.Instance.Unmarshall(context);
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

        private static FleetUnmarshaller _instance = new FleetUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static FleetUnmarshaller Instance => _instance;
    }
}
