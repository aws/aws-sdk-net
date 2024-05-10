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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TrafficPattern Object
    /// </summary>  
    public class TrafficPatternUnmarshaller : IUnmarshaller<TrafficPattern, XmlUnmarshallerContext>, IUnmarshaller<TrafficPattern, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TrafficPattern IUnmarshaller<TrafficPattern, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public TrafficPattern Unmarshall(JsonUnmarshallerContext context)
        {
            TrafficPattern unmarshalledObject = new TrafficPattern();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Phases", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Phase, PhaseUnmarshaller>(PhaseUnmarshaller.Instance);
                    unmarshalledObject.Phases = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Stairs", targetDepth))
                {
                    var unmarshaller = StairsUnmarshaller.Instance;
                    unmarshalledObject.Stairs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrafficType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TrafficType = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TrafficPatternUnmarshaller _instance = new TrafficPatternUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TrafficPatternUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}