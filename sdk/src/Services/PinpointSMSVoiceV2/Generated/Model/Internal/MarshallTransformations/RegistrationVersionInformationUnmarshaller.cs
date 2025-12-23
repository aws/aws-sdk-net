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
    /// Response Unmarshaller for RegistrationVersionInformation Object
    /// </summary>  
    public class RegistrationVersionInformationUnmarshaller : IUnmarshaller<RegistrationVersionInformation, XmlUnmarshallerContext>, IUnmarshaller<RegistrationVersionInformation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RegistrationVersionInformation IUnmarshaller<RegistrationVersionInformation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RegistrationVersionInformation Unmarshall(JsonUnmarshallerContext context)
        {
            RegistrationVersionInformation unmarshalledObject = new RegistrationVersionInformation();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DeniedReasons", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RegistrationDeniedReasonInformation, RegistrationDeniedReasonInformationUnmarshaller>(RegistrationDeniedReasonInformationUnmarshaller.Instance);
                    unmarshalledObject.DeniedReasons = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Feedback", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Feedback = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RegistrationVersionStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RegistrationVersionStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RegistrationVersionStatusHistory", targetDepth))
                {
                    var unmarshaller = RegistrationVersionStatusHistoryUnmarshaller.Instance;
                    unmarshalledObject.RegistrationVersionStatusHistory = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VersionNumber", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.VersionNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RegistrationVersionInformationUnmarshaller _instance = new RegistrationVersionInformationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RegistrationVersionInformationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}