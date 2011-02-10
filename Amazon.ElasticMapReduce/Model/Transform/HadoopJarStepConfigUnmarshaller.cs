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

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticMapReduce.Model.Transform
{
     /// <summary>
     ///   HadoopJarStepConfig Unmarshaller
     /// </summary>
    internal class HadoopJarStepConfigUnmarshaller : IUnmarshaller<HadoopJarStepConfig, UnmarshallerContext> 
    {
        public HadoopJarStepConfig Unmarshall(UnmarshallerContext context) 
        {
            HadoopJarStepConfig hadoopJarStepConfig = new HadoopJarStepConfig();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Properties/member", targetDepth))
                    {
                        hadoopJarStepConfig.Properties.Add(KeyValueUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("Jar", targetDepth))
                    {
                        hadoopJarStepConfig.Jar = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("MainClass", targetDepth))
                    {
                        hadoopJarStepConfig.MainClass = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Args/member", targetDepth))
                    {
                        hadoopJarStepConfig.Args.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return hadoopJarStepConfig;
                }
            }

            return hadoopJarStepConfig;
        }

        private static HadoopJarStepConfigUnmarshaller instance;

        public static HadoopJarStepConfigUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new HadoopJarStepConfigUnmarshaller();

            return instance;
        }
    }
}
    
