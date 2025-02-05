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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.NeptuneGraph.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.NeptuneGraph.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GraphDataSummary Object
    /// </summary>  
    public class GraphDataSummaryUnmarshaller : IJsonUnmarshaller<GraphDataSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public GraphDataSummary Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            GraphDataSummary unmarshalledObject = new GraphDataSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("edgeLabels", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.EdgeLabels = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("edgeProperties", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Dictionary<string, long>, JsonDictionaryUnmarshaller<string, long, StringUnmarshaller, LongUnmarshaller>>(new JsonDictionaryUnmarshaller<string, long, StringUnmarshaller, LongUnmarshaller>(StringUnmarshaller.Instance, LongUnmarshaller.Instance));
                    unmarshalledObject.EdgeProperties = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("edgeStructures", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<EdgeStructure, EdgeStructureUnmarshaller>(EdgeStructureUnmarshaller.Instance);
                    unmarshalledObject.EdgeStructures = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("nodeLabels", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.NodeLabels = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("nodeProperties", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Dictionary<string, long>, JsonDictionaryUnmarshaller<string, long, StringUnmarshaller, LongUnmarshaller>>(new JsonDictionaryUnmarshaller<string, long, StringUnmarshaller, LongUnmarshaller>(StringUnmarshaller.Instance, LongUnmarshaller.Instance));
                    unmarshalledObject.NodeProperties = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("nodeStructures", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<NodeStructure, NodeStructureUnmarshaller>(NodeStructureUnmarshaller.Instance);
                    unmarshalledObject.NodeStructures = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("numEdgeLabels", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.NumEdgeLabels = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("numEdgeProperties", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.NumEdgeProperties = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("numEdges", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.NumEdges = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("numNodeLabels", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.NumNodeLabels = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("numNodeProperties", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.NumNodeProperties = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("numNodes", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.NumNodes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("totalEdgePropertyValues", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.TotalEdgePropertyValues = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("totalNodePropertyValues", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.TotalNodePropertyValues = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static GraphDataSummaryUnmarshaller _instance = new GraphDataSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GraphDataSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}