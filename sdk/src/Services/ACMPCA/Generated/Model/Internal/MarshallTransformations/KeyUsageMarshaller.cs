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
#pragma warning disable CS0612,CS0618
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
            if(requestObject == null)
                return;
            if(requestObject.IsSetCRLSign())
            {
                context.Writer.WritePropertyName("CRLSign");
                context.Writer.WriteBooleanValue(requestObject.CRLSign.Value);
            }

            if(requestObject.IsSetDataEncipherment())
            {
                context.Writer.WritePropertyName("DataEncipherment");
                context.Writer.WriteBooleanValue(requestObject.DataEncipherment.Value);
            }

            if(requestObject.IsSetDecipherOnly())
            {
                context.Writer.WritePropertyName("DecipherOnly");
                context.Writer.WriteBooleanValue(requestObject.DecipherOnly.Value);
            }

            if(requestObject.IsSetDigitalSignature())
            {
                context.Writer.WritePropertyName("DigitalSignature");
                context.Writer.WriteBooleanValue(requestObject.DigitalSignature.Value);
            }

            if(requestObject.IsSetEncipherOnly())
            {
                context.Writer.WritePropertyName("EncipherOnly");
                context.Writer.WriteBooleanValue(requestObject.EncipherOnly.Value);
            }

            if(requestObject.IsSetKeyAgreement())
            {
                context.Writer.WritePropertyName("KeyAgreement");
                context.Writer.WriteBooleanValue(requestObject.KeyAgreement.Value);
            }

            if(requestObject.IsSetKeyCertSign())
            {
                context.Writer.WritePropertyName("KeyCertSign");
                context.Writer.WriteBooleanValue(requestObject.KeyCertSign.Value);
            }

            if(requestObject.IsSetKeyEncipherment())
            {
                context.Writer.WritePropertyName("KeyEncipherment");
                context.Writer.WriteBooleanValue(requestObject.KeyEncipherment.Value);
            }

            if(requestObject.IsSetNonRepudiation())
            {
                context.Writer.WritePropertyName("NonRepudiation");
                context.Writer.WriteBooleanValue(requestObject.NonRepudiation.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KeyUsageMarshaller Instance = new KeyUsageMarshaller();

    }
}