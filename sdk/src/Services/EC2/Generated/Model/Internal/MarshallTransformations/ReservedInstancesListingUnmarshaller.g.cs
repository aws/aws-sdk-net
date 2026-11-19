/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.EC2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ReservedInstancesListing Object
    /// </summary>
    public partial class ReservedInstancesListingUnmarshaller : IXmlUnmarshaller<ReservedInstancesListing, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ReservedInstancesListing Unmarshall(XmlUnmarshallerContext context)
        {
            ReservedInstancesListing unmarshalledObject = new ReservedInstancesListing();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument)
            {
                targetDepth += 2;
            }

            while (context.Read())
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
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreateDate = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("instanceCounts/item", targetDepth))
                    {
                        if (unmarshalledObject.InstanceCounts == null)
                        {
                            unmarshalledObject.InstanceCounts = new List<InstanceCount>();
                        }
                        var unmarshaller = InstanceCountUnmarshaller.Instance;
                        unmarshalledObject.InstanceCounts.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("priceSchedules/item", targetDepth))
                    {
                        if (unmarshalledObject.PriceSchedules == null)
                        {
                            unmarshalledObject.PriceSchedules = new List<PriceSchedule>();
                        }
                        var unmarshaller = PriceScheduleUnmarshaller.Instance;
                        unmarshalledObject.PriceSchedules.Add(unmarshaller.Unmarshall(context));
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
                        if (unmarshalledObject.Tags == null)
                        {
                            unmarshalledObject.Tags = new List<Tag>();
                        }
                        var unmarshaller = TagUnmarshaller.Instance;
                        unmarshalledObject.Tags.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("updateDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
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

        private static ReservedInstancesListingUnmarshaller _instance = new ReservedInstancesListingUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ReservedInstancesListingUnmarshaller Instance => _instance;
    }
}
