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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Invoicing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EinvoiceDeliveryPreference Marshaller
    /// </summary>
    public class EinvoiceDeliveryPreferenceMarshaller : IRequestMarshaller<EinvoiceDeliveryPreference, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EinvoiceDeliveryPreference requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConnectionTestingMethod())
            {
                context.Writer.WritePropertyName("ConnectionTestingMethod");
                context.Writer.Write(requestObject.ConnectionTestingMethod);
            }

            if(requestObject.IsSetEinvoiceDeliveryActivationDate())
            {
                context.Writer.WritePropertyName("EinvoiceDeliveryActivationDate");
                context.Writer.Write(requestObject.EinvoiceDeliveryActivationDate);
            }

            if(requestObject.IsSetEinvoiceDeliveryAttachmentTypes())
            {
                context.Writer.WritePropertyName("EinvoiceDeliveryAttachmentTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEinvoiceDeliveryAttachmentTypesListValue in requestObject.EinvoiceDeliveryAttachmentTypes)
                {
                        context.Writer.Write(requestObjectEinvoiceDeliveryAttachmentTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEinvoiceDeliveryDocumentTypes())
            {
                context.Writer.WritePropertyName("EinvoiceDeliveryDocumentTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEinvoiceDeliveryDocumentTypesListValue in requestObject.EinvoiceDeliveryDocumentTypes)
                {
                        context.Writer.Write(requestObjectEinvoiceDeliveryDocumentTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetProtocol())
            {
                context.Writer.WritePropertyName("Protocol");
                context.Writer.Write(requestObject.Protocol);
            }

            if(requestObject.IsSetPurchaseOrderDataSources())
            {
                context.Writer.WritePropertyName("PurchaseOrderDataSources");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPurchaseOrderDataSourcesListValue in requestObject.PurchaseOrderDataSources)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = PurchaseOrderDataSourceMarshaller.Instance;
                    marshaller.Marshall(requestObjectPurchaseOrderDataSourcesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EinvoiceDeliveryPreferenceMarshaller Instance = new EinvoiceDeliveryPreferenceMarshaller();

    }
}