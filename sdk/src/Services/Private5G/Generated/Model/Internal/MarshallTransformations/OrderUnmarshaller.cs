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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Private5G.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Private5G.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Order Object
    /// </summary>  
    public class OrderUnmarshaller : IUnmarshaller<Order, XmlUnmarshallerContext>, IUnmarshaller<Order, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Order IUnmarshaller<Order, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Order Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Order unmarshalledObject = new Order();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("acknowledgmentStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AcknowledgmentStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("networkArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NetworkArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("networkSiteArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NetworkSiteArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("orderArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OrderArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("orderedResources", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<OrderedResourceDefinition, OrderedResourceDefinitionUnmarshaller>(OrderedResourceDefinitionUnmarshaller.Instance);
                    unmarshalledObject.OrderedResources = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("shippingAddress", targetDepth))
                {
                    var unmarshaller = AddressUnmarshaller.Instance;
                    unmarshalledObject.ShippingAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("trackingInformation", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<TrackingInformation, TrackingInformationUnmarshaller>(TrackingInformationUnmarshaller.Instance);
                    unmarshalledObject.TrackingInformation = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static OrderUnmarshaller _instance = new OrderUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OrderUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}