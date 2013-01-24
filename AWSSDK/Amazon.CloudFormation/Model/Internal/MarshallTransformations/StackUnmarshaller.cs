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
     ///   Stack Unmarshaller
     /// </summary>
    internal class StackUnmarshaller : IUnmarshaller<Stack, XmlUnmarshallerContext>, IUnmarshaller<Stack, JsonUnmarshallerContext> 
    {
        public Stack Unmarshall(XmlUnmarshallerContext context) 
        {
            Stack stack = new Stack();
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
                        stack.StackId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("StackName", targetDepth))
                    {
                        stack.StackName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Description", targetDepth))
                    {
                        stack.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Parameters/member", targetDepth))
                    {
                        stack.Parameters.Add(ParameterUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("CreationTime", targetDepth))
                    {
                        stack.CreationTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("LastUpdatedTime", targetDepth))
                    {
                        stack.LastUpdatedTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("StackStatus", targetDepth))
                    {
                        stack.StackStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("StackStatusReason", targetDepth))
                    {
                        stack.StackStatusReason = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DisableRollback", targetDepth))
                    {
                        stack.DisableRollback = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("NotificationARNs/member", targetDepth))
                    {
                        stack.NotificationARNs.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("TimeoutInMinutes", targetDepth))
                    {
                        stack.TimeoutInMinutes = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Capabilities/member", targetDepth))
                    {
                        stack.Capabilities.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("Outputs/member", targetDepth))
                    {
                        stack.Outputs.Add(OutputUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("Tags/member", targetDepth))
                    {
                        stack.Tags.Add(TagUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return stack;
                }
            }
                        


            return stack;
        }

        public Stack Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static StackUnmarshaller instance;

        public static StackUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new StackUnmarshaller();

            return instance;
        }
    }
}
    
