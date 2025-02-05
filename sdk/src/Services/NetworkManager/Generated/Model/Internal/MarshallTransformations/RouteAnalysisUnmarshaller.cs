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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.NetworkManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RouteAnalysis Object
    /// </summary>  
    public class RouteAnalysisUnmarshaller : IJsonUnmarshaller<RouteAnalysis, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public RouteAnalysis Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            RouteAnalysis unmarshalledObject = new RouteAnalysis();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Destination", targetDepth))
                {
                    var unmarshaller = RouteAnalysisEndpointOptionsUnmarshaller.Instance;
                    unmarshalledObject.Destination = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ForwardPath", targetDepth))
                {
                    var unmarshaller = RouteAnalysisPathUnmarshaller.Instance;
                    unmarshalledObject.ForwardPath = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GlobalNetworkId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GlobalNetworkId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("IncludeReturnPath", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IncludeReturnPath = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OwnerAccountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OwnerAccountId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReturnPath", targetDepth))
                {
                    var unmarshaller = RouteAnalysisPathUnmarshaller.Instance;
                    unmarshalledObject.ReturnPath = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RouteAnalysisId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RouteAnalysisId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Source", targetDepth))
                {
                    var unmarshaller = RouteAnalysisEndpointOptionsUnmarshaller.Instance;
                    unmarshalledObject.Source = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StartTimestamp", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTimestamp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("UseMiddleboxes", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.UseMiddleboxes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RouteAnalysisUnmarshaller _instance = new RouteAnalysisUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RouteAnalysisUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}