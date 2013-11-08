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

using Amazon.ElasticLoadBalancing.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   PolicyDescription Unmarshaller
     /// </summary>
    internal class PolicyDescriptionUnmarshaller : IUnmarshaller<PolicyDescription, XmlUnmarshallerContext>, IUnmarshaller<PolicyDescription, JsonUnmarshallerContext> 
    {
        public PolicyDescription Unmarshall(XmlUnmarshallerContext context) 
        {
            PolicyDescription policyDescription = new PolicyDescription();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("PolicyName", targetDepth))
                    {
                        policyDescription.PolicyName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("PolicyTypeName", targetDepth))
                    {
                        policyDescription.PolicyTypeName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("PolicyAttributeDescriptions/member", targetDepth))
                    {
                        policyDescription.PolicyAttributeDescriptions.Add(PolicyAttributeDescriptionUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return policyDescription;
                }
            }
                        


            return policyDescription;
        }

        public PolicyDescription Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static PolicyDescriptionUnmarshaller instance;

        public static PolicyDescriptionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new PolicyDescriptionUnmarshaller();

            return instance;
        }
    }
}
    
