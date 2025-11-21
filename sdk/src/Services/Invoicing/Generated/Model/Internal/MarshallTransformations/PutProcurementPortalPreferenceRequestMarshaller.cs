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
    /// PutProcurementPortalPreference Request Marshaller
    /// </summary>       
    public class PutProcurementPortalPreferenceRequestMarshaller : IMarshaller<IRequest, PutProcurementPortalPreferenceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutProcurementPortalPreferenceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutProcurementPortalPreferenceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Invoicing");
            string target = "Invoicing.PutProcurementPortalPreference";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-12-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetContacts())
                {
                    context.Writer.WritePropertyName("Contacts");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestContactsListValue in publicRequest.Contacts)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ContactMarshaller.Instance;
                        marshaller.Marshall(publicRequestContactsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetEinvoiceDeliveryEnabled())
                {
                    context.Writer.WritePropertyName("EinvoiceDeliveryEnabled");
                    context.Writer.Write(publicRequest.EinvoiceDeliveryEnabled);
                }

                if(publicRequest.IsSetEinvoiceDeliveryPreference())
                {
                    context.Writer.WritePropertyName("EinvoiceDeliveryPreference");
                    context.Writer.WriteObjectStart();

                    var marshaller = EinvoiceDeliveryPreferenceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EinvoiceDeliveryPreference, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetProcurementPortalInstanceEndpoint())
                {
                    context.Writer.WritePropertyName("ProcurementPortalInstanceEndpoint");
                    context.Writer.Write(publicRequest.ProcurementPortalInstanceEndpoint);
                }

                if(publicRequest.IsSetProcurementPortalPreferenceArn())
                {
                    context.Writer.WritePropertyName("ProcurementPortalPreferenceArn");
                    context.Writer.Write(publicRequest.ProcurementPortalPreferenceArn);
                }

                if(publicRequest.IsSetProcurementPortalSharedSecret())
                {
                    context.Writer.WritePropertyName("ProcurementPortalSharedSecret");
                    context.Writer.Write(publicRequest.ProcurementPortalSharedSecret);
                }

                if(publicRequest.IsSetPurchaseOrderRetrievalEnabled())
                {
                    context.Writer.WritePropertyName("PurchaseOrderRetrievalEnabled");
                    context.Writer.Write(publicRequest.PurchaseOrderRetrievalEnabled);
                }

                if(publicRequest.IsSetSelector())
                {
                    context.Writer.WritePropertyName("Selector");
                    context.Writer.WriteObjectStart();

                    var marshaller = ProcurementPortalPreferenceSelectorMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Selector, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTestEnvPreference())
                {
                    context.Writer.WritePropertyName("TestEnvPreference");
                    context.Writer.WriteObjectStart();

                    var marshaller = TestEnvPreferenceInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TestEnvPreference, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutProcurementPortalPreferenceRequestMarshaller _instance = new PutProcurementPortalPreferenceRequestMarshaller();        

        internal static PutProcurementPortalPreferenceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutProcurementPortalPreferenceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}