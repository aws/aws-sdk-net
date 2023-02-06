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

namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Profile Object
    /// </summary>  
    public class ProfileUnmarshaller : IUnmarshaller<Profile, XmlUnmarshallerContext>, IUnmarshaller<Profile, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Profile IUnmarshaller<Profile, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Profile Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Profile unmarshalledObject = new Profile();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AccountNumber", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AdditionalInformation", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AdditionalInformation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Address", targetDepth))
                {
                    var unmarshaller = AddressUnmarshaller.Instance;
                    unmarshalledObject.Address = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Attributes", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Attributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BillingAddress", targetDepth))
                {
                    var unmarshaller = AddressUnmarshaller.Instance;
                    unmarshalledObject.BillingAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BirthDate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BirthDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BusinessEmailAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BusinessEmailAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BusinessName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BusinessName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BusinessPhoneNumber", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BusinessPhoneNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EmailAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EmailAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FirstName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FirstName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FoundByItems", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<FoundByKeyValue, FoundByKeyValueUnmarshaller>(FoundByKeyValueUnmarshaller.Instance);
                    unmarshalledObject.FoundByItems = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Gender", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Gender = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GenderString", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GenderString = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HomePhoneNumber", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HomePhoneNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MailingAddress", targetDepth))
                {
                    var unmarshaller = AddressUnmarshaller.Instance;
                    unmarshalledObject.MailingAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MiddleName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MiddleName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MobilePhoneNumber", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MobilePhoneNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PartyType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PartyType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PartyTypeString", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PartyTypeString = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PersonalEmailAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PersonalEmailAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PhoneNumber", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PhoneNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProfileId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProfileId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShippingAddress", targetDepth))
                {
                    var unmarshaller = AddressUnmarshaller.Instance;
                    unmarshalledObject.ShippingAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ProfileUnmarshaller _instance = new ProfileUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ProfileUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}