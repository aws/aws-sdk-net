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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.PinpointSMSVoiceV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RegistrationDeniedReasonInformation Object
    /// </summary>  
    public class RegistrationDeniedReasonInformationUnmarshaller : IJsonUnmarshaller<RegistrationDeniedReasonInformation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public RegistrationDeniedReasonInformation Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            RegistrationDeniedReasonInformation unmarshalledObject = new RegistrationDeniedReasonInformation();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("DocumentationLink", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DocumentationLink = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DocumentationTitle", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DocumentationTitle = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LongDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LongDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Reason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Reason = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ShortDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShortDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RegistrationDeniedReasonInformationUnmarshaller _instance = new RegistrationDeniedReasonInformationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RegistrationDeniedReasonInformationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}