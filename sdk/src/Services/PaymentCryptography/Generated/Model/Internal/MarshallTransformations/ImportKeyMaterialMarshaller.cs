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
    /// ImportKeyMaterial Marshaller
    /// </summary>
    public class ImportKeyMaterialMarshaller : IRequestMarshaller<ImportKeyMaterial, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ImportKeyMaterial requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDiffieHellmanTr31KeyBlock())
            {
                context.Writer.WritePropertyName("DiffieHellmanTr31KeyBlock");
                context.Writer.WriteStartObject();

                var marshaller = ImportDiffieHellmanTr31KeyBlockMarshaller.Instance;
                marshaller.Marshall(requestObject.DiffieHellmanTr31KeyBlock, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKeyCryptogram())
            {
                context.Writer.WritePropertyName("KeyCryptogram");
                context.Writer.WriteStartObject();

                var marshaller = ImportKeyCryptogramMarshaller.Instance;
                marshaller.Marshall(requestObject.KeyCryptogram, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRootCertificatePublicKey())
            {
                context.Writer.WritePropertyName("RootCertificatePublicKey");
                context.Writer.WriteStartObject();

                var marshaller = RootCertificatePublicKeyMarshaller.Instance;
                marshaller.Marshall(requestObject.RootCertificatePublicKey, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTr31KeyBlock())
            {
                context.Writer.WritePropertyName("Tr31KeyBlock");
                context.Writer.WriteStartObject();

                var marshaller = ImportTr31KeyBlockMarshaller.Instance;
                marshaller.Marshall(requestObject.Tr31KeyBlock, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTr34KeyBlock())
            {
                context.Writer.WritePropertyName("Tr34KeyBlock");
                context.Writer.WriteStartObject();

                var marshaller = ImportTr34KeyBlockMarshaller.Instance;
                marshaller.Marshall(requestObject.Tr34KeyBlock, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTrustedCertificatePublicKey())
            {
                context.Writer.WritePropertyName("TrustedCertificatePublicKey");
                context.Writer.WriteStartObject();

                var marshaller = TrustedCertificatePublicKeyMarshaller.Instance;
                marshaller.Marshall(requestObject.TrustedCertificatePublicKey, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ImportKeyMaterialMarshaller Instance = new ImportKeyMaterialMarshaller();

    }
}