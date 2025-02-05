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
using System.Text;
using System.Xml.Serialization;

using Amazon.Keyspaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Keyspaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SchemaDefinition Marshaller
    /// </summary>
    public class SchemaDefinitionMarshaller : IRequestMarshaller<SchemaDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SchemaDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllColumns())
            {
                context.Writer.WritePropertyName("allColumns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAllColumnsListValue in requestObject.AllColumns)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ColumnDefinitionMarshaller.Instance;
                    marshaller.Marshall(requestObjectAllColumnsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetClusteringKeys())
            {
                context.Writer.WritePropertyName("clusteringKeys");
                context.Writer.WriteStartArray();
                foreach(var requestObjectClusteringKeysListValue in requestObject.ClusteringKeys)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ClusteringKeyMarshaller.Instance;
                    marshaller.Marshall(requestObjectClusteringKeysListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPartitionKeys())
            {
                context.Writer.WritePropertyName("partitionKeys");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPartitionKeysListValue in requestObject.PartitionKeys)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PartitionKeyMarshaller.Instance;
                    marshaller.Marshall(requestObjectPartitionKeysListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStaticColumns())
            {
                context.Writer.WritePropertyName("staticColumns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStaticColumnsListValue in requestObject.StaticColumns)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StaticColumnMarshaller.Instance;
                    marshaller.Marshall(requestObjectStaticColumnsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SchemaDefinitionMarshaller Instance = new SchemaDefinitionMarshaller();

    }
}