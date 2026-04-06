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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DevOpsAgent.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DevOpsAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MCPServerAuthorizationConfig Marshaller
    /// </summary>
    public class MCPServerAuthorizationConfigMarshaller : IRequestMarshaller<MCPServerAuthorizationConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MCPServerAuthorizationConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetApiKey())
            {
                context.Writer.WritePropertyName("apiKey");
                context.Writer.WriteStartObject();

                var marshaller = MCPServerAPIKeyConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ApiKey, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAuthorizationDiscovery())
            {
                context.Writer.WritePropertyName("authorizationDiscovery");
                context.Writer.WriteStartObject();

                var marshaller = MCPServerAuthorizationDiscoveryConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.AuthorizationDiscovery, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBearerToken())
            {
                context.Writer.WritePropertyName("bearerToken");
                context.Writer.WriteStartObject();

                var marshaller = MCPServerBearerTokenConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.BearerToken, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOAuth3LO())
            {
                context.Writer.WritePropertyName("oAuth3LO");
                context.Writer.WriteStartObject();

                var marshaller = MCPServerOAuth3LOConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.OAuth3LO, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOAuthClientCredentials())
            {
                context.Writer.WritePropertyName("oAuthClientCredentials");
                context.Writer.WriteStartObject();

                var marshaller = MCPServerOAuthClientCredentialsConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.OAuthClientCredentials, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MCPServerAuthorizationConfigMarshaller Instance = new MCPServerAuthorizationConfigMarshaller();

    }
}