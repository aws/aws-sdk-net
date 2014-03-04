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

using Amazon.ElastiCache.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   DescribeEventsResult Unmarshaller
     /// </summary>
    internal class DescribeEventsResultUnmarshaller : IUnmarshaller<DescribeEventsResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeEventsResult, JsonUnmarshallerContext> 
    {
        public DescribeEventsResult Unmarshall(XmlUnmarshallerContext context) 
        {
            DescribeEventsResult describeEventsResult = new DescribeEventsResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Marker", targetDepth))
                    {
                        describeEventsResult.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Events/Event", targetDepth))
                    {
                        describeEventsResult.Events.Add(EventUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return describeEventsResult;
                }
            }
                        


            return describeEventsResult;
        }

        public DescribeEventsResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DescribeEventsResultUnmarshaller instance;

        public static DescribeEventsResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DescribeEventsResultUnmarshaller();

            return instance;
        }
    }
}
    
