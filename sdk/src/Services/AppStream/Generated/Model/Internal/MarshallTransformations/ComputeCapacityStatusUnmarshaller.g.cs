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
    /// Response Unmarshaller for ComputeCapacityStatus Object
    /// </summary>
    public partial class ComputeCapacityStatusUnmarshaller : ICborUnmarshaller<ComputeCapacityStatus, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ComputeCapacityStatus Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new ComputeCapacityStatus();
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
                    case "ActiveUserSessions":
                        context.AddPathSegment("ActiveUserSessions");
                        unmarshalledObject.ActiveUserSessions = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ActualUserSessions":
                        context.AddPathSegment("ActualUserSessions");
                        unmarshalledObject.ActualUserSessions = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Available":
                        context.AddPathSegment("Available");
                        unmarshalledObject.Available = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AvailableUserSessions":
                        context.AddPathSegment("AvailableUserSessions");
                        unmarshalledObject.AvailableUserSessions = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Desired":
                        context.AddPathSegment("Desired");
                        unmarshalledObject.Desired = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DesiredUserSessions":
                        context.AddPathSegment("DesiredUserSessions");
                        unmarshalledObject.DesiredUserSessions = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DrainModeActiveUserSessions":
                        context.AddPathSegment("DrainModeActiveUserSessions");
                        unmarshalledObject.DrainModeActiveUserSessions = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DrainModeUnusedUserSessions":
                        context.AddPathSegment("DrainModeUnusedUserSessions");
                        unmarshalledObject.DrainModeUnusedUserSessions = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Draining":
                        context.AddPathSegment("Draining");
                        unmarshalledObject.Draining = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "InUse":
                        context.AddPathSegment("InUse");
                        unmarshalledObject.InUse = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Running":
                        context.AddPathSegment("Running");
                        unmarshalledObject.Running = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
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

        private static ComputeCapacityStatusUnmarshaller _instance = new ComputeCapacityStatusUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ComputeCapacityStatusUnmarshaller Instance => _instance;
    }
}
