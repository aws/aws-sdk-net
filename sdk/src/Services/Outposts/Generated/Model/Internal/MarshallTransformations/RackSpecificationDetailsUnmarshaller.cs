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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Outposts.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Outposts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RackSpecificationDetails Object
    /// </summary>  
    public class RackSpecificationDetailsUnmarshaller : IJsonUnmarshaller<RackSpecificationDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public RackSpecificationDetails Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            RackSpecificationDetails unmarshalledObject = new RackSpecificationDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("EC2Capacities", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<EC2Capacity, EC2CapacityUnmarshaller>(EC2CapacityUnmarshaller.Instance);
                    unmarshalledObject.EC2Capacities = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RackDepthInches", targetDepth))
                {
                    var unmarshaller = NullableFloatUnmarshaller.Instance;
                    unmarshalledObject.RackDepthInches = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RackHeightInches", targetDepth))
                {
                    var unmarshaller = NullableFloatUnmarshaller.Instance;
                    unmarshalledObject.RackHeightInches = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RackId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RackId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RackPowerDrawKva", targetDepth))
                {
                    var unmarshaller = NullableFloatUnmarshaller.Instance;
                    unmarshalledObject.RackPowerDrawKva = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RackUnitHeight", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RackUnitHeight = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RackUse", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RackUse = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RackWeightLbs", targetDepth))
                {
                    var unmarshaller = NullableFloatUnmarshaller.Instance;
                    unmarshalledObject.RackWeightLbs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RackWidthInches", targetDepth))
                {
                    var unmarshaller = NullableFloatUnmarshaller.Instance;
                    unmarshalledObject.RackWidthInches = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RackSpecificationDetailsUnmarshaller _instance = new RackSpecificationDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RackSpecificationDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}