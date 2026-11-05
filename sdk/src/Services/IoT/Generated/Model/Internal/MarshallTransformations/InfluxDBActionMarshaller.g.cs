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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.IoT.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InfluxDBAction Marshaller
    /// </summary>
    public partial class InfluxDBActionMarshaller : IRequestMarshaller<InfluxDBAction, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(InfluxDBAction requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetBatchConfig())
            {
                context.Writer.WritePropertyName("batchConfig");
                context.Writer.WriteStartObject();

                var marshaller = InfluxDBBatchConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.BatchConfig, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("databaseName");
                context.Writer.WriteStringValue(requestObject.DatabaseName);
            }

            if (requestObject.IsSetDestinationArn())
            {
                context.Writer.WritePropertyName("destinationArn");
                context.Writer.WriteStringValue(requestObject.DestinationArn);
            }

            if (requestObject.IsSetOrganization())
            {
                context.Writer.WritePropertyName("organization");
                context.Writer.WriteStringValue(requestObject.Organization);
            }

            if (requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

            if (requestObject.IsSetTableName())
            {
                context.Writer.WritePropertyName("tableName");
                context.Writer.WriteStringValue(requestObject.TableName);
            }

            if (requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var requestObjectTagsKvp in requestObject.Tags)
                {
                    context.Writer.WritePropertyName(requestObjectTagsKvp.Key);
                    var requestObjectTagsValue = requestObjectTagsKvp.Value;
                    context.Writer.WriteStringValue(requestObjectTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetTimestampUnit())
            {
                context.Writer.WritePropertyName("timestampUnit");
                context.Writer.WriteStringValue(requestObject.TimestampUnit);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static InfluxDBActionMarshaller Instance = new InfluxDBActionMarshaller();
    }
}
