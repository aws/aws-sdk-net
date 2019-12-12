/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Response Unmarshaller for ApprovalRuleTemplate Object
    /// </summary>  
    public class ApprovalRuleTemplateUnmarshaller : IUnmarshaller<ApprovalRuleTemplate, XmlUnmarshallerContext>, IUnmarshaller<ApprovalRuleTemplate, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ApprovalRuleTemplate IUnmarshaller<ApprovalRuleTemplate, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ApprovalRuleTemplate Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ApprovalRuleTemplate unmarshalledObject = new ApprovalRuleTemplate();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("approvalRuleTemplateContent", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApprovalRuleTemplateContent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("approvalRuleTemplateDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApprovalRuleTemplateDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("approvalRuleTemplateId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApprovalRuleTemplateId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("approvalRuleTemplateName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApprovalRuleTemplateName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("creationDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastModifiedDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastModifiedUser", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedUser = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ruleContentSha256", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RuleContentSha256 = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ApprovalRuleTemplateUnmarshaller _instance = new ApprovalRuleTemplateUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ApprovalRuleTemplateUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}