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
    /// Response Unmarshaller for LogStream Object
    /// </summary>  
    public class LogStreamUnmarshaller : ICborUnmarshaller<LogStream, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public LogStream Unmarshall(CborUnmarshallerContext context)
        {
            LogStream unmarshalledObject = new LogStream();
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
                    case "arn":
                        {
                            context.AddPathSegment("Arn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "creationTime":
                        {
                            context.AddPathSegment("CreationTime");
                            var unmarshaller = CborNullableDateTimeEpochLongMillisecondsUnmarshaller.Instance;
                            unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "firstEventTimestamp":
                        {
                            context.AddPathSegment("FirstEventTimestamp");
                            var unmarshaller = CborNullableDateTimeEpochLongMillisecondsUnmarshaller.Instance;
                            unmarshalledObject.FirstEventTimestamp = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "lastEventTimestamp":
                        {
                            context.AddPathSegment("LastEventTimestamp");
                            var unmarshaller = CborNullableDateTimeEpochLongMillisecondsUnmarshaller.Instance;
                            unmarshalledObject.LastEventTimestamp = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "lastIngestionTime":
                        {
                            context.AddPathSegment("LastIngestionTime");
                            var unmarshaller = CborNullableDateTimeEpochLongMillisecondsUnmarshaller.Instance;
                            unmarshalledObject.LastIngestionTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "logStreamName":
                        {
                            context.AddPathSegment("LogStreamName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.LogStreamName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "storedBytes":
                        {
                            context.AddPathSegment("StoredBytes");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            unmarshalledObject.StoredBytes = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "uploadSequenceToken":
                        {
                            context.AddPathSegment("UploadSequenceToken");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.UploadSequenceToken = unmarshaller.Unmarshall(context);
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


        private static LogStreamUnmarshaller _instance = new LogStreamUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LogStreamUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}