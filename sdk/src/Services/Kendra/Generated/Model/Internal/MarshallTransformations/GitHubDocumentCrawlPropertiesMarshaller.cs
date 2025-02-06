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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GitHubDocumentCrawlProperties Marshaller
    /// </summary>
    public class GitHubDocumentCrawlPropertiesMarshaller : IRequestMarshaller<GitHubDocumentCrawlProperties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GitHubDocumentCrawlProperties requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCrawlIssue())
            {
                context.Writer.WritePropertyName("CrawlIssue");
                context.Writer.WriteBooleanValue(requestObject.CrawlIssue.Value);
            }

            if(requestObject.IsSetCrawlIssueComment())
            {
                context.Writer.WritePropertyName("CrawlIssueComment");
                context.Writer.WriteBooleanValue(requestObject.CrawlIssueComment.Value);
            }

            if(requestObject.IsSetCrawlIssueCommentAttachment())
            {
                context.Writer.WritePropertyName("CrawlIssueCommentAttachment");
                context.Writer.WriteBooleanValue(requestObject.CrawlIssueCommentAttachment.Value);
            }

            if(requestObject.IsSetCrawlPullRequest())
            {
                context.Writer.WritePropertyName("CrawlPullRequest");
                context.Writer.WriteBooleanValue(requestObject.CrawlPullRequest.Value);
            }

            if(requestObject.IsSetCrawlPullRequestComment())
            {
                context.Writer.WritePropertyName("CrawlPullRequestComment");
                context.Writer.WriteBooleanValue(requestObject.CrawlPullRequestComment.Value);
            }

            if(requestObject.IsSetCrawlPullRequestCommentAttachment())
            {
                context.Writer.WritePropertyName("CrawlPullRequestCommentAttachment");
                context.Writer.WriteBooleanValue(requestObject.CrawlPullRequestCommentAttachment.Value);
            }

            if(requestObject.IsSetCrawlRepositoryDocuments())
            {
                context.Writer.WritePropertyName("CrawlRepositoryDocuments");
                context.Writer.WriteBooleanValue(requestObject.CrawlRepositoryDocuments.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GitHubDocumentCrawlPropertiesMarshaller Instance = new GitHubDocumentCrawlPropertiesMarshaller();

    }
}