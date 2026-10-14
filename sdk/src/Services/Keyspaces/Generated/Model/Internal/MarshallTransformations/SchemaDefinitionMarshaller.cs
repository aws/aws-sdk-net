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
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.Keyspaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SchemaDefinition Marshaller
    /// </summary>
    public class SchemaDefinitionMarshaller : IRequestMarshaller<SchemaDefinition, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SchemaDefinition requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetAllColumns())
            {
                context.Writer.WriteTextString("allColumns");
                context.Writer.WriteStartArray(requestObject.AllColumns.Count);
                foreach(var requestObjectAllColumnsListValue in requestObject.AllColumns)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = ColumnDefinitionMarshaller.Instance;
                    marshaller.Marshall(requestObjectAllColumnsListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetClusteringKeys())
            {
                context.Writer.WriteTextString("clusteringKeys");
                context.Writer.WriteStartArray(requestObject.ClusteringKeys.Count);
                foreach(var requestObjectClusteringKeysListValue in requestObject.ClusteringKeys)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = ClusteringKeyMarshaller.Instance;
                    marshaller.Marshall(requestObjectClusteringKeysListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetPartitionKeys())
            {
                context.Writer.WriteTextString("partitionKeys");
                context.Writer.WriteStartArray(requestObject.PartitionKeys.Count);
                foreach(var requestObjectPartitionKeysListValue in requestObject.PartitionKeys)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = PartitionKeyMarshaller.Instance;
                    marshaller.Marshall(requestObjectPartitionKeysListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetStaticColumns())
            {
                context.Writer.WriteTextString("staticColumns");
                context.Writer.WriteStartArray(requestObject.StaticColumns.Count);
                foreach(var requestObjectStaticColumnsListValue in requestObject.StaticColumns)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = StaticColumnMarshaller.Instance;
                    marshaller.Marshall(requestObjectStaticColumnsListValue, context);

                    context.Writer.WriteEndMap();
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