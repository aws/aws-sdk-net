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

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   ListAvailableSolutionStacksResult Unmarshaller
     /// </summary>
    internal class ListAvailableSolutionStacksResultUnmarshaller : IUnmarshaller<ListAvailableSolutionStacksResult, XmlUnmarshallerContext> 
    {
        public ListAvailableSolutionStacksResult Unmarshall(XmlUnmarshallerContext context) 
        {
            ListAvailableSolutionStacksResult listAvailableSolutionStacksResult = new ListAvailableSolutionStacksResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("SolutionStacks/member", targetDepth))
                    {
                        listAvailableSolutionStacksResult.SolutionStacks.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("SolutionStackDetails/member", targetDepth))
                    {
                        listAvailableSolutionStacksResult.SolutionStackDetails.Add(SolutionStackDescriptionUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return listAvailableSolutionStacksResult;
                }
            }
                        


            return listAvailableSolutionStacksResult;
        }

        private static ListAvailableSolutionStacksResultUnmarshaller instance;

        public static ListAvailableSolutionStacksResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ListAvailableSolutionStacksResultUnmarshaller();

            return instance;
        }
    }
}
    
