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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Snowball.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.Snowball.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Address Object
    /// </summary>  
    public class AddressUnmarshaller : ICborUnmarshaller<Address, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Address Unmarshall(CborUnmarshallerContext context)
        {
            Address unmarshalledObject = new Address();
            if (context.IsEmptyResponse)
                return null;
            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "AddressId":
                        {
                            context.AddPathSegment("AddressId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AddressId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "City":
                        {
                            context.AddPathSegment("City");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.City = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Company":
                        {
                            context.AddPathSegment("Company");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Company = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Country":
                        {
                            context.AddPathSegment("Country");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Country = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "IsRestricted":
                        {
                            context.AddPathSegment("IsRestricted");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.IsRestricted = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Landmark":
                        {
                            context.AddPathSegment("Landmark");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Landmark = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Name":
                        {
                            context.AddPathSegment("Name");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PhoneNumber":
                        {
                            context.AddPathSegment("PhoneNumber");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PhoneNumber = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PostalCode":
                        {
                            context.AddPathSegment("PostalCode");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PostalCode = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PrefectureOrDistrict":
                        {
                            context.AddPathSegment("PrefectureOrDistrict");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PrefectureOrDistrict = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StateOrProvince":
                        {
                            context.AddPathSegment("StateOrProvince");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.StateOrProvince = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Street1":
                        {
                            context.AddPathSegment("Street1");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Street1 = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Street2":
                        {
                            context.AddPathSegment("Street2");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Street2 = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Street3":
                        {
                            context.AddPathSegment("Street3");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Street3 = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Type":
                        {
                            context.AddPathSegment("Type");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            return unmarshalledObject;
        }


        private static AddressUnmarshaller _instance = new AddressUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AddressUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}