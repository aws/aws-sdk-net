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

using Amazon.S3Tables.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.S3Tables.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DestinationTable Marshaller
    /// </summary>
    public partial class DestinationTableMarshaller : IRequestMarshaller<DestinationTable, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(DestinationTable requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetEncryptionConfiguration())
            {
                context.Writer.WritePropertyName("encryptionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = EncryptionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.EncryptionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetIcebergSortOrder())
            {
                context.Writer.WritePropertyName("icebergSortOrder");
                context.Writer.WriteStartObject();

                var marshaller = IcebergSortOrderMarshaller.Instance;
                marshaller.Marshall(requestObject.IcebergSortOrder, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if (requestObject.IsSetNamespace())
            {
                context.Writer.WritePropertyName("namespace");
                context.Writer.WriteStringValue(requestObject.Namespace);
            }

            if (requestObject.IsSetProperties())
            {
                context.Writer.WritePropertyName("properties");
                context.Writer.WriteStartObject();

                var marshaller = MigrationTablePropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.Properties, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetSchema())
            {
                context.Writer.WritePropertyName("schema");
                context.Writer.WriteStartObject();

                var marshaller = IcebergSchemaV2Marshaller.Instance;
                marshaller.Marshall(requestObject.Schema, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetStorageClassConfiguration())
            {
                context.Writer.WritePropertyName("storageClassConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = StorageClassConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.StorageClassConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetTableBucketARN())
            {
                context.Writer.WritePropertyName("tableBucketARN");
                context.Writer.WriteStringValue(requestObject.TableBucketARN);
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
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static DestinationTableMarshaller Instance = new DestinationTableMarshaller();
    }
}
