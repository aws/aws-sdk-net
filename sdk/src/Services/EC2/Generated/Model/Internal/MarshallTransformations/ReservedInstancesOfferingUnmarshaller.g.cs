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
    /// Response Unmarshaller for ReservedInstancesOffering Object
    /// </summary>
    public partial class ReservedInstancesOfferingUnmarshaller : IXmlUnmarshaller<ReservedInstancesOffering, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ReservedInstancesOffering Unmarshall(XmlUnmarshallerContext context)
        {
            ReservedInstancesOffering unmarshalledObject = new ReservedInstancesOffering();
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
                    if (context.TestExpression("availabilityZone", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("availabilityZoneId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AvailabilityZoneId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("currencyCode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CurrencyCode = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("duration", targetDepth))
                    {
                        var unmarshaller = NullableLongUnmarshaller.Instance;
                        unmarshalledObject.Duration = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("fixedPrice", targetDepth))
                    {
                        var unmarshaller = NullableFloatUnmarshaller.Instance;
                        unmarshalledObject.FixedPrice = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("instanceTenancy", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InstanceTenancy = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("instanceType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("marketplace", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.Marketplace = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("offeringClass", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OfferingClass = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("offeringType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OfferingType = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("pricingDetailsSet/item", targetDepth))
                    {
                        if (unmarshalledObject.PricingDetails == null)
                        {
                            unmarshalledObject.PricingDetails = new List<PricingDetail>();
                        }
                        var unmarshaller = PricingDetailUnmarshaller.Instance;
                        unmarshalledObject.PricingDetails.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("productDescription", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ProductDescription = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("recurringCharges/item", targetDepth))
                    {
                        if (unmarshalledObject.RecurringCharges == null)
                        {
                            unmarshalledObject.RecurringCharges = new List<RecurringCharge>();
                        }
                        var unmarshaller = RecurringChargeUnmarshaller.Instance;
                        unmarshalledObject.RecurringCharges.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("reservedInstancesOfferingId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ReservedInstancesOfferingId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("scope", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Scope = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("usagePrice", targetDepth))
                    {
                        var unmarshaller = NullableFloatUnmarshaller.Instance;
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

        private static ReservedInstancesOfferingUnmarshaller _instance = new ReservedInstancesOfferingUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ReservedInstancesOfferingUnmarshaller Instance => _instance;
    }
}
