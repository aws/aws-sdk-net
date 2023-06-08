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

namespace Amazon.PaymentCryptographyData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SessionKeyDerivation Marshaller
    /// </summary>
    public class SessionKeyDerivationMarshaller : IRequestMarshaller<SessionKeyDerivation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SessionKeyDerivation requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAmex())
            {
                context.Writer.WritePropertyName("Amex");
                context.Writer.WriteObjectStart();

                var marshaller = SessionKeyAmexMarshaller.Instance;
                marshaller.Marshall(requestObject.Amex, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEmv2000())
            {
                context.Writer.WritePropertyName("Emv2000");
                context.Writer.WriteObjectStart();

                var marshaller = SessionKeyEmv2000Marshaller.Instance;
                marshaller.Marshall(requestObject.Emv2000, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEmvCommon())
            {
                context.Writer.WritePropertyName("EmvCommon");
                context.Writer.WriteObjectStart();

                var marshaller = SessionKeyEmvCommonMarshaller.Instance;
                marshaller.Marshall(requestObject.EmvCommon, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMastercard())
            {
                context.Writer.WritePropertyName("Mastercard");
                context.Writer.WriteObjectStart();

                var marshaller = SessionKeyMastercardMarshaller.Instance;
                marshaller.Marshall(requestObject.Mastercard, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVisa())
            {
                context.Writer.WritePropertyName("Visa");
                context.Writer.WriteObjectStart();

                var marshaller = SessionKeyVisaMarshaller.Instance;
                marshaller.Marshall(requestObject.Visa, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SessionKeyDerivationMarshaller Instance = new SessionKeyDerivationMarshaller();

    }
}