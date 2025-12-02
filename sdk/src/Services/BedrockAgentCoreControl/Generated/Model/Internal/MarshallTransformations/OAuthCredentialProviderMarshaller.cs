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
    /// OAuthCredentialProvider Marshaller
    /// </summary>
    public class OAuthCredentialProviderMarshaller : IRequestMarshaller<OAuthCredentialProvider, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OAuthCredentialProvider requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCustomParameters())
            {
                context.Writer.WritePropertyName("customParameters");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectCustomParametersKvp in requestObject.CustomParameters)
                {
                    context.Writer.WritePropertyName(requestObjectCustomParametersKvp.Key);
                    var requestObjectCustomParametersValue = requestObjectCustomParametersKvp.Value;

                        context.Writer.Write(requestObjectCustomParametersValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDefaultReturnUrl())
            {
                context.Writer.WritePropertyName("defaultReturnUrl");
                context.Writer.Write(requestObject.DefaultReturnUrl);
            }

            if(requestObject.IsSetGrantType())
            {
                context.Writer.WritePropertyName("grantType");
                context.Writer.Write(requestObject.GrantType);
            }

            if(requestObject.IsSetProviderArn())
            {
                context.Writer.WritePropertyName("providerArn");
                context.Writer.Write(requestObject.ProviderArn);
            }

            if(requestObject.IsSetScopes())
            {
                context.Writer.WritePropertyName("scopes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectScopesListValue in requestObject.Scopes)
                {
                        context.Writer.Write(requestObjectScopesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OAuthCredentialProviderMarshaller Instance = new OAuthCredentialProviderMarshaller();

    }
}