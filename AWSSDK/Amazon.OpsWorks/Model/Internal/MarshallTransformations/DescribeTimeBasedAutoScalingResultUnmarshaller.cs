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
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Amazon.OpsWorks.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// DescribeTimeBasedAutoScalingResultUnmarshaller
      /// </summary>
      internal class DescribeTimeBasedAutoScalingResultUnmarshaller : IUnmarshaller<DescribeTimeBasedAutoScalingResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeTimeBasedAutoScalingResult, JsonUnmarshallerContext>
      {
        DescribeTimeBasedAutoScalingResult IUnmarshaller<DescribeTimeBasedAutoScalingResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public DescribeTimeBasedAutoScalingResult Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeTimeBasedAutoScalingResult describeTimeBasedAutoScalingResult = new DescribeTimeBasedAutoScalingResult();
          describeTimeBasedAutoScalingResult.TimeBasedAutoScalingConfigurations = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("TimeBasedAutoScalingConfigurations", targetDepth))
              {
                describeTimeBasedAutoScalingResult.TimeBasedAutoScalingConfigurations = new List<TimeBasedAutoScalingConfiguration>();
                        TimeBasedAutoScalingConfigurationUnmarshaller unmarshaller = TimeBasedAutoScalingConfigurationUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     describeTimeBasedAutoScalingResult.TimeBasedAutoScalingConfigurations.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return describeTimeBasedAutoScalingResult;
                }
            }
          

            return describeTimeBasedAutoScalingResult;
        }

        private static DescribeTimeBasedAutoScalingResultUnmarshaller instance;
        public static DescribeTimeBasedAutoScalingResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new DescribeTimeBasedAutoScalingResultUnmarshaller();
            return instance;
        }
    }
}
  
