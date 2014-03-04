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

using Amazon.AutoScaling.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   DescribeAccountLimitsResult Unmarshaller
     /// </summary>
    internal class DescribeAccountLimitsResultUnmarshaller : IUnmarshaller<DescribeAccountLimitsResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeAccountLimitsResult, JsonUnmarshallerContext> 
    {
        public DescribeAccountLimitsResult Unmarshall(XmlUnmarshallerContext context) 
        {
            DescribeAccountLimitsResult describeAccountLimitsResult = new DescribeAccountLimitsResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("MaxNumberOfAutoScalingGroups", targetDepth))
                    {
                        describeAccountLimitsResult.MaxNumberOfAutoScalingGroups = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("MaxNumberOfLaunchConfigurations", targetDepth))
                    {
                        describeAccountLimitsResult.MaxNumberOfLaunchConfigurations = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return describeAccountLimitsResult;
                }
            }
                        


            return describeAccountLimitsResult;
        }

        public DescribeAccountLimitsResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DescribeAccountLimitsResultUnmarshaller instance;

        public static DescribeAccountLimitsResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DescribeAccountLimitsResultUnmarshaller();

            return instance;
        }
    }
}
    
