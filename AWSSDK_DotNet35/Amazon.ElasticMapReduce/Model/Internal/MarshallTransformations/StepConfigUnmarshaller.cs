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
    using Amazon.ElasticMapReduce.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// StepConfigUnmarshaller
      /// </summary>
      internal class StepConfigUnmarshaller : IUnmarshaller<StepConfig, XmlUnmarshallerContext>, IUnmarshaller<StepConfig, JsonUnmarshallerContext>
      {
        StepConfig IUnmarshaller<StepConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public StepConfig Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            StepConfig stepConfig = new StepConfig();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("Name", targetDepth))
              {
                context.Read();
                stepConfig.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ActionOnFailure", targetDepth))
              {
                context.Read();
                stepConfig.ActionOnFailure = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("HadoopJarStep", targetDepth))
              {
                context.Read();
                stepConfig.HadoopJarStep = HadoopJarStepConfigUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return stepConfig;
                }
            }
          

            return stepConfig;
        }

        private static StepConfigUnmarshaller instance;
        public static StepConfigUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new StepConfigUnmarshaller();
            return instance;
        }
    }
}
  
