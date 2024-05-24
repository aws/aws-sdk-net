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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Anomaly Object
    /// </summary>  
    public class AnomalyUnmarshaller : IUnmarshaller<Anomaly, XmlUnmarshallerContext>, IUnmarshaller<Anomaly, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Anomaly IUnmarshaller<Anomaly, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Anomaly Unmarshall(JsonUnmarshallerContext context)
        {
            Anomaly unmarshalledObject = new Anomaly();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("active", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Active = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("anomalyDetectorArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AnomalyDetectorArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("anomalyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AnomalyId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("firstSeen", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.FirstSeen = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("histogram", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, long, StringUnmarshaller, LongUnmarshaller>(StringUnmarshaller.Instance, LongUnmarshaller.Instance);
                    unmarshalledObject.Histogram = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("isPatternLevelSuppression", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsPatternLevelSuppression = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastSeen", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.LastSeen = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("logGroupArnList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.LogGroupArnList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("logSamples", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<LogEvent, LogEventUnmarshaller>(LogEventUnmarshaller.Instance);
                    unmarshalledObject.LogSamples = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("patternId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PatternId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("patternRegex", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PatternRegex = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("patternString", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PatternString = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("patternTokens", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PatternToken, PatternTokenUnmarshaller>(PatternTokenUnmarshaller.Instance);
                    unmarshalledObject.PatternTokens = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("priority", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Priority = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("state", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("suppressed", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Suppressed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("suppressedDate", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.SuppressedDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("suppressedUntil", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.SuppressedUntil = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AnomalyUnmarshaller _instance = new AnomalyUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AnomalyUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}