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
     ///   ListStackResourcesResult Unmarshaller
     /// </summary>
    internal class ListStackResourcesResultUnmarshaller : IUnmarshaller<ListStackResourcesResult, XmlUnmarshallerContext>, IUnmarshaller<ListStackResourcesResult, JsonUnmarshallerContext> 
    {
        public ListStackResourcesResult Unmarshall(XmlUnmarshallerContext context) 
        {
            ListStackResourcesResult listStackResourcesResult = new ListStackResourcesResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("StackResourceSummaries/member", targetDepth))
                    {
                        listStackResourcesResult.StackResourceSummaries.Add(StackResourceSummaryUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("NextToken", targetDepth))
                    {
                        listStackResourcesResult.NextToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return listStackResourcesResult;
                }
            }
                        


            return listStackResourcesResult;
        }

        public ListStackResourcesResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ListStackResourcesResultUnmarshaller instance;

        public static ListStackResourcesResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ListStackResourcesResultUnmarshaller();

            return instance;
        }
    }
}
    
