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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeDeploy.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.CodeDeploy.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TargetGroupPairInfo Object
    /// </summary>  
    public class TargetGroupPairInfoUnmarshaller : IJsonUnmarshaller<TargetGroupPairInfo, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public TargetGroupPairInfo Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            TargetGroupPairInfo unmarshalledObject = new TargetGroupPairInfo();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("prodTrafficRoute", targetDepth))
                {
                    var unmarshaller = TrafficRouteUnmarshaller.Instance;
                    unmarshalledObject.ProdTrafficRoute = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("targetGroups", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<TargetGroupInfo, TargetGroupInfoUnmarshaller>(TargetGroupInfoUnmarshaller.Instance);
                    unmarshalledObject.TargetGroups = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("testTrafficRoute", targetDepth))
                {
                    var unmarshaller = TrafficRouteUnmarshaller.Instance;
                    unmarshalledObject.TestTrafficRoute = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TargetGroupPairInfoUnmarshaller _instance = new TargetGroupPairInfoUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TargetGroupPairInfoUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}