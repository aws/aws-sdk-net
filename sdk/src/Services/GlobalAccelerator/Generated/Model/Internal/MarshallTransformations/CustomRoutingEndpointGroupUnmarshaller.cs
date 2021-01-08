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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GlobalAccelerator.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GlobalAccelerator.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CustomRoutingEndpointGroup Object
    /// </summary>  
    public class CustomRoutingEndpointGroupUnmarshaller : IUnmarshaller<CustomRoutingEndpointGroup, XmlUnmarshallerContext>, IUnmarshaller<CustomRoutingEndpointGroup, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CustomRoutingEndpointGroup IUnmarshaller<CustomRoutingEndpointGroup, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CustomRoutingEndpointGroup Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            CustomRoutingEndpointGroup unmarshalledObject = new CustomRoutingEndpointGroup();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DestinationDescriptions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<CustomRoutingDestinationDescription, CustomRoutingDestinationDescriptionUnmarshaller>(CustomRoutingDestinationDescriptionUnmarshaller.Instance);
                    unmarshalledObject.DestinationDescriptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndpointDescriptions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<CustomRoutingEndpointDescription, CustomRoutingEndpointDescriptionUnmarshaller>(CustomRoutingEndpointDescriptionUnmarshaller.Instance);
                    unmarshalledObject.EndpointDescriptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndpointGroupArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EndpointGroupArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndpointGroupRegion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EndpointGroupRegion = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CustomRoutingEndpointGroupUnmarshaller _instance = new CustomRoutingEndpointGroupUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CustomRoutingEndpointGroupUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}