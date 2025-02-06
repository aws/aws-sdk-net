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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TableInput Marshaller
    /// </summary>
    public class TableInputMarshaller : IRequestMarshaller<TableInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TableInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetLastAccessTime())
            {
                context.Writer.WritePropertyName("LastAccessTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.LastAccessTime.Value)));
            }

            if(requestObject.IsSetLastAnalyzedTime())
            {
                context.Writer.WritePropertyName("LastAnalyzedTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.LastAnalyzedTime.Value)));
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetOwner())
            {
                context.Writer.WritePropertyName("Owner");
                context.Writer.WriteStringValue(requestObject.Owner);
            }

            if(requestObject.IsSetParameters())
            {
                context.Writer.WritePropertyName("Parameters");
                context.Writer.WriteStartObject();
                foreach (var requestObjectParametersKvp in requestObject.Parameters)
                {
                    context.Writer.WritePropertyName(requestObjectParametersKvp.Key);
                    var requestObjectParametersValue = requestObjectParametersKvp.Value;

                        context.Writer.WriteStringValue(requestObjectParametersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPartitionKeys())
            {
                context.Writer.WritePropertyName("PartitionKeys");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPartitionKeysListValue in requestObject.PartitionKeys)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ColumnMarshaller.Instance;
                    marshaller.Marshall(requestObjectPartitionKeysListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRetention())
            {
                context.Writer.WritePropertyName("Retention");
                context.Writer.WriteNumberValue(requestObject.Retention.Value);
            }

            if(requestObject.IsSetStorageDescriptor())
            {
                context.Writer.WritePropertyName("StorageDescriptor");
                context.Writer.WriteStartObject();

                var marshaller = StorageDescriptorMarshaller.Instance;
                marshaller.Marshall(requestObject.StorageDescriptor, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTableType())
            {
                context.Writer.WritePropertyName("TableType");
                context.Writer.WriteStringValue(requestObject.TableType);
            }

            if(requestObject.IsSetTargetTable())
            {
                context.Writer.WritePropertyName("TargetTable");
                context.Writer.WriteStartObject();

                var marshaller = TableIdentifierMarshaller.Instance;
                marshaller.Marshall(requestObject.TargetTable, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetViewDefinition())
            {
                context.Writer.WritePropertyName("ViewDefinition");
                context.Writer.WriteStartObject();

                var marshaller = ViewDefinitionInputMarshaller.Instance;
                marshaller.Marshall(requestObject.ViewDefinition, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetViewExpandedText())
            {
                context.Writer.WritePropertyName("ViewExpandedText");
                context.Writer.WriteStringValue(requestObject.ViewExpandedText);
            }

            if(requestObject.IsSetViewOriginalText())
            {
                context.Writer.WritePropertyName("ViewOriginalText");
                context.Writer.WriteStringValue(requestObject.ViewOriginalText);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TableInputMarshaller Instance = new TableInputMarshaller();

    }
}