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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppStream.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
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
    public class FleetUnmarshaller : ICborUnmarshaller<Fleet, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Fleet Unmarshall(CborUnmarshallerContext context)
        {
            Fleet unmarshalledObject = new Fleet();
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
                    case "Arn":
                        {
                            context.AddPathSegment("Arn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ComputeCapacityStatus":
                        {
                            context.AddPathSegment("ComputeCapacityStatus");
                            var unmarshaller = ComputeCapacityStatusUnmarshaller.Instance;
                            unmarshalledObject.ComputeCapacityStatus = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CreatedTime":
                        {
                            context.AddPathSegment("CreatedTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.CreatedTime = unmarshaller.Unmarshall(context);
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
                    case "DisableIMDSV1":
                        {
                            context.AddPathSegment("DisableIMDSV1");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.DisableIMDSV1 = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DisconnectTimeoutInSeconds":
                        {
                            context.AddPathSegment("DisconnectTimeoutInSeconds");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.DisconnectTimeoutInSeconds = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DisplayName":
                        {
                            context.AddPathSegment("DisplayName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.DisplayName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DomainJoinInfo":
                        {
                            context.AddPathSegment("DomainJoinInfo");
                            var unmarshaller = DomainJoinInfoUnmarshaller.Instance;
                            unmarshalledObject.DomainJoinInfo = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EnableDefaultInternetAccess":
                        {
                            context.AddPathSegment("EnableDefaultInternetAccess");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.EnableDefaultInternetAccess = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "FleetErrors":
                        {
                            context.AddPathSegment("FleetErrors");
                            var unmarshaller = new CborListUnmarshaller<FleetError, FleetErrorUnmarshaller>(FleetErrorUnmarshaller.Instance);
                            unmarshalledObject.FleetErrors = unmarshaller.Unmarshall(context);
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
                    case "IamRoleArn":
                        {
                            context.AddPathSegment("IamRoleArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.IamRoleArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "IdleDisconnectTimeoutInSeconds":
                        {
                            context.AddPathSegment("IdleDisconnectTimeoutInSeconds");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.IdleDisconnectTimeoutInSeconds = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ImageArn":
                        {
                            context.AddPathSegment("ImageArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ImageArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ImageName":
                        {
                            context.AddPathSegment("ImageName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ImageName = unmarshaller.Unmarshall(context);
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
                    case "MaxConcurrentSessions":
                        {
                            context.AddPathSegment("MaxConcurrentSessions");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.MaxConcurrentSessions = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "MaxSessionsPerInstance":
                        {
                            context.AddPathSegment("MaxSessionsPerInstance");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.MaxSessionsPerInstance = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "MaxUserDurationInSeconds":
                        {
                            context.AddPathSegment("MaxUserDurationInSeconds");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.MaxUserDurationInSeconds = unmarshaller.Unmarshall(context);
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
                    case "Platform":
                        {
                            context.AddPathSegment("Platform");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Platform = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "RootVolumeConfig":
                        {
                            context.AddPathSegment("RootVolumeConfig");
                            var unmarshaller = VolumeConfigUnmarshaller.Instance;
                            unmarshalledObject.RootVolumeConfig = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SessionScriptS3Location":
                        {
                            context.AddPathSegment("SessionScriptS3Location");
                            var unmarshaller = S3LocationUnmarshaller.Instance;
                            unmarshalledObject.SessionScriptS3Location = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "State":
                        {
                            context.AddPathSegment("State");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.State = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StreamView":
                        {
                            context.AddPathSegment("StreamView");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.StreamView = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "UsbDeviceFilterStrings":
                        {
                            context.AddPathSegment("UsbDeviceFilterStrings");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.UsbDeviceFilterStrings = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "VpcConfig":
                        {
                            context.AddPathSegment("VpcConfig");
                            var unmarshaller = VpcConfigUnmarshaller.Instance;
                            unmarshalledObject.VpcConfig = unmarshaller.Unmarshall(context);
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


        private static FleetUnmarshaller _instance = new FleetUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FleetUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}