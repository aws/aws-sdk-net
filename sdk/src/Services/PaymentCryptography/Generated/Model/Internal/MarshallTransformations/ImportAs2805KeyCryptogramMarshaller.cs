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

#pragma warning disable CS0612,CS0618
namespace Amazon.PaymentCryptography.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImportAs2805KeyCryptogram Marshaller
    /// </summary>
    public class ImportAs2805KeyCryptogramMarshaller : IRequestMarshaller<ImportAs2805KeyCryptogram, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ImportAs2805KeyCryptogram requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAs2805KeyVariant())
            {
                context.Writer.WritePropertyName("As2805KeyVariant");
                context.Writer.Write(requestObject.As2805KeyVariant);
            }

            if(requestObject.IsSetExportable())
            {
                context.Writer.WritePropertyName("Exportable");
                context.Writer.Write(requestObject.Exportable);
            }

            if(requestObject.IsSetKeyAlgorithm())
            {
                context.Writer.WritePropertyName("KeyAlgorithm");
                context.Writer.Write(requestObject.KeyAlgorithm);
            }

            if(requestObject.IsSetKeyModesOfUse())
            {
                context.Writer.WritePropertyName("KeyModesOfUse");
                context.Writer.WriteObjectStart();

                var marshaller = KeyModesOfUseMarshaller.Instance;
                marshaller.Marshall(requestObject.KeyModesOfUse, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetWrappedKeyCryptogram())
            {
                context.Writer.WritePropertyName("WrappedKeyCryptogram");
                context.Writer.Write(requestObject.WrappedKeyCryptogram);
            }

            if(requestObject.IsSetWrappingKeyIdentifier())
            {
                context.Writer.WritePropertyName("WrappingKeyIdentifier");
                context.Writer.Write(requestObject.WrappingKeyIdentifier);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ImportAs2805KeyCryptogramMarshaller Instance = new ImportAs2805KeyCryptogramMarshaller();

    }
}