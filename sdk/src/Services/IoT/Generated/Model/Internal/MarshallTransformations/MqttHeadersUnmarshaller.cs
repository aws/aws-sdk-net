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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MqttHeaders Object
    /// </summary>  
    public class MqttHeadersUnmarshaller : IUnmarshaller<MqttHeaders, XmlUnmarshallerContext>, IUnmarshaller<MqttHeaders, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        MqttHeaders IUnmarshaller<MqttHeaders, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public MqttHeaders Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            MqttHeaders unmarshalledObject = new MqttHeaders();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("contentType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ContentType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("correlationData", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CorrelationData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("messageExpiry", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MessageExpiry = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("payloadFormatIndicator", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PayloadFormatIndicator = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("responseTopic", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResponseTopic = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("userProperties", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<UserProperty, UserPropertyUnmarshaller>(UserPropertyUnmarshaller.Instance);
                    unmarshalledObject.UserProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static MqttHeadersUnmarshaller _instance = new MqttHeadersUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MqttHeadersUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}