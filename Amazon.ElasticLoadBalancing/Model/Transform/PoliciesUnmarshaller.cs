/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElasticLoadBalancing.Model.Transform
{
     /// <summary>
     ///   Policies Unmarshaller
     /// </summary>
    internal class PoliciesUnmarshaller : IUnmarshaller<Policies, UnmarshallerContext> 
    {
        public Policies Unmarshall(UnmarshallerContext context) 
        {
            Policies policies = new Policies();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AppCookieStickinessPolicies/member", targetDepth))
                    {
                        policies.AppCookieStickinessPolicies.Add(AppCookieStickinessPolicyUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("LBCookieStickinessPolicies/member", targetDepth))
                    {
                        policies.LBCookieStickinessPolicies.Add(LBCookieStickinessPolicyUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return policies;
                }
            }

            return policies;
        }

        private static PoliciesUnmarshaller instance;

        public static PoliciesUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new PoliciesUnmarshaller();

            return instance;
        }
    }
}
    
