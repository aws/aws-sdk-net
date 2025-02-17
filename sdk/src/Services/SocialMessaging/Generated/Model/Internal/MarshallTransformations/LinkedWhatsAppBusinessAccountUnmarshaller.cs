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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SocialMessaging.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SocialMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LinkedWhatsAppBusinessAccount Object
    /// </summary>  
    public class LinkedWhatsAppBusinessAccountUnmarshaller : IUnmarshaller<LinkedWhatsAppBusinessAccount, XmlUnmarshallerContext>, IUnmarshaller<LinkedWhatsAppBusinessAccount, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        LinkedWhatsAppBusinessAccount IUnmarshaller<LinkedWhatsAppBusinessAccount, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public LinkedWhatsAppBusinessAccount Unmarshall(JsonUnmarshallerContext context)
        {
            LinkedWhatsAppBusinessAccount unmarshalledObject = new LinkedWhatsAppBusinessAccount();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("eventDestinations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<WhatsAppBusinessAccountEventDestination, WhatsAppBusinessAccountEventDestinationUnmarshaller>(WhatsAppBusinessAccountEventDestinationUnmarshaller.Instance);
                    unmarshalledObject.EventDestinations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("linkDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LinkDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("phoneNumbers", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<WhatsAppPhoneNumberSummary, WhatsAppPhoneNumberSummaryUnmarshaller>(WhatsAppPhoneNumberSummaryUnmarshaller.Instance);
                    unmarshalledObject.PhoneNumbers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("registrationStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RegistrationStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("wabaId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WabaId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("wabaName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WabaName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static LinkedWhatsAppBusinessAccountUnmarshaller _instance = new LinkedWhatsAppBusinessAccountUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LinkedWhatsAppBusinessAccountUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}