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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GitHubDocumentCrawlProperties Object
    /// </summary>  
    public class GitHubDocumentCrawlPropertiesUnmarshaller : IUnmarshaller<GitHubDocumentCrawlProperties, XmlUnmarshallerContext>, IUnmarshaller<GitHubDocumentCrawlProperties, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        GitHubDocumentCrawlProperties IUnmarshaller<GitHubDocumentCrawlProperties, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public GitHubDocumentCrawlProperties Unmarshall(JsonUnmarshallerContext context)
        {
            GitHubDocumentCrawlProperties unmarshalledObject = new GitHubDocumentCrawlProperties();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CrawlIssue", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CrawlIssue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CrawlIssueComment", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CrawlIssueComment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CrawlIssueCommentAttachment", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CrawlIssueCommentAttachment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CrawlPullRequest", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CrawlPullRequest = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CrawlPullRequestComment", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CrawlPullRequestComment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CrawlPullRequestCommentAttachment", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CrawlPullRequestCommentAttachment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CrawlRepositoryDocuments", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CrawlRepositoryDocuments = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static GitHubDocumentCrawlPropertiesUnmarshaller _instance = new GitHubDocumentCrawlPropertiesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GitHubDocumentCrawlPropertiesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}