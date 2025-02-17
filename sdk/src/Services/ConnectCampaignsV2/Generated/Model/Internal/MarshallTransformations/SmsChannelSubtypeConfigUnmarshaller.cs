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
    /// Response Unmarshaller for SmsChannelSubtypeConfig Object
    /// </summary>  
    public class SmsChannelSubtypeConfigUnmarshaller : IUnmarshaller<SmsChannelSubtypeConfig, XmlUnmarshallerContext>, IUnmarshaller<SmsChannelSubtypeConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SmsChannelSubtypeConfig IUnmarshaller<SmsChannelSubtypeConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SmsChannelSubtypeConfig Unmarshall(JsonUnmarshallerContext context)
        {
            SmsChannelSubtypeConfig unmarshalledObject = new SmsChannelSubtypeConfig();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("capacity", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Capacity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultOutboundConfig", targetDepth))
                {
                    var unmarshaller = SmsOutboundConfigUnmarshaller.Instance;
                    unmarshalledObject.DefaultOutboundConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("outboundMode", targetDepth))
                {
                    var unmarshaller = SmsOutboundModeUnmarshaller.Instance;
                    unmarshalledObject.OutboundMode = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SmsChannelSubtypeConfigUnmarshaller _instance = new SmsChannelSubtypeConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SmsChannelSubtypeConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}