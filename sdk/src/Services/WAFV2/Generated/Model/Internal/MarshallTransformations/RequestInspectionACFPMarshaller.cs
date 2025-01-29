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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WAFV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.WAFV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RequestInspectionACFP Marshaller
    /// </summary>
    public class RequestInspectionACFPMarshaller : IRequestMarshaller<RequestInspectionACFP, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RequestInspectionACFP requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAddressFields())
            {
                context.Writer.WritePropertyName("AddressFields");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAddressFieldsListValue in requestObject.AddressFields)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AddressFieldMarshaller.Instance;
                    marshaller.Marshall(requestObjectAddressFieldsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEmailField())
            {
                context.Writer.WritePropertyName("EmailField");
                context.Writer.WriteStartObject();

                var marshaller = EmailFieldMarshaller.Instance;
                marshaller.Marshall(requestObject.EmailField, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPasswordField())
            {
                context.Writer.WritePropertyName("PasswordField");
                context.Writer.WriteStartObject();

                var marshaller = PasswordFieldMarshaller.Instance;
                marshaller.Marshall(requestObject.PasswordField, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPayloadType())
            {
                context.Writer.WritePropertyName("PayloadType");
                context.Writer.WriteStringValue(requestObject.PayloadType);
            }

            if(requestObject.IsSetPhoneNumberFields())
            {
                context.Writer.WritePropertyName("PhoneNumberFields");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPhoneNumberFieldsListValue in requestObject.PhoneNumberFields)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PhoneNumberFieldMarshaller.Instance;
                    marshaller.Marshall(requestObjectPhoneNumberFieldsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetUsernameField())
            {
                context.Writer.WritePropertyName("UsernameField");
                context.Writer.WriteStartObject();

                var marshaller = UsernameFieldMarshaller.Instance;
                marshaller.Marshall(requestObject.UsernameField, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RequestInspectionACFPMarshaller Instance = new RequestInspectionACFPMarshaller();

    }
}