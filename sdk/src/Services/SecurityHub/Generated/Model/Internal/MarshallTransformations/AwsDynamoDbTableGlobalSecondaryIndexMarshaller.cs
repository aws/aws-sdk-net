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
    /// AwsDynamoDbTableGlobalSecondaryIndex Marshaller
    /// </summary>
    public class AwsDynamoDbTableGlobalSecondaryIndexMarshaller : IRequestMarshaller<AwsDynamoDbTableGlobalSecondaryIndex, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsDynamoDbTableGlobalSecondaryIndex requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBackfilling())
            {
                context.Writer.WritePropertyName("Backfilling");
                context.Writer.WriteBooleanValue(requestObject.Backfilling.Value);
            }

            if(requestObject.IsSetIndexArn())
            {
                context.Writer.WritePropertyName("IndexArn");
                context.Writer.WriteStringValue(requestObject.IndexArn);
            }

            if(requestObject.IsSetIndexName())
            {
                context.Writer.WritePropertyName("IndexName");
                context.Writer.WriteStringValue(requestObject.IndexName);
            }

            if(requestObject.IsSetIndexSizeBytes())
            {
                context.Writer.WritePropertyName("IndexSizeBytes");
                context.Writer.WriteNumberValue(requestObject.IndexSizeBytes.Value);
            }

            if(requestObject.IsSetIndexStatus())
            {
                context.Writer.WritePropertyName("IndexStatus");
                context.Writer.WriteStringValue(requestObject.IndexStatus);
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

            if(requestObject.IsSetProjection())
            {
                context.Writer.WritePropertyName("Projection");
                context.Writer.WriteStartObject();

                var marshaller = AwsDynamoDbTableProjectionMarshaller.Instance;
                marshaller.Marshall(requestObject.Projection, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetProvisionedThroughput())
            {
                context.Writer.WritePropertyName("ProvisionedThroughput");
                context.Writer.WriteStartObject();

                var marshaller = AwsDynamoDbTableProvisionedThroughputMarshaller.Instance;
                marshaller.Marshall(requestObject.ProvisionedThroughput, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsDynamoDbTableGlobalSecondaryIndexMarshaller Instance = new AwsDynamoDbTableGlobalSecondaryIndexMarshaller();

    }
}