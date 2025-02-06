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
 * Do not modify this file. This file is generated from the payment-cryptography-2021-09-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PaymentCryptography.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.PaymentCryptography.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// KeyModesOfUse Marshaller
    /// </summary>
    public class KeyModesOfUseMarshaller : IRequestMarshaller<KeyModesOfUse, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(KeyModesOfUse requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDecrypt())
            {
                context.Writer.WritePropertyName("Decrypt");
                context.Writer.WriteBooleanValue(requestObject.Decrypt.Value);
            }

            if(requestObject.IsSetDeriveKey())
            {
                context.Writer.WritePropertyName("DeriveKey");
                context.Writer.WriteBooleanValue(requestObject.DeriveKey.Value);
            }

            if(requestObject.IsSetEncrypt())
            {
                context.Writer.WritePropertyName("Encrypt");
                context.Writer.WriteBooleanValue(requestObject.Encrypt.Value);
            }

            if(requestObject.IsSetGenerate())
            {
                context.Writer.WritePropertyName("Generate");
                context.Writer.WriteBooleanValue(requestObject.Generate.Value);
            }

            if(requestObject.IsSetNoRestrictions())
            {
                context.Writer.WritePropertyName("NoRestrictions");
                context.Writer.WriteBooleanValue(requestObject.NoRestrictions.Value);
            }

            if(requestObject.IsSetSign())
            {
                context.Writer.WritePropertyName("Sign");
                context.Writer.WriteBooleanValue(requestObject.Sign.Value);
            }

            if(requestObject.IsSetUnwrap())
            {
                context.Writer.WritePropertyName("Unwrap");
                context.Writer.WriteBooleanValue(requestObject.Unwrap.Value);
            }

            if(requestObject.IsSetVerify())
            {
                context.Writer.WritePropertyName("Verify");
                context.Writer.WriteBooleanValue(requestObject.Verify.Value);
            }

            if(requestObject.IsSetWrap())
            {
                context.Writer.WritePropertyName("Wrap");
                context.Writer.WriteBooleanValue(requestObject.Wrap.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KeyModesOfUseMarshaller Instance = new KeyModesOfUseMarshaller();

    }
}