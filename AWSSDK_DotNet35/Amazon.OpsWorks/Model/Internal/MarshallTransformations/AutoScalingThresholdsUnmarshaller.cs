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
    using ThirdParty.Json.LitJson;
    using Amazon.OpsWorks.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// AutoScalingThresholdsUnmarshaller
      /// </summary>
      internal class AutoScalingThresholdsUnmarshaller : IUnmarshaller<AutoScalingThresholds, XmlUnmarshallerContext>, IUnmarshaller<AutoScalingThresholds, JsonUnmarshallerContext>
      {
        AutoScalingThresholds IUnmarshaller<AutoScalingThresholds, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public AutoScalingThresholds Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            AutoScalingThresholds autoScalingThresholds = new AutoScalingThresholds();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("InstanceCount", targetDepth))
              {
                context.Read();
                autoScalingThresholds.InstanceCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ThresholdsWaitTime", targetDepth))
              {
                context.Read();
                autoScalingThresholds.ThresholdsWaitTime = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("IgnoreMetricsTime", targetDepth))
              {
                context.Read();
                autoScalingThresholds.IgnoreMetricsTime = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CpuThreshold", targetDepth))
              {
                context.Read();
                autoScalingThresholds.CpuThreshold = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("MemoryThreshold", targetDepth))
              {
                context.Read();
                autoScalingThresholds.MemoryThreshold = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("LoadThreshold", targetDepth))
              {
                context.Read();
                autoScalingThresholds.LoadThreshold = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return autoScalingThresholds;
                }
            }
          

            return autoScalingThresholds;
        }

        private static AutoScalingThresholdsUnmarshaller instance;
        public static AutoScalingThresholdsUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new AutoScalingThresholdsUnmarshaller();
            return instance;
        }
    }
}
  
