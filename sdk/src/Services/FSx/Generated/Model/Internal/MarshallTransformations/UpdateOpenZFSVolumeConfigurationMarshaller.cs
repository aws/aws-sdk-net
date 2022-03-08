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
using ThirdParty.Json.LitJson;

namespace Amazon.FSx.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateOpenZFSVolumeConfiguration Marshaller
    /// </summary>
    public class UpdateOpenZFSVolumeConfigurationMarshaller : IRequestMarshaller<UpdateOpenZFSVolumeConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdateOpenZFSVolumeConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDataCompressionType())
            {
                context.Writer.WritePropertyName("DataCompressionType");
                context.Writer.Write(requestObject.DataCompressionType);
            }

            if(requestObject.IsSetNfsExports())
            {
                context.Writer.WritePropertyName("NfsExports");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNfsExportsListValue in requestObject.NfsExports)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = OpenZFSNfsExportMarshaller.Instance;
                    marshaller.Marshall(requestObjectNfsExportsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetReadOnly())
            {
                context.Writer.WritePropertyName("ReadOnly");
                context.Writer.Write(requestObject.ReadOnly);
            }

            if(requestObject.IsSetRecordSizeKiB())
            {
                context.Writer.WritePropertyName("RecordSizeKiB");
                context.Writer.Write(requestObject.RecordSizeKiB);
            }

            if(requestObject.IsSetStorageCapacityQuotaGiB())
            {
                context.Writer.WritePropertyName("StorageCapacityQuotaGiB");
                context.Writer.Write(requestObject.StorageCapacityQuotaGiB);
            }

            if(requestObject.IsSetStorageCapacityReservationGiB())
            {
                context.Writer.WritePropertyName("StorageCapacityReservationGiB");
                context.Writer.Write(requestObject.StorageCapacityReservationGiB);
            }

            if(requestObject.IsSetUserAndGroupQuotas())
            {
                context.Writer.WritePropertyName("UserAndGroupQuotas");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectUserAndGroupQuotasListValue in requestObject.UserAndGroupQuotas)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = OpenZFSUserOrGroupQuotaMarshaller.Instance;
                    marshaller.Marshall(requestObjectUserAndGroupQuotasListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdateOpenZFSVolumeConfigurationMarshaller Instance = new UpdateOpenZFSVolumeConfigurationMarshaller();

    }
}