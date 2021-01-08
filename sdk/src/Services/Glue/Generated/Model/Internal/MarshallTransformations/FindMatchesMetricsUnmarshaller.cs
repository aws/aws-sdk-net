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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FindMatchesMetrics Object
    /// </summary>  
    public class FindMatchesMetricsUnmarshaller : IUnmarshaller<FindMatchesMetrics, XmlUnmarshallerContext>, IUnmarshaller<FindMatchesMetrics, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        FindMatchesMetrics IUnmarshaller<FindMatchesMetrics, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public FindMatchesMetrics Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            FindMatchesMetrics unmarshalledObject = new FindMatchesMetrics();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AreaUnderPRCurve", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.AreaUnderPRCurve = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ColumnImportances", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ColumnImportance, ColumnImportanceUnmarshaller>(ColumnImportanceUnmarshaller.Instance);
                    unmarshalledObject.ColumnImportances = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConfusionMatrix", targetDepth))
                {
                    var unmarshaller = ConfusionMatrixUnmarshaller.Instance;
                    unmarshalledObject.ConfusionMatrix = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("F1", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.F1 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Precision", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Precision = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Recall", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Recall = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static FindMatchesMetricsUnmarshaller _instance = new FindMatchesMetricsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FindMatchesMetricsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}