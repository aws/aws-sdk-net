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

using Amazon.ElastiCache.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   DescribeReservedCacheNodesOfferingsResult Unmarshaller
     /// </summary>
    internal class DescribeReservedCacheNodesOfferingsResultUnmarshaller : IUnmarshaller<DescribeReservedCacheNodesOfferingsResult, XmlUnmarshallerContext> 
    {
        public DescribeReservedCacheNodesOfferingsResult Unmarshall(XmlUnmarshallerContext context) 
        {
            DescribeReservedCacheNodesOfferingsResult describeReservedCacheNodesOfferingsResult = new DescribeReservedCacheNodesOfferingsResult();
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
                        describeReservedCacheNodesOfferingsResult.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ReservedCacheNodesOfferings/ReservedCacheNodesOffering", targetDepth))
                    {
                        describeReservedCacheNodesOfferingsResult.ReservedCacheNodesOfferings.Add(ReservedCacheNodesOfferingUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return describeReservedCacheNodesOfferingsResult;
                }
            }
                        


            return describeReservedCacheNodesOfferingsResult;
        }

        private static DescribeReservedCacheNodesOfferingsResultUnmarshaller instance;

        public static DescribeReservedCacheNodesOfferingsResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DescribeReservedCacheNodesOfferingsResultUnmarshaller();

            return instance;
        }
    }
}
    
