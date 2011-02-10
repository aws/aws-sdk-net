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
     ///   DescribeDBInstancesResult Unmarshaller
     /// </summary>
    internal class DescribeDBInstancesResultUnmarshaller : IUnmarshaller<DescribeDBInstancesResult, UnmarshallerContext> 
    {
        public DescribeDBInstancesResult Unmarshall(UnmarshallerContext context) 
        {
            DescribeDBInstancesResult describeDBInstancesResult = new DescribeDBInstancesResult();
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
                        describeDBInstancesResult.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DBInstances/DBInstance", targetDepth))
                    {
                        describeDBInstancesResult.DBInstances.Add(DBInstanceUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return describeDBInstancesResult;
                }
            }

            return describeDBInstancesResult;
        }

        private static DescribeDBInstancesResultUnmarshaller instance;

        public static DescribeDBInstancesResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DescribeDBInstancesResultUnmarshaller();

            return instance;
        }
    }
}
    
