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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pinpoint.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MessageConfiguration Object
    /// </summary>  
    public class MessageConfigurationUnmarshaller : IUnmarshaller<MessageConfiguration, XmlUnmarshallerContext>, IUnmarshaller<MessageConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        MessageConfiguration IUnmarshaller<MessageConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public MessageConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            MessageConfiguration unmarshalledObject = new MessageConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("APNSMessage", targetDepth))
                {
                    var unmarshaller = MessageUnmarshaller.Instance;
                    unmarshalledObject.APNSMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultMessage", targetDepth))
                {
                    var unmarshaller = MessageUnmarshaller.Instance;
                    unmarshalledObject.DefaultMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GCMMessage", targetDepth))
                {
                    var unmarshaller = MessageUnmarshaller.Instance;
                    unmarshalledObject.GCMMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static MessageConfigurationUnmarshaller _instance = new MessageConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MessageConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}