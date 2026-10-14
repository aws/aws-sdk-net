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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.QuickSight.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for HierarchyFilterNode Object
    /// </summary>
    public partial class HierarchyFilterNodeUnmarshaller : IJsonUnmarshaller<HierarchyFilterNode, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public HierarchyFilterNode Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new HierarchyFilterNode();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Children", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<HierarchyFilterNode, HierarchyFilterNodeUnmarshaller>(HierarchyFilterNodeUnmarshaller.Instance);
                    unmarshalledObject.Children = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Column", targetDepth, ref reader))
                {
                    var unmarshaller = ColumnIdentifierUnmarshaller.Instance;
                    unmarshalledObject.Column = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("HierarchyValues", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.HierarchyValues = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ParentValue", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ParentValue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static HierarchyFilterNodeUnmarshaller _instance = new HierarchyFilterNodeUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static HierarchyFilterNodeUnmarshaller Instance => _instance;
    }
}
