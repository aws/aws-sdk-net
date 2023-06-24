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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CleanRooms.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CleanRooms.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AnalysisRuleAggregation Object
    /// </summary>  
    public class AnalysisRuleAggregationUnmarshaller : IUnmarshaller<AnalysisRuleAggregation, XmlUnmarshallerContext>, IUnmarshaller<AnalysisRuleAggregation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AnalysisRuleAggregation IUnmarshaller<AnalysisRuleAggregation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AnalysisRuleAggregation Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AnalysisRuleAggregation unmarshalledObject = new AnalysisRuleAggregation();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("aggregateColumns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AggregateColumn, AggregateColumnUnmarshaller>(AggregateColumnUnmarshaller.Instance);
                    unmarshalledObject.AggregateColumns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dimensionColumns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.DimensionColumns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("joinColumns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.JoinColumns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("joinRequired", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JoinRequired = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("outputConstraints", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AggregationConstraint, AggregationConstraintUnmarshaller>(AggregationConstraintUnmarshaller.Instance);
                    unmarshalledObject.OutputConstraints = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scalarFunctions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ScalarFunctions = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AnalysisRuleAggregationUnmarshaller _instance = new AnalysisRuleAggregationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AnalysisRuleAggregationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}