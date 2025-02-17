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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AuthenticationConfigurationInput Marshaller
    /// </summary>
    public class AuthenticationConfigurationInputMarshaller : IRequestMarshaller<AuthenticationConfigurationInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AuthenticationConfigurationInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAuthenticationType())
            {
                context.Writer.WritePropertyName("AuthenticationType");
                context.Writer.Write(requestObject.AuthenticationType);
            }

            if(requestObject.IsSetBasicAuthenticationCredentials())
            {
                context.Writer.WritePropertyName("BasicAuthenticationCredentials");
                context.Writer.WriteObjectStart();

                var marshaller = BasicAuthenticationCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.BasicAuthenticationCredentials, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCustomAuthenticationCredentials())
            {
                context.Writer.WritePropertyName("CustomAuthenticationCredentials");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectCustomAuthenticationCredentialsKvp in requestObject.CustomAuthenticationCredentials)
                {
                    context.Writer.WritePropertyName(requestObjectCustomAuthenticationCredentialsKvp.Key);
                    var requestObjectCustomAuthenticationCredentialsValue = requestObjectCustomAuthenticationCredentialsKvp.Value;

                        context.Writer.Write(requestObjectCustomAuthenticationCredentialsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetKmsKeyArn())
            {
                context.Writer.WritePropertyName("KmsKeyArn");
                context.Writer.Write(requestObject.KmsKeyArn);
            }

            if(requestObject.IsSetOAuth2Properties())
            {
                context.Writer.WritePropertyName("OAuth2Properties");
                context.Writer.WriteObjectStart();

                var marshaller = OAuth2PropertiesInputMarshaller.Instance;
                marshaller.Marshall(requestObject.OAuth2Properties, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSecretArn())
            {
                context.Writer.WritePropertyName("SecretArn");
                context.Writer.Write(requestObject.SecretArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AuthenticationConfigurationInputMarshaller Instance = new AuthenticationConfigurationInputMarshaller();

    }
}