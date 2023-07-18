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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AnalyticsUtteranceResult Object
    /// </summary>  
    public class AnalyticsUtteranceResultUnmarshaller : IUnmarshaller<AnalyticsUtteranceResult, XmlUnmarshallerContext>, IUnmarshaller<AnalyticsUtteranceResult, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AnalyticsUtteranceResult IUnmarshaller<AnalyticsUtteranceResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AnalyticsUtteranceResult Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AnalyticsUtteranceResult unmarshalledObject = new AnalyticsUtteranceResult();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("attributeResults", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AnalyticsUtteranceAttributeResult, AnalyticsUtteranceAttributeResultUnmarshaller>(AnalyticsUtteranceAttributeResultUnmarshaller.Instance);
                    unmarshalledObject.AttributeResults = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("binKeys", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AnalyticsBinKey, AnalyticsBinKeyUnmarshaller>(AnalyticsBinKeyUnmarshaller.Instance);
                    unmarshalledObject.BinKeys = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("groupByKeys", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AnalyticsUtteranceGroupByKey, AnalyticsUtteranceGroupByKeyUnmarshaller>(AnalyticsUtteranceGroupByKeyUnmarshaller.Instance);
                    unmarshalledObject.GroupByKeys = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("metricsResults", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AnalyticsUtteranceMetricResult, AnalyticsUtteranceMetricResultUnmarshaller>(AnalyticsUtteranceMetricResultUnmarshaller.Instance);
                    unmarshalledObject.MetricsResults = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AnalyticsUtteranceResultUnmarshaller _instance = new AnalyticsUtteranceResultUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AnalyticsUtteranceResultUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}