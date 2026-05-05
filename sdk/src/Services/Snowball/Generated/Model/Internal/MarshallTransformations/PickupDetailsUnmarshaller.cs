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
    /// Response Unmarshaller for PickupDetails Object
    /// </summary>  
    public class PickupDetailsUnmarshaller : ICborUnmarshaller<PickupDetails, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public PickupDetails Unmarshall(CborUnmarshallerContext context)
        {
            PickupDetails unmarshalledObject = new PickupDetails();
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
                    case "DevicePickupId":
                        {
                            context.AddPathSegment("DevicePickupId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.DevicePickupId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Email":
                        {
                            context.AddPathSegment("Email");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Email = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "IdentificationExpirationDate":
                        {
                            context.AddPathSegment("IdentificationExpirationDate");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.IdentificationExpirationDate = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "IdentificationIssuingOrg":
                        {
                            context.AddPathSegment("IdentificationIssuingOrg");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.IdentificationIssuingOrg = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "IdentificationNumber":
                        {
                            context.AddPathSegment("IdentificationNumber");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.IdentificationNumber = unmarshaller.Unmarshall(context);
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
                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            return unmarshalledObject;
        }


        private static PickupDetailsUnmarshaller _instance = new PickupDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PickupDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}