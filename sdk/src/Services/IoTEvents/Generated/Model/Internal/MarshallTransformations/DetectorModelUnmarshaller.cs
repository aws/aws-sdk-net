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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTEvents.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTEvents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DetectorModel Object
    /// </summary>  
    public class DetectorModelUnmarshaller : IUnmarshaller<DetectorModel, XmlUnmarshallerContext>, IUnmarshaller<DetectorModel, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DetectorModel IUnmarshaller<DetectorModel, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DetectorModel Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DetectorModel unmarshalledObject = new DetectorModel();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("detectorModelConfiguration", targetDepth))
                {
                    var unmarshaller = DetectorModelConfigurationUnmarshaller.Instance;
                    unmarshalledObject.DetectorModelConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("detectorModelDefinition", targetDepth))
                {
                    var unmarshaller = DetectorModelDefinitionUnmarshaller.Instance;
                    unmarshalledObject.DetectorModelDefinition = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DetectorModelUnmarshaller _instance = new DetectorModelUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DetectorModelUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}