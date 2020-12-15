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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GreengrassV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GreengrassV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for IoTJobExecutionsRolloutConfig Object
    /// </summary>  
    public class IoTJobExecutionsRolloutConfigUnmarshaller : IUnmarshaller<IoTJobExecutionsRolloutConfig, XmlUnmarshallerContext>, IUnmarshaller<IoTJobExecutionsRolloutConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        IoTJobExecutionsRolloutConfig IUnmarshaller<IoTJobExecutionsRolloutConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public IoTJobExecutionsRolloutConfig Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            IoTJobExecutionsRolloutConfig unmarshalledObject = new IoTJobExecutionsRolloutConfig();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("exponentialRate", targetDepth))
                {
                    var unmarshaller = IoTJobExponentialRolloutRateUnmarshaller.Instance;
                    unmarshalledObject.ExponentialRate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maximumPerMinute", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaximumPerMinute = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static IoTJobExecutionsRolloutConfigUnmarshaller _instance = new IoTJobExecutionsRolloutConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static IoTJobExecutionsRolloutConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}