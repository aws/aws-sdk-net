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
     ///   ReservedCacheNode Unmarshaller
     /// </summary>
    internal class ReservedCacheNodeUnmarshaller : IUnmarshaller<ReservedCacheNode, XmlUnmarshallerContext>, IUnmarshaller<ReservedCacheNode, JsonUnmarshallerContext> 
    {
        public ReservedCacheNode Unmarshall(XmlUnmarshallerContext context) 
        {
            ReservedCacheNode reservedCacheNode = new ReservedCacheNode();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            if (context.IsStartOfDocument) 
               targetDepth++;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("ReservedCacheNodeId", targetDepth))
                    {
                        reservedCacheNode.ReservedCacheNodeId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ReservedCacheNodesOfferingId", targetDepth))
                    {
                        reservedCacheNode.ReservedCacheNodesOfferingId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CacheNodeType", targetDepth))
                    {
                        reservedCacheNode.CacheNodeType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("StartTime", targetDepth))
                    {
                        reservedCacheNode.StartTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Duration", targetDepth))
                    {
                        reservedCacheNode.Duration = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("FixedPrice", targetDepth))
                    {
                        reservedCacheNode.FixedPrice = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("UsagePrice", targetDepth))
                    {
                        reservedCacheNode.UsagePrice = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CacheNodeCount", targetDepth))
                    {
                        reservedCacheNode.CacheNodeCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ProductDescription", targetDepth))
                    {
                        reservedCacheNode.ProductDescription = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("OfferingType", targetDepth))
                    {
                        reservedCacheNode.OfferingType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("State", targetDepth))
                    {
                        reservedCacheNode.State = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("RecurringCharges/RecurringCharge", targetDepth))
                    {
                        reservedCacheNode.RecurringCharges.Add(RecurringChargeUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return reservedCacheNode;
                }
            }
                        


            return reservedCacheNode;
        }

        public ReservedCacheNode Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ReservedCacheNodeUnmarshaller instance;

        public static ReservedCacheNodeUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ReservedCacheNodeUnmarshaller();

            return instance;
        }
    }
}
    
