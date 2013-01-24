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
     ///   StackResourceSummary Unmarshaller
     /// </summary>
    internal class StackResourceSummaryUnmarshaller : IUnmarshaller<StackResourceSummary, XmlUnmarshallerContext>, IUnmarshaller<StackResourceSummary, JsonUnmarshallerContext> 
    {
        public StackResourceSummary Unmarshall(XmlUnmarshallerContext context) 
        {
            StackResourceSummary stackResourceSummary = new StackResourceSummary();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("LogicalResourceId", targetDepth))
                    {
                        stackResourceSummary.LogicalResourceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("PhysicalResourceId", targetDepth))
                    {
                        stackResourceSummary.PhysicalResourceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ResourceType", targetDepth))
                    {
                        stackResourceSummary.ResourceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("LastUpdatedTimestamp", targetDepth))
                    {
                        stackResourceSummary.LastUpdatedTimestamp = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ResourceStatus", targetDepth))
                    {
                        stackResourceSummary.ResourceStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ResourceStatusReason", targetDepth))
                    {
                        stackResourceSummary.ResourceStatusReason = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return stackResourceSummary;
                }
            }
                        


            return stackResourceSummary;
        }

        public StackResourceSummary Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static StackResourceSummaryUnmarshaller instance;

        public static StackResourceSummaryUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new StackResourceSummaryUnmarshaller();

            return instance;
        }
    }
}
    
