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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ReservedInstancesListing Object
    /// </summary>  
    public class ReservedInstancesListingUnmarshaller : IUnmarshaller<ReservedInstancesListing, XmlUnmarshallerContext>, IUnmarshaller<ReservedInstancesListing, JsonUnmarshallerContext>
    {
        public ReservedInstancesListing Unmarshall(XmlUnmarshallerContext context)
        {
            ReservedInstancesListing unmarshalledObject = new ReservedInstancesListing();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("clientToken", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ClientToken = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("createDate", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreateDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("instanceCounts/item", targetDepth))
                    {
                        var unmarshaller = InstanceCountUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.InstanceCounts.Add(item);
                        continue;
                    }
                    if (context.TestExpression("priceSchedules/item", targetDepth))
                    {
                        var unmarshaller = PriceScheduleUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.PriceSchedules.Add(item);
                        continue;
                    }
                    if (context.TestExpression("reservedInstancesId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ReservedInstancesId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("reservedInstancesListingId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ReservedInstancesListingId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("statusMessage", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StatusMessage = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Tags.Add(item);
                        continue;
                    }
                    if (context.TestExpression("updateDate", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.UpdateDate = unmarshaller.Unmarshall(context);
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

        public ReservedInstancesListing Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static ReservedInstancesListingUnmarshaller _instance = new ReservedInstancesListingUnmarshaller();        

        public static ReservedInstancesListingUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}