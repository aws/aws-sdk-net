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
    /// ExportKeyMaterial Marshaller
    /// </summary>
    public class ExportKeyMaterialMarshaller : IRequestMarshaller<ExportKeyMaterial, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ExportKeyMaterial requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetKeyCryptogram())
            {
                context.Writer.WritePropertyName("KeyCryptogram");
                context.Writer.WriteObjectStart();

                var marshaller = ExportKeyCryptogramMarshaller.Instance;
                marshaller.Marshall(requestObject.KeyCryptogram, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTr31KeyBlock())
            {
                context.Writer.WritePropertyName("Tr31KeyBlock");
                context.Writer.WriteObjectStart();

                var marshaller = ExportTr31KeyBlockMarshaller.Instance;
                marshaller.Marshall(requestObject.Tr31KeyBlock, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTr34KeyBlock())
            {
                context.Writer.WritePropertyName("Tr34KeyBlock");
                context.Writer.WriteObjectStart();

                var marshaller = ExportTr34KeyBlockMarshaller.Instance;
                marshaller.Marshall(requestObject.Tr34KeyBlock, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ExportKeyMaterialMarshaller Instance = new ExportKeyMaterialMarshaller();

    }
}