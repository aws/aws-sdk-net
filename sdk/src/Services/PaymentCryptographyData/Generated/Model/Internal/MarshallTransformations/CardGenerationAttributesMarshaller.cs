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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PaymentCryptographyData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CardGenerationAttributes Marshaller
    /// </summary>
    public class CardGenerationAttributesMarshaller : IRequestMarshaller<CardGenerationAttributes, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CardGenerationAttributes requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAmexCardSecurityCodeVersion1())
            {
                context.Writer.WritePropertyName("AmexCardSecurityCodeVersion1");
                context.Writer.WriteObjectStart();

                var marshaller = AmexCardSecurityCodeVersion1Marshaller.Instance;
                marshaller.Marshall(requestObject.AmexCardSecurityCodeVersion1, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAmexCardSecurityCodeVersion2())
            {
                context.Writer.WritePropertyName("AmexCardSecurityCodeVersion2");
                context.Writer.WriteObjectStart();

                var marshaller = AmexCardSecurityCodeVersion2Marshaller.Instance;
                marshaller.Marshall(requestObject.AmexCardSecurityCodeVersion2, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCardHolderVerificationValue())
            {
                context.Writer.WritePropertyName("CardHolderVerificationValue");
                context.Writer.WriteObjectStart();

                var marshaller = CardHolderVerificationValueMarshaller.Instance;
                marshaller.Marshall(requestObject.CardHolderVerificationValue, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCardVerificationValue1())
            {
                context.Writer.WritePropertyName("CardVerificationValue1");
                context.Writer.WriteObjectStart();

                var marshaller = CardVerificationValue1Marshaller.Instance;
                marshaller.Marshall(requestObject.CardVerificationValue1, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCardVerificationValue2())
            {
                context.Writer.WritePropertyName("CardVerificationValue2");
                context.Writer.WriteObjectStart();

                var marshaller = CardVerificationValue2Marshaller.Instance;
                marshaller.Marshall(requestObject.CardVerificationValue2, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDynamicCardVerificationCode())
            {
                context.Writer.WritePropertyName("DynamicCardVerificationCode");
                context.Writer.WriteObjectStart();

                var marshaller = DynamicCardVerificationCodeMarshaller.Instance;
                marshaller.Marshall(requestObject.DynamicCardVerificationCode, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDynamicCardVerificationValue())
            {
                context.Writer.WritePropertyName("DynamicCardVerificationValue");
                context.Writer.WriteObjectStart();

                var marshaller = DynamicCardVerificationValueMarshaller.Instance;
                marshaller.Marshall(requestObject.DynamicCardVerificationValue, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CardGenerationAttributesMarshaller Instance = new CardGenerationAttributesMarshaller();

    }
}