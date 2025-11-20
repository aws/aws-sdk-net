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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ExpressGatewayScalingTarget Object
    /// </summary>  
    public class ExpressGatewayScalingTargetUnmarshaller : IUnmarshaller<ExpressGatewayScalingTarget, XmlUnmarshallerContext>, IUnmarshaller<ExpressGatewayScalingTarget, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ExpressGatewayScalingTarget IUnmarshaller<ExpressGatewayScalingTarget, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ExpressGatewayScalingTarget Unmarshall(JsonUnmarshallerContext context)
        {
            ExpressGatewayScalingTarget unmarshalledObject = new ExpressGatewayScalingTarget();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("autoScalingMetric", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AutoScalingMetric = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("autoScalingTargetValue", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AutoScalingTargetValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maxTaskCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxTaskCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("minTaskCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinTaskCount = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ExpressGatewayScalingTargetUnmarshaller _instance = new ExpressGatewayScalingTargetUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ExpressGatewayScalingTargetUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}