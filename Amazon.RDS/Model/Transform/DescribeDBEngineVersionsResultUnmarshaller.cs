/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.RDS.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.RDS.Model.Transform
{
     /// <summary>
     ///   DescribeDBEngineVersionsResult Unmarshaller
     /// </summary>
    internal class DescribeDBEngineVersionsResultUnmarshaller : IUnmarshaller<DescribeDBEngineVersionsResult, UnmarshallerContext> 
    {
        public DescribeDBEngineVersionsResult Unmarshall(UnmarshallerContext context) 
        {
            DescribeDBEngineVersionsResult describeDBEngineVersionsResult = new DescribeDBEngineVersionsResult();
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
                        describeDBEngineVersionsResult.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DBEngineVersions/DBEngineVersion", targetDepth))
                    {
                        describeDBEngineVersionsResult.DBEngineVersions.Add(DBEngineVersionUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return describeDBEngineVersionsResult;
                }
            }

            return describeDBEngineVersionsResult;
        }

        private static DescribeDBEngineVersionsResultUnmarshaller instance;

        public static DescribeDBEngineVersionsResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DescribeDBEngineVersionsResultUnmarshaller();

            return instance;
        }
    }
}
    
