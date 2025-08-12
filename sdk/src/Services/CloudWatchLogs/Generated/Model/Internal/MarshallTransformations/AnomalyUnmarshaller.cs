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
    /// Response Unmarshaller for Anomaly Object
    /// </summary>  
    public class AnomalyUnmarshaller : ICborUnmarshaller<Anomaly, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Anomaly Unmarshall(CborUnmarshallerContext context)
        {
            Anomaly unmarshalledObject = new Anomaly();
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
                    case "active":
                        {
                            context.AddPathSegment("Active");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.Active = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "anomalyDetectorArn":
                        {
                            context.AddPathSegment("AnomalyDetectorArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AnomalyDetectorArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "anomalyId":
                        {
                            context.AddPathSegment("AnomalyId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AnomalyId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "description":
                        {
                            context.AddPathSegment("Description");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "firstSeen":
                        {
                            context.AddPathSegment("FirstSeen");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            unmarshalledObject.FirstSeen = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "histogram":
                        {
                            context.AddPathSegment("Histogram");
                            var unmarshaller = new CborDictionaryUnmarshaller<string, long, CborStringUnmarshaller, CborLongUnmarshaller>(CborStringUnmarshaller.Instance, CborLongUnmarshaller.Instance);
                            unmarshalledObject.Histogram = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "isPatternLevelSuppression":
                        {
                            context.AddPathSegment("IsPatternLevelSuppression");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.IsPatternLevelSuppression = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "lastSeen":
                        {
                            context.AddPathSegment("LastSeen");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            unmarshalledObject.LastSeen = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "logGroupArnList":
                        {
                            context.AddPathSegment("LogGroupArnList");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.LogGroupArnList = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "logSamples":
                        {
                            context.AddPathSegment("LogSamples");
                            var unmarshaller = new CborListUnmarshaller<LogEvent, LogEventUnmarshaller>(LogEventUnmarshaller.Instance);
                            unmarshalledObject.LogSamples = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "patternId":
                        {
                            context.AddPathSegment("PatternId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PatternId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "patternRegex":
                        {
                            context.AddPathSegment("PatternRegex");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PatternRegex = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "patternString":
                        {
                            context.AddPathSegment("PatternString");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PatternString = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "patternTokens":
                        {
                            context.AddPathSegment("PatternTokens");
                            var unmarshaller = new CborListUnmarshaller<PatternToken, PatternTokenUnmarshaller>(PatternTokenUnmarshaller.Instance);
                            unmarshalledObject.PatternTokens = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "priority":
                        {
                            context.AddPathSegment("Priority");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Priority = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "state":
                        {
                            context.AddPathSegment("State");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.State = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "suppressed":
                        {
                            context.AddPathSegment("Suppressed");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.Suppressed = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "suppressedDate":
                        {
                            context.AddPathSegment("SuppressedDate");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            unmarshalledObject.SuppressedDate = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "suppressedUntil":
                        {
                            context.AddPathSegment("SuppressedUntil");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            unmarshalledObject.SuppressedUntil = unmarshaller.Unmarshall(context);
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