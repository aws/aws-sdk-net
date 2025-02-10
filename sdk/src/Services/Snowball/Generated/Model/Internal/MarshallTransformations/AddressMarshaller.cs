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
using System.Text;
using System.Xml.Serialization;

using Amazon.Snowball.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Snowball.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Address Marshaller
    /// </summary>
    public class AddressMarshaller : IRequestMarshaller<Address, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Address requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAddressId())
            {
                context.Writer.WritePropertyName("AddressId");
                context.Writer.WriteStringValue(requestObject.AddressId);
            }

            if(requestObject.IsSetCity())
            {
                context.Writer.WritePropertyName("City");
                context.Writer.WriteStringValue(requestObject.City);
            }

            if(requestObject.IsSetCompany())
            {
                context.Writer.WritePropertyName("Company");
                context.Writer.WriteStringValue(requestObject.Company);
            }

            if(requestObject.IsSetCountry())
            {
                context.Writer.WritePropertyName("Country");
                context.Writer.WriteStringValue(requestObject.Country);
            }

            if(requestObject.IsSetIsRestricted())
            {
                context.Writer.WritePropertyName("IsRestricted");
                context.Writer.WriteBooleanValue(requestObject.IsRestricted.Value);
            }

            if(requestObject.IsSetLandmark())
            {
                context.Writer.WritePropertyName("Landmark");
                context.Writer.WriteStringValue(requestObject.Landmark);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetPhoneNumber())
            {
                context.Writer.WritePropertyName("PhoneNumber");
                context.Writer.WriteStringValue(requestObject.PhoneNumber);
            }

            if(requestObject.IsSetPostalCode())
            {
                context.Writer.WritePropertyName("PostalCode");
                context.Writer.WriteStringValue(requestObject.PostalCode);
            }

            if(requestObject.IsSetPrefectureOrDistrict())
            {
                context.Writer.WritePropertyName("PrefectureOrDistrict");
                context.Writer.WriteStringValue(requestObject.PrefectureOrDistrict);
            }

            if(requestObject.IsSetStateOrProvince())
            {
                context.Writer.WritePropertyName("StateOrProvince");
                context.Writer.WriteStringValue(requestObject.StateOrProvince);
            }

            if(requestObject.IsSetStreet1())
            {
                context.Writer.WritePropertyName("Street1");
                context.Writer.WriteStringValue(requestObject.Street1);
            }

            if(requestObject.IsSetStreet2())
            {
                context.Writer.WritePropertyName("Street2");
                context.Writer.WriteStringValue(requestObject.Street2);
            }

            if(requestObject.IsSetStreet3())
            {
                context.Writer.WritePropertyName("Street3");
                context.Writer.WriteStringValue(requestObject.Street3);
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AddressMarshaller Instance = new AddressMarshaller();

    }
}