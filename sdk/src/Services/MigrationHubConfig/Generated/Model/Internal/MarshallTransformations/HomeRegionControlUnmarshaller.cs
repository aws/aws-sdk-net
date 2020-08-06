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
 * Do not modify this file. This file is generated from the migrationhub-config-2019-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MigrationHubConfig.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MigrationHubConfig.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for HomeRegionControl Object
    /// </summary>  
    public class HomeRegionControlUnmarshaller : IUnmarshaller<HomeRegionControl, XmlUnmarshallerContext>, IUnmarshaller<HomeRegionControl, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        HomeRegionControl IUnmarshaller<HomeRegionControl, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public HomeRegionControl Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            HomeRegionControl unmarshalledObject = new HomeRegionControl();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ControlId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ControlId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HomeRegion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HomeRegion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RequestedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.RequestedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Target", targetDepth))
                {
                    var unmarshaller = TargetUnmarshaller.Instance;
                    unmarshalledObject.Target = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static HomeRegionControlUnmarshaller _instance = new HomeRegionControlUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HomeRegionControlUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}