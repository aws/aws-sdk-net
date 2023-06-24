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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ActionRemoteIpDetails Marshaller
    /// </summary>
    public class ActionRemoteIpDetailsMarshaller : IRequestMarshaller<ActionRemoteIpDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ActionRemoteIpDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCity())
            {
                context.Writer.WritePropertyName("City");
                context.Writer.WriteObjectStart();

                var marshaller = CityMarshaller.Instance;
                marshaller.Marshall(requestObject.City, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCountry())
            {
                context.Writer.WritePropertyName("Country");
                context.Writer.WriteObjectStart();

                var marshaller = CountryMarshaller.Instance;
                marshaller.Marshall(requestObject.Country, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGeoLocation())
            {
                context.Writer.WritePropertyName("GeoLocation");
                context.Writer.WriteObjectStart();

                var marshaller = GeoLocationMarshaller.Instance;
                marshaller.Marshall(requestObject.GeoLocation, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIpAddressV4())
            {
                context.Writer.WritePropertyName("IpAddressV4");
                context.Writer.Write(requestObject.IpAddressV4);
            }

            if(requestObject.IsSetOrganization())
            {
                context.Writer.WritePropertyName("Organization");
                context.Writer.WriteObjectStart();

                var marshaller = IpOrganizationDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Organization, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ActionRemoteIpDetailsMarshaller Instance = new ActionRemoteIpDetailsMarshaller();

    }
}