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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Outposts.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Outposts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RackPhysicalProperties Object
    /// </summary>  
    public class RackPhysicalPropertiesUnmarshaller : IUnmarshaller<RackPhysicalProperties, XmlUnmarshallerContext>, IUnmarshaller<RackPhysicalProperties, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RackPhysicalProperties IUnmarshaller<RackPhysicalProperties, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RackPhysicalProperties Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            RackPhysicalProperties unmarshalledObject = new RackPhysicalProperties();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("FiberOpticCableType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FiberOpticCableType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaximumSupportedWeightLbs", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaximumSupportedWeightLbs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OpticalStandard", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OpticalStandard = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PowerConnector", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PowerConnector = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PowerDrawKva", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PowerDrawKva = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PowerFeedDrop", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PowerFeedDrop = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PowerPhase", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PowerPhase = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UplinkCount", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UplinkCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UplinkGbps", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UplinkGbps = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static RackPhysicalPropertiesUnmarshaller _instance = new RackPhysicalPropertiesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RackPhysicalPropertiesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}