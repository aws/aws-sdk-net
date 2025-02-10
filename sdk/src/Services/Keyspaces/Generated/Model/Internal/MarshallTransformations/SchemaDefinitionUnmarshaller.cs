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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Keyspaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Keyspaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SchemaDefinition Object
    /// </summary>  
    public class SchemaDefinitionUnmarshaller : IJsonUnmarshaller<SchemaDefinition, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public SchemaDefinition Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            SchemaDefinition unmarshalledObject = new SchemaDefinition();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("allColumns", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ColumnDefinition, ColumnDefinitionUnmarshaller>(ColumnDefinitionUnmarshaller.Instance);
                    unmarshalledObject.AllColumns = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("clusteringKeys", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ClusteringKey, ClusteringKeyUnmarshaller>(ClusteringKeyUnmarshaller.Instance);
                    unmarshalledObject.ClusteringKeys = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("partitionKeys", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<PartitionKey, PartitionKeyUnmarshaller>(PartitionKeyUnmarshaller.Instance);
                    unmarshalledObject.PartitionKeys = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("staticColumns", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<StaticColumn, StaticColumnUnmarshaller>(StaticColumnUnmarshaller.Instance);
                    unmarshalledObject.StaticColumns = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SchemaDefinitionUnmarshaller _instance = new SchemaDefinitionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SchemaDefinitionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}