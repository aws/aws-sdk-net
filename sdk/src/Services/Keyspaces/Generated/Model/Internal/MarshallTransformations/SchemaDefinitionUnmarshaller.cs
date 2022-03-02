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
using ThirdParty.Json.LitJson;

namespace Amazon.Keyspaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SchemaDefinition Object
    /// </summary>  
    public class SchemaDefinitionUnmarshaller : IUnmarshaller<SchemaDefinition, XmlUnmarshallerContext>, IUnmarshaller<SchemaDefinition, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SchemaDefinition IUnmarshaller<SchemaDefinition, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SchemaDefinition Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SchemaDefinition unmarshalledObject = new SchemaDefinition();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("allColumns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ColumnDefinition, ColumnDefinitionUnmarshaller>(ColumnDefinitionUnmarshaller.Instance);
                    unmarshalledObject.AllColumns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("clusteringKeys", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ClusteringKey, ClusteringKeyUnmarshaller>(ClusteringKeyUnmarshaller.Instance);
                    unmarshalledObject.ClusteringKeys = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("partitionKeys", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PartitionKey, PartitionKeyUnmarshaller>(PartitionKeyUnmarshaller.Instance);
                    unmarshalledObject.PartitionKeys = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("staticColumns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StaticColumn, StaticColumnUnmarshaller>(StaticColumnUnmarshaller.Instance);
                    unmarshalledObject.StaticColumns = unmarshaller.Unmarshall(context);
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