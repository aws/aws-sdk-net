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
    /// UpdateBackendAuthUserPoolConfig Marshaller
    /// </summary>       
    public class UpdateBackendAuthUserPoolConfigMarshaller : IRequestMarshaller<UpdateBackendAuthUserPoolConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdateBackendAuthUserPoolConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetForgotPassword())
            {
                context.Writer.WritePropertyName("forgotPassword");
                context.Writer.WriteObjectStart();

                var marshaller = UpdateBackendAuthForgotPasswordConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ForgotPassword, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMfa())
            {
                context.Writer.WritePropertyName("mfa");
                context.Writer.WriteObjectStart();

                var marshaller = UpdateBackendAuthMFAConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.Mfa, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOAuth())
            {
                context.Writer.WritePropertyName("oAuth");
                context.Writer.WriteObjectStart();

                var marshaller = UpdateBackendAuthOAuthConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.OAuth, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPasswordPolicy())
            {
                context.Writer.WritePropertyName("passwordPolicy");
                context.Writer.WriteObjectStart();

                var marshaller = UpdateBackendAuthPasswordPolicyConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.PasswordPolicy, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static UpdateBackendAuthUserPoolConfigMarshaller Instance = new UpdateBackendAuthUserPoolConfigMarshaller();

    }
}