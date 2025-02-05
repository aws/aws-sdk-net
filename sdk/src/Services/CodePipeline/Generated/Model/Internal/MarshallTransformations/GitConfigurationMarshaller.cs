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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodePipeline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CodePipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GitConfiguration Marshaller
    /// </summary>
    public class GitConfigurationMarshaller : IRequestMarshaller<GitConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GitConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetPullRequest())
            {
                context.Writer.WritePropertyName("pullRequest");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPullRequestListValue in requestObject.PullRequest)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = GitPullRequestFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectPullRequestListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPush())
            {
                context.Writer.WritePropertyName("push");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPushListValue in requestObject.Push)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = GitPushFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectPushListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSourceActionName())
            {
                context.Writer.WritePropertyName("sourceActionName");
                context.Writer.WriteStringValue(requestObject.SourceActionName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GitConfigurationMarshaller Instance = new GitConfigurationMarshaller();

    }
}