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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SocialMessaging.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SocialMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LibraryTemplateButtonList Object
    /// </summary>  
    public class LibraryTemplateButtonListUnmarshaller : IUnmarshaller<LibraryTemplateButtonList, XmlUnmarshallerContext>, IUnmarshaller<LibraryTemplateButtonList, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        LibraryTemplateButtonList IUnmarshaller<LibraryTemplateButtonList, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public LibraryTemplateButtonList Unmarshall(JsonUnmarshallerContext context)
        {
            LibraryTemplateButtonList unmarshalledObject = new LibraryTemplateButtonList();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("otpType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OtpType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("phoneNumber", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PhoneNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("supportedApps", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Dictionary<string, string>, DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>>(new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance));
                    unmarshalledObject.SupportedApps = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("text", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Text = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("url", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Url = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("zeroTapTermsAccepted", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ZeroTapTermsAccepted = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static LibraryTemplateButtonListUnmarshaller _instance = new LibraryTemplateButtonListUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LibraryTemplateButtonListUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}