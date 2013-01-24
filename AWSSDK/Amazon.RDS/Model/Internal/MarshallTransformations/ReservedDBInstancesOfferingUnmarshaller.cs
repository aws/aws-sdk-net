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

using Amazon.RDS.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   ReservedDBInstancesOffering Unmarshaller
     /// </summary>
    internal class ReservedDBInstancesOfferingUnmarshaller : IUnmarshaller<ReservedDBInstancesOffering, XmlUnmarshallerContext>, IUnmarshaller<ReservedDBInstancesOffering, JsonUnmarshallerContext> 
    {
        public ReservedDBInstancesOffering Unmarshall(XmlUnmarshallerContext context) 
        {
            ReservedDBInstancesOffering reservedDBInstancesOffering = new ReservedDBInstancesOffering();
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
                    if (context.TestExpression("ReservedDBInstancesOfferingId", targetDepth))
                    {
                        reservedDBInstancesOffering.ReservedDBInstancesOfferingId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DBInstanceClass", targetDepth))
                    {
                        reservedDBInstancesOffering.DBInstanceClass = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Duration", targetDepth))
                    {
                        reservedDBInstancesOffering.Duration = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("FixedPrice", targetDepth))
                    {
                        reservedDBInstancesOffering.FixedPrice = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("UsagePrice", targetDepth))
                    {
                        reservedDBInstancesOffering.UsagePrice = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CurrencyCode", targetDepth))
                    {
                        reservedDBInstancesOffering.CurrencyCode = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ProductDescription", targetDepth))
                    {
                        reservedDBInstancesOffering.ProductDescription = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("OfferingType", targetDepth))
                    {
                        reservedDBInstancesOffering.OfferingType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("MultiAZ", targetDepth))
                    {
                        reservedDBInstancesOffering.MultiAZ = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("RecurringCharges/RecurringCharge", targetDepth))
                    {
                        reservedDBInstancesOffering.RecurringCharges.Add(RecurringChargeUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return reservedDBInstancesOffering;
                }
            }
                        


            return reservedDBInstancesOffering;
        }

        public ReservedDBInstancesOffering Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ReservedDBInstancesOfferingUnmarshaller instance;

        public static ReservedDBInstancesOfferingUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ReservedDBInstancesOfferingUnmarshaller();

            return instance;
        }
    }
}
    
