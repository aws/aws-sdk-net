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
    /// DataLakeAccessProperties Marshaller
    /// </summary>
    public class DataLakeAccessPropertiesMarshaller : IRequestMarshaller<DataLakeAccessProperties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DataLakeAccessProperties requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCatalogType())
            {
                context.Writer.WritePropertyName("CatalogType");
                context.Writer.WriteStringValue(requestObject.CatalogType);
            }

            if(requestObject.IsSetDataLakeAccess())
            {
                context.Writer.WritePropertyName("DataLakeAccess");
                context.Writer.WriteBooleanValue(requestObject.DataLakeAccess.Value);
            }

            if(requestObject.IsSetDataTransferRole())
            {
                context.Writer.WritePropertyName("DataTransferRole");
                context.Writer.WriteStringValue(requestObject.DataTransferRole);
            }

            if(requestObject.IsSetKmsKey())
            {
                context.Writer.WritePropertyName("KmsKey");
                context.Writer.WriteStringValue(requestObject.KmsKey);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DataLakeAccessPropertiesMarshaller Instance = new DataLakeAccessPropertiesMarshaller();

    }
}