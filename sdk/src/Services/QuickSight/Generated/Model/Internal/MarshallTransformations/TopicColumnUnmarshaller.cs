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

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TopicColumn Object
    /// </summary>  
    public class TopicColumnUnmarshaller : IUnmarshaller<TopicColumn, XmlUnmarshallerContext>, IUnmarshaller<TopicColumn, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TopicColumn IUnmarshaller<TopicColumn, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TopicColumn Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            TopicColumn unmarshalledObject = new TopicColumn();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Aggregation", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Aggregation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AllowedAggregations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AllowedAggregations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CellValueSynonyms", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<CellValueSynonym, CellValueSynonymUnmarshaller>(CellValueSynonymUnmarshaller.Instance);
                    unmarshalledObject.CellValueSynonyms = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ColumnDataRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ColumnDataRole = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ColumnDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ColumnDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ColumnFriendlyName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ColumnFriendlyName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ColumnName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ColumnName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ColumnSynonyms", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ColumnSynonyms = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ComparativeOrder", targetDepth))
                {
                    var unmarshaller = ComparativeOrderUnmarshaller.Instance;
                    unmarshalledObject.ComparativeOrder = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultFormatting", targetDepth))
                {
                    var unmarshaller = DefaultFormattingUnmarshaller.Instance;
                    unmarshalledObject.DefaultFormatting = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DisableIndexing", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DisableIndexing = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IsIncludedInTopic", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsIncludedInTopic = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NeverAggregateInFilter", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.NeverAggregateInFilter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NotAllowedAggregations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.NotAllowedAggregations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SemanticType", targetDepth))
                {
                    var unmarshaller = SemanticTypeUnmarshaller.Instance;
                    unmarshalledObject.SemanticType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TimeGranularity", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimeGranularity = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static TopicColumnUnmarshaller _instance = new TopicColumnUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TopicColumnUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}