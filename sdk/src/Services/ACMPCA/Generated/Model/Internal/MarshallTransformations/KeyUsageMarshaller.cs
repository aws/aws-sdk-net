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
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.ACMPCA.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// KeyUsage Marshaller
    /// </summary>
    public class KeyUsageMarshaller : IRequestMarshaller<KeyUsage, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(KeyUsage requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetCRLSign())
            {
                context.Writer.WriteTextString("CRLSign");
                context.Writer.WriteBoolean(requestObject.CRLSign.Value);
            }
            if (requestObject.IsSetDataEncipherment())
            {
                context.Writer.WriteTextString("DataEncipherment");
                context.Writer.WriteBoolean(requestObject.DataEncipherment.Value);
            }
            if (requestObject.IsSetDecipherOnly())
            {
                context.Writer.WriteTextString("DecipherOnly");
                context.Writer.WriteBoolean(requestObject.DecipherOnly.Value);
            }
            if (requestObject.IsSetDigitalSignature())
            {
                context.Writer.WriteTextString("DigitalSignature");
                context.Writer.WriteBoolean(requestObject.DigitalSignature.Value);
            }
            if (requestObject.IsSetEncipherOnly())
            {
                context.Writer.WriteTextString("EncipherOnly");
                context.Writer.WriteBoolean(requestObject.EncipherOnly.Value);
            }
            if (requestObject.IsSetKeyAgreement())
            {
                context.Writer.WriteTextString("KeyAgreement");
                context.Writer.WriteBoolean(requestObject.KeyAgreement.Value);
            }
            if (requestObject.IsSetKeyCertSign())
            {
                context.Writer.WriteTextString("KeyCertSign");
                context.Writer.WriteBoolean(requestObject.KeyCertSign.Value);
            }
            if (requestObject.IsSetKeyEncipherment())
            {
                context.Writer.WriteTextString("KeyEncipherment");
                context.Writer.WriteBoolean(requestObject.KeyEncipherment.Value);
            }
            if (requestObject.IsSetNonRepudiation())
            {
                context.Writer.WriteTextString("NonRepudiation");
                context.Writer.WriteBoolean(requestObject.NonRepudiation.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KeyUsageMarshaller Instance = new KeyUsageMarshaller();

    }
}