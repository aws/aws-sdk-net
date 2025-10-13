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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentCoreControl.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentCoreControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Oauth2AuthorizationServerMetadata Marshaller
    /// </summary>
    public class Oauth2AuthorizationServerMetadataMarshaller : IRequestMarshaller<Oauth2AuthorizationServerMetadata, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Oauth2AuthorizationServerMetadata requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAuthorizationEndpoint())
            {
                context.Writer.WritePropertyName("authorizationEndpoint");
                context.Writer.Write(requestObject.AuthorizationEndpoint);
            }

            if(requestObject.IsSetIssuer())
            {
                context.Writer.WritePropertyName("issuer");
                context.Writer.Write(requestObject.Issuer);
            }

            if(requestObject.IsSetResponseTypes())
            {
                context.Writer.WritePropertyName("responseTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResponseTypesListValue in requestObject.ResponseTypes)
                {
                        context.Writer.Write(requestObjectResponseTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTokenEndpoint())
            {
                context.Writer.WritePropertyName("tokenEndpoint");
                context.Writer.Write(requestObject.TokenEndpoint);
            }

            if(requestObject.IsSetTokenEndpointAuthMethods())
            {
                context.Writer.WritePropertyName("tokenEndpointAuthMethods");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTokenEndpointAuthMethodsListValue in requestObject.TokenEndpointAuthMethods)
                {
                        context.Writer.Write(requestObjectTokenEndpointAuthMethodsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static Oauth2AuthorizationServerMetadataMarshaller Instance = new Oauth2AuthorizationServerMetadataMarshaller();

    }
}