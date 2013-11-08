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
      /// LoadBasedAutoScalingConfigurationUnmarshaller
      /// </summary>
      internal class LoadBasedAutoScalingConfigurationUnmarshaller : IUnmarshaller<LoadBasedAutoScalingConfiguration, XmlUnmarshallerContext>, IUnmarshaller<LoadBasedAutoScalingConfiguration, JsonUnmarshallerContext>
      {
        LoadBasedAutoScalingConfiguration IUnmarshaller<LoadBasedAutoScalingConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public LoadBasedAutoScalingConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            LoadBasedAutoScalingConfiguration loadBasedAutoScalingConfiguration = new LoadBasedAutoScalingConfiguration();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("LayerId", targetDepth))
              {
                context.Read();
                loadBasedAutoScalingConfiguration.LayerId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Enable", targetDepth))
              {
                context.Read();
                loadBasedAutoScalingConfiguration.Enable = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("UpScaling", targetDepth))
              {
                context.Read();
                loadBasedAutoScalingConfiguration.UpScaling = AutoScalingThresholdsUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("DownScaling", targetDepth))
              {
                context.Read();
                loadBasedAutoScalingConfiguration.DownScaling = AutoScalingThresholdsUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return loadBasedAutoScalingConfiguration;
                }
            }
          

            return loadBasedAutoScalingConfiguration;
        }

        private static LoadBasedAutoScalingConfigurationUnmarshaller instance;
        public static LoadBasedAutoScalingConfigurationUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new LoadBasedAutoScalingConfigurationUnmarshaller();
            return instance;
        }
    }
}
  
