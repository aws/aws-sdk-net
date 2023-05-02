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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKVoice.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ChimeSDKVoice.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for VoiceProfileSummary Object
    /// </summary>  
    public class VoiceProfileSummaryUnmarshaller : IUnmarshaller<VoiceProfileSummary, XmlUnmarshallerContext>, IUnmarshaller<VoiceProfileSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        VoiceProfileSummary IUnmarshaller<VoiceProfileSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public VoiceProfileSummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            VoiceProfileSummary unmarshalledObject = new VoiceProfileSummary();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreatedTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExpirationTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ExpirationTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UpdatedTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.UpdatedTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VoiceProfileArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VoiceProfileArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VoiceProfileDomainId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VoiceProfileDomainId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VoiceProfileId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VoiceProfileId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static VoiceProfileSummaryUnmarshaller _instance = new VoiceProfileSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VoiceProfileSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}