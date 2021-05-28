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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LocationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LocationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Step Object
    /// </summary>  
    public class StepUnmarshaller : IUnmarshaller<Step, XmlUnmarshallerContext>, IUnmarshaller<Step, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Step IUnmarshaller<Step, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Step Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Step unmarshalledObject = new Step();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Distance", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Distance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DurationSeconds", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.DurationSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndPosition", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<double, DoubleUnmarshaller>(DoubleUnmarshaller.Instance);
                    unmarshalledObject.EndPosition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GeometryOffset", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.GeometryOffset = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartPosition", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<double, DoubleUnmarshaller>(DoubleUnmarshaller.Instance);
                    unmarshalledObject.StartPosition = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static StepUnmarshaller _instance = new StepUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StepUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}