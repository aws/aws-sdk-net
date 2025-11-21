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
using System.Net;
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
    /// Response Unmarshaller for ProcurementPortalPreference Object
    /// </summary>  
    public class ProcurementPortalPreferenceUnmarshaller : IUnmarshaller<ProcurementPortalPreference, XmlUnmarshallerContext>, IUnmarshaller<ProcurementPortalPreference, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ProcurementPortalPreference IUnmarshaller<ProcurementPortalPreference, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ProcurementPortalPreference Unmarshall(JsonUnmarshallerContext context)
        {
            ProcurementPortalPreference unmarshalledObject = new ProcurementPortalPreference();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AwsAccountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AwsAccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BuyerDomain", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BuyerDomain = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BuyerIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BuyerIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Contacts", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Contact, ContactUnmarshaller>(ContactUnmarshaller.Instance);
                    unmarshalledObject.Contacts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreateDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EinvoiceDeliveryEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EinvoiceDeliveryEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EinvoiceDeliveryPreference", targetDepth))
                {
                    var unmarshaller = EinvoiceDeliveryPreferenceUnmarshaller.Instance;
                    unmarshalledObject.EinvoiceDeliveryPreference = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EinvoiceDeliveryPreferenceStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EinvoiceDeliveryPreferenceStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EinvoiceDeliveryPreferenceStatusReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EinvoiceDeliveryPreferenceStatusReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastUpdateDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdateDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProcurementPortalInstanceEndpoint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProcurementPortalInstanceEndpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProcurementPortalName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProcurementPortalName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProcurementPortalPreferenceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProcurementPortalPreferenceArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProcurementPortalSharedSecret", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProcurementPortalSharedSecret = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PurchaseOrderRetrievalEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.PurchaseOrderRetrievalEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PurchaseOrderRetrievalEndpoint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PurchaseOrderRetrievalEndpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PurchaseOrderRetrievalPreferenceStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PurchaseOrderRetrievalPreferenceStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PurchaseOrderRetrievalPreferenceStatusReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PurchaseOrderRetrievalPreferenceStatusReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Selector", targetDepth))
                {
                    var unmarshaller = ProcurementPortalPreferenceSelectorUnmarshaller.Instance;
                    unmarshalledObject.Selector = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SupplierDomain", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SupplierDomain = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SupplierIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SupplierIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TestEnvPreference", targetDepth))
                {
                    var unmarshaller = TestEnvPreferenceUnmarshaller.Instance;
                    unmarshalledObject.TestEnvPreference = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Version", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Version = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ProcurementPortalPreferenceUnmarshaller _instance = new ProcurementPortalPreferenceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ProcurementPortalPreferenceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}