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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LicenseManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.LicenseManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ProductInformationFilter Marshaller
    /// </summary>
    public class ProductInformationFilterMarshaller : IRequestMarshaller<ProductInformationFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ProductInformationFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetProductInformationFilterComparator())
            {
                context.Writer.WritePropertyName("ProductInformationFilterComparator");
                context.Writer.WriteStringValue(requestObject.ProductInformationFilterComparator);
            }

            if(requestObject.IsSetProductInformationFilterName())
            {
                context.Writer.WritePropertyName("ProductInformationFilterName");
                context.Writer.WriteStringValue(requestObject.ProductInformationFilterName);
            }

            if(requestObject.IsSetProductInformationFilterValue())
            {
                context.Writer.WritePropertyName("ProductInformationFilterValue");
                context.Writer.WriteStartArray();
                foreach(var requestObjectProductInformationFilterValueListValue in requestObject.ProductInformationFilterValue)
                {
                        context.Writer.WriteStringValue(requestObjectProductInformationFilterValueListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ProductInformationFilterMarshaller Instance = new ProductInformationFilterMarshaller();

    }
}