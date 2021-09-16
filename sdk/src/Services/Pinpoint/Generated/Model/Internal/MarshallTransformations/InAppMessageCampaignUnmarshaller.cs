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
    /// Response Unmarshaller for InAppMessageCampaign Object
    /// </summary>  
    public class InAppMessageCampaignUnmarshaller : IUnmarshaller<InAppMessageCampaign, XmlUnmarshallerContext>, IUnmarshaller<InAppMessageCampaign, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        InAppMessageCampaign IUnmarshaller<InAppMessageCampaign, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public InAppMessageCampaign Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            InAppMessageCampaign unmarshalledObject = new InAppMessageCampaign();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CampaignId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CampaignId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DailyCap", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DailyCap = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InAppMessage", targetDepth))
                {
                    var unmarshaller = InAppMessageUnmarshaller.Instance;
                    unmarshalledObject.InAppMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Priority", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Priority = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Schedule", targetDepth))
                {
                    var unmarshaller = InAppCampaignScheduleUnmarshaller.Instance;
                    unmarshalledObject.Schedule = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SessionCap", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SessionCap = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalCap", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TotalCap = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TreatmentId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TreatmentId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static InAppMessageCampaignUnmarshaller _instance = new InAppMessageCampaignUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InAppMessageCampaignUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}