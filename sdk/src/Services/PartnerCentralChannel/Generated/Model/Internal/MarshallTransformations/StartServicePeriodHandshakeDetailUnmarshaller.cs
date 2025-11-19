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
 * Do not modify this file. This file is generated from the partnercentral-channel-2024-03-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.PartnerCentralChannel.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralChannel.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for StartServicePeriodHandshakeDetail Object
    /// </summary>  
    public class StartServicePeriodHandshakeDetailUnmarshaller : IUnmarshaller<StartServicePeriodHandshakeDetail, XmlUnmarshallerContext>, IUnmarshaller<StartServicePeriodHandshakeDetail, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        StartServicePeriodHandshakeDetail IUnmarshaller<StartServicePeriodHandshakeDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public StartServicePeriodHandshakeDetail Unmarshall(JsonUnmarshallerContext context)
        {
            StartServicePeriodHandshakeDetail unmarshalledObject = new StartServicePeriodHandshakeDetail();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("endDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.EndDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("minimumNoticeDays", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MinimumNoticeDays = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("note", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Note = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("servicePeriodType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServicePeriodType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("startDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartDate = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static StartServicePeriodHandshakeDetailUnmarshaller _instance = new StartServicePeriodHandshakeDetailUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartServicePeriodHandshakeDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}