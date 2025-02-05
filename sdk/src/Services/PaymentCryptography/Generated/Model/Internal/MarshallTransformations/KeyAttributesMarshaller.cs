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
    /// KeyAttributes Marshaller
    /// </summary>
    public class KeyAttributesMarshaller : IRequestMarshaller<KeyAttributes, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(KeyAttributes requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetKeyAlgorithm())
            {
                context.Writer.WritePropertyName("KeyAlgorithm");
                context.Writer.WriteStringValue(requestObject.KeyAlgorithm);
            }

            if(requestObject.IsSetKeyClass())
            {
                context.Writer.WritePropertyName("KeyClass");
                context.Writer.WriteStringValue(requestObject.KeyClass);
            }

            if(requestObject.IsSetKeyModesOfUse())
            {
                context.Writer.WritePropertyName("KeyModesOfUse");
                context.Writer.WriteStartObject();

                var marshaller = KeyModesOfUseMarshaller.Instance;
                marshaller.Marshall(requestObject.KeyModesOfUse, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKeyUsage())
            {
                context.Writer.WritePropertyName("KeyUsage");
                context.Writer.WriteStringValue(requestObject.KeyUsage);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KeyAttributesMarshaller Instance = new KeyAttributesMarshaller();

    }
}