/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53Domains.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Route53Domains.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ContactDetail Object
    /// </summary>  
    public class ContactDetailUnmarshaller : IUnmarshaller<ContactDetail, XmlUnmarshallerContext>, IUnmarshaller<ContactDetail, JsonUnmarshallerContext>
    {
        ContactDetail IUnmarshaller<ContactDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public ContactDetail Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ContactDetail unmarshalledObject = new ContactDetail();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AddressLine1", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AddressLine1 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AddressLine2", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AddressLine2 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("City", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.City = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ContactType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ContactType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CountryCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CountryCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Email", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Email = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExtraParams", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ExtraParam, ExtraParamUnmarshaller>(ExtraParamUnmarshaller.Instance);
                    unmarshalledObject.ExtraParams = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Fax", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Fax = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FirstName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FirstName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OrganizationName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OrganizationName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PhoneNumber", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PhoneNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("State", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ZipCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ZipCode = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ContactDetailUnmarshaller _instance = new ContactDetailUnmarshaller();        

        public static ContactDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}