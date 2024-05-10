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
    /// EncryptionDecryptionAttributes Marshaller
    /// </summary>
    public class EncryptionDecryptionAttributesMarshaller : IRequestMarshaller<EncryptionDecryptionAttributes, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EncryptionDecryptionAttributes requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAsymmetric())
            {
                context.Writer.WritePropertyName("Asymmetric");
                context.Writer.WriteObjectStart();

                var marshaller = AsymmetricEncryptionAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.Asymmetric, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDukpt())
            {
                context.Writer.WritePropertyName("Dukpt");
                context.Writer.WriteObjectStart();

                var marshaller = DukptEncryptionAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.Dukpt, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEmv())
            {
                context.Writer.WritePropertyName("Emv");
                context.Writer.WriteObjectStart();

                var marshaller = EmvEncryptionAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.Emv, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSymmetric())
            {
                context.Writer.WritePropertyName("Symmetric");
                context.Writer.WriteObjectStart();

                var marshaller = SymmetricEncryptionAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.Symmetric, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EncryptionDecryptionAttributesMarshaller Instance = new EncryptionDecryptionAttributesMarshaller();

    }
}