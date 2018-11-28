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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeDeploy.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeDeploy.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TargetGroupPairInfo Object
    /// </summary>  
    public class TargetGroupPairInfoUnmarshaller : IUnmarshaller<TargetGroupPairInfo, XmlUnmarshallerContext>, IUnmarshaller<TargetGroupPairInfo, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TargetGroupPairInfo IUnmarshaller<TargetGroupPairInfo, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TargetGroupPairInfo Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            TargetGroupPairInfo unmarshalledObject = new TargetGroupPairInfo();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("prodTrafficRoute", targetDepth))
                {
                    var unmarshaller = TrafficRouteUnmarshaller.Instance;
                    unmarshalledObject.ProdTrafficRoute = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("targetGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<TargetGroupInfo, TargetGroupInfoUnmarshaller>(TargetGroupInfoUnmarshaller.Instance);
                    unmarshalledObject.TargetGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("testTrafficRoute", targetDepth))
                {
                    var unmarshaller = TrafficRouteUnmarshaller.Instance;
                    unmarshalledObject.TestTrafficRoute = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static TargetGroupPairInfoUnmarshaller _instance = new TargetGroupPairInfoUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TargetGroupPairInfoUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}