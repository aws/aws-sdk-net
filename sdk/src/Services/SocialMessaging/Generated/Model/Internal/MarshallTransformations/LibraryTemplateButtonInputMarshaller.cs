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
    /// LibraryTemplateButtonInput Marshaller
    /// </summary>
    public class LibraryTemplateButtonInputMarshaller : IRequestMarshaller<LibraryTemplateButtonInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LibraryTemplateButtonInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetOtpType())
            {
                context.Writer.WritePropertyName("otpType");
                context.Writer.WriteStringValue(requestObject.OtpType);
            }

            if(requestObject.IsSetPhoneNumber())
            {
                context.Writer.WritePropertyName("phoneNumber");
                context.Writer.WriteStringValue(requestObject.PhoneNumber);
            }

            if(requestObject.IsSetSupportedApps())
            {
                context.Writer.WritePropertyName("supportedApps");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSupportedAppsListValue in requestObject.SupportedApps)
                {
                    context.Writer.WriteStartObject();
                    foreach (var requestObjectSupportedAppsListValueKvp in requestObjectSupportedAppsListValue)
                    {
                        context.Writer.WritePropertyName(requestObjectSupportedAppsListValueKvp.Key);
                        var requestObjectSupportedAppsListValueValue = requestObjectSupportedAppsListValueKvp.Value;

                            context.Writer.WriteStringValue(requestObjectSupportedAppsListValueValue);
                    }
                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

            if(requestObject.IsSetUrl())
            {
                context.Writer.WritePropertyName("url");
                context.Writer.WriteStartObject();
                foreach (var requestObjectUrlKvp in requestObject.Url)
                {
                    context.Writer.WritePropertyName(requestObjectUrlKvp.Key);
                    var requestObjectUrlValue = requestObjectUrlKvp.Value;

                        context.Writer.WriteStringValue(requestObjectUrlValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetZeroTapTermsAccepted())
            {
                context.Writer.WritePropertyName("zeroTapTermsAccepted");
                context.Writer.WriteBooleanValue(requestObject.ZeroTapTermsAccepted.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LibraryTemplateButtonInputMarshaller Instance = new LibraryTemplateButtonInputMarshaller();

    }
}