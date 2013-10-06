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

using Amazon.CloudFormation.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   StackEvent Unmarshaller
     /// </summary>
    internal class StackEventUnmarshaller : IUnmarshaller<StackEvent, XmlUnmarshallerContext>, IUnmarshaller<StackEvent, JsonUnmarshallerContext> 
    {
        public StackEvent Unmarshall(XmlUnmarshallerContext context) 
        {
            StackEvent stackEvent = new StackEvent();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("StackId", targetDepth))
                    {
                        stackEvent.StackId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("EventId", targetDepth))
                    {
                        stackEvent.EventId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("StackName", targetDepth))
                    {
                        stackEvent.StackName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("LogicalResourceId", targetDepth))
                    {
                        stackEvent.LogicalResourceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("PhysicalResourceId", targetDepth))
                    {
                        stackEvent.PhysicalResourceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ResourceType", targetDepth))
                    {
                        stackEvent.ResourceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Timestamp", targetDepth))
                    {
                        stackEvent.Timestamp = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ResourceStatus", targetDepth))
                    {
                        stackEvent.ResourceStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ResourceStatusReason", targetDepth))
                    {
                        stackEvent.ResourceStatusReason = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ResourceProperties", targetDepth))
                    {
                        stackEvent.ResourceProperties = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return stackEvent;
                }
            }
                        


            return stackEvent;
        }

        public StackEvent Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static StackEventUnmarshaller instance;

        public static StackEventUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new StackEventUnmarshaller();

            return instance;
        }
    }
}
    
