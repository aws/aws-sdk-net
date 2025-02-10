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
#pragma warning disable CS0612,CS0618
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
            if(requestObject == null)
                return;
            if(requestObject.IsSetDomainPrefix())
            {
                context.Writer.WritePropertyName("domainPrefix");
                context.Writer.WriteStringValue(requestObject.DomainPrefix);
            }

            if(requestObject.IsSetOAuthGrantType())
            {
                context.Writer.WritePropertyName("oAuthGrantType");
                context.Writer.WriteStringValue(requestObject.OAuthGrantType);
            }

            if(requestObject.IsSetOAuthScopes())
            {
                context.Writer.WritePropertyName("oAuthScopes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectOAuthScopesListValue in requestObject.OAuthScopes)
                {
                        context.Writer.WriteStringValue(requestObjectOAuthScopesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRedirectSignInURIs())
            {
                context.Writer.WritePropertyName("redirectSignInURIs");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRedirectSignInURIsListValue in requestObject.RedirectSignInURIs)
                {
                        context.Writer.WriteStringValue(requestObjectRedirectSignInURIsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRedirectSignOutURIs())
            {
                context.Writer.WritePropertyName("redirectSignOutURIs");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRedirectSignOutURIsListValue in requestObject.RedirectSignOutURIs)
                {
                        context.Writer.WriteStringValue(requestObjectRedirectSignOutURIsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSocialProviderSettings())
            {
                context.Writer.WritePropertyName("socialProviderSettings");
                context.Writer.WriteStartObject();

                var marshaller = SocialProviderSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.SocialProviderSettings, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdateBackendAuthOAuthConfigMarshaller Instance = new UpdateBackendAuthOAuthConfigMarshaller();

    }
}