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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ARCRegionswitch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ARCRegionswitch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ArcRoutingControlConfiguration Object
    /// </summary>  
    public class ArcRoutingControlConfigurationUnmarshaller : IUnmarshaller<ArcRoutingControlConfiguration, XmlUnmarshallerContext>, IUnmarshaller<ArcRoutingControlConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ArcRoutingControlConfiguration IUnmarshaller<ArcRoutingControlConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ArcRoutingControlConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            ArcRoutingControlConfiguration unmarshalledObject = new ArcRoutingControlConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("crossAccountRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CrossAccountRole = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("externalId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExternalId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("regionAndRoutingControls", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, List<ArcRoutingControlState>, StringUnmarshaller, ListUnmarshaller<ArcRoutingControlState, ArcRoutingControlStateUnmarshaller>>(StringUnmarshaller.Instance, new ListUnmarshaller<ArcRoutingControlState, ArcRoutingControlStateUnmarshaller>(ArcRoutingControlStateUnmarshaller.Instance));
                    unmarshalledObject.RegionAndRoutingControls = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timeoutMinutes", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TimeoutMinutes = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ArcRoutingControlConfigurationUnmarshaller _instance = new ArcRoutingControlConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ArcRoutingControlConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}