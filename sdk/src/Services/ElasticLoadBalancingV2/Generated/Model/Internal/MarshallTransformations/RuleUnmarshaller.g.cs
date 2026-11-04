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

using Amazon.ElasticLoadBalancingV2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.ElasticLoadBalancingV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Rule Object
    /// </summary>
    public partial class RuleUnmarshaller : IXmlUnmarshaller<Rule, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Rule Unmarshall(XmlUnmarshallerContext context)
        {
            Rule unmarshalledObject = new Rule();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument)
            {
                targetDepth += 2;
            }

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Actions/member", targetDepth))
                    {
                        if (unmarshalledObject.Actions == null)
                        {
                            unmarshalledObject.Actions = new List<Action>();
                        }
                        var unmarshaller = ActionUnmarshaller.Instance;
                        unmarshalledObject.Actions.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("Conditions/member", targetDepth))
                    {
                        if (unmarshalledObject.Conditions == null)
                        {
                            unmarshalledObject.Conditions = new List<RuleCondition>();
                        }
                        var unmarshaller = RuleConditionUnmarshaller.Instance;
                        unmarshalledObject.Conditions.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("IsDefault", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.IsDefault = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Priority", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Priority = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("RuleArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RuleArn = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Transforms/member", targetDepth))
                    {
                        if (unmarshalledObject.Transforms == null)
                        {
                            unmarshalledObject.Transforms = new List<RuleTransform>();
                        }
                        var unmarshaller = RuleTransformUnmarshaller.Instance;
                        unmarshalledObject.Transforms.Add(unmarshaller.Unmarshall(context));
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

        private static RuleUnmarshaller _instance = new RuleUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RuleUnmarshaller Instance => _instance;
    }
}
