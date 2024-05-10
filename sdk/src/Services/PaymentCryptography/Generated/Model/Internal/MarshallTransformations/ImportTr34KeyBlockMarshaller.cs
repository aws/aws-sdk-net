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
    /// ImportTr34KeyBlock Marshaller
    /// </summary>
    public class ImportTr34KeyBlockMarshaller : IRequestMarshaller<ImportTr34KeyBlock, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ImportTr34KeyBlock requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCertificateAuthorityPublicKeyIdentifier())
            {
                context.Writer.WritePropertyName("CertificateAuthorityPublicKeyIdentifier");
                context.Writer.Write(requestObject.CertificateAuthorityPublicKeyIdentifier);
            }

            if(requestObject.IsSetImportToken())
            {
                context.Writer.WritePropertyName("ImportToken");
                context.Writer.Write(requestObject.ImportToken);
            }

            if(requestObject.IsSetKeyBlockFormat())
            {
                context.Writer.WritePropertyName("KeyBlockFormat");
                context.Writer.Write(requestObject.KeyBlockFormat);
            }

            if(requestObject.IsSetRandomNonce())
            {
                context.Writer.WritePropertyName("RandomNonce");
                context.Writer.Write(requestObject.RandomNonce);
            }

            if(requestObject.IsSetSigningKeyCertificate())
            {
                context.Writer.WritePropertyName("SigningKeyCertificate");
                context.Writer.Write(requestObject.SigningKeyCertificate);
            }

            if(requestObject.IsSetWrappedKeyBlock())
            {
                context.Writer.WritePropertyName("WrappedKeyBlock");
                context.Writer.Write(requestObject.WrappedKeyBlock);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ImportTr34KeyBlockMarshaller Instance = new ImportTr34KeyBlockMarshaller();

    }
}