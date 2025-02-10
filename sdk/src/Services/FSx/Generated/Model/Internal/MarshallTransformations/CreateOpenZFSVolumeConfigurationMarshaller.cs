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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FSx.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.FSx.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateOpenZFSVolumeConfiguration Marshaller
    /// </summary>
    public class CreateOpenZFSVolumeConfigurationMarshaller : IRequestMarshaller<CreateOpenZFSVolumeConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateOpenZFSVolumeConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCopyTagsToSnapshots())
            {
                context.Writer.WritePropertyName("CopyTagsToSnapshots");
                context.Writer.WriteBooleanValue(requestObject.CopyTagsToSnapshots.Value);
            }

            if(requestObject.IsSetDataCompressionType())
            {
                context.Writer.WritePropertyName("DataCompressionType");
                context.Writer.WriteStringValue(requestObject.DataCompressionType);
            }

            if(requestObject.IsSetNfsExports())
            {
                context.Writer.WritePropertyName("NfsExports");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNfsExportsListValue in requestObject.NfsExports)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = OpenZFSNfsExportMarshaller.Instance;
                    marshaller.Marshall(requestObjectNfsExportsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetOriginSnapshot())
            {
                context.Writer.WritePropertyName("OriginSnapshot");
                context.Writer.WriteStartObject();

                var marshaller = CreateOpenZFSOriginSnapshotConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.OriginSnapshot, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetParentVolumeId())
            {
                context.Writer.WritePropertyName("ParentVolumeId");
                context.Writer.WriteStringValue(requestObject.ParentVolumeId);
            }

            if(requestObject.IsSetReadOnly())
            {
                context.Writer.WritePropertyName("ReadOnly");
                context.Writer.WriteBooleanValue(requestObject.ReadOnly.Value);
            }

            if(requestObject.IsSetRecordSizeKiB())
            {
                context.Writer.WritePropertyName("RecordSizeKiB");
                context.Writer.WriteNumberValue(requestObject.RecordSizeKiB.Value);
            }

            if(requestObject.IsSetStorageCapacityQuotaGiB())
            {
                context.Writer.WritePropertyName("StorageCapacityQuotaGiB");
                context.Writer.WriteNumberValue(requestObject.StorageCapacityQuotaGiB.Value);
            }

            if(requestObject.IsSetStorageCapacityReservationGiB())
            {
                context.Writer.WritePropertyName("StorageCapacityReservationGiB");
                context.Writer.WriteNumberValue(requestObject.StorageCapacityReservationGiB.Value);
            }

            if(requestObject.IsSetUserAndGroupQuotas())
            {
                context.Writer.WritePropertyName("UserAndGroupQuotas");
                context.Writer.WriteStartArray();
                foreach(var requestObjectUserAndGroupQuotasListValue in requestObject.UserAndGroupQuotas)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = OpenZFSUserOrGroupQuotaMarshaller.Instance;
                    marshaller.Marshall(requestObjectUserAndGroupQuotasListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CreateOpenZFSVolumeConfigurationMarshaller Instance = new CreateOpenZFSVolumeConfigurationMarshaller();

    }
}