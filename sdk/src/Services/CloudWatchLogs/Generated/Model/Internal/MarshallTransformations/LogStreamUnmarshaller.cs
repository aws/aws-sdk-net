/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using ThirdParty.Json.LitJson;

namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LogStream Object
    /// </summary>  
    public class LogStreamUnmarshaller : IUnmarshaller<LogStream, XmlUnmarshallerContext>, IUnmarshaller<LogStream, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        LogStream IUnmarshaller<LogStream, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public LogStream Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            LogStream unmarshalledObject = new LogStream();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("creationTime", targetDepth))
                {
                    var unmarshaller = DateTimeEpochLongMillisecondsUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("firstEventTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeEpochLongMillisecondsUnmarshaller.Instance;
                    unmarshalledObject.FirstEventTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastEventTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeEpochLongMillisecondsUnmarshaller.Instance;
                    unmarshalledObject.LastEventTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastIngestionTime", targetDepth))
                {
                    var unmarshaller = DateTimeEpochLongMillisecondsUnmarshaller.Instance;
                    unmarshalledObject.LastIngestionTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("logStreamName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogStreamName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("storedBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.StoredBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("uploadSequenceToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UploadSequenceToken = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
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