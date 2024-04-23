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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.FraudDetector.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.FraudDetector.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ATIMetricDataPoint Object
    /// </summary>  
    public class ATIMetricDataPointUnmarshaller : IUnmarshaller<ATIMetricDataPoint, XmlUnmarshallerContext>, IUnmarshaller<ATIMetricDataPoint, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ATIMetricDataPoint IUnmarshaller<ATIMetricDataPoint, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ATIMetricDataPoint Unmarshall(JsonUnmarshallerContext context)
        {
            ATIMetricDataPoint unmarshalledObject = new ATIMetricDataPoint();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("adr", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    unmarshalledObject.Adr = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("atodr", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    unmarshalledObject.Atodr = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("cr", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    unmarshalledObject.Cr = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("threshold", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    unmarshalledObject.Threshold = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ATIMetricDataPointUnmarshaller _instance = new ATIMetricDataPointUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ATIMetricDataPointUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618