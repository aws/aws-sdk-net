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
    /// Response Unmarshaller for InputLossBehavior Object
    /// </summary>  
    public class InputLossBehaviorUnmarshaller : IUnmarshaller<InputLossBehavior, XmlUnmarshallerContext>, IUnmarshaller<InputLossBehavior, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        InputLossBehavior IUnmarshaller<InputLossBehavior, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public InputLossBehavior Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            InputLossBehavior unmarshalledObject = new InputLossBehavior();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("blackFrameMsec", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.BlackFrameMsec = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inputLossImageColor", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InputLossImageColor = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inputLossImageSlate", targetDepth))
                {
                    var unmarshaller = InputLocationUnmarshaller.Instance;
                    unmarshalledObject.InputLossImageSlate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inputLossImageType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InputLossImageType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("repeatFrameMsec", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RepeatFrameMsec = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static InputLossBehaviorUnmarshaller _instance = new InputLossBehaviorUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InputLossBehaviorUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}