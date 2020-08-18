/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsDynamoDbTableDetails Object
    /// </summary>  
    public class AwsDynamoDbTableDetailsUnmarshaller : IUnmarshaller<AwsDynamoDbTableDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsDynamoDbTableDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsDynamoDbTableDetails IUnmarshaller<AwsDynamoDbTableDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsDynamoDbTableDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsDynamoDbTableDetails unmarshalledObject = new AwsDynamoDbTableDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AttributeDefinitions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsDynamoDbTableAttributeDefinition, AwsDynamoDbTableAttributeDefinitionUnmarshaller>(AwsDynamoDbTableAttributeDefinitionUnmarshaller.Instance);
                    unmarshalledObject.AttributeDefinitions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BillingModeSummary", targetDepth))
                {
                    var unmarshaller = AwsDynamoDbTableBillingModeSummaryUnmarshaller.Instance;
                    unmarshalledObject.BillingModeSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationDateTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreationDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GlobalSecondaryIndexes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsDynamoDbTableGlobalSecondaryIndex, AwsDynamoDbTableGlobalSecondaryIndexUnmarshaller>(AwsDynamoDbTableGlobalSecondaryIndexUnmarshaller.Instance);
                    unmarshalledObject.GlobalSecondaryIndexes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GlobalTableVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GlobalTableVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ItemCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ItemCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KeySchema", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsDynamoDbTableKeySchema, AwsDynamoDbTableKeySchemaUnmarshaller>(AwsDynamoDbTableKeySchemaUnmarshaller.Instance);
                    unmarshalledObject.KeySchema = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LatestStreamArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LatestStreamArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LatestStreamLabel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LatestStreamLabel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LocalSecondaryIndexes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsDynamoDbTableLocalSecondaryIndex, AwsDynamoDbTableLocalSecondaryIndexUnmarshaller>(AwsDynamoDbTableLocalSecondaryIndexUnmarshaller.Instance);
                    unmarshalledObject.LocalSecondaryIndexes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProvisionedThroughput", targetDepth))
                {
                    var unmarshaller = AwsDynamoDbTableProvisionedThroughputUnmarshaller.Instance;
                    unmarshalledObject.ProvisionedThroughput = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Replicas", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsDynamoDbTableReplica, AwsDynamoDbTableReplicaUnmarshaller>(AwsDynamoDbTableReplicaUnmarshaller.Instance);
                    unmarshalledObject.Replicas = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RestoreSummary", targetDepth))
                {
                    var unmarshaller = AwsDynamoDbTableRestoreSummaryUnmarshaller.Instance;
                    unmarshalledObject.RestoreSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SseDescription", targetDepth))
                {
                    var unmarshaller = AwsDynamoDbTableSseDescriptionUnmarshaller.Instance;
                    unmarshalledObject.SseDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StreamSpecification", targetDepth))
                {
                    var unmarshaller = AwsDynamoDbTableStreamSpecificationUnmarshaller.Instance;
                    unmarshalledObject.StreamSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TableId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TableId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TableName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TableName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TableSizeBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.TableSizeBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TableStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TableStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsDynamoDbTableDetailsUnmarshaller _instance = new AwsDynamoDbTableDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsDynamoDbTableDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}