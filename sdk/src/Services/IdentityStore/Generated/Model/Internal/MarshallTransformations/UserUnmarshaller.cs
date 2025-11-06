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
 * Do not modify this file. This file is generated from the identitystore-2020-06-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IdentityStore.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IdentityStore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for User Object
    /// </summary>  
    public class UserUnmarshaller : IUnmarshaller<User, XmlUnmarshallerContext>, IUnmarshaller<User, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        User IUnmarshaller<User, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public User Unmarshall(JsonUnmarshallerContext context)
        {
            User unmarshalledObject = new User();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Addresses", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Address, AddressUnmarshaller>(AddressUnmarshaller.Instance);
                    unmarshalledObject.Addresses = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Birthdate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Birthdate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreatedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreatedBy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreatedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DisplayName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DisplayName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Emails", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Email, EmailUnmarshaller>(EmailUnmarshaller.Instance);
                    unmarshalledObject.Emails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExternalIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ExternalId, ExternalIdUnmarshaller>(ExternalIdUnmarshaller.Instance);
                    unmarshalledObject.ExternalIds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IdentityStoreId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IdentityStoreId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Locale", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Locale = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = NameUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NickName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NickName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PhoneNumbers", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PhoneNumber, PhoneNumberUnmarshaller>(PhoneNumberUnmarshaller.Instance);
                    unmarshalledObject.PhoneNumbers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Photos", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Photo, PhotoUnmarshaller>(PhotoUnmarshaller.Instance);
                    unmarshalledObject.Photos = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreferredLanguage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreferredLanguage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProfileUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProfileUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Timezone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Timezone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Title", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Title = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UpdatedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.UpdatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UpdatedBy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UpdatedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UserId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UserName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UserStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UserType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Website", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Website = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static UserUnmarshaller _instance = new UserUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UserUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}