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
     ///   RunJobFlowResult Unmarshaller
     /// </summary>
    internal class RunJobFlowResultUnmarshaller : IUnmarshaller<RunJobFlowResult, UnmarshallerContext> 
    {
        public RunJobFlowResult Unmarshall(UnmarshallerContext context) 
        {
            RunJobFlowResult runJobFlowResult = new RunJobFlowResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("JobFlowId", targetDepth))
                    {
                        runJobFlowResult.JobFlowId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return runJobFlowResult;
                }
            }

            return runJobFlowResult;
        }

        private static RunJobFlowResultUnmarshaller instance;

        public static RunJobFlowResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new RunJobFlowResultUnmarshaller();

            return instance;
        }
    }
}
    
