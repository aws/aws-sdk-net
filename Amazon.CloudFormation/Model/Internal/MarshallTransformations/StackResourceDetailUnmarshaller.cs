/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.CloudFormation.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   StackResourceDetail Unmarshaller
     /// </summary>
    internal class StackResourceDetailUnmarshaller : IUnmarshaller<StackResourceDetail, UnmarshallerContext> 
    {
        public StackResourceDetail Unmarshall(UnmarshallerContext context) 
        {
            StackResourceDetail stackResourceDetail = new StackResourceDetail();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("StackName", targetDepth))
                    {
                        stackResourceDetail.StackName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("StackId", targetDepth))
                    {
                        stackResourceDetail.StackId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("LogicalResourceId", targetDepth))
                    {
                        stackResourceDetail.LogicalResourceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("PhysicalResourceId", targetDepth))
                    {
                        stackResourceDetail.PhysicalResourceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ResourceType", targetDepth))
                    {
                        stackResourceDetail.ResourceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("LastUpdatedTimestamp", targetDepth))
                    {
                        stackResourceDetail.LastUpdatedTimestamp = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ResourceStatus", targetDepth))
                    {
                        stackResourceDetail.ResourceStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ResourceStatusReason", targetDepth))
                    {
                        stackResourceDetail.ResourceStatusReason = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Description", targetDepth))
                    {
                        stackResourceDetail.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Metadata", targetDepth))
                    {
                        stackResourceDetail.Metadata = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return stackResourceDetail;
                }
            }

            return stackResourceDetail;
        }

        private static StackResourceDetailUnmarshaller instance;

        public static StackResourceDetailUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new StackResourceDetailUnmarshaller();

            return instance;
        }
    }
}
    
