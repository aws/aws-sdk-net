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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AmplifyBackend.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AmplifyBackend.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateBackendAuthForgotPasswordConfig Marshaller
    /// </summary>       
    public class CreateBackendAuthForgotPasswordConfigMarshaller : IRequestMarshaller<CreateBackendAuthForgotPasswordConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateBackendAuthForgotPasswordConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDeliveryMethod())
            {
                context.Writer.WritePropertyName("deliveryMethod");
                context.Writer.Write(requestObject.DeliveryMethod);
            }

            if(requestObject.IsSetEmailSettings())
            {
                context.Writer.WritePropertyName("emailSettings");
                context.Writer.WriteObjectStart();

                var marshaller = EmailSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.EmailSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSmsSettings())
            {
                context.Writer.WritePropertyName("smsSettings");
                context.Writer.WriteObjectStart();

                var marshaller = SmsSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.SmsSettings, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static CreateBackendAuthForgotPasswordConfigMarshaller Instance = new CreateBackendAuthForgotPasswordConfigMarshaller();

    }
}