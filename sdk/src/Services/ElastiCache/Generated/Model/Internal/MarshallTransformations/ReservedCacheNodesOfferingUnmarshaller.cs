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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ReservedCacheNodesOffering Object
    /// </summary>  
    public class ReservedCacheNodesOfferingUnmarshaller : IXmlUnmarshaller<ReservedCacheNodesOffering, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ReservedCacheNodesOffering Unmarshall(XmlUnmarshallerContext context)
        {
            ReservedCacheNodesOffering unmarshalledObject = new ReservedCacheNodesOffering();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("CacheNodeType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CacheNodeType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Duration", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.Duration = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("FixedPrice", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.FixedPrice = unmarshaller.Unmarshall(context);
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
                        if (unmarshalledObject.RecurringCharges == null)
                        {
                            unmarshalledObject.RecurringCharges = new List<RecurringCharge>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.RecurringCharges.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ReservedCacheNodesOfferingId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ReservedCacheNodesOfferingId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("UsagePrice", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
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

        private static ReservedCacheNodesOfferingUnmarshaller _instance = new ReservedCacheNodesOfferingUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReservedCacheNodesOfferingUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}