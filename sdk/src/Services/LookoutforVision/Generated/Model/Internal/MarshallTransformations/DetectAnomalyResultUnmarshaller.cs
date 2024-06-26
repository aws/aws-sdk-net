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
 * Do not modify this file. This file is generated from the lookoutvision-2020-11-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LookoutforVision.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.LookoutforVision.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DetectAnomalyResult Object
    /// </summary>  
    public class DetectAnomalyResultUnmarshaller : IUnmarshaller<DetectAnomalyResult, XmlUnmarshallerContext>, IUnmarshaller<DetectAnomalyResult, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DetectAnomalyResult IUnmarshaller<DetectAnomalyResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public DetectAnomalyResult Unmarshall(JsonUnmarshallerContext context)
        {
            DetectAnomalyResult unmarshalledObject = new DetectAnomalyResult();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Anomalies", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Anomaly, AnomalyUnmarshaller>(AnomalyUnmarshaller.Instance);
                    unmarshalledObject.Anomalies = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AnomalyMask", targetDepth))
                {
                    var unmarshaller = MemoryStreamUnmarshaller.Instance;
                    unmarshalledObject.AnomalyMask = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Confidence", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    unmarshalledObject.Confidence = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IsAnomalous", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsAnomalous = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Source", targetDepth))
                {
                    var unmarshaller = ImageSourceUnmarshaller.Instance;
                    unmarshalledObject.Source = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DetectAnomalyResultUnmarshaller _instance = new DetectAnomalyResultUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DetectAnomalyResultUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}