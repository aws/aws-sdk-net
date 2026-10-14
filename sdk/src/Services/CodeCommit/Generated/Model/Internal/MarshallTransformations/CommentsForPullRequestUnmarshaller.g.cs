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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.CodeCommit.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.CodeCommit.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CommentsForPullRequest Object
    /// </summary>
    public partial class CommentsForPullRequestUnmarshaller : IJsonUnmarshaller<CommentsForPullRequest, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public CommentsForPullRequest Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new CommentsForPullRequest();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("afterBlobId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AfterBlobId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("afterCommitId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AfterCommitId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("beforeBlobId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BeforeBlobId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("beforeCommitId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BeforeCommitId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("comments", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<Comment, CommentUnmarshaller>(CommentUnmarshaller.Instance);
                    unmarshalledObject.Comments = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("location", targetDepth, ref reader))
                {
                    var unmarshaller = LocationUnmarshaller.Instance;
                    unmarshalledObject.Location = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("pullRequestId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PullRequestId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("repositoryName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RepositoryName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static CommentsForPullRequestUnmarshaller _instance = new CommentsForPullRequestUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CommentsForPullRequestUnmarshaller Instance => _instance;
    }
}
