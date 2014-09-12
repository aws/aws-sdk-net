/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;

using Amazon.S3.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   Condition Unmarshaller
     /// </summary>
    internal class RoutingRuleConditionUnmarshaller : IUnmarshaller<RoutingRuleCondition, XmlUnmarshallerContext>, IUnmarshaller<RoutingRuleCondition, JsonUnmarshallerContext> 
    {
        public RoutingRuleCondition Unmarshall(XmlUnmarshallerContext context) 
        {
            RoutingRuleCondition condition = new RoutingRuleCondition();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("HttpErrorCodeReturnedEquals", targetDepth))
                    {
                        condition.HttpErrorCodeReturnedEquals = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("KeyPrefixEquals", targetDepth))
                    {
                        condition.KeyPrefixEquals = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return condition;
                }
            }
                        


            return condition;
        }

        public RoutingRuleCondition Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static RoutingRuleConditionUnmarshaller _instance;

        public static RoutingRuleConditionUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RoutingRuleConditionUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
    
