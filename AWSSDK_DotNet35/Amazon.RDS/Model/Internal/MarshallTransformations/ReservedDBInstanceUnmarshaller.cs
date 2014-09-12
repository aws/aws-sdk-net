/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the rds-2013-09-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ReservedDBInstance Object
    /// </summary>  
    public class ReservedDBInstanceUnmarshaller : IUnmarshaller<ReservedDBInstance, XmlUnmarshallerContext>, IUnmarshaller<ReservedDBInstance, JsonUnmarshallerContext>
    {
        public ReservedDBInstance Unmarshall(XmlUnmarshallerContext context)
        {
            ReservedDBInstance unmarshalledObject = new ReservedDBInstance();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("CurrencyCode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CurrencyCode = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBInstanceClass", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBInstanceClass = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBInstanceCount", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.DBInstanceCount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Duration", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.Duration = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("FixedPrice", targetDepth))
                    {
                        var unmarshaller = DoubleUnmarshaller.Instance;
                        unmarshalledObject.FixedPrice = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MultiAZ", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.MultiAZ = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("OfferingType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OfferingType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ProductDescription", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ProductDescription = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RecurringCharges/RecurringCharge", targetDepth))
                    {
                        var unmarshaller = RecurringChargeUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.RecurringCharges.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ReservedDBInstanceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ReservedDBInstanceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ReservedDBInstancesOfferingId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ReservedDBInstancesOfferingId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StartTime", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.StartTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("State", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.State = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("UsagePrice", targetDepth))
                    {
                        var unmarshaller = DoubleUnmarshaller.Instance;
                        unmarshalledObject.UsagePrice = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        public ReservedDBInstance Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static ReservedDBInstanceUnmarshaller _instance = new ReservedDBInstanceUnmarshaller();        

        public static ReservedDBInstanceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}