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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TopicIRFilterOption Object
    /// </summary>  
    public class TopicIRFilterOptionUnmarshaller : IUnmarshaller<TopicIRFilterOption, XmlUnmarshallerContext>, IUnmarshaller<TopicIRFilterOption, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TopicIRFilterOption IUnmarshaller<TopicIRFilterOption, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public TopicIRFilterOption Unmarshall(JsonUnmarshallerContext context)
        {
            TopicIRFilterOption unmarshalledObject = new TopicIRFilterOption();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AggMetrics", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<FilterAggMetrics, FilterAggMetricsUnmarshaller>(FilterAggMetricsUnmarshaller.Instance);
                    unmarshalledObject.AggMetrics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Aggregation", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Aggregation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AggregationFunctionParameters", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.AggregationFunctionParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AggregationPartitionBy", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AggregationPartitionBy, AggregationPartitionByUnmarshaller>(AggregationPartitionByUnmarshaller.Instance);
                    unmarshalledObject.AggregationPartitionBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Anchor", targetDepth))
                {
                    var unmarshaller = AnchorUnmarshaller.Instance;
                    unmarshalledObject.Anchor = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Constant", targetDepth))
                {
                    var unmarshaller = TopicConstantValueUnmarshaller.Instance;
                    unmarshalledObject.Constant = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FilterClass", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FilterClass = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FilterType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FilterType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Function", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Function = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Inclusive", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Inclusive = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Inverse", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Inverse = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastNextOffset", targetDepth))
                {
                    var unmarshaller = TopicConstantValueUnmarshaller.Instance;
                    unmarshalledObject.LastNextOffset = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NullFilter", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NullFilter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OperandField", targetDepth))
                {
                    var unmarshaller = IdentifierUnmarshaller.Instance;
                    unmarshalledObject.OperandField = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Range", targetDepth))
                {
                    var unmarshaller = TopicConstantValueUnmarshaller.Instance;
                    unmarshalledObject.Range = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SortDirection", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SortDirection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TimeGranularity", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimeGranularity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TopBottomLimit", targetDepth))
                {
                    var unmarshaller = TopicConstantValueUnmarshaller.Instance;
                    unmarshalledObject.TopBottomLimit = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TopicIRFilterOptionUnmarshaller _instance = new TopicIRFilterOptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TopicIRFilterOptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}