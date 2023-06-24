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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ClaimedPhoneNumberSummary Object
    /// </summary>  
    public class ClaimedPhoneNumberSummaryUnmarshaller : IUnmarshaller<ClaimedPhoneNumberSummary, XmlUnmarshallerContext>, IUnmarshaller<ClaimedPhoneNumberSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ClaimedPhoneNumberSummary IUnmarshaller<ClaimedPhoneNumberSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ClaimedPhoneNumberSummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ClaimedPhoneNumberSummary unmarshalledObject = new ClaimedPhoneNumberSummary();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("PhoneNumber", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PhoneNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PhoneNumberArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PhoneNumberArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PhoneNumberCountryCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PhoneNumberCountryCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PhoneNumberDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PhoneNumberDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PhoneNumberId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PhoneNumberId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PhoneNumberStatus", targetDepth))
                {
                    var unmarshaller = PhoneNumberStatusUnmarshaller.Instance;
                    unmarshalledObject.PhoneNumberStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PhoneNumberType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PhoneNumberType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TargetArn = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ClaimedPhoneNumberSummaryUnmarshaller _instance = new ClaimedPhoneNumberSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ClaimedPhoneNumberSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}