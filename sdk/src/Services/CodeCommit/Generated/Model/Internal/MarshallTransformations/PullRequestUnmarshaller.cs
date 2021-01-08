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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeCommit.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeCommit.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PullRequest Object
    /// </summary>  
    public class PullRequestUnmarshaller : IUnmarshaller<PullRequest, XmlUnmarshallerContext>, IUnmarshaller<PullRequest, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PullRequest IUnmarshaller<PullRequest, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PullRequest Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            PullRequest unmarshalledObject = new PullRequest();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("approvalRules", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ApprovalRule, ApprovalRuleUnmarshaller>(ApprovalRuleUnmarshaller.Instance);
                    unmarshalledObject.ApprovalRules = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("authorArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AuthorArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("clientRequestToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClientRequestToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("creationDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastActivityDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastActivityDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pullRequestId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PullRequestId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pullRequestStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PullRequestStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pullRequestTargets", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PullRequestTarget, PullRequestTargetUnmarshaller>(PullRequestTargetUnmarshaller.Instance);
                    unmarshalledObject.PullRequestTargets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("revisionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RevisionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("title", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Title = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static PullRequestUnmarshaller _instance = new PullRequestUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PullRequestUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}