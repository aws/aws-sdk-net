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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GeoPlaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.GeoPlaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Contacts Object
    /// </summary>  
    public class ContactsUnmarshaller : IUnmarshaller<Contacts, XmlUnmarshallerContext>, IUnmarshaller<Contacts, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Contacts IUnmarshaller<Contacts, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Contacts Unmarshall(JsonUnmarshallerContext context)
        {
            Contacts unmarshalledObject = new Contacts();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Emails", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ContactDetails, ContactDetailsUnmarshaller>(ContactDetailsUnmarshaller.Instance);
                    unmarshalledObject.Emails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Faxes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ContactDetails, ContactDetailsUnmarshaller>(ContactDetailsUnmarshaller.Instance);
                    unmarshalledObject.Faxes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Phones", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ContactDetails, ContactDetailsUnmarshaller>(ContactDetailsUnmarshaller.Instance);
                    unmarshalledObject.Phones = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Websites", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ContactDetails, ContactDetailsUnmarshaller>(ContactDetailsUnmarshaller.Instance);
                    unmarshalledObject.Websites = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ContactsUnmarshaller _instance = new ContactsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ContactsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}