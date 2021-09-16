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
    /// Response Unmarshaller for InAppMessageContent Object
    /// </summary>  
    public class InAppMessageContentUnmarshaller : IUnmarshaller<InAppMessageContent, XmlUnmarshallerContext>, IUnmarshaller<InAppMessageContent, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        InAppMessageContent IUnmarshaller<InAppMessageContent, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public InAppMessageContent Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            InAppMessageContent unmarshalledObject = new InAppMessageContent();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BackgroundColor", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BackgroundColor = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BodyConfig", targetDepth))
                {
                    var unmarshaller = InAppMessageBodyConfigUnmarshaller.Instance;
                    unmarshalledObject.BodyConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HeaderConfig", targetDepth))
                {
                    var unmarshaller = InAppMessageHeaderConfigUnmarshaller.Instance;
                    unmarshalledObject.HeaderConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ImageUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImageUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PrimaryBtn", targetDepth))
                {
                    var unmarshaller = InAppMessageButtonUnmarshaller.Instance;
                    unmarshalledObject.PrimaryBtn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecondaryBtn", targetDepth))
                {
                    var unmarshaller = InAppMessageButtonUnmarshaller.Instance;
                    unmarshalledObject.SecondaryBtn = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static InAppMessageContentUnmarshaller _instance = new InAppMessageContentUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InAppMessageContentUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}