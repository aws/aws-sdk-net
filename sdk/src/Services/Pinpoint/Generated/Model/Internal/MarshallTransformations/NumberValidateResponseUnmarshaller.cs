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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for NumberValidateResponse Object
    /// </summary>  
    public class NumberValidateResponseUnmarshaller : IJsonUnmarshaller<NumberValidateResponse, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public NumberValidateResponse Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            NumberValidateResponse unmarshalledObject = new NumberValidateResponse();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Carrier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Carrier = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("City", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.City = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CleansedPhoneNumberE164", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CleansedPhoneNumberE164 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CleansedPhoneNumberNational", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CleansedPhoneNumberNational = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Country", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Country = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CountryCodeIso2", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CountryCodeIso2 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CountryCodeNumeric", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CountryCodeNumeric = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("County", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.County = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OriginalCountryCodeIso2", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OriginalCountryCodeIso2 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OriginalPhoneNumber", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OriginalPhoneNumber = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PhoneType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PhoneType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PhoneTypeCode", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.PhoneTypeCode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Timezone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Timezone = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ZipCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ZipCode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static NumberValidateResponseUnmarshaller _instance = new NumberValidateResponseUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NumberValidateResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}