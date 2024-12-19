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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TableDescription Object
    /// </summary>  
    public class TableDescriptionUnmarshaller : IJsonUnmarshaller<TableDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public TableDescription Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            TableDescription unmarshalledObject = new TableDescription();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("ArchivalSummary", targetDepth))
                {
                    var unmarshaller = ArchivalSummaryUnmarshaller.Instance;
                    unmarshalledObject.ArchivalSummary = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AttributeDefinitions", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AttributeDefinition, AttributeDefinitionUnmarshaller>(AttributeDefinitionUnmarshaller.Instance);
                    unmarshalledObject.AttributeDefinitions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BillingModeSummary", targetDepth))
                {
                    var unmarshaller = BillingModeSummaryUnmarshaller.Instance;
                    unmarshalledObject.BillingModeSummary = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreationDateTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationDateTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DeletionProtectionEnabled", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.DeletionProtectionEnabled = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GlobalSecondaryIndexes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<GlobalSecondaryIndexDescription, GlobalSecondaryIndexDescriptionUnmarshaller>(GlobalSecondaryIndexDescriptionUnmarshaller.Instance);
                    unmarshalledObject.GlobalSecondaryIndexes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GlobalTableVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GlobalTableVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ItemCount", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.ItemCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("KeySchema", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<KeySchemaElement, KeySchemaElementUnmarshaller>(KeySchemaElementUnmarshaller.Instance);
                    unmarshalledObject.KeySchema = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LatestStreamArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LatestStreamArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LatestStreamLabel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LatestStreamLabel = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LocalSecondaryIndexes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<LocalSecondaryIndexDescription, LocalSecondaryIndexDescriptionUnmarshaller>(LocalSecondaryIndexDescriptionUnmarshaller.Instance);
                    unmarshalledObject.LocalSecondaryIndexes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OnDemandThroughput", targetDepth))
                {
                    var unmarshaller = OnDemandThroughputUnmarshaller.Instance;
                    unmarshalledObject.OnDemandThroughput = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ProvisionedThroughput", targetDepth))
                {
                    var unmarshaller = ProvisionedThroughputDescriptionUnmarshaller.Instance;
                    unmarshalledObject.ProvisionedThroughput = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Replicas", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ReplicaDescription, ReplicaDescriptionUnmarshaller>(ReplicaDescriptionUnmarshaller.Instance);
                    unmarshalledObject.Replicas = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RestoreSummary", targetDepth))
                {
                    var unmarshaller = RestoreSummaryUnmarshaller.Instance;
                    unmarshalledObject.RestoreSummary = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SSEDescription", targetDepth))
                {
                    var unmarshaller = SSEDescriptionUnmarshaller.Instance;
                    unmarshalledObject.SSEDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StreamSpecification", targetDepth))
                {
                    var unmarshaller = StreamSpecificationUnmarshaller.Instance;
                    unmarshalledObject.StreamSpecification = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TableArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TableArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TableClassSummary", targetDepth))
                {
                    var unmarshaller = TableClassSummaryUnmarshaller.Instance;
                    unmarshalledObject.TableClassSummary = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TableId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TableId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TableName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TableName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TableSizeBytes", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.TableSizeBytes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TableStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TableStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TableDescriptionUnmarshaller _instance = new TableDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TableDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}