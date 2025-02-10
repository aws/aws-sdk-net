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
using System.Text;
using System.Xml.Serialization;

using Amazon.GeoPlaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.GeoPlaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GeocodeQueryComponents Marshaller
    /// </summary>
    public class GeocodeQueryComponentsMarshaller : IRequestMarshaller<GeocodeQueryComponents, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GeocodeQueryComponents requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAddressNumber())
            {
                context.Writer.WritePropertyName("AddressNumber");
                context.Writer.WriteStringValue(requestObject.AddressNumber);
            }

            if(requestObject.IsSetCountry())
            {
                context.Writer.WritePropertyName("Country");
                context.Writer.WriteStringValue(requestObject.Country);
            }

            if(requestObject.IsSetDistrict())
            {
                context.Writer.WritePropertyName("District");
                context.Writer.WriteStringValue(requestObject.District);
            }

            if(requestObject.IsSetLocality())
            {
                context.Writer.WritePropertyName("Locality");
                context.Writer.WriteStringValue(requestObject.Locality);
            }

            if(requestObject.IsSetPostalCode())
            {
                context.Writer.WritePropertyName("PostalCode");
                context.Writer.WriteStringValue(requestObject.PostalCode);
            }

            if(requestObject.IsSetRegion())
            {
                context.Writer.WritePropertyName("Region");
                context.Writer.WriteStringValue(requestObject.Region);
            }

            if(requestObject.IsSetStreet())
            {
                context.Writer.WritePropertyName("Street");
                context.Writer.WriteStringValue(requestObject.Street);
            }

            if(requestObject.IsSetSubRegion())
            {
                context.Writer.WritePropertyName("SubRegion");
                context.Writer.WriteStringValue(requestObject.SubRegion);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GeocodeQueryComponentsMarshaller Instance = new GeocodeQueryComponentsMarshaller();

    }
}