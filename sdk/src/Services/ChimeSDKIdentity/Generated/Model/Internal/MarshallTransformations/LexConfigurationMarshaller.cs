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
 * Do not modify this file. This file is generated from the chime-sdk-identity-2021-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKIdentity.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ChimeSDKIdentity.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LexConfiguration Marshaller
    /// </summary>
    public class LexConfigurationMarshaller : IRequestMarshaller<LexConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LexConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetInvokedBy())
            {
                context.Writer.WritePropertyName("InvokedBy");
                context.Writer.WriteObjectStart();

                var marshaller = InvokedByMarshaller.Instance;
                marshaller.Marshall(requestObject.InvokedBy, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLexBotAliasArn())
            {
                context.Writer.WritePropertyName("LexBotAliasArn");
                context.Writer.Write(requestObject.LexBotAliasArn);
            }

            if(requestObject.IsSetLocaleId())
            {
                context.Writer.WritePropertyName("LocaleId");
                context.Writer.Write(requestObject.LocaleId);
            }

            if(requestObject.IsSetRespondsTo())
            {
                context.Writer.WritePropertyName("RespondsTo");
                context.Writer.Write(requestObject.RespondsTo);
            }

            if(requestObject.IsSetWelcomeIntent())
            {
                context.Writer.WritePropertyName("WelcomeIntent");
                context.Writer.Write(requestObject.WelcomeIntent);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LexConfigurationMarshaller Instance = new LexConfigurationMarshaller();

    }
}