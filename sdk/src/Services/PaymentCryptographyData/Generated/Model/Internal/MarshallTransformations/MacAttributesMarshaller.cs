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
#pragma warning disable CS0612,CS0618
namespace Amazon.PaymentCryptographyData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MacAttributes Marshaller
    /// </summary>
    public class MacAttributesMarshaller : IRequestMarshaller<MacAttributes, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MacAttributes requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAlgorithm())
            {
                context.Writer.WritePropertyName("Algorithm");
                context.Writer.WriteStringValue(requestObject.Algorithm);
            }

            if(requestObject.IsSetDukptCmac())
            {
                context.Writer.WritePropertyName("DukptCmac");
                context.Writer.WriteStartObject();

                var marshaller = MacAlgorithmDukptMarshaller.Instance;
                marshaller.Marshall(requestObject.DukptCmac, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDukptIso9797Algorithm1())
            {
                context.Writer.WritePropertyName("DukptIso9797Algorithm1");
                context.Writer.WriteStartObject();

                var marshaller = MacAlgorithmDukptMarshaller.Instance;
                marshaller.Marshall(requestObject.DukptIso9797Algorithm1, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDukptIso9797Algorithm3())
            {
                context.Writer.WritePropertyName("DukptIso9797Algorithm3");
                context.Writer.WriteStartObject();

                var marshaller = MacAlgorithmDukptMarshaller.Instance;
                marshaller.Marshall(requestObject.DukptIso9797Algorithm3, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEmvMac())
            {
                context.Writer.WritePropertyName("EmvMac");
                context.Writer.WriteStartObject();

                var marshaller = MacAlgorithmEmvMarshaller.Instance;
                marshaller.Marshall(requestObject.EmvMac, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MacAttributesMarshaller Instance = new MacAttributesMarshaller();

    }
}