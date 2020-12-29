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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ACMPCA.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ACMPCA.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// KeyUsage Marshaller
    /// </summary>       
    public class KeyUsageMarshaller : IRequestMarshaller<KeyUsage, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(KeyUsage requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCRLSign())
            {
                context.Writer.WritePropertyName("CRLSign");
                context.Writer.Write(requestObject.CRLSign);
            }

            if(requestObject.IsSetDataEncipherment())
            {
                context.Writer.WritePropertyName("DataEncipherment");
                context.Writer.Write(requestObject.DataEncipherment);
            }

            if(requestObject.IsSetDecipherOnly())
            {
                context.Writer.WritePropertyName("DecipherOnly");
                context.Writer.Write(requestObject.DecipherOnly);
            }

            if(requestObject.IsSetDigitalSignature())
            {
                context.Writer.WritePropertyName("DigitalSignature");
                context.Writer.Write(requestObject.DigitalSignature);
            }

            if(requestObject.IsSetEncipherOnly())
            {
                context.Writer.WritePropertyName("EncipherOnly");
                context.Writer.Write(requestObject.EncipherOnly);
            }

            if(requestObject.IsSetKeyAgreement())
            {
                context.Writer.WritePropertyName("KeyAgreement");
                context.Writer.Write(requestObject.KeyAgreement);
            }

            if(requestObject.IsSetKeyCertSign())
            {
                context.Writer.WritePropertyName("KeyCertSign");
                context.Writer.Write(requestObject.KeyCertSign);
            }

            if(requestObject.IsSetKeyEncipherment())
            {
                context.Writer.WritePropertyName("KeyEncipherment");
                context.Writer.Write(requestObject.KeyEncipherment);
            }

            if(requestObject.IsSetNonRepudiation())
            {
                context.Writer.WritePropertyName("NonRepudiation");
                context.Writer.Write(requestObject.NonRepudiation);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static KeyUsageMarshaller Instance = new KeyUsageMarshaller();

    }
}