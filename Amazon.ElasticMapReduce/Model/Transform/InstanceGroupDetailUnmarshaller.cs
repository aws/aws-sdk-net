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
     ///   InstanceGroupDetail Unmarshaller
     /// </summary>
    internal class InstanceGroupDetailUnmarshaller : IUnmarshaller<InstanceGroupDetail, UnmarshallerContext> 
    {
        public InstanceGroupDetail Unmarshall(UnmarshallerContext context) 
        {
            InstanceGroupDetail instanceGroupDetail = new InstanceGroupDetail();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("InstanceGroupId", targetDepth))
                    {
                        instanceGroupDetail.InstanceGroupId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Name", targetDepth))
                    {
                        instanceGroupDetail.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Market", targetDepth))
                    {
                        instanceGroupDetail.Market = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("InstanceRole", targetDepth))
                    {
                        instanceGroupDetail.InstanceRole = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("InstanceType", targetDepth))
                    {
                        instanceGroupDetail.InstanceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("InstanceRequestCount", targetDepth))
                    {
                        instanceGroupDetail.InstanceRequestCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("InstanceRunningCount", targetDepth))
                    {
                        instanceGroupDetail.InstanceRunningCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("State", targetDepth))
                    {
                        instanceGroupDetail.State = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("LastStateChangeReason", targetDepth))
                    {
                        instanceGroupDetail.LastStateChangeReason = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("CreationDateTime", targetDepth))
                    {
                        instanceGroupDetail.CreationDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("StartDateTime", targetDepth))
                    {
                        instanceGroupDetail.StartDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ReadyDateTime", targetDepth))
                    {
                        instanceGroupDetail.ReadyDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("EndDateTime", targetDepth))
                    {
                        instanceGroupDetail.EndDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return instanceGroupDetail;
                }
            }

            return instanceGroupDetail;
        }

        private static InstanceGroupDetailUnmarshaller instance;

        public static InstanceGroupDetailUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new InstanceGroupDetailUnmarshaller();

            return instance;
        }
    }
}
    
