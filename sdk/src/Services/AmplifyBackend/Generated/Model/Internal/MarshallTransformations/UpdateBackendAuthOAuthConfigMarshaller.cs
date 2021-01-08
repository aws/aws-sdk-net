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
    /// UpdateBackendAuthOAuthConfig Marshaller
    /// </summary>       
    public class UpdateBackendAuthOAuthConfigMarshaller : IRequestMarshaller<UpdateBackendAuthOAuthConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdateBackendAuthOAuthConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDomainPrefix())
            {
                context.Writer.WritePropertyName("domainPrefix");
                context.Writer.Write(requestObject.DomainPrefix);
            }

            if(requestObject.IsSetOAuthGrantType())
            {
                context.Writer.WritePropertyName("oAuthGrantType");
                context.Writer.Write(requestObject.OAuthGrantType);
            }

            if(requestObject.IsSetOAuthScopes())
            {
                context.Writer.WritePropertyName("oAuthScopes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOAuthScopesListValue in requestObject.OAuthScopes)
                {
                        context.Writer.Write(requestObjectOAuthScopesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRedirectSignInURIs())
            {
                context.Writer.WritePropertyName("redirectSignInURIs");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRedirectSignInURIsListValue in requestObject.RedirectSignInURIs)
                {
                        context.Writer.Write(requestObjectRedirectSignInURIsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRedirectSignOutURIs())
            {
                context.Writer.WritePropertyName("redirectSignOutURIs");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRedirectSignOutURIsListValue in requestObject.RedirectSignOutURIs)
                {
                        context.Writer.Write(requestObjectRedirectSignOutURIsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSocialProviderSettings())
            {
                context.Writer.WritePropertyName("socialProviderSettings");
                context.Writer.WriteObjectStart();

                var marshaller = SocialProviderSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.SocialProviderSettings, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static UpdateBackendAuthOAuthConfigMarshaller Instance = new UpdateBackendAuthOAuthConfigMarshaller();

    }
}