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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kafka.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Kafka.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// IcebergDestinationConfiguration Marshaller
    /// </summary>
    public class IcebergDestinationConfigurationMarshaller : IRequestMarshaller<IcebergDestinationConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(IcebergDestinationConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAppendOnly())
            {
                context.Writer.WritePropertyName("appendOnly");
                context.Writer.WriteBooleanValue(requestObject.AppendOnly.Value);
            }

            if(requestObject.IsSetCatalog())
            {
                context.Writer.WritePropertyName("catalog");
                context.Writer.WriteStartObject();

                var marshaller = CatalogMarshaller.Instance;
                marshaller.Marshall(requestObject.Catalog, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCompressionType())
            {
                context.Writer.WritePropertyName("compressionType");
                context.Writer.WriteStringValue(requestObject.CompressionType);
            }

            if(requestObject.IsSetDataFreshnessInSeconds())
            {
                context.Writer.WritePropertyName("dataFreshnessInSeconds");
                context.Writer.WriteNumberValue(requestObject.DataFreshnessInSeconds.Value);
            }

            if(requestObject.IsSetDeadLetterQueueS3())
            {
                context.Writer.WritePropertyName("deadLetterQueueS3");
                context.Writer.WriteStartObject();

                var marshaller = DeadLetterQueueS3Marshaller.Instance;
                marshaller.Marshall(requestObject.DeadLetterQueueS3, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDestinationTableList())
            {
                context.Writer.WritePropertyName("destinationTableList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDestinationTableListListValue in requestObject.DestinationTableList)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DestinationTableMarshaller.Instance;
                    marshaller.Marshall(requestObjectDestinationTableListListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSchemaEvolution())
            {
                context.Writer.WritePropertyName("schemaEvolution");
                context.Writer.WriteStartObject();

                var marshaller = SchemaEvolutionMarshaller.Instance;
                marshaller.Marshall(requestObject.SchemaEvolution, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetServiceExecutionRoleArn())
            {
                context.Writer.WritePropertyName("serviceExecutionRoleArn");
                context.Writer.WriteStringValue(requestObject.ServiceExecutionRoleArn);
            }

            if(requestObject.IsSetTableCreation())
            {
                context.Writer.WritePropertyName("tableCreation");
                context.Writer.WriteStartObject();

                var marshaller = TableCreationMarshaller.Instance;
                marshaller.Marshall(requestObject.TableCreation, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static IcebergDestinationConfigurationMarshaller Instance = new IcebergDestinationConfigurationMarshaller();

    }
}