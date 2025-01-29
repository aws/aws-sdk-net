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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SocialMessaging.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SocialMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// WhatsAppSetupFinalization Marshaller
    /// </summary>
    public class WhatsAppSetupFinalizationMarshaller : IRequestMarshaller<WhatsAppSetupFinalization, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(WhatsAppSetupFinalization requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAssociateInProgressToken())
            {
                context.Writer.WritePropertyName("associateInProgressToken");
                context.Writer.WriteStringValue(requestObject.AssociateInProgressToken);
            }

            if(requestObject.IsSetPhoneNumberParent())
            {
                context.Writer.WritePropertyName("phoneNumberParent");
                context.Writer.WriteStringValue(requestObject.PhoneNumberParent);
            }

            if(requestObject.IsSetPhoneNumbers())
            {
                context.Writer.WritePropertyName("phoneNumbers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPhoneNumbersListValue in requestObject.PhoneNumbers)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = WabaPhoneNumberSetupFinalizationMarshaller.Instance;
                    marshaller.Marshall(requestObjectPhoneNumbersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetWaba())
            {
                context.Writer.WritePropertyName("waba");
                context.Writer.WriteStartObject();

                var marshaller = WabaSetupFinalizationMarshaller.Instance;
                marshaller.Marshall(requestObject.Waba, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static WhatsAppSetupFinalizationMarshaller Instance = new WhatsAppSetupFinalizationMarshaller();

    }
}