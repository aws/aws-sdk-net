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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTFleetWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTFleetWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SignalDecoder Object
    /// </summary>  
    public class SignalDecoderUnmarshaller : IUnmarshaller<SignalDecoder, XmlUnmarshallerContext>, IUnmarshaller<SignalDecoder, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SignalDecoder IUnmarshaller<SignalDecoder, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SignalDecoder Unmarshall(JsonUnmarshallerContext context)
        {
            SignalDecoder unmarshalledObject = new SignalDecoder();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("canSignal", targetDepth))
                {
                    var unmarshaller = CanSignalUnmarshaller.Instance;
                    unmarshalledObject.CanSignal = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("customDecodingSignal", targetDepth))
                {
                    var unmarshaller = CustomDecodingSignalUnmarshaller.Instance;
                    unmarshalledObject.CustomDecodingSignal = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fullyQualifiedName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FullyQualifiedName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("interfaceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InterfaceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("messageSignal", targetDepth))
                {
                    var unmarshaller = MessageSignalUnmarshaller.Instance;
                    unmarshalledObject.MessageSignal = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("obdSignal", targetDepth))
                {
                    var unmarshaller = ObdSignalUnmarshaller.Instance;
                    unmarshalledObject.ObdSignal = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SignalDecoderUnmarshaller _instance = new SignalDecoderUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SignalDecoderUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}