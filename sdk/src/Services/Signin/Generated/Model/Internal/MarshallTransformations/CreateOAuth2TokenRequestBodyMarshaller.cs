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
 * Do not modify this file. This file is generated from the signin-2023-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Signin.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Signin.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateOAuth2TokenRequestBody Marshaller
    /// </summary>
    public class CreateOAuth2TokenRequestBodyMarshaller : IRequestMarshaller<CreateOAuth2TokenRequestBody, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateOAuth2TokenRequestBody requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetClientId())
            {
                context.Writer.WritePropertyName("clientId");
                context.Writer.WriteStringValue(requestObject.ClientId);
            }

            if(requestObject.IsSetCode())
            {
                context.Writer.WritePropertyName("code");
                context.Writer.WriteStringValue(requestObject.Code);
            }

            if(requestObject.IsSetCodeVerifier())
            {
                context.Writer.WritePropertyName("codeVerifier");
                context.Writer.WriteStringValue(requestObject.CodeVerifier);
            }

            if(requestObject.IsSetGrantType())
            {
                context.Writer.WritePropertyName("grantType");
                context.Writer.WriteStringValue(requestObject.GrantType);
            }

            if(requestObject.IsSetRedirectUri())
            {
                context.Writer.WritePropertyName("redirectUri");
                context.Writer.WriteStringValue(requestObject.RedirectUri);
            }

            if(requestObject.IsSetRefreshToken())
            {
                context.Writer.WritePropertyName("refreshToken");
                context.Writer.WriteStringValue(requestObject.RefreshToken);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CreateOAuth2TokenRequestBodyMarshaller Instance = new CreateOAuth2TokenRequestBodyMarshaller();

    }
}