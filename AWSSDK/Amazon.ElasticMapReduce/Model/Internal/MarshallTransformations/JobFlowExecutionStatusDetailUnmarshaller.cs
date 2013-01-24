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
     ///   JobFlowExecutionStatusDetail Unmarshaller
     /// </summary>
    internal class JobFlowExecutionStatusDetailUnmarshaller : IUnmarshaller<JobFlowExecutionStatusDetail, XmlUnmarshallerContext>, IUnmarshaller<JobFlowExecutionStatusDetail, JsonUnmarshallerContext> 
    {
        public JobFlowExecutionStatusDetail Unmarshall(XmlUnmarshallerContext context) 
        {
            JobFlowExecutionStatusDetail jobFlowExecutionStatusDetail = new JobFlowExecutionStatusDetail();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("State", targetDepth))
                    {
                        jobFlowExecutionStatusDetail.State = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CreationDateTime", targetDepth))
                    {
                        jobFlowExecutionStatusDetail.CreationDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("StartDateTime", targetDepth))
                    {
                        jobFlowExecutionStatusDetail.StartDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ReadyDateTime", targetDepth))
                    {
                        jobFlowExecutionStatusDetail.ReadyDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("EndDateTime", targetDepth))
                    {
                        jobFlowExecutionStatusDetail.EndDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("LastStateChangeReason", targetDepth))
                    {
                        jobFlowExecutionStatusDetail.LastStateChangeReason = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return jobFlowExecutionStatusDetail;
                }
            }
                        


            return jobFlowExecutionStatusDetail;
        }

        public JobFlowExecutionStatusDetail Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static JobFlowExecutionStatusDetailUnmarshaller instance;

        public static JobFlowExecutionStatusDetailUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new JobFlowExecutionStatusDetailUnmarshaller();

            return instance;
        }
    }
}
    
