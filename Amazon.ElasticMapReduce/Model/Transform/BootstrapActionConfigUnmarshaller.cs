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
     ///   BootstrapActionConfig Unmarshaller
     /// </summary>
    internal class BootstrapActionConfigUnmarshaller : IUnmarshaller<BootstrapActionConfig, UnmarshallerContext> 
    {
        public BootstrapActionConfig Unmarshall(UnmarshallerContext context) 
        {
            BootstrapActionConfig bootstrapActionConfig = new BootstrapActionConfig();
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
                        bootstrapActionConfig.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ScriptBootstrapAction", targetDepth))
                    {
                        bootstrapActionConfig.ScriptBootstrapAction = ScriptBootstrapActionConfigUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return bootstrapActionConfig;
                }
            }

            return bootstrapActionConfig;
        }

        private static BootstrapActionConfigUnmarshaller instance;

        public static BootstrapActionConfigUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new BootstrapActionConfigUnmarshaller();

            return instance;
        }
    }
}
    
