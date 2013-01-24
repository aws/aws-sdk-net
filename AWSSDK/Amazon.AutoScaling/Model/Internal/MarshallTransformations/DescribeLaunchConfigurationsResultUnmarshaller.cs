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
     ///   DescribeLaunchConfigurationsResult Unmarshaller
     /// </summary>
    internal class DescribeLaunchConfigurationsResultUnmarshaller : IUnmarshaller<DescribeLaunchConfigurationsResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeLaunchConfigurationsResult, JsonUnmarshallerContext> 
    {
        public DescribeLaunchConfigurationsResult Unmarshall(XmlUnmarshallerContext context) 
        {
            DescribeLaunchConfigurationsResult describeLaunchConfigurationsResult = new DescribeLaunchConfigurationsResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("LaunchConfigurations/member", targetDepth))
                    {
                        describeLaunchConfigurationsResult.LaunchConfigurations.Add(LaunchConfigurationUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("NextToken", targetDepth))
                    {
                        describeLaunchConfigurationsResult.NextToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return describeLaunchConfigurationsResult;
                }
            }
                        


            return describeLaunchConfigurationsResult;
        }

        public DescribeLaunchConfigurationsResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DescribeLaunchConfigurationsResultUnmarshaller instance;

        public static DescribeLaunchConfigurationsResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DescribeLaunchConfigurationsResultUnmarshaller();

            return instance;
        }
    }
}
    
