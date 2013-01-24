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
     ///   PolicyTypeDescription Unmarshaller
     /// </summary>
    internal class PolicyTypeDescriptionUnmarshaller : IUnmarshaller<PolicyTypeDescription, XmlUnmarshallerContext>, IUnmarshaller<PolicyTypeDescription, JsonUnmarshallerContext> 
    {
        public PolicyTypeDescription Unmarshall(XmlUnmarshallerContext context) 
        {
            PolicyTypeDescription policyTypeDescription = new PolicyTypeDescription();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("PolicyTypeName", targetDepth))
                    {
                        policyTypeDescription.PolicyTypeName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Description", targetDepth))
                    {
                        policyTypeDescription.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("PolicyAttributeTypeDescriptions/member", targetDepth))
                    {
                        policyTypeDescription.PolicyAttributeTypeDescriptions.Add(PolicyAttributeTypeDescriptionUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return policyTypeDescription;
                }
            }
                        


            return policyTypeDescription;
        }

        public PolicyTypeDescription Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static PolicyTypeDescriptionUnmarshaller instance;

        public static PolicyTypeDescriptionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new PolicyTypeDescriptionUnmarshaller();

            return instance;
        }
    }
}
    
