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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.Route53Domains.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.Route53Domains.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ContactDetail Object
    /// </summary>
    public partial class ContactDetailUnmarshaller : ICborUnmarshaller<ContactDetail, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ContactDetail Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new ContactDetail();
            if (context.IsEmptyResponse) return null;

            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "AddressLine1":
                        context.AddPathSegment("AddressLine1");
                        unmarshalledObject.AddressLine1 = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AddressLine2":
                        context.AddPathSegment("AddressLine2");
                        unmarshalledObject.AddressLine2 = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "City":
                        context.AddPathSegment("City");
                        unmarshalledObject.City = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ContactType":
                        context.AddPathSegment("ContactType");
                        unmarshalledObject.ContactType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CountryCode":
                        context.AddPathSegment("CountryCode");
                        unmarshalledObject.CountryCode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Email":
                        context.AddPathSegment("Email");
                        unmarshalledObject.Email = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ExtraParams":
                        context.AddPathSegment("ExtraParams");
                        unmarshalledObject.ExtraParams = new CborListUnmarshaller<ExtraParam, ExtraParamUnmarshaller>(ExtraParamUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Fax":
                        context.AddPathSegment("Fax");
                        unmarshalledObject.Fax = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FirstName":
                        context.AddPathSegment("FirstName");
                        unmarshalledObject.FirstName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LastName":
                        context.AddPathSegment("LastName");
                        unmarshalledObject.LastName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "OrganizationName":
                        context.AddPathSegment("OrganizationName");
                        unmarshalledObject.OrganizationName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PhoneNumber":
                        context.AddPathSegment("PhoneNumber");
                        unmarshalledObject.PhoneNumber = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "State":
                        context.AddPathSegment("State");
                        unmarshalledObject.State = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ZipCode":
                        context.AddPathSegment("ZipCode");
                        unmarshalledObject.ZipCode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            return unmarshalledObject;
        }

        private static ContactDetailUnmarshaller _instance = new ContactDetailUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ContactDetailUnmarshaller Instance => _instance;
    }
}
