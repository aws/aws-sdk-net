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
    /// Response Unmarshaller for EC2InstanceCounts Object
    /// </summary>  
    public class EC2InstanceCountsUnmarshaller : ICborUnmarshaller<EC2InstanceCounts, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public EC2InstanceCounts Unmarshall(CborUnmarshallerContext context)
        {
            EC2InstanceCounts unmarshalledObject = new EC2InstanceCounts();
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
                    case "ACTIVE":
                        {
                            context.AddPathSegment("ACTIVE");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.ACTIVE = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DESIRED":
                        {
                            context.AddPathSegment("DESIRED");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.DESIRED = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "IDLE":
                        {
                            context.AddPathSegment("IDLE");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.IDLE = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "MAXIMUM":
                        {
                            context.AddPathSegment("MAXIMUM");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.MAXIMUM = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "MINIMUM":
                        {
                            context.AddPathSegment("MINIMUM");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.MINIMUM = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PENDING":
                        {
                            context.AddPathSegment("PENDING");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.PENDING = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "TERMINATING":
                        {
                            context.AddPathSegment("TERMINATING");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.TERMINATING = unmarshaller.Unmarshall(context);
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


        private static EC2InstanceCountsUnmarshaller _instance = new EC2InstanceCountsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EC2InstanceCountsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}