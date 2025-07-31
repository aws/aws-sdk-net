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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CustomerProfiles.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ProfileAttributes Object
    /// </summary>  
    public class ProfileAttributesUnmarshaller : IUnmarshaller<ProfileAttributes, XmlUnmarshallerContext>, IUnmarshaller<ProfileAttributes, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ProfileAttributes IUnmarshaller<ProfileAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ProfileAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            ProfileAttributes unmarshalledObject = new ProfileAttributes();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AccountNumber", targetDepth))
                {
                    var unmarshaller = ProfileDimensionUnmarshaller.Instance;
                    unmarshalledObject.AccountNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AdditionalInformation", targetDepth))
                {
                    var unmarshaller = ExtraLengthValueProfileDimensionUnmarshaller.Instance;
                    unmarshalledObject.AdditionalInformation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Address", targetDepth))
                {
                    var unmarshaller = AddressDimensionUnmarshaller.Instance;
                    unmarshalledObject.Address = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Attributes", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, AttributeDimension, StringUnmarshaller, AttributeDimensionUnmarshaller>(StringUnmarshaller.Instance, AttributeDimensionUnmarshaller.Instance);
                    unmarshalledObject.Attributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BillingAddress", targetDepth))
                {
                    var unmarshaller = AddressDimensionUnmarshaller.Instance;
                    unmarshalledObject.BillingAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BirthDate", targetDepth))
                {
                    var unmarshaller = DateDimensionUnmarshaller.Instance;
                    unmarshalledObject.BirthDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BusinessEmailAddress", targetDepth))
                {
                    var unmarshaller = ProfileDimensionUnmarshaller.Instance;
                    unmarshalledObject.BusinessEmailAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BusinessName", targetDepth))
                {
                    var unmarshaller = ProfileDimensionUnmarshaller.Instance;
                    unmarshalledObject.BusinessName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BusinessPhoneNumber", targetDepth))
                {
                    var unmarshaller = ProfileDimensionUnmarshaller.Instance;
                    unmarshalledObject.BusinessPhoneNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EmailAddress", targetDepth))
                {
                    var unmarshaller = ProfileDimensionUnmarshaller.Instance;
                    unmarshalledObject.EmailAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FirstName", targetDepth))
                {
                    var unmarshaller = ProfileDimensionUnmarshaller.Instance;
                    unmarshalledObject.FirstName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GenderString", targetDepth))
                {
                    var unmarshaller = ProfileDimensionUnmarshaller.Instance;
                    unmarshalledObject.GenderString = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HomePhoneNumber", targetDepth))
                {
                    var unmarshaller = ProfileDimensionUnmarshaller.Instance;
                    unmarshalledObject.HomePhoneNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastName", targetDepth))
                {
                    var unmarshaller = ProfileDimensionUnmarshaller.Instance;
                    unmarshalledObject.LastName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MailingAddress", targetDepth))
                {
                    var unmarshaller = AddressDimensionUnmarshaller.Instance;
                    unmarshalledObject.MailingAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MiddleName", targetDepth))
                {
                    var unmarshaller = ProfileDimensionUnmarshaller.Instance;
                    unmarshalledObject.MiddleName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MobilePhoneNumber", targetDepth))
                {
                    var unmarshaller = ProfileDimensionUnmarshaller.Instance;
                    unmarshalledObject.MobilePhoneNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PartyTypeString", targetDepth))
                {
                    var unmarshaller = ProfileDimensionUnmarshaller.Instance;
                    unmarshalledObject.PartyTypeString = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PersonalEmailAddress", targetDepth))
                {
                    var unmarshaller = ProfileDimensionUnmarshaller.Instance;
                    unmarshalledObject.PersonalEmailAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PhoneNumber", targetDepth))
                {
                    var unmarshaller = ProfileDimensionUnmarshaller.Instance;
                    unmarshalledObject.PhoneNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProfileType", targetDepth))
                {
                    var unmarshaller = ProfileTypeDimensionUnmarshaller.Instance;
                    unmarshalledObject.ProfileType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShippingAddress", targetDepth))
                {
                    var unmarshaller = AddressDimensionUnmarshaller.Instance;
                    unmarshalledObject.ShippingAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ProfileAttributesUnmarshaller _instance = new ProfileAttributesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ProfileAttributesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}