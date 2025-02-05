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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.StepFunctions.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.StepFunctions.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MapRunItemCounts Object
    /// </summary>  
    public class MapRunItemCountsUnmarshaller : IJsonUnmarshaller<MapRunItemCounts, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public MapRunItemCounts Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            MapRunItemCounts unmarshalledObject = new MapRunItemCounts();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("aborted", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.Aborted = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("failed", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.Failed = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("failuresNotRedrivable", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.FailuresNotRedrivable = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pending", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.Pending = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pendingRedrive", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.PendingRedrive = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("resultsWritten", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.ResultsWritten = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("running", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.Running = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("succeeded", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.Succeeded = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timedOut", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.TimedOut = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("total", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.Total = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static MapRunItemCountsUnmarshaller _instance = new MapRunItemCountsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MapRunItemCountsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}