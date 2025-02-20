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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EvaluationResult Object
    /// </summary>  
    public class EvaluationResultUnmarshaller : IXmlUnmarshaller<EvaluationResult, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public EvaluationResult Unmarshall(XmlUnmarshallerContext context)
        {
            EvaluationResult unmarshalledObject = new EvaluationResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("EvalActionName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EvalActionName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EvalDecision", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EvalDecision = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EvalDecisionDetails/entry", targetDepth))
                    {
                        var unmarshaller = new XmlKeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance, "key", "value");
                        if (unmarshalledObject.EvalDecisionDetails == null)
                        {
                            unmarshalledObject.EvalDecisionDetails = new Dictionary<string, string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.EvalDecisionDetails.Add(item);
                        continue;
                    }
                    if (context.TestExpression("EvalResourceName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EvalResourceName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MatchedStatements/member", targetDepth))
                    {
                        var unmarshaller = StatementUnmarshaller.Instance;
                        if (unmarshalledObject.MatchedStatements == null)
                        {
                            unmarshalledObject.MatchedStatements = new List<Statement>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.MatchedStatements.Add(item);
                        continue;
                    }
                    if (context.TestExpression("MissingContextValues/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.MissingContextValues == null)
                        {
                            unmarshalledObject.MissingContextValues = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.MissingContextValues.Add(item);
                        continue;
                    }
                    if (context.TestExpression("OrganizationsDecisionDetail", targetDepth))
                    {
                        var unmarshaller = OrganizationsDecisionDetailUnmarshaller.Instance;
                        unmarshalledObject.OrganizationsDecisionDetail = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PermissionsBoundaryDecisionDetail", targetDepth))
                    {
                        var unmarshaller = PermissionsBoundaryDecisionDetailUnmarshaller.Instance;
                        unmarshalledObject.PermissionsBoundaryDecisionDetail = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ResourceSpecificResults/member", targetDepth))
                    {
                        var unmarshaller = ResourceSpecificResultUnmarshaller.Instance;
                        if (unmarshalledObject.ResourceSpecificResults == null)
                        {
                            unmarshalledObject.ResourceSpecificResults = new List<ResourceSpecificResult>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ResourceSpecificResults.Add(item);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        private static EvaluationResultUnmarshaller _instance = new EvaluationResultUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EvaluationResultUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}