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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchLogs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FieldIndex Object
    /// </summary>  
    public class FieldIndexUnmarshaller : ICborUnmarshaller<FieldIndex, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public FieldIndex Unmarshall(CborUnmarshallerContext context)
        {
            FieldIndex unmarshalledObject = new FieldIndex();
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
                    case "fieldIndexName":
                        {
                            context.AddPathSegment("FieldIndexName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.FieldIndexName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "firstEventTime":
                        {
                            context.AddPathSegment("FirstEventTime");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            unmarshalledObject.FirstEventTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "lastEventTime":
                        {
                            context.AddPathSegment("LastEventTime");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            unmarshalledObject.LastEventTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "lastScanTime":
                        {
                            context.AddPathSegment("LastScanTime");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            unmarshalledObject.LastScanTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "logGroupIdentifier":
                        {
                            context.AddPathSegment("LogGroupIdentifier");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.LogGroupIdentifier = unmarshaller.Unmarshall(context);
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


        private static FieldIndexUnmarshaller _instance = new FieldIndexUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FieldIndexUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}