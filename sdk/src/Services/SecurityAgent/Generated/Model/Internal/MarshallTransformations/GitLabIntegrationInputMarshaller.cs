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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityAgent.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GitLabIntegrationInput Marshaller
    /// </summary>
    public class GitLabIntegrationInputMarshaller : IRequestMarshaller<GitLabIntegrationInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GitLabIntegrationInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccessToken())
            {
                context.Writer.WritePropertyName("accessToken");
                context.Writer.WriteStringValue(requestObject.AccessToken);
            }

            if(requestObject.IsSetGroupId())
            {
                context.Writer.WritePropertyName("groupId");
                context.Writer.WriteStringValue(requestObject.GroupId);
            }

            if(requestObject.IsSetTargetUrl())
            {
                context.Writer.WritePropertyName("targetUrl");
                context.Writer.WriteStringValue(requestObject.TargetUrl);
            }

            if(requestObject.IsSetTokenType())
            {
                context.Writer.WritePropertyName("tokenType");
                context.Writer.WriteStringValue(requestObject.TokenType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GitLabIntegrationInputMarshaller Instance = new GitLabIntegrationInputMarshaller();

    }
}