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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.PinpointSMSVoiceV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PinpointSMSVoiceV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RegistrationFieldDisplayHints Object
    /// </summary>  
    public class RegistrationFieldDisplayHintsUnmarshaller : IUnmarshaller<RegistrationFieldDisplayHints, XmlUnmarshallerContext>, IUnmarshaller<RegistrationFieldDisplayHints, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RegistrationFieldDisplayHints IUnmarshaller<RegistrationFieldDisplayHints, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RegistrationFieldDisplayHints Unmarshall(JsonUnmarshallerContext context)
        {
            RegistrationFieldDisplayHints unmarshalledObject = new RegistrationFieldDisplayHints();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DocumentationLink", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DocumentationLink = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DocumentationTitle", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DocumentationTitle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExampleTextValue", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExampleTextValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LongDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LongDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SelectOptionDescriptions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SelectOptionDescription, SelectOptionDescriptionUnmarshaller>(SelectOptionDescriptionUnmarshaller.Instance);
                    unmarshalledObject.SelectOptionDescriptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShortDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShortDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TextValidationDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TextValidationDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Title", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Title = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RegistrationFieldDisplayHintsUnmarshaller _instance = new RegistrationFieldDisplayHintsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RegistrationFieldDisplayHintsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}