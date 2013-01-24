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

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   JobFlowDetail Unmarshaller
     /// </summary>
    internal class JobFlowDetailUnmarshaller : IUnmarshaller<JobFlowDetail, XmlUnmarshallerContext>, IUnmarshaller<JobFlowDetail, JsonUnmarshallerContext> 
    {
        public JobFlowDetail Unmarshall(XmlUnmarshallerContext context) 
        {
            JobFlowDetail jobFlowDetail = new JobFlowDetail();
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
                        jobFlowDetail.JobFlowId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Name", targetDepth))
                    {
                        jobFlowDetail.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("LogUri", targetDepth))
                    {
                        jobFlowDetail.LogUri = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("AmiVersion", targetDepth))
                    {
                        jobFlowDetail.AmiVersion = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ExecutionStatusDetail", targetDepth))
                    {
                        jobFlowDetail.ExecutionStatusDetail = JobFlowExecutionStatusDetailUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Instances", targetDepth))
                    {
                        jobFlowDetail.Instances = JobFlowInstancesDetailUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Steps/member", targetDepth))
                    {
                        jobFlowDetail.Steps.Add(StepDetailUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("BootstrapActions/member", targetDepth))
                    {
                        jobFlowDetail.BootstrapActions.Add(BootstrapActionDetailUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("SupportedProducts/member", targetDepth))
                    {
                        jobFlowDetail.SupportedProducts.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("VisibleToAllUsers", targetDepth))
                    {
                        jobFlowDetail.VisibleToAllUsers = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("JobFlowRole", targetDepth))
                    {
                        jobFlowDetail.JobFlowRole = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return jobFlowDetail;
                }
            }
                        


            return jobFlowDetail;
        }

        public JobFlowDetail Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static JobFlowDetailUnmarshaller instance;

        public static JobFlowDetailUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new JobFlowDetailUnmarshaller();

            return instance;
        }
    }
}
    
