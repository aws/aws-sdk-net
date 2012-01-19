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

using Amazon.CloudWatch.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudWatch.Model.Transform
{
     /// <summary>
     ///   ListMetricsResult Unmarshaller
     /// </summary>
    internal class ListMetricsResultUnmarshaller : IUnmarshaller<ListMetricsResult, UnmarshallerContext> 
    {
        public ListMetricsResult Unmarshall(UnmarshallerContext context) 
        {
            ListMetricsResult listMetricsResult = new ListMetricsResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Metrics/member", targetDepth))
                    {
                        listMetricsResult.Metrics.Add(MetricUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("NextToken", targetDepth))
                    {
                        listMetricsResult.NextToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return listMetricsResult;
                }
            }

            return listMetricsResult;
        }

        private static ListMetricsResultUnmarshaller instance;

        public static ListMetricsResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ListMetricsResultUnmarshaller();

            return instance;
        }
    }
}
    
