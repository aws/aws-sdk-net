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
    /// ConnectorOAuth2Properties Marshaller
    /// </summary>
    public class ConnectorOAuth2PropertiesMarshaller : IRequestMarshaller<ConnectorOAuth2Properties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ConnectorOAuth2Properties requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAuthorizationCodeProperties())
            {
                context.Writer.WritePropertyName("AuthorizationCodeProperties");
                context.Writer.WriteObjectStart();

                var marshaller = ConnectorAuthorizationCodePropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.AuthorizationCodeProperties, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetClientCredentialsProperties())
            {
                context.Writer.WritePropertyName("ClientCredentialsProperties");
                context.Writer.WriteObjectStart();

                var marshaller = ClientCredentialsPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.ClientCredentialsProperties, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetJWTBearerProperties())
            {
                context.Writer.WritePropertyName("JWTBearerProperties");
                context.Writer.WriteObjectStart();

                var marshaller = JWTBearerPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.JWTBearerProperties, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOAuth2GrantType())
            {
                context.Writer.WritePropertyName("OAuth2GrantType");
                context.Writer.Write(requestObject.OAuth2GrantType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ConnectorOAuth2PropertiesMarshaller Instance = new ConnectorOAuth2PropertiesMarshaller();

    }
}