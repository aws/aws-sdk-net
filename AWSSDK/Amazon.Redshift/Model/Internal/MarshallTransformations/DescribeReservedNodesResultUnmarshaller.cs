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

using Amazon.Redshift.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   DescribeReservedNodesResult Unmarshaller
     /// </summary>
    internal class DescribeReservedNodesResultUnmarshaller : IUnmarshaller<DescribeReservedNodesResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeReservedNodesResult, JsonUnmarshallerContext> 
    {
        public DescribeReservedNodesResult Unmarshall(XmlUnmarshallerContext context) 
        {
            DescribeReservedNodesResult describeReservedNodesResult = new DescribeReservedNodesResult();
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
                        describeReservedNodesResult.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ReservedNodes/ReservedNode", targetDepth))
                    {
                        describeReservedNodesResult.ReservedNodes.Add(ReservedNodeUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return describeReservedNodesResult;
                }
            }
                        


            return describeReservedNodesResult;
        }

        public DescribeReservedNodesResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DescribeReservedNodesResultUnmarshaller instance;

        public static DescribeReservedNodesResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DescribeReservedNodesResultUnmarshaller();

            return instance;
        }
    }
}
    
