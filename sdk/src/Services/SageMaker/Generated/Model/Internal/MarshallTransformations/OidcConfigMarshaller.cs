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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OidcConfig Marshaller
    /// </summary>
    public class OidcConfigMarshaller : IRequestMarshaller<OidcConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OidcConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAuthenticationRequestExtraParams())
            {
                context.Writer.WritePropertyName("AuthenticationRequestExtraParams");
                context.Writer.WriteStartObject();
                foreach (var requestObjectAuthenticationRequestExtraParamsKvp in requestObject.AuthenticationRequestExtraParams)
                {
                    context.Writer.WritePropertyName(requestObjectAuthenticationRequestExtraParamsKvp.Key);
                    var requestObjectAuthenticationRequestExtraParamsValue = requestObjectAuthenticationRequestExtraParamsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectAuthenticationRequestExtraParamsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAuthorizationEndpoint())
            {
                context.Writer.WritePropertyName("AuthorizationEndpoint");
                context.Writer.WriteStringValue(requestObject.AuthorizationEndpoint);
            }

            if(requestObject.IsSetClientId())
            {
                context.Writer.WritePropertyName("ClientId");
                context.Writer.WriteStringValue(requestObject.ClientId);
            }

            if(requestObject.IsSetClientSecret())
            {
                context.Writer.WritePropertyName("ClientSecret");
                context.Writer.WriteStringValue(requestObject.ClientSecret);
            }

            if(requestObject.IsSetIssuer())
            {
                context.Writer.WritePropertyName("Issuer");
                context.Writer.WriteStringValue(requestObject.Issuer);
            }

            if(requestObject.IsSetJwksUri())
            {
                context.Writer.WritePropertyName("JwksUri");
                context.Writer.WriteStringValue(requestObject.JwksUri);
            }

            if(requestObject.IsSetLogoutEndpoint())
            {
                context.Writer.WritePropertyName("LogoutEndpoint");
                context.Writer.WriteStringValue(requestObject.LogoutEndpoint);
            }

            if(requestObject.IsSetScope())
            {
                context.Writer.WritePropertyName("Scope");
                context.Writer.WriteStringValue(requestObject.Scope);
            }

            if(requestObject.IsSetTokenEndpoint())
            {
                context.Writer.WritePropertyName("TokenEndpoint");
                context.Writer.WriteStringValue(requestObject.TokenEndpoint);
            }

            if(requestObject.IsSetUserInfoEndpoint())
            {
                context.Writer.WritePropertyName("UserInfoEndpoint");
                context.Writer.WriteStringValue(requestObject.UserInfoEndpoint);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OidcConfigMarshaller Instance = new OidcConfigMarshaller();

    }
}