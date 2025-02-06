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
 * Do not modify this file. This file is generated from the payment-cryptography-data-2022-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PaymentCryptographyData.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.PaymentCryptographyData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DynamicCardVerificationValue Marshaller
    /// </summary>
    public class DynamicCardVerificationValueMarshaller : IRequestMarshaller<DynamicCardVerificationValue, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DynamicCardVerificationValue requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetApplicationTransactionCounter())
            {
                context.Writer.WritePropertyName("ApplicationTransactionCounter");
                context.Writer.WriteStringValue(requestObject.ApplicationTransactionCounter);
            }

            if(requestObject.IsSetCardExpiryDate())
            {
                context.Writer.WritePropertyName("CardExpiryDate");
                context.Writer.WriteStringValue(requestObject.CardExpiryDate);
            }

            if(requestObject.IsSetPanSequenceNumber())
            {
                context.Writer.WritePropertyName("PanSequenceNumber");
                context.Writer.WriteStringValue(requestObject.PanSequenceNumber);
            }

            if(requestObject.IsSetServiceCode())
            {
                context.Writer.WritePropertyName("ServiceCode");
                context.Writer.WriteStringValue(requestObject.ServiceCode);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DynamicCardVerificationValueMarshaller Instance = new DynamicCardVerificationValueMarshaller();

    }
}