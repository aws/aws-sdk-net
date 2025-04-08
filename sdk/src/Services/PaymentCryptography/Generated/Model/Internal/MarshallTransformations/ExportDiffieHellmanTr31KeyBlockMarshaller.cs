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
    /// ExportDiffieHellmanTr31KeyBlock Marshaller
    /// </summary>
    public class ExportDiffieHellmanTr31KeyBlockMarshaller : IRequestMarshaller<ExportDiffieHellmanTr31KeyBlock, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ExportDiffieHellmanTr31KeyBlock requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCertificateAuthorityPublicKeyIdentifier())
            {
                context.Writer.WritePropertyName("CertificateAuthorityPublicKeyIdentifier");
                context.Writer.WriteStringValue(requestObject.CertificateAuthorityPublicKeyIdentifier);
            }

            if(requestObject.IsSetDerivationData())
            {
                context.Writer.WritePropertyName("DerivationData");
                context.Writer.WriteStartObject();

                var marshaller = DiffieHellmanDerivationDataMarshaller.Instance;
                marshaller.Marshall(requestObject.DerivationData, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDeriveKeyAlgorithm())
            {
                context.Writer.WritePropertyName("DeriveKeyAlgorithm");
                context.Writer.WriteStringValue(requestObject.DeriveKeyAlgorithm);
            }

            if(requestObject.IsSetKeyBlockHeaders())
            {
                context.Writer.WritePropertyName("KeyBlockHeaders");
                context.Writer.WriteStartObject();

                var marshaller = KeyBlockHeadersMarshaller.Instance;
                marshaller.Marshall(requestObject.KeyBlockHeaders, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKeyDerivationFunction())
            {
                context.Writer.WritePropertyName("KeyDerivationFunction");
                context.Writer.WriteStringValue(requestObject.KeyDerivationFunction);
            }

            if(requestObject.IsSetKeyDerivationHashAlgorithm())
            {
                context.Writer.WritePropertyName("KeyDerivationHashAlgorithm");
                context.Writer.WriteStringValue(requestObject.KeyDerivationHashAlgorithm);
            }

            if(requestObject.IsSetPrivateKeyIdentifier())
            {
                context.Writer.WritePropertyName("PrivateKeyIdentifier");
                context.Writer.WriteStringValue(requestObject.PrivateKeyIdentifier);
            }

            if(requestObject.IsSetPublicKeyCertificate())
            {
                context.Writer.WritePropertyName("PublicKeyCertificate");
                context.Writer.WriteStringValue(requestObject.PublicKeyCertificate);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ExportDiffieHellmanTr31KeyBlockMarshaller Instance = new ExportDiffieHellmanTr31KeyBlockMarshaller();

    }
}