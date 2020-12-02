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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CustomerProfiles.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
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
            if(requestObject.IsSetAddress1())
            {
                context.Writer.WritePropertyName("Address1");
                context.Writer.Write(requestObject.Address1);
            }

            if(requestObject.IsSetAddress2())
            {
                context.Writer.WritePropertyName("Address2");
                context.Writer.Write(requestObject.Address2);
            }

            if(requestObject.IsSetAddress3())
            {
                context.Writer.WritePropertyName("Address3");
                context.Writer.Write(requestObject.Address3);
            }

            if(requestObject.IsSetAddress4())
            {
                context.Writer.WritePropertyName("Address4");
                context.Writer.Write(requestObject.Address4);
            }

            if(requestObject.IsSetCity())
            {
                context.Writer.WritePropertyName("City");
                context.Writer.Write(requestObject.City);
            }

            if(requestObject.IsSetCountry())
            {
                context.Writer.WritePropertyName("Country");
                context.Writer.Write(requestObject.Country);
            }

            if(requestObject.IsSetCounty())
            {
                context.Writer.WritePropertyName("County");
                context.Writer.Write(requestObject.County);
            }

            if(requestObject.IsSetPostalCode())
            {
                context.Writer.WritePropertyName("PostalCode");
                context.Writer.Write(requestObject.PostalCode);
            }

            if(requestObject.IsSetProvince())
            {
                context.Writer.WritePropertyName("Province");
                context.Writer.Write(requestObject.Province);
            }

            if(requestObject.IsSetState())
            {
                context.Writer.WritePropertyName("State");
                context.Writer.Write(requestObject.State);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AddressMarshaller Instance = new AddressMarshaller();

    }
}