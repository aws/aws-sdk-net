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
     ///   ReservedCacheNodesOffering Unmarshaller
     /// </summary>
    internal class ReservedCacheNodesOfferingUnmarshaller : IUnmarshaller<ReservedCacheNodesOffering, XmlUnmarshallerContext> 
    {
        public ReservedCacheNodesOffering Unmarshall(XmlUnmarshallerContext context) 
        {
            ReservedCacheNodesOffering reservedCacheNodesOffering = new ReservedCacheNodesOffering();
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
                    if (context.TestExpression("ReservedCacheNodesOfferingId", targetDepth))
                    {
                        reservedCacheNodesOffering.ReservedCacheNodesOfferingId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CacheNodeType", targetDepth))
                    {
                        reservedCacheNodesOffering.CacheNodeType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Duration", targetDepth))
                    {
                        reservedCacheNodesOffering.Duration = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("FixedPrice", targetDepth))
                    {
                        reservedCacheNodesOffering.FixedPrice = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("UsagePrice", targetDepth))
                    {
                        reservedCacheNodesOffering.UsagePrice = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ProductDescription", targetDepth))
                    {
                        reservedCacheNodesOffering.ProductDescription = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("OfferingType", targetDepth))
                    {
                        reservedCacheNodesOffering.OfferingType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("RecurringCharges/RecurringCharge", targetDepth))
                    {
                        reservedCacheNodesOffering.RecurringCharges.Add(RecurringChargeUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return reservedCacheNodesOffering;
                }
            }
                        


            return reservedCacheNodesOffering;
        }

        private static ReservedCacheNodesOfferingUnmarshaller instance;

        public static ReservedCacheNodesOfferingUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ReservedCacheNodesOfferingUnmarshaller();

            return instance;
        }
    }
}
    
