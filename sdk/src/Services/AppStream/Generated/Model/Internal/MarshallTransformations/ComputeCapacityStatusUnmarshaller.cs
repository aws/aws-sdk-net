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
    /// Response Unmarshaller for ComputeCapacityStatus Object
    /// </summary>  
    public class ComputeCapacityStatusUnmarshaller : ICborUnmarshaller<ComputeCapacityStatus, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ComputeCapacityStatus Unmarshall(CborUnmarshallerContext context)
        {
            ComputeCapacityStatus unmarshalledObject = new ComputeCapacityStatus();
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
                    case "ActiveUserSessions":
                        {
                            context.AddPathSegment("ActiveUserSessions");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.ActiveUserSessions = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ActualUserSessions":
                        {
                            context.AddPathSegment("ActualUserSessions");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.ActualUserSessions = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Available":
                        {
                            context.AddPathSegment("Available");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.Available = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "AvailableUserSessions":
                        {
                            context.AddPathSegment("AvailableUserSessions");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.AvailableUserSessions = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Desired":
                        {
                            context.AddPathSegment("Desired");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.Desired = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DesiredUserSessions":
                        {
                            context.AddPathSegment("DesiredUserSessions");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.DesiredUserSessions = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Draining":
                        {
                            context.AddPathSegment("Draining");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.Draining = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DrainModeActiveUserSessions":
                        {
                            context.AddPathSegment("DrainModeActiveUserSessions");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.DrainModeActiveUserSessions = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DrainModeUnusedUserSessions":
                        {
                            context.AddPathSegment("DrainModeUnusedUserSessions");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.DrainModeUnusedUserSessions = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "InUse":
                        {
                            context.AddPathSegment("InUse");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.InUse = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Running":
                        {
                            context.AddPathSegment("Running");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.Running = unmarshaller.Unmarshall(context);
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


        private static ComputeCapacityStatusUnmarshaller _instance = new ComputeCapacityStatusUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ComputeCapacityStatusUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}