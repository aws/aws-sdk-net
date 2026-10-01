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

using Amazon.LakeFormation.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.LakeFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Resource Object
    /// </summary>
    public partial class ResourceUnmarshaller : IJsonUnmarshaller<Resource, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Resource Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new Resource();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Catalog", targetDepth, ref reader))
                {
                    var unmarshaller = CatalogResourceUnmarshaller.Instance;
                    unmarshalledObject.Catalog = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("DataCellsFilter", targetDepth, ref reader))
                {
                    var unmarshaller = DataCellsFilterResourceUnmarshaller.Instance;
                    unmarshalledObject.DataCellsFilter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("DataLocation", targetDepth, ref reader))
                {
                    var unmarshaller = DataLocationResourceUnmarshaller.Instance;
                    unmarshalledObject.DataLocation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Database", targetDepth, ref reader))
                {
                    var unmarshaller = DatabaseResourceUnmarshaller.Instance;
                    unmarshalledObject.Database = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("LFTag", targetDepth, ref reader))
                {
                    var unmarshaller = LFTagKeyResourceUnmarshaller.Instance;
                    unmarshalledObject.LFTag = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("LFTagExpression", targetDepth, ref reader))
                {
                    var unmarshaller = LFTagExpressionResourceUnmarshaller.Instance;
                    unmarshalledObject.LFTagExpression = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("LFTagPolicy", targetDepth, ref reader))
                {
                    var unmarshaller = LFTagPolicyResourceUnmarshaller.Instance;
                    unmarshalledObject.LFTagPolicy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Table", targetDepth, ref reader))
                {
                    var unmarshaller = TableResourceUnmarshaller.Instance;
                    unmarshalledObject.Table = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("TableWithColumns", targetDepth, ref reader))
                {
                    var unmarshaller = TableWithColumnsResourceUnmarshaller.Instance;
                    unmarshalledObject.TableWithColumns = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static ResourceUnmarshaller _instance = new ResourceUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ResourceUnmarshaller Instance => _instance;
    }
}
