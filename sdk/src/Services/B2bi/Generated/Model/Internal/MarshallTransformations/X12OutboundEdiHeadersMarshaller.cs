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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.B2bi.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.B2bi.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// X12OutboundEdiHeaders Marshaller
    /// </summary>
    public class X12OutboundEdiHeadersMarshaller : IRequestMarshaller<X12OutboundEdiHeaders, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(X12OutboundEdiHeaders requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetControlNumbers())
            {
                context.Writer.WritePropertyName("controlNumbers");
                context.Writer.WriteStartObject();

                var marshaller = X12ControlNumbersMarshaller.Instance;
                marshaller.Marshall(requestObject.ControlNumbers, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDelimiters())
            {
                context.Writer.WritePropertyName("delimiters");
                context.Writer.WriteStartObject();

                var marshaller = X12DelimitersMarshaller.Instance;
                marshaller.Marshall(requestObject.Delimiters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFunctionalGroupHeaders())
            {
                context.Writer.WritePropertyName("functionalGroupHeaders");
                context.Writer.WriteStartObject();

                var marshaller = X12FunctionalGroupHeadersMarshaller.Instance;
                marshaller.Marshall(requestObject.FunctionalGroupHeaders, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGs05TimeFormat())
            {
                context.Writer.WritePropertyName("gs05TimeFormat");
                context.Writer.WriteStringValue(requestObject.Gs05TimeFormat);
            }

            if(requestObject.IsSetInterchangeControlHeaders())
            {
                context.Writer.WritePropertyName("interchangeControlHeaders");
                context.Writer.WriteStartObject();

                var marshaller = X12InterchangeControlHeadersMarshaller.Instance;
                marshaller.Marshall(requestObject.InterchangeControlHeaders, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetValidateEdi())
            {
                context.Writer.WritePropertyName("validateEdi");
                context.Writer.WriteBooleanValue(requestObject.ValidateEdi.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static X12OutboundEdiHeadersMarshaller Instance = new X12OutboundEdiHeadersMarshaller();

    }
}