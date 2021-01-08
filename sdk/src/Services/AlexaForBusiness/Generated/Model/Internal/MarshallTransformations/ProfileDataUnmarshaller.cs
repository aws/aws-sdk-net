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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AlexaForBusiness.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AlexaForBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ProfileData Object
    /// </summary>  
    public class ProfileDataUnmarshaller : IUnmarshaller<ProfileData, XmlUnmarshallerContext>, IUnmarshaller<ProfileData, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ProfileData IUnmarshaller<ProfileData, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ProfileData Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ProfileData unmarshalledObject = new ProfileData();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Address", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Address = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DistanceUnit", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DistanceUnit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IsDefault", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsDefault = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Locale", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Locale = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProfileArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProfileArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProfileName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProfileName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TemperatureUnit", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TemperatureUnit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Timezone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Timezone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WakeWord", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WakeWord = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ProfileDataUnmarshaller _instance = new ProfileDataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ProfileDataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}