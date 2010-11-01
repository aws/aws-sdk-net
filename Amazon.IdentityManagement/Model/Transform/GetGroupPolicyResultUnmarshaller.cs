/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.IdentityManagement.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IdentityManagement.Model.Transform
{
     /// <summary>
     ///   GetGroupPolicyResult Unmarshaller
     /// </summary>
    internal class GetGroupPolicyResultUnmarshaller : IUnmarshaller<GetGroupPolicyResult, UnmarshallerContext> 
    {
        public GetGroupPolicyResult Unmarshall(UnmarshallerContext context) 
        {
            GetGroupPolicyResult getGroupPolicyResult = new GetGroupPolicyResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("GroupName", targetDepth))
                    {
                        getGroupPolicyResult.GroupName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("PolicyName", targetDepth))
                    {
                        getGroupPolicyResult.PolicyName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("PolicyDocument", targetDepth))
                    {
                        getGroupPolicyResult.PolicyDocument = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return getGroupPolicyResult;
                }
            }

            return getGroupPolicyResult;
        }

        private static GetGroupPolicyResultUnmarshaller instance;

        public static GetGroupPolicyResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new GetGroupPolicyResultUnmarshaller();

            return instance;
        }
    }
}
    
