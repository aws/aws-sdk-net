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
    /// Response Unmarshaller for ExpectedRoute Object
    /// </summary>  
    public class ExpectedRouteUnmarshaller : IUnmarshaller<ExpectedRoute, XmlUnmarshallerContext>, IUnmarshaller<ExpectedRoute, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ExpectedRoute IUnmarshaller<ExpectedRoute, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ExpectedRoute Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ExpectedRoute unmarshalledObject = new ExpectedRoute();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AllowedTargets", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AllowedTargets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ContributingSubnets", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ContributingSubnets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IpV4Cidr", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IpV4Cidr = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IpV6Cidr", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IpV6Cidr = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PrefixListId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrefixListId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RouteTableId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RouteTableId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ExpectedRouteUnmarshaller _instance = new ExpectedRouteUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ExpectedRouteUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}