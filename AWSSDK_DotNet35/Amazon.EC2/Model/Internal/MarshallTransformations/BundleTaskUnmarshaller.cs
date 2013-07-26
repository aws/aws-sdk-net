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

using Amazon.EC2.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   BundleTask Unmarshaller
     /// </summary>
    internal class BundleTaskUnmarshaller : IUnmarshaller<BundleTask, XmlUnmarshallerContext>, IUnmarshaller<BundleTask, JsonUnmarshallerContext> 
    {
        public BundleTask Unmarshall(XmlUnmarshallerContext context) 
        {
            BundleTask bundleTask = new BundleTask();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("instanceId", targetDepth))
                    {
                        bundleTask.InstanceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("bundleId", targetDepth))
                    {
                        bundleTask.BundleId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("state", targetDepth))
                    {
                        bundleTask.State = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("startTime", targetDepth))
                    {
                        bundleTask.StartTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("updateTime", targetDepth))
                    {
                        bundleTask.UpdateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("storage", targetDepth))
                    {
                        bundleTask.Storage = StorageUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("progress", targetDepth))
                    {
                        bundleTask.Progress = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("error", targetDepth))
                    {
                        bundleTask.BundleTaskError = BundleTaskErrorUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return bundleTask;
                }
            }
                        


            return bundleTask;
        }

        public BundleTask Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static BundleTaskUnmarshaller instance;

        public static BundleTaskUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new BundleTaskUnmarshaller();

            return instance;
        }
    }
}
    
