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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CrawlerHistory Object
    /// </summary>  
    public class CrawlerHistoryUnmarshaller : IJsonUnmarshaller<CrawlerHistory, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public CrawlerHistory Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            CrawlerHistory unmarshalledObject = new CrawlerHistory();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CrawlId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CrawlId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DPUHour", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.DPUHour = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EndTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.EndTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ErrorMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ErrorMessage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LogGroup", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogGroup = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LogStream", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogStream = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MessagePrefix", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MessagePrefix = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StartTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("State", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Summary", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Summary = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CrawlerHistoryUnmarshaller _instance = new CrawlerHistoryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CrawlerHistoryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}