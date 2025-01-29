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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OAuth2Properties Marshaller
    /// </summary>
    public class OAuth2PropertiesMarshaller : IRequestMarshaller<OAuth2Properties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OAuth2Properties requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAuthorizationCodeProperties())
            {
                context.Writer.WritePropertyName("authorizationCodeProperties");
                context.Writer.WriteStartObject();

                var marshaller = AuthorizationCodePropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.AuthorizationCodeProperties, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOAuth2ClientApplication())
            {
                context.Writer.WritePropertyName("oAuth2ClientApplication");
                context.Writer.WriteStartObject();

                var marshaller = OAuth2ClientApplicationMarshaller.Instance;
                marshaller.Marshall(requestObject.OAuth2ClientApplication, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOAuth2Credentials())
            {
                context.Writer.WritePropertyName("oAuth2Credentials");
                context.Writer.WriteStartObject();

                var marshaller = GlueOAuth2CredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.OAuth2Credentials, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOAuth2GrantType())
            {
                context.Writer.WritePropertyName("oAuth2GrantType");
                context.Writer.WriteStringValue(requestObject.OAuth2GrantType);
            }

            if(requestObject.IsSetTokenUrl())
            {
                context.Writer.WritePropertyName("tokenUrl");
                context.Writer.WriteStringValue(requestObject.TokenUrl);
            }

            if(requestObject.IsSetTokenUrlParametersMap())
            {
                context.Writer.WritePropertyName("tokenUrlParametersMap");
                context.Writer.WriteStartObject();
                foreach (var requestObjectTokenUrlParametersMapKvp in requestObject.TokenUrlParametersMap)
                {
                    context.Writer.WritePropertyName(requestObjectTokenUrlParametersMapKvp.Key);
                    var requestObjectTokenUrlParametersMapValue = requestObjectTokenUrlParametersMapKvp.Value;

                        context.Writer.WriteStringValue(requestObjectTokenUrlParametersMapValue);
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OAuth2PropertiesMarshaller Instance = new OAuth2PropertiesMarshaller();

    }
}