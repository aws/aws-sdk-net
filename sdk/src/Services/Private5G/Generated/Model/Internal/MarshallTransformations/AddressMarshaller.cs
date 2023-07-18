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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Private5G.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Private5G.Model.Internal.MarshallTransformations
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
            if(requestObject.IsSetCity())
            {
                context.Writer.WritePropertyName("city");
                context.Writer.Write(requestObject.City);
            }

            if(requestObject.IsSetCompany())
            {
                context.Writer.WritePropertyName("company");
                context.Writer.Write(requestObject.Company);
            }

            if(requestObject.IsSetCountry())
            {
                context.Writer.WritePropertyName("country");
                context.Writer.Write(requestObject.Country);
            }

            if(requestObject.IsSetEmailAddress())
            {
                context.Writer.WritePropertyName("emailAddress");
                context.Writer.Write(requestObject.EmailAddress);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetPhoneNumber())
            {
                context.Writer.WritePropertyName("phoneNumber");
                context.Writer.Write(requestObject.PhoneNumber);
            }

            if(requestObject.IsSetPostalCode())
            {
                context.Writer.WritePropertyName("postalCode");
                context.Writer.Write(requestObject.PostalCode);
            }

            if(requestObject.IsSetStateOrProvince())
            {
                context.Writer.WritePropertyName("stateOrProvince");
                context.Writer.Write(requestObject.StateOrProvince);
            }

            if(requestObject.IsSetStreet1())
            {
                context.Writer.WritePropertyName("street1");
                context.Writer.Write(requestObject.Street1);
            }

            if(requestObject.IsSetStreet2())
            {
                context.Writer.WritePropertyName("street2");
                context.Writer.Write(requestObject.Street2);
            }

            if(requestObject.IsSetStreet3())
            {
                context.Writer.WritePropertyName("street3");
                context.Writer.Write(requestObject.Street3);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AddressMarshaller Instance = new AddressMarshaller();

    }
}