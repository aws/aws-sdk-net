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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MainframeModernization.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MainframeModernization.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DataSet Marshaller
    /// </summary>
    public class DataSetMarshaller : IRequestMarshaller<DataSet, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DataSet requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDatasetName())
            {
                context.Writer.WritePropertyName("datasetName");
                context.Writer.WriteStringValue(requestObject.DatasetName);
            }

            if(requestObject.IsSetDatasetOrg())
            {
                context.Writer.WritePropertyName("datasetOrg");
                context.Writer.WriteStartObject();

                var marshaller = DatasetOrgAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.DatasetOrg, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRecordLength())
            {
                context.Writer.WritePropertyName("recordLength");
                context.Writer.WriteStartObject();

                var marshaller = RecordLengthMarshaller.Instance;
                marshaller.Marshall(requestObject.RecordLength, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRelativePath())
            {
                context.Writer.WritePropertyName("relativePath");
                context.Writer.WriteStringValue(requestObject.RelativePath);
            }

            if(requestObject.IsSetStorageType())
            {
                context.Writer.WritePropertyName("storageType");
                context.Writer.WriteStringValue(requestObject.StorageType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DataSetMarshaller Instance = new DataSetMarshaller();

    }
}