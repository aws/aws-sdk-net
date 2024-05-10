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
    /// PinGenerationAttributes Marshaller
    /// </summary>
    public class PinGenerationAttributesMarshaller : IRequestMarshaller<PinGenerationAttributes, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PinGenerationAttributes requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetIbm3624NaturalPin())
            {
                context.Writer.WritePropertyName("Ibm3624NaturalPin");
                context.Writer.WriteObjectStart();

                var marshaller = Ibm3624NaturalPinMarshaller.Instance;
                marshaller.Marshall(requestObject.Ibm3624NaturalPin, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIbm3624PinFromOffset())
            {
                context.Writer.WritePropertyName("Ibm3624PinFromOffset");
                context.Writer.WriteObjectStart();

                var marshaller = Ibm3624PinFromOffsetMarshaller.Instance;
                marshaller.Marshall(requestObject.Ibm3624PinFromOffset, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIbm3624PinOffset())
            {
                context.Writer.WritePropertyName("Ibm3624PinOffset");
                context.Writer.WriteObjectStart();

                var marshaller = Ibm3624PinOffsetMarshaller.Instance;
                marshaller.Marshall(requestObject.Ibm3624PinOffset, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIbm3624RandomPin())
            {
                context.Writer.WritePropertyName("Ibm3624RandomPin");
                context.Writer.WriteObjectStart();

                var marshaller = Ibm3624RandomPinMarshaller.Instance;
                marshaller.Marshall(requestObject.Ibm3624RandomPin, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVisaPin())
            {
                context.Writer.WritePropertyName("VisaPin");
                context.Writer.WriteObjectStart();

                var marshaller = VisaPinMarshaller.Instance;
                marshaller.Marshall(requestObject.VisaPin, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVisaPinVerificationValue())
            {
                context.Writer.WritePropertyName("VisaPinVerificationValue");
                context.Writer.WriteObjectStart();

                var marshaller = VisaPinVerificationValueMarshaller.Instance;
                marshaller.Marshall(requestObject.VisaPinVerificationValue, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PinGenerationAttributesMarshaller Instance = new PinGenerationAttributesMarshaller();

    }
}