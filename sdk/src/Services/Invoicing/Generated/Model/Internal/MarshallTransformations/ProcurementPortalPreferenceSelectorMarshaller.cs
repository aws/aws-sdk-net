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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Invoicing.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Invoicing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ProcurementPortalPreferenceSelector Marshaller
    /// </summary>
    public class ProcurementPortalPreferenceSelectorMarshaller : IRequestMarshaller<ProcurementPortalPreferenceSelector, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ProcurementPortalPreferenceSelector requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetInvoiceUnitArns())
            {
                context.Writer.WritePropertyName("InvoiceUnitArns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInvoiceUnitArnsListValue in requestObject.InvoiceUnitArns)
                {
                        context.Writer.WriteStringValue(requestObjectInvoiceUnitArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSellerOfRecords())
            {
                context.Writer.WritePropertyName("SellerOfRecords");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSellerOfRecordsListValue in requestObject.SellerOfRecords)
                {
                        context.Writer.WriteStringValue(requestObjectSellerOfRecordsListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ProcurementPortalPreferenceSelectorMarshaller Instance = new ProcurementPortalPreferenceSelectorMarshaller();

    }
}