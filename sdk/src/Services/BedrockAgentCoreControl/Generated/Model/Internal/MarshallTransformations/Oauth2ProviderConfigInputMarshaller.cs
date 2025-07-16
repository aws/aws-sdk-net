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
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentCoreControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Oauth2ProviderConfigInput Marshaller
    /// </summary>
    public class Oauth2ProviderConfigInputMarshaller : IRequestMarshaller<Oauth2ProviderConfigInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Oauth2ProviderConfigInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCustomOauth2ProviderConfig())
            {
                context.Writer.WritePropertyName("customOauth2ProviderConfig");
                context.Writer.WriteStartObject();

                var marshaller = CustomOauth2ProviderConfigInputMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomOauth2ProviderConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGithubOauth2ProviderConfig())
            {
                context.Writer.WritePropertyName("githubOauth2ProviderConfig");
                context.Writer.WriteStartObject();

                var marshaller = GithubOauth2ProviderConfigInputMarshaller.Instance;
                marshaller.Marshall(requestObject.GithubOauth2ProviderConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGoogleOauth2ProviderConfig())
            {
                context.Writer.WritePropertyName("googleOauth2ProviderConfig");
                context.Writer.WriteStartObject();

                var marshaller = GoogleOauth2ProviderConfigInputMarshaller.Instance;
                marshaller.Marshall(requestObject.GoogleOauth2ProviderConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMicrosoftOauth2ProviderConfig())
            {
                context.Writer.WritePropertyName("microsoftOauth2ProviderConfig");
                context.Writer.WriteStartObject();

                var marshaller = MicrosoftOauth2ProviderConfigInputMarshaller.Instance;
                marshaller.Marshall(requestObject.MicrosoftOauth2ProviderConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSalesforceOauth2ProviderConfig())
            {
                context.Writer.WritePropertyName("salesforceOauth2ProviderConfig");
                context.Writer.WriteStartObject();

                var marshaller = SalesforceOauth2ProviderConfigInputMarshaller.Instance;
                marshaller.Marshall(requestObject.SalesforceOauth2ProviderConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSlackOauth2ProviderConfig())
            {
                context.Writer.WritePropertyName("slackOauth2ProviderConfig");
                context.Writer.WriteStartObject();

                var marshaller = SlackOauth2ProviderConfigInputMarshaller.Instance;
                marshaller.Marshall(requestObject.SlackOauth2ProviderConfig, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static Oauth2ProviderConfigInputMarshaller Instance = new Oauth2ProviderConfigInputMarshaller();

    }
}