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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSOAdmin.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SSOAdmin.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Grant Marshaller
    /// </summary>
    public class GrantMarshaller : IRequestMarshaller<Grant, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Grant requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAuthorizationCode())
            {
                context.Writer.WritePropertyName("AuthorizationCode");
                context.Writer.WriteStartObject();

                var marshaller = AuthorizationCodeGrantMarshaller.Instance;
                marshaller.Marshall(requestObject.AuthorizationCode, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetJwtBearer())
            {
                context.Writer.WritePropertyName("JwtBearer");
                context.Writer.WriteStartObject();

                var marshaller = JwtBearerGrantMarshaller.Instance;
                marshaller.Marshall(requestObject.JwtBearer, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRefreshToken())
            {
                context.Writer.WritePropertyName("RefreshToken");
                context.Writer.WriteStartObject();

                var marshaller = RefreshTokenGrantMarshaller.Instance;
                marshaller.Marshall(requestObject.RefreshToken, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTokenExchange())
            {
                context.Writer.WritePropertyName("TokenExchange");
                context.Writer.WriteStartObject();

                var marshaller = TokenExchangeGrantMarshaller.Instance;
                marshaller.Marshall(requestObject.TokenExchange, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GrantMarshaller Instance = new GrantMarshaller();

    }
}