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
    /// KeyBlockHeaders Marshaller
    /// </summary>
    public class KeyBlockHeadersMarshaller : IRequestMarshaller<KeyBlockHeaders, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(KeyBlockHeaders requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetKeyExportability())
            {
                context.Writer.WritePropertyName("KeyExportability");
                context.Writer.WriteStringValue(requestObject.KeyExportability);
            }

            if(requestObject.IsSetKeyModesOfUse())
            {
                context.Writer.WritePropertyName("KeyModesOfUse");
                context.Writer.WriteStartObject();

                var marshaller = KeyModesOfUseMarshaller.Instance;
                marshaller.Marshall(requestObject.KeyModesOfUse, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKeyVersion())
            {
                context.Writer.WritePropertyName("KeyVersion");
                context.Writer.WriteStringValue(requestObject.KeyVersion);
            }

            if(requestObject.IsSetOptionalBlocks())
            {
                context.Writer.WritePropertyName("OptionalBlocks");
                context.Writer.WriteStartObject();
                foreach (var requestObjectOptionalBlocksKvp in requestObject.OptionalBlocks)
                {
                    context.Writer.WritePropertyName(requestObjectOptionalBlocksKvp.Key);
                    var requestObjectOptionalBlocksValue = requestObjectOptionalBlocksKvp.Value;

                        context.Writer.WriteStringValue(requestObjectOptionalBlocksValue);
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KeyBlockHeadersMarshaller Instance = new KeyBlockHeadersMarshaller();

    }
}