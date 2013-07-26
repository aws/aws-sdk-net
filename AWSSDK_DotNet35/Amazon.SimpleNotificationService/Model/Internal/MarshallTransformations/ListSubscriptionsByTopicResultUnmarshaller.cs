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
     ///   ListSubscriptionsByTopicResult Unmarshaller
     /// </summary>
    internal class ListSubscriptionsByTopicResultUnmarshaller : IUnmarshaller<ListSubscriptionsByTopicResult, XmlUnmarshallerContext>, IUnmarshaller<ListSubscriptionsByTopicResult, JsonUnmarshallerContext> 
    {
        public ListSubscriptionsByTopicResult Unmarshall(XmlUnmarshallerContext context) 
        {
            ListSubscriptionsByTopicResult listSubscriptionsByTopicResult = new ListSubscriptionsByTopicResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Subscriptions/member", targetDepth))
                    {
                        listSubscriptionsByTopicResult.Subscriptions.Add(SubscriptionUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("NextToken", targetDepth))
                    {
                        listSubscriptionsByTopicResult.NextToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return listSubscriptionsByTopicResult;
                }
            }
                        


            return listSubscriptionsByTopicResult;
        }

        public ListSubscriptionsByTopicResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ListSubscriptionsByTopicResultUnmarshaller instance;

        public static ListSubscriptionsByTopicResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ListSubscriptionsByTopicResultUnmarshaller();

            return instance;
        }
    }
}
    
