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

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticMapReduce.Model.Transform
{
     /// <summary>
     ///   StepConfig Unmarshaller
     /// </summary>
    internal class StepConfigUnmarshaller : IUnmarshaller<StepConfig, UnmarshallerContext> 
    {
        public StepConfig Unmarshall(UnmarshallerContext context) 
        {
            StepConfig stepConfig = new StepConfig();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Name", targetDepth))
                    {
                        stepConfig.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ActionOnFailure", targetDepth))
                    {
                        stepConfig.ActionOnFailure = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("HadoopJarStep", targetDepth))
                    {
                        stepConfig.HadoopJarStep = HadoopJarStepConfigUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
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
    
