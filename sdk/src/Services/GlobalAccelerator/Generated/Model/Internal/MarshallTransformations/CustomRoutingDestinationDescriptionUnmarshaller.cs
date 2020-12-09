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
    /// Response Unmarshaller for CustomRoutingDestinationDescription Object
    /// </summary>  
    public class CustomRoutingDestinationDescriptionUnmarshaller : IUnmarshaller<CustomRoutingDestinationDescription, XmlUnmarshallerContext>, IUnmarshaller<CustomRoutingDestinationDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CustomRoutingDestinationDescription IUnmarshaller<CustomRoutingDestinationDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CustomRoutingDestinationDescription Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            CustomRoutingDestinationDescription unmarshalledObject = new CustomRoutingDestinationDescription();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("FromPort", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.FromPort = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Protocols", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Protocols = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ToPort", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ToPort = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CustomRoutingDestinationDescriptionUnmarshaller _instance = new CustomRoutingDestinationDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CustomRoutingDestinationDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}