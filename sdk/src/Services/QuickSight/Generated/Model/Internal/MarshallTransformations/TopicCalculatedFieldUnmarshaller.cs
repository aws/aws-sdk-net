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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TopicCalculatedField Object
    /// </summary>  
    public class TopicCalculatedFieldUnmarshaller : IJsonUnmarshaller<TopicCalculatedField, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public TopicCalculatedField Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            TopicCalculatedField unmarshalledObject = new TopicCalculatedField();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Aggregation", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Aggregation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AllowedAggregations", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AllowedAggregations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CalculatedFieldDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CalculatedFieldDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CalculatedFieldName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CalculatedFieldName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CalculatedFieldSynonyms", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.CalculatedFieldSynonyms = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CellValueSynonyms", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<CellValueSynonym, CellValueSynonymUnmarshaller>(CellValueSynonymUnmarshaller.Instance);
                    unmarshalledObject.CellValueSynonyms = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ColumnDataRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ColumnDataRole = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ComparativeOrder", targetDepth))
                {
                    var unmarshaller = ComparativeOrderUnmarshaller.Instance;
                    unmarshalledObject.ComparativeOrder = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DefaultFormatting", targetDepth))
                {
                    var unmarshaller = DefaultFormattingUnmarshaller.Instance;
                    unmarshalledObject.DefaultFormatting = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DisableIndexing", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.DisableIndexing = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Expression", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Expression = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("IsIncludedInTopic", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IsIncludedInTopic = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NeverAggregateInFilter", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.NeverAggregateInFilter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NonAdditive", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.NonAdditive = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NotAllowedAggregations", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.NotAllowedAggregations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SemanticType", targetDepth))
                {
                    var unmarshaller = SemanticTypeUnmarshaller.Instance;
                    unmarshalledObject.SemanticType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TimeGranularity", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimeGranularity = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TopicCalculatedFieldUnmarshaller _instance = new TopicCalculatedFieldUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TopicCalculatedFieldUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}