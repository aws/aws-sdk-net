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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.FMS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EC2DeleteRouteAction Object
    /// </summary>  
    public class EC2DeleteRouteActionUnmarshaller : IUnmarshaller<EC2DeleteRouteAction, XmlUnmarshallerContext>, IUnmarshaller<EC2DeleteRouteAction, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        EC2DeleteRouteAction IUnmarshaller<EC2DeleteRouteAction, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public EC2DeleteRouteAction Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            EC2DeleteRouteAction unmarshalledObject = new EC2DeleteRouteAction();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DestinationCidrBlock", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DestinationCidrBlock = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DestinationIpv6CidrBlock", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DestinationIpv6CidrBlock = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DestinationPrefixListId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DestinationPrefixListId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RouteTableId", targetDepth))
                {
                    var unmarshaller = ActionTargetUnmarshaller.Instance;
                    unmarshalledObject.RouteTableId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static EC2DeleteRouteActionUnmarshaller _instance = new EC2DeleteRouteActionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EC2DeleteRouteActionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}