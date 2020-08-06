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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.PinpointEmail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.PinpointEmail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DomainDeliverabilityCampaign Object
    /// </summary>  
    public class DomainDeliverabilityCampaignUnmarshaller : IUnmarshaller<DomainDeliverabilityCampaign, XmlUnmarshallerContext>, IUnmarshaller<DomainDeliverabilityCampaign, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DomainDeliverabilityCampaign IUnmarshaller<DomainDeliverabilityCampaign, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DomainDeliverabilityCampaign Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DomainDeliverabilityCampaign unmarshalledObject = new DomainDeliverabilityCampaign();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CampaignId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CampaignId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeleteRate", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.DeleteRate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Esps", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Esps = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FirstSeenDateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.FirstSeenDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FromAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FromAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ImageUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImageUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InboxCount", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.InboxCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastSeenDateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastSeenDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProjectedVolume", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ProjectedVolume = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReadDeleteRate", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.ReadDeleteRate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReadRate", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.ReadRate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SendingIps", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SendingIps = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SpamCount", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.SpamCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Subject", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Subject = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DomainDeliverabilityCampaignUnmarshaller _instance = new DomainDeliverabilityCampaignUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DomainDeliverabilityCampaignUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}