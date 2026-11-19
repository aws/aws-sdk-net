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

using Amazon.WorkSpaces.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.WorkSpaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for WorkspaceAccessProperties Object
    /// </summary>
    public partial class WorkspaceAccessPropertiesUnmarshaller : ICborUnmarshaller<WorkspaceAccessProperties, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public WorkspaceAccessProperties Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new WorkspaceAccessProperties();
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
                    case "AccessEndpointConfig":
                        context.AddPathSegment("AccessEndpointConfig");
                        unmarshalledObject.AccessEndpointConfig = AccessEndpointConfigUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DeviceTypeAndroid":
                        context.AddPathSegment("DeviceTypeAndroid");
                        unmarshalledObject.DeviceTypeAndroid = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DeviceTypeChromeOs":
                        context.AddPathSegment("DeviceTypeChromeOs");
                        unmarshalledObject.DeviceTypeChromeOs = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DeviceTypeIos":
                        context.AddPathSegment("DeviceTypeIos");
                        unmarshalledObject.DeviceTypeIos = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DeviceTypeLinux":
                        context.AddPathSegment("DeviceTypeLinux");
                        unmarshalledObject.DeviceTypeLinux = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DeviceTypeOsx":
                        context.AddPathSegment("DeviceTypeOsx");
                        unmarshalledObject.DeviceTypeOsx = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DeviceTypeWeb":
                        context.AddPathSegment("DeviceTypeWeb");
                        unmarshalledObject.DeviceTypeWeb = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DeviceTypeWindows":
                        context.AddPathSegment("DeviceTypeWindows");
                        unmarshalledObject.DeviceTypeWindows = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DeviceTypeWorkSpacesThinClient":
                        context.AddPathSegment("DeviceTypeWorkSpacesThinClient");
                        unmarshalledObject.DeviceTypeWorkSpacesThinClient = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DeviceTypeZeroClient":
                        context.AddPathSegment("DeviceTypeZeroClient");
                        unmarshalledObject.DeviceTypeZeroClient = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static WorkspaceAccessPropertiesUnmarshaller _instance = new WorkspaceAccessPropertiesUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static WorkspaceAccessPropertiesUnmarshaller Instance => _instance;
    }
}
