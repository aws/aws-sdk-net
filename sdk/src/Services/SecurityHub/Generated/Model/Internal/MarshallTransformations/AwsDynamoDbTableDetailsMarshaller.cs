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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetAttributeDefinitions())
            {
                context.Writer.WritePropertyName("AttributeDefinitions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAttributeDefinitionsListValue in requestObject.AttributeDefinitions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsDynamoDbTableAttributeDefinitionMarshaller.Instance;
                    marshaller.Marshall(requestObjectAttributeDefinitionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetBillingModeSummary())
            {
                context.Writer.WritePropertyName("BillingModeSummary");
                context.Writer.WriteObjectStart();

                var marshaller = AwsDynamoDbTableBillingModeSummaryMarshaller.Instance;
                marshaller.Marshall(requestObject.BillingModeSummary, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCreationDateTime())
            {
                context.Writer.WritePropertyName("CreationDateTime");
                context.Writer.Write(requestObject.CreationDateTime);
            }

            if(requestObject.IsSetGlobalSecondaryIndexes())
            {
                context.Writer.WritePropertyName("GlobalSecondaryIndexes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectGlobalSecondaryIndexesListValue in requestObject.GlobalSecondaryIndexes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsDynamoDbTableGlobalSecondaryIndexMarshaller.Instance;
                    marshaller.Marshall(requestObjectGlobalSecondaryIndexesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetGlobalTableVersion())
            {
                context.Writer.WritePropertyName("GlobalTableVersion");
                context.Writer.Write(requestObject.GlobalTableVersion);
            }

            if(requestObject.IsSetItemCount())
            {
                context.Writer.WritePropertyName("ItemCount");
                context.Writer.Write(requestObject.ItemCount);
            }

            if(requestObject.IsSetKeySchema())
            {
                context.Writer.WritePropertyName("KeySchema");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectKeySchemaListValue in requestObject.KeySchema)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsDynamoDbTableKeySchemaMarshaller.Instance;
                    marshaller.Marshall(requestObjectKeySchemaListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLatestStreamArn())
            {
                context.Writer.WritePropertyName("LatestStreamArn");
                context.Writer.Write(requestObject.LatestStreamArn);
            }

            if(requestObject.IsSetLatestStreamLabel())
            {
                context.Writer.WritePropertyName("LatestStreamLabel");
                context.Writer.Write(requestObject.LatestStreamLabel);
            }

            if(requestObject.IsSetLocalSecondaryIndexes())
            {
                context.Writer.WritePropertyName("LocalSecondaryIndexes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLocalSecondaryIndexesListValue in requestObject.LocalSecondaryIndexes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsDynamoDbTableLocalSecondaryIndexMarshaller.Instance;
                    marshaller.Marshall(requestObjectLocalSecondaryIndexesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetProvisionedThroughput())
            {
                context.Writer.WritePropertyName("ProvisionedThroughput");
                context.Writer.WriteObjectStart();

                var marshaller = AwsDynamoDbTableProvisionedThroughputMarshaller.Instance;
                marshaller.Marshall(requestObject.ProvisionedThroughput, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetReplicas())
            {
                context.Writer.WritePropertyName("Replicas");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectReplicasListValue in requestObject.Replicas)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsDynamoDbTableReplicaMarshaller.Instance;
                    marshaller.Marshall(requestObjectReplicasListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRestoreSummary())
            {
                context.Writer.WritePropertyName("RestoreSummary");
                context.Writer.WriteObjectStart();

                var marshaller = AwsDynamoDbTableRestoreSummaryMarshaller.Instance;
                marshaller.Marshall(requestObject.RestoreSummary, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSseDescription())
            {
                context.Writer.WritePropertyName("SseDescription");
                context.Writer.WriteObjectStart();

                var marshaller = AwsDynamoDbTableSseDescriptionMarshaller.Instance;
                marshaller.Marshall(requestObject.SseDescription, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStreamSpecification())
            {
                context.Writer.WritePropertyName("StreamSpecification");
                context.Writer.WriteObjectStart();

                var marshaller = AwsDynamoDbTableStreamSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.StreamSpecification, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTableId())
            {
                context.Writer.WritePropertyName("TableId");
                context.Writer.Write(requestObject.TableId);
            }

            if(requestObject.IsSetTableName())
            {
                context.Writer.WritePropertyName("TableName");
                context.Writer.Write(requestObject.TableName);
            }

            if(requestObject.IsSetTableSizeBytes())
            {
                context.Writer.WritePropertyName("TableSizeBytes");
                context.Writer.Write(requestObject.TableSizeBytes);
            }

            if(requestObject.IsSetTableStatus())
            {
                context.Writer.WritePropertyName("TableStatus");
                context.Writer.Write(requestObject.TableStatus);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsDynamoDbTableDetailsMarshaller Instance = new AwsDynamoDbTableDetailsMarshaller();

    }
}