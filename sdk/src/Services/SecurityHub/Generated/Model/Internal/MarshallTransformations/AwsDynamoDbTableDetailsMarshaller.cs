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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsDynamoDbTableDetails Marshaller
    /// </summary>
    public class AwsDynamoDbTableDetailsMarshaller : IRequestMarshaller<AwsDynamoDbTableDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsDynamoDbTableDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAttributeDefinitions())
            {
                context.Writer.WritePropertyName("AttributeDefinitions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAttributeDefinitionsListValue in requestObject.AttributeDefinitions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsDynamoDbTableAttributeDefinitionMarshaller.Instance;
                    marshaller.Marshall(requestObjectAttributeDefinitionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetBillingModeSummary())
            {
                context.Writer.WritePropertyName("BillingModeSummary");
                context.Writer.WriteStartObject();

                var marshaller = AwsDynamoDbTableBillingModeSummaryMarshaller.Instance;
                marshaller.Marshall(requestObject.BillingModeSummary, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCreationDateTime())
            {
                context.Writer.WritePropertyName("CreationDateTime");
                context.Writer.WriteStringValue(requestObject.CreationDateTime);
            }

            if(requestObject.IsSetDeletionProtectionEnabled())
            {
                context.Writer.WritePropertyName("DeletionProtectionEnabled");
                context.Writer.WriteBooleanValue(requestObject.DeletionProtectionEnabled.Value);
            }

            if(requestObject.IsSetGlobalSecondaryIndexes())
            {
                context.Writer.WritePropertyName("GlobalSecondaryIndexes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectGlobalSecondaryIndexesListValue in requestObject.GlobalSecondaryIndexes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsDynamoDbTableGlobalSecondaryIndexMarshaller.Instance;
                    marshaller.Marshall(requestObjectGlobalSecondaryIndexesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetGlobalTableVersion())
            {
                context.Writer.WritePropertyName("GlobalTableVersion");
                context.Writer.WriteStringValue(requestObject.GlobalTableVersion);
            }

            if(requestObject.IsSetItemCount())
            {
                context.Writer.WritePropertyName("ItemCount");
                context.Writer.WriteNumberValue(requestObject.ItemCount.Value);
            }

            if(requestObject.IsSetKeySchema())
            {
                context.Writer.WritePropertyName("KeySchema");
                context.Writer.WriteStartArray();
                foreach(var requestObjectKeySchemaListValue in requestObject.KeySchema)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsDynamoDbTableKeySchemaMarshaller.Instance;
                    marshaller.Marshall(requestObjectKeySchemaListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLatestStreamArn())
            {
                context.Writer.WritePropertyName("LatestStreamArn");
                context.Writer.WriteStringValue(requestObject.LatestStreamArn);
            }

            if(requestObject.IsSetLatestStreamLabel())
            {
                context.Writer.WritePropertyName("LatestStreamLabel");
                context.Writer.WriteStringValue(requestObject.LatestStreamLabel);
            }

            if(requestObject.IsSetLocalSecondaryIndexes())
            {
                context.Writer.WritePropertyName("LocalSecondaryIndexes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLocalSecondaryIndexesListValue in requestObject.LocalSecondaryIndexes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsDynamoDbTableLocalSecondaryIndexMarshaller.Instance;
                    marshaller.Marshall(requestObjectLocalSecondaryIndexesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetProvisionedThroughput())
            {
                context.Writer.WritePropertyName("ProvisionedThroughput");
                context.Writer.WriteStartObject();

                var marshaller = AwsDynamoDbTableProvisionedThroughputMarshaller.Instance;
                marshaller.Marshall(requestObject.ProvisionedThroughput, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetReplicas())
            {
                context.Writer.WritePropertyName("Replicas");
                context.Writer.WriteStartArray();
                foreach(var requestObjectReplicasListValue in requestObject.Replicas)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsDynamoDbTableReplicaMarshaller.Instance;
                    marshaller.Marshall(requestObjectReplicasListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRestoreSummary())
            {
                context.Writer.WritePropertyName("RestoreSummary");
                context.Writer.WriteStartObject();

                var marshaller = AwsDynamoDbTableRestoreSummaryMarshaller.Instance;
                marshaller.Marshall(requestObject.RestoreSummary, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSseDescription())
            {
                context.Writer.WritePropertyName("SseDescription");
                context.Writer.WriteStartObject();

                var marshaller = AwsDynamoDbTableSseDescriptionMarshaller.Instance;
                marshaller.Marshall(requestObject.SseDescription, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStreamSpecification())
            {
                context.Writer.WritePropertyName("StreamSpecification");
                context.Writer.WriteStartObject();

                var marshaller = AwsDynamoDbTableStreamSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.StreamSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTableId())
            {
                context.Writer.WritePropertyName("TableId");
                context.Writer.WriteStringValue(requestObject.TableId);
            }

            if(requestObject.IsSetTableName())
            {
                context.Writer.WritePropertyName("TableName");
                context.Writer.WriteStringValue(requestObject.TableName);
            }

            if(requestObject.IsSetTableSizeBytes())
            {
                context.Writer.WritePropertyName("TableSizeBytes");
                context.Writer.WriteNumberValue(requestObject.TableSizeBytes.Value);
            }

            if(requestObject.IsSetTableStatus())
            {
                context.Writer.WritePropertyName("TableStatus");
                context.Writer.WriteStringValue(requestObject.TableStatus);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsDynamoDbTableDetailsMarshaller Instance = new AwsDynamoDbTableDetailsMarshaller();

    }
}