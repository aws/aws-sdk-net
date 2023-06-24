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
using ThirdParty.Json.LitJson;

namespace Amazon.StepFunctions.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MapRunExecutionCounts Object
    /// </summary>  
    public class MapRunExecutionCountsUnmarshaller : IUnmarshaller<MapRunExecutionCounts, XmlUnmarshallerContext>, IUnmarshaller<MapRunExecutionCounts, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        MapRunExecutionCounts IUnmarshaller<MapRunExecutionCounts, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public MapRunExecutionCounts Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            MapRunExecutionCounts unmarshalledObject = new MapRunExecutionCounts();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("aborted", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Aborted = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("failed", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Failed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pending", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Pending = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resultsWritten", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ResultsWritten = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("running", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Running = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("succeeded", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Succeeded = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timedOut", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.TimedOut = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("total", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Total = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static MapRunExecutionCountsUnmarshaller _instance = new MapRunExecutionCountsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MapRunExecutionCountsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}