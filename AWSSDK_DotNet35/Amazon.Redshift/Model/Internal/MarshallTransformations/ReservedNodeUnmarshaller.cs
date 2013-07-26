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
     ///   ReservedNode Unmarshaller
     /// </summary>
    internal class ReservedNodeUnmarshaller : IUnmarshaller<ReservedNode, XmlUnmarshallerContext>, IUnmarshaller<ReservedNode, JsonUnmarshallerContext> 
    {
        public ReservedNode Unmarshall(XmlUnmarshallerContext context) 
        {
            ReservedNode reservedNode = new ReservedNode();
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
                    if (context.TestExpression("ReservedNodeId", targetDepth))
                    {
                        reservedNode.ReservedNodeId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ReservedNodeOfferingId", targetDepth))
                    {
                        reservedNode.ReservedNodeOfferingId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("NodeType", targetDepth))
                    {
                        reservedNode.NodeType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("StartTime", targetDepth))
                    {
                        reservedNode.StartTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Duration", targetDepth))
                    {
                        reservedNode.Duration = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("FixedPrice", targetDepth))
                    {
                        reservedNode.FixedPrice = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("UsagePrice", targetDepth))
                    {
                        reservedNode.UsagePrice = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("CurrencyCode", targetDepth))
                    {
                        reservedNode.CurrencyCode = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("NodeCount", targetDepth))
                    {
                        reservedNode.NodeCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("State", targetDepth))
                    {
                        reservedNode.State = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("OfferingType", targetDepth))
                    {
                        reservedNode.OfferingType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("RecurringCharges/RecurringCharge", targetDepth))
                    {
                        reservedNode.RecurringCharges.Add(RecurringChargeUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return reservedNode;
                }
            }
                        


            return reservedNode;
        }

        public ReservedNode Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ReservedNodeUnmarshaller instance;

        public static ReservedNodeUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ReservedNodeUnmarshaller();

            return instance;
        }
    }
}
    
