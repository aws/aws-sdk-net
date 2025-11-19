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
 * Do not modify this file. This file is generated from the connectcampaignsv2-2024-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectCampaignsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ConnectCampaignsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TelephonyOutboundConfig Object
    /// </summary>  
    public class TelephonyOutboundConfigUnmarshaller : IUnmarshaller<TelephonyOutboundConfig, XmlUnmarshallerContext>, IUnmarshaller<TelephonyOutboundConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TelephonyOutboundConfig IUnmarshaller<TelephonyOutboundConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public TelephonyOutboundConfig Unmarshall(JsonUnmarshallerContext context)
        {
            TelephonyOutboundConfig unmarshalledObject = new TelephonyOutboundConfig();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("answerMachineDetectionConfig", targetDepth))
                {
                    var unmarshaller = AnswerMachineDetectionConfigUnmarshaller.Instance;
                    unmarshalledObject.AnswerMachineDetectionConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectContactFlowId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConnectContactFlowId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectSourcePhoneNumber", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConnectSourcePhoneNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ringTimeout", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RingTimeout = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TelephonyOutboundConfigUnmarshaller _instance = new TelephonyOutboundConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TelephonyOutboundConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}