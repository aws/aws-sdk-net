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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetDecrypt())
            {
                context.Writer.WritePropertyName("Decrypt");
                context.Writer.Write(requestObject.Decrypt);
            }

            if(requestObject.IsSetDeriveKey())
            {
                context.Writer.WritePropertyName("DeriveKey");
                context.Writer.Write(requestObject.DeriveKey);
            }

            if(requestObject.IsSetEncrypt())
            {
                context.Writer.WritePropertyName("Encrypt");
                context.Writer.Write(requestObject.Encrypt);
            }

            if(requestObject.IsSetGenerate())
            {
                context.Writer.WritePropertyName("Generate");
                context.Writer.Write(requestObject.Generate);
            }

            if(requestObject.IsSetNoRestrictions())
            {
                context.Writer.WritePropertyName("NoRestrictions");
                context.Writer.Write(requestObject.NoRestrictions);
            }

            if(requestObject.IsSetSign())
            {
                context.Writer.WritePropertyName("Sign");
                context.Writer.Write(requestObject.Sign);
            }

            if(requestObject.IsSetUnwrap())
            {
                context.Writer.WritePropertyName("Unwrap");
                context.Writer.Write(requestObject.Unwrap);
            }

            if(requestObject.IsSetVerify())
            {
                context.Writer.WritePropertyName("Verify");
                context.Writer.Write(requestObject.Verify);
            }

            if(requestObject.IsSetWrap())
            {
                context.Writer.WritePropertyName("Wrap");
                context.Writer.Write(requestObject.Wrap);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KeyModesOfUseMarshaller Instance = new KeyModesOfUseMarshaller();

    }
}