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
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.Snowball.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Address Marshaller
    /// </summary>
    public class AddressMarshaller : IRequestMarshaller<Address, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Address requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetAddressId())
            {
                context.Writer.WriteTextString("AddressId");
                context.Writer.WriteTextString(requestObject.AddressId);
            }
            if (requestObject.IsSetCity())
            {
                context.Writer.WriteTextString("City");
                context.Writer.WriteTextString(requestObject.City);
            }
            if (requestObject.IsSetCompany())
            {
                context.Writer.WriteTextString("Company");
                context.Writer.WriteTextString(requestObject.Company);
            }
            if (requestObject.IsSetCountry())
            {
                context.Writer.WriteTextString("Country");
                context.Writer.WriteTextString(requestObject.Country);
            }
            if (requestObject.IsSetIsRestricted())
            {
                context.Writer.WriteTextString("IsRestricted");
                context.Writer.WriteBoolean(requestObject.IsRestricted.Value);
            }
            if (requestObject.IsSetLandmark())
            {
                context.Writer.WriteTextString("Landmark");
                context.Writer.WriteTextString(requestObject.Landmark);
            }
            if (requestObject.IsSetName())
            {
                context.Writer.WriteTextString("Name");
                context.Writer.WriteTextString(requestObject.Name);
            }
            if (requestObject.IsSetPhoneNumber())
            {
                context.Writer.WriteTextString("PhoneNumber");
                context.Writer.WriteTextString(requestObject.PhoneNumber);
            }
            if (requestObject.IsSetPostalCode())
            {
                context.Writer.WriteTextString("PostalCode");
                context.Writer.WriteTextString(requestObject.PostalCode);
            }
            if (requestObject.IsSetPrefectureOrDistrict())
            {
                context.Writer.WriteTextString("PrefectureOrDistrict");
                context.Writer.WriteTextString(requestObject.PrefectureOrDistrict);
            }
            if (requestObject.IsSetStateOrProvince())
            {
                context.Writer.WriteTextString("StateOrProvince");
                context.Writer.WriteTextString(requestObject.StateOrProvince);
            }
            if (requestObject.IsSetStreet1())
            {
                context.Writer.WriteTextString("Street1");
                context.Writer.WriteTextString(requestObject.Street1);
            }
            if (requestObject.IsSetStreet2())
            {
                context.Writer.WriteTextString("Street2");
                context.Writer.WriteTextString(requestObject.Street2);
            }
            if (requestObject.IsSetStreet3())
            {
                context.Writer.WriteTextString("Street3");
                context.Writer.WriteTextString(requestObject.Street3);
            }
            if (requestObject.IsSetType())
            {
                context.Writer.WriteTextString("Type");
                context.Writer.WriteTextString(requestObject.Type);
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AddressMarshaller Instance = new AddressMarshaller();

    }
}