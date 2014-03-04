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
     ///   ReservedDBInstance Unmarshaller
     /// </summary>
    internal class ReservedDBInstanceUnmarshaller : IUnmarshaller<ReservedDBInstance, XmlUnmarshallerContext>, IUnmarshaller<ReservedDBInstance, JsonUnmarshallerContext> 
    {
        public ReservedDBInstance Unmarshall(XmlUnmarshallerContext context) 
        {
            ReservedDBInstance reservedDBInstance = new ReservedDBInstance();
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
                    if (context.TestExpression("ReservedDBInstanceId", targetDepth))
                    {
                        reservedDBInstance.ReservedDBInstanceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ReservedDBInstancesOfferingId", targetDepth))
                    {
                        reservedDBInstance.ReservedDBInstancesOfferingId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DBInstanceClass", targetDepth))
                    {
                        reservedDBInstance.DBInstanceClass = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("StartTime", targetDepth))
                    {
                        reservedDBInstance.StartTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Duration", targetDepth))
                    {
                        reservedDBInstance.Duration = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("FixedPrice", targetDepth))
                    {
                        reservedDBInstance.FixedPrice = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("UsagePrice", targetDepth))
                    {
                        reservedDBInstance.UsagePrice = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CurrencyCode", targetDepth))
                    {
                        reservedDBInstance.CurrencyCode = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DBInstanceCount", targetDepth))
                    {
                        reservedDBInstance.DBInstanceCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ProductDescription", targetDepth))
                    {
                        reservedDBInstance.ProductDescription = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("OfferingType", targetDepth))
                    {
                        reservedDBInstance.OfferingType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("MultiAZ", targetDepth))
                    {
                        reservedDBInstance.MultiAZ = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("State", targetDepth))
                    {
                        reservedDBInstance.State = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("RecurringCharges/RecurringCharge", targetDepth))
                    {
                        reservedDBInstance.RecurringCharges.Add(RecurringChargeUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return reservedDBInstance;
                }
            }
                        


            return reservedDBInstance;
        }

        public ReservedDBInstance Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ReservedDBInstanceUnmarshaller instance;

        public static ReservedDBInstanceUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ReservedDBInstanceUnmarshaller();

            return instance;
        }
    }
}
    
