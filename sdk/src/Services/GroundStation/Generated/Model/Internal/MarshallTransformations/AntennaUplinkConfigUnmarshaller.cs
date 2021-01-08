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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GroundStation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GroundStation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AntennaUplinkConfig Object
    /// </summary>  
    public class AntennaUplinkConfigUnmarshaller : IUnmarshaller<AntennaUplinkConfig, XmlUnmarshallerContext>, IUnmarshaller<AntennaUplinkConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AntennaUplinkConfig IUnmarshaller<AntennaUplinkConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AntennaUplinkConfig Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AntennaUplinkConfig unmarshalledObject = new AntennaUplinkConfig();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("spectrumConfig", targetDepth))
                {
                    var unmarshaller = UplinkSpectrumConfigUnmarshaller.Instance;
                    unmarshalledObject.SpectrumConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("targetEirp", targetDepth))
                {
                    var unmarshaller = EirpUnmarshaller.Instance;
                    unmarshalledObject.TargetEirp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("transmitDisabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.TransmitDisabled = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AntennaUplinkConfigUnmarshaller _instance = new AntennaUplinkConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AntennaUplinkConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}