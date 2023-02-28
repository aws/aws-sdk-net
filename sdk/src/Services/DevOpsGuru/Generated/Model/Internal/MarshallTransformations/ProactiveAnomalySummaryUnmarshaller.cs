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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DevOpsGuru.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DevOpsGuru.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ProactiveAnomalySummary Object
    /// </summary>  
    public class ProactiveAnomalySummaryUnmarshaller : IUnmarshaller<ProactiveAnomalySummary, XmlUnmarshallerContext>, IUnmarshaller<ProactiveAnomalySummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ProactiveAnomalySummary IUnmarshaller<ProactiveAnomalySummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ProactiveAnomalySummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ProactiveAnomalySummary unmarshalledObject = new ProactiveAnomalySummary();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AnomalyReportedTimeRange", targetDepth))
                {
                    var unmarshaller = AnomalyReportedTimeRangeUnmarshaller.Instance;
                    unmarshalledObject.AnomalyReportedTimeRange = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AnomalyResources", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AnomalyResource, AnomalyResourceUnmarshaller>(AnomalyResourceUnmarshaller.Instance);
                    unmarshalledObject.AnomalyResources = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AnomalyTimeRange", targetDepth))
                {
                    var unmarshaller = AnomalyTimeRangeUnmarshaller.Instance;
                    unmarshalledObject.AnomalyTimeRange = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AssociatedInsightId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssociatedInsightId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Limit", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Limit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PredictionTimeRange", targetDepth))
                {
                    var unmarshaller = PredictionTimeRangeUnmarshaller.Instance;
                    unmarshalledObject.PredictionTimeRange = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceCollection", targetDepth))
                {
                    var unmarshaller = ResourceCollectionUnmarshaller.Instance;
                    unmarshalledObject.ResourceCollection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Severity", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Severity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceDetails", targetDepth))
                {
                    var unmarshaller = AnomalySourceDetailsUnmarshaller.Instance;
                    unmarshalledObject.SourceDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceMetadata", targetDepth))
                {
                    var unmarshaller = AnomalySourceMetadataUnmarshaller.Instance;
                    unmarshalledObject.SourceMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UpdateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.UpdateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ProactiveAnomalySummaryUnmarshaller _instance = new ProactiveAnomalySummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ProactiveAnomalySummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}