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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Neptunedata.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Neptunedata.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PropertygraphSummary Object
    /// </summary>  
    public class PropertygraphSummaryUnmarshaller : IUnmarshaller<PropertygraphSummary, XmlUnmarshallerContext>, IUnmarshaller<PropertygraphSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PropertygraphSummary IUnmarshaller<PropertygraphSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PropertygraphSummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            PropertygraphSummary unmarshalledObject = new PropertygraphSummary();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("edgeLabels", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.EdgeLabels = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("edgeProperties", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Dictionary<string, long>, DictionaryUnmarshaller<string, long, StringUnmarshaller, LongUnmarshaller>>(new DictionaryUnmarshaller<string, long, StringUnmarshaller, LongUnmarshaller>(StringUnmarshaller.Instance, LongUnmarshaller.Instance));
                    unmarshalledObject.EdgeProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("edgeStructures", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<EdgeStructure, EdgeStructureUnmarshaller>(EdgeStructureUnmarshaller.Instance);
                    unmarshalledObject.EdgeStructures = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("nodeLabels", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.NodeLabels = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("nodeProperties", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Dictionary<string, long>, DictionaryUnmarshaller<string, long, StringUnmarshaller, LongUnmarshaller>>(new DictionaryUnmarshaller<string, long, StringUnmarshaller, LongUnmarshaller>(StringUnmarshaller.Instance, LongUnmarshaller.Instance));
                    unmarshalledObject.NodeProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("nodeStructures", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<NodeStructure, NodeStructureUnmarshaller>(NodeStructureUnmarshaller.Instance);
                    unmarshalledObject.NodeStructures = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("numEdgeLabels", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.NumEdgeLabels = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("numEdgeProperties", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.NumEdgeProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("numEdges", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.NumEdges = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("numNodeLabels", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.NumNodeLabels = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("numNodeProperties", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.NumNodeProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("numNodes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.NumNodes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("totalEdgePropertyValues", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.TotalEdgePropertyValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("totalNodePropertyValues", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.TotalNodePropertyValues = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static PropertygraphSummaryUnmarshaller _instance = new PropertygraphSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PropertygraphSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}