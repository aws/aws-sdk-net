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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CostExplorer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CostExplorer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Anomaly Object
    /// </summary>  
    public class AnomalyUnmarshaller : IUnmarshaller<Anomaly, XmlUnmarshallerContext>, IUnmarshaller<Anomaly, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Anomaly IUnmarshaller<Anomaly, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Anomaly Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Anomaly unmarshalledObject = new Anomaly();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AnomalyEndDate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AnomalyEndDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AnomalyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AnomalyId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AnomalyScore", targetDepth))
                {
                    var unmarshaller = AnomalyScoreUnmarshaller.Instance;
                    unmarshalledObject.AnomalyScore = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AnomalyStartDate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AnomalyStartDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DimensionValue", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DimensionValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Feedback", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Feedback = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Impact", targetDepth))
                {
                    var unmarshaller = ImpactUnmarshaller.Instance;
                    unmarshalledObject.Impact = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MonitorArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MonitorArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RootCauses", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RootCause, RootCauseUnmarshaller>(RootCauseUnmarshaller.Instance);
                    unmarshalledObject.RootCauses = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AnomalyUnmarshaller _instance = new AnomalyUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AnomalyUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}