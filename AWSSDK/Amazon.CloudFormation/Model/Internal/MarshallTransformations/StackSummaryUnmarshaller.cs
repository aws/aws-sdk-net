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
     ///   StackSummary Unmarshaller
     /// </summary>
    internal class StackSummaryUnmarshaller : IUnmarshaller<StackSummary, XmlUnmarshallerContext>, IUnmarshaller<StackSummary, JsonUnmarshallerContext> 
    {
        public StackSummary Unmarshall(XmlUnmarshallerContext context) 
        {
            StackSummary stackSummary = new StackSummary();
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
                        stackSummary.StackId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("StackName", targetDepth))
                    {
                        stackSummary.StackName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("TemplateDescription", targetDepth))
                    {
                        stackSummary.TemplateDescription = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CreationTime", targetDepth))
                    {
                        stackSummary.CreationTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("LastUpdatedTime", targetDepth))
                    {
                        stackSummary.LastUpdatedTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DeletionTime", targetDepth))
                    {
                        stackSummary.DeletionTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("StackStatus", targetDepth))
                    {
                        stackSummary.StackStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("StackStatusReason", targetDepth))
                    {
                        stackSummary.StackStatusReason = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return stackSummary;
                }
            }
                        


            return stackSummary;
        }

        public StackSummary Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static StackSummaryUnmarshaller instance;

        public static StackSummaryUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new StackSummaryUnmarshaller();

            return instance;
        }
    }
}
    
