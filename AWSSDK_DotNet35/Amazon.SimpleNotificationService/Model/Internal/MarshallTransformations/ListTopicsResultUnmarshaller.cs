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

using Amazon.SimpleNotificationService.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SimpleNotificationService.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   ListTopicsResult Unmarshaller
     /// </summary>
    internal class ListTopicsResultUnmarshaller : IUnmarshaller<ListTopicsResult, XmlUnmarshallerContext>, IUnmarshaller<ListTopicsResult, JsonUnmarshallerContext> 
    {
        public ListTopicsResult Unmarshall(XmlUnmarshallerContext context) 
        {
            ListTopicsResult listTopicsResult = new ListTopicsResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Topics/member", targetDepth))
                    {
                        listTopicsResult.Topics.Add(TopicUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("NextToken", targetDepth))
                    {
                        listTopicsResult.NextToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return listTopicsResult;
                }
            }
                        


            return listTopicsResult;
        }

        public ListTopicsResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ListTopicsResultUnmarshaller instance;

        public static ListTopicsResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ListTopicsResultUnmarshaller();

            return instance;
        }
    }
}
    
