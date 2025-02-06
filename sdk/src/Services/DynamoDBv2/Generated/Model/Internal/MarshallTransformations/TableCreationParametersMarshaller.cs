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
using System.Text;
using System.Xml.Serialization;

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TableCreationParameters Marshaller
    /// </summary>
    public class TableCreationParametersMarshaller : IRequestMarshaller<TableCreationParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TableCreationParameters requestObject, JsonMarshallerContext context)
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

                    var marshaller = AttributeDefinitionMarshaller.Instance;
                    marshaller.Marshall(requestObjectAttributeDefinitionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetBillingMode())
            {
                context.Writer.WritePropertyName("BillingMode");
                context.Writer.WriteStringValue(requestObject.BillingMode);
            }

            if(requestObject.IsSetGlobalSecondaryIndexes())
            {
                context.Writer.WritePropertyName("GlobalSecondaryIndexes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectGlobalSecondaryIndexesListValue in requestObject.GlobalSecondaryIndexes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = GlobalSecondaryIndexMarshaller.Instance;
                    marshaller.Marshall(requestObjectGlobalSecondaryIndexesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetKeySchema())
            {
                context.Writer.WritePropertyName("KeySchema");
                context.Writer.WriteStartArray();
                foreach(var requestObjectKeySchemaListValue in requestObject.KeySchema)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = KeySchemaElementMarshaller.Instance;
                    marshaller.Marshall(requestObjectKeySchemaListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetOnDemandThroughput())
            {
                context.Writer.WritePropertyName("OnDemandThroughput");
                context.Writer.WriteStartObject();

                var marshaller = OnDemandThroughputMarshaller.Instance;
                marshaller.Marshall(requestObject.OnDemandThroughput, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetProvisionedThroughput())
            {
                context.Writer.WritePropertyName("ProvisionedThroughput");
                context.Writer.WriteStartObject();

                var marshaller = ProvisionedThroughputMarshaller.Instance;
                marshaller.Marshall(requestObject.ProvisionedThroughput, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSSESpecification())
            {
                context.Writer.WritePropertyName("SSESpecification");
                context.Writer.WriteStartObject();

                var marshaller = SSESpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.SSESpecification, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTableName())
            {
                context.Writer.WritePropertyName("TableName");
                context.Writer.WriteStringValue(requestObject.TableName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TableCreationParametersMarshaller Instance = new TableCreationParametersMarshaller();

    }
}