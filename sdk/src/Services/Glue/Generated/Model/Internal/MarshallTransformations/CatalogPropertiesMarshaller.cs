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
    /// CatalogProperties Marshaller
    /// </summary>
    public class CatalogPropertiesMarshaller : IRequestMarshaller<CatalogProperties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CatalogProperties requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCustomProperties())
            {
                context.Writer.WritePropertyName("CustomProperties");
                context.Writer.WriteStartObject();
                foreach (var requestObjectCustomPropertiesKvp in requestObject.CustomProperties)
                {
                    context.Writer.WritePropertyName(requestObjectCustomPropertiesKvp.Key);
                    var requestObjectCustomPropertiesValue = requestObjectCustomPropertiesKvp.Value;

                        context.Writer.WriteStringValue(requestObjectCustomPropertiesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDataLakeAccessProperties())
            {
                context.Writer.WritePropertyName("DataLakeAccessProperties");
                context.Writer.WriteStartObject();

                var marshaller = DataLakeAccessPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.DataLakeAccessProperties, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIcebergOptimizationProperties())
            {
                context.Writer.WritePropertyName("IcebergOptimizationProperties");
                context.Writer.WriteStartObject();

                var marshaller = IcebergOptimizationPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.IcebergOptimizationProperties, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CatalogPropertiesMarshaller Instance = new CatalogPropertiesMarshaller();

    }
}