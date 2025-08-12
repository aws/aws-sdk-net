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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeBuild.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CodeBuild.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Webhook Object
    /// </summary>  
    public class WebhookUnmarshaller : IUnmarshaller<Webhook, XmlUnmarshallerContext>, IUnmarshaller<Webhook, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Webhook IUnmarshaller<Webhook, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Webhook Unmarshall(JsonUnmarshallerContext context)
        {
            Webhook unmarshalledObject = new Webhook();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("branchFilter", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BranchFilter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("buildType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BuildType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("filterGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<List<WebhookFilter>, ListUnmarshaller<WebhookFilter, WebhookFilterUnmarshaller>>(new ListUnmarshaller<WebhookFilter, WebhookFilterUnmarshaller>(WebhookFilterUnmarshaller.Instance));
                    unmarshalledObject.FilterGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastModifiedSecret", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedSecret = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("manualCreation", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ManualCreation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("payloadUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PayloadUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pullRequestBuildPolicy", targetDepth))
                {
                    var unmarshaller = PullRequestBuildPolicyUnmarshaller.Instance;
                    unmarshalledObject.PullRequestBuildPolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scopeConfiguration", targetDepth))
                {
                    var unmarshaller = ScopeConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ScopeConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("secret", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Secret = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("statusMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatusMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("url", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Url = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static WebhookUnmarshaller _instance = new WebhookUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static WebhookUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}