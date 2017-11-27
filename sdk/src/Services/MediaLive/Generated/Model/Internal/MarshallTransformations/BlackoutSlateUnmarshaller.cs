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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BlackoutSlate Object
    /// </summary>  
    public class BlackoutSlateUnmarshaller : IUnmarshaller<BlackoutSlate, XmlUnmarshallerContext>, IUnmarshaller<BlackoutSlate, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        BlackoutSlate IUnmarshaller<BlackoutSlate, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public BlackoutSlate Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            BlackoutSlate unmarshalledObject = new BlackoutSlate();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("blackoutSlateImage", targetDepth))
                {
                    var unmarshaller = InputLocationUnmarshaller.Instance;
                    unmarshalledObject.BlackoutSlateImage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("networkEndBlackout", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NetworkEndBlackout = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("networkEndBlackoutImage", targetDepth))
                {
                    var unmarshaller = InputLocationUnmarshaller.Instance;
                    unmarshalledObject.NetworkEndBlackoutImage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("networkId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NetworkId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("state", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static BlackoutSlateUnmarshaller _instance = new BlackoutSlateUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BlackoutSlateUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}