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
    /// StripePrivyConfigurationInput Marshaller
    /// </summary>
    public class StripePrivyConfigurationInputMarshaller : IRequestMarshaller<StripePrivyConfigurationInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(StripePrivyConfigurationInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAppId())
            {
                context.Writer.WritePropertyName("appId");
                context.Writer.WriteStringValue(requestObject.AppId);
            }

            if(requestObject.IsSetAppSecret())
            {
                context.Writer.WritePropertyName("appSecret");
                context.Writer.WriteStringValue(requestObject.AppSecret);
            }

            if(requestObject.IsSetAuthorizationId())
            {
                context.Writer.WritePropertyName("authorizationId");
                context.Writer.WriteStringValue(requestObject.AuthorizationId);
            }

            if(requestObject.IsSetAuthorizationPrivateKey())
            {
                context.Writer.WritePropertyName("authorizationPrivateKey");
                context.Writer.WriteStringValue(requestObject.AuthorizationPrivateKey);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static StripePrivyConfigurationInputMarshaller Instance = new StripePrivyConfigurationInputMarshaller();

    }
}