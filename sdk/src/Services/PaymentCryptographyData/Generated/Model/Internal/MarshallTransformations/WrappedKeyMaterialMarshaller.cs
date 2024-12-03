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
    /// WrappedKeyMaterial Marshaller
    /// </summary>
    public class WrappedKeyMaterialMarshaller : IRequestMarshaller<WrappedKeyMaterial, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(WrappedKeyMaterial requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDiffieHellmanSymmetricKey())
            {
                context.Writer.WritePropertyName("DiffieHellmanSymmetricKey");
                context.Writer.WriteObjectStart();

                var marshaller = EcdhDerivationAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.DiffieHellmanSymmetricKey, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTr31KeyBlock())
            {
                context.Writer.WritePropertyName("Tr31KeyBlock");
                context.Writer.Write(requestObject.Tr31KeyBlock);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static WrappedKeyMaterialMarshaller Instance = new WrappedKeyMaterialMarshaller();

    }
}