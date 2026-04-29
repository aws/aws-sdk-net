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
    /// Response Unmarshaller for FleetUtilization Object
    /// </summary>  
    public class FleetUtilizationUnmarshaller : ICborUnmarshaller<FleetUtilization, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public FleetUtilization Unmarshall(CborUnmarshallerContext context)
        {
            FleetUtilization unmarshalledObject = new FleetUtilization();
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
                    case "ActiveGameSessionCount":
                        {
                            context.AddPathSegment("ActiveGameSessionCount");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.ActiveGameSessionCount = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ActiveServerProcessCount":
                        {
                            context.AddPathSegment("ActiveServerProcessCount");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.ActiveServerProcessCount = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CurrentPlayerSessionCount":
                        {
                            context.AddPathSegment("CurrentPlayerSessionCount");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.CurrentPlayerSessionCount = unmarshaller.Unmarshall(context);
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
                    case "Location":
                        {
                            context.AddPathSegment("Location");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Location = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "MaximumPlayerSessionCount":
                        {
                            context.AddPathSegment("MaximumPlayerSessionCount");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.MaximumPlayerSessionCount = unmarshaller.Unmarshall(context);
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


        private static FleetUtilizationUnmarshaller _instance = new FleetUtilizationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FleetUtilizationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}