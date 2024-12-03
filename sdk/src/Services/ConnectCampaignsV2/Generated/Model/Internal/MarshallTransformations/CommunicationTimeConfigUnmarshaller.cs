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
    /// Response Unmarshaller for CommunicationTimeConfig Object
    /// </summary>  
    public class CommunicationTimeConfigUnmarshaller : IUnmarshaller<CommunicationTimeConfig, XmlUnmarshallerContext>, IUnmarshaller<CommunicationTimeConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CommunicationTimeConfig IUnmarshaller<CommunicationTimeConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public CommunicationTimeConfig Unmarshall(JsonUnmarshallerContext context)
        {
            CommunicationTimeConfig unmarshalledObject = new CommunicationTimeConfig();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("email", targetDepth))
                {
                    var unmarshaller = TimeWindowUnmarshaller.Instance;
                    unmarshalledObject.Email = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("localTimeZoneConfig", targetDepth))
                {
                    var unmarshaller = LocalTimeZoneConfigUnmarshaller.Instance;
                    unmarshalledObject.LocalTimeZoneConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sms", targetDepth))
                {
                    var unmarshaller = TimeWindowUnmarshaller.Instance;
                    unmarshalledObject.Sms = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("telephony", targetDepth))
                {
                    var unmarshaller = TimeWindowUnmarshaller.Instance;
                    unmarshalledObject.Telephony = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CommunicationTimeConfigUnmarshaller _instance = new CommunicationTimeConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CommunicationTimeConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}